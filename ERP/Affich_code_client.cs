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
	public class Affich_code_client : Form
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
		[AccessedThroughProperty("dgvC")]
		private DataGridView _dgvC;

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

		internal virtual DataGridView dgvC
		{
			[CompilerGenerated]
			get
			{
				return _dgvC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgv1_CellContentDoubleClick;
				KeyEventHandler value3 = dgvC_KeyDown;
				DataGridView dgvC = _dgvC;
				if (dgvC != null)
				{
					dgvC.CellContentDoubleClick -= value2;
					dgvC.KeyDown -= value3;
				}
				_dgvC = value;
				dgvC = _dgvC;
				if (dgvC != null)
				{
					dgvC.CellContentDoubleClick += value2;
					dgvC.KeyDown += value3;
				}
			}
		}

		public Affich_code_client()
		{
			base.KeyDown += Affich_code_client_KeyDown;
			base.Load += Affich_code_client_Load;
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
			dgvC = new DataGridView();
			((ISupportInitialize)dgvC).BeginInit();
			base.SuspendLayout();
			Button1.BackColor = SystemColors.MenuHighlight;
			Button1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.Location = new Point(256, 553);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(100, 47);
			Button1.TabIndex = 34;
			Button1.Text = "OK";
			Button1.UseVisualStyleBackColor = false;
			TextBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox1.Location = new Point(386, 54);
			TextBox1.Margin = new Padding(5, 6, 5, 6);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(185, 26);
			TextBox1.TabIndex = 2;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label3.Location = new Point(181, 30);
			Label3.Margin = new Padding(5, 0, 5, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(47, 18);
			Label3.TabIndex = 32;
			Label3.Text = "Code";
			Label2.AutoSize = true;
			Label2.BackColor = SystemColors.ButtonHighlight;
			Label2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label2.Location = new Point(456, 30);
			Label2.Margin = new Padding(5, 0, 5, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(47, 18);
			Label2.TabIndex = 31;
			Label2.Text = "Label";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label1.Location = new Point(3, 30);
			Label1.Margin = new Padding(5, 0, 5, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(118, 18);
			Label1.TabIndex = 30;
			Label1.Text = "Recherche par: ";
			txtSearch.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSearch.Location = new Point(122, 54);
			txtSearch.Margin = new Padding(5, 6, 5, 6);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(177, 26);
			txtSearch.TabIndex = 1;
			dgvC.AllowUserToAddRows = false;
			dgvC.AllowUserToDeleteRows = false;
			dgvC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvC.BackgroundColor = Color.White;
			dgvC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvC.Location = new Point(14, 106);
			dgvC.Margin = new Padding(5, 6, 5, 6);
			dgvC.Name = "dgvC";
			dgvC.ReadOnly = true;
			dgvC.Size = new Size(624, 421);
			dgvC.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(659, 601);
			base.Controls.Add(Button1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(txtSearch);
			base.Controls.Add(dgvC);
			Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(206, 0);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Affich_code_client";
			Text = "Affich code client";
			((ISupportInitialize)dgvC).EndInit();
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
				string selectCommandText = "select IDCLIENT, NOM, MAIL FROM CLIENT WHERE IDCLIENT LIKE '" + txtSearch.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("CLIENT");
				mySqlDataAdapter.Fill(dataTable);
				dgvC.DataSource = dataTable;
				Globals.clorerDGV(dgvC);
				affichdgv(dgvC);
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

		private void affichdgv(DataGridView Dgv)
		{
			try
			{
				Dgv.Columns[0].HeaderCell.Value = "Id. Client";
				Dgv.Columns[1].HeaderCell.Value = "Nom";
				Dgv.Columns[0].Width = 140;
				Dgv.Columns[1].Width = 240;
				Dgv.Columns[2].Visible = false;
				DataGridView dataGridView = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
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
				string selectCommandText = "select IDCLIENT, NOM, MAIL FROM CLIENT WHERE NOM LIKE '" + TextBox1.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("CLIENT");
				mySqlDataAdapter.Fill(dataTable);
				dgvC.DataSource = dataTable;
				Globals.clorerDGV(dgvC);
				affichdgv(dgvC);
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
			if (Operators.CompareString(Globals.flag_COD_client, "Mail_A", false) == 0)
			{
				MyProject.Forms.Mail.destinataire.Text = MyProject.Forms.Mail.destinataire.Text + dgvC.CurrentRow.Cells[2].Value.ToString() + ";";
			}
			else if (Operators.CompareString(Globals.flag_COD_client, "Mail_CC", false) == 0)
			{
				MyProject.Forms.Mail.cc_destin.Text = MyProject.Forms.Mail.cc_destin.Text + dgvC.CurrentRow.Cells[2].Value.ToString() + ";";
			}
			else if (Operators.CompareString(Globals.flag_COD_client, "Mail_CCi", false) == 0)
			{
				MyProject.Forms.Mail.cci_destin.Text = MyProject.Forms.Mail.cci_destin.Text + dgvC.CurrentRow.Cells[2].Value.ToString() + ";";
			}
			else
			{
				MyProject.Forms.Ajout_sortie_Stock.CLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Vente.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact1.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact2.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact3.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Client.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Client.Nom.Text = dgvC.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Client.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
				MyProject.Forms.Histo_Client.IDCLIENT.Text = dgvC.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Histo_Client.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Globals.flag_COD_client = "";
			base.Close();
		}

		private void dgvC_KeyDown(object sender, KeyEventArgs e)
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

		private void Affich_code_client_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Affich_code_client_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
				workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
			}
		}
	}
}
