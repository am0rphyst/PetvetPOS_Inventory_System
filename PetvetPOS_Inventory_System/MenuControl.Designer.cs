namespace PetvetPOS_Inventory_System
{
    partial class MenuControl
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.icon = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.icon});
            this.shapeContainer1.Size = new System.Drawing.Size(92, 128);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.icon.BorderColor = System.Drawing.Color.White;
            this.icon.BorderWidth = 2;
            this.icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon.Location = new System.Drawing.Point(11, 7);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(68, 65);
            this.icon.Click += new System.EventHandler(this.icon_Click);
            this.icon.MouseEnter += new System.EventHandler(this.icon_MouseEnter);
            this.icon.MouseHover += new System.EventHandler(this.icon_MouseHover);
            this.icon.MouseLeave += new System.EventHandler(this.icon_MouseLeave);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 76);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(92, 39);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Menu Name";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(92, 128);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape icon;
        private System.Windows.Forms.Label lblDesc;
    }
}
