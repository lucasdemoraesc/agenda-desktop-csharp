namespace sistemaAgenda_v3
{
	partial class FormConsulta
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
			this.radioButtonNome = new System.Windows.Forms.RadioButton();
			this.radioButtonTelefone = new System.Windows.Forms.RadioButton();
			this.TextBoxDigit = new MetroFramework.Controls.MetroTextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButtonCodigo
			// 
			this.radioButtonCodigo.AutoSize = true;
			this.radioButtonCodigo.ForeColor = System.Drawing.Color.DimGray;
			this.radioButtonCodigo.Location = new System.Drawing.Point(3, 3);
			this.radioButtonCodigo.Name = "radioButtonCodigo";
			this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
			this.radioButtonCodigo.TabIndex = 1;
			this.radioButtonCodigo.Text = "Código";
			this.radioButtonCodigo.UseVisualStyleBackColor = true;
			this.radioButtonCodigo.Click += new System.EventHandler(this.radioBtn_Click);
			// 
			// radioButtonNome
			// 
			this.radioButtonNome.AutoSize = true;
			this.radioButtonNome.Checked = true;
			this.radioButtonNome.ForeColor = System.Drawing.Color.DimGray;
			this.radioButtonNome.Location = new System.Drawing.Point(67, 3);
			this.radioButtonNome.Name = "radioButtonNome";
			this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
			this.radioButtonNome.TabIndex = 2;
			this.radioButtonNome.TabStop = true;
			this.radioButtonNome.Text = "Nome";
			this.radioButtonNome.UseVisualStyleBackColor = true;
			this.radioButtonNome.Click += new System.EventHandler(this.radioBtn_Click);
			// 
			// radioButtonTelefone
			// 
			this.radioButtonTelefone.AutoSize = true;
			this.radioButtonTelefone.ForeColor = System.Drawing.Color.DimGray;
			this.radioButtonTelefone.Location = new System.Drawing.Point(126, 3);
			this.radioButtonTelefone.Name = "radioButtonTelefone";
			this.radioButtonTelefone.Size = new System.Drawing.Size(67, 17);
			this.radioButtonTelefone.TabIndex = 3;
			this.radioButtonTelefone.Text = "Telefone";
			this.radioButtonTelefone.UseVisualStyleBackColor = true;
			this.radioButtonTelefone.Click += new System.EventHandler(this.radioBtn_Click);
			// 
			// TextBoxDigit
			// 
			// 
			// 
			// 
			this.TextBoxDigit.CustomButton.Image = null;
			this.TextBoxDigit.CustomButton.Location = new System.Drawing.Point(168, 1);
			this.TextBoxDigit.CustomButton.Name = "";
			this.TextBoxDigit.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TextBoxDigit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TextBoxDigit.CustomButton.TabIndex = 1;
			this.TextBoxDigit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TextBoxDigit.CustomButton.UseSelectable = true;
			this.TextBoxDigit.CustomButton.Visible = false;
			this.TextBoxDigit.Lines = new string[0];
			this.TextBoxDigit.Location = new System.Drawing.Point(3, 26);
			this.TextBoxDigit.MaxLength = 32767;
			this.TextBoxDigit.Name = "TextBoxDigit";
			this.TextBoxDigit.PasswordChar = '\0';
			this.TextBoxDigit.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextBoxDigit.SelectedText = "";
			this.TextBoxDigit.SelectionLength = 0;
			this.TextBoxDigit.SelectionStart = 0;
			this.TextBoxDigit.ShortcutsEnabled = true;
			this.TextBoxDigit.Size = new System.Drawing.Size(190, 23);
			this.TextBoxDigit.TabIndex = 0;
			this.TextBoxDigit.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TextBoxDigit.UseSelectable = true;
			this.TextBoxDigit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TextBoxDigit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TextBoxDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Enter);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.radioButtonCodigo);
			this.flowLayoutPanel1.Controls.Add(this.radioButtonNome);
			this.flowLayoutPanel1.Controls.Add(this.radioButtonTelefone);
			this.flowLayoutPanel1.Controls.Add(this.TextBoxDigit);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 60);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// FormConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 140);
			this.Controls.Add(this.flowLayoutPanel1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(235, 140);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(235, 140);
			this.Name = "FormConsulta";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buscar contato";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsulta_Close);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton radioButtonCodigo;
		private System.Windows.Forms.RadioButton radioButtonNome;
		private System.Windows.Forms.RadioButton radioButtonTelefone;
		private MetroFramework.Controls.MetroTextBox TextBoxDigit;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}