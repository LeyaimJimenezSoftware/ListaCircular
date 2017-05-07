using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasRutas
{
    class Base
    {
        private string _nombre;
        private double _minutos;
        private Base _siguiente;

        public Base (string nombre,double minutos)
        {
            this.nombre = nombre;
            this.minutos = minutos;
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double minutos
        {
            get { return _minutos; }
            set { _minutos = value; }
        }
        public Base siguiente
        {
            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }
        }

        public override string ToString()
        {
            return "Nombre de la base: " + nombre + " minutos para llegar a la base: " + minutos+ "\r\n" + "\r\n";
        }



    }
}
