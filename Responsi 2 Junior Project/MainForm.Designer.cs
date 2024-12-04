namespace Responsi_2_Junior_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblLogo = new Label();
            lblNama = new Label();
            lblDep = new Label();
            groupBox1 = new GroupBox();
            lblID_Dep = new Label();
            txtNama = new TextBox();
            comboDep = new ComboBox();
            button1 = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.Location = new Point(112, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(371, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Human Resources Management App";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(48, 104);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(93, 15);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Karyawan";
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Location = new Point(48, 137);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(85, 15);
            lblDep.TabIndex = 2;
            lblDep.Text = "Dep. Karyawan";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblID_Dep);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(552, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 123);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Departemen";
            // 
            // lblID_Dep
            // 
            lblID_Dep.AutoSize = true;
            lblID_Dep.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblID_Dep.Location = new Point(17, 27);
            lblID_Dep.Name = "lblID_Dep";
            lblID_Dep.Size = new Size(136, 85);
            lblID_Dep.TabIndex = 0;
            lblID_Dep.Text = "HR: HR\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN: Finance";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(170, 101);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(203, 23);
            txtNama.TabIndex = 4;
            txtNama.TextChanged += TxtNama_TextChanged;
            // 
            // comboDep
            // 
            comboDep.FormattingEnabled = true;
            comboDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            comboDep.Location = new Point(170, 134);
            comboDep.Name = "comboDep";
            comboDep.Size = new Size(203, 23);
            comboDep.TabIndex = 5;
            comboDep.SelectedIndexChanged += ComboDep_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(48, 178);
            button1.Name = "button1";
            button1.Size = new Size(205, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(589, 491);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(163, 45);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Reload Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(704, 255);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 53);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(48, 178);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(205, 34);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += BtnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(303, 178);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(205, 34);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(547, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(205, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(button1);
            Controls.Add(comboDep);
            Controls.Add(txtNama);
            Controls.Add(groupBox1);
            Controls.Add(lblDep);
            Controls.Add(lblNama);
            Controls.Add(lblLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private Label lblNama;
        private Label lblDep;
        private GroupBox groupBox1;
        private TextBox txtNama;
        private ComboBox comboDep;
        private Button button1;
        private Button btnLoad;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblID_Dep;
    }
}