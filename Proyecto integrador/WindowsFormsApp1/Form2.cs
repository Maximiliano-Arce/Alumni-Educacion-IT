using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        private Stack<Form> historial = new Stack<Form>();
        public Form2()
        {
            InitializeComponent();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1f2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Asegúrate de que hay una instancia válida de Form1
            if (Application.OpenForms["Form1"] != null)
            {
                // Muestra la instancia existente de Form1 y cierra el formulario actual
                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

     
            f3.textBox1f3.Text = textBox1f2.Text;
            f3.textBox2f3.Text = textBox2f2.Text;
            f3.textBox3f3.Text = textBox4f2.Text;
        }
    }
}
