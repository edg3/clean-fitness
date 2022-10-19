using Android.Graphics;
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
    // FileName => FilePath
    private Dictionary<string, string> _BaseImagesDict = null;
    // Currently: only puts it in memory while I decide interaction for the data inserting implementation at start
    private async Task<bool> DownloadMyFoodData()
    {
        var downloadedFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "MyFoodData.zip");
        if (File.Exists(downloadedFilePath))
        {
            var finfo = new FileInfo(downloadedFilePath);
            if (finfo.Length == 1471207)
            {
                using (var localFile = File.OpenRead(downloadedFilePath))
                {
                    if (ProcessCaloriesFile(localFile)) return await DownloadDefaultImages();
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
            return await DownloadDefaultImages();
        }

        return false;
    }

    private async Task<bool> DownloadDefaultImages()
    {
        var downloadedFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Images.zip");
        if (File.Exists(downloadedFilePath))
        {
            var finfo = new FileInfo(downloadedFilePath);
            if (finfo.Length == 1)
            {
                using (var localFile = File.OpenRead(downloadedFilePath))
                {
                    if (ProcessImageDictionary(localFile)) return true;
                }
            }
        }

        var success = await DownloadFileAsync("https://edg3.co.za/dl/Images.zip", downloadedFilePath);

        if (success)
        {
            try
            {
                return ProcessImageDictionary(File.OpenRead(downloadedFilePath));
            }
            catch (Exception e)
            {
                var a = 1;
            }
        }

        return false;
    }
    private bool ProcessImageDictionary(FileStream localFile)
    {
        _BaseImagesDict = new Dictionary<string, string>();
        return true;
        using (var localZip = new ZipArchive(localFile, ZipArchiveMode.Read))
        {
            foreach (var localEntry in localZip.Entries)
            {
                using (var openEntry = localEntry.Open())
                {
                    var filePath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), localEntry.Name);
                    _BaseImagesDict.Add(localEntry.Name, filePath);
                    if (!File.Exists(filePath))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            openEntry.CopyTo(memoryStream);

                            using (var writer = System.IO.File.Create(filePath))
                            {
                                byte[] bytesInStream = new byte[memoryStream.Length];
                                openEntry.Read(bytesInStream, 0, bytesInStream.Length);

                                writer.Write(bytesInStream, 0, bytesInStream.Length);
                                writer.Close();
                            }
                        }
                    }
                }
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

                                /* TODO: verify time taken on mobile device; 3s approx. on Desktop test */
                                var calorieData = new MBaseCalories()
                                {
                                    Name = currentSplit[1],
                                    CaloriesPer100g = double.Parse(currentSplit[3]),
                                    FatPer100g = double.Parse(currentSplit[4]),
                                    ProteinPer100g = double.Parse(currentSplit[5]),
                                    CarbohydratePer100g = double.Parse(currentSplit[6]),
                                    SugarsPer100g = double.Parse(currentSplit[7]),
                                    FiberPer100g = double.Parse(currentSplit[8]),
                                    CholesterolePer100g = double.Parse(currentSplit[9]),
                                    SaturatedFatsPer100g = double.Parse(currentSplit[10]),
                                    CalciumPer100g = double.Parse(currentSplit[11]),
                                    IronPer100g = double.Parse(currentSplit[12]),
                                    PotassiumPer100g = double.Parse(currentSplit[13]),
                                    MagnesiumPer100g = double.Parse(currentSplit[14]),
                                    VitaminAIUPer100g = double.Parse(currentSplit[15]),
                                    VitaminARAEPer100g = double.Parse(currentSplit[16]),
                                    VitaminCPer100g = double.Parse(currentSplit[17]),
                                    VitaminB12Per100g = double.Parse(currentSplit[18]),
                                    VitaminDPer100g = double.Parse(currentSplit[19]),
                                    VitaminEPer100g = double.Parse(currentSplit[20]),
                                    Omega3sPer100g = double.Parse(currentSplit[24]),
                                    Omega6sPer100g = double.Parse(currentSplit[25]),
                                    SucrosePer100g = double.Parse(currentSplit[30]),
                                    GlucosePer100g = double.Parse(currentSplit[31]),
                                    FructosePer100g = double.Parse(currentSplit[32]),
                                    LactosePer100g = double.Parse(currentSplit[33]),
                                    MaltosePer100g = double.Parse(currentSplit[34]),
                                    GalactosePer100g = double.Parse(currentSplit[35]),
                                    StarchPer100g = double.Parse(currentSplit[36]),
                                    ChlorinePer100g = double.Parse(currentSplit[46]),
                                    VitaminB6Per100g = double.Parse(currentSplit[51]),
                                    VitaminD2Per100g = double.Parse(currentSplit[64]),
                                    VitaminD3Per100g = double.Parse(currentSplit[65]),
                                    VitaminDIUPer100g = double.Parse(currentSplit[66]),
                                    VitaminKPer100g = double.Parse(currentSplit[67]),
                                    AlcoholPer100g = double.Parse(currentSplit[95]),
                                    CaffeinePer100g = double.Parse(currentSplit[96]),
                                    WaterPer100g = double.Parse(currentSplit[22]),
                                    SodiumPer100g = double.Parse(currentSplit[39]),
                                    ZincPer100g = double.Parse(currentSplit[40]),
                                    FolicAcidPer100g = double.Parse(currentSplit[54]),
                                    FattyAcidsTotalMonosaturatedPer100g = double.Parse(currentSplit[70]),
                                    FattyAcidsTotalPolyunsaturatedPer100g = double.Parse(currentSplit[71])
                                };
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
                CF.Popup("Complete", "We've got all the calories data in memory ready to import into the database when we create it for ourselves.", "Yay!");
            }
            else
            {
                _BaseImportList?.Clear();
                _BaseImportList = null;
                CF.Popup("Oh dear", "There seems to have been a problem...", "I'll try again later...");
            }
        }
        else
        {
            CF.Popup("Oops...", "You've already loaded the data from the web...", "Ok");
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
    public double Height { get; set; } = 50;
    public double Weight { get; set; } = 50;
    public int Age { get; set; } = 50;

    private bool IsFirstNameCheck = true;
    public Command CreateDatabase => new Command(async () =>
    {
        if (IsFirstNameCheck && Name.Trim().Length == 0)
        {
            IsFirstNameCheck = false;
            await MainPage.I.DisplayAlert("Note", "You don't have to fill in these details if you don't want to, you can change them for yourself later whenever you want to. Just note the calculations won't be completely correct for suggestions, and reports wont be linked to you. If you click 'Create' again it will continue, you won't see this message again.", "Ok");
        }
        else
        {
            if (Height < 0) Height = 1;
            if (Weight < 0) Weight = 1;
            if (Age < 0) Age = 1;
            await MainPage.I.DisplayAlert("Note", "Please wait, the database will be created after you press 'Ok'. Don't force close the app.", "Ok");
            DB.I.Create(_BaseImportList, _BaseImagesDict, Name, Height, Weight, Age);
            _personalInformationSetup = false;
            File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "MyFoodData.zip"));
            File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Images.zip"));
            await MainPage.I.DisplayAlert("Note", "Done! You can now use Simple Fitness.", "Ok");
            CF.Nav.GoTo(NavLocation.Home);
        }
    });

    /// <summary>
    /// General functions
    /// </summary>
    private Command _importDB;
    public Command ImportDB => _importDB ??= new Command(async () =>
    {
        DB.I.ImportDB();
        await MainPage.I.DisplayAlert("Done", "Supposed DB imported!", "Ok");
        CF.Nav.GoTo(NavLocation.Home);
    });

    public void CleanData()
    {
        _BaseImportList?.Clear();
    }

    public void LoadData()
    {

    }
}
