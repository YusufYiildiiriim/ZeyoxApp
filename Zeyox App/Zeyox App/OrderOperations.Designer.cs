namespace Zeyox_App
{
    partial class OrderOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOperations));
            this.zeyoxsellproducts = new System.Windows.Forms.Button();
            this.authorizedoperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zeyoxsellproducts
            // 
            this.zeyoxsellproducts.Image = ((System.Drawing.Image)(resources.GetObject("zeyoxsellproducts.Image")));
            this.zeyoxsellproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zeyoxsellproducts.Location = new System.Drawing.Point(34, 12);
            this.zeyoxsellproducts.Name = "zeyoxsellproducts";
            this.zeyoxsellproducts.Size = new System.Drawing.Size(200, 50);
            this.zeyoxsellproducts.TabIndex = 0;
            this.zeyoxsellproducts.Text = "Zeyox\'ta Ürün Sat";
            this.zeyoxsellproducts.UseVisualStyleBackColor = true;
            // 
            // authorizedoperations
            // 
            this.authorizedoperations.Image = ((System.Drawing.Image)(resources.GetObject("authorizedoperations.Image")));
            this.authorizedoperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorizedoperations.Location = new System.Drawing.Point(34, 68);
            this.authorizedoperations.Name = "authorizedoperations";
            this.authorizedoperations.Size = new System.Drawing.Size(200, 50);
            this.authorizedoperations.TabIndex = 1;
            this.authorizedoperations.Text = "Yetkili İşlemler";
            this.authorizedoperations.UseVisualStyleBackColor = true;
            // 
            // OrderOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 138);
            this.Controls.Add(this.authorizedoperations);
            this.Controls.Add(this.zeyoxsellproducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diğer İşlemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zeyoxsellproducts;
        private System.Windows.Forms.Button authorizedoperations;
    }
}