namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(148, 55);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(182, 23);
            txtCarID.TabIndex = 0;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(148, 98);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(182, 23);
            txtCarName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(148, 194);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 23);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(148, 239);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(182, 23);
            txtReleaseYear.TabIndex = 3;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Items:", "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(148, 144);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(182, 23);
            cboManufacturer.TabIndex = 4;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(49, 58);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 5;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(49, 101);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 6;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(49, 147);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 7;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(49, 197);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(49, 242);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 9;
            lbReleaseYear.Text = "Release Year";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(148, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(255, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 348);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}