﻿namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.burgersTextBox = new System.Windows.Forms.TextBox();
            this.friesTextBox = new System.Windows.Forms.TextBox();
            this.drinksTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.priceTextLabel = new System.Windows.Forms.Label();
            this.taxTextLabel = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.priceOutLabel = new System.Windows.Forms.Label();
            this.taxOutLabel = new System.Windows.Forms.Label();
            this.totalOutLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tenderedTextLabel = new System.Windows.Forms.Label();
            this.changeTextLabel = new System.Windows.Forms.Label();
            this.changeOutLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.newOrderLabel = new System.Windows.Forms.Button();
            this.reciveButton = new System.Windows.Forms.Button();
            this.generalOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.BackColor = System.Drawing.Color.Transparent;
            this.burgerLabel.Location = new System.Drawing.Point(80, 66);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(58, 17);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.BackColor = System.Drawing.Color.Transparent;
            this.friesLabel.Location = new System.Drawing.Point(80, 94);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(39, 17);
            this.friesLabel.TabIndex = 1;
            this.friesLabel.Text = "Fries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(80, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks";
            // 
            // burgersTextBox
            // 
            this.burgersTextBox.Location = new System.Drawing.Point(198, 63);
            this.burgersTextBox.Name = "burgersTextBox";
            this.burgersTextBox.Size = new System.Drawing.Size(100, 22);
            this.burgersTextBox.TabIndex = 3;
            // 
            // friesTextBox
            // 
            this.friesTextBox.Location = new System.Drawing.Point(197, 91);
            this.friesTextBox.Name = "friesTextBox";
            this.friesTextBox.Size = new System.Drawing.Size(100, 22);
            this.friesTextBox.TabIndex = 4;
            // 
            // drinksTextBox
            // 
            this.drinksTextBox.Location = new System.Drawing.Point(198, 119);
            this.drinksTextBox.Name = "drinksTextBox";
            this.drinksTextBox.Size = new System.Drawing.Size(100, 22);
            this.drinksTextBox.TabIndex = 5;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Red;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Location = new System.Drawing.Point(83, 154);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(215, 30);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // priceTextLabel
            // 
            this.priceTextLabel.AutoSize = true;
            this.priceTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceTextLabel.Location = new System.Drawing.Point(80, 200);
            this.priceTextLabel.Name = "priceTextLabel";
            this.priceTextLabel.Size = new System.Drawing.Size(36, 17);
            this.priceTextLabel.TabIndex = 7;
            this.priceTextLabel.Text = "Cost";
            // 
            // taxTextLabel
            // 
            this.taxTextLabel.AutoSize = true;
            this.taxTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxTextLabel.Location = new System.Drawing.Point(80, 227);
            this.taxTextLabel.Name = "taxTextLabel";
            this.taxTextLabel.Size = new System.Drawing.Size(31, 17);
            this.taxTextLabel.TabIndex = 8;
            this.taxTextLabel.Text = "Tax";
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.AutoSize = true;
            this.totalTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTextLabel.Location = new System.Drawing.Point(80, 254);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.Size = new System.Drawing.Size(40, 17);
            this.totalTextLabel.TabIndex = 9;
            this.totalTextLabel.Text = "Total";
            // 
            // priceOutLabel
            // 
            this.priceOutLabel.AutoSize = true;
            this.priceOutLabel.Location = new System.Drawing.Point(252, 200);
            this.priceOutLabel.Name = "priceOutLabel";
            this.priceOutLabel.Size = new System.Drawing.Size(0, 17);
            this.priceOutLabel.TabIndex = 10;
            // 
            // taxOutLabel
            // 
            this.taxOutLabel.AutoSize = true;
            this.taxOutLabel.Location = new System.Drawing.Point(252, 227);
            this.taxOutLabel.Name = "taxOutLabel";
            this.taxOutLabel.Size = new System.Drawing.Size(0, 17);
            this.taxOutLabel.TabIndex = 11;
            // 
            // totalOutLabel
            // 
            this.totalOutLabel.AutoSize = true;
            this.totalOutLabel.Location = new System.Drawing.Point(252, 254);
            this.totalOutLabel.Name = "totalOutLabel";
            this.totalOutLabel.Size = new System.Drawing.Size(0, 17);
            this.totalOutLabel.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(81, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 10);
            this.label10.TabIndex = 13;
            // 
            // tenderedTextLabel
            // 
            this.tenderedTextLabel.AutoSize = true;
            this.tenderedTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedTextLabel.Location = new System.Drawing.Point(80, 301);
            this.tenderedTextLabel.Name = "tenderedTextLabel";
            this.tenderedTextLabel.Size = new System.Drawing.Size(70, 17);
            this.tenderedTextLabel.TabIndex = 14;
            this.tenderedTextLabel.Text = "Tendered";
            // 
            // changeTextLabel
            // 
            this.changeTextLabel.AutoSize = true;
            this.changeTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeTextLabel.Location = new System.Drawing.Point(81, 374);
            this.changeTextLabel.Name = "changeTextLabel";
            this.changeTextLabel.Size = new System.Drawing.Size(57, 17);
            this.changeTextLabel.TabIndex = 15;
            this.changeTextLabel.Text = "Change";
            // 
            // changeOutLabel
            // 
            this.changeOutLabel.AutoSize = true;
            this.changeOutLabel.Location = new System.Drawing.Point(252, 374);
            this.changeOutLabel.Name = "changeOutLabel";
            this.changeOutLabel.Size = new System.Drawing.Size(0, 17);
            this.changeOutLabel.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Red;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(82, 329);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(215, 32);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(198, 301);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenderedTextBox.TabIndex = 18;
            // 
            // newOrderLabel
            // 
            this.newOrderLabel.BackColor = System.Drawing.Color.Red;
            this.newOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderLabel.Location = new System.Drawing.Point(425, 395);
            this.newOrderLabel.Name = "newOrderLabel";
            this.newOrderLabel.Size = new System.Drawing.Size(215, 35);
            this.newOrderLabel.TabIndex = 19;
            this.newOrderLabel.Text = "New Order";
            this.newOrderLabel.UseVisualStyleBackColor = false;
            this.newOrderLabel.Click += new System.EventHandler(this.newOrderLabel_Click);
            // 
            // reciveButton
            // 
            this.reciveButton.BackColor = System.Drawing.Color.Red;
            this.reciveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveButton.Location = new System.Drawing.Point(84, 397);
            this.reciveButton.Name = "reciveButton";
            this.reciveButton.Size = new System.Drawing.Size(214, 30);
            this.reciveButton.TabIndex = 20;
            this.reciveButton.Text = "Print recive";
            this.reciveButton.UseVisualStyleBackColor = false;
            this.reciveButton.Visible = false;
            this.reciveButton.Click += new System.EventHandler(this.reciveButton_Click);
            // 
            // generalOutLabel
            // 
            this.generalOutLabel.AutoSize = true;
            this.generalOutLabel.Location = new System.Drawing.Point(255, 22);
            this.generalOutLabel.Name = "generalOutLabel";
            this.generalOutLabel.Size = new System.Drawing.Size(0, 17);
            this.generalOutLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generalOutLabel);
            this.Controls.Add(this.reciveButton);
            this.Controls.Add(this.newOrderLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeOutLabel);
            this.Controls.Add(this.changeTextLabel);
            this.Controls.Add(this.tenderedTextLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalOutLabel);
            this.Controls.Add(this.taxOutLabel);
            this.Controls.Add(this.priceOutLabel);
            this.Controls.Add(this.totalTextLabel);
            this.Controls.Add(this.taxTextLabel);
            this.Controls.Add(this.priceTextLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinksTextBox);
            this.Controls.Add(this.friesTextBox);
            this.Controls.Add(this.burgersTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox burgersTextBox;
        private System.Windows.Forms.TextBox friesTextBox;
        private System.Windows.Forms.TextBox drinksTextBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label priceTextLabel;
        private System.Windows.Forms.Label taxTextLabel;
        private System.Windows.Forms.Label totalTextLabel;
        private System.Windows.Forms.Label priceOutLabel;
        private System.Windows.Forms.Label taxOutLabel;
        private System.Windows.Forms.Label totalOutLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tenderedTextLabel;
        private System.Windows.Forms.Label changeTextLabel;
        private System.Windows.Forms.Label changeOutLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Button newOrderLabel;
        private System.Windows.Forms.Button reciveButton;
        private System.Windows.Forms.Label generalOutLabel;
    }
}

