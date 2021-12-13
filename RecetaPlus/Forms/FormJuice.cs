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
    public partial class FormJuice : Form
    {
        int counter = 0;
        public FormJuice()
        {
            InitializeComponent();
        }

        private void FormJuice_Load(object sender, EventArgs e)
        {
            txtBoxJuice.Text = APIcalls.Search(counter, "Juice");
        }

        private void btnNextJuice_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxJuice.Text = APIcalls.Search(counter, "Juice");
        }

        private void btnPreviousJuice_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxJuice.Text = APIcalls.Search(counter, "Juice");
        }
    }
}
