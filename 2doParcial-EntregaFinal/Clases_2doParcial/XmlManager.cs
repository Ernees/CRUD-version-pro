using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_2doParcial
{
    public class XmlManager: IArchivos
    {
        public bool Guardar(string path, List<Barco> lista)
        {
            bool retorno;
            retorno = false;
            //try
            //{
            if(lista!=null)
            {

                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Barco>));
                    ser.Serialize(sw, lista);
                }
                retorno = true;
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            return retorno;
        }

        public List<Barco> Leer(string path)
        {
            List<Barco> lista = null;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<Barco>));
                    lista = (List<Barco>)des.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
