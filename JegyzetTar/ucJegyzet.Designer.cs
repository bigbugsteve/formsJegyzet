namespace JegyzetTar
{
	partial class ucJegyzet
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
            this.cbJegyzet = new System.Windows.Forms.ComboBox();
            this.tbCím = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btMent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbJegyzet
            // 
            this.cbJegyzet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJegyzet.FormattingEnabled = true;
            this.cbJegyzet.Location = new System.Drawing.Point(27, 26);
            this.cbJegyzet.Name = "cbJegyzet";
            this.cbJegyzet.Size = new System.Drawing.Size(287, 23);
            this.cbJegyzet.TabIndex = 0;
            // 
            // tbCím
            // 
            this.tbCím.Location = new System.Drawing.Point(27, 70);
            this.tbCím.Name = "tbCím";
            this.tbCím.Size = new System.Drawing.Size(287, 23);
            this.tbCím.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(27, 109);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(287, 23);
            this.tbUrl.TabIndex = 2;
            // 
            // btMent
            // 
            this.btMent.Location = new System.Drawing.Point(27, 154);
            this.btMent.Name = "btMent";
            this.btMent.Size = new System.Drawing.Size(75, 23);
            this.btMent.TabIndex = 3;
            this.btMent.Text = "Ment";
            this.btMent.UseVisualStyleBackColor = true;
            this.btMent.Click += new System.EventHandler(this.btMent_Click);
            // 
            // ucJegyzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btMent);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbCím);
            this.Controls.Add(this.cbJegyzet);
            this.Name = "ucJegyzet";
            this.Size = new System.Drawing.Size(417, 281);
            this.VisibleChanged += new System.EventHandler(this.ucJegyzet_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ComboBox cbJegyzet;
		private TextBox tbCím;
		private TextBox tbUrl;
		private Button btMent;
	}
}
