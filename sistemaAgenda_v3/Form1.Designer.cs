namespace sistemaAgenda_v3
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.DataGrid = new MetroFramework.Controls.MetroGrid();
			this.MetroPanel = new MetroFramework.Controls.MetroPanel();
			this.btnSair = new MetroFramework.Controls.MetroButton();
			this.btnConsultar = new MetroFramework.Controls.MetroButton();
			this.btnRecarregar = new MetroFramework.Controls.MetroButton();
			this.btnSalvar = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
			this.MetroPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGrid
			// 
			this.DataGrid.AllowUserToResizeRows = false;
			this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.DataGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataGrid.EnableHeadersVisualStyles = false;
			this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.DataGrid.Location = new System.Drawing.Point(20, 60);
			this.DataGrid.Name = "DataGrid";
			this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGrid.Size = new System.Drawing.Size(860, 321);
			this.DataGrid.TabIndex = 0;
			// 
			// MetroPanel
			// 
			this.MetroPanel.Controls.Add(this.btnSair);
			this.MetroPanel.Controls.Add(this.btnConsultar);
			this.MetroPanel.Controls.Add(this.btnRecarregar);
			this.MetroPanel.Controls.Add(this.btnSalvar);
			this.MetroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MetroPanel.HorizontalScrollbarBarColor = true;
			this.MetroPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.MetroPanel.HorizontalScrollbarSize = 10;
			this.MetroPanel.Location = new System.Drawing.Point(20, 437);
			this.MetroPanel.Name = "MetroPanel";
			this.MetroPanel.Size = new System.Drawing.Size(860, 43);
			this.MetroPanel.TabIndex = 1;
			this.MetroPanel.VerticalScrollbarBarColor = true;
			this.MetroPanel.VerticalScrollbarHighlightOnWheel = false;
			this.MetroPanel.VerticalScrollbarSize = 10;
			// 
			// btnSair
			// 
			this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSair.Location = new System.Drawing.Point(560, 0);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 43);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseSelectable = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnConsultar.Location = new System.Drawing.Point(635, 0);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 43);
			this.btnConsultar.TabIndex = 4;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseSelectable = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnRecarregar
			// 
			this.btnRecarregar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRecarregar.Location = new System.Drawing.Point(710, 0);
			this.btnRecarregar.Name = "btnRecarregar";
			this.btnRecarregar.Size = new System.Drawing.Size(75, 43);
			this.btnRecarregar.TabIndex = 3;
			this.btnRecarregar.Text = "Recarregar";
			this.btnRecarregar.UseSelectable = true;
			this.btnRecarregar.Click += new System.EventHandler(this.loadRecords);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSalvar.Location = new System.Drawing.Point(785, 0);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 43);
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseSelectable = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.MetroPanel);
			this.Controls.Add(this.DataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Text = "Agenda";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.Load += new System.EventHandler(this.loadRecords);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
			this.MetroPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid DataGrid;
		private MetroFramework.Controls.MetroPanel MetroPanel;
		private MetroFramework.Controls.MetroButton btnRecarregar;
		private MetroFramework.Controls.MetroButton btnSalvar;
		private MetroFramework.Controls.MetroButton btnSair;
		private MetroFramework.Controls.MetroButton btnConsultar;
	}
}

