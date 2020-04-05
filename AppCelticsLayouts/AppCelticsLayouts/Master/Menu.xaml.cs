using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCelticsLayouts.Model;

namespace AppCelticsLayouts.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        public static Player CelticsPlayer(string name, int age, string birthDate)
        {
            Player player = new Player { Name = name, Age = age, BirthDate = birthDate };
            return player;
        }
        private void GoCelticsPage(object sender, EventArgs args)
        {            
            Detail = new Pages.Celtics();
        }
        private void GoRondoPage(object sender, EventArgs args)
        {
            CelticsPlayer("Rajon Rondo", 34, "22/02/1986");
            Detail = new Pages.Profile();
        }
        private void GoPiercePage(object sender, EventArgs args)
        {
            CelticsPlayer("Paul Pierce", 42, "13/10/1977");
            Detail = new Pages.Profile();
        }
        private void GoGarnettPage(object sender, EventArgs args)
        {
            CelticsPlayer("Kevin Garnett", 43, "19/05/1976");
            Detail = new Pages.Profile();
        }
    }
}