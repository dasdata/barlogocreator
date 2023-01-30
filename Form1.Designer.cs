namespace BarLogoCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picResult = new System.Windows.Forms.PictureBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnMakeLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cbIndustries = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbStyles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.picResult1 = new System.Windows.Forms.PictureBox();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.picResult3 = new System.Windows.Forms.PictureBox();
            this.cbxLogoStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(62, 728);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(456, 418);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrompt.Location = new System.Drawing.Point(62, 356);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(1144, 240);
            this.txtPrompt.TabIndex = 1;
            // 
            // btnMakeLogo
            // 
            this.btnMakeLogo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMakeLogo.Location = new System.Drawing.Point(551, 602);
            this.btnMakeLogo.Name = "btnMakeLogo";
            this.btnMakeLogo.Size = new System.Drawing.Size(655, 87);
            this.btnMakeLogo.TabIndex = 2;
            this.btnMakeLogo.Text = "Make Logo";
            this.btnMakeLogo.UseVisualStyleBackColor = true;
            this.btnMakeLogo.Click += new System.EventHandler(this.btnMakeLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "BarLogo";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(72, 1230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product or service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Industry";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(62, 163);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(495, 43);
            this.txtBrandName.TabIndex = 10;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(62, 279);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(495, 43);
            this.txtProduct.TabIndex = 11;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // cbIndustries
            // 
            this.cbIndustries.FormattingEnabled = true;
            this.cbIndustries.Location = new System.Drawing.Point(685, 161);
            this.cbIndustries.Name = "cbIndustries";
            this.cbIndustries.Size = new System.Drawing.Size(521, 45);
            this.cbIndustries.TabIndex = 12;
            this.cbIndustries.SelectedIndexChanged += new System.EventHandler(this.cbIndustries_SelectedIndexChanged);
            // 
            // cbStyles
            // 
            this.cbStyles.FormattingEnabled = true;
            this.cbStyles.Location = new System.Drawing.Point(685, 279);
            this.cbStyles.Name = "cbStyles";
            this.cbStyles.Size = new System.Drawing.Size(521, 45);
            this.cbStyles.TabIndex = 14;
            this.cbStyles.SelectedIndexChanged += new System.EventHandler(this.cbStyles_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1308, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Colors";
            // 
            // lbColors
            // 
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 37;
            this.lbColors.Location = new System.Drawing.Point(1308, 279);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(655, 411);
            this.lbColors.TabIndex = 16;
            this.lbColors.SelectedIndexChanged += new System.EventHandler(this.lbColors_SelectedIndexChanged);
            // 
            // picResult1
            // 
            this.picResult1.Location = new System.Drawing.Point(562, 728);
            this.picResult1.Name = "picResult1";
            this.picResult1.Size = new System.Drawing.Size(446, 418);
            this.picResult1.TabIndex = 17;
            this.picResult1.TabStop = false;
            // 
            // picResult2
            // 
            this.picResult2.Location = new System.Drawing.Point(1044, 728);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(456, 418);
            this.picResult2.TabIndex = 18;
            this.picResult2.TabStop = false;
            // 
            // picResult3
            // 
            this.picResult3.Location = new System.Drawing.Point(1530, 728);
            this.picResult3.Name = "picResult3";
            this.picResult3.Size = new System.Drawing.Size(433, 418);
            this.picResult3.TabIndex = 19;
            this.picResult3.TabStop = false;
            // 
            // cbxLogoStyle
            // 
            this.cbxLogoStyle.FormattingEnabled = true;
            this.cbxLogoStyle.Location = new System.Drawing.Point(1308, 161);
            this.cbxLogoStyle.Name = "cbxLogoStyle";
            this.cbxLogoStyle.Size = new System.Drawing.Size(521, 45);
            this.cbxLogoStyle.TabIndex = 21;
            this.cbxLogoStyle.SelectedIndexChanged += new System.EventHandler(this.cbxLogoStyle_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1308, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "LogoType";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(942, 1202);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(132, 37);
            this.lblLoading.TabIndex = 22;
            this.lblLoading.Text = "Loading...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2019, 1319);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.cbxLogoStyle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picResult3);
            this.Controls.Add(this.picResult2);
            this.Controls.Add(this.picResult1);
            this.Controls.Add(this.lbColors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStyles);
            this.Controls.Add(this.cbIndustries);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeLogo);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.picResult);
            this.Name = "Form1";
            this.Text = "BarLogo";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picResult;
        private TextBox txtPrompt;
        private Button btnMakeLogo;
        private Label label1;
        private Label lblResult;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBrandName;
        private TextBox txtProduct;
        private ComboBox cbIndustries;
        private ColorDialog colorDialog1;
        private ComboBox cbStyles;
        private Label label6;
        private ListBox lbColors;
        private PictureBox picResult1;
        private PictureBox picResult2;
        private PictureBox picResult3;
        private ComboBox cbxLogoStyle;
        private Label label7;
        private Label lblLoading;
    }
}