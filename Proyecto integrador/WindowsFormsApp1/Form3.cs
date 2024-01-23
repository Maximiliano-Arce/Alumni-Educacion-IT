using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string[] cursosnet = { "HTML", "intro a la program .NET", "program Web NET core", "intro a BD y SQL", "Javascript desde cero" };
        string[] cursosphp = { "PHP Arquitec Avanzada", "Program Web en PHP y MySQL", "intro al paradigma de objetos", "PHP Laravel", "UML y UP: Analisis y diseño" };
        string[] cursosjava = { "Introduccion a java", "Intro al Paradigma de Objetos", "Java Standard 17 Web Program", "Java Web API", "Java Hibernate JPA" };
        string[] carreras = { "Programacion.Net", "Programacion PHP", "Programacion Java" };

        private List<System.Windows.Forms.TextBox> selecciones = new List<System.Windows.Forms.TextBox>();
        private int currentIndex;
        private List<string> cursosSeleccionados = new List<string>();


        public Form3()
        {
            InitializeComponent();

            selecciones.Add(textBox5);
            selecciones.Add(textBox6);
            selecciones.Add(textBox8);
            selecciones.Add(textBox7);
            selecciones.Add(textBox9);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando se selecciona una carrera, muestra los cursos correspondientes
            string carreraSeleccionada = comboBox1.Text;

            if (carreraSeleccionada.Equals(carreras[0], StringComparison.OrdinalIgnoreCase))
            {
                todosloscursos(cursosnet);
            }
            else if (carreraSeleccionada.Equals(carreras[1], StringComparison.OrdinalIgnoreCase))
            {
                todosloscursos(cursosphp);
            }
            else if (carreraSeleccionada.Equals(carreras[2], StringComparison.OrdinalIgnoreCase))
            {
                todosloscursos(cursosjava);
            }
            // Puedes agregar más bloques else if según sea necesario para otras carreras

            string opcionSeleccionada = comboBox1.SelectedItem.ToString();

            textBox4f3.Text = opcionSeleccionada;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el índice seleccionado en el ComboBox2
            int selectedIndex = comboBox2.SelectedIndex;

            // Realiza la lógica necesaria con el índice seleccionado
            // Por ejemplo, podrías obtener el elemento seleccionado y mostrarlo en un MessageBox
            if (selectedIndex != -1)
            {
                string selectedCurso = comboBox2.Items[selectedIndex].ToString();
                MessageBox.Show($"Curso seleccionado: {selectedCurso}");
            }
        }

        void todosloscursos(string[] cursos)
        {
            // Limpia los elementos anteriores en comboBox2
            comboBox2.Items.Clear();

            //for (int i = 0; i < cursos.Length; i++)
            //{
            //    comboBox2.Items.Add(cursos[i]);


            //};

            foreach (string curso in cursos)
            {
                // Verifica si el curso ya ha sido seleccionado antes de agregarlo al ComboBox
                if (!cursosSeleccionados.Contains(curso))
                {
                    comboBox2.Items.Add(curso);
                }
            }

            //comboBox2.Items.AddRange(cursos);

        }

        void carrerass()
        {
            for (int i = 0; i < carreras.Length; i++)
            {
                comboBox1.Items.Add(carreras[i]);



            };

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            carrerass();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private List<System.Windows.Forms.TextBox> GetSelecciones()
        {
            return selecciones;
        }

        private void AplicarSeleccionesATextBox(List<System.Windows.Forms.TextBox> selecciones)
        {
            // Asigna cada selección a un TextBox correspondiente
            for (int i = 0; i < selecciones.Count; i++)
            {
                if (i < Controls.Count)
                {
                    if (Controls[i] is System.Windows.Forms.TextBox textBox)
                    {
                        textBox.Text = selecciones[i].Text;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay una selección en el ComboBox
            if (comboBox1.SelectedIndex != -1)
            {
                // Obtiene el valor seleccionado del ComboBox
                string opcionSeleccionada = comboBox2.SelectedItem.ToString();

                if (!cursosSeleccionados.Contains(opcionSeleccionada))
                {

                    selecciones[currentIndex].Text = opcionSeleccionada;
                    cursosSeleccionados.Add(opcionSeleccionada);

                    currentIndex++;

                }
                else
                {
                    MessageBox.Show("Este curso ya ha sido seleccionado.");
                }

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();



        }

        private void ImprimirContenido(object sender, PrintPageEventArgs e)
        {



        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirInscripcion(object sender, PrintPageEventArgs e)
        {
            // Crear un nuevo objeto Bitmap con el tamaño del Panel
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);

            // Dibujar el contenido del Panel en el Bitmap
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.Width, panel1.Height));

            // Dibujar el Bitmap en el objeto Graphics
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1f3.Text;
            string apellido = textBox2f3.Text;
            string mail = textBox3f3.Text;
            string carrera = textBox4f3.Text;
            string curso1 = textBox5.Text;
            string curso2 = textBox6.Text;
            string curso3 = textBox7.Text;
            string curso4 = textBox8.Text;
            string curso5 = textBox9.Text;

            string connectionString = "Server=Localhost;Database=inscripciones;User ID = root; Password = ;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL para la inserción
                string query = "INSERT INTO datos (nombre, apellido, mail, carrera,  curso1, curso2, curso3, curso4, curso5) VALUES (@nombre, @apellido, @mail, @carrera, @curso1, @curso2, @curso3, @curso4, @curso5)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agregar parámetros para evitar SQL Injection
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@carrera", carrera);
                    command.Parameters.AddWithValue("@curso1", curso1);
                    command.Parameters.AddWithValue("@curso2", curso2);
                    command.Parameters.AddWithValue("@curso3", curso3);
                    command.Parameters.AddWithValue("@curso4", curso4);
                    command.Parameters.AddWithValue("@curso5", curso5);

                    // Ejecutar la consulta
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar datos: " + ex.Message);
                    }

                }
            }
        }
    }
}