using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
    public class Fusoliera : IComposite
    {
        private double _lung;
        private string _materiale;

        public double Lung
        {
            get { return _lung; }
            set
            {
              _lung = value;
            }
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Fusoliera()
        {
            Lung = 0;
            Materiale = string.Empty;
        }

        public Fusoliera(double lung, string materiale)
        {
            Lung = lung;
            Materiale = materiale;
        }

        public Fusoliera(Fusoliera vFusoliera)
        {
            Lung = vFusoliera.Lung;
            Materiale = vFusoliera.Materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera altro = (Fusoliera)obj;
            return Lung == altro.Lung && Materiale == altro.Materiale;
        }

        public void Aggiunta(IComposite composite)
        {
            throw new NotImplementedException();
        }

        public IComposite GetChild(int indice)
        {
            throw new NotImplementedException();
        }

        public double Prezzo()
        {
            return Lung * 30;
        }

        public void Rimuovi(int indice)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lunghezza fusoliera: {Lung}; Materiale fusoliera: {Materiale}";
        }


    }
}
