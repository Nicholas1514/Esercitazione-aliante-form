using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
	public class Coda:IComposite
	{
        private double _lung;

        public double Lung
        {
            get { return _lung; }
            set
            {
              
                    _lung = value;
             
                    _lung = 8F;
            }
        }

        public Coda()
        {
            Lung = 0;
        }

        public Coda(double lung)
        {
            Lung = lung;
        }

        public Coda(Coda vCoda)
        {
            Lung = vCoda.Lung;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda altro = (Coda)obj;
            return Lung == altro.Lung;
        }

        public void Aggiunta(IComposite component)
        {
            throw new NotImplementedException();
        }

        public void Rimuovi(int index)
        {
            throw new NotImplementedException();
        }

        public IComposite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Lunghezza coda: {Lung}";
        }

        public double Prezzo()
        {
            return Lung * 30;
        }
    }
}

