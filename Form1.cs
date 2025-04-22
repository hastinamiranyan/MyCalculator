using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {

            InitializeComponent();
            calculate = new Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)numericUpDown1.Value,(int)numericUpDown2.Value);
                MessageBox.Show("sum : "+sum);
            }

        }

        bool ValidateInputs()
        {
            bool IsVAlid = true;

            if (numericUpDown1.Value == 0)
            {
                IsVAlid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (numericUpDown2.Value == 0)
                {
                    IsVAlid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید ");
                }
            }

            return IsVAlid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.Minus((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                MessageBox.Show("minus : " + minus);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                MessageBox.Show("minus : " + multiple);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                MessageBox.Show("minus : " + divide);

            }
        }
    }
}
