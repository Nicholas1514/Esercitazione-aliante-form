using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
	public class Ala: IComposite
	{
		private double _lu;
		private double _ap;

		public double Lu
		{
			get { return _lu; }
			set { _lu = value; }
		}

		public double Ap
		{
			get { return _ap; }
			set { _ap = value; }
		}

		public Ala()
		{
			Ap = 0;
			Lu = 0;
		}

		public Ala(double lu, double ap)
		{
			Lu = lu;
			Ap = ap;
		}

		public Ala(Ala vala)
		{
			Lu = vala.Lu;
			Ap = vala.Ap;
		}

        public void Aggiunta(IComposite composite)
        {
            throw new NotImplementedException();
        }

        public void Rimuovi(int indice)
        {
            throw new NotImplementedException();
        }

        public IComposite GetChild(int indice)
        {
            throw new NotImplementedException();
        }

        public double Prezzo()
        {
            return Ap * Lu;
        }

        public override string ToString()
        {
			return $"Lunghezza: {Lu} + Apertura: {Ap}";
        }
    }
}
