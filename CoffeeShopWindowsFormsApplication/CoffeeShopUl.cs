using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopWindowsFormsApplication
{
    public partial class CoffeeShopUl : Form
    {
        public CoffeeShopUl()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {


            try
            {
                // Cappuccino = 175------
                // CoffeeLatte = 150-----
                // Whitecoffee = 125-----
                // BlueCoffee = 200------
                
                string customerName = customerNameTextBox.Text;
                string contactNo = contactNoTextBox.Text;
                string address = addressRichTextBox.Text;
                string selectedItem = selectCoffeeListcomboBox.Text;
               
                double unitPrice = 0.0;

                if (selectCoffeeListcomboBox.SelectedIndex == 0)
                {
                    unitPrice = 175;
                }


                else if (selectCoffeeListcomboBox.SelectedIndex == 1)
                {
                    unitPrice = 150;
                }

                else if (selectCoffeeListcomboBox.SelectedIndex == 2)
                {
                    unitPrice = 125;
                }

                else if (selectCoffeeListcomboBox.SelectedIndex == 3)
                {
                    unitPrice = 200;
                }

                double unit = Convert.ToDouble(unitTextBox.Text);

                double totalPrice = 0.0;

                if (unit > 3)
                {
                    totalPrice = (unit * unitPrice) - 50;
                }
                else
                {
                    totalPrice = (unit * unitPrice);
                }

                

                receptRichTextBox.Text = "JB COFFEE SHOP " + "\n" +
                                        "------------------------------ " + "\n" + "\n" + "\n" +

                                        "Customar Information :  " + "\n" +
                                        "----------------------------------------- " + "\n" +

                                        "Customar Name :  " + customerName + "\n" +
                                        "Contact No :  " + contactNo + "\n" +
                                        "Address :  " + address + "\n" + "\n" +

                                        "Shopping Details :  " + "\n" +
                                        "------------------------------------------" + "\n" +
                                        "Iteme Name :  " + selectedItem + "\n" +
                                        "Unit :  " + unit + "\n" +
                                        "Unit Price :  " + unitPrice + "\n" +
                                        "--------------------------------------------" + "\n" +
                                        "Total Price :  " + totalPrice + "\n" + "\n" +
                                        "Thanks for shopping. Have a nice day".ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }   
   
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receptRichTextBox.Text, new Font("Arial Rounded MT Bold", 16, FontStyle.Bold),
                                                                  Brushes.Black, new PointF(100, 100));
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Text
            = contactNoTextBox.Text
            = addressRichTextBox.Text
            = selectCoffeeListcomboBox.Text
            = unitTextBox.Text 
            = receptRichTextBox.Text
            = " ";
        }

        
       


      

       

       

     
    }
}
