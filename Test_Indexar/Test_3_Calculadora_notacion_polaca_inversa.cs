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
    public partial class Test_3_Calculadora_notacion_polaca_inversa : Form
    {
        public Test_3_Calculadora_notacion_polaca_inversa()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string[] tokens = txtExpression.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Stack<decimal> stack = new Stack<decimal>();
            decimal result = 0;

            foreach (string token in tokens)
            {
                if (decimal.TryParse(token, out decimal number))
                {
                    stack.Push(number);
                }
                else
                {
                    decimal operand2 = stack.Pop();
                    decimal operand1 = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            result = operand1 / operand2;
                            break;
                        default:
                            MessageBox.Show("Invalid operator: " + token);
                            return;
                    }

                    stack.Push(result);
                }
            }

            if (stack.Count == 1)
            {
                txtResult.Text = stack.Pop().ToString();
            }
            else
            {
                MessageBox.Show("Invalid expression");
            }
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {

            Test_4_Calculadora_ecuacion_cuadratica test_4_Calculadora_Ecuacion_Cuadratica = new Test_4_Calculadora_ecuacion_cuadratica  ();
            this.Hide();

            test_4_Calculadora_Ecuacion_Cuadratica.Show();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            Test_2_Fibonacci test_2_Fibonacci = new Test_2_Fibonacci ();

            this.Hide();

            test_2_Fibonacci.Show();
        }
    }
}
