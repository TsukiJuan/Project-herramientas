using AxAcroPDFLib;
using AxWMPLib;
using System;
using System.Windows.Forms;

namespace pdfV
{
    public partial class frm_reutilizacion : Form
    {
        public frm_reutilizacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
            string urldot = openFileDialog1.FileName;
            windowsMedia.URL = urldot;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            openFileDialog.Title = "Selecciona un archivo PDF";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivoPDF = openFileDialog.FileName;

                // Cargar el archivo PDF en el control axAcroPDF
                pdfReader.src = rutaArchivoPDF;
            }
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            string url = "https://sicau.pascualbravo.edu.co/SICAU/Account/Login";
            // Navegar a la URL ingresada
            wbBrowser.Navigate(url);
        }
    }
    }


