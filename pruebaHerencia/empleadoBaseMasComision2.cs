using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaHerencia
{
    public class empleadoBaseMasComision2 : empleadoXComision
    {

        private decimal SalarioBase;
        public empleadoBaseMasComision2(string nombre, string apellido,
            string nss, decimal tarifa, decimal venta, decimal Salario) 
            : base(nombre, apellido, nss, tarifa, venta)
        {
            SalarioBase = Salario;
        }
    public decimal salarioBase
        {
            get
            {
                return SalarioBase;
            }
            set
            {
                salarioBase = (value <0)? 0 : value;
            }
        }

        public override decimal ingresos()
        {
            return salarioBase+ base.ingresos();
    }

        public override string ToString()
        {
           return String.Format("{0} {1} \n{2}: {3:C}", 
               "salario base +" , base.ToString(),
                "salariobAse", salarioBase);
        }
    }
    
}
