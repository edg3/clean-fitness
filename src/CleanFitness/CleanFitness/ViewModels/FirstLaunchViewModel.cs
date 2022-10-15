using CleanFitness.Actions;
using CleanFitness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CleanFitness.ViewModels;

public class FirstLaunchViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Calories Data
    /// </summary>
    private bool _haventOpenedCaloriesData = true;
    public bool HaventOpenedCaloriesData
    {
        get => _haventOpenedCaloriesData;
        set
        {
            _haventOpenedCaloriesData = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HaventOpenedCaloriesData)));
        }
    }
    private List<MBaseCalories> _BaseImportList = null;
    // Currently: only puts it in memory while I decide interaction for the data inserting implementation at start
    private async Task<bool> DownloadMyFoodData()
    {
        var downloadedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "MyFoodData.zip");
        if (File.Exists(downloadedFilePath))
        {
            var finfo = new FileInfo(downloadedFilePath);
            if (finfo.Length == 1471207)
            {
                using (var localFile = File.OpenRead(downloadedFilePath))
                {
                    if (ProcessCaloriesFile(localFile)) return true;
                }
            }
        }

        var success = await DownloadFileAsync("https://edg3.co.za/dl/MyFoodDataCleaned.zip", downloadedFilePath);

        if (success)
        {
            try
            {
                using (var file = File.OpenRead(downloadedFilePath))
                {
                    if (!ProcessCaloriesFile(file)) return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        return false;
    }

    private bool ProcessCaloriesFile(FileStream localFile)
    {
        using (var localZip = new ZipArchive(localFile, ZipArchiveMode.Read))
        {
            foreach (var localEntry in localZip.Entries)
            {
                if (localEntry.Name == "MyFoodDataCleaned.csv")
                {
                    using (var stream = localEntry.Open())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            _BaseImportList = new List<MBaseCalories>();

                            var data = reader.ReadToEnd();
                            reader.Close();

                            var splitData = data.Split('\n');
                            var startingSplit = splitData[0].Split(',');
                            for (int i = 1; i < splitData.Length; ++i)
                            {
                                if (splitData[i].Length < 1) break;

                                var currentSplit = splitData[i].Split(',');

                                var calorieData = new MBaseCalories() { Name = currentSplit[1], CaloriesPer100g = double.Parse(currentSplit[3]) };
                                _BaseImportList.Add(calorieData);
                            }

                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    private async Task<bool> DownloadFileAsync(string fileUrl, string downloadedFilePath)
    {
        try
        {
            using var client = new HttpClient();
            var downloadStream = await client.GetStreamAsync(fileUrl);
            using var fileStream = File.Create(downloadedFilePath);
            await downloadStream.CopyToAsync(fileStream);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public Command RetrieveCaloriesData => new Command(async () =>
    {
        if (null == _BaseImportList)
        {
            var success = await DownloadMyFoodData();
            if (success)
            {
                PersonalInformationSetup = true;
                HaventOpenedCaloriesData = false;
                await MainPage.I.DisplayAlert("Complete", "We've got all the calories data in memory ready to import into the database when we create it for ourselves.", "Yay!");
            }
            else
            {
                _BaseImportList?.Clear();
                _BaseImportList = null;
                await MainPage.I.DisplayAlert("Oh dear", "There seems to have been a problem...", "I'll try again later...");
            }
        }
        else
        {
            await MainPage.I.DisplayAlert("Oops...", "You've already loaded the data from the web...", "Ok");
        }
    });

    /// <summary>
    /// Personal Information setup
    /// </summary>
    private bool _personalInformationSetup = false;
    public bool PersonalInformationSetup
    {
        get => _personalInformationSetup;
        set
        {
            _personalInformationSetup = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PersonalInformationSetup)));
        }
    }
    public string Name { get; set; } = "";

    /// <summary>
    /// General functions
    /// </summary>
    public void CleanData()
    {
        _BaseImportList.Clear();
    }

    public void LoadData()
    {

    }
}
