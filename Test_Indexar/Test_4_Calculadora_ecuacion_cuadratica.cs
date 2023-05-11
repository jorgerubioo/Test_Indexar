using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Indexar
{
    public partial class Test_4_Calculadora_ecuacion_cuadratica : Form
    {
        public Test_4_Calculadora_ecuacion_cuadratica()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)

        //ingresar A y que sea numerico        
        {
            if (txt_A.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor numerico en A", "Error");
                txt_A.Focus();
                return;
            }
            double A;
            try
            {
                A = Convert.ToDouble(txt_A.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en A", "Error");
                txt_A.Text = "";
                txt_A.Focus();
                return;
            }
            //ingresar B y que sea numerico  
            if (txt_B.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor numerico en B", "Error");

                txt_B.Focus();
                return;
            }
            double B;
            try
            {
                B = Convert.ToDouble(txt_B.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en B", "Error");
                txt_B.Text = "";
                txt_B.Focus();
                return;
            }
            //ingresar C y que sea numerico  
            if (txt_C.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor numerico en C", "Error");
                txt_C.Focus();
                return;
            }

            double C;
            try
            {
                C = Convert.ToDouble(txt_C.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en C", "Error");
                txt_C.Text = "";
                txt_C.Focus();
                return;
            }

            //Calculo Ecuacion
            double x1, x2;
            ecuacionCuadratica(A, B, C, out x1, out x2);

            //Resultados
            txt_R1.Text = x1.ToString();
            txt_R2.Text = x2.ToString();

        }

        private void ecuacionCuadratica(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a *c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_R1.Text = "";
            txt_R2.Text = "";

            txt_A.Focus();



        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {


            Test_5_Calcular_indice_masa_corporal test_5_Calcular_Indice_Masa_Corporal = new Test_5_Calcular_indice_masa_corporal();


            this.Hide();

            test_5_Calcular_Indice_Masa_Corporal.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Test_3_Calculadora_notacion_polaca_inversa test_3_Calculadora_Notacion_Polaca_Inversa = new Test_3_Calculadora_notacion_polaca_inversa();

            this.Hide();

            test_3_Calculadora_Notacion_Polaca_Inversa.Show();
        }
    }
    }
    

