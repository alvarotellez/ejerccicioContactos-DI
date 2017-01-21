using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_copiaContacto
{
    public class clsListado
    {
        public ObservableCollection<clsPersona> getListado()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();

            lista.Add(new clsPersona(1, "Alvaro", "Tellez", DateTime.Now, "Moron", "656456782"));
            lista.Add(new clsPersona(2, "David", "Benitez", DateTime.Now, "Dos Hermanas", "656456782"));
            lista.Add(new clsPersona(3, "Merecedes", "Requena", DateTime.Now, "Sevilla", "656456782"));
            lista.Add(new clsPersona(4, "Jose Antonio", "Ruiz", DateTime.Now, "Carmona", "656456782"));
            lista.Add(new clsPersona(5, "Daniel", "Leal", DateTime.Now, "Mairena", "656456782"));
            lista.Add(new clsPersona(6, "Migue", "Barrera", DateTime.Now, "Sevilla", "656456782"));
            lista.Add(new clsPersona(7, "Carlos", "Prieto", DateTime.Now, "Dos Hermanas", "656456782"));
            lista.Add(new clsPersona(8, "Adri", "Pol", DateTime.Now, "Moron", "656456782"));

            return lista;
        }
    }
}
