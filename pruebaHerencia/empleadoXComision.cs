using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaHerencia
{
    public class empleadoXComision : Object
    {

        private string _PrimerNombre;
        private decimal _ventasBrutas;
        private string _numSeguroSocial;
        private decimal _tarifaComision;
        private string _apelllidoPaterno;

        public empleadoXComision(string nombre, string apellido,string nss, decimal tarifa, decimal venta)
        {

            _PrimerNombre = nombre;
            _apelllidoPaterno = apellido;
            _numSeguroSocial = nss;
            _tarifaComision = tarifa;
            _numSeguroSocial = nss;

        }

        public string nombre
        {
            get
            {
                return _PrimerNombre;
            }
        }
        public string apellido
        {
            get
            {
                return _apelllidoPaterno;
            }
        }
        public decimal tarifaComision
        {
            get
            {
                return _tarifaComision;
            }
            set
            {
                tarifaComision = (value > 0 && value <1)? value : 0;
            }
        }
        public decimal ventasBrutas
        {
            get
            {
                return _ventasBrutas;
            }
            set
            {
                tarifaComision =(value < 0 )? value : 0;
            }
        }

        public virtual decimal ingresos()
        {
            return _tarifaComision * ventasBrutas;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}{2}\n{3}: {4}\n " +
                "{5}: {6:C})\n{7}:{8:F2}", "empleado por comision",
                _PrimerNombre, _apelllidoPaterno,"numero de seguro social",
                _numSeguroSocial,"ventas brutas", _ventasBrutas,
                "tarifa por Comision", _tarifaComision);
        }
    }
}
