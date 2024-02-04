namespace petadoption
{
    partial class addPet
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
            this.addpetPanel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agelabel = new System.Windows.Forms.Label();
            this.ageTxtbox = new System.Windows.Forms.TextBox();
            this.addPetBtn = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.breedAptb2 = new System.Windows.Forms.TextBox();
            this.breedApForm = new System.Windows.Forms.Label();
            this.nameAptb1 = new System.Windows.Forms.TextBox();
            this.nameApForm = new System.Windows.Forms.Label();
            this.addpetPanel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadpetpicbBox = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.imageText = new System.Windows.Forms.TextBox();
            this.addpetPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addpetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadpetpicbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addpetPanel1
            // 
            this.addpetPanel1.BackColor = System.Drawing.Color.Silver;
            this.addpetPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addpetPanel1.Controls.Add(this.pictureBox6);
            this.addpetPanel1.Controls.Add(this.Back);
            this.addpetPanel1.Controls.Add(this.dataGridView1);
            this.addpetPanel1.Controls.Add(this.Agelabel);
            this.addpetPanel1.Controls.Add(this.ageTxtbox);
            this.addpetPanel1.Controls.Add(this.addPetBtn);
            this.addpetPanel1.Controls.Add(this.DescriptionLabel);
            this.addpetPanel1.Controls.Add(this.descriptionTextbox);
            this.addpetPanel1.Controls.Add(this.breedAptb2);
            this.addpetPanel1.Controls.Add(this.breedApForm);
            this.addpetPanel1.Controls.Add(this.nameAptb1);
            this.addpetPanel1.Controls.Add(this.nameApForm);
            this.addpetPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addpetPanel1.Location = new System.Drawing.Point(0, 0);
            this.addpetPanel1.Name = "addpetPanel1";
            this.addpetPanel1.Size = new System.Drawing.Size(1207, 1049);
            this.addpetPanel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::petadoption.Properties.Resources.kk;
            this.pictureBox6.Location = new System.Drawing.Point(563, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(502, 398);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Back.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(922, 850);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 61);
            this.Back.TabIndex = 10;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(647, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelabel.Location = new System.Drawing.Point(44, 359);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(90, 39);
            this.Agelabel.TabIndex = 8;
            this.Agelabel.Text = "Age: ";
            // 
            // ageTxtbox
            // 
            this.ageTxtbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxtbox.Location = new System.Drawing.Point(51, 401);
            this.ageTxtbox.Multiline = true;
            this.ageTxtbox.Name = "ageTxtbox";
            this.ageTxtbox.Size = new System.Drawing.Size(309, 47);
            this.ageTxtbox.TabIndex = 7;
            this.ageTxtbox.TextChanged += new System.EventHandler(this.ageTxtbox_TextChanged);
            // 
            // addPetBtn
            // 
            this.addPetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addPetBtn.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPetBtn.Location = new System.Drawing.Point(54, 850);
            this.addPetBtn.Name = "addPetBtn";
            this.addPetBtn.Size = new System.Drawing.Size(145, 61);
            this.addPetBtn.TabIndex = 6;
            this.addPetBtn.Text = "INSERT";
            this.addPetBtn.UseVisualStyleBackColor = false;
            this.addPetBtn.Click += new System.EventHandler(this.addPetBtn_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(47, 496);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(180, 39);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(51, 538);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(1014, 288);
            this.descriptionTextbox.TabIndex = 4;
            this.descriptionTextbox.TextChanged += new System.EventHandler(this.descriptionTextbox_TextChanged);
            // 
            // breedAptb2
            // 
            this.breedAptb2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedAptb2.Location = new System.Drawing.Point(54, 274);
            this.breedAptb2.Multiline = true;
            this.breedAptb2.Name = "breedAptb2";
            this.breedAptb2.Size = new System.Drawing.Size(309, 47);
            this.breedAptb2.TabIndex = 3;
            // 
            // breedApForm
            // 
            this.breedApForm.AutoSize = true;
            this.breedApForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedApForm.Location = new System.Drawing.Point(47, 206);
            this.breedApForm.Name = "breedApForm";
            this.breedApForm.Size = new System.Drawing.Size(125, 39);
            this.breedApForm.TabIndex = 2;
            this.breedApForm.Text = "Breed : ";
            // 
            // nameAptb1
            // 
            this.nameAptb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAptb1.Location = new System.Drawing.Point(51, 115);
            this.nameAptb1.Multiline = true;
            this.nameAptb1.Name = "nameAptb1";
            this.nameAptb1.Size = new System.Drawing.Size(309, 47);
            this.nameAptb1.TabIndex = 1;
            this.nameAptb1.TextChanged += new System.EventHandler(this.nameAptb1_TextChanged);
            // 
            // nameApForm
            // 
            this.nameApForm.AutoSize = true;
            this.nameApForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApForm.Location = new System.Drawing.Point(44, 64);
            this.nameApForm.Name = "nameApForm";
            this.nameApForm.Size = new System.Drawing.Size(128, 39);
            this.nameApForm.TabIndex = 0;
            this.nameApForm.Text = "Name : ";
            // 
            // addpetPanel2
            // 
            this.addpetPanel2.BackColor = System.Drawing.Color.DimGray;
            this.addpetPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addpetPanel2.Controls.Add(this.label1);
            this.addpetPanel2.Controls.Add(this.uploadpetpicbBox);
            this.addpetPanel2.Controls.Add(this.uploadBtn);
            this.addpetPanel2.Controls.Add(this.imageText);
            this.addpetPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addpetPanel2.Location = new System.Drawing.Point(1207, 0);
            this.addpetPanel2.Name = "addpetPanel2";
            this.addpetPanel2.Size = new System.Drawing.Size(633, 1049);
            this.addpetPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 721);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 105);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rescue Pet";
            // 
            // uploadpetpicbBox
            // 
            this.uploadpetpicbBox.BackColor = System.Drawing.Color.White;
            this.uploadpetpicbBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadpetpicbBox.Location = new System.Drawing.Point(203, 166);
            this.uploadpetpicbBox.Name = "uploadpetpicbBox";
            this.uploadpetpicbBox.Size = new System.Drawing.Size(386, 335);
            this.uploadpetpicbBox.TabIndex = 0;
            this.uploadpetpicbBox.TabStop = false;
            this.uploadpetpicbBox.Click += new System.EventHandler(this.uploadpetpicbBox_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uploadBtn.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(331, 516);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(145, 61);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "UPLOAD";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(203, 166);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(386, 22);
            this.imageText.TabIndex = 2;
            this.imageText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1049);
            this.Controls.Add(this.addpetPanel2);
            this.Controls.Add(this.addpetPanel1);
            this.Name = "addPet";
            this.Text = "addPet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.addpetPanel1.ResumeLayout(false);
            this.addpetPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addpetPanel2.ResumeLayout(false);
            this.addpetPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadpetpicbBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addpetPanel1;
        private System.Windows.Forms.TextBox breedAptb2;
        private System.Windows.Forms.Label breedApForm;
        private System.Windows.Forms.TextBox nameAptb1;
        private System.Windows.Forms.Label nameApForm;
        private System.Windows.Forms.Panel addpetPanel2;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox uploadpetpicbBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button addPetBtn;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.TextBox ageTxtbox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}