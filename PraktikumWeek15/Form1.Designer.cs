namespace PraktikumWeek15
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
            this.labelBuDewi = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.labelMenu = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBoxMinuman = new System.Windows.Forms.GroupBox();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelNominal = new System.Windows.Forms.Label();
            this.groupBoxMinuman.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuDewi
            // 
            this.labelBuDewi.AutoSize = true;
            this.labelBuDewi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuDewi.Location = new System.Drawing.Point(187, 4);
            this.labelBuDewi.Name = "labelBuDewi";
            this.labelBuDewi.Size = new System.Drawing.Size(75, 20);
            this.labelBuDewi.TabIndex = 0;
            this.labelBuDewi.Text = "Bu Dewi";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(107, 35);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(37, 13);
            this.labelItems.TabIndex = 1;
            this.labelItems.Text = "Items";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(19, 66);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(141, 160);
            this.listBoxItems.TabIndex = 2;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(166, 66);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(112, 160);
            this.listBoxHarga.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(126, 236);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(303, 39);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 5;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(389, 39);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 6;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(302, 84);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(34, 13);
            this.labelMenu.TabIndex = 7;
            this.labelMenu.Text = "Menu";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(338, 81);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItems.TabIndex = 8;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(468, 86);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(42, 13);
            this.labelHarga.TabIndex = 9;
            this.labelHarga.Text = "Harga :";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(365, 203);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 10;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(456, 237);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(66, 20);
            this.buttonCheckOut.TabIndex = 11;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // groupBoxMinuman
            // 
            this.groupBoxMinuman.Controls.Add(this.radioButtonJumbo);
            this.groupBoxMinuman.Controls.Add(this.radioButtonNormal);
            this.groupBoxMinuman.Controls.Add(this.labelSize);
            this.groupBoxMinuman.Location = new System.Drawing.Point(305, 110);
            this.groupBoxMinuman.Name = "groupBoxMinuman";
            this.groupBoxMinuman.Size = new System.Drawing.Size(158, 80);
            this.groupBoxMinuman.TabIndex = 12;
            this.groupBoxMinuman.TabStop = false;
            this.groupBoxMinuman.Visible = false;
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(86, 48);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonJumbo.TabIndex = 2;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.CheckedChanged += new System.EventHandler(this.radioButtonJumbo_CheckedChanged);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(16, 48);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 1;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(16, 18);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size";
            // 
            // labelNominal
            // 
            this.labelNominal.AutoSize = true;
            this.labelNominal.Location = new System.Drawing.Point(516, 86);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(28, 13);
            this.labelNominal.TabIndex = 13;
            this.labelNominal.Text = ". . . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 314);
            this.Controls.Add(this.labelNominal);
            this.Controls.Add(this.groupBoxMinuman);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonMakanan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelBuDewi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMinuman.ResumeLayout(false);
            this.groupBoxMinuman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuDewi;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.GroupBox groupBoxMinuman;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelNominal;
    }
}

