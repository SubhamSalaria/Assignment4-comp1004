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
    public partial class ProductInfoForm : Form
    {
        private SelectionForm PreviousForm;

        private OrderForm OrderForm;

        private product Product;

        private bool isClosingAlone;

        public ProductInfoForm(SelectionForm parentForm, product currentProduct)
        {
            InitializeComponent();

            this.PreviousForm = parentForm;
            this.Product = currentProduct;

            this.isClosingAlone = false;
        }

        public void CancelProduct()
        {
            this.isClosingAlone = true;
            this.Close();

            this.PreviousForm.CancelSelection();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            this.Reload(); //For Multiple Uses
        }

        private void Reload()
        {
            // Set Textboxes with info
            this.ProductIDTextBox.Text = this.Product.productID.ToString();
            this.ConditionTextBox.Text = this.Product.condition.ToString();
            this.CostTextBox.Text = String.Format("{0:C}", this.Product.cost);

            // Set Product Info Textboxes
            this.PlatformTextBox.Text = this.Product.platform.ToString();
            this.OSTextBox.Text = this.Product.OS.ToString();

            this.ManufacturerTextBox.Text = this.Product.manufacturer.ToString();
            this.ModelTextBox.Text = this.Product.model.ToString();

            // Set Tech Specs Textboxes
            this.MemoryTextBox.Text = this.Product.RAM_size.ToString();
            this.LCDSizeTextBox.Text = this.Product.screensize.ToString();
            this.HDDTextBox.Text = this.Product.HDD_size.ToString();

            this.CPUBrandTextBox.Text = this.Product.CPU_brand.ToString();
            this.CPUNumberTextBox.Text = this.Product.CPU_number.ToString();
            this.GPUTypeTextBox.Text = this.Product.GPU_Type.ToString();

            this.CPUTypeTextBox.Text = this.Product.CPU_type.ToString();
            this.CPUSpeedTextBox.Text = this.Product.CPU_speed.ToString();
            this.WebcamTextBox.Text = this.Product.webcam.ToString();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.isClosing == false && this.isClosingAlone == false) Program.ConfirmClose(e);
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            Button ActiveButton = (Button)sender;

            if (ActiveButton == this.NextButton)
            {
                this.PurchaseProduct();
            }
            else if (ActiveButton == this.CancelButton)
            {
                this.CancelProduct();
            }
            else if (ActiveButton == this.AnotherProductButton)
            {
                this.AnotherProduct();
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ActiveItem = (ToolStripMenuItem)sender;

            if (ActiveItem == this.OpenMenuItem)
            {
                this.OpenFile();
            }
            else if (ActiveItem == this.SaveMenuItem)
            {
                this.SaveFile();
            }
            else if (ActiveItem == this.ExitMenuItem)
            {
                this.Close();
            }

            else if (ActiveItem == this.AnotherProductMenuItem)
            {
                this.AnotherProduct();
            }
            else if (ActiveItem == this.CancelMenuItem)
            {
                this.CancelProduct();
            }
            else if (ActiveItem == this.ProceedMenuItem)
            {
                this.PurchaseProduct();
            }
        }

        private void PurchaseProduct()
        {
            this.Hide();

            this.OrderForm = new OrderForm(this, this.Product);
            this.OrderForm.Show();
        }

        private void AnotherProduct()
        {
            this.isClosingAlone = true;
            this.Close();

            this.PreviousForm.Show();
        }

        private void OpenFile()
        {
            product NewProduct = Program.LoadProduct(this.PreviousForm.Database);

            if (NewProduct.productID != -1)
            {
                this.Product = NewProduct;
                this.Reload();
            }
        }

        private void SaveFile()
        {
            Program.SaveProduct(this.Product);
        }
    }
}
