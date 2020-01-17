using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace sistemaAgenda_v3
{
	public partial class Form1 : MetroForm
	{
		SQLiteConnection db = new SQLiteConnection("Data Source=database.db;Version=3;New = True");
		private SQLiteDataAdapter sda;
		private DataTable dt;

		public Form1()
		{
			InitializeComponent();
		}

		private void loadRecords(object sender, EventArgs e)
		{
			try
			{
				sda = new SQLiteDataAdapter("SELECT * FROM Agenda", db);
				dt = new DataTable("Contatos");
				sda.Fill(dt);
				DataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				using (SQLiteCommandBuilder cbd = new SQLiteCommandBuilder(sda))
				{
					if (sda.Update(dt) != 0)
						MessageBox.Show(this, "Alterações salvas com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show(this, "No momento não há alterações para salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			FormConsulta janelaConsultar = new FormConsulta(sda, dt, dt.DefaultView);
			janelaConsultar.ShowInTaskbar = false;
			janelaConsultar.ShowDialog();
		}
	}
}
