using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agraga el constructor
            operacion suma1 = new operacion();

            suma1.N11 = int.Parse(textBox1.Text);
            suma1.N21 = int.Parse(textBox2.Text);

            textBox4.Text = suma1.N11.ToString();
            textBox5.Text = suma1.N21.ToString();
            textBox6.Text = suma1.sumar().ToString();

            textBox3.Text = suma1.sumar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //agraga el constructor
            operacion meno1 = new operacion();

            meno1.N11 = int.Parse(textBox1.Text);
            meno1.N21 = int.Parse(textBox2.Text);

            textBox4.Text = meno1.N11.ToString();
            textBox5.Text = meno1.N21.ToString();
            textBox6.Text = meno1. meno().ToString();

            textBox3.Text = meno1.meno().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //agraga el constructor
            operacion multi1 = new operacion();

            multi1.N11 = int.Parse(textBox1.Text);
            multi1.N21 = int.Parse(textBox2.Text);

            textBox4.Text = multi1.N11.ToString();
            textBox5.Text = multi1.N21.ToString();
            textBox6.Text = multi1.multi().ToString();

            textBox3.Text = multi1.multi().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //agraga el constructor
            operacion divi1 = new operacion();

            divi1.N11 = int.Parse(textBox1.Text);
            divi1.N21 = int.Parse(textBox2.Text);

            textBox4.Text = divi1.N11.ToString();
            textBox5.Text = divi1.N21.ToString();
            textBox6.Text = divi1.dividir().ToString();

            textBox3.Text = divi1.dividir().ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //foreach : enumera los elementos de una colección y
            //ejecuta su cuerpo para cada elemento de la colección.
            foreach (Control ctr in this.Controls) //controls clase de la cual vamos a poder crear instancias para diseñar la interfaz de la aplicación
            {
                if (ctr is TextBox)
                    ctr.Text = string.Empty;//Representa la cadena vacía. Este campo es de solo lectura.
                                            //En el código de la aplicación, este campo se usa más comúnmente en asignaciones para
                                            //inicializar una variable de cadena en una cadena vacía. Para probar si el valor de
                                            //una cadena es nullo String.Empty , use el método IsNullOrEmpty .
            }
            /* textBox1.Text = "";
             textBox2.Text = "";
             textBox4.Text = "";
             textBox5.Text = "";
             textBox6.Text = "";
             textBox3.Text = "";*/

        }
    }
}
