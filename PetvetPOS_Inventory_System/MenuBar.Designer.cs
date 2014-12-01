namespace PetvetPOS_Inventory_System
{
    partial class MenuBar
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
            this.menuControl1 = new PetvetPOS_Inventory_System.MenuControl();
            this.menuControl2 = new PetvetPOS_Inventory_System.MenuControl();
            this.menuControl3 = new PetvetPOS_Inventory_System.MenuControl();
            this.SuspendLayout();
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(5, 15);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(92, 113);
            this.menuControl1.TabIndex = 0;
            this.menuControl1.Load += new System.EventHandler(this.menuControl1_Load);
            this.menuControl1.Click += new System.EventHandler(this.menuControl1_Click);
            // 
            // menuControl2
            // 
            this.menuControl2.Location = new System.Drawing.Point(6, 146);
            this.menuControl2.Name = "menuControl2";
            this.menuControl2.Size = new System.Drawing.Size(92, 116);
            this.menuControl2.TabIndex = 1;
            this.menuControl2.Load += new System.EventHandler(this.menuControl2_Load);
            this.menuControl2.Click += new System.EventHandler(this.menuControl2_Click);
            // 
            // menuControl3
            // 
            this.menuControl3.Location = new System.Drawing.Point(6, 280);
            this.menuControl3.Name = "menuControl3";
            this.menuControl3.Size = new System.Drawing.Size(92, 128);
            this.menuControl3.TabIndex = 2;
            this.menuControl3.Click += new System.EventHandler(this.menuControl3_Click);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuControl3);
            this.Controls.Add(this.menuControl2);
            this.Controls.Add(this.menuControl1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(105, 431);
            this.Load += new System.EventHandler(this.MenuBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControl menuControl1;
        private MenuControl menuControl2;
        private MenuControl menuControl3;
    }
}
