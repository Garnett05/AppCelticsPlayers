using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCelticsLayouts.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void GoCelticsPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Profile());
        }
        private void GoProfilePage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Celtics());
        }
    }
}