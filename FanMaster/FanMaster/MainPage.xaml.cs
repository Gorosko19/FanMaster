using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FanMaster
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            heroes.ItemsSource = Menulist();
            var StartPage = typeof(funkt.heroess);
            Detail = new NavigationPage((Page)Activator.CreateInstance(StartPage));
            IsPresented = false;
        }

        private List<klas> Menulist()
        {
            var herolist = new List<klas>();
            herolist.Add(new klas()
            {
                Text = "Персонажи",
                ImageP = "Persi.PNG",
                TarPage = typeof(funkt.heroess)
            });

            herolist.Add(new klas()
            {
                Text = "Основные фракции",
                ImageP = "Frakcii.PNG",
                TarPage = typeof(funkt.opisanie)
            });

            herolist.Add(new klas()
            {
                Text = "Области",
                ImageP = "karta.PNG",
                TarPage = typeof(funkt.opisanie)
            });
            return herolist;

        }

        private void heroes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (klas)e.SelectedItem;
            Type selectedpage = selecte.TarPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}

