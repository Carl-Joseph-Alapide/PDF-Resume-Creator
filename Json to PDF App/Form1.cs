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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Json_to_PDF_App
{
    public partial class formResumeCreator : Form
    {
        public formResumeCreator()
        {
            InitializeComponent();

        }

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
            public string Link { get; set; }
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
            try
            {
                var Json_Path = @"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\" + txtbxSearch.Text + ".json";
                String Json_Content = File.ReadAllText(Json_Path);
                Resume_Content Resume = JsonConvert.DeserializeObject<Resume_Content>(Json_Content);

                txtbxName.Text = Resume.Name;
                txtbxPosition.Text = Resume.Position;
                txtbxObjective.Text = Resume.Objective;
                txtbxContact.Text = Resume.ContactNo + "\r\n" + Resume.EmailAddress + "\r\n" + Resume.Address + "\r\n" + Resume.Facebook;
                txtbxEducation.Text = "College" + "                                                                        " + "Senior HighSchool" + "\r\n" + Resume.School + "                    " + Resume.School1 + "\r\n" +
                                     Resume.Course + "           " + Resume.Strand + "\r\n" + Resume.SchoolAddress + "                                                        " + Resume.SchoolAddress1 + "\r\n" +
                                     Resume.SchoolYear + "                                                              " + Resume.SchoolYear1 + "\r\n" + "\r\n" + "HighSchool" + "                                       " + "Elementary" + "\r\n" +
                                     Resume.School2 + "                              " + Resume.School3 + "\r\n" + Resume.SchoolAddress2 + "           " + Resume.SchoolAddress3 + "\r\n" +
                                     Resume.SchoolYear2 + "                                        " + Resume.SchoolYear3 + "\r\n" + "\r\n" + "Elementary" + "\r\n" + Resume.School4 + "\r\n" + Resume.SchoolAddress4 + "\r\n" +
                                     Resume.SchoolYear4;

                txtbxSkills.Text = Resume.Skill1 + "              " + Resume.Skill2 + "            " + Resume.Skill3 + "\r\n" + Resume.Skill4 + "          " + Resume.Skill5 + "              " + Resume.Skill6 + "\r\n" + "\r\n" + Resume.Link + "\r\n" +  Resume.GithubAccountLink;
                txtbxCharRef.Text = Resume.CharacterReferenceName + "\r\n" + Resume.CharacterReferencePosition + "\r\n" + Resume.CharacterReferenceCompany + "\r\n" + Resume.CharacterReferenceMobile + ".";
                txtbxCharRef1.Text = Resume.CharacterReferenceName1 + "\r\n" + Resume.CharacterReferencePosition1 + "\r\n" + Resume.CharacterReferenceCompany1 + "\r\n" + Resume.CharacterReferenceMobile1 + ".";
                txtbxCharRef2.Text = Resume.CharacterReferenceName2 + "\r\n" + Resume.CharacterReferencePosition2 + "\r\n" + Resume.CharacterReferenceCompany2 + "\r\n" + Resume.CharacterReferenceMobile2 + ".";
                txtbxSearch.Clear();
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtbxSearch.Text))
                    MessageBox.Show("Please type the name of your file before deserializing", "File name cannot be blank");
                else
                    MessageBox.Show("There is no such file that has this name","Sorry");
                
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            bool Continue = true;
            Document Docs = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter PDF = PdfWriter.GetInstance(Docs, new FileStream(@"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\Alapide, Carl Joseph Resume.pdf", FileMode.Create));
            Docs.Open();
            try
            {

                iTextSharp.text.Image Photo = iTextSharp.text.Image.GetInstance(@"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\" + txtbxPhoto.Text);
                Photo.ScalePercent(25f);
                Photo.SetAbsolutePosition(Docs.PageSize.Width - 20f - 170f, Docs.PageSize.Height - 36f - 150.6f);
                Photo.Border = iTextSharp.text.Rectangle.BOX;
                Photo.BorderColor = iTextSharp.text.BaseColor.BLACK;
                Photo.BorderWidth = 2f;
                Docs.Add(Photo);
            }

            catch (Exception)
            {
                Continue = false;
                if (string.IsNullOrEmpty(txtbxPhoto.Text))
                {
                    MessageBox.Show("Please type the file name of your resume photo","Incomplete Details");
                }
                else
                {
                    MessageBox.Show("Sorry We couldn't find an image with this File name","Incomplete Details");
                }
            }

            if (string.IsNullOrEmpty(txtbxName.Text))
            {
                MessageBox.Show("Please Fill out all the details", "Incomplete Details");
            }
            else if (Continue == false)
            {
                MessageBox.Show("Please Fill out all the details", "Incomplete Details");
            }
            else
            {
                Paragraph Name = new Paragraph(txtbxName.Text);
                Paragraph Position = new Paragraph(txtbxPosition.Text);
                Paragraph objective = new Paragraph(txtbxObjective.Text);
                Paragraph contact = new Paragraph(txtbxContact.Text);
                Paragraph Skills = new Paragraph(txtbxSkills.Text);
                Paragraph Education = new Paragraph(txtbxEducation.Text);
                Paragraph char_Ref = new Paragraph(txtbxCharRef.Text);
                Paragraph char_Ref1 = new Paragraph(txtbxCharRef1.Text);
                Paragraph char_Ref2 = new Paragraph(txtbxCharRef2.Text);
                Paragraph ProfileTitle = new Paragraph("Profile");
                Paragraph SkillTitle = new Paragraph("Skills");
                Paragraph EducationTitle = new Paragraph("Educational background");
                Paragraph CharTitle = new Paragraph("Character Reference");
                Chunk Divider = new Chunk("         ________________________________________________");
                Chunk Space = new Chunk("                                         ");

                Name.Font.Size = 25f;
                Name.IndentationLeft = 40f;
                Name.Font.SetStyle("bold");
                Name.Font.SetFamily("Courier");

                Position.Font.Size = 15f;
                Position.IndentationLeft = 145f;
                Position.Font.SetFamily("Times New Roman");

                objective.Font.Size = 12f;
                objective.Font.SetFamily("Times New Roman");
                objective.Alignment = Element.ALIGN_LEFT;
                objective.IndentationLeft = 25f;
                objective.IndentationRight = 30f;

                contact.Font.Size = 10f;
                contact.IndentationLeft = 25f;
                contact.Alignment = Element.ALIGN_LEFT;
                contact.Font.SetFamily("Times New Roman");

                Skills.Font.Size = 10f;
                Skills.Alignment = Element.ALIGN_LEFT;
                Skills.Font.SetFamily("Times New Roman");
                Skills.IndentationLeft = 25;
                Skills.IndentationRight = 25;

                Education.Font.Size = 10;
                Education.Alignment = Element.ALIGN_LEFT;
                Education.Font.SetFamily("Times New Roman");
                Education.IndentationLeft = 25f;
                Education.IndentationRight = 25f;

                char_Ref.Font.Size = 10;
                char_Ref.Alignment = Element.ALIGN_LEFT;
                char_Ref.Font.SetFamily("Times New Roman");
                char_Ref.IndentationLeft = 25f;
                char_Ref.IndentationRight = 25f;

                char_Ref1.Font.Size = 10;
                char_Ref1.Alignment = Element.ALIGN_LEFT;
                char_Ref1.Font.SetFamily("Times New Roman");
                char_Ref1.IndentationLeft = 25f;
                char_Ref1.IndentationRight = 25f;

                char_Ref2.Font.Size = 10;
                char_Ref2.Alignment = Element.ALIGN_LEFT;
                char_Ref2.Font.SetFamily("Times New Roman");
                char_Ref2.IndentationLeft = 25f;
                char_Ref2.IndentationRight = 25f;

                ProfileTitle.Font.Size = 18f;
                ProfileTitle.IndentationLeft = 25f;
                ProfileTitle.Font.SetStyle("bold");
                ProfileTitle.Font.SetFamily("Times New Roman");
                ProfileTitle.Alignment = Element.ALIGN_LEFT;

                SkillTitle.Font.Size = 18f;
                SkillTitle.IndentationLeft = 25f;
                SkillTitle.Font.SetStyle("bold");
                SkillTitle.Font.SetFamily("Times New Roman");
                SkillTitle.Alignment = Element.ALIGN_LEFT;

                EducationTitle.Font.Size = 18f;
                EducationTitle.IndentationLeft = 25f;
                EducationTitle.Font.SetStyle("bold");
                EducationTitle.Font.SetFamily("Times New Roman");
                EducationTitle.Alignment = Element.ALIGN_LEFT;

                CharTitle.Font.Size = 18f;
                CharTitle.IndentationLeft = 25f;
                CharTitle.Font.SetStyle("bold");
                CharTitle.Font.SetFamily("Times New Roman");
                CharTitle.Alignment = Element.ALIGN_LEFT;

                Docs.Add(Name);
                Docs.Add(Position);
                Docs.Add(contact);
                Docs.Add(Divider);
                Docs.Add(Space);
                Docs.Add(Space);
                Docs.Add(ProfileTitle);
                Docs.Add(Space);
                Docs.Add(objective);
                Docs.Add(Space);
                Docs.Add(SkillTitle);
                Docs.Add(Space);
                Docs.Add(Skills);
                Docs.Add(Space);
                Docs.Add(EducationTitle);
                Docs.Add(Space);
                Docs.Add(Education);
                Docs.Add(Space);
                Docs.Add(Space);
                Docs.Add(Space);
                Docs.Add(Space);
                Docs.Add(Space);
                Docs.Add(CharTitle);
                Docs.Add(Space);
                Docs.Add(char_Ref);
                Docs.Add(Space);
                Docs.Add(char_Ref1);
                Docs.Add(Space);
                Docs.Add(char_Ref2);

                Docs.Close();

                MessageBox.Show("A PDF of your Resume was Created", "Success");
            }
        }

    }
}
