﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class Reports : MyUserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        public Reports(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }
    }
}
