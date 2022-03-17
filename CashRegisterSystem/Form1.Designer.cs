
namespace CashRegisterSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewProductButt = new System.Windows.Forms.Button();
            this.TransactButt = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewProductButt
            // 
            this.NewProductButt.Location = new System.Drawing.Point(0, 12);
            this.NewProductButt.Name = "NewProductButt";
            this.NewProductButt.Size = new System.Drawing.Size(111, 49);
            this.NewProductButt.TabIndex = 2;
            this.NewProductButt.Text = "New Product";
            this.NewProductButt.UseVisualStyleBackColor = true;
            this.NewProductButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactButt
            // 
            this.TransactButt.Location = new System.Drawing.Point(235, 12);
            this.TransactButt.Name = "TransactButt";
            this.TransactButt.Size = new System.Drawing.Size(111, 48);
            this.TransactButt.TabIndex = 2;
            this.TransactButt.Text = "Transactions";
            this.TransactButt.UseVisualStyleBackColor = true;
            this.TransactButt.Click += new System.EventHandler(this.TransactButt_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(352, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(111, 48);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(96, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 449);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(0, 97);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 50);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update list";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 516);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.TransactButt);
            this.Controls.Add(this.NewProductButt);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewProductButt;
        private System.Windows.Forms.Button TransactButt;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
    }
}

