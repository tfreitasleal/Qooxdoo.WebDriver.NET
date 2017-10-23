﻿namespace Wisej.SimpleDemo
{
    partial class ButtonsWindow
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonsPanel = new Wisej.Web.FlowLayoutPanel();
            this.customerEditor = new Wisej.Web.Button();
            this.supplierEditor = new Wisej.Web.Button();
            this.productEditor = new Wisej.Web.Button();
            this.orderEditor = new Wisej.Web.Button();
            this.invoiceEditor = new Wisej.Web.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.customerEditor);
            this.buttonsPanel.Controls.Add(this.supplierEditor);
            this.buttonsPanel.Controls.Add(this.productEditor);
            this.buttonsPanel.Controls.Add(this.orderEditor);
            this.buttonsPanel.Controls.Add(this.invoiceEditor);
            this.buttonsPanel.Dock = Wisej.Web.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(250, 480);
            this.buttonsPanel.TabIndex = 1;
            // 
            // customerEditor
            // 
            this.customerEditor.Location = new System.Drawing.Point(20, 50);
            this.customerEditor.Margin = new Wisej.Web.Padding(20, 50, 10, 25);
            this.customerEditor.Name = "customerEditor";
            this.customerEditor.Size = new System.Drawing.Size(180, 40);
            this.customerEditor.TabIndex = 0;
            this.customerEditor.Text = "1 - Customer Editor";
            this.customerEditor.Click += new System.EventHandler(this.customerEditor_Click);
            // 
            // supplierEditor
            // 
            this.supplierEditor.Location = new System.Drawing.Point(20, 135);
            this.supplierEditor.Margin = new Wisej.Web.Padding(20, 20, 10, 25);
            this.supplierEditor.Name = "supplierEditor";
            this.supplierEditor.Size = new System.Drawing.Size(180, 40);
            this.supplierEditor.TabIndex = 1;
            this.supplierEditor.Text = "2 - Supplier Editor";
            // 
            // productEditor
            // 
            this.productEditor.Location = new System.Drawing.Point(20, 220);
            this.productEditor.Margin = new Wisej.Web.Padding(20, 20, 10, 25);
            this.productEditor.Name = "productEditor";
            this.productEditor.Size = new System.Drawing.Size(180, 40);
            this.productEditor.TabIndex = 2;
            this.productEditor.Text = "3 - Product Editor";
            // 
            // orderEditor
            // 
            this.orderEditor.Location = new System.Drawing.Point(20, 305);
            this.orderEditor.Margin = new Wisej.Web.Padding(20, 20, 10, 25);
            this.orderEditor.Name = "orderEditor";
            this.orderEditor.Size = new System.Drawing.Size(180, 40);
            this.orderEditor.TabIndex = 3;
            this.orderEditor.Text = "4 - Order Editor";
            // 
            // invoiceEditor
            // 
            this.invoiceEditor.Location = new System.Drawing.Point(20, 390);
            this.invoiceEditor.Margin = new Wisej.Web.Padding(20, 20, 10, 25);
            this.invoiceEditor.Name = "invoiceEditor";
            this.invoiceEditor.Size = new System.Drawing.Size(180, 40);
            this.invoiceEditor.TabIndex = 4;
            this.invoiceEditor.Text = "5 - Invoice Editor";
            // 
            // ButtonsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 480);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "ButtonsWindow";
            this.Text = "Buttons Window";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.FlowLayoutPanel buttonsPanel;
        private Web.Button customerEditor;
        private Web.Button supplierEditor;
        private Web.Button productEditor;
        private Web.Button orderEditor;
        private Web.Button invoiceEditor;
    }
}