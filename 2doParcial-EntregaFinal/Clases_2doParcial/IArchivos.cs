using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    internal interface IArchivos
    {
        bool Guardar(string path, List<Barco> lista);
        List<Barco> Leer(string path);
    }
}
