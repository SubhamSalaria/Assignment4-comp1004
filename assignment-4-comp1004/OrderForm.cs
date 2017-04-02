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
using System.IO;
using assignment_4_comp1004.Properties;

namespace assignment_4_comp1004
{
    public partial class OrderForm : Form
    {
        private ProductInfoForm PreviousForm;

        private product Product;

        private double TotalPrice;

        private bool isClosingAlone;

        public OrderForm(ProductInfoForm previousForm, product product)
        {
            InitializeComponent();

            this.PreviousForm = previousForm;
            this.Product = product;

            this.isClosingAlone = false;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.isClosing == false && this.isClosingAlone == false) Program.ConfirmClose(e);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            double price = (double)Product.cost;
            double tax = price * 0.13;
            double total = price + tax;

            this.TotalPrice = total;

            this.PriceTextBox.Text = String.Format("{0:C}", price);
            this.TaxTextBox.Text = String.Format("{0:C}", tax);
            this.TotalTextBox.Text = String.Format("{0:C}", total);

            this.ComputerPictureBox.Image = (
                Product.platform.ToString().ToLower().Contains("laptop") ?
                Resources.stock_laptop :
                Resources.stock_desktop
                );

            this.ConditionTextBox.Text = Product.condition;
            this.PlatformTextBox.Text = Product.platform;

            this.ManufacturerTextBox.Text = Product.manufacturer;
            this.ModelTextBox.Text = Product.model;

            this.LCDSizeTextBox.Text = Product.screensize;
            this.MemoryTextBox.Text = Product.RAM_size;
            this.CPUBrandTextBox.Text = Product.CPU_brand;
            this.CPUTypeTextBox.Text = Product.CPU_type;
            this.CPUNumberTextBox.Text = Product.CPU_number;
            this.CPUSpeedTextBox.Text = Product.CPU_speed;
            this.HDDTextBox.Text = Product.HDD_size;
            this.GPUTypeTextBox.Text = Product.GPU_Type;
            this.WebcamTextBox.Text = Product.webcam;
            this.OSTextBox.Text = Product.OS;
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            Button ActiveButton = (Button)sender;

            if (ActiveButton == this.FinishButton)
            {
                this.FinishPurchase();
            }
            else if (ActiveButton == this.CancelButton)
            {
                this.CancelPurchase();
            }
            else if (ActiveButton == this.BackButton)
            {
                this.GoBack();
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ActiveItem = (ToolStripMenuItem)sender;

            if (ActiveItem == this.PrintMenuItem)
            {
                this.PrintOrder();
            }
            else if (ActiveItem == this.ExitMenuItem)
            {
                this.Close();
            }

            else if (ActiveItem == this.BackMenuItem)
            {
                this.GoBack();
            }

            else if (ActiveItem == this.AboutMenuItem)
            {
                Program.showAboutDialog();
            }
        }

        private void FinishPurchase()
        {
            string confirmationString = String.Format("Are you sure you wish to purchase {0}'s {1} for {2:C}?",
                Product.manufacturer,
                Product.model,
                this.TotalPrice
                );

            DialogResult Result = MessageBox.Show(confirmationString,
                "Order Confirmation",
                MessageBoxButtons.YesNo
                );

            if (Result == DialogResult.Yes)
            {
                this.isClosingAlone = true;
                this.Close();

                this.PreviousForm.CancelProduct();

                MessageBox.Show("Thank you for your purchase! Your product will be shipped to you as soon as possible.", "Thank You!");
            }
        }

        private void CancelPurchase()
        {
            DialogResult Result = MessageBox.Show("Are you sure you wish to cancel your order?",
                "Cancel Confirmation",
                MessageBoxButtons.YesNo
                );

            if (Result == DialogResult.Yes)
            {
                this.isClosingAlone = true;
                this.Close();

                this.PreviousForm.CancelProduct();
            }
        }

        private void GoBack()
        {
            this.isClosingAlone = true;
            this.Close();

            this.PreviousForm.Show();
        }

        private void PrintOrder()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            string CurrentFileName = String.Format("Dollar Computers {0} {1} Order",
                Product.manufacturer,
                Product.model
                );
            string CurrentFileDirectory = "C:\\Users\\" + Environment.UserName + "\\Documents";

            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog.InitialDirectory = CurrentFileDirectory;
            saveFileDialog.FileName = (CurrentFileName.Contains('\\') ?
                CurrentFileName.Substring(CurrentFileName.LastIndexOf('\\') + 1) :
                CurrentFileName
                );

            DialogResult Result = saveFileDialog.ShowDialog();

            if (Result == DialogResult.OK
                && saveFileDialog.FileName.ToString().Length > 0)
            {
                CurrentFileName = saveFileDialog.FileName.ToString();

                StreamWriter Writer = new StreamWriter(CurrentFileName);

                string ProductOrder = "Dollar Computers Order:\n\n"
                    + "Manufacturer: " + this.Product.manufacturer.ToString() + "\n"
                    + "Model: " + this.Product.model.ToString() + "\n"
                    + "Platform: " + this.Product.platform.ToString() + "\n"
                    + "Product ID: " + this.Product.productID.ToString() + "\n"
                    + "Condition: " + this.Product.condition.ToString() + "\n"
                    + "\n"
                    + "Price: " + this.PriceTextBox.Text + "\n"
                    + "Tax: " + this.TaxTextBox.Text + "\n"
                    + "Total Cost: " + this.TotalTextBox.Text + "\n\n\n"
                    + "Details:\n\n"
                    + "LCD Size: " + this.Product.screensize + "\n"
                    + "Memory: " + this.Product.RAM_size + "\n"
                    + "CPU Brand: " + this.Product.CPU_brand + "\n"
                    + "CPU Type: " + this.Product.CPU_type + "\n"
                    + "CPU Number: " + this.Product.CPU_number + "\n"
                    + "CPU Speed: " + this.Product.CPU_speed + "\n"
                    + "HDD: " + this.Product.HDD_size + "\n"
                    + "GPU Type: " + this.Product.GPU_Type + "\n"
                    + "Webcam: " + this.Product.webcam + "\n"
                    + "OS: " + this.Product.OS + "\n";

                Writer.Write(ProductOrder);

                Writer.Close();
            }
        }
    }
}
