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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtbxPosition = new System.Windows.Forms.TextBox();
            this.lblObjective = new System.Windows.Forms.Label();
            this.txtbxObjective = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtbxContact = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.txtbxEducation = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.txtbxSkills = new System.Windows.Forms.TextBox();
            this.lblCharRef = new System.Windows.Forms.Label();
            this.txtbxCharRef = new System.Windows.Forms.TextBox();
            this.txtbxCharRef1 = new System.Windows.Forms.TextBox();
            this.txtbxCharRef2 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(251, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(409, 39);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Create your own Resume";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(591, 68);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(117, 47);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "Deserialize";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(31, 150);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(302, 20);
            this.txtbxName.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(28, 177);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 27;
            this.lblPosition.Text = "Position:";
            // 
            // txtbxPosition
            // 
            this.txtbxPosition.Location = new System.Drawing.Point(31, 193);
            this.txtbxPosition.Name = "txtbxPosition";
            this.txtbxPosition.Size = new System.Drawing.Size(302, 20);
            this.txtbxPosition.TabIndex = 26;
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Location = new System.Drawing.Point(349, 136);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(55, 13);
            this.lblObjective.TabIndex = 29;
            this.lblObjective.Text = "Objective:";
            // 
            // txtbxObjective
            // 
            this.txtbxObjective.Location = new System.Drawing.Point(352, 152);
            this.txtbxObjective.Multiline = true;
            this.txtbxObjective.Name = "txtbxObjective";
            this.txtbxObjective.Size = new System.Drawing.Size(437, 61);
            this.txtbxObjective.TabIndex = 28;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(28, 394);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(79, 13);
            this.lblContact.TabIndex = 31;
            this.lblContact.Text = "Contact Details";
            // 
            // txtbxContact
            // 
            this.txtbxContact.Location = new System.Drawing.Point(31, 410);
            this.txtbxContact.Multiline = true;
            this.txtbxContact.Name = "txtbxContact";
            this.txtbxContact.Size = new System.Drawing.Size(306, 132);
            this.txtbxContact.TabIndex = 30;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(349, 231);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(124, 13);
            this.lblEducation.TabIndex = 33;
            this.lblEducation.Text = "Educational Background";
            // 
            // txtbxEducation
            // 
            this.txtbxEducation.Location = new System.Drawing.Point(352, 247);
            this.txtbxEducation.Multiline = true;
            this.txtbxEducation.Name = "txtbxEducation";
            this.txtbxEducation.Size = new System.Drawing.Size(437, 295);
            this.txtbxEducation.TabIndex = 32;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(32, 231);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(31, 13);
            this.lblSkills.TabIndex = 35;
            this.lblSkills.Text = "Skills";
            // 
            // txtbxSkills
            // 
            this.txtbxSkills.Location = new System.Drawing.Point(31, 247);
            this.txtbxSkills.Multiline = true;
            this.txtbxSkills.Name = "txtbxSkills";
            this.txtbxSkills.Size = new System.Drawing.Size(306, 135);
            this.txtbxSkills.TabIndex = 34;
            // 
            // lblCharRef
            // 
            this.lblCharRef.AutoSize = true;
            this.lblCharRef.Location = new System.Drawing.Point(28, 552);
            this.lblCharRef.Name = "lblCharRef";
            this.lblCharRef.Size = new System.Drawing.Size(106, 13);
            this.lblCharRef.TabIndex = 37;
            this.lblCharRef.Text = "Character Reference";
            // 
            // txtbxCharRef
            // 
            this.txtbxCharRef.Location = new System.Drawing.Point(31, 568);
            this.txtbxCharRef.Multiline = true;
            this.txtbxCharRef.Name = "txtbxCharRef";
            this.txtbxCharRef.Size = new System.Drawing.Size(234, 113);
            this.txtbxCharRef.TabIndex = 36;
            // 
            // txtbxCharRef1
            // 
            this.txtbxCharRef1.Location = new System.Drawing.Point(291, 568);
            this.txtbxCharRef1.Multiline = true;
            this.txtbxCharRef1.Name = "txtbxCharRef1";
            this.txtbxCharRef1.Size = new System.Drawing.Size(234, 113);
            this.txtbxCharRef1.TabIndex = 38;
            // 
            // txtbxCharRef2
            // 
            this.txtbxCharRef2.Location = new System.Drawing.Point(555, 568);
            this.txtbxCharRef2.Multiline = true;
            this.txtbxCharRef2.Name = "txtbxCharRef2";
            this.txtbxCharRef2.Size = new System.Drawing.Size(234, 113);
            this.txtbxCharRef2.TabIndex = 39;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(33, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(217, 16);
            this.lblSearch.TabIndex = 40;
            this.lblSearch.Text = "Input the File name of the Json";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(256, 82);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(318, 20);
            this.txtbxSearch.TabIndex = 41;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(346, 696);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(127, 50);
            this.btnPDF.TabIndex = 42;
            this.btnPDF.Text = "Create PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // formResumeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(890, 749);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtbxCharRef2);
            this.Controls.Add(this.txtbxCharRef1);
            this.Controls.Add(this.lblCharRef);
            this.Controls.Add(this.txtbxCharRef);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.txtbxSkills);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.txtbxEducation);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtbxContact);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.txtbxObjective);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtbxPosition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formResumeCreator";
            this.Text = "Resumake  - Free Resume Maker";
            this.Load += new System.EventHandler(this.formResumeCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtbxPosition;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.TextBox txtbxObjective;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtbxContact;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox txtbxEducation;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.TextBox txtbxSkills;
        private System.Windows.Forms.Label lblCharRef;
        private System.Windows.Forms.TextBox txtbxCharRef;
        private System.Windows.Forms.TextBox txtbxCharRef1;
        private System.Windows.Forms.TextBox txtbxCharRef2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnPDF;
    }
}

