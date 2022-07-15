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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnJson_Click(object sender, EventArgs e)
        {
            JSON JSON = new JSON
            {
                Name = "Carl",
                Birthday = "May 27, 2003",
                Contact_number = "09218007914",
                Address = "Bagong Silang Caloocan City"
            };
            string output = JsonConvert.SerializeObject(JSON);
            txtbxJSON.Text = output;
            StreamWriter Resume = new StreamWriter(@"C:\Users\Carl Joseph\source\repos\Json to PDF App\Json to PDF App\Resume\Resume.json");
            Resume.WriteLine(JSON.Name);
            Resume.WriteLine(JSON.Birthday);
            Resume.WriteLine(JSON.Contact_number);
            Resume.WriteLine(JSON.Address);
            Resume.Close();
        } 
    }
}
