
namespace WinFormsApp1
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.IBlContactId = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameBX = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.ContNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addr = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.ChooseGender = new System.Windows.Forms.ComboBox();
            this.Adding = new System.Windows.Forms.Button();
            this.Deleting = new System.Windows.Forms.Button();
            this.Updating = new System.Windows.Forms.Button();
            this.Clearing = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Searching = new System.Windows.Forms.Label();
            this.ForSearching = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::WinFormsApp1.Properties.Resources.rwHCOYEBMc8;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(929, 473);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // IBlContactId
            // 
            this.IBlContactId.AutoSize = true;
            this.IBlContactId.BackColor = System.Drawing.Color.Transparent;
            this.IBlContactId.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.IBlContactId.Location = new System.Drawing.Point(1071, 27);
            this.IBlContactId.Name = "IBlContactId";
            this.IBlContactId.Size = new System.Drawing.Size(229, 60);
            this.IBlContactId.TabIndex = 1;
            this.IBlContactId.Text = "Contact Id";
            // 
            // ContactBox
            // 
            this.ContactBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactBox.Location = new System.Drawing.Point(1609, 43);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.ReadOnly = true;
            this.ContactBox.Size = new System.Drawing.Size(391, 43);
            this.ContactBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(1609, 142);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Input Your name Here";
            this.NameBox.Size = new System.Drawing.Size(391, 43);
            this.NameBox.TabIndex = 4;
            // 
            // NameBX
            // 
            this.NameBX.AutoSize = true;
            this.NameBX.BackColor = System.Drawing.Color.Transparent;
            this.NameBX.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.NameBX.Location = new System.Drawing.Point(1071, 125);
            this.NameBX.Name = "NameBX";
            this.NameBX.Size = new System.Drawing.Size(240, 60);
            this.NameBX.TabIndex = 3;
            this.NameBX.Text = "First Name";
            this.NameBX.Click += new System.EventHandler(this.label1_Click);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(1609, 232);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.PlaceholderText = "Input Your surname Here";
            this.SurnameBox.Size = new System.Drawing.Size(391, 43);
            this.SurnameBox.TabIndex = 8;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.BackColor = System.Drawing.Color.Transparent;
            this.Surname.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Surname.Location = new System.Drawing.Point(1071, 216);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(201, 60);
            this.Surname.TabIndex = 7;
            this.Surname.Text = "Surname";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(1609, 330);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.PlaceholderText = "Input Your number Here";
            this.NumberBox.Size = new System.Drawing.Size(391, 43);
            this.NumberBox.TabIndex = 6;
            // 
            // ContNum
            // 
            this.ContNum.AutoSize = true;
            this.ContNum.BackColor = System.Drawing.Color.Transparent;
            this.ContNum.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ContNum.Location = new System.Drawing.Point(1071, 314);
            this.ContNum.Name = "ContNum";
            this.ContNum.Size = new System.Drawing.Size(305, 60);
            this.ContNum.TabIndex = 5;
            this.ContNum.Text = "Contact numb";
            this.ContNum.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1609, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Input Your addr Here";
            this.textBox1.Size = new System.Drawing.Size(391, 156);
            this.textBox1.TabIndex = 10;
            // 
            // Addr
            // 
            this.Addr.AutoSize = true;
            this.Addr.BackColor = System.Drawing.Color.Transparent;
            this.Addr.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Addr.Location = new System.Drawing.Point(1071, 419);
            this.Addr.Name = "Addr";
            this.Addr.Size = new System.Drawing.Size(124, 60);
            this.Addr.TabIndex = 9;
            this.Addr.Text = "Addr";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Gender.Location = new System.Drawing.Point(1071, 647);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(172, 60);
            this.Gender.TabIndex = 11;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ChooseGender
            // 
            this.ChooseGender.FormattingEnabled = true;
            this.ChooseGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Apache-28"});
            this.ChooseGender.Location = new System.Drawing.Point(1609, 663);
            this.ChooseGender.Name = "ChooseGender";
            this.ChooseGender.Size = new System.Drawing.Size(391, 45);
            this.ChooseGender.TabIndex = 12;
            // 
            // Adding
            // 
            this.Adding.BackColor = System.Drawing.Color.Transparent;
            this.Adding.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Adding.Location = new System.Drawing.Point(39, 538);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(401, 107);
            this.Adding.TabIndex = 13;
            this.Adding.Text = "Add";
            this.Adding.UseVisualStyleBackColor = false;
            this.Adding.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deleting
            // 
            this.Deleting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deleting.ForeColor = System.Drawing.Color.Red;
            this.Deleting.Location = new System.Drawing.Point(39, 846);
            this.Deleting.Name = "Deleting";
            this.Deleting.Size = new System.Drawing.Size(401, 107);
            this.Deleting.TabIndex = 14;
            this.Deleting.Text = "Delete";
            this.Deleting.UseVisualStyleBackColor = true;
            this.Deleting.Click += new System.EventHandler(this.Deleting_Click);
            // 
            // Updating
            // 
            this.Updating.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Updating.ForeColor = System.Drawing.Color.Teal;
            this.Updating.Location = new System.Drawing.Point(39, 690);
            this.Updating.Name = "Updating";
            this.Updating.Size = new System.Drawing.Size(401, 107);
            this.Updating.TabIndex = 15;
            this.Updating.Text = "Update";
            this.Updating.UseVisualStyleBackColor = true;
            this.Updating.Click += new System.EventHandler(this.Updating_Click);
            // 
            // Clearing
            // 
            this.Clearing.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clearing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clearing.Location = new System.Drawing.Point(567, 538);
            this.Clearing.Name = "Clearing";
            this.Clearing.Size = new System.Drawing.Size(401, 107);
            this.Clearing.TabIndex = 16;
            this.Clearing.Text = "Clear";
            this.Clearing.UseVisualStyleBackColor = true;
            this.Clearing.Click += new System.EventHandler(this.Clearing_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(1077, 744);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 92;
            this.GridView.RowTemplate.Height = 45;
            this.GridView.Size = new System.Drawing.Size(1116, 243);
            this.GridView.TabIndex = 17;
            this.GridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView_RowHeaderMouseClick);
            // 
            // Searching
            // 
            this.Searching.AutoSize = true;
            this.Searching.Location = new System.Drawing.Point(846, 846);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(95, 37);
            this.Searching.TabIndex = 18;
            this.Searching.Text = "Search";
            this.Searching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForSearching
            // 
            this.ForSearching.Location = new System.Drawing.Point(790, 929);
            this.ForSearching.Name = "ForSearching";
            this.ForSearching.PlaceholderText = "Enter Here";
            this.ForSearching.Size = new System.Drawing.Size(225, 43);
            this.ForSearching.TabIndex = 19;
            this.ForSearching.TextChanged += new System.EventHandler(this.ForSearching_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2018, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2205, 999);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForSearching);
            this.Controls.Add(this.Searching);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Clearing);
            this.Controls.Add(this.Updating);
            this.Controls.Add(this.Deleting);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.ChooseGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Addr);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.ContNum);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameBX);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.IBlContactId);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contact";
            this.Text = "Da First APP";
            this.Load += new System.EventHandler(this.Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label IBlContactId;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameBX;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label ContNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Addr;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox ChooseGender;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.Button Deleting;
        private System.Windows.Forms.Button Updating;
        private System.Windows.Forms.Button Clearing;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label Searching;
        private System.Windows.Forms.TextBox ForSearching;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

