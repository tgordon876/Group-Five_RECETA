using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetaPlus.Forms
{
    public partial class FormDinner : Form
    {
        int counter = 0;
        public FormDinner()
        {
            InitializeComponent();
        }

        private void FormDinner_Load(object sender, EventArgs e)
        {
            txtBoxDinner.Text = APIcalls.Search(counter, "Dinner");
        }

        private void btnNextDinner_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxDinner.Text = APIcalls.Search(counter, "Dinner");
        }

        private void btnPreviousDinner_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxDinner.Text = APIcalls.Search(counter, "Dinner");
        }
    }
}
