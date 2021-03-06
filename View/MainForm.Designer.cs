﻿namespace GroupAProducts.View
{
    partial class MainForm
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
            this.dGV_ProductList = new System.Windows.Forms.DataGridView();
            this.rownum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcatname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ProductList
            // 
            this.dGV_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rownum,
            this.ProductID,
            this.PCatID,
            this.BrandID,
            this.BrandName,
            this.ProductName,
            this.pcatname,
            this.Qty});
            this.dGV_ProductList.Location = new System.Drawing.Point(12, 89);
            this.dGV_ProductList.Name = "dGV_ProductList";
            this.dGV_ProductList.Size = new System.Drawing.Size(470, 362);
            this.dGV_ProductList.TabIndex = 0;
            this.dGV_ProductList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_ProductList_CellMouseClick);
            // 
            // rownum
            // 
            this.rownum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rownum.DataPropertyName = "rownum";
            this.rownum.HeaderText = "No.";
            this.rownum.Name = "rownum";
            this.rownum.ReadOnly = true;
            this.rownum.Width = 49;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductID.DataPropertyName = "productid";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // PCatID
            // 
            this.PCatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCatID.DataPropertyName = "pcatid";
            this.PCatID.HeaderText = "Category ID";
            this.PCatID.Name = "PCatID";
            this.PCatID.Visible = false;
            // 
            // BrandID
            // 
            this.BrandID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BrandID.DataPropertyName = "brandid";
            this.BrandID.HeaderText = "Brand ID";
            this.BrandID.Name = "BrandID";
            this.BrandID.Visible = false;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BrandName.DataPropertyName = "brandname";
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.Width = 84;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.DataPropertyName = "productname";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 92;
            // 
            // pcatname
            // 
            this.pcatname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pcatname.DataPropertyName = "pcatname";
            this.pcatname.HeaderText = "Category Name";
            this.pcatname.Name = "pcatname";
            this.pcatname.Width = 96;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.DataPropertyName = "total_qty";
            this.Qty.HeaderText = "Total Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 90;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(12, 29);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(255, 31);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Inventory-Stock List";
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 463);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dGV_ProductList);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rownum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcatname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label lblStock;
    }
}