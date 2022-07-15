namespace Json_to_PDF_App
{
    partial class Form1
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
            this.txtbxJSON = new System.Windows.Forms.TextBox();
            this.BtnJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxJSON
            // 
            this.txtbxJSON.Location = new System.Drawing.Point(161, 79);
            this.txtbxJSON.Multiline = true;
            this.txtbxJSON.Name = "txtbxJSON";
            this.txtbxJSON.Size = new System.Drawing.Size(435, 103);
            this.txtbxJSON.TabIndex = 0;
            // 
            // BtnJson
            // 
            this.BtnJson.Location = new System.Drawing.Point(319, 220);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(125, 23);
            this.BtnJson.TabIndex = 1;
            this.BtnJson.Text = "Convert to JSON";
            this.BtnJson.UseVisualStyleBackColor = true;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.txtbxJSON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxJSON;
        private System.Windows.Forms.Button BtnJson;
    }
}

