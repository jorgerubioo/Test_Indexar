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
    public partial class Test_5_Calcular_indice_masa_corporal : Form
    {
        public Test_5_Calcular_indice_masa_corporal()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txt_Peso.Text);
            double altura = double.Parse(txt_Altura.Text.Replace(".", ","));
            double imc = peso / (altura * altura);

            lbl_Result.Text = $"IMC: {imc:F2}";

            if (imc < 18.0)
            {
                lbl_Result.Text = imc.ToString("0.###")+" Peso bajo. Necesario valorar signos de desnutrición.";
            }
            else if (imc >= 18.0 && imc <= 24.9)
            {
                lbl_Result.Text = imc.ToString("0.###") + " Peso normal";
            }
            else if (imc >= 25 && imc <= 26.9)
            {
                lbl_Result.Text = imc.ToString("0.###") + " Sobrepeso";
            }
           
            else if (imc >= 27.0 && imc <= 29.9)
            {
                lbl_Result.Text = imc.ToString("0.###") + " Obesidad grado I, Riesgo relativo alto para desarrollar enfermedades cardiovasculares";
            }
            else if (imc >= 30.0 && imc <= 39.9)
            {
                lbl_Result.Text = imc.ToString("0.###") + " Obesidad grado II, Reisgo relativo muy alto para el desarrollo de enfermedades cardiovasculares";
            }
            else
            {
                lbl_Result.Text = imc.ToString("0.###") + " Obesidad grado III, extrema o Morbida. Riesgo relativo extremadamente alto para el desarrollo de enfermedades cardiovasculares";
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Test_4_Calculadora_ecuacion_cuadratica test_4_Calculadora_Ecuacion_Cuadratica = new Test_4_Calculadora_ecuacion_cuadratica();

            this.Hide();

            test_4_Calculadora_Ecuacion_Cuadratica.Show();
        }
    }
    }

