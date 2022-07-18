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
            public string Objective { get; set; }
            public string ContactNo { get; set; }
            public string EmailAddress { get; set; }
            public string Address { get; set; }
            public string Facebook { get; set; }
            public string School { get; set; }
            public string Course { get; set; }
            public string SchoolAddress { get; set; }
            public string SchoolYear { get; set; }
            public string School1 { get; set; }
            public string Strand { get; set; }
            public string SchoolAddress1 { get; set; }
            public string SchoolYear1 { get; set; }
            public string School2 { get; set; }
            public string SchoolAddress2 { get; set; }
            public string SchoolYear2 { get; set; }
            public string School3 { get; set; }
            public string SchoolAddress3 { get; set; }
            public string SchoolYear3 { get; set; }
            public string School4 { get; set; }
            public string SchoolAddress4 { get; set; }
            public string SchoolYear4 { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Skill4 { get; set; }
            public string Skill5 { get; set; }
            public string Skill6 { get; set; }
            public string GithubAccountLink { get; set; }
            public string CharacterReferenceName { get; set; }
            public string CharacterReferenceCompany { get; set; }
            public string CharacterReferencePosition { get; set; }
            public string CharacterReferenceMobile { get; set; }
            public string CharacterReferenceName1 { get; set; }
            public string CharacterReferenceCompany1 { get; set; }
            public string CharacterReferencePosition1 { get; set; }
            public string CharacterReferenceMobile1 { get; set; }
            public string CharacterReferenceName2 { get; set; }
            public string CharacterReferenceCompany2 { get; set; }
            public string CharacterReferencePosition2 { get; set; }
            public string CharacterReferenceMobile2 { get; set; }
        }



        private void BtnJson_Click(object sender, EventArgs e)
        {
            
        }

        private void formResumeCreator_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var Json_Path = @"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\Resume.json";
            String Json_Content = File.ReadAllText(Json_Path);
            Resume_Content Resume = JsonConvert.DeserializeObject<Resume_Content>(Json_Content);

            txtbxName.Text = Resume.Name;
            txtbxPosition.Text = Resume.Position;
            txtbxObjective.Text = Resume.Objective;
            txtbxContact.Text = Resume.ContactNo + "\r\n" + Resume.EmailAddress + "\r\n" + Resume.Address + "\r\n" + Resume.Facebook;
            txtbxEducation.Text = Resume.School + "\r\n" + Resume.Course + "\r\n" + Resume.SchoolAddress + "\r\n" + Resume.SchoolYear + "\r\n" + "\r\n" +
                                Resume.School1 + "\r\n" + Resume.Strand + "\r\n" + Resume.SchoolAddress1 + "\r\n" + Resume.SchoolYear1 + "\r\n" + "\r\n" +
                                Resume.School2 + "\r\n" + Resume.SchoolAddress2 + "\r\n" + Resume.SchoolYear2 + "\r\n" + "\r\n" +
                                Resume.School3 + "\r\n" + Resume.SchoolAddress3 + "\r\n" + Resume.SchoolYear3 + "\r\n" + "\r\n" +
                                Resume.School4 + "\r\n" + Resume.SchoolAddress4 + "\r\n" + Resume.SchoolYear4;
            txtbxSkills.Text = Resume.Skill1 + "\r\n" + Resume.Skill2 + "\r\n" + Resume.Skill3 + "\r\n" + Resume.Skill4 + "\r\n" + Resume.Skill5 + "\r\n" + Resume.Skill6 + "\r\n" + "\r\n" + Resume.GithubAccountLink;
            txtbxCharRef.Text = Resume.CharacterReferenceName + "\r\n" + Resume.CharacterReferenceCompany + "\r\n" + Resume.CharacterReferencePosition + "\r\n" + Resume.CharacterReferenceMobile;
            txtbxCharRef1.Text = Resume.CharacterReferenceName1 + "\r\n" + Resume.CharacterReferenceCompany1 + "\r\n" + Resume.CharacterReferencePosition1 + "\r\n" + Resume.CharacterReferenceMobile1;
            txtbxCharRef2.Text = Resume.CharacterReferenceName2 + "\r\n" + Resume.CharacterReferenceCompany2 + "\r\n" + Resume.CharacterReferencePosition2 + "\r\n" + Resume.CharacterReferenceMobile2;


        }
    }
}
