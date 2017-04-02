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
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;

namespace assignment_4_comp1004
{
    public partial class SelectionForm : Form
    {

        // Use Entify Framework to connect to database
        public productscotext Database;

        private List<product> ProductList; // from product table in db

        private StartForm PreviousForm;

        // Form shows info on selected product before a purchase
        private ProductInfoForm ProductInfoForm;

        private product CurrentProduct;

        // Constructor
        public SelectionForm(StartForm parentForm)
        {
            InitializeComponent();

            this.PreviousForm = parentForm;
        }

        /* FOLLOWING CODE IS NOT MINE
         * FOUND ON THIS PAGE: http://stackoverflow.com/questions/2031824/what-is-the-best-way-to-check-for-internet-connectivity-using-net
         * RETRIEVED ON: November 25, 2016 (2016-11-25)
         * POSTED AS AN ANSWER TO A PROBLEM
         * POSTED BY: ChaosPandion (http://stackoverflow.com/users/156142/chaospandion)
         * EDITED BY: Kevin (http://stackoverflow.com/users/1144624/kevin)
         * vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
         */
        public static bool isInternetConnected()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        /* ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
         * THE ABOVE CODE IS NOT MINE
         * SOURCE LINKED ABOVE
         */

        /// <summary>
        /// Called through StartForm from SplashForm to load Product List in splash screen
        /// </summary>
        public void LoadProducts()
        {
            try
            {
                if (!isInternetConnected())
                {
                    throw new Exception();
                }

                // Connect to db using EF
                this.Database = new productscotext();

                // Use LINQ to access the student table in the db
                ProductList = (from product in Database.products
                               select product).ToList();
            }
            catch
            {
                DialogResult Result = MessageBox.Show("Unexpected Error Occurred: Could not get product table from DollarComputerDB.\n"
                    + "Please make sure you are connected to the internet and have access to dollar-server.database.windows.net",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                Application.Exit();
            }
        }

        public void GetProducts()
        {
            // Display ProductList in the DataGridView
            this.ProductsDataGridView.DataSource = ProductList;

            for (int i = 0; i < this.ProductsDataGridView.Columns.Count; i++)
            {
                string header = "DEFAULT_HEADER";

                switch (this.ProductsDataGridView.Columns[i].Name)
                {
                    case "productID":
                        header = "ID";
                        break;
                    case "cost":
                        header = "Cost";
                        this.ProductsDataGridView.Columns[i].DefaultCellStyle.Format = "c"; // Money
                        break;
                    case "manufacturer":
                        header = "Brand";
                        break;
                    case "model":
                        header = "Model";
                        break;
                    case "RAM_type":
                        header = "RAM Type";
                        break;
                    case "RAM_size":
                        header = "RAM Size";
                        break;
                    case "displaytype":
                        header = "Display";
                        break;
                    case "screensize":
                        header = "Screen Size";
                        break;
                    case "resolution":
                        header = "Resolution";
                        break;
                    case "CPU_Class":
                        header = "CPU Class";
                        break;
                    case "CPU_brand":
                        header = "CPU Brand";
                        break;
                    case "CPU_type":
                        header = "CPU Type";
                        break;
                    case "CPU_speed":
                        header = "CPU Speed";
                        break;
                    case "CPU_number":
                        header = "CPU Number";
                        break;
                    case "condition":
                        header = "Condition";
                        break;
                    case "OS":
                        header = "Operating System";
                        break;
                    case "platform":
                        header = "Platform";
                        break;
                    case "HDD_size":
                        header = "HDD";
                        break;
                    case "HDD_speed":
                        header = "HDD Speed";
                        break;
                    case "GPU_Type":
                        header = "GPU";
                        break;
                    case "optical_drive":
                        header = "Optical Drive";
                        break;
                    case "Audio_type":
                        header = "Audio";
                        break;
                    case "LAN":
                        header = "LAN";
                        break;
                    case "WIFI":
                        header = "WiFi";
                        break;
                    case "width":
                        header = "Width";
                        break;
                    case "height":
                        header = "Height";
                        break;
                    case "depth":
                        header = "Depth";
                        break;
                    case "weight":
                        header = "Weight";
                        break;
                    case "moust_type":
                        header = "Mouse";
                        break;
                    case "power":
                        header = "Power";
                        break;
                    case "webcam":
                        header = "Webcam";
                        break;
                    case "default":
                        header = "DEFAULT_HEADER";
                        break;
                }

                this.ProductsDataGridView.Columns[i].HeaderText = header;
                this.ProductsDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void CancelSelection()
        {
            this.Hide();

            this.PreviousForm.Show();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.isClosing == false) Program.ConfirmClose(e);
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            this.GetProducts();
        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.ProductsDataGridView.CurrentRow.Selected = true;

                this.SelectProduct(this.ProductsDataGridView.CurrentRow);
            }
            catch
            {
                // Do Nothing

                // Exception occurs on default selection when grid view is loading
            }
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            Button ActiveButton = (Button)sender;

            if (ActiveButton == this.CancelButton)
            {
                this.CancelSelection();
            }
            else if (ActiveButton == this.NextButton)
            {
                this.NextSelection();
            }
        }

        private void SelectProduct(DataGridViewRow currentRow)
        {
            this.CurrentProduct = (product)currentRow.DataBoundItem;

            this.SelectionTextBox.Text = this.ProductSummary(this.CurrentProduct);
        }

        private string ProductSummary(product currentProduct)
        {
            int currentID = currentProduct.productID;

            string ProductSum = currentProduct.manufacturer
                + " "
                + currentProduct.model
                + " - "
                + String.Format("{0:C}", currentProduct.cost);

            return ProductSum;
        }

        private void NextSelection()
        {
            this.Hide();

            this.ProductInfoForm = new ProductInfoForm(this, this.CurrentProduct);
            this.ProductInfoForm.Show();
        }
    }
}
