namespace CalculatorGravitatieSpace_sl
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CalculatorGravitatieSpace calculatorGravitatieSpace = new CalculatorGravitatieSpace();

            if (DialogResult == DialogResult.OK && calculatorGravitatieSpace.User == textUsername.Text && calculatorGravitatieSpace.Password == textPassowrd.Text)
            {
                calculatorGravitatieSpace.Show();
            }
            else
            {
                MessageBox.Show("Username si parola gresita, va rugam sa introduceti datele de logare cu mai multa atentie ! ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}