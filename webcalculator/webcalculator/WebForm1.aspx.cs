using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webformclass;

namespace webcalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        double num1, ans, num2;
        int count;

        double a;
        double b;

        Class1 obj = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {

        }

        protected void CE_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty; ;
            count = 0;

        }

        protected void C_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && TextBox1.Text.Length > 0)
            {
                num1 = 0;
                TextBox1.Text = string.Empty;
            }
            else if (num1 > 0 && TextBox1.Text.Length > 0)
            {
                TextBox1.Text = string.Empty;
            }
            
        }

        protected void back_Click(object sender, EventArgs e)
        {
            int lenght = TextBox1.Text.Length - 1;
            string text = TextBox1.Text;
            TextBox1.Text = string.Empty;
            for (int i = 0; i < lenght; i++)
                TextBox1.Text = TextBox1.Text + text[i];
        }

        protected void one_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        protected void twe_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;

        }

        protected void three_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3;
        }

        protected void four_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;
        }

        protected void five_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        protected void six_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        protected void eight_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 8;
        }

        protected void nine_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty; ;
            TextBox1.Focus();
            count = 2;
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty; ;
            TextBox1.Focus();
            count = 1;
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty; ;
            TextBox1.Focus();
            count = 3;
        }

        protected void div_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty; ;
            TextBox1.Focus();
            count = 4;
        }

        protected void zero_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 0;
        }

        protected void point_Click(object sender, EventArgs e)
        {
             count = 0;
            string text = TextBox1.Text;
            for (int i = 0; i < TextBox1.Text.Length; i++)
            {
                if (text[i].ToString() == ".")
                {
                    count = 1; break;
                }
                else
                {
                    count = 0;
                }
            }
            if (count == 0)
            {
                TextBox1.Text = TextBox1.Text + ".";
            }
        
        }

        protected void sin_Click(object sender, EventArgs e)
        {
           

            a = double.Parse(TextBox1.Text);
            ans = obj.sin(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void sinh_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.sinh(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void cos_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.cos(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void cosh_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.cosh(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void tan_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.tan(a);
            TextBox1.Text = Convert.ToString(ans);
        
        }

        protected void tanh_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.tanh(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void log_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.log(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void log10_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.log10(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void exp_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.exp(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void sqrt_Click(object sender, EventArgs e)
        {
            a = double.Parse(TextBox1.Text);
            ans = obj.sqrt(a);
            TextBox1.Text = Convert.ToString(ans);
        }

        protected void pi_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(Math.PI);
        }

        protected void pow_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty;
            TextBox1.Focus();
            count = 5;
        }

        protected void pow1_Click(object sender, EventArgs e)
        {
            count = 6;

        }

        protected void E_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(Math.E);
        }

        protected void mod_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TextBox1.Text);
            TextBox1.Text = string.Empty;
            TextBox1.Focus();
            count = 7;
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:

                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.sub(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;
                case 2:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.add(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;
                case 3:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.mul(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;
                case 4:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.div(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;

                case 5:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.pow(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;
                case 6:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.pow(num2, num1 = 2);
                    TextBox1.Text = ans.ToString();
                    break;
                case 7:
                    num2 = double.Parse(TextBox1.Text);
                    ans = obj.mod(num1, num2);
                    TextBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}