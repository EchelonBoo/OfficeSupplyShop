namespace OfficeSupply
{
    partial class frmProductDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductShortDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductLongDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductReorderLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductReorderAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductUnitPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductSupplierID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductMarkup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateProductDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(135, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(135, 56);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtProductShortDescription
            // 
            this.txtProductShortDescription.Location = new System.Drawing.Point(135, 82);
            this.txtProductShortDescription.Name = "txtProductShortDescription";
            this.txtProductShortDescription.Size = new System.Drawing.Size(100, 20);
            this.txtProductShortDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Short Description:";
            // 
            // txtProductLongDescription
            // 
            this.txtProductLongDescription.Location = new System.Drawing.Point(135, 108);
            this.txtProductLongDescription.Name = "txtProductLongDescription";
            this.txtProductLongDescription.Size = new System.Drawing.Size(100, 20);
            this.txtProductLongDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Long Description:";
            // 
            // txtProductReorderLevel
            // 
            this.txtProductReorderLevel.Location = new System.Drawing.Point(135, 216);
            this.txtProductReorderLevel.Name = "txtProductReorderLevel";
            this.txtProductReorderLevel.Size = new System.Drawing.Size(100, 20);
            this.txtProductReorderLevel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reorder Level";
            // 
            // txtProductReorderAmount
            // 
            this.txtProductReorderAmount.Location = new System.Drawing.Point(135, 190);
            this.txtProductReorderAmount.Name = "txtProductReorderAmount";
            this.txtProductReorderAmount.Size = new System.Drawing.Size(100, 20);
            this.txtProductReorderAmount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reorder Amount:";
            // 
            // txtProductUnitPrice
            // 
            this.txtProductUnitPrice.Location = new System.Drawing.Point(135, 164);
            this.txtProductUnitPrice.Name = "txtProductUnitPrice";
            this.txtProductUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductUnitPrice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Unit Price:";
            // 
            // txtProductSupplierID
            // 
            this.txtProductSupplierID.Location = new System.Drawing.Point(135, 137);
            this.txtProductSupplierID.Name = "txtProductSupplierID";
            this.txtProductSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtProductSupplierID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Supplier ID:";
            // 
            // txtProductMarkup
            // 
            this.txtProductMarkup.Location = new System.Drawing.Point(135, 242);
            this.txtProductMarkup.Name = "txtProductMarkup";
            this.txtProductMarkup.Size = new System.Drawing.Size(100, 20);
            this.txtProductMarkup.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Markup:";
            // 
            // btnUpdateProductDetails
            // 
            this.btnUpdateProductDetails.AllowDrop = true;
            this.btnUpdateProductDetails.Location = new System.Drawing.Point(160, 288);
            this.btnUpdateProductDetails.Name = "btnUpdateProductDetails";
            this.btnUpdateProductDetails.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProductDetails.TabIndex = 19;
            this.btnUpdateProductDetails.Text = "Add/Update";
            this.btnUpdateProductDetails.UseVisualStyleBackColor = true;
            this.btnUpdateProductDetails.Click += new System.EventHandler(this.btnUpdateProductDetails_Click);
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 358);
            this.Controls.Add(this.btnUpdateProductDetails);
            this.Controls.Add(this.txtProductMarkup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProductReorderLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductReorderAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductUnitPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductSupplierID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProductLongDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductShortDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "frmProductDetails";
            this.Text = "Add or Update Product";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductShortDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductLongDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductReorderLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductReorderAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductSupplierID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductMarkup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateProductDetails;
    }
}