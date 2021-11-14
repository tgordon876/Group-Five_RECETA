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
            pnlBFSubMenu.Size = new Size(200, 170); 
            btn1BF.Size = new Size(200, 40);
            btn2BF.Size = new Size(200, 40);
            btn3BF.Size = new Size(200, 40);
            btn4BF.Size = new Size(200, 40);
            btnLunch.Size = new Size(200, 40);
            pnlLSubMenu.Size = new Size(200, 170);
            btn5L.Size = new Size(200, 40);
            btn6L.Size = new Size(200, 40);
            btn7L.Size = new Size(200, 40);
            btn8L.Size = new Size(200, 40);
            btnDinner.Size = new Size(200, 40);
            pnlDSubMenu.Size = new Size(200, 170);
            btn9D.Size = new Size(200, 40);
            btn10D.Size = new Size(200, 40);
            btn11D.Size = new Size(200, 40);
            btn12D.Size = new Size(200, 40);
            btnDesert.Size = new Size(200,40);
            btnHelp.Size = new Size(200, 40);

            pnlBFSubMenu.Visible = false;
            pnlLSubMenu.Visible = false;
            pnlDSubMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (pnlBFSubMenu.Visible == true)
                pnlBFSubMenu.Visible = false;
            if (pnlLSubMenu.Visible == true)
                pnlLSubMenu.Visible = false;
            if (pnlDSubMenu.Visible == true)
                pnlDSubMenu.Visible = false;
        }
         private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Breakfast
        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBFSubMenu);
        }

        private void btn1BF_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn2BF_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn3BF_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn4BF_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }
        #endregion
        #region Lunch
        private void btnLunch_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlLSubMenu);
        }

        private void btn5L_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }
        private void btn6L_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn7L_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn8L_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }
        #endregion
        #region Dinner
        private void btnDinner_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDSubMenu);
        }

        private void btn9D_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn10D_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn11D_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }

        private void btn12D_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hideSubMenu();
        }
        #endregion
    }
}
