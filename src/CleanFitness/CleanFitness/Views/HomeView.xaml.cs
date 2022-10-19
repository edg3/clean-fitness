using CleanFitness.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CleanFitness.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentView
    {
        public HomeView()
        {
            InitializeComponent();

            var source = new HtmlWebViewSource()
            {
                Html = CF.VML.HomeVM.StatsView
            };
            webStatview.Source = source;
        }
    }
}