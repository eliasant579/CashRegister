using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        const double TAX = 0.13;
        const double BURGER_PRICE = 2.49, FRIES_PRICE = 1.89, DRINK_PRICE = 0.99;
        int burgerN, friesN, drinkN;
        double taxprice, total, price, tendered;

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //storing
            try { burgerN = Convert.ToInt16(burgersTextBox.Text); }
            catch { }
            try { friesN = Convert.ToInt16(friesTextBox.Text); }
            catch { }
            try { drinkN = Convert.ToInt16(drinksTextBox.Text); }
            catch { }

            //some math stuff
            price = BURGER_PRICE * burgerN + FRIES_PRICE * friesN + DRINK_PRICE * drinkN;
            taxprice = TAX * price;
            total = taxprice + price;

            //output
            priceOutLabel.Text = price.ToString("C");
            taxOutLabel.Text = taxprice.ToString("C");
            totalOutLabel.Text = total.ToString("C");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedTextBox.Text);
            tendered -= total;
            changeOutLabel.Text = tendered.ToString("C");
        }

        private void newOrderLabel_Click(object sender, EventArgs e)
        {
            burgersTextBox.Text = null;
            friesTextBox.Text = null;
            drinksTextBox.Text = null;

            totalOutLabel.Text = null;
            taxOutLabel.Text = null;
            priceOutLabel.Text = null;
            changeOutLabel.Text = null;
            tenderedTextBox.Text = null;
        }
    }
}
