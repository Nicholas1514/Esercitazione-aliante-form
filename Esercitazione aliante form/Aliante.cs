using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
	public class Aliante : IComposite
	{
		private List<IComposite> _componenti;

		public List<IComposite> Composites
		{
			get { return _componenti; }
			set { _componenti = value; }
		}

		public Aliante()
		{
			Composites = new List<IComposite>();
		}

		public Aliante(Aliante vAliante)
		{
			Composites = vAliante.Composites;
		}

		public Aliante(List<IComposite> componenti)
		{
			Composites = componenti;
		}

		public void Aggiunta(IComposite componenti)
		{
			Composites.Add(componenti);
		}

		public void Rimuovi(int indice)
		{
			Composites.RemoveAt(indice);
		}

		public IComposite GetChild(int indice)
		{
			return Composites[indice];
		}

		public override string ToString()
		{
			string s = "";
			foreach(var componenti in Composites)
			{
				s += componenti.ToString();
			}
			return s;
		}

		public double Prezzo()
		{
			double totale = 0;
			foreach(var componenti in Composites)
			{
				totale += componenti.Prezzo();
			}

			return totale;
		}

		public override bool Equals(object obj)
		{
			if(!(obj is Aliante) || obj == null)
			{
				return false;
			}
			Aliante altro = (Aliante)obj;
			if(Composites.Count != altro.Composites.Count)
			{
				return false;
			}

			for(int i = 0; i < Composites.Count; i++)
			{
				if (!Composites[i].Equals(altro.Composites[i]))
				{
					return false;
				}
			}

			return true;
		}
	}

}
