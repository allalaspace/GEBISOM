using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Gestion_stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AFFICH_TT")]
		private Button _AFFICH_TT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("total")]
		private TextBox _total;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		internal virtual DataGridView dgv1
		{
			[CompilerGenerated]
			get
			{
				return _dgv1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgv1_CellDoubleClick;
				DataGridView dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellDoubleClick -= value2;
				}
				_dgv1 = value;
				dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellDoubleClick += value2;
				}
			}
		}

		internal virtual Button AFFICH_TT
		{
			[CompilerGenerated]
			get
			{
				return _AFFICH_TT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = AFFICH_TT_Click;
				Button aFFICH_TT = _AFFICH_TT;
				if (aFFICH_TT != null)
				{
					aFFICH_TT.Click -= value2;
				}
				_AFFICH_TT = value;
				aFFICH_TT = _AFFICH_TT;
				if (aFFICH_TT != null)
				{
					aFFICH_TT.Click += value2;
				}
			}
		}

		internal virtual Button btnUpdate
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate_Click;
				Button btnUpdate = _btnUpdate;
				if (btnUpdate != null)
				{
					btnUpdate.Click -= value2;
				}
				_btnUpdate = value;
				btnUpdate = _btnUpdate;
				if (btnUpdate != null)
				{
					btnUpdate.Click += value2;
				}
			}
		}

		internal virtual Button btnDelete
		{
			[CompilerGenerated]
			get
			{
				return _btnDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDelete_Click;
				Button btnDelete = _btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click -= value2;
				}
				_btnDelete = value;
				btnDelete = _btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click += value2;
				}
			}
		}

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return _Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button3_Click;
				Button button = _Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button3 = value;
				button = _Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return _CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CheckBox1_CheckedChanged;
				CheckBox checkBox = _CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_CheckBox1 = value;
				checkBox = _CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return _CheckBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CheckBox2_CheckedChanged;
				CheckBox checkBox = _CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_CheckBox2 = value;
				checkBox = _CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return _Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button5_Click;
				Button button = _Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button5 = value;
				button = _Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public virtual ComboBox REFART
		{
			[CompilerGenerated]
			get
			{
				return _REFART;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = REFART_KeyDown;
				EventHandler value3 = REFART_SelectedIndexChanged;
				EventHandler value4 = REFART_Validated;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.KeyDown -= value2;
					rEFART.SelectedIndexChanged -= value3;
					rEFART.Validated -= value4;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.KeyDown += value2;
					rEFART.SelectedIndexChanged += value3;
					rEFART.Validated += value4;
				}
			}
		}

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual Button B_rechercher
		{
			[CompilerGenerated]
			get
			{
				return _B_rechercher;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_rechercher_Click;
				Button b_rechercher = _B_rechercher;
				if (b_rechercher != null)
				{
					b_rechercher.Click -= value2;
				}
				_B_rechercher = value;
				b_rechercher = _B_rechercher;
				if (b_rechercher != null)
				{
					b_rechercher.Click += value2;
				}
			}
		}

		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox total
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label14
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox LIBART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnNew
		{
			[CompilerGenerated]
			get
			{
				return _btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNew_Click;
				Button btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click -= value2;
				}
				_btnNew = value;
				btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click += value2;
				}
			}
		}

		public Gestion_stock()
		{
			base.Load += frmMain_Load;
			InitializeComponent();
		}

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		public void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.ClearTextBox(this);
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select * from ARTICLE_D where REFART ='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				mySqlCommand.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					string selectCommandText = "select REFART, LIBART, LIB_FAM, STOK, STKMIN, STKMAG, NOMFRS,STOK*PRIX_ATTC FROM ARTICLE_D where REFART ='" + REFART.Text + "'";
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select IFNULL(sum(STOK*PRIX_ATTC),0) from ARTICLE_D where REFART ='" + REFART.Text + "'";
					decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(mySqlCommand.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value) + " DT";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					dgv1.DataSource = dataTable;
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					FormatDGV(dgv1);
				}
				else
				{
					REFART.Text = "";
					LIBART.Text = "";
					MessageBox.Show("Article non trouvé");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
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

		private void AFFICH_TT_Click(object sender, EventArgs e)
		{
			try
			{
				CheckBox1.Checked = false;
				CheckBox2.Checked = false;
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select REFART, LIBART, LIB_FAM,PRIX_ATTC, STOK, STKMIN, STKMAG, NOMFRS,STOK*PRIX_ATTC FROM ARTICLE_D";
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select IFNULL(sum(STOK*PRIX_ATTC),0) from ARTICLE_D";
				decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(mySqlCommand.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
				total.Text = Conversions.ToString(value) + " DT";
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(Globals.cmd);
				DataSet dataSet = new DataSet();
				MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
				DataTable dataTable = new DataTable();
				DataSet dataSet2 = new DataSet();
				mySqlDataAdapter.Fill(dataSet2, "ARTICLE_D");
				dataTable = dataSet2.Tables["ARTICLE_D"];
				dgv1.DataSource = dataTable;
				FormatDGV(dgv1);
				Globals.cmd.Dispose();
				REFART.Text = "";
				LIBART.Text = "";
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Gestion_Article_Com.Show();
				MyProject.Forms.Gestion_Article_Com.REFART.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Article_Com.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				MyProject.Forms.Gestion_Article_Com.Show();
				MyProject.Forms.Gestion_Article_Com.REFART.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Gestion_Article_Com.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					MySqlConnection mySqlConnection = new MySqlConnection(Globals.connStr);
					if (mySqlConnection.State == ConnectionState.Closed)
					{
						mySqlConnection.Open();
					}
					string selectCommandText = "select REFART, LIBART, LIB_FAM,PRIX_ATTC, STOK, STKMIN, STKMAG, NOMFRS,STOK*PRIX_ATTC FROM ARTICLE_D";
					Globals.cmd.Connection = mySqlConnection;
					Globals.cmd.CommandText = "select IFNULL(sum(STOK*PRIX_ATTC),0) from ARTICLE_D";
					decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value) + " DT";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, mySqlConnection);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					dgv1.DataSource = dataTable;
					FormatDGV(dgv1);
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (mySqlConnection.State == ConnectionState.Closed)
					{
						mySqlConnection.Open();
					}
					mySqlCommand.Connection = mySqlConnection;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
					mySqlDataAdapter2.Fill(dataSet, "list");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
					mySqlConnection?.Close();
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer le stock de cette article?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "UPDATE ARTICLE_D SET STOK=null WHERE REFART='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					dgv1.Rows.Remove(dgv1.CurrentRow);
					FormatDGV(dgv1);
					MessageBox.Show("STOCK supprimé");
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
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

		private void btnNew_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
		}

		public void RefreshDGV()
		{
			string selectCommandText = "select REFART, LIBART, LIB_FAM, PRIX_ATTC, STOK, STKMIN, STKMAG, NOMFRS,STOK*PRIX_ATTC FROM ARTICLE_D";
			Globals.cmd.Connection = Globals.conn;
			Globals.cmd.CommandText = "select IFNULL(sum(STOK*PRIX_ATTC),0) from ARTICLE_D";
			decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
			total.Text = Conversions.ToString(value) + " DT";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("ARTICLE_D");
			mySqlDataAdapter.Fill(dataTable);
			dgv1.DataSource = dataTable;
			FormatDGV(dgv1);
		}

		public void FormatDGV(DataGridView Dgv)
		{
			Dgv.Columns[0].HeaderCell.Value = "Réf. Article";
			Dgv.Columns[1].HeaderCell.Value = "Lib. Article";
			Dgv.Columns[2].HeaderCell.Value = "Famille";
			Dgv.Columns[3].HeaderCell.Value = "PRIX U.";
			Dgv.Columns[4].HeaderCell.Value = "Stock";
			Dgv.Columns[5].HeaderCell.Value = "Stock min";
			Dgv.Columns[6].HeaderCell.Value = "Stock max";
			Dgv.Columns[7].HeaderCell.Value = "Fournisseur";
			Dgv.Columns[8].HeaderCell.Value = "Valeur stock";
			DataGridView dataGridView = null;
			checked
			{
				int num = Dgv.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (unchecked(i % 2) == 1)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
					}
					if (decimal.Compare(Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(Dgv.Rows[i].Cells[4].Value))), Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(Dgv.Rows[i].Cells[5].Value)))) < 0)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
					}
					if (decimal.Compare(Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(Dgv.Rows[i].Cells[4].Value))), Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(Dgv.Rows[i].Cells[6].Value)))) > 0)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
					}
				}
				Dgv.Width = 0;
				Dgv.Height = 0;
				IEnumerator enumerator = default(IEnumerator);
				DataGridView dataGridView2;
				try
				{
					enumerator = Dgv.Columns.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataGridViewColumn dataGridViewColumn = unchecked((DataGridViewColumn)enumerator.Current);
						(dataGridView2 = Dgv).Width = dataGridView2.Width + dataGridViewColumn.Width;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				(dataGridView2 = Dgv).Width = dataGridView2.Width + (Dgv.RowHeadersWidth + 10);
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = unchecked((IEnumerable)Dgv.Rows).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataGridViewRow dataGridViewRow = unchecked((DataGridViewRow)enumerator2.Current);
						(dataGridView2 = Dgv).Height = dataGridView2.Height + dataGridViewRow.Height;
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				(dataGridView2 = Dgv).Height = dataGridView2.Height + (Dgv.ColumnHeadersHeight + 2);
				if (Dgv.Height <= 468)
				{
					Dgv.Height = Dgv.Height;
				}
				else
				{
					Dgv.Height = 468;
				}
				if (Dgv.Width <= 1090)
				{
					Dgv.Width = Dgv.Width;
				}
				else
				{
					Dgv.Width = 1090;
				}
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					total.Text = "";
					if (CheckBox1.Checked)
					{
						CheckBox2.Checked = false;
						dgv1.CurrentCell = null;
						int num = dgv1.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (decimal.Compare(Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(dgv1.Rows[i].Cells[4].Value))), Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(dgv1.Rows[i].Cells[5].Value)))) < 0)
							{
								dgv1.Rows[i].Visible = true;
							}
							else
							{
								dgv1.Rows[i].Visible = false;
							}
						}
					}
					else
					{
						AFFICH_TT_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					total.Text = "";
					if (CheckBox2.Checked)
					{
						CheckBox1.Checked = false;
						dgv1.CurrentCell = null;
						int num = dgv1.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (decimal.Compare(Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(dgv1.Rows[i].Cells[4].Value))), Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(dgv1.Rows[i].Cells[6].Value)))) > 0)
							{
								dgv1.Rows[i].Visible = true;
							}
							else
							{
								dgv1.Rows[i].Visible = false;
							}
						}
					}
					else
					{
						AFFICH_TT_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void B_rechercher_Click(object sender, EventArgs e)
		{
			REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "SG";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D";
				MyProject.Forms.Affich_code.dgvA.DataSource = null;
				MyProject.Forms.Affich_code.dgvA.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code.dgvA, "ARTICLE");
				DataGridView dgvA = MyProject.Forms.Affich_code.dgvA;
				dgvA.Columns[0].HeaderCell.Value = "Réf. Article";
				dgvA.Columns[1].HeaderCell.Value = "Nom";
				dgvA.Columns[0].Width = 140;
				dgvA.Columns[1].Width = 240;
				dgvA = null;
				int num = checked(MyProject.Forms.Affich_code.dgvA.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						MyProject.Forms.Affich_code.dgvA.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						MyProject.Forms.Affich_code.dgvA.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

		private void REFART_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where REFART ='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					if (Operators.CompareString(REFART.Text, "", false) == 0)
					{
						mySqlDataReader.Close();
						mySqlDataReader.Dispose();
						goto end_IL_0001;
					}
					MessageBox.Show("Article no trouvé!", "Article");
					REFART.Text = "";
					LIBART.Text = "";
					REFART.Focus();
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				end_IL_0001:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_stock));
			dgv1 = new DataGridView();
			AFFICH_TT = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			Label3 = new Label();
			Label4 = new Label();
			Button1 = new Button();
			Button3 = new Button();
			CheckBox1 = new CheckBox();
			CheckBox2 = new CheckBox();
			GroupBox1 = new GroupBox();
			LIBART = new ComboBox();
			Button5 = new Button();
			REFART = new ComboBox();
			Label5 = new Label();
			B_rechercher = new Button();
			Label6 = new Label();
			total = new TextBox();
			Label14 = new Label();
			btnNew = new Button();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.BackgroundColor = Color.White;
			dgv1.BorderStyle = BorderStyle.Fixed3D;
			dgv1.Cursor = Cursors.Arrow;
			dgv1.Location = new Point(148, 203);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(989, 468);
			dgv1.TabIndex = 3;
			AFFICH_TT.BackColor = Color.White;
			AFFICH_TT.Cursor = Cursors.Hand;
			AFFICH_TT.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			AFFICH_TT.Image = Resources.Button_Refresh_icon;
			AFFICH_TT.ImageAlign = ContentAlignment.MiddleLeft;
			AFFICH_TT.Location = new Point(17, 203);
			AFFICH_TT.Margin = new Padding(3, 4, 3, 4);
			AFFICH_TT.Name = "AFFICH_TT";
			AFFICH_TT.Size = new Size(109, 55);
			AFFICH_TT.TabIndex = 4;
			AFFICH_TT.Text = "Initier";
			AFFICH_TT.TextAlign = ContentAlignment.MiddleRight;
			AFFICH_TT.UseVisualStyleBackColor = false;
			btnUpdate.BackColor = Color.White;
			btnUpdate.Cursor = Cursors.Hand;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.Image = Resources.edit_file_icon;
			btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdate.Location = new Point(17, 379);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(109, 53);
			btnUpdate.TabIndex = 6;
			btnUpdate.Text = "Modifier";
			btnUpdate.TextAlign = ContentAlignment.MiddleRight;
			btnUpdate.UseVisualStyleBackColor = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(17, 462);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(109, 53);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Supprimer";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Cursor = Cursors.Hand;
			Label3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(1095, 142);
			Label3.Name = "Label3";
			Label3.Size = new Size(91, 16);
			Label3.TabIndex = 27;
			Label3.Text = "Sorties Stock";
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.Cursor = Cursors.Hand;
			Label4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(977, 142);
			Label4.Name = "Label4";
			Label4.Size = new Size(94, 16);
			Label4.TabIndex = 26;
			Label4.Text = "Entrées Stock";
			Button1.BackgroundImage = (Image)componentResourceManager.GetObject("Button1.BackgroundImage");
			Button1.Cursor = Cursors.Hand;
			Button1.Location = new Point(1098, 63);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(70, 75);
			Button1.TabIndex = 25;
			Button1.UseVisualStyleBackColor = true;
			Button3.BackgroundImage = (Image)componentResourceManager.GetObject("Button3.BackgroundImage");
			Button3.Cursor = Cursors.Hand;
			Button3.Location = new Point(980, 63);
			Button3.Margin = new Padding(3, 4, 3, 4);
			Button3.Name = "Button3";
			Button3.Size = new Size(73, 75);
			Button3.TabIndex = 24;
			Button3.UseVisualStyleBackColor = true;
			CheckBox1.AutoSize = true;
			CheckBox1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			CheckBox1.ForeColor = Color.Red;
			CheckBox1.Location = new Point(812, 90);
			CheckBox1.Name = "CheckBox1";
			CheckBox1.Size = new Size(126, 23);
			CheckBox1.TabIndex = 28;
			CheckBox1.Text = "Stocks faible";
			CheckBox1.UseVisualStyleBackColor = true;
			CheckBox2.AutoSize = true;
			CheckBox2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			CheckBox2.ForeColor = Color.FromArgb(0, 192, 0);
			CheckBox2.Location = new Point(812, 146);
			CheckBox2.Name = "CheckBox2";
			CheckBox2.Size = new Size(165, 23);
			CheckBox2.TabIndex = 29;
			CheckBox2.Text = "Stocks dépassant";
			CheckBox2.UseVisualStyleBackColor = true;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Label5);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Label6);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox1.Location = new Point(12, 71);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(794, 98);
			GroupBox1.TabIndex = 47;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Référence";
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(367, 42);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(288, 26);
			LIBART.Sorted = true;
			LIBART.TabIndex = 47;
			Button5.Cursor = Cursors.Hand;
			Button5.Location = new Point(250, 40);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 46;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(59, 41);
			REFART.Name = "REFART";
			REFART.Size = new Size(206, 26);
			REFART.TabIndex = 14;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(307, 44);
			Label5.Name = "Label5";
			Label5.Size = new Size(54, 18);
			Label5.TabIndex = 3;
			Label5.Text = "Libelle";
			B_rechercher.BackColor = Color.White;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.Image = Resources.Actions_document_find_icon1;
			B_rechercher.ImageAlign = ContentAlignment.MiddleLeft;
			B_rechercher.Location = new Point(661, 32);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(127, 43);
			B_rechercher.TabIndex = 2;
			B_rechercher.Text = "Rechercher";
			B_rechercher.TextAlign = ContentAlignment.MiddleRight;
			B_rechercher.UseVisualStyleBackColor = false;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(6, 45);
			Label6.Name = "Label6";
			Label6.Size = new Size(47, 18);
			Label6.TabIndex = 0;
			Label6.Text = "Code";
			total.BackColor = Color.CornflowerBlue;
			total.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			total.Location = new Point(1147, 435);
			total.Margin = new Padding(3, 4, 3, 4);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(202, 29);
			total.TabIndex = 110;
			total.Text = "0.00";
			total.TextAlign = HorizontalAlignment.Center;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(1143, 402);
			Label14.Name = "Label14";
			Label14.Size = new Size(203, 19);
			Label14.TabIndex = 109;
			Label14.Text = "Valeur Global Stock";
			btnNew.BackColor = Color.White;
			btnNew.Cursor = Cursors.Hand;
			btnNew.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNew.Image = Resources.add_1_icon;
			btnNew.ImageAlign = ContentAlignment.MiddleLeft;
			btnNew.Location = new Point(17, 294);
			btnNew.Margin = new Padding(3, 4, 3, 4);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(109, 58);
			btnNew.TabIndex = 11;
			btnNew.Text = "Ajouter";
			btnNew.TextAlign = ContentAlignment.MiddleRight;
			btnNew.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(total);
			base.Controls.Add(Label14);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(CheckBox2);
			base.Controls.Add(CheckBox1);
			base.Controls.Add(Label3);
			base.Controls.Add(Label4);
			base.Controls.Add(Button1);
			base.Controls.Add(Button3);
			base.Controls.Add(btnNew);
			base.Controls.Add(btnDelete);
			base.Controls.Add(btnUpdate);
			base.Controls.Add(AFFICH_TT);
			base.Controls.Add(dgv1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Gestion_stock";
			Text = "Gestion Stock";
			base.Controls.SetChildIndex(dgv1, 0);
			base.Controls.SetChildIndex(AFFICH_TT, 0);
			base.Controls.SetChildIndex(btnUpdate, 0);
			base.Controls.SetChildIndex(btnDelete, 0);
			base.Controls.SetChildIndex(btnNew, 0);
			base.Controls.SetChildIndex(Button3, 0);
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(CheckBox1, 0);
			base.Controls.SetChildIndex(CheckBox2, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(total, 0);
			((ISupportInitialize)dgv1).EndInit();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
