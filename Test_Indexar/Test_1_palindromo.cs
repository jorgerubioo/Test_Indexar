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
    public partial class Test_1_palindromo : Form
    {
        public Test_1_palindromo()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            string input = txt_input.Text.ToLower().Replace(" ", "");
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            if (input == reversed)
            {
                lbl_Result.Text = "Es un palíndromo";
            }
            else
            {
                lbl_Result.Text = "No es un palíndromo";
            }
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            Test_2_Fibonacci test_2_Fibonacci = new Test_2_Fibonacci();

            this.Hide();

            test_2_Fibonacci.Show();
        }
    }
}
