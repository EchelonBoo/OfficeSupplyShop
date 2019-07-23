namespace OfficeSupply
{
    partial class frmUpdateSalesLines
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
            this.btnExit2 = new System.Windows.Forms.Button();
            this.txtShortDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdateSalesLines = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(59, 228);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(112, 37);
            this.btnExit2.TabIndex = 26;
            this.btnExit2.Text = "E&xit";
            this.btnExit2.UseVisualStyleBackColor = true;
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.Location = new System.Drawing.Point(180, 127);
            this.txtShortDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.ReadOnly = true;
            this.txtShortDesc.Size = new System.Drawing.Size(160, 22);
            this.txtShortDesc.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Short Desc:";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(180, 32);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(160, 24);
            this.productComboBox.TabIndex = 23;
            // 
            // btnUpdateSalesLines
            // 
            this.btnUpdateSalesLines.Location = new System.Drawing.Point(228, 228);
            this.btnUpdateSalesLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateSalesLines.Name = "btnUpdateSalesLines";
            this.btnUpdateSalesLines.Size = new System.Drawing.Size(112, 37);
            this.btnUpdateSalesLines.TabIndex = 22;
            this.btnUpdateSalesLines.Text = "&Update";
            this.btnUpdateSalesLines.UseVisualStyleBackColor = true;
            this.btnUpdateSalesLines.Click += new System.EventHandler(this.btnUpdateSalesLines_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 173);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(180, 168);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(160, 22);
            this.txtTotal.TabIndex = 20;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(180, 75);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(160, 22);
            this.txtQty.TabIndex = 19;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(13, 78);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(115, 17);
            this.lblQty.TabIndex = 18;
            this.lblQty.Text = "Enter a Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(13, 32);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(91, 17);
            this.lblProduct.TabIndex = 17;
            this.lblProduct.Text = "Pick Product:";
            // 
            // frmUpdateSalesLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 302);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.txtShortDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.btnUpdateSalesLines);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblProduct);
            this.Name = "frmUpdateSalesLines";
            this.Text = "frmUpdateSalesLines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.TextBox txtShortDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button btnUpdateSalesLines;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProduct;
    }
}