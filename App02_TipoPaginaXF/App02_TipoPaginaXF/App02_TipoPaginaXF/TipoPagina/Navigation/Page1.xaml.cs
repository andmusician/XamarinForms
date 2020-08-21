using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void MudarParaPagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ChamarModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Master.Master();
        }
    }
}