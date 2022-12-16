using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraProjekt
{
    //cKara Version 1.1 by Barbara Bielawski
    public partial class Form1 : Form
    {
        private int eingabe;
        private void btnRun_Click(object sender, EventArgs e)
        {
            Main("");
        }

       

        public Form1()
        {
            InitializeComponent();
        }


        private void btnEnde_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eingabe = Convert.ToInt32(txtEingabe.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben");
            }
        }
    }
}
