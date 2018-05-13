using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Affich_ID_FRS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtSearch")]
		private TextBox _txtSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvF")]
		private DataGridView _dgvF;

		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return _Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button1_Click;
				Button button = _Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button1 = value;
				button = _Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return _TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox1_TextChanged;
				KeyEventHandler value3 = textbox1_KeyDown;
				TextBox textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
					textBox.KeyDown -= value3;
				}
				_TextBox1 = value;
				textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
					textBox.KeyDown += value3;
				}
			}
		}

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtSearch
		{
			[CompilerGenerated]
			get
			{
				return _txtSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtSearch_TextChanged;
				KeyEventHandler value3 = txtSearch_KeyDown;
				TextBox txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.TextChanged -= value2;
					txtSearch.KeyDown -= value3;
				}
				_txtSearch = value;
				txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.TextChanged += value2;
					txtSearch.KeyDown += value3;
				}
			}
		}

		internal virtual DataGridView dgvF
		{
			[CompilerGenerated]
			get
			{
				return _dgvF;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgv1_CellContentDoubleClick;
				KeyEventHandler value3 = dgvF_KeyDown;
				DataGridView dgvF = _dgvF;
				if (dgvF != null)
				{
					dgvF.CellContentDoubleClick -= value2;
					dgvF.KeyDown -= value3;
				}
				_dgvF = value;
				dgvF = _dgvF;
				if (dgvF != null)
				{
					dgvF.CellContentDoubleClick += value2;
					dgvF.KeyDown += value3;
				}
			}
		}

		public Affich_ID_FRS()
		{
			base.KeyDown += Affich_ID_FRS_KeyDown;
			base.Load += Affich_ID_FRS_Load;
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			Button1 = new Button();
			TextBox1 = new TextBox();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			txtSearch = new TextBox();
			dgvF = new DataGridView();
			((ISupportInitialize)dgvF).BeginInit();
			base.SuspendLayout();
			Button1.BackColor = SystemColors.MenuHighlight;
			Button1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.Location = new Point(238, 627);
			Button1.Name = "Button1";
			Button1.Size = new Size(86, 38);
			Button1.TabIndex = 34;
			Button1.Text = "OK";
			Button1.UseVisualStyleBackColor = false;
			TextBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox1.Location = new Point(356, 55);
			TextBox1.Margin = new Padding(4, 5, 4, 5);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(159, 26);
			TextBox1.TabIndex = 2;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label3.Location = new Point(179, 20);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(47, 18);
			Label3.TabIndex = 32;
			Label3.Text = "Code";
			Label2.AutoSize = true;
			Label2.BackColor = SystemColors.ButtonHighlight;
			Label2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label2.ForeColor = SystemColors.ActiveCaptionText;
			Label2.Location = new Point(415, 20);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(47, 18);
			Label2.TabIndex = 31;
			Label2.Text = "Label";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label1.Location = new Point(27, 20);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(118, 18);
			Label1.TabIndex = 30;
			Label1.Text = "Recherche par: ";
			txtSearch.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSearch.Location = new Point(133, 55);
			txtSearch.Margin = new Padding(4, 5, 4, 5);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(152, 26);
			txtSearch.TabIndex = 1;
			dgvF.AllowUserToAddRows = false;
			dgvF.AllowUserToDeleteRows = false;
			dgvF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvF.BackgroundColor = Color.White;
			dgvF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvF.Location = new Point(30, 100);
			dgvF.Margin = new Padding(4, 5, 4, 5);
			dgvF.Name = "dgvF";
			dgvF.ReadOnly = true;
			dgvF.Size = new Size(535, 504);
			dgvF.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(625, 677);
			base.Controls.Add(Button1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(txtSearch);
			base.Controls.Add(dgvF);
			Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Affich_ID_FRS";
			Text = "Affich code Fournisseur";
			((ISupportInitialize)dgvF).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string selectCommandText = "select IDFRS, NOMFRS FROM FOURN WHERE IDFRS LIKE '" + txtSearch.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("FOURN");
				mySqlDataAdapter.Fill(dataTable);
				dgvF.DataSource = dataTable;
				Globals.clorerDGV(dgvF);
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string selectCommandText = "select IDFRS, NOMFRS FROM FOURN WHERE NOMFRS LIKE '" + TextBox1.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("FOURN");
				mySqlDataAdapter.Fill(dataTable);
				dgvF.DataSource = dataTable;
				Globals.clorerDGV(dgvF);
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(Globals.flag_COD, "AES", false) == 0)
			{
				MyProject.Forms.Ajout_entree_Stock.fournisseur.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
			}
			else if (Operators.CompareString(Globals.flag_COD, "GF", false) == 0)
			{
				MyProject.Forms.Gestion_Fourn.IDFRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Fourn.NOMFRS.Text = dgvF.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Fourn.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "GAF", false) == 0)
			{
				MyProject.Forms.Gestion_Article_Com.FRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Article_Com.NOMFRS.Text = dgvF.CurrentRow.Cells[1].Value.ToString();
			}
			else
			{
				//Globals.Ajout_Fact4.FRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact5.FRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact6.FRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact7.FRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Histo_Fourn.IDFRS.Text = dgvF.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Histo_Fourn.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Globals.flag_COD = "";
			base.Close();
		}

		private void dgvF_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				Button1_Click(1, e);
				e.Handled = true;
			}
		}

		private void textbox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				SendKeys.Send("{Tab}");
				e.Handled = true;
			}
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				SendKeys.Send("{Tab}");
				e.Handled = true;
			}
		}

		private void Affich_ID_FRS_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Affich_ID_FRS_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
					workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
					string query = "select distinct IDFRS,NOMFRS from FOURN ";
					this.dgvF.DataSource = null;
					this.dgvF.Rows.Clear();
					Globals.LoadData(query, this.dgvF, "FOURN");
					DataGridView dgvF = this.dgvF;
					dgvF.Columns[0].HeaderCell.Value = "Id. Fournisseur";
					dgvF.Columns[1].HeaderCell.Value = "Nom Frs";
					dgvF.Columns[0].Width = 140;
					dgvF.Columns[1].Width = 240;
					dgvF = null;
					int num = this.dgvF.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (unchecked(i % 2) == 1)
						{
							this.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
						}
						else
						{
							this.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.White;
						}
					}
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show(ex2.Message.ToString());
					ProjectData.ClearProjectError();
				}
				finally
				{
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
				}
			}
		}
	}
}
