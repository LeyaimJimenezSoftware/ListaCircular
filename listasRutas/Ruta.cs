using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasRutas
{
    class Ruta
    {

        private Base primero;
        private Base ultimo;
        string recorridos;

        public Ruta(){
            primero = null;
            ultimo = null;
            
                  }

        public void agregar(Base nuevaBase)
        {
            //Base encontrado = buscar(nuevaBase.nombre);
            if (primero == null && ultimo == null)
            {
                primero = nuevaBase;
                nuevaBase.siguiente = primero;
            }

            
            else /*if (encontrado == null) */
            {
                Base temporal = primero;
              
               
                while (temporal.siguiente != primero)
                {
                    temporal = temporal.siguiente;

                }

                temporal.siguiente = nuevaBase;
                nuevaBase.siguiente = primero;
            }
              
        }
        public void agregarInicio(Base nuevaBase)
        {
            Base temporal = primero;
            if (primero == null && ultimo == null)
            {
                primero = nuevaBase;
                nuevaBase.siguiente = primero;
            }
            else
            {

                while (temporal.siguiente != primero)
                {
                    temporal = temporal.siguiente;

                }
                nuevaBase.siguiente = primero;
                primero = nuevaBase;
                temporal.siguiente = primero;

            }
         }
        public void eliminarProducto(string nombre)
        {

            bool encontrado = false;
            Base temporal = primero;
            if (temporal.nombre == nombre)
            {
                primero = temporal.siguiente;
                encontrado = true;
            }


            while (temporal != null && encontrado != true)
            {


                if (temporal.siguiente.nombre == nombre)
                {


                    temporal.siguiente = temporal.siguiente.siguiente;

                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }
            }

        }

        public Base buscar(string nombre)
        {

            Base buscado = null;
            bool encontrado = false;
            Base temporal = primero;


            while (temporal != null && encontrado != true)
            {
                if (temporal.nombre == nombre)
                {
                    buscado = temporal;
                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }
            }




            return buscado;
        }

        public string recorrido(string nombre ,int horaInicio,int horaFin)
        {
            DateTime dato = DateTime.Now;
            double hora , hFinal;
            Base temporal = buscar(nombre);
            DateTime HoraInicio = new DateTime(dato.Year, dato.Month, dato.Day, horaInicio, dato.Minute, dato.Second);
            DateTime HoraFinal = new DateTime(dato.Year, dato.Month, dato.Day, horaFin, dato.Minute, dato.Second);
            hora = 0;
            DateTime temporaltime = HoraInicio;

            hFinal = horaFin;

            if (horaInicio <= 12)
            {
                while (hora < HoraFinal.Hour)
                {

                    hora += temporal.minutos;
                    recorridos += " " + temporal.nombre + ":" + HoraInicio.AddHours(hora) + "\r\n";

                    temporal = temporal.siguiente;
                }
            }
            else if (horaInicio > 12)
            {
                hora = horaInicio;
                while (hora < hFinal)
                {

                    hora += temporal.minutos;
                    recorridos += " " + temporal.nombre + ":" + HoraInicio.AddHours(hora) + "\r\n";

                    temporal = temporal.siguiente;
                }
            }

            return "" + HoraInicio + " - " + HoraInicio.AddHours(hora) + "\r\n " + recorridos+"\r\n";
        }

        public void insertarBase(Base nueva, string nombre)
        {
            if (primero.nombre == nueva.nombre)
            {
                nueva.siguiente = primero;
                primero = nueva;
            }
            else
            {
              Base temporal = buscar(nombre);
                nueva.siguiente = temporal.siguiente;
                temporal.siguiente = nueva;
            }

        }

        public override string ToString()
        {
            string str = " ";

            Base t = primero;

            while (t.siguiente != primero)
            {

                str += t.ToString();
                t = t.siguiente;

            }
            str += t.ToString();
            return str;



        }

    }
}
