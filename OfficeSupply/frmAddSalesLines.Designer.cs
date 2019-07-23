namespace OfficeSupply
{
    partial class frmAddSalesLines
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddSalesLines = new System.Windows.Forms.Button();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShortDesc = new System.Windows.Forms.TextBox();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(17, 46);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(91, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Pick Product:";
            
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(17, 92);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(115, 17);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Enter a Quantity:";
            
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(184, 89);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(160, 22);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(185, 182);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(160, 22);
            this.txtTotal.TabIndex = 4;
           
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 187);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
           
            // 
            // btnAddSalesLines
            // 
            this.btnAddSalesLines.Location = new System.Drawing.Point(233, 243);
            this.btnAddSalesLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSalesLines.Name = "btnAddSalesLines";
            this.btnAddSalesLines.Size = new System.Drawing.Size(112, 37);
            this.btnAddSalesLines.TabIndex = 10;
            this.btnAddSalesLines.Text = "&Add";
            this.btnAddSalesLines.UseVisualStyleBackColor = true;
            this.btnAddSalesLines.Click += new System.EventHandler(this.btnAddSalesLines_Click);
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(184, 46);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(160, 24);
            this.productComboBox.TabIndex = 11;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Short Desc:";
            
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.Location = new System.Drawing.Point(184, 134);
            this.txtShortDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.ReadOnly = true;
            this.txtShortDesc.Size = new System.Drawing.Size(160, 22);
            this.txtShortDesc.TabIndex = 13;
            
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(68, 243);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(112, 37);
            this.btnExit2.TabIndex = 14;
            this.btnExit2.Text = "E&xit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // frmAddSalesLines
            // 
            this.AcceptButton = this.btnAddSalesLines;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 310);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.txtShortDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.btnAddSalesLines);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddSalesLines";
            this.Text = "AddSalesLines";
            this.Load += new System.EventHandler(this.AddSalesLines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddSalesLines;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShortDesc;
        private System.Windows.Forms.Button btnExit2;
    }
}