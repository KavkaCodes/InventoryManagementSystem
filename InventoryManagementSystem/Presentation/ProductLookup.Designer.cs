namespace InventoryManagementSystem.Presentation
{
    partial class ProductLookup
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
            txt_ProductId = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            btn_GetProduct = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            lbl_ProductId = new System.Windows.Forms.Label();
            lbl_ProductInfo = new System.Windows.Forms.Label();
            lbl_ProductInv = new System.Windows.Forms.Label();
            btn_Cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txt_ProductId
            // 
            txt_ProductId.Location = new System.Drawing.Point(187, 29);
            txt_ProductId.Name = "txt_ProductId";
            txt_ProductId.Size = new System.Drawing.Size(185, 23);
            txt_ProductId.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(187, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(454, 184);
            listBox1.TabIndex = 1;
            // 
            // btn_GetProduct
            // 
            btn_GetProduct.Location = new System.Drawing.Point(508, 29);
            btn_GetProduct.Name = "btn_GetProduct";
            btn_GetProduct.Size = new System.Drawing.Size(133, 23);
            btn_GetProduct.TabIndex = 2;
            btn_GetProduct.Text = "Get Product";
            btn_GetProduct.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(187, 83);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(454, 97);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_ProductId
            // 
            lbl_ProductId.AutoSize = true;
            lbl_ProductId.Location = new System.Drawing.Point(116, 33);
            lbl_ProductId.Name = "lbl_ProductId";
            lbl_ProductId.Size = new System.Drawing.Size(65, 15);
            lbl_ProductId.TabIndex = 4;
            lbl_ProductId.Text = "Product Id:";
            lbl_ProductId.Click += label1_Click;
            // 
            // lbl_ProductInfo
            // 
            lbl_ProductInfo.AutoSize = true;
            lbl_ProductInfo.Location = new System.Drawing.Point(102, 83);
            lbl_ProductInfo.Name = "lbl_ProductInfo";
            lbl_ProductInfo.Size = new System.Drawing.Size(79, 15);
            lbl_ProductInfo.TabIndex = 5;
            lbl_ProductInfo.Text = "Proiduct Info:";
            // 
            // lbl_ProductInv
            // 
            lbl_ProductInv.AutoSize = true;
            lbl_ProductInv.Location = new System.Drawing.Point(121, 195);
            lbl_ProductInv.Name = "lbl_ProductInv";
            lbl_ProductInv.Size = new System.Drawing.Size(60, 15);
            lbl_ProductInv.TabIndex = 6;
            lbl_ProductInv.Text = "Inventory:";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new System.Drawing.Point(528, 403);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(113, 23);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "&Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // ProductLookup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Highlight;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_Cancel);
            Controls.Add(lbl_ProductInv);
            Controls.Add(lbl_ProductInfo);
            Controls.Add(lbl_ProductId);
            Controls.Add(listView1);
            Controls.Add(btn_GetProduct);
            Controls.Add(listBox1);
            Controls.Add(txt_ProductId);
            Name = "ProductLookup";
            Text = "ProductLookup";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_GetProduct;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_ProductId;
        private System.Windows.Forms.Label lbl_ProductInfo;
        private System.Windows.Forms.Label lbl_ProductInv;
        private System.Windows.Forms.Button btn_Cancel;
    }
}