﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem.Presentation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ProdLookup_Click(object sender, EventArgs e)
        {
            ProductLookup productLookup = new ProductLookup();
            this.Hide();
            productLookup.Tag = this.Text;
            productLookup.ShowDialog();
            
        }
    }
}
