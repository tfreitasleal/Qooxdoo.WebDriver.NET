﻿using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.SimpleDemo
{
    public partial class ButtonsWindow : Form
    {
        public ButtonsWindow()
        {
            InitializeComponent();
        }

        private void customerEditor_Click(object sender, EventArgs e)
        {
            var customerEditorWindow = new CustomerEditor();
            customerEditorWindow.ShowDialog(this);
        }

        private void supplierEditor_Click(object sender, EventArgs e)
        {
            AlertBox.Show("Supplier Editor must be implemented", MessageBoxIcon.Error, true, ContentAlignment.BottomRight, 120000);
            AlertBox.Show("Supplier Editor should be implemented", MessageBoxIcon.Warning, true, ContentAlignment.BottomRight, 120000);
            AlertBox.Show("Supplier Editor will be implemented", MessageBoxIcon.Information, true, ContentAlignment.BottomRight, 120000);
        }
    }
}