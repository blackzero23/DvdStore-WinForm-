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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCustomer = new System.Windows.Forms.ToolStripButton();
            this.tsbDvd = new System.Windows.Forms.ToolStripButton();
            this.tsbRantal = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCustomer,
            this.tsbDvd,
            this.tsbRantal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCustomer
            // 
            this.tsbCustomer.Image = global::DvdStore.Properties.Resources.CustomerIcon;
            this.tsbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomer.Name = "tsbCustomer";
            this.tsbCustomer.Size = new System.Drawing.Size(98, 24);
            this.tsbCustomer.Text = "Customer";
            this.tsbCustomer.Click += new System.EventHandler(this.TsbCustomer_Click);
            // 
            // tsbDvd
            // 
            this.tsbDvd.Image = global::DvdStore.Properties.Resources.DvdIcon;
            this.tsbDvd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDvd.Name = "tsbDvd";
            this.tsbDvd.Size = new System.Drawing.Size(60, 24);
            this.tsbDvd.Text = "Dvd";
            this.tsbDvd.Click += new System.EventHandler(this.TsbDvd_Click);
            // 
            // tsbRantal
            // 
            this.tsbRantal.Image = global::DvdStore.Properties.Resources.RentalIcon;
            this.tsbRantal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRantal.Name = "tsbRantal";
            this.tsbRantal.Size = new System.Drawing.Size(76, 24);
            this.tsbRantal.Text = "Rental";
            this.tsbRantal.Click += new System.EventHandler(this.TsbRental_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDvd;
        private System.Windows.Forms.ToolStripButton tsbCustomer;
        private System.Windows.Forms.ToolStripButton tsbRantal;
    }
}