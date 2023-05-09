namespace Demchenko_BCSH1_SP.Control
{
    partial class UserControlLabelledTBoxReadOnly
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
            labelName.Location = new Point(3, 6);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(82, 3);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 1;
            // 
            // UserControlLabelledTBoxReadOnly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbName);
            Controls.Add(labelName);
            Name = "UserControlLabelledTBoxReadOnly";
            Size = new Size(240, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox tbName;
    }
}
