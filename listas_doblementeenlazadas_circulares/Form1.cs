using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listas_doblementeenlazadas_circulares
{
    public partial class Form1 : Form
    {
        private ListaSimpleEnlazadaCanales galeriaCanales;
        public Form1()
        {
            InitializeComponent();
            InicializarCanales();
        }

        private void InicializarCanales()
        {
            galeriaCanales = new ListaSimpleEnlazadaCanales();

            galeriaCanales.AgregarCanal("Canal 1",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\6162038-hd_1080_1920_30fps.mp4");

            // Ruta local: NO uses \" en @"
            galeriaCanales.AgregarCanal("Canal 2",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\856985-hd_1920_1080_30fps.mp4");

            galeriaCanales.AgregarCanal("Canal 3",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\3144446-hd_1920_1080_25fps.mp4");

            galeriaCanales.AgregarCanal("Canal 4 (Sintel)",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\4829605-uhd_3840_2160_30fps.mp4");

            galeriaCanales.AgregarCanal("Canal 5",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\5147455-hd_1080_1920_30fps.mp4");

            galeriaCanales.AgregarCanal("Canal 6",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\5309381-hd_1920_1080_25fps.mp4");

            galeriaCanales.AgregarCanal("Canal 7",
                @"C:\Users\linsy\OneDrive\Documents\Q3-2025\Estructura de datos\VideosMP4\5478927-uhd_3840_2160_25fps.mp4");

            // Iniciar con el primer canal
            ReproducirCanal(galeriaCanales.ObtenerSiguienteCanal());
        }

        private void ReproducirCanal(NodoCanal canal)
        {
            if (canal != null)
            {
                // 1. Mostrar el nombre del canal
                lblNombreCa.Text = canal.Nombre;

                // 2. Cargar y reproducir el stream en el AxWindowsMediaPlayer
                axWindowsMediaPlayer1.URL = canal.UrlStream;
            }
            else
            {
                lblNombreCa.Text = "FIN DE LA LISTA DE CANALES";
                axWindowsMediaPlayer1.URL = string.Empty; // Detener la reproducción
            }
        }

        private void btnSiguient_Click_1(object sender, EventArgs e)
        {
            NodoCanal canalSiguiente = galeriaCanales.ObtenerSiguienteCanal();
            ReproducirCanal(canalSiguiente);
        }

        private void btnReinicia_Click_1(object sender, EventArgs e)
        {
            // Vuelve al primer nodo y actualiza la visualizacion
            galeriaCanales.Reiniciar();
            ReproducirCanal(galeriaCanales.ObtenerSiguienteCanal());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            NodoCanal canalAnterior = galeriaCanales.ObtenerAnteriorCanal();
            ReproducirCanal(canalAnterior);
        }
    }
}


