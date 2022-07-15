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

        private void BtnJson_Click(object sender, EventArgs e)
        {
            JSON JSON = new JSON
            {
                Name = txtbxFullName.Text,
                Birthday = txtbxBirthday.Text,
                Address = txtbxAddress.Text,
                Contact_number = txtbxMobile.Text,
                Email = txtbxEmail.Text,
                Facebook = txtbxFacebook.Text,
                Education = txtbxEducation.Text,
                Skills = txtbxSkills.Text,
                Work = txtbxWork.Text,
                Character_Ref = TxtbxCharacterREf.Text
            };
            string output = JsonConvert.SerializeObject(JSON);
            txtbxJSON.Text = output;
            StreamWriter Resume = new StreamWriter(@"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\Resume.json");
            Resume.WriteLine(JSON.Name);
            Resume.WriteLine(JSON.Birthday);
            Resume.WriteLine(JSON.Address);
            Resume.WriteLine(JSON.Contact_number);
            Resume.WriteLine(JSON.Email);
            Resume.WriteLine(JSON.Facebook);
            Resume.WriteLine(JSON.Education);
            Resume.WriteLine(JSON.Skills);
            Resume.WriteLine(JSON.Work);
            Resume.WriteLine(JSON.Character_Ref);
            Resume.Close();
        }

        private void formResumeCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
