using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
	public class Aliante
	{
		public Ala Ala { get; set; }
		public Fusoliera Fusoliera { get; set; }
		public Coda Coda { get; set; }
		
		public Aliante()
		{
			Ala = null;
			Fusoliera = null;
			Coda = null;
		}
		public Aliante(Ala ala, Fusoliera fus, Coda coda)
		{
		  Ala = ala;
			Fusoliera = fus;
			Coda = coda;
		}

		public virtual string Descrizione()
		{
			return $"Ala: {Ala} + Fusoliera: {Fusoliera} + Coda: {Coda}";
		}
	}

}
