namespace ToolTest.Views
{
    partial class FrmPlayer
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
            this.components = new System.ComponentModel.Container();
            this.TxtPlayerName = new System.Windows.Forms.Label();
            this.TxtbPlayerName = new System.Windows.Forms.TextBox();
            this.RbtnMale = new System.Windows.Forms.RadioButton();
            this.RbtnFemale = new System.Windows.Forms.RadioButton();
            this.RbtnMasic = new System.Windows.Forms.RadioButton();
            this.RbtnSword = new System.Windows.Forms.RadioButton();
            this.GbxSex = new System.Windows.Forms.GroupBox();
            this.GbxJob = new System.Windows.Forms.GroupBox();
            this.CbxBraver = new System.Windows.Forms.CheckBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.HptextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbxSex.SuspendLayout();
            this.GbxJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.AutoSize = true;
            this.TxtPlayerName.Location = new System.Drawing.Point(60, 59);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(66, 12);
            this.TxtPlayerName.TabIndex = 0;
            this.TxtPlayerName.Text = "PlayerName";
            // 
            // TxtbPlayerName
            // 
            this.TxtbPlayerName.Location = new System.Drawing.Point(132, 56);
            this.TxtbPlayerName.Name = "TxtbPlayerName";
            this.TxtbPlayerName.Size = new System.Drawing.Size(100, 19);
            this.TxtbPlayerName.TabIndex = 1;
            // 
            // RbtnMale
            // 
            this.RbtnMale.AutoSize = true;
            this.RbtnMale.Location = new System.Drawing.Point(31, 13);
            this.RbtnMale.Name = "RbtnMale";
            this.RbtnMale.Size = new System.Drawing.Size(47, 16);
            this.RbtnMale.TabIndex = 2;
            this.RbtnMale.TabStop = true;
            this.RbtnMale.Text = "Male";
            this.RbtnMale.UseVisualStyleBackColor = true;
            // 
            // RbtnFemale
            // 
            this.RbtnFemale.AutoSize = true;
            this.RbtnFemale.Location = new System.Drawing.Point(114, 13);
            this.RbtnFemale.Name = "RbtnFemale";
            this.RbtnFemale.Size = new System.Drawing.Size(60, 16);
            this.RbtnFemale.TabIndex = 3;
            this.RbtnFemale.TabStop = true;
            this.RbtnFemale.Text = "Female";
            this.RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // RbtnMasic
            // 
            this.RbtnMasic.AutoSize = true;
            this.RbtnMasic.Location = new System.Drawing.Point(114, 13);
            this.RbtnMasic.Name = "RbtnMasic";
            this.RbtnMasic.Size = new System.Drawing.Size(53, 16);
            this.RbtnMasic.TabIndex = 4;
            this.RbtnMasic.TabStop = true;
            this.RbtnMasic.Text = "Masic";
            this.RbtnMasic.UseVisualStyleBackColor = true;
            // 
            // RbtnSword
            // 
            this.RbtnSword.AutoSize = true;
            this.RbtnSword.Location = new System.Drawing.Point(31, 13);
            this.RbtnSword.Name = "RbtnSword";
            this.RbtnSword.Size = new System.Drawing.Size(54, 16);
            this.RbtnSword.TabIndex = 5;
            this.RbtnSword.TabStop = true;
            this.RbtnSword.Text = "Sword";
            this.RbtnSword.UseVisualStyleBackColor = true;
            // 
            // GbxSex
            // 
            this.GbxSex.Controls.Add(this.RbtnMale);
            this.GbxSex.Controls.Add(this.RbtnFemale);
            this.GbxSex.Location = new System.Drawing.Point(62, 96);
            this.GbxSex.Name = "GbxSex";
            this.GbxSex.Size = new System.Drawing.Size(200, 46);
            this.GbxSex.TabIndex = 6;
            this.GbxSex.TabStop = false;
            this.GbxSex.Text = "Sex";
            // 
            // GbxJob
            // 
            this.GbxJob.Controls.Add(this.RbtnMasic);
            this.GbxJob.Controls.Add(this.RbtnSword);
            this.GbxJob.Location = new System.Drawing.Point(62, 148);
            this.GbxJob.Name = "GbxJob";
            this.GbxJob.Size = new System.Drawing.Size(200, 45);
            this.GbxJob.TabIndex = 7;
            this.GbxJob.TabStop = false;
            this.GbxJob.Text = "Job";
            // 
            // CbxBraver
            // 
            this.CbxBraver.AutoSize = true;
            this.CbxBraver.Location = new System.Drawing.Point(93, 199);
            this.CbxBraver.Name = "CbxBraver";
            this.CbxBraver.Size = new System.Drawing.Size(58, 16);
            this.CbxBraver.TabIndex = 8;
            this.CbxBraver.Text = "Braver";
            this.CbxBraver.UseVisualStyleBackColor = true;
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "power",
            "tecnic",
            "hard"});
            this.CmbType.Location = new System.Drawing.Point(93, 221);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(121, 20);
            this.CmbType.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSave.Location = new System.Drawing.Point(12, 390);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(101, 48);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLoad.Location = new System.Drawing.Point(132, 390);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(100, 48);
            this.BtnLoad.TabIndex = 11;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // HptextBox
            // 
            this.HptextBox.AccessibleName = "";
            this.HptextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.HptextBox.Location = new System.Drawing.Point(93, 269);
            this.HptextBox.Name = "HptextBox";
            this.HptextBox.Size = new System.Drawing.Size(121, 19);
            this.HptextBox.TabIndex = 12;
            this.HptextBox.Leave += new System.EventHandler(this.HptextBox_Leave);
            this.HptextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HptextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HptextBox);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.CbxBraver);
            this.Controls.Add(this.GbxJob);
            this.Controls.Add(this.GbxSex);
            this.Controls.Add(this.TxtbPlayerName);
            this.Controls.Add(this.TxtPlayerName);
            this.Name = "FrmPlayer";
            this.Text = "FrmPlayer";
            this.GbxSex.ResumeLayout(false);
            this.GbxSex.PerformLayout();
            this.GbxJob.ResumeLayout(false);
            this.GbxJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtPlayerName;
        private System.Windows.Forms.TextBox TxtbPlayerName;
        private System.Windows.Forms.RadioButton RbtnMale;
        private System.Windows.Forms.RadioButton RbtnFemale;
        private System.Windows.Forms.RadioButton RbtnMasic;
        private System.Windows.Forms.RadioButton RbtnSword;
        private System.Windows.Forms.GroupBox GbxSex;
        private System.Windows.Forms.GroupBox GbxJob;
        private System.Windows.Forms.CheckBox CbxBraver;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox HptextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}