using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace sistemaAgenda_v3
{
	public partial class FormConsulta : MetroForm
	{
		private SQLiteDataAdapter sda;
		DataTable dt;
		DataView dv;

		public FormConsulta()
		{
			InitializeComponent();
		}

		public FormConsulta(SQLiteDataAdapter sda, DataTable dt, DataView dv)
		{
			InitializeComponent();
			this.sda = sda;
			this.dt = dt;
			this.dv = dt.DefaultView;
		}

		private void FormConsulta_Close(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}

		private void KeyPress_Enter(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				if (radioButtonCodigo.Checked)
				{
					try
					{
						dv.RowFilter = string.Format("Codigo = "+Convert.ToInt32(TextBoxDigit.Text));
						dt.Clear();
						sda.Fill(dt);
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						this.Close();
					}
				}
				else if (radioButtonNome.Checked)
				{
					try
					{
						dv.RowFilter = string.Format("Nome LIKE '%{0}%'", TextBoxDigit.Text);
						dt.Clear();
						sda.Fill(dt);
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						this.Close();
					}
				}
				else if (radioButtonTelefone.Checked)
				{
					try
					{
						dv.RowFilter = string.Format("Telefone = '"+TextBoxDigit.Text+"'");
						dt.Clear();
						sda.Fill(dt);
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						this.Close();
					}
				}
			}
		}

		private void radioBtn_Click(object sender, EventArgs e)
		{
			TextBoxDigit.Focus();
			TextBoxDigit.SelectAll();
		}
	}
}