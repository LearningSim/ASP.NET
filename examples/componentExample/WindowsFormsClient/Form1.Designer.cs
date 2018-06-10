namespace WindowsFormsClient {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.countryList = new System.Windows.Forms.ComboBox();
			this.fillBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// countryList
			// 
			this.countryList.FormattingEnabled = true;
			this.countryList.Location = new System.Drawing.Point(13, 13);
			this.countryList.Name = "countryList";
			this.countryList.Size = new System.Drawing.Size(121, 21);
			this.countryList.TabIndex = 0;
			// 
			// fillBtn
			// 
			this.fillBtn.Location = new System.Drawing.Point(150, 13);
			this.fillBtn.Name = "fillBtn";
			this.fillBtn.Size = new System.Drawing.Size(75, 23);
			this.fillBtn.TabIndex = 1;
			this.fillBtn.Text = "Fill country list";
			this.fillBtn.UseVisualStyleBackColor = true;
			this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 262);
			this.Controls.Add(this.fillBtn);
			this.Controls.Add(this.countryList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox countryList;
		private System.Windows.Forms.Button fillBtn;
	}
}

