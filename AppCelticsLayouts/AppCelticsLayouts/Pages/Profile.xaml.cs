using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCelticsLayouts.Master;
using AppCelticsLayouts.Model;

namespace AppCelticsLayouts.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            Player play = new Player();
            play.Name = 
            InitializeComponent();
        }
    }
}