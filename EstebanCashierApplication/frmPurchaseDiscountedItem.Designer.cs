namespace EstebanCashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.Itemtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pricetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Discounttb = new System.Windows.Forms.TextBox();
            this.Quantitytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Computebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.Paymenttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // Itemtb
            // 
            this.Itemtb.Location = new System.Drawing.Point(62, 74);
            this.Itemtb.Name = "Itemtb";
            this.Itemtb.Size = new System.Drawing.Size(138, 20);
            this.Itemtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // Pricetb
            // 
            this.Pricetb.Location = new System.Drawing.Point(100, 110);
            this.Pricetb.Name = "Pricetb";
            this.Pricetb.Size = new System.Drawing.Size(100, 20);
            this.Pricetb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount(%):";
            // 
            // Discounttb
            // 
            this.Discounttb.Location = new System.Drawing.Point(209, 74);
            this.Discounttb.Name = "Discounttb";
            this.Discounttb.Size = new System.Drawing.Size(100, 20);
            this.Discounttb.TabIndex = 5;
            // 
            // Quantitytb
            // 
            this.Quantitytb.Location = new System.Drawing.Point(261, 110);
            this.Quantitytb.Name = "Quantitytb";
            this.Quantitytb.Size = new System.Drawing.Size(48, 20);
            this.Quantitytb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // Computebtn
            // 
            this.Computebtn.Location = new System.Drawing.Point(154, 146);
            this.Computebtn.Name = "Computebtn";
            this.Computebtn.Size = new System.Drawing.Size(75, 23);
            this.Computebtn.TabIndex = 8;
            this.Computebtn.Text = "Compute";
            this.Computebtn.UseVisualStyleBackColor = true;
            this.Computebtn.Click += new System.EventHandler(this.Computebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total amount:";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(170, 184);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(16, 13);
            this.TotalAmount.TabIndex = 10;
            this.TotalAmount.Text = "...";
            // 
            // Paymenttb
            // 
            this.Paymenttb.Location = new System.Drawing.Point(154, 219);
            this.Paymenttb.Name = "Paymenttb";
            this.Paymenttb.Size = new System.Drawing.Size(94, 20);
            this.Paymenttb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment received:";
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(252, 217);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(57, 23);
            this.Submitbtn.TabIndex = 13;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(170, 255);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(16, 13);
            this.Change.TabIndex = 15;
            this.Change.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Change:";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 347);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Paymenttb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Computebtn);
            this.Controls.Add(this.Quantitytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Discounttb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pricetb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Itemtb);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.Load += new System.EventHandler(this.frmPurchaseDiscountedItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Itemtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pricetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Discounttb;
        private System.Windows.Forms.TextBox Quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Computebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.TextBox Paymenttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Label label9;
    }
}

