using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Subham Salaria
// Student #: 200333595
// Dollar Computers
namespace assignment_4_comp1004
{
    public partial class SplashForm : Form
    {
        private StartForm StartForm;

        public SplashForm()
        {
            InitializeComponent();

            this.StartForm = new StartForm();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.SplashTimer.Enabled = false;

            this.loadStartForm();
        }

        private void loadStartForm()
        {
            this.Hide();

            this.StartForm.Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.StartForm.LoadProducts();
            this.SplashTimer.Enabled = true;
        }
    }
}
