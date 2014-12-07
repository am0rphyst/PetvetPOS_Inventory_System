using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace PetvetPOS_Inventory_System
{
    public partial class MenuControl : UserControl
    {
        private Label menuName;
        private OvalShape iconShape;
        private Color origColor;

        private MenuBar menuBar;
        private bool isSelected;
        private UserControl mapControl;
        private MasterController masterController;

        public MenuControl()
        {
            InitializeComponent();
            iconShape = icon;
            menuName = lblDesc;
            origColor = icon.BackColor;
        }


        public MenuControl(Image image, string menuString)
        {
            InitializeComponent();
            iconShape = icon;
            menuName = lblDesc;
            setIconImage = image;
            menuName.Text = menuString;
            origColor = icon.BackColor;
        }

        public UserControl accessMapPanel
        {
            get
            {
                return mapControl;
            }
            set
            {
                mapControl = value;
            }
        }

        public MenuBar accessMenuBar
        {
            set
            {
                menuBar = value;
            }
                
        }

        public Image setIconImage 
        {   
            set
            {
                iconShape.BackgroundImage = value;
            }
        }

        public Image getIconImage
        {
            get
            {
                return icon.BackgroundImage;
            }
            
        }

        public string accessIconLabel
        {
            set
            {
                menuName.Text = value;
            }
            get
            {
                return menuName.Text;
            }
        }

        public void select()
        {
            isSelected = true;
        }

        private void icon_Click(object sender, EventArgs e)
        {
            // Unselect all menus before selecting new
            menuBar.unselectAll();
            this.select();

            masterController.updateTitle(menuName.Text, icon.BackgroundImage);
            menuBar.updateMenus();
            masterController.changeCurrentContent(mapControl);
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        public void redraw()
        {
            if (isSelected)
            {
                icon.BackColor = Color.White;
                icon.BorderColor = Color.Gold;
            }
            else
            {
                icon.BackColor = origColor;
                icon.BorderColor = Color.White;
            }
        }

        private void icon_MouseEnter(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        private void icon_MouseLeave(object sender, EventArgs e)
        {
            icon.BorderColor = Color.White;
        }

        public void unselect()
        {
            isSelected = false;
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {

        }

        public MasterController accessMasterController 
        {
            get
            {
                return masterController;
            }
            set
            {
                this.masterController = value;
            }
        }
    }
}
