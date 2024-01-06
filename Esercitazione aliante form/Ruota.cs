using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
	public class Ruota:IComposite
	{
        private Gomma _gomma;
        private Cerchione _cerchione;

        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }

        public Ruota()
        {
            Gomma = new Gomma();
            Cerchione = new Cerchione();
        }

        public Ruota(Cerchione cerchione, Gomma gomma)
        {
            Cerchione = cerchione;
            Gomma = gomma;
        }

        public Ruota(Ruota vRuota)
        {
            Gomma = vRuota.Gomma;
            Cerchione = vRuota.Cerchione;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruota) || obj == null)
            {
                return false;
            }

            Ruota altro = (Ruota)obj;
            return Gomma == altro.Gomma && Cerchione == altro.Cerchione;
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
            return $"Dettagli gomma: {Gomma}; Dettagli cerchioni: {Cerchione}";
        }

        public double Prezzo()
        {
            return 0;
        }
    }
}
