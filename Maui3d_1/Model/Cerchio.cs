using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui3d_1.Model
{
    public class Cerchio
    {
        private double raggio;
        public double Raggio
        {
            get { return raggio; }
            set
            {
                if (value > 0)
                {
                    raggio = value;
                }
                else
                {
                    throw new Exception("Il raggio deve essere un numero positivo");
                }
            }
        }
        
        public Cerchio() 
        {
            raggio = 1;
        }

        public double AreaCerchio()
        {
            double risultato;
            risultato = Math.PI * Math.Pow(Raggio, 2);
            return risultato;

        }
        public double Circonferenza() 
        {
            double risultato;
            risultato = 2 * Math.PI * Raggio;
            return risultato;
        }

    }
}
