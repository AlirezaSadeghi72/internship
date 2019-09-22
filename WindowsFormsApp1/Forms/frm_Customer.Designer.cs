namespace WindowsFormsApp1.Forms
{
    partial class frm_Customer
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
            this.lbl_SHMO = new System.Windows.Forms.Label();
            this.txt_CustNumber = new System.Windows.Forms.TextBox();
            this.txt_CustCod = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.chbox_CustSpecific = new System.Windows.Forms.CheckBox();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.lbl_AccountSide = new System.Windows.Forms.Label();
            this.cbox_AccountSide = new System.Windows.Forms.ComboBox();
            this.cbox_Visitor = new System.Windows.Forms.ComboBox();
            this.lbl_Visitor = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_tell = new System.Windows.Forms.Label();
            this.txt_Tell = new System.Windows.Forms.TextBox();
            this.gbox_BasicInfo = new System.Windows.Forms.GroupBox();
            this.gbox_FinancialSituation = new System.Windows.Forms.GroupBox();
            this.txt_MaxMinFactor = new System.Windows.Forms.TextBox();
            this.lbl_MaxMinFactor = new System.Windows.Forms.Label();
            this.txt_Credibility = new System.Windows.Forms.TextBox();
            this.lbl_Credibility = new System.Windows.Forms.Label();
            this.chbox_InvoiceToInvoice = new System.Windows.Forms.CheckBox();
            this.chbox_CashPos = new System.Windows.Forms.CheckBox();
            this.chbox_CheckCredit = new System.Windows.Forms.CheckBox();
            this.gbox_Description = new System.Windows.Forms.GroupBox();
            this.rtxt_Description = new System.Windows.Forms.RichTextBox();
            this.btn_adoQuery = new System.Windows.Forms.Button();
            this.btn_adoSP = new System.Windows.Forms.Button();
            this.btn_adoLambda = new System.Windows.Forms.Button();
            this.btn_entitySP = new System.Windows.Forms.Button();
            this.btn_TopLastCustomer = new System.Windows.Forms.Button();
            this.gbox_BasicInfo.SuspendLayout();
            this.gbox_FinancialSituation.SuspendLayout();
            this.gbox_Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SHMO
            // 
            this.lbl_SHMO.AutoSize = true;
            this.lbl_SHMO.Location = new System.Drawing.Point(330, 22);
            this.lbl_SHMO.Name = "lbl_SHMO";
            this.lbl_SHMO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SHMO.Size = new System.Drawing.Size(66, 13);
            this.lbl_SHMO.TabIndex = 0;
            this.lbl_SHMO.Text = "شماره کارت:";
            // 
            // txt_CustNumber
            // 
            this.txt_CustNumber.Location = new System.Drawing.Point(224, 19);
            this.txt_CustNumber.Name = "txt_CustNumber";
            this.txt_CustNumber.ReadOnly = true;
            this.txt_CustNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_CustNumber.TabIndex = 1;
            this.txt_CustNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CustCod
            // 
            this.txt_CustCod.Location = new System.Drawing.Point(36, 19);
            this.txt_CustCod.Name = "txt_CustCod";
            this.txt_CustCod.ReadOnly = true;
            this.txt_CustCod.Size = new System.Drawing.Size(100, 20);
            this.txt_CustCod.TabIndex = 3;
            this.txt_CustCod.Text = "001029042";
            this.txt_CustCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Location = new System.Drawing.Point(142, 22);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Cod.Size = new System.Drawing.Size(58, 13);
            this.lbl_Cod.TabIndex = 2;
            this.lbl_Cod.Text = "کد مشتری:";
            // 
            // chbox_CustSpecific
            // 
            this.chbox_CustSpecific.AutoSize = true;
            this.chbox_CustSpecific.Location = new System.Drawing.Point(309, 104);
            this.chbox_CustSpecific.Name = "chbox_CustSpecific";
            this.chbox_CustSpecific.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbox_CustSpecific.Size = new System.Drawing.Size(84, 17);
            this.chbox_CustSpecific.TabIndex = 6;
            this.chbox_CustSpecific.Text = "مشتری خاص";
            this.chbox_CustSpecific.UseVisualStyleBackColor = true;
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(17, 59);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CustName.Size = new System.Drawing.Size(307, 20);
            this.txt_CustName.TabIndex = 5;
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Location = new System.Drawing.Point(330, 62);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CustName.Size = new System.Drawing.Size(65, 13);
            this.lbl_CustName.TabIndex = 4;
            this.lbl_CustName.Text = "آقا/شرکت: *";
            // 
            // lbl_AccountSide
            // 
            this.lbl_AccountSide.AutoSize = true;
            this.lbl_AccountSide.Location = new System.Drawing.Point(195, 87);
            this.lbl_AccountSide.Name = "lbl_AccountSide";
            this.lbl_AccountSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_AccountSide.Size = new System.Drawing.Size(89, 13);
            this.lbl_AccountSide.TabIndex = 5;
            this.lbl_AccountSide.Text = "گروه طرف حساب:";
            // 
            // cbox_AccountSide
            // 
            this.cbox_AccountSide.FormattingEnabled = true;
            this.cbox_AccountSide.Location = new System.Drawing.Point(162, 103);
            this.cbox_AccountSide.Name = "cbox_AccountSide";
            this.cbox_AccountSide.Size = new System.Drawing.Size(121, 21);
            this.cbox_AccountSide.TabIndex = 8;
            // 
            // cbox_Visitor
            // 
            this.cbox_Visitor.FormattingEnabled = true;
            this.cbox_Visitor.Location = new System.Drawing.Point(17, 104);
            this.cbox_Visitor.Name = "cbox_Visitor";
            this.cbox_Visitor.Size = new System.Drawing.Size(121, 21);
            this.cbox_Visitor.TabIndex = 10;
            // 
            // lbl_Visitor
            // 
            this.lbl_Visitor.AutoSize = true;
            this.lbl_Visitor.Location = new System.Drawing.Point(79, 88);
            this.lbl_Visitor.Name = "lbl_Visitor";
            this.lbl_Visitor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Visitor.Size = new System.Drawing.Size(60, 13);
            this.lbl_Visitor.TabIndex = 9;
            this.lbl_Visitor.Text = "نام ویزیتور:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(330, 147);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Address.Size = new System.Drawing.Size(55, 13);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "آدرس محل:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(17, 144);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Address.Size = new System.Drawing.Size(307, 20);
            this.txt_Address.TabIndex = 11;
            this.txt_Address.Text = "خراسان جنوبي قائن شهرک آزادگان پيروزي 3 ";
            // 
            // lbl_tell
            // 
            this.lbl_tell.AutoSize = true;
            this.lbl_tell.Location = new System.Drawing.Point(227, 180);
            this.lbl_tell.Name = "lbl_tell";
            this.lbl_tell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_tell.Size = new System.Drawing.Size(29, 13);
            this.lbl_tell.TabIndex = 0;
            this.lbl_tell.Text = "تلفن:";
            // 
            // txt_Tell
            // 
            this.txt_Tell.Location = new System.Drawing.Point(121, 177);
            this.txt_Tell.Name = "txt_Tell";
            this.txt_Tell.Size = new System.Drawing.Size(100, 20);
            this.txt_Tell.TabIndex = 12;
            this.txt_Tell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // gbox_BasicInfo
            // 
            this.gbox_BasicInfo.Controls.Add(this.txt_CustNumber);
            this.gbox_BasicInfo.Controls.Add(this.cbox_Visitor);
            this.gbox_BasicInfo.Controls.Add(this.lbl_SHMO);
            this.gbox_BasicInfo.Controls.Add(this.lbl_Visitor);
            this.gbox_BasicInfo.Controls.Add(this.lbl_tell);
            this.gbox_BasicInfo.Controls.Add(this.cbox_AccountSide);
            this.gbox_BasicInfo.Controls.Add(this.txt_Tell);
            this.gbox_BasicInfo.Controls.Add(this.txt_Address);
            this.gbox_BasicInfo.Controls.Add(this.lbl_Cod);
            this.gbox_BasicInfo.Controls.Add(this.txt_CustName);
            this.gbox_BasicInfo.Controls.Add(this.txt_CustCod);
            this.gbox_BasicInfo.Controls.Add(this.lbl_Address);
            this.gbox_BasicInfo.Controls.Add(this.chbox_CustSpecific);
            this.gbox_BasicInfo.Controls.Add(this.lbl_AccountSide);
            this.gbox_BasicInfo.Controls.Add(this.lbl_CustName);
            this.gbox_BasicInfo.Location = new System.Drawing.Point(253, 12);
            this.gbox_BasicInfo.Name = "gbox_BasicInfo";
            this.gbox_BasicInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbox_BasicInfo.Size = new System.Drawing.Size(400, 217);
            this.gbox_BasicInfo.TabIndex = 11;
            this.gbox_BasicInfo.TabStop = false;
            this.gbox_BasicInfo.Text = "اطلاعات پایه";
            // 
            // gbox_FinancialSituation
            // 
            this.gbox_FinancialSituation.Controls.Add(this.txt_MaxMinFactor);
            this.gbox_FinancialSituation.Controls.Add(this.lbl_MaxMinFactor);
            this.gbox_FinancialSituation.Controls.Add(this.txt_Credibility);
            this.gbox_FinancialSituation.Controls.Add(this.lbl_Credibility);
            this.gbox_FinancialSituation.Controls.Add(this.chbox_InvoiceToInvoice);
            this.gbox_FinancialSituation.Controls.Add(this.chbox_CashPos);
            this.gbox_FinancialSituation.Controls.Add(this.chbox_CheckCredit);
            this.gbox_FinancialSituation.Location = new System.Drawing.Point(289, 235);
            this.gbox_FinancialSituation.Name = "gbox_FinancialSituation";
            this.gbox_FinancialSituation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbox_FinancialSituation.Size = new System.Drawing.Size(314, 176);
            this.gbox_FinancialSituation.TabIndex = 12;
            this.gbox_FinancialSituation.TabStop = false;
            this.gbox_FinancialSituation.Text = "وظعیت مالی";
            // 
            // txt_MaxMinFactor
            // 
            this.txt_MaxMinFactor.Location = new System.Drawing.Point(78, 132);
            this.txt_MaxMinFactor.Name = "txt_MaxMinFactor";
            this.txt_MaxMinFactor.Size = new System.Drawing.Size(100, 20);
            this.txt_MaxMinFactor.TabIndex = 17;
            this.txt_MaxMinFactor.Text = "0";
            this.txt_MaxMinFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MaxMinFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // lbl_MaxMinFactor
            // 
            this.lbl_MaxMinFactor.AutoSize = true;
            this.lbl_MaxMinFactor.Location = new System.Drawing.Point(184, 135);
            this.lbl_MaxMinFactor.Name = "lbl_MaxMinFactor";
            this.lbl_MaxMinFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MaxMinFactor.Size = new System.Drawing.Size(81, 13);
            this.lbl_MaxMinFactor.TabIndex = 0;
            this.lbl_MaxMinFactor.Text = "ت.ف.مجاز مانده:";
            // 
            // txt_Credibility
            // 
            this.txt_Credibility.Location = new System.Drawing.Point(97, 19);
            this.txt_Credibility.Name = "txt_Credibility";
            this.txt_Credibility.Size = new System.Drawing.Size(100, 20);
            this.txt_Credibility.TabIndex = 13;
            this.txt_Credibility.Text = "0";
            this.txt_Credibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Credibility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // lbl_Credibility
            // 
            this.lbl_Credibility.AutoSize = true;
            this.lbl_Credibility.Location = new System.Drawing.Point(203, 22);
            this.lbl_Credibility.Name = "lbl_Credibility";
            this.lbl_Credibility.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Credibility.Size = new System.Drawing.Size(37, 13);
            this.lbl_Credibility.TabIndex = 0;
            this.lbl_Credibility.Text = "اعتبار:";
            // 
            // chbox_InvoiceToInvoice
            // 
            this.chbox_InvoiceToInvoice.AutoSize = true;
            this.chbox_InvoiceToInvoice.Location = new System.Drawing.Point(140, 109);
            this.chbox_InvoiceToInvoice.Name = "chbox_InvoiceToInvoice";
            this.chbox_InvoiceToInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbox_InvoiceToInvoice.Size = new System.Drawing.Size(158, 17);
            this.chbox_InvoiceToInvoice.TabIndex = 16;
            this.chbox_InvoiceToInvoice.Text = "الزام تسویه فاکتور به فاکتور";
            this.chbox_InvoiceToInvoice.UseVisualStyleBackColor = true;
            this.chbox_InvoiceToInvoice.CheckedChanged += new System.EventHandler(this.chbox_InvoiceToInvoice_CheckedChanged);
            // 
            // chbox_CashPos
            // 
            this.chbox_CashPos.AutoSize = true;
            this.chbox_CashPos.Location = new System.Drawing.Point(151, 86);
            this.chbox_CashPos.Name = "chbox_CashPos";
            this.chbox_CashPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbox_CashPos.Size = new System.Drawing.Size(147, 17);
            this.chbox_CashPos.TabIndex = 15;
            this.chbox_CashPos.Text = "دریافت به صورت نقد و pos";
            this.chbox_CashPos.UseVisualStyleBackColor = true;
            this.chbox_CashPos.CheckedChanged += new System.EventHandler(this.chbox_CashPos_CheckedChanged);
            // 
            // chbox_CheckCredit
            // 
            this.chbox_CheckCredit.AutoSize = true;
            this.chbox_CheckCredit.Location = new System.Drawing.Point(21, 63);
            this.chbox_CheckCredit.Name = "chbox_CheckCredit";
            this.chbox_CheckCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbox_CheckCredit.Size = new System.Drawing.Size(277, 17);
            this.chbox_CheckCredit.TabIndex = 14;
            this.chbox_CheckCredit.Text = "چک های مشتری در محاسبه مانده اعتبار وی دخیل باشد";
            this.chbox_CheckCredit.UseVisualStyleBackColor = true;
            // 
            // gbox_Description
            // 
            this.gbox_Description.Controls.Add(this.rtxt_Description);
            this.gbox_Description.Location = new System.Drawing.Point(26, 25);
            this.gbox_Description.Name = "gbox_Description";
            this.gbox_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbox_Description.Size = new System.Drawing.Size(203, 378);
            this.gbox_Description.TabIndex = 13;
            this.gbox_Description.TabStop = false;
            this.gbox_Description.Text = "توضیحات";
            // 
            // rtxt_Description
            // 
            this.rtxt_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Description.Location = new System.Drawing.Point(3, 16);
            this.rtxt_Description.Name = "rtxt_Description";
            this.rtxt_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxt_Description.Size = new System.Drawing.Size(197, 359);
            this.rtxt_Description.TabIndex = 18;
            this.rtxt_Description.Text = "";
            // 
            // btn_adoQuery
            // 
            this.btn_adoQuery.Location = new System.Drawing.Point(528, 433);
            this.btn_adoQuery.Name = "btn_adoQuery";
            this.btn_adoQuery.Size = new System.Drawing.Size(75, 23);
            this.btn_adoQuery.TabIndex = 14;
            this.btn_adoQuery.Text = "ADO Query";
            this.btn_adoQuery.UseVisualStyleBackColor = true;
            this.btn_adoQuery.Click += new System.EventHandler(this.btn_adoQuery_Click);
            // 
            // btn_adoSP
            // 
            this.btn_adoSP.Location = new System.Drawing.Point(451, 433);
            this.btn_adoSP.Name = "btn_adoSP";
            this.btn_adoSP.Size = new System.Drawing.Size(75, 23);
            this.btn_adoSP.TabIndex = 15;
            this.btn_adoSP.Text = "ADO SP";
            this.btn_adoSP.UseVisualStyleBackColor = true;
            this.btn_adoSP.Click += new System.EventHandler(this.btn_adoSP_Click);
            // 
            // btn_adoLambda
            // 
            this.btn_adoLambda.Location = new System.Drawing.Point(367, 433);
            this.btn_adoLambda.Name = "btn_adoLambda";
            this.btn_adoLambda.Size = new System.Drawing.Size(79, 23);
            this.btn_adoLambda.TabIndex = 16;
            this.btn_adoLambda.Text = "ADO Lambda";
            this.btn_adoLambda.UseVisualStyleBackColor = true;
            this.btn_adoLambda.Click += new System.EventHandler(this.btn_adoLambda_Click);
            // 
            // btn_entitySP
            // 
            this.btn_entitySP.Location = new System.Drawing.Point(286, 433);
            this.btn_entitySP.Name = "btn_entitySP";
            this.btn_entitySP.Size = new System.Drawing.Size(75, 23);
            this.btn_entitySP.TabIndex = 17;
            this.btn_entitySP.Text = "entity SP";
            this.btn_entitySP.UseVisualStyleBackColor = true;
            this.btn_entitySP.Click += new System.EventHandler(this.btn_entitySP_Click);
            // 
            // btn_TopLastCustomer
            // 
            this.btn_TopLastCustomer.Location = new System.Drawing.Point(12, 433);
            this.btn_TopLastCustomer.Name = "btn_TopLastCustomer";
            this.btn_TopLastCustomer.Size = new System.Drawing.Size(135, 23);
            this.btn_TopLastCustomer.TabIndex = 18;
            this.btn_TopLastCustomer.Text = "نمایش 10مشتری اخر";
            this.btn_TopLastCustomer.UseVisualStyleBackColor = true;
            this.btn_TopLastCustomer.Click += new System.EventHandler(this.btn_TopLastCustomer_Click);
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 468);
            this.Controls.Add(this.btn_TopLastCustomer);
            this.Controls.Add(this.btn_entitySP);
            this.Controls.Add(this.btn_adoLambda);
            this.Controls.Add(this.btn_adoSP);
            this.Controls.Add(this.btn_adoQuery);
            this.Controls.Add(this.gbox_Description);
            this.Controls.Add(this.gbox_FinancialSituation);
            this.Controls.Add(this.gbox_BasicInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف مشتری";
            this.Load += new System.EventHandler(this.frm_Customer_Load);
            this.gbox_BasicInfo.ResumeLayout(false);
            this.gbox_BasicInfo.PerformLayout();
            this.gbox_FinancialSituation.ResumeLayout(false);
            this.gbox_FinancialSituation.PerformLayout();
            this.gbox_Description.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SHMO;
        private System.Windows.Forms.TextBox txt_CustNumber;
        private System.Windows.Forms.TextBox txt_CustCod;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.CheckBox chbox_CustSpecific;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.Label lbl_AccountSide;
        private System.Windows.Forms.ComboBox cbox_AccountSide;
        private System.Windows.Forms.ComboBox cbox_Visitor;
        private System.Windows.Forms.Label lbl_Visitor;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_tell;
        private System.Windows.Forms.TextBox txt_Tell;
        private System.Windows.Forms.GroupBox gbox_BasicInfo;
        private System.Windows.Forms.GroupBox gbox_FinancialSituation;
        private System.Windows.Forms.TextBox txt_MaxMinFactor;
        private System.Windows.Forms.Label lbl_MaxMinFactor;
        private System.Windows.Forms.TextBox txt_Credibility;
        private System.Windows.Forms.Label lbl_Credibility;
        private System.Windows.Forms.CheckBox chbox_InvoiceToInvoice;
        private System.Windows.Forms.CheckBox chbox_CashPos;
        private System.Windows.Forms.CheckBox chbox_CheckCredit;
        private System.Windows.Forms.GroupBox gbox_Description;
        private System.Windows.Forms.RichTextBox rtxt_Description;
        private System.Windows.Forms.Button btn_adoQuery;
        private System.Windows.Forms.Button btn_adoSP;
        private System.Windows.Forms.Button btn_adoLambda;
        private System.Windows.Forms.Button btn_entitySP;
        private System.Windows.Forms.Button btn_TopLastCustomer;
    }
}