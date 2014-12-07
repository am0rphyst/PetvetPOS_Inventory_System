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
        private MyUserControl currentContent;
        private UserSettingsControl userSettingsControl;


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

        public MasterController(Form mainForm, Panel mainPanel)
        {
            this.mainForm = mainForm;
            this.mainPanel = mainPanel;
        }

        public Titlebar setTitleBar 
        {
            set
            {
                titleBar = value;
            }
        }

        public MenuBar setMenuBar 
        {
            set
            {
                menuBar = value;
            }
        }

        public UserSettingsControl setUserSettingsControl
        {
            set
            {
                userSettingsControl = value;
            }
        }

        public MyUserControl accessCurrentContent
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

        public void changeCurrentContent(MyUserControl content)
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

        public void initMenuBar(bool isAdmin)
        {
            MenuList list;

            if (isAdmin)
            {
                list = new AdminMenuList(this);
              
            }
            else
            {
                list = new UserMenuList(this);
            }

            menuBar.accessMenuControl = list.getList;
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
            titleBar.setImage = Properties.Resources.iconmonstr_home_6_icon_256;
        }

        public void updateTitle(string titlename, Image icon)
        {
            titleBar.setTitle = titlename;
            titleBar.setImage = icon;
        }

        public void logout()
        {
            userSettingsControl.returnHome();
            clearMenuBar();
            clearTitleHeader();
        }

        public void showUserSettingsControl(string name)
        {
            userSettingsControl.appearWithName(name);
        }
    }
}
