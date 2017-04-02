using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment_4_comp1004.Modules;

namespace assignment_4_comp1004
{
    public partial class StartForm : Form
    {
        private SelectionForm SelectionForm;

        public StartForm()
        {
            InitializeComponent();

            this.SelectionForm = new SelectionForm(this);
        }

        /// <summary>
        /// Middle man between seletion screen with Product List, and splash screen where the loading occurs
        /// </summary>
        public void LoadProducts()
        {
            this.SelectionForm.LoadProducts();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.NewOrderButton.Focus();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.isClosing == false) Program.ConfirmClose(e);
        }

        private void AboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.showAboutDialog();
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            Button ActiveButton = (Button)sender;

            if (ActiveButton == this.NewOrderButton)
            {
                this.StartNewOrder();
            }
            else if (ActiveButton == this.LoadOrderButton)
            {
                this.LoadOrder();
            }
            else if (ActiveButton == this.ExitButton)
            {
                this.Close();
            }
        }

        private void StartNewOrder()
        {
            this.Hide();

            this.SelectionForm.Show();
        }

        private void LoadOrder()
        {
            product LoadedProduct = Program.LoadProduct(this.SelectionForm.Database);

            if (LoadedProduct.productID != -1)
            {
                ProductInfoForm ProductForm = new ProductInfoForm(this.SelectionForm, LoadedProduct);

                this.Hide();

                ProductForm.Show();
            }
        }
    }
}
