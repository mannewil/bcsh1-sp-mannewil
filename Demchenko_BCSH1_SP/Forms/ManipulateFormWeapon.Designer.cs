namespace Demchenko_BCSH1_SP.Forms
{
    partial class ManipulateFormWeapon
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
            panelWeaponType = new Panel();
            panelManufacturer = new Panel();
            panelAmmotype = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            labelManufacturer = new Label();
            labelAT = new Label();
            labelWT = new Label();
            cBoxManufacturer = new ComboBox();
            cBoxAT = new ComboBox();
            cBoxWT = new ComboBox();
            ucName = new Control.UserControlLabelledTbox();
            ucPrice = new Control.UserControlLabelledTbox();
            ucWeight = new Control.UserControlLabelledTbox();
            ucManName = new Control.UserControlLabelledTBoxReadOnly();
            ucManCountry = new Control.UserControlLabelledTBoxReadOnly();
            ucManYear = new Control.UserControlLabelledTBoxReadOnly();
            ucATName = new Control.UserControlLabelledTBoxReadOnly();
            ucATCaliber = new Control.UserControlLabelledTBoxReadOnly();
            ucWTName = new Control.UserControlLabelledTBoxReadOnly();
            ucWTWeaponType = new Control.UserControlLabelledTBoxReadOnly();
            panelWeaponType.SuspendLayout();
            panelManufacturer.SuspendLayout();
            panelAmmotype.SuspendLayout();
            SuspendLayout();
            // 
            // panelWeaponType
            // 
            panelWeaponType.Controls.Add(ucATCaliber);
            panelWeaponType.Controls.Add(ucATName);
            panelWeaponType.Location = new Point(508, 76);
            panelWeaponType.Name = "panelWeaponType";
            panelWeaponType.Size = new Size(233, 259);
            panelWeaponType.TabIndex = 3;
            // 
            // panelManufacturer
            // 
            panelManufacturer.Controls.Add(ucWTWeaponType);
            panelManufacturer.Controls.Add(ucWTName);
            panelManufacturer.Location = new Point(747, 76);
            panelManufacturer.Name = "panelManufacturer";
            panelManufacturer.Size = new Size(222, 259);
            panelManufacturer.TabIndex = 4;
            // 
            // panelAmmotype
            // 
            panelAmmotype.Controls.Add(ucManYear);
            panelAmmotype.Controls.Add(ucManCountry);
            panelAmmotype.Controls.Add(ucManName);
            panelAmmotype.Location = new Point(273, 76);
            panelAmmotype.Name = "panelAmmotype";
            panelAmmotype.Size = new Size(229, 259);
            panelAmmotype.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(8, 306);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += OnBtnOkClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(150, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnBtnCancelClick;
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelManufacturer.Location = new Point(318, 9);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(133, 28);
            labelManufacturer.TabIndex = 8;
            labelManufacturer.Text = "Manufacturer:";
            // 
            // labelAT
            // 
            labelAT.AutoSize = true;
            labelAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAT.Location = new Point(563, 9);
            labelAT.Name = "labelAT";
            labelAT.Size = new Size(121, 28);
            labelAT.TabIndex = 9;
            labelAT.Text = "Ammo Type:";
            // 
            // labelWT
            // 
            labelWT.AutoSize = true;
            labelWT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWT.Location = new Point(788, 9);
            labelWT.Name = "labelWT";
            labelWT.Size = new Size(135, 28);
            labelWT.TabIndex = 10;
            labelWT.Text = "Weapon Type:";
            // 
            // cBoxManufacturer
            // 
            cBoxManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxManufacturer.FormattingEnabled = true;
            cBoxManufacturer.Location = new Point(302, 40);
            cBoxManufacturer.Name = "cBoxManufacturer";
            cBoxManufacturer.Size = new Size(165, 28);
            cBoxManufacturer.TabIndex = 11;
            cBoxManufacturer.SelectedIndexChanged += OnCBoxManufacturerChanged;
            // 
            // cBoxAT
            // 
            cBoxAT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxAT.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxAT.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxAT.FormattingEnabled = true;
            cBoxAT.Location = new Point(539, 40);
            cBoxAT.Name = "cBoxAT";
            cBoxAT.Size = new Size(165, 28);
            cBoxAT.TabIndex = 12;
            cBoxAT.SelectedIndexChanged += OnCBoxATChanged;
            // 
            // cBoxWT
            // 
            cBoxWT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxWT.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxWT.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxWT.FormattingEnabled = true;
            cBoxWT.Location = new Point(775, 42);
            cBoxWT.Name = "cBoxWT";
            cBoxWT.Size = new Size(165, 28);
            cBoxWT.TabIndex = 13;
            cBoxWT.SelectedIndexChanged += OnCBoxWTChanged;
            // 
            // ucName
            // 
            ucName.LabelText = "Name:";
            ucName.Location = new Point(8, 4);
            ucName.Name = "ucName";
            ucName.Size = new Size(234, 64);
            ucName.TabIndex = 14;
            ucName.TextBoxText = "";
            // 
            // ucPrice
            // 
            ucPrice.LabelText = "Name:";
            ucPrice.Location = new Point(8, 76);
            ucPrice.Name = "ucPrice";
            ucPrice.Size = new Size(234, 64);
            ucPrice.TabIndex = 15;
            ucPrice.TextBoxText = "";
            // 
            // ucWeight
            // 
            ucWeight.LabelText = "Name:";
            ucWeight.Location = new Point(8, 146);
            ucWeight.Name = "ucWeight";
            ucWeight.Size = new Size(234, 64);
            ucWeight.TabIndex = 16;
            ucWeight.TextBoxText = "";
            // 
            // ucManName
            // 
            ucManName.LabelText = "Name";
            ucManName.Location = new Point(3, 3);
            ucManName.Name = "ucManName";
            ucManName.Size = new Size(223, 50);
            ucManName.TabIndex = 0;
            ucManName.TextBoxText = "";
            // 
            // ucManCountry
            // 
            ucManCountry.LabelText = "Name";
            ucManCountry.Location = new Point(3, 59);
            ucManCountry.Name = "ucManCountry";
            ucManCountry.Size = new Size(223, 50);
            ucManCountry.TabIndex = 1;
            ucManCountry.TextBoxText = "";
            // 
            // ucManYear
            // 
            ucManYear.LabelText = "Name";
            ucManYear.Location = new Point(3, 115);
            ucManYear.Name = "ucManYear";
            ucManYear.Size = new Size(223, 50);
            ucManYear.TabIndex = 2;
            ucManYear.TextBoxText = "";
            // 
            // ucATName
            // 
            ucATName.LabelText = "Name";
            ucATName.Location = new Point(3, 3);
            ucATName.Name = "ucATName";
            ucATName.Size = new Size(227, 50);
            ucATName.TabIndex = 0;
            ucATName.TextBoxText = "";
            // 
            // ucATCaliber
            // 
            ucATCaliber.LabelText = "Name";
            ucATCaliber.Location = new Point(3, 59);
            ucATCaliber.Name = "ucATCaliber";
            ucATCaliber.Size = new Size(227, 50);
            ucATCaliber.TabIndex = 1;
            ucATCaliber.TextBoxText = "";
            // 
            // ucWTName
            // 
            ucWTName.LabelText = "Name";
            ucWTName.Location = new Point(3, 3);
            ucWTName.Name = "ucWTName";
            ucWTName.Size = new Size(216, 50);
            ucWTName.TabIndex = 2;
            ucWTName.TextBoxText = "";
            // 
            // ucWTWeaponType
            // 
            ucWTWeaponType.LabelText = "Name";
            ucWTWeaponType.Location = new Point(3, 59);
            ucWTWeaponType.Name = "ucWTWeaponType";
            ucWTWeaponType.Size = new Size(216, 50);
            ucWTWeaponType.TabIndex = 3;
            ucWTWeaponType.TextBoxText = "";
            // 
            // ManipulateFormWeapon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 347);
            Controls.Add(ucWeight);
            Controls.Add(ucPrice);
            Controls.Add(ucName);
            Controls.Add(cBoxWT);
            Controls.Add(cBoxAT);
            Controls.Add(cBoxManufacturer);
            Controls.Add(labelWT);
            Controls.Add(labelAT);
            Controls.Add(labelManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panelAmmotype);
            Controls.Add(panelManufacturer);
            Controls.Add(panelWeaponType);
            Name = "ManipulateFormWeapon";
            Text = "ManipulateFormWeapon";
            panelWeaponType.ResumeLayout(false);
            panelManufacturer.ResumeLayout(false);
            panelAmmotype.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelWeaponType;
        private Panel panelManufacturer;
        private Panel panelAmmotype;
        private Button btnOK;
        private Button btnCancel;
        private Label labelManufacturer;
        private Label labelAT;
        private Label labelWT;
        private ComboBox cBoxManufacturer;
        private ComboBox cBoxAT;
        private ComboBox cBoxWT;
        private Control.UserControlLabelledTbox ucName;
        private Control.UserControlLabelledTbox ucPrice;
        private Control.UserControlLabelledTbox ucWeight;
        private Control.UserControlLabelledTBoxReadOnly ucATCaliber;
        private Control.UserControlLabelledTBoxReadOnly ucATName;
        private Control.UserControlLabelledTBoxReadOnly ucManYear;
        private Control.UserControlLabelledTBoxReadOnly ucManCountry;
        private Control.UserControlLabelledTBoxReadOnly ucManName;
        private Control.UserControlLabelledTBoxReadOnly ucWTWeaponType;
        private Control.UserControlLabelledTBoxReadOnly ucWTName;
    }
}