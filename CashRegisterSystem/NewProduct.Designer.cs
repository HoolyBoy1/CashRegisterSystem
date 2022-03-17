
namespace CashRegisterSystem
{
    partial class NewProduct
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NamePrice = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.Confirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(3, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(129, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name of product:\r\n";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NameText.Location = new System.Drawing.Point(6, 44);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(185, 22);
            this.NameText.TabIndex = 1;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 83);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(112, 17);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price of product:";
            // 
            // NamePrice
            // 
            this.NamePrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NamePrice.Location = new System.Drawing.Point(6, 103);
            this.NamePrice.Name = "NamePrice";
            this.NamePrice.Size = new System.Drawing.Size(185, 22);
            this.NamePrice.TabIndex = 3;
            this.NamePrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(3, 143);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(56, 17);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount";
            this.AmountLabel.Click += new System.EventHandler(this.AmountLabel_Click);
            // 
            // AmountText
            // 
            this.AmountText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AmountText.Location = new System.Drawing.Point(6, 163);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(185, 22);
            this.AmountText.TabIndex = 5;
            this.AmountText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Confirmation
            // 
            this.Confirmation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Confirmation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Confirmation.Location = new System.Drawing.Point(269, 190);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(114, 33);
            this.Confirmation.TabIndex = 6;
            this.Confirmation.Text = "Okey";
            this.Confirmation.UseVisualStyleBackColor = false;
            this.Confirmation.Click += new System.EventHandler(this.Confirmation_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 223);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NamePrice);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox NamePrice;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Button Confirmation;
    }
}