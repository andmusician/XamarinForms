using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBar();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new Controles.BoxView();
        }
    }
}