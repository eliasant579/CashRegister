using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            int error = 0;
            //storing
            try
            {
                burgerN = Convert.ToInt16(burgersTextBox.Text);
                if (burgerN < 0)
                {
                    burgersTextBox.Text = null;
                    generalOutLabel.Text = "input error";
                    error++;
                }
            }
            catch
            {
                burgersTextBox.Text = null;
                generalOutLabel.Text = "input error";
                error++;
            }

            try
            {
                friesN = Convert.ToInt16(friesTextBox.Text);
                if (friesN < 0)
                {
                    friesTextBox.Text = null;
                    generalOutLabel.Text = "input error";
                    error++;
                }
            }
            catch
            {
                friesTextBox.Text = null;
                generalOutLabel.Text = "input error";
                error++;
            }

            try
            {
                drinkN = Convert.ToInt16(drinksTextBox.Text);
                if (drinkN < 0)
                {
                    drinksTextBox.Text = null;
                    generalOutLabel.Text = "input error";
                    error++;
                }
            }
            catch
            {
                drinksTextBox.Text = null;
                generalOutLabel.Text = "input error";
                error++;
            }

            //if there's more than one error it breaks here, so ALL the code preceding is processed
            if (error != 0)
            { return; }

            //some math stuff
            price = BURGER_PRICE * burgerN + FRIES_PRICE * friesN + DRINK_PRICE * drinkN;
            taxprice = TAX * price;
            total = taxprice + price;

            //output
            priceOutLabel.Text = price.ToString("C");
            taxOutLabel.Text = taxprice.ToString("C");
            totalOutLabel.Text = total.ToString("C");
            generalOutLabel.Text = null;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(tenderedTextBox.Text) < total)
                {
                    tenderedTextBox.Text = null;
                    generalOutLabel.Text = "input error";
                    return;
                }
                tendered = Convert.ToDouble(tenderedTextBox.Text);
                tendered -= total;
                changeOutLabel.Text = tendered.ToString("C");

                reciveButton.Visible = true;
            }
            catch
            {
                tenderedTextBox.Text = null;
                generalOutLabel.Text = "input error";
                return;
            }
        }

        private void reciveButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SoundPlayer recivePlayer = new SoundPlayer(Properties.Resources.open);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush rectangleBrush = new SolidBrush(Color.White);
            SolidBrush stringBrush = new SolidBrush(Color.Black);

            g.FillRectangle(rectangleBrush, 300, 50, 200, 250);


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

            reciveButton.Visible = false;

            burgerN = 0;
            friesN = 0;
            drinkN = 0;
            taxprice = 0;
            total = 0;
            price = 0;
            tendered = 0;

            //draw a rectangle with the form backcolor over the recive
            Graphics g = this.CreateGraphics();
            SolidBrush rectangleBrush = new SolidBrush(this.BackColor);

            g.FillRectangle(rectangleBrush, 300, 50, 200, 250);

        }
    }
}
