using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maui3d_1.ViewModel
{
    public class CerchioViewModel : DatiBind
    {
        private double raggioCirconferenza;
        public double RaggioCirconferenza
        {
            get { return raggioCirconferenza; }
            set
            {
                if (raggioCirconferenza != value)

                    raggioCirconferenza = value;
                OnPropertyChanged(nameof(RaggioCirconferenza)); //Aggiorno la proprietà

            }
        }

        public Command FaiQualcosa =>
            new Command(() => { CalcoloArea(); });

        public async void CalcoloArea()
        {
            double risultato;
            risultato = Math.PI*Math.Pow(raggioCirconferenza, 2);
            await App.Current.MainPage.DisplayAlert("Area Cerchio", risultato.ToString(), "OK");
        }

    }
}
