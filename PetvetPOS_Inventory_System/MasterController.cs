using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public class MasterController
    {
        Panel panel;
        MenuBar menuBar;
        Titlebar titleBar;
        UserControl currentContent;
        Form form;

        public MasterController(Panel panel, MenuBar menuBar, Titlebar titleBar, Form form)
        {
            this.panel = panel;
            this.menuBar = menuBar;
            this.menuBar.accessMasterController = this;
            this.titleBar = titleBar;
            this.titleBar.accessMasterController = this;
            this.form = form;
            currentContent = null;
        }

        public UserControl accessCurrentContent
        {
            get
            {
                return currentContent;
            }
            set
            {
                currentContent = value;
            }
        }

        public void changeCurrentContent(UserControl content)
        {
            // 
            this.panel.Controls.Remove(currentContent);
            this.currentContent = content;
            this.currentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentContent.Location = new System.Drawing.Point(0, 0);
            this.panel.Controls.Add(this.currentContent);
            
        }
    }
}
