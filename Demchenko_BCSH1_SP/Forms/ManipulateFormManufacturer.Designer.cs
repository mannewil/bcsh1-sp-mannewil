namespace Demchenko_BCSH1_SP.Forms
{
    partial class ManipulateFormManufacturer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbCountry = new TextBox();
            tbFYear = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Country of origin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 150);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Foundation year";
            // 
            // tbName
            // 
            tbName.Location = new Point(198, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 3;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(198, 91);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 4;
            // 
            // tbFYear
            // 
            tbFYear.Location = new Point(198, 150);
            tbFYear.Name = "tbFYear";
            tbFYear.Size = new Size(125, 27);
            tbFYear.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(23, 278);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += OnBtnOkClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(229, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnBtnCancelClick;
            // 
            // ManipulateFormManufacturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 324);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(tbFYear);
            Controls.Add(tbCountry);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManipulateFormManufacturer";
            Text = "Manufacturer -- Add/Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbCountry;
        private TextBox tbFYear;
        private Button btnOK;
        private Button btnCancel;
    }
}