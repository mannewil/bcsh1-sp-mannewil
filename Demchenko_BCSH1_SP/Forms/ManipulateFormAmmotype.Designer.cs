namespace Demchenko_BCSH1_SP.Forms
{
    partial class ManipulateFormAmmotype
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
            tbName = new TextBox();
            tbAmmotype = new TextBox();
            label2 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(168, 29);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 5;
            // 
            // tbAmmotype
            // 
            tbAmmotype.Location = new Point(168, 90);
            tbAmmotype.Name = "tbAmmotype";
            tbAmmotype.Size = new Size(125, 27);
            tbAmmotype.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 90);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Caliber";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(34, 186);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += OnBtnOkClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(199, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnBtnCancelClick;
            // 
            // ManipulateFormAmmotype
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 255);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(tbAmmotype);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "ManipulateFormAmmotype";
            Text = "Ammotype -- Add/Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private TextBox tbAmmotype;
        private Label label2;
        private Button btnOK;
        private Button btnCancel;
    }
}