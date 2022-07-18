using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Json_to_PDF_App
{
    public partial class formResumeCreator : Form
    {
        public formResumeCreator()
        {
            InitializeComponent();

        }

        //static void Main(string[] args)
        //{

        //    //var Resume = new Resume_Content
        //    //{
              
        //    //};

        //}
        //[Serializable]

        private class Resume_Content
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public string Career_Objective { get; set; }
            public string ContactNo { get; set; }
            public string EmailAddress { get; set; }
            public string Address { get; set; }
            public string Facebook { get; set; }
            public string School { get; set; }
            public string Course { get; set; }
            public string School_Address { get; set; }
            public string School_Year { get; set; }
            public string School1 { get; set; }
            public string Strand { get; set; }
            public string School_Year1 { get; set; }
            public string School2 { get; set; }
            public string School_Address2 { get; set; }
            public string School_Year2 { get; set; }
            public string School3 { get; set; }
            public string School_Address3 { get; set; }
            public string School_Year3 { get; set; }
            public string School_4 { get; set; }
            public string School_Address_4 { get; set; }
            public string School_Year_4 { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Skill4 { get; set; }
            public string Skill5 { get; set; }
            public string Skill6 { get; set; }
            public string Github_Account_Link { get; set; }
            public string Character_Referenc_Name { get; set; }
            public string Character_Reference_Company { get; set; }
            public string Character_Reference_Position { get; set; }
            public string Character_Reference_Mobile { get; set; }
            public string Character_Reference_Name1 { get; set; }
            public string Character_Reference_Company1 { get; set; }
            public string Character_Reference_Position1 { get; set; }
            public string Character_Reference_Mobile1 { get; set; }
            public string Character_Reference_Name2 { get; set; }
            public string Character_Reference_Company2 { get; set; }
            public string Character_Reference_Position2 { get; set; }
            public string Character_Reference_Mobile2 { get; set; }


        }



        private void BtnJson_Click(object sender, EventArgs e)
        {
            
        }

        private void formResumeCreator_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var Json_Path = @"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\resume.json";
            String Json_Content = File.ReadAllText(Json_Path);
        }
    }
}
