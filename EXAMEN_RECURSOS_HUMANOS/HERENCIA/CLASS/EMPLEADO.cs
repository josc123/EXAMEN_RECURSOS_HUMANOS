using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    public class EMPLEADO : PERSONA
    {
        // ATRIBUTO
        private string TIPODECONTRATO;
        private Double SUELDO;
        private string TIPO;
        private String CEDULA;

        //PROPIEDADES 

        public string TIPODECONTRATO1
        {
            get => TIPODECONTRATO; 
            set => TIPODECONTRATO = value; 
        }
        public string TIPO1
        {
            get => TIPO; 
            set => TIPO = value;
        }
        public double SUELDO1
        { 
            get => SUELDO;
            set => SUELDO = value;
        }
        public string CEDULA1
        {
            get => CEDULA;
            set => CEDULA = value;
        }

        //PROCEDIMIENTOS
        public void CALCULARSUELDO(double SUELDOBASICO)
        {
            if (this.TIPO1 == "GERENTE")
            {
                if (this.TIPODECONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASICO + 350;
                }
                else if (this.TIPODECONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * SUELDOBASICO + 700;
                }
             
            }
            else if (this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPODECONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASICO + 350;
                }
                else if (this.TIPODECONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASICO + 700;
                }
            }
            else
            {
                this.SUELDO1 = 0;
            }
        }
    }
}
