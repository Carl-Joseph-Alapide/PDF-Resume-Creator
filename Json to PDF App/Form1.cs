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
            MessageBox.Show(Resume.Name);
            MessageBox.Show(Resume.Position);
            MessageBox.Show(Resume.Objective);
            MessageBox.Show(Resume.ContactNo);
            MessageBox.Show(Resume.EmailAddress);
            MessageBox.Show(Resume.Address);
            MessageBox.Show(Resume.Facebook);
            MessageBox.Show(Resume.School);
            MessageBox.Show(Resume.SchoolAddress);
            MessageBox.Show(Resume.SchoolYear);
            MessageBox.Show(Resume.School1);
            MessageBox.Show(Resume.Strand);
            MessageBox.Show(Resume.SchoolAddress1);
            MessageBox.Show(Resume.SchoolYear1);
            MessageBox.Show(Resume.School2);
            MessageBox.Show(Resume.SchoolAddress2);
            MessageBox.Show(Resume.SchoolYear2);
            MessageBox.Show(Resume.School3);
            MessageBox.Show(Resume.SchoolAddress3);
            MessageBox.Show(Resume.SchoolYear3);
            MessageBox.Show(Resume.School4);
            MessageBox.Show(Resume.SchoolAddress4);
            MessageBox.Show(Resume.SchoolYear4);
            MessageBox.Show(Resume.Skill1);
            MessageBox.Show(Resume.Skill2);
            MessageBox.Show(Resume.Skill3);
            MessageBox.Show(Resume.Skill4);
            MessageBox.Show(Resume.Skill5);
            MessageBox.Show(Resume.Skill6);
            MessageBox.Show(Resume.GithubAccountLink);
            MessageBox.Show(Resume.CharacterReferenceName);
            MessageBox.Show(Resume.CharacterReferenceCompany);
            MessageBox.Show(Resume.CharacterReferencePosition);
            MessageBox.Show(Resume.CharacterReferenceMobile);
            MessageBox.Show(Resume.CharacterReferenceName1);
            MessageBox.Show(Resume.CharacterReferenceCompany1);
            MessageBox.Show(Resume.CharacterReferencePosition1);
            MessageBox.Show(Resume.CharacterReferenceMobile1);
            MessageBox.Show(Resume.CharacterReferenceName2);
            MessageBox.Show(Resume.CharacterReferenceCompany2);
            MessageBox.Show(Resume.CharacterReferencePosition2);
            MessageBox.Show(Resume.CharacterReferenceMobile2);



        }
    }
}
