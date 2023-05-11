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
    public partial class Test_2_Fibonacci : Form
    {
        public Test_2_Fibonacci()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Number.Text);
            txt_Sequence.Text = GenerateFibonacciSequence(n);
        }

        private string GenerateFibonacciSequence(int n)
        {
            if (n < 1) return "";
            if (n == 1) return "0";

            int a = 0;
            int b = 1;
            string result = "0, 1";
            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                result += ", " + c;
            }
            return result;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            

            Test_3_Calculadora_notacion_polaca_inversa test_3_Calculadora_Notacion_Polaca_Inversa = new Test_3_Calculadora_notacion_polaca_inversa();

            this.Hide();

            test_3_Calculadora_Notacion_Polaca_Inversa.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Test_1_palindromo test_1_Palindromo = new Test_1_palindromo();

            this.Hide();

            test_1_Palindromo.Show();
        }
    }
}
