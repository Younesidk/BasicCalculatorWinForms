namespace BasicCalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double? FirstNumber = null;
        private string Operation;
        private bool IsNewEntry = true;

        private void NumberButtons_Click(object sender, EventArgs eventArgs)
        {
            if (IsNewEntry)
            {
                DisplayTextBox.Clear();
                IsNewEntry = false;
            }

            Button button = (Button)sender;

            DisplayTextBox.Text += button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Clear();
            FirstNumber = null;
            Operation = null;
            IsNewEntry = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double? SecondNumber = Convert.ToDouble(DisplayTextBox.Text);

            if (SecondNumber == null)
            {
                SecondNumber = 0;
            }

            double result = 0;

            switch (Operation)
            {
                case "+":
                    {
                        result = (double)FirstNumber + (double)SecondNumber;

                        DisplayTextBox.Text = Convert.ToString(result);

                        break;
                    }
                case "-":
                    {
                        result = (double)FirstNumber - (double)SecondNumber;

                        DisplayTextBox.Text = Convert.ToString(result);

                        break;
                    }
                case "*":
                    {
                        result = (double)FirstNumber * (double)SecondNumber;

                        DisplayTextBox.Text = Convert.ToString(result);

                        break;
                    }
                case "/":
                    {
                        if (SecondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by Zero");
                            return;
                        }
                        result = (double)FirstNumber / (double)SecondNumber;

                        DisplayTextBox.Text = Convert.ToString(result);

                        break;
                    }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            //string? result = Checking(Number1TextBox.Text, Number2TextBox.Text, "+");

            //if (result == null)
            //    return;

            //ResultLabel.Text = result;

            if (string.IsNullOrWhiteSpace(DisplayTextBox.Text))
                FirstNumber = 0;
            else
                FirstNumber = Convert.ToDouble(DisplayTextBox.Text);

            DisplayTextBox.Clear();
            Operation = "+";
            IsNewEntry = true;
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            //string? result = Checking(Number1TextBox.Text, Number2TextBox.Text, "-");

            //if (result == null)
            //    return;


            //ResultLabel.Text = result;

            if (string.IsNullOrWhiteSpace(DisplayTextBox.Text))
                FirstNumber = 0;
            else
                FirstNumber = Convert.ToDouble(DisplayTextBox.Text);

            DisplayTextBox.Clear();
            Operation = "-";
            IsNewEntry = true;
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            //string? result = Checking(Number1TextBox.Text, Number2TextBox.Text, "*");

            //if (result == null)
            //    return;

            //ResultLabel.Text = result;

            if (string.IsNullOrWhiteSpace(DisplayTextBox.Text))
                FirstNumber = 0;
            else
                FirstNumber = Convert.ToDouble(DisplayTextBox.Text);

            DisplayTextBox.Clear();
            Operation = "*";
            IsNewEntry = true;
        }
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            //string? result = Checking(Number1TextBox.Text, Number2TextBox.Text, "/");

            //if (result == null)
            //    return;

            //ResultLabel.Text = result;

            if (string.IsNullOrWhiteSpace(DisplayTextBox.Text))
                FirstNumber = 0;
            else
                FirstNumber = Convert.ToDouble(DisplayTextBox.Text);

            DisplayTextBox.Clear();
            Operation = "/";
            IsNewEntry = true;
        }




        //private string? Checking(string Number1, string Number2, string Op)
        //{
        //    long n = 0, m = 0;

        //    if (string.IsNullOrWhiteSpace(Number1) || string.IsNullOrWhiteSpace(Number2))
        //    {
        //        MessageBox.Show("Please Don't Leave the numbers empty");
        //        return null;
        //    }

        //    if (!long.TryParse(Number1, out n) || !long.TryParse(Number2, out m))
        //    {
        //        MessageBox.Show("Please Enter Numbers");
        //        return null;
        //    }

        //    double result = 0; // Change result to double to handle division

        //    switch (Op)
        //    {
        //        case "+":
        //            result = n + m;
        //            break;
        //        case "-":
        //            result = n - m;
        //            break;
        //        case "*":
        //            result = n * m;
        //            break;
        //        case "/":
        //            if (m == 0)
        //            {
        //                MessageBox.Show("Cannot divide by zero");
        //                return null;
        //            }
        //            result = (double)n / (double)m;
        //            break;
        //        default:
        //            MessageBox.Show("Invalid operator");
        //            return null;
        //    }

        //    return $"{n} {Op} {m} = {result}";
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
