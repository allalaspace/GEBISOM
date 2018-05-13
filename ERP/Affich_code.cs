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
	public class Affich_code : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvA")]
		private DataGridView _dgvA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtSearch")]
		private TextBox _txtSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		public string refart;

		internal virtual DataGridView dgvA
		{
			[CompilerGenerated]
			get
			{
				return _dgvA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgv1_CellContentDoubleClick;
				KeyEventHandler value3 = dgvA_KeyDown;
				DataGridView dgvA = _dgvA;
				if (dgvA != null)
				{
					dgvA.CellContentDoubleClick -= value2;
					dgvA.KeyDown -= value3;
				}
				_dgvA = value;
				dgvA = _dgvA;
				if (dgvA != null)
				{
					dgvA.CellContentDoubleClick += value2;
					dgvA.KeyDown += value3;
				}
			}
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
				KeyEventHandler value2 = txtSearch_KeyDown;
				EventHandler value3 = txtSearch_TextChanged;
				TextBox txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.KeyDown -= value2;
					txtSearch.TextChanged -= value3;
				}
				_txtSearch = value;
				txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.KeyDown += value2;
					txtSearch.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label1
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

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
				KeyEventHandler value2 = textbox1_KeyDown;
				EventHandler value3 = TextBox1_TextChanged;
				TextBox textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
					textBox.TextChanged -= value3;
				}
				_TextBox1 = value;
				textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
					textBox.TextChanged += value3;
				}
			}
		}

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

		public Affich_code()
		{
			base.KeyDown += Affich_code_KeyDown;
			base.Load += Affich_code_Load;
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
			dgvA = new DataGridView();
			txtSearch = new TextBox();
			Label1 = new Label();
			Label2 = new Label();
			Label3 = new Label();
			TextBox1 = new TextBox();
			Button1 = new Button();
			((ISupportInitialize)dgvA).BeginInit();
			base.SuspendLayout();
			dgvA.AllowUserToAddRows = false;
			dgvA.AllowUserToDeleteRows = false;
			dgvA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvA.BackgroundColor = Color.White;
			dgvA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvA.Location = new Point(11, 110);
			dgvA.Margin = new Padding(4, 5, 4, 5);
			dgvA.Name = "dgvA";
			dgvA.ReadOnly = true;
			dgvA.Size = new Size(535, 490);
			dgvA.TabIndex = 3;
			txtSearch.Location = new Point(113, 47);
			txtSearch.Margin = new Padding(4, 5, 4, 5);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(152, 25);
			txtSearch.TabIndex = 1;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Location = new Point(7, 12);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(113, 17);
			Label1.TabIndex = 23;
			Label1.Text = "Recherche par: ";
			Label2.AutoSize = true;
			Label2.BackColor = SystemColors.ButtonHighlight;
			Label2.Location = new Point(395, 12);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(43, 17);
			Label2.TabIndex = 24;
			Label2.Text = "Label";
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Location = new Point(159, 12);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(43, 17);
			Label3.TabIndex = 25;
			Label3.Text = "Code";
			TextBox1.Location = new Point(336, 47);
			TextBox1.Margin = new Padding(4, 5, 4, 5);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(159, 25);
			TextBox1.TabIndex = 2;
			Button1.BackColor = SystemColors.MenuHighlight;
			Button1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.Location = new Point(228, 617);
			Button1.Name = "Button1";
			Button1.Size = new Size(106, 38);
			Button1.TabIndex = 27;
			Button1.Text = "OK";
			Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(8f, 17f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(560, 686);
			base.Controls.Add(Button1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(txtSearch);
			base.Controls.Add(dgvA);
			Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(10, 0);
			base.Margin = new Padding(4);
			base.Name = "Affich_code";
			Text = "Affich code";
			((ISupportInitialize)dgvA).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dgvA_KeyDown(object sender, KeyEventArgs e)
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string selectCommandText = "select REFART, LIBART FROM ARTICLE_D WHERE REFART LIKE '" + txtSearch.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("ARTICLE_D");
				mySqlDataAdapter.Fill(dataTable);
				dgvA.DataSource = dataTable;
				Globals.clorerDGV(dgvA);
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
				string selectCommandText = "select REFART, LIBART FROM ARTICLE_D WHERE LIBART LIKE '" + TextBox1.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("ARTICLE_D");
				mySqlDataAdapter.Fill(dataTable);
				dgvA.DataSource = dataTable;
				Globals.clorerDGV(dgvA);
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
			if (Operators.CompareString(Globals.flag_COD, "ARTM", false) == 0)
			{
				MyProject.Forms.Gestion_Article_Mont.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Article_Mont.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Article_Mont.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "HART", false) == 0)
			{
				MyProject.Forms.Histo_Article.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Histo_Article.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Histo_Article.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "GARTCOM", false) == 0)
			{
				MyProject.Forms.Gestion_Article_Com.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Article_Com.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Article_Com.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "VM", false) == 0)
			{
				MyProject.Forms.Gestion_Vente.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Vente.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Vente.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "VC", false) == 0)
			{
				MyProject.Forms.Gestion_Vente.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Vente.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_Vente.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "ASS", false) == 0)
			{
				MyProject.Forms.Ajout_sortie_Stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Ajout_sortie_Stock.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Ajout_sortie_Stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "AES", false) == 0)
			{
				MyProject.Forms.Ajout_entree_Stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Ajout_entree_Stock.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Ajout_entree_Stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "SG", false) == 0)
			{
				MyProject.Forms.Gestion_stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_stock.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Gestion_stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "ES", false) == 0)
			{
				MyProject.Forms.Entree_Stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Entree_Stock.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Entree_Stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "SS", false) == 0)
			{
				MyProject.Forms.Sortie_Stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Sortie_Stock.LIBART.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Sortie_Stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "AF", false) == 0)
			{
				//Globals.Ajout_Fact1.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact1.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact1.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact2.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact2.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact2.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact3.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact3.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact3.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact4.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact4.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact4.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact5.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact5.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact5.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact6.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact6.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact6.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact7.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact7.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact7.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "AFC", false) == 0)
			{
				//Globals.Ajout_Fact1.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact1.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact1.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact2.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact2.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact2.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact3.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact3.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact3.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact4.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact4.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact4.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact5.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact5.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact5.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact6.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact6.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact6.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				//Globals.Ajout_Fact7.REFART_C.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				//Globals.Ajout_Fact7.LIBART_C.Text = dgvA.CurrentRow.Cells[1].Value.ToString();
				//Globals.Ajout_Fact7.REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (Operators.CompareString(Globals.flag_COD, "STATSTK", false) == 0)
			{
				MyProject.Forms.Stat_Stock.REFART.Text = dgvA.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Stat_Stock.B_Affich_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Globals.flag_COD = "";
			base.Close();
		}

		private void Affich_code_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Affich_code_Load(object sender, EventArgs e)
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
