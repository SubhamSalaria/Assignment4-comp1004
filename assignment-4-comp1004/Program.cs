using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using assignment_4_comp1004.Modules;
using System.IO;
using System.Text;

namespace assignment_4_comp1004
{
    static class Program
    {
        public static bool isClosing { get; set; }

        private static string _CurrentFileName;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());

            isClosing = false;
        }

        public static void ConfirmClose(FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Close Confirmation",
                MessageBoxButtons.YesNo
                );

            if (Result == DialogResult.Yes)
            {
                isClosing = true;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        public static void SaveProduct(product Product)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            _CurrentFileName = String.Format("DollarComputersID{0}Save", Product.productID);

            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.FileName = (_CurrentFileName.Contains('\\') ?
                _CurrentFileName.Substring(_CurrentFileName.LastIndexOf('\\') + 1) :
                _CurrentFileName
                );

            DialogResult Result = saveFileDialog.ShowDialog();

            if (Result == DialogResult.OK
                && saveFileDialog.FileName.ToString().Length > 0)
            {
                _CurrentFileName = saveFileDialog.FileName.ToString();

                StreamWriter Writer = new StreamWriter(_CurrentFileName);

                Writer.Write(
                    EncryptProduct(ProductData(Product))
                    );

                Writer.Close();
            }
        }

        public static product LoadProduct(DollarComputersContext database)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            DialogResult Result = openFileDialog.ShowDialog();

            if (Result == DialogResult.OK)
            {
                try
                {
                    StreamReader Reader = new StreamReader(openFileDialog.FileName);

                    string SaveFileText = DecryptProduct(Reader.ReadToEnd());

                    Reader.Close();

                    List<product> productList = (from item in database.products
                                                 select item).ToList();

                    foreach (product item in productList)
                    {
                        if (SaveFileText == ProductData(item))
                        {
                            return item;
                        }
                    }

                    _CurrentFileName = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show(
                        "Error: File could not be loaded.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }

            product Product = new product();
            Product.productID = -1;

            return Product;
        }

        /* FOLLOWING CODE IS NOT MINE
         * FOUND ON THIS PAGE: http://www.fluxbytes.com/csharp/convert-string-to-binary-and-binary-to-string-in-c/#crayon-5834a6eb5ad15468288020
         * RETRIEVED ON: November 25, 2016 (2016-11-25)
         * POSTED AS AN ARTICLE
         * POSTED BY: CooLMinE (http://www.fluxbytes.com/author/coolmine/)
         * vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
         */
        private static string EncryptProduct(string data)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                stringBuilder.Append(
                    Convert.ToString(c, 2).PadLeft(8, '0')
                    );
            }

            return stringBuilder.ToString();
        }
        private static string DecryptProduct(string data)
        {
            List<byte> byteList = new List<byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(
                    Convert.ToByte(data.Substring(i, 8), 2)
                    );
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        /* ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
         * THE ABOVE CODE IS NOT MINE
         * SOURCE LINKED ABOVE
         */

        public static void showAboutDialog()
        {
            MessageBox.Show(
                "Dollar Computers computer purchasing software v1.02\n\n"
                + "Created By: Naga Rimmalapudi | 200277598\n"
                + "Last Revised: December 1, 2016\n\n"
                + "COMP1004-F2016-Assignment 4\n"
                + "This application replicates the purchasing of computer hardware at a fake company called Dollar Computers. It uses an online SQL server and SQL database for all of the product information.",
                "About - Dollar Computers"
                );
        }

        private static string ProductData(product Product)
        {
            return Product.productID + Product.manufacturer + Product.model + Product.condition + Product.cost;
        }
    }
}
