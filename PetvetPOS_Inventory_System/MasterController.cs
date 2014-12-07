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
        private Form mainForm;
        private Panel mainPanel;
        private MenuBar menuBar;
        private Titlebar titleBar;
        private UserControl currentContent;


        public MasterController(Panel mainPanel, MenuBar menuBar, Titlebar titleBar, Form mainForm)
        {
            this.mainPanel = mainPanel;
            this.menuBar = menuBar;
            this.menuBar.accessMasterController = this;
            this.titleBar = titleBar;
            this.titleBar.accessMasterController = this;
            this.mainForm = mainForm;
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
            if (currentContent != null)
            {
                mainPanel.Controls.Remove(currentContent);
            }

            currentContent = content;
            currentContent.Dock = DockStyle.Fill;
            currentContent.Location = new Point(0, 0);
            mainPanel.Controls.Add(currentContent);
        }

        public void setMenuBar()
        {
            menuBar.initControlLocation();
        }

        public void defaultSelectedMenu(int index)
        {
            menuBar.selectControlbyIndex(index);
        }

        // overload method
        public void defaultSelectedMenu(string name)
        {
            menuBar.selectControlbyName(name);
        }

        public void clearMenuBar()
        {
            menuBar.removeMenuControls();
        }

        public Button setFormReturnkey
        {
            set
            {
                mainForm.AcceptButton = value;
            }
        }

        public void closeForm()
        {
            mainForm.Close();
        }

        public void clearTitleHeader()
        {
            titleBar.setTitle = "HOME";
            titleBar.setImage = null;
        }

        public void updateTitle(string titlename, Image icon)
        {
            titleBar.setTitle = titlename;
            titleBar.setImage = icon;
        }
    }
}
