namespace Json_to_PDF_App
{
    partial class formResumeCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResumeCreator));
            this.txtbxJSON = new System.Windows.Forms.TextBox();
            this.BtnJson = new System.Windows.Forms.Button();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.txtbxMobile = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtbxFacebook = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtbxBirthday = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.txtbxEducation = new System.Windows.Forms.TextBox();
            this.txtbxSkills = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.txtbxWork = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.TxtbxCharacterREf = new System.Windows.Forms.TextBox();
            this.lblCharacterRef = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxJSON
            // 
            this.txtbxJSON.Location = new System.Drawing.Point(572, 68);
            this.txtbxJSON.Multiline = true;
            this.txtbxJSON.Name = "txtbxJSON";
            this.txtbxJSON.Size = new System.Drawing.Size(183, 45);
            this.txtbxJSON.TabIndex = 0;
            // 
            // BtnJson
            // 
            this.BtnJson.Location = new System.Drawing.Point(602, 139);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(125, 23);
            this.BtnJson.TabIndex = 1;
            this.BtnJson.Text = "Convert to JSON";
            this.BtnJson.UseVisualStyleBackColor = true;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(35, 84);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(276, 20);
            this.txtbxFullName.TabIndex = 2;
            // 
            // txtbxMobile
            // 
            this.txtbxMobile.Location = new System.Drawing.Point(35, 181);
            this.txtbxMobile.Name = "txtbxMobile";
            this.txtbxMobile.Size = new System.Drawing.Size(154, 20);
            this.txtbxMobile.TabIndex = 3;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(35, 129);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(465, 20);
            this.txtbxAddress.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(32, 68);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(32, 165);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(78, 13);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "Mobile Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(32, 113);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(56, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(409, 39);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Create your own Resume";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(195, 181);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(139, 20);
            this.txtbxEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(195, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(337, 165);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(55, 13);
            this.lblFacebook.TabIndex = 12;
            this.lblFacebook.Text = "Facebook";
            // 
            // txtbxFacebook
            // 
            this.txtbxFacebook.Location = new System.Drawing.Point(340, 181);
            this.txtbxFacebook.Name = "txtbxFacebook";
            this.txtbxFacebook.Size = new System.Drawing.Size(160, 20);
            this.txtbxFacebook.TabIndex = 11;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(317, 68);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 14;
            this.lblBirthday.Text = "Birthday";
            // 
            // txtbxBirthday
            // 
            this.txtbxBirthday.Location = new System.Drawing.Point(317, 84);
            this.txtbxBirthday.Name = "txtbxBirthday";
            this.txtbxBirthday.Size = new System.Drawing.Size(183, 20);
            this.txtbxBirthday.TabIndex = 13;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(32, 231);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(116, 13);
            this.lblEducation.TabIndex = 15;
            this.lblEducation.Text = "Educational Attainment";
            // 
            // txtbxEducation
            // 
            this.txtbxEducation.Location = new System.Drawing.Point(35, 247);
            this.txtbxEducation.Multiline = true;
            this.txtbxEducation.Name = "txtbxEducation";
            this.txtbxEducation.Size = new System.Drawing.Size(465, 54);
            this.txtbxEducation.TabIndex = 16;
            // 
            // txtbxSkills
            // 
            this.txtbxSkills.Location = new System.Drawing.Point(35, 339);
            this.txtbxSkills.Multiline = true;
            this.txtbxSkills.Name = "txtbxSkills";
            this.txtbxSkills.Size = new System.Drawing.Size(465, 54);
            this.txtbxSkills.TabIndex = 18;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(32, 323);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(31, 13);
            this.lblSkills.TabIndex = 17;
            this.lblSkills.Text = "Skills";
            // 
            // txtbxWork
            // 
            this.txtbxWork.Location = new System.Drawing.Point(35, 425);
            this.txtbxWork.Multiline = true;
            this.txtbxWork.Name = "txtbxWork";
            this.txtbxWork.Size = new System.Drawing.Size(465, 54);
            this.txtbxWork.TabIndex = 20;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(32, 409);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(89, 13);
            this.lblWork.TabIndex = 19;
            this.lblWork.Text = "Work Experience";
            // 
            // TxtbxCharacterREf
            // 
            this.TxtbxCharacterREf.Location = new System.Drawing.Point(35, 507);
            this.TxtbxCharacterREf.Multiline = true;
            this.TxtbxCharacterREf.Name = "TxtbxCharacterREf";
            this.TxtbxCharacterREf.Size = new System.Drawing.Size(465, 54);
            this.TxtbxCharacterREf.TabIndex = 22;
            // 
            // lblCharacterRef
            // 
            this.lblCharacterRef.AutoSize = true;
            this.lblCharacterRef.Location = new System.Drawing.Point(32, 491);
            this.lblCharacterRef.Name = "lblCharacterRef";
            this.lblCharacterRef.Size = new System.Drawing.Size(106, 13);
            this.lblCharacterRef.TabIndex = 21;
            this.lblCharacterRef.Text = "Character Reference";
            this.lblCharacterRef.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(614, 277);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "Read Json";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // formResumeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.TxtbxCharacterREf);
            this.Controls.Add(this.lblCharacterRef);
            this.Controls.Add(this.txtbxWork);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.txtbxSkills);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.txtbxEducation);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtbxBirthday);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.txtbxFacebook);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxMobile);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.txtbxJSON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formResumeCreator";
            this.Text = "Resumake  - Free Resume Maker";
            this.Load += new System.EventHandler(this.formResumeCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxJSON;
        private System.Windows.Forms.Button BtnJson;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.TextBox txtbxMobile;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtbxFacebook;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtbxBirthday;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox txtbxEducation;
        private System.Windows.Forms.TextBox txtbxSkills;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.TextBox txtbxWork;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.TextBox TxtbxCharacterREf;
        private System.Windows.Forms.Label lblCharacterRef;
        private System.Windows.Forms.Button btnRead;
    }
}

