using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            menuBar1.controlTitleBar(titlebar1);
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString() + " " + DateTime.Today.DayOfWeek.ToString();
        }

        private void titlebar1_Load(object sender, EventArgs e)
        {

        }
    }
}
