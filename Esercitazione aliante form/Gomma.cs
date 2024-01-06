using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
    public class Gomma : IComposite
    {
        private double _alt;
        private double _larg;
        private double _raggio;

        public double Alt
        {
            get { return _alt; }
            set
            {
             _alt = value;
            }
        }

        public double Larg
        {
            get { return _larg; }
            set
            {
             _larg = value;
            }
        }

        public double Raggio
        {
            get { return _raggio; }
            set {_raggio = value; }
        }

        public Gomma()
        {
            Alt = 0;
            Larg = 0;
            Raggio = 0;
        }

        public Gomma(double alt, double larg, double raggio)
        {
            Alt = alt;
            Larg = larg;
            Raggio = raggio;
        }

        public Gomma(Gomma vGomma)
        {
            Alt = vGomma.Alt;
            Larg = vGomma.Larg;
            Raggio = vGomma.Raggio;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Gomma) || obj == null)
            {
                return false;
            }

            Gomma altro = (Gomma)obj;
            return Alt == altro.Alt && Larg == altro.Larg && Raggio == altro.Raggio;
        }

        public void Aggiunta(IComposite component)
        {

        }

        public void Rimuovi(int index)
        {

        }

        public IComposite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Altezza: {Alt}; Larghezza: {Larg}; Raggio: {Raggio}";
        }

        public double Prezzo()
        {
            return Alt * Larg * Raggio * 10;
        }
    }
}

