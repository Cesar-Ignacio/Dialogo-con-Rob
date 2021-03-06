using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaArchivp
{
    public partial class Form3 : Form
    {
        string nombre_usuario;
        string[] dialogos_disponibles;
        
        public Form3(string nombre)
        {
            InitializeComponent();
            nombre_usuario = nombre;
            string dialogos = Properties.Resources.dialogo.ToString();
            dialogos_disponibles = dialogos.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private string PCM(string nombre) 
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nombre);
        }

        private void CargarDialogo()
        {
            Random rand = new Random();
            label1.Text = "Bienvenido ";
            label1.Text +=", " +PCM(nombre_usuario)+",";
            int numero = rand.Next(1, dialogos_disponibles.Length);
            label1.Text +=dialogos_disponibles[numero]; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            CargarDialogo();
        }
    }
}
