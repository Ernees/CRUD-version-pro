using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public class Herencia1 : Empleado
    {
        #region Atributos
        private double salarioBase;
        #endregion

        #region Propiedades
        //Implementar Excepciones
        public double SalarioTotal
        {
            get
            {
                return CalcularSalario();
            }
        }
        public double SalarioBase
        {
            get => salarioBase;
            set
            {
            //    if (value < 0 || value > 500000)
            //    {
            //        throw new DatoInvalidoException("Intento ingresar un sueldo fuera de rango", value.ToString());
            //    }
                salarioBase = value;
            }
        }
        #endregion

        #region Constructores
        public Herencia1(int id, string nombre, string apellido, int edad, string departamento, double salarioBase)
            : base(nombre, apellido, edad, departamento)
        {
            this.salarioBase = salarioBase;
        }
        #endregion

        #region Metodos
        // Métodos sobrescritos
        protected double CalcularSalario()
        {
            return this.SalarioBase + (this.SalarioBase * 0.5f);
        }


        #endregion
    }
}
