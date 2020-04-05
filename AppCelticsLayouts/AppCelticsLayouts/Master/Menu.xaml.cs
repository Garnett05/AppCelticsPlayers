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
            Detail = new Pages.Celtics();
        }
        private void GoRondoPage(object sender, EventArgs args)
        {            
            Detail = new Pages.Profile();
        }
        private void GoPiercePage(object sender, EventArgs args)
        {            
            Detail = new Pages.Profile();
        }
        private void GoGarnettPage(object sender, EventArgs args)
        {            
            Detail = new Pages.Profile();
        }
    }
}