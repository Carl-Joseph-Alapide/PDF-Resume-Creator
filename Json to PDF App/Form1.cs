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

        static void Main(string[] args)
        {

            var Resume = new Resume_Content
            {
                Name = "Carl Joseph B. Alapide",
                Birthday = "May 27, 2003",
                Address = "Ph8 B block 70 lot 10 Bagong Silang Caloocan city",
                Mobile_no = "09218007914",
                Email = "carljosephalapide@gmail.com",
                Facebook = "Carl Josep Alapide",
                Education = "Polytechnic University of the Philippines",
                Skills = "Programming Skills",
                Work_Exp = "Call center Agent",
                Char_Ref = "Nerissa Cortez"
            };

        }
        [Serializable]

        private class Resume_Content
        {
            public string Name { get; set; }
            public string Birthday { get; set; }
            public string Address { get; set; }
            public string Mobile_no { get; set; }
            public string Email { get; set; }
            public string Facebook { get; set; }
            public string Education { get; set; }
            public string Skills { get; set; }
            public string Work_Exp { get; set; }
            public string Char_Ref { get; set; }

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

        private void btnRead_Click(object sender, EventArgs e)
        {
           
        }
    }
}
