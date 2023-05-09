namespace Demchenko_BCSH1_SP.Forms
{
    partial class ManipulateFormWeaponType
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
            btnOK = new Button();
            btnCancel = new Button();
            tbName = new TextBox();
            tbWeaponType = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Weapon Type";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(23, 180);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += OnBtnOkClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnBtnCancelClick;
            // 
            // tbName
            // 
            tbName.Location = new Point(182, 24);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 4;
            // 
            // tbWeaponType
            // 
            tbWeaponType.Location = new Point(182, 82);
            tbWeaponType.Name = "tbWeaponType";
            tbWeaponType.Size = new Size(125, 27);
            tbWeaponType.TabIndex = 5;
            // 
            // ManipulateFormWeaponType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 225);
            Controls.Add(tbWeaponType);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManipulateFormWeaponType";
            Text = "Weapon Type -- Add/Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tbName;
        private TextBox tbWeaponType;
    }
}