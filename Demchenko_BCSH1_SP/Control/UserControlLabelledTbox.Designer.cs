namespace Demchenko_BCSH1_SP.Control
{
    partial class UserControlLabelledTbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(10, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // tbName
            // 
            tbName.Location = new Point(91, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 1;
            // 
            // UserControlWeaponField
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbName);
            Controls.Add(labelName);
            Name = "UserControlWeaponField";
            Size = new Size(239, 69);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox tbName;
    }
}
