using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGravitatieSpace_sl
{
    public partial class CalculatorGravitatieSpace : MaterialSkin.Controls.MaterialForm
    {
        private string userName = "Admin.2002";
        private string passwordLogin = "Amalia.2023";
        public CalculatorGravitatieSpace()
        {
            InitializeComponent();
        }


        public string User { get => userName; set => userName = value; }
        public string Password { get => passwordLogin; set => passwordLogin = value; }

        private void textNumeClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGreutate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

        }
    }
}
