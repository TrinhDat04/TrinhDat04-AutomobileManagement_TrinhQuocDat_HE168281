namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            btnNew = new Button();
            btnLoad = new Button();
            btnClose = new Button();
            dgvCarList = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(28, 37);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(28, 71);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(28, 110);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(446, 45);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(446, 87);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(112, 34);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(193, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(112, 68);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(193, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(112, 107);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(193, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(523, 84);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(193, 23);
            txtReleaseYear.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(523, 42);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 23);
            txtPrice.TabIndex = 9;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(345, 157);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 10;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(72, 157);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(345, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(2, 224);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(768, 220);
            dgvCarList.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(620, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 514);
            Controls.Add(btnDelete);
            Controls.Add(dgvCarList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private Button btnNew;
        private Button btnLoad;
        private Button btnClose;
        private DataGridView dgvCarList;
        private Button btnDelete;
    }
}