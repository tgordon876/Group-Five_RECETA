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
    public partial class FormSearch : Form
    {
        int counter = 0;
        string inputValue = "";
        public FormSearch(string input)
        {
            InitializeComponent();
            inputValue = input;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            txtBoxSearch.Text = APIcalls.Search(counter, inputValue);

        }

        private void btnNextSearch_Click(object sender, EventArgs e)
        {
            counter++;
            txtBoxSearch.Text = APIcalls.Search(counter, inputValue);
        }

        private void btnPreviousSearch_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
            }
            txtBoxSearch.Text = APIcalls.Search(counter, inputValue);
        }
    }
}
