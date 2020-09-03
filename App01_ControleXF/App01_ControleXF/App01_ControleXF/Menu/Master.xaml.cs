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

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Detail = new Controles.Label();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new Controles.Button();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditor();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Detail = new Controles.DatePicker();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Detail = new Controles.TimePicker();
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Detail = new Controles.TableViewPage();
        }
    }
}