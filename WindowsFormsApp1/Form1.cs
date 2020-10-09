using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_calculator : Form
    {
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(FormulaMDAS.getSub);

            int num1 = Int32.Parse(txtbox_num1.Text);
            int num2 = Int32.Parse(txtbox_num2.Text);

            MessageBox.Show(txtbox_num1.Text+ " - " + txtbox_num2.Text + " is equals to " +delegateAnswer(num1, num2).ToString(), "Result");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(FormulaMDAS.getSum);

            int num1 = Int32.Parse(txtbox_num1.Text);
            int num2 = Int32.Parse(txtbox_num2.Text);

            MessageBox.Show(txtbox_num1.Text + " + " + txtbox_num2.Text + " is equals to " +delegateAnswer(num1, num2).ToString(), "Result");
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(FormulaMDAS.getMul);

            int num1 = Int32.Parse(txtbox_num1.Text);
            int num2 = Int32.Parse(txtbox_num2.Text);

            MessageBox.Show(txtbox_num1.Text + " x " + txtbox_num2.Text + " is equals to " +delegateAnswer(num1, num2).ToString(), "Result");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(FormulaMDAS.getDiv);

            int num1 = Int32.Parse(txtbox_num1.Text);
            int num2 = Int32.Parse(txtbox_num2.Text);

            MessageBox.Show(txtbox_num1.Text + " ÷ " + txtbox_num2.Text + " is equals to " +delegateAnswer(num1, num2).ToString(), "Result");
        }
    }
}
