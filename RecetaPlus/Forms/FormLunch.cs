using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace RecetaPlus.Forms
{
    public partial class FormLunch : Form
    {
        int counter = 0;
        public FormLunch()
        {
            InitializeComponent();
        }

        private void FormLunch_Load(object sender, EventArgs e)
        {
            txtBoxLunch.Text = APIcalls.Search(counter, "Lunch");
        }

        private void btnNextLunch_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxLunch.Text = APIcalls.Search(counter, "Lunch");
        }

        private void btnPreviousLunch_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxLunch.Text = APIcalls.Search(counter, "Lunch");
        }
    }
}
