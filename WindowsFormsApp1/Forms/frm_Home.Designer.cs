namespace WindowsFormsApp1.Forms
{
    partial class frm_Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewVisitor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Customer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_Customer
            // 
            this.tsmi_Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NewCustomer,
            this.tsmi_NewVisitor});
            this.tsmi_Customer.Name = "tsmi_Customer";
            this.tsmi_Customer.Size = new System.Drawing.Size(53, 20);
            this.tsmi_Customer.Text = "مشتری";
            // 
            // tsmi_NewCustomer
            // 
            this.tsmi_NewCustomer.Name = "tsmi_NewCustomer";
            this.tsmi_NewCustomer.Size = new System.Drawing.Size(214, 22);
            this.tsmi_NewCustomer.Text = "تعریف مشتری";
            this.tsmi_NewCustomer.Click += new System.EventHandler(this.tsmi_NewCustomer_Click);
            // 
            // tsmi_NewVisitor
            // 
            this.tsmi_NewVisitor.Name = "tsmi_NewVisitor";
            this.tsmi_NewVisitor.Size = new System.Drawing.Size(214, 22);
            this.tsmi_NewVisitor.Text = "تعریف ویزیتور/پرسنل فروش";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آتیران";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Customer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_NewCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_NewVisitor;
    }
}

