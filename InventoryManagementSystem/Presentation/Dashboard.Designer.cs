namespace InventoryManagementSystem.Presentation
{
    partial class Dashboard
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lbl_BinFunc = new System.Windows.Forms.Label();
            btn_MoveInventory = new System.Windows.Forms.Button();
            btn_StockIn = new System.Windows.Forms.Button();
            btn_StockOut = new System.Windows.Forms.Button();
            btn_ProdLookup = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btn_LogOut = new System.Windows.Forms.Button();
            btn_AddLocation = new System.Windows.Forms.Button();
            btn_AddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbl_BinFunc);
            splitContainer1.Panel1.Controls.Add(btn_MoveInventory);
            splitContainer1.Panel1.Controls.Add(btn_StockIn);
            splitContainer1.Panel1.Controls.Add(btn_StockOut);
            splitContainer1.Panel1.Controls.Add(btn_ProdLookup);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(btn_LogOut);
            splitContainer1.Panel2.Controls.Add(btn_AddLocation);
            splitContainer1.Panel2.Controls.Add(btn_AddProduct);
            splitContainer1.Size = new System.Drawing.Size(800, 450);
            splitContainer1.SplitterDistance = 404;
            splitContainer1.TabIndex = 0;
            // 
            // lbl_BinFunc
            // 
            lbl_BinFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_BinFunc.AutoSize = true;
            lbl_BinFunc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BinFunc.ForeColor = System.Drawing.SystemColors.Window;
            lbl_BinFunc.Location = new System.Drawing.Point(21, 14);
            lbl_BinFunc.Name = "lbl_BinFunc";
            lbl_BinFunc.Size = new System.Drawing.Size(137, 30);
            lbl_BinFunc.TabIndex = 4;
            lbl_BinFunc.Text = "Bin Functions";
            lbl_BinFunc.Click += label1_Click;
            // 
            // btn_MoveInventory
            // 
            btn_MoveInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_MoveInventory.Location = new System.Drawing.Point(113, 345);
            btn_MoveInventory.Name = "btn_MoveInventory";
            btn_MoveInventory.Size = new System.Drawing.Size(160, 44);
            btn_MoveInventory.TabIndex = 3;
            btn_MoveInventory.Text = "Move Inventory";
            btn_MoveInventory.UseVisualStyleBackColor = true;
            // 
            // btn_StockIn
            // 
            btn_StockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_StockIn.Location = new System.Drawing.Point(113, 248);
            btn_StockIn.Name = "btn_StockIn";
            btn_StockIn.Size = new System.Drawing.Size(160, 44);
            btn_StockIn.TabIndex = 2;
            btn_StockIn.Text = "Stock In";
            btn_StockIn.UseVisualStyleBackColor = true;
            // 
            // btn_StockOut
            // 
            btn_StockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_StockOut.Location = new System.Drawing.Point(113, 161);
            btn_StockOut.Name = "btn_StockOut";
            btn_StockOut.Size = new System.Drawing.Size(160, 44);
            btn_StockOut.TabIndex = 1;
            btn_StockOut.Text = "Stock Out";
            btn_StockOut.UseVisualStyleBackColor = true;
            // 
            // btn_ProdLookup
            // 
            btn_ProdLookup.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_ProdLookup.Location = new System.Drawing.Point(113, 69);
            btn_ProdLookup.Name = "btn_ProdLookup";
            btn_ProdLookup.Size = new System.Drawing.Size(160, 44);
            btn_ProdLookup.TabIndex = 0;
            btn_ProdLookup.Text = "Product Lookup";
            btn_ProdLookup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Window;
            label1.Location = new System.Drawing.Point(19, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 30);
            label1.TabIndex = 5;
            label1.Text = "User Functions";
            // 
            // btn_LogOut
            // 
            btn_LogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_LogOut.Location = new System.Drawing.Point(192, 363);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new System.Drawing.Size(90, 26);
            btn_LogOut.TabIndex = 4;
            btn_LogOut.Text = "Log Out";
            btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_AddLocation
            // 
            btn_AddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_AddLocation.Location = new System.Drawing.Point(122, 161);
            btn_AddLocation.Name = "btn_AddLocation";
            btn_AddLocation.Size = new System.Drawing.Size(160, 44);
            btn_AddLocation.TabIndex = 2;
            btn_AddLocation.Text = "Add Location";
            btn_AddLocation.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_AddProduct.Location = new System.Drawing.Point(122, 69);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new System.Drawing.Size(160, 44);
            btn_AddProduct.TabIndex = 1;
            btn_AddProduct.Text = "Add Product";
            btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Highlight;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(splitContainer1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_BinFunc;
        private System.Windows.Forms.Button btn_MoveInventory;
        private System.Windows.Forms.Button btn_StockIn;
        private System.Windows.Forms.Button btn_StockOut;
        private System.Windows.Forms.Button btn_ProdLookup;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_AddLocation;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label label1;
    }
}