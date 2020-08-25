using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditor : ContentPage
    {
        public EntryEditor()
        {
            InitializeComponent();

            txt_Idade.TextChanged += delegate (object sender,  TextChangedEventArgs args)
            {
                Lbl_Duplicado.Text = args.NewTextValue;
            };

            Comentario.Completed += delegate (object sender,  EventArgs args)
            {
                LblQuandidadeCaracteres.Text = Comentario.Text.Length.ToString();
            };
        }
    }
}