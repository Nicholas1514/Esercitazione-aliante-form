using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_form
{
    public interface IComposite
    {
        void Aggiunta(IComposite composite);
        void Rimuovi(int indice);
        IComposite GetChild(int indice);
        bool Equals(object obj);
        string ToString();
        double Prezzo();
    }
}
