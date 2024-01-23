using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       public string nombre, mail, apellido;
       public string confirmacion;
       public int carrera;
       public string edad;
       public string[] cursos = new string[5];
       public string decision;


        public Form1()
        {
            InitializeComponent();
            mostrarsaludo();

        }

        public void mostrarsaludo()
        {
            // Obtener el nombre de usuario del equipo
            string nombreUsuario = Environment.UserName;

            // Mostrar un saludo
            MessageBox.Show("¡Hola, " + nombreUsuario + "! Bienvenido a Alumni.", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Educacion it2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.textBox1f2.Text = textBox1.Text;
            f2.textBox2f2.Text = textBox2.Text;
            f2.textBox4f2.Text = textBox4.Text;

            f2.Show();

            MessageBox.Show("se cargaron los datos");

            //Form2 formulario2 = new Form2();
            //formulario2.Show();


        }
    }
}
