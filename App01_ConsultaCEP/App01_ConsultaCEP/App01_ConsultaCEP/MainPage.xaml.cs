using System;
using System.ComponentModel;
using Xamarin.Forms;
using App01_ConsultaCEP.Service.Model;
using App01_ConsultaCEP.Service;

namespace App01_ConsultaCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs e)
        {
            string cep = CEP.Text.Trim();

            if (isValidCep(cep))
            {
                Endereco end = ViaCEPService.BuscarEnderecoViaCep(cep);

                RESULTADO.Text = string.Format("Endereço: {0}, {1}, {2}", end.Logradouro, end.Localidade, end.UF);
            }            
        }

        private bool isValidCep(string cep)
        {
            var isValid = true;

            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP Inválido! O Cep deve conter 8 caracteres.", "OK");

                isValid = false;
            }           

            if(!int.TryParse(cep, out _))
            {
                DisplayAlert("ERRO", "CEP Inválido! O Cep deve conter apenas numeros.", "OK");

                isValid = false;
            }
            
            return isValid;
        }
    }
}
