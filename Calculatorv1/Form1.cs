namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        string act = "";
        double Answer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumCLick(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void Action(object sender, EventArgs e)
        {
            
            if (a != 0)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                Compute(a, b, act);
                textBox1.Text = Convert.ToString(Answer);
            }

            /*if (textBox1.TextLength != 0 && act!="")
            {
                b = Convert.ToDouble(textBox1.Text);
                Compute(a,b,act);
            } else  */
            
            if (textBox1.TextLength != 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
            act = ((Button)sender).Text;
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            act = "";
            Answer = 0;
        }

        private void Form1_Load(object sender, EventArgs e) //Клик в пустую область/мимо
        {

        }

        private void Equals(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                b = Convert.ToDouble(textBox1.Text);

            }
            textBox1.Clear();
            Compute(a, b, act);
            textBox1.Text = Convert.ToString(Answer);
           
        }

        void Compute(double a, double b, string act)
        {
            switch (act)
            {
                case "+":
                    {
                        Answer = a + b;
                        textBox1.Text = Convert.ToString(Answer);
                        break;
                    }
                case "-":
                    {
                        Answer = a - b;
                        textBox1.Text = Convert.ToString(Answer);
                        break;
                    }
                case "*":
                    {
                        Answer = a * b;
                        textBox1.Text = Convert.ToString(Answer);
                        break;
                    }
                case "/":
                    {
                        Answer = a / b;
                        textBox1.Text = Convert.ToString(Answer);
                        break;
                    }
            }
        }



        private void Debuger(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(a);
            textBox3.Text = Convert.ToString(b);
            textBox4.Text = Convert.ToString(Answer);
        }
    }
}