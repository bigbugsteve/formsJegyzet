namespace JegyzetTar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsJegyzetTar = new JegyzetTar.dsJegyzetTar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBöngészés = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJegyzetek = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKilépés = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucJegyzet = new JegyzetTar.ucJegyzet();
            ((System.ComponentModel.ISupportInitialize)(this.dsJegyzetTar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dsJegyzetTar
            // 
            this.dsJegyzetTar.DataSetName = "dsJegyzetTar";
            this.dsJegyzetTar.Namespace = "http://tempuri.org/dsJegyzetTar.xsd";
            this.dsJegyzetTar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBöngészés,
            this.tsmiJegyzetek,
            this.mentésToolStripMenuItem,
            this.tsmiKilépés});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBöngészés
            // 
            this.tsmiBöngészés.Name = "tsmiBöngészés";
            this.tsmiBöngészés.Size = new System.Drawing.Size(74, 20);
            this.tsmiBöngészés.Text = "Böngészés";
            this.tsmiBöngészés.Click += new System.EventHandler(this.tsmiBöngészés_Click);
            // 
            // tsmiJegyzetek
            // 
            this.tsmiJegyzetek.Name = "tsmiJegyzetek";
            this.tsmiJegyzetek.Size = new System.Drawing.Size(69, 20);
            this.tsmiJegyzetek.Text = "Jegyzetek";
            this.tsmiJegyzetek.Click += new System.EventHandler(this.tsmiJegyzetek_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // tsmiKilépés
            // 
            this.tsmiKilépés.Name = "tsmiKilépés";
            this.tsmiKilépés.Size = new System.Drawing.Size(56, 20);
            this.tsmiKilépés.Text = "Kilépés";
            this.tsmiKilépés.Click += new System.EventHandler(this.tsmiKilépés_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(109, 116);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // ucJegyzet
            // 
            this.ucJegyzet.dsJegyzetTar = null;
            this.ucJegyzet.Location = new System.Drawing.Point(454, 187);
            this.ucJegyzet.Name = "ucJegyzet";
            this.ucJegyzet.Size = new System.Drawing.Size(417, 281);
            this.ucJegyzet.TabIndex = 2;
            this.ucJegyzet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucJegyzet);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jegyzet tár";
            ((System.ComponentModel.ISupportInitialize)(this.dsJegyzetTar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsJegyzetTar dsJegyzetTar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiBöngészés;
        private ToolStripMenuItem tsmiKilépés;
        private DataGridView dgv;
        private ToolStripMenuItem tsmiJegyzetek;
		private ucJegyzet ucJegyzet;
		private ToolStripMenuItem mentésToolStripMenuItem;
    }
}