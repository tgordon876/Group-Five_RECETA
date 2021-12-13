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
    public partial class FormDessert : Form
    {
        int counter = 0;
        public FormDessert()
        {
            InitializeComponent();
        }

        private void FormDessert_Load(object sender, EventArgs e)
        {
            txtBoxDessert.Text = APIcalls.Search(counter, "Dessert");
        }

        private void btnNextDessert_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxDessert.Text = APIcalls.Search(counter, "Dessert");
        }

        private void btbPreviousDessert_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxDessert.Text = APIcalls.Search(counter, "Dessert");
        }
    }
}
