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
            comboBoxListSelection = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            comboBoxSorting = new ComboBox();
            listViewMain = new ListView();
            cHeader = new ColumnHeader();
            panel1 = new Panel();
            labelEntities = new Label();
            labelSorting = new Label();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxListSelection
            // 
            comboBoxListSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListSelection.FormattingEnabled = true;
            comboBoxListSelection.Items.AddRange(new object[] { "Weapon", "Manufacturer", "Ammo type", "Weapon type" });
            comboBoxListSelection.Location = new Point(925, 35);
            comboBoxListSelection.Name = "comboBoxListSelection";
            comboBoxListSelection.Size = new Size(162, 28);
            comboBoxListSelection.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(925, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 57);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add...";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += OnBtnAddClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(925, 206);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 53);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit...";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += OnBtnEditClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(925, 265);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(162, 56);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove...";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += OnBtnRemoveClick;
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
            btnSave.Click += OnBtnSaveClick;
            // 
            // btnLoad
            // 
            btnLoad.ForeColor = Color.Green;
            btnLoad.Location = new Point(925, 497);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(162, 65);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load...";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += OnBtnLoadClick;
            // 
            // comboBoxSorting
            // 
            comboBoxSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSorting.FormattingEnabled = true;
            comboBoxSorting.Location = new Point(925, 109);
            comboBoxSorting.Name = "comboBoxSorting";
            comboBoxSorting.Size = new Size(162, 28);
            comboBoxSorting.TabIndex = 7;
            // 
            // listViewMain
            // 
            listViewMain.Columns.AddRange(new ColumnHeader[] { cHeader });
            listViewMain.Dock = DockStyle.Fill;
            listViewMain.FullRowSelect = true;
            listViewMain.GridLines = true;
            listViewMain.Location = new Point(0, 0);
            listViewMain.MultiSelect = false;
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(907, 550);
            listViewMain.TabIndex = 8;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = View.Details;
            listViewMain.DoubleClick += OnListViewItemDoubleClick;
            listViewMain.MouseClick += OnListViewItemRightClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(listViewMain);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 550);
            panel1.TabIndex = 9;
            // 
            // labelEntities
            // 
            labelEntities.AutoSize = true;
            labelEntities.Location = new Point(964, 9);
            labelEntities.Name = "labelEntities";
            labelEntities.Size = new Size(81, 20);
            labelEntities.TabIndex = 10;
            labelEntities.Text = "Entity Type";
            // 
            // labelSorting
            // 
            labelSorting.AutoSize = true;
            labelSorting.Location = new Point(980, 86);
            labelSorting.Name = "labelSorting";
            labelSorting.Size = new Size(65, 20);
            labelSorting.TabIndex = 11;
            labelSorting.Text = "Sort by...";
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(925, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 39);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear...";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += OnBtnClearClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 593);
            Controls.Add(btnClear);
            Controls.Add(labelSorting);
            Controls.Add(labelEntities);
            Controls.Add(panel1);
            Controls.Add(comboBoxSorting);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxListSelection);
            Name = "MainForm";
            Text = "Weapon Database";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxListSelection;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnSave;
        private Button btnLoad;
        private ComboBox comboBoxSorting;
        private ListView listViewMain;
        private Panel panel1;
        private ColumnHeader cHeader;
        private Label labelEntities;
        private Label labelSorting;
        private Button btnClear;
    }
}