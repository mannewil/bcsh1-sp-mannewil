namespace Demchenko_BCSH1_SP
{
    partial class MainForm
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
            listViewMain = new ListView();
            comboBoxListSelection = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listViewMain
            // 
            listViewMain.Location = new Point(1, 2);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(918, 589);
            listViewMain.TabIndex = 0;
            listViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxListSelection
            // 
            comboBoxListSelection.FormattingEnabled = true;
            comboBoxListSelection.Location = new Point(925, 2);
            comboBoxListSelection.Name = "comboBoxListSelection";
            comboBoxListSelection.Size = new Size(162, 28);
            comboBoxListSelection.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(925, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 57);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add...";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(925, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 53);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit...";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(925, 321);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(162, 56);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove...";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(925, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 66);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save...";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Green;
            button1.Location = new Point(925, 497);
            button1.Name = "button1";
            button1.Size = new Size(162, 65);
            button1.TabIndex = 6;
            button1.Text = "Load...";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 593);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxListSelection);
            Controls.Add(listViewMain);
            Name = "MainForm";
            Text = "Weapon Database";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewMain;
        private ComboBox comboBoxListSelection;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnSave;
        private Button button1;
    }
}