using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace AppListaSite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> sites = new List<string>
        {
            "db4free.net","youtube.com","globoplay.globo.com","w3schools.com","luizbarueri.com.br"
        };
        public MainPage()
        {
            InitializeComponent();
            ListaSites.ItemsSource = sites;
        }

        private void SeachSites_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = SeachSites.Text;
            ListaSites.ItemsSource = sites.Where(x => x.ToLower().Contains(texto));
        }
    }
}
