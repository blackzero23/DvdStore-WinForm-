namespace DvdStore
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBook = new System.Windows.Forms.ToolStripButton();
            this.tsbCustomer = new System.Windows.Forms.ToolStripButton();
            this.tsbRantal = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBook,
            this.tsbCustomer,
            this.tsbRantal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBook
            // 
            this.tsbBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbBook.Image")));
            this.tsbBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBook.Name = "tsbBook";
            this.tsbBook.Size = new System.Drawing.Size(54, 22);
            this.tsbBook.Text = "Book";
            // 
            // tsbCustomer
            // 
            this.tsbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustomer.Image")));
            this.tsbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomer.Name = "tsbCustomer";
            this.tsbCustomer.Size = new System.Drawing.Size(79, 22);
            this.tsbCustomer.Text = "Customer";
            // 
            // tsbRantal
            // 
            this.tsbRantal.Image = ((System.Drawing.Image)(resources.GetObject("tsbRantal.Image")));
            this.tsbRantal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRantal.Name = "tsbRantal";
            this.tsbRantal.Size = new System.Drawing.Size(60, 22);
            this.tsbRantal.Text = "Rental";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBook;
        private System.Windows.Forms.ToolStripButton tsbCustomer;
        private System.Windows.Forms.ToolStripButton tsbRantal;
    }
}