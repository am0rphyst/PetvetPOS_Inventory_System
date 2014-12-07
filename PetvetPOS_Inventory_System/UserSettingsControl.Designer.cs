namespace PetvetPOS_Inventory_System
{
    partial class UserSettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.partA = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.logoutContextMenuStrips = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logoutContextMenuStrips.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.partA});
            this.shapeContainer1.Size = new System.Drawing.Size(186, 33);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // partA
            // 
            this.partA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.partA.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.partA.BorderColor = System.Drawing.Color.White;
            this.partA.ContextMenuStrip = this.logoutContextMenuStrips;
            this.partA.CornerRadius = 3;
            this.partA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.partA.Location = new System.Drawing.Point(-7, -6);
            this.partA.Name = "partA";
            this.partA.Size = new System.Drawing.Size(196, 44);
            // 
            // logoutContextMenuStrips
            // 
            this.logoutContextMenuStrips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.sETTINGSToolStripMenuItem});
            this.logoutContextMenuStrips.Name = "logoutContextMenuStrips";
            this.logoutContextMenuStrips.Size = new System.Drawing.Size(174, 48);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            // 
            // loginName
            // 
            this.loginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.loginName.ContextMenuStrip = this.logoutContextMenuStrips;
            this.loginName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginName.ForeColor = System.Drawing.Color.White;
            this.loginName.Location = new System.Drawing.Point(0, 0);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(186, 33);
            this.loginName.TabIndex = 1;
            this.loginName.Text = "Log In Name";
            this.loginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.loginName, "Right click to logout or change the settings of the \r\ncurrent user.");
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // UserSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginName);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UserSettingsControl";
            this.Size = new System.Drawing.Size(186, 33);
            this.Load += new System.EventHandler(this.UserSettingsControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserSettingsControl_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserSettingsControl_KeyPress);
            this.logoutContextMenuStrips.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape partA;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.ContextMenuStrip logoutContextMenuStrips;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
    }
}
