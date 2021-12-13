using System;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace RecetaPlus.Forms
{
    public partial class FormBreakFast : Form
    {
        int counter = 0;

        public FormBreakFast()
        {
            InitializeComponent();
        }

        private void FormBreakFast_Load(object sender, EventArgs e)
        {
            txtBoxBreakfast.Text = APIcalls.Search(counter, "Breakfast");
        }


        private void btnNextBreakfast_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxBreakfast.Text = APIcalls.Search(counter, "Breakfast");
        }

        private void btnPreviousBreakfast_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxBreakfast.Text = APIcalls.Search(counter, "Breakfast");
        }
    }
}
