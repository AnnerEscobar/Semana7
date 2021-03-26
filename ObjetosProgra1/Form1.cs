using PlayerPrueba.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerPrueba
{
    public partial class velocidad : Form
    {

        Automovil carro;

        public velocidad()
        {
            InitializeComponent();
        }

        //Boton para crear el carro----------------------------------------------------------------------------------------

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            carro = new Automovil("Jeep", "Negro", 100);

            labelColor.Text = carro.color;
            labelMarca.Text = carro.marca;
        }

        //Boton para encender el automovil-----------------------------------------------------------------------------

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            try
            {
                labelEncender.Text = carro.encenderAutomovil();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No has creado ningun carro ");
            }
        }

        //Boton para Acelerar el carro--------------------------------------------------------------------------------

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    labelAcelerar.Text = carro.Acelerar();
                }
                else
                {
                    labelAcelerar.Text = ($"El carro: {carro.marca} no esta encendido ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes encender el carro primero");
            }
        }

        //Boton para Frenar el carro-------------------------------------------------------------------------------------

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    labelFrenar.Text = carro.Frenar();
                }
                else 
                {
                    labelAcelerar.Text = ($"El carro: {carro.marca} no esta encendido ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes encender el carro primero");
            }
        }

        //Boton para apagar el carro------------------------------------------------------------------------------------

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    labelApagar.Text = carro.Apagar();

                }
                else
                {
                    labelApagar.Text = ("x ");
                    labelEncender.Text = ("Auto apagado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes encender el carrro primero");
            }
        }

        //Boton para tocar el claxon-------------------------------------------------------------------------------------

        private void buttonClaxon_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    carro.Claxon();
                }
                else
                {
                    MessageBox.Show(" Necesitas encender el carro para usar la bocina ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Debes encender el carro primero");
            }
        }

        //Boton para reproducir en la consola de video--------------------------------------------------------------------

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    axWindowsMediaPlayer1.URL = @"C:\Users\anner\source\repos\objetoProgra1\objetoProgra1\bin\Debug\Sonidos\Video.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes encender el carro primero");
            }
        }

        //Boton para parar la reproduccion de video en la consola--------------------------------------------------------

        private void buttonParar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                     axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
                else
                {
                    MessageBox.Show("Vehiculo apagado");
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("El vehiculo esta apagado");
            }
        }

        //Boton para pausar la reproduccion en la consola de video----------------------------------------------------------

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
                else
                {
                    MessageBox.Show("Vehiculo apagado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El vehiculo esta apagado");
            }
        }

        //Labels que muestran la fecha y la hora en la pantalla-------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (carro.estaEncendido() == true)
                {
                    hora.Text = DateTime.Now.ToLongTimeString();
                    fecha.Text = DateTime.Now.ToShortDateString();

                }
                else
                {
                    fecha.Text = ("X-X-X-X-X");
                    hora.Text = ("X-X-X-X-X");
                }
            }catch(Exception ex)
            {
                    fecha.Text = ("X-X-X-X-X");
                    hora.Text = ("X-X-X-X-X");
            }
            
        }

        private void velocidad_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
