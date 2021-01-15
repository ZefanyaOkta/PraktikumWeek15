namespace PraktikumWeek15
{
    partial class Form2
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
            this.checkBoxDiskon = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxDiskon = new System.Windows.Forms.GroupBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.groupBoxDiskon.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDiskon
            // 
            this.checkBoxDiskon.AutoSize = true;
            this.checkBoxDiskon.Location = new System.Drawing.Point(25, 29);
            this.checkBoxDiskon.Name = "checkBoxDiskon";
            this.checkBoxDiskon.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDiskon.TabIndex = 0;
            this.checkBoxDiskon.Text = "Discount";
            this.checkBoxDiskon.UseVisualStyleBackColor = true;
            this.checkBoxDiskon.CheckedChanged += new System.EventHandler(this.checkBoxDiskon_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(18, 109);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(256, 33);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(256, 64);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(25, 13);
            this.labelTax.TabIndex = 3;
            this.labelTax.Text = "Tax";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(256, 94);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(49, 13);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(256, 122);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // groupBoxDiskon
            // 
            this.groupBoxDiskon.Controls.Add(this.textBoxDiskon);
            this.groupBoxDiskon.Controls.Add(this.labelInput);
            this.groupBoxDiskon.Location = new System.Drawing.Point(25, 52);
            this.groupBoxDiskon.Name = "groupBoxDiskon";
            this.groupBoxDiskon.Size = new System.Drawing.Size(131, 43);
            this.groupBoxDiskon.TabIndex = 6;
            this.groupBoxDiskon.TabStop = false;
            this.groupBoxDiskon.Visible = false;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(6, 16);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(43, 13);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(82, 20);
            this.textBoxDiskon.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 312);
            this.Controls.Add(this.groupBoxDiskon);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxDiskon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxDiskon.ResumeLayout(false);
            this.groupBoxDiskon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDiskon;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBoxDiskon;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label labelInput;
    }
}