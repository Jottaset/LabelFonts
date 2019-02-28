using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelFonts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random random = new Random();

        void MudarFonte(object sender, EventArgs args)
        {
            string[] conteudo = { "Laila-SemiBold.ttf#Laila-SemiBold.ttf",
                                  "Srisakdi-Regular.ttf#Srisakdi-Regular.ttf",
                                  "Pacifico-Regular.ttf#Pacifico-Regular.ttf",
                                   "Lobster-Regular.ttf#Lobster-Regular"};
                                   
            Label_02.FontFamily = conteudo[random.Next(0, (conteudo.Length - 1))];

            Label_01.FontFamily = conteudo[random.Next(0, (conteudo.Length - 1))];

            Label_03.FontFamily = conteudo[random.Next(0, (conteudo.Length - 1))];
        }
    }
}
