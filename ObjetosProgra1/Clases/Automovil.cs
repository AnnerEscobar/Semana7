using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using AxWMPLib;

namespace PlayerPrueba.Clases
{
    class Automovil
    {
        //Propiedades o atributos del objeto---------------------------------------------

        public string marca { get; }
        public string color { get; set; }

        public int vel_max { get; }
        private int velActual { get; set; }
        
        private bool encendido = false;

        //Constructor de la clase-------------------------------------------------------

        public Automovil(string marca, string color, int vel_max)
        {
            this.marca = marca;
            this.color = color;
            this.vel_max = vel_max;

        }

        //Funcion para encender el automovil-------------------------------------------

        public string encenderAutomovil()
        {
            try
            {
                if (encendido == true)
                {
                    return "El automovil se encuentra encendido ";

                }
                else
                {
                    encendido = true;
                    velActual = 0;
                    return "Listo!!! Auto encendido ";
                }
            }catch(Exception ex)
            {
                return "Debes encender el vehiculo";
            }
        }

        //Funcion que verifica si el carro esta encendido-------------------------------

        public bool estaEncendido()
        {
            return encendido;
        }

        //funcion para acelerar------------------------------------------------------------

        public string Acelerar()
        {
           
            if (velActual >= vel_max)
            {
                return "Esta es la velocidad maxima ";
            }
            else if(velActual <= 10)
            {
                velActual += 5;
                return $"Vas a: {velActual} Kh/ph\nPRIMERA MARCHA";
            }else if(velActual <=20)
            {
                velActual += 5;
                return $"Vas a: {velActual} Kh/ph\nSEGUNDA MARCHA";
            }
            else if (velActual <=40 )
            {
                velActual += 5;
                return $"Vas a: {velActual} Kh/ph\nTERCER MARCHA";
            }
            else if (velActual <= 60)
            {
                velActual += 5;
                return $"Vas a: {velActual} Kh/ph\nCUARTA MARCHA";
            }
            else 
            {
                velActual += 5;
                return $"Vas a: {velActual} Kh/ph\nPRECAUCION QUINTA MARCHA";
            }

        }

        //Funcion para frenar ----------------------------------------------------

        public string Frenar()
        {
            
            if (velActual == 0)
            {
                return "El auto se ha detenido\npor completo";
            }
            else
            {
                velActual -= 5;
                return $"Vas a una velocidad de\n{velActual} Kh/Ph ";
            }

           
        }
        


        //Funcion para apagar-------------------------------------------------------

        public string Apagar()
        {
            if (velActual == 0)
            {
                encendido = false;
                return " Presiona otra vez para apagar ";

            }
            else
            {
                return " El auto no se puede apagar en movimiento ";
            }
        }

        //Funcion para tocar el claxon--------------------------------------------------------

        public void Claxon()
        {
            SoundPlayer sonido;

            sonido = new SoundPlayer(@"C:\Users\anner\source\repos\objetoProgra1\objetoProgra1\bin\Debug\Sonidos\Sonido.wav");
            sonido.Play();

        }
       
        
    }
}
