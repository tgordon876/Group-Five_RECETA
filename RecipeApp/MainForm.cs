using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomDesign();
        }
        private void CustomDesign()
        {
            //Form.Size = new Size(1100, 600);
            pnlSideMenu.Size = new Size(250,1100);
            btnBreakfast.Size = new Size(200, 40);
            btn1BF.Size = new Size(200, 40);
            btn2BF.Size = new Size(200, 40);
            btn3BF.Size = new Size(200, 40);
            btn4BF.Size = new Size(200, 40);
            btnLunch.Size = new Size(200, 40);
            btn5L.Size = new Size(200, 40);
            btn6L.Size = new Size(200, 40);
            btn7L.Size = new Size(200, 40);
            btn8L.Size = new Size(200, 40);
            btnDinner.Size = new Size(200, 40);
            btn9D.Size = new Size(200, 40);
            btn10D.Size = new Size(200, 40);
            btn11D.Size = new Size(200, 40);
            btn12D.Size = new Size(200, 40);
            btnDesert.Size = new Size(200,40);
            btnHelp.Size = new Size(200, 40);
        }

        private void btn4BF_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn6L_Click(object sender, EventArgs e)
        {

        }
    }
}
