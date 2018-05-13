using ERP.My;
using ERP.My.Resources;
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
	public class Histo_Article : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STOK")]
		private TextBox _STOK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STKMIN")]
		private TextBox _STKMIN;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STKMAG")]
		private TextBox _STKMAG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DGV2")]
		private DataGridView _DGV2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private TextBox _LIBART;

		internal virtual GroupBox GroupBox1
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

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual GroupBox GroupBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox STOK
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label21
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox STKMIN
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label24
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox STKMAG
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label26
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgv1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView DGV2
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

		internal virtual TextBox LIBART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Histo_Article()
		{
			base.Load += Histo_Article_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Histo_Article));
			GroupBox1 = new GroupBox();
			LIBART = new TextBox();
			Button5 = new Button();
			Label2 = new Label();
			B_rechercher = new Button();
			Label1 = new Label();
			REFART = new ComboBox();
			GroupBox2 = new GroupBox();
			STOK = new TextBox();
			Label21 = new Label();
			STKMIN = new TextBox();
			Label24 = new Label();
			STKMAG = new TextBox();
			Label26 = new Label();
			GroupBox3 = new GroupBox();
			dgv1 = new DataGridView();
			GroupBox4 = new GroupBox();
			DGV2 = new DataGridView();
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			GroupBox3.SuspendLayout();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox4.SuspendLayout();
			((ISupportInitialize)DGV2).BeginInit();
			base.SuspendLayout();
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(Label2);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox1.Location = new Point(14, 69);
			GroupBox1.Margin = new Padding(3, 4, 3, 4);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(3, 4, 3, 4);
			GroupBox1.Size = new Size(1080, 100);
			GroupBox1.TabIndex = 28;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Référence";
			LIBART.Location = new Point(358, 44);
			LIBART.Margin = new Padding(3, 4, 3, 4);
			LIBART.Name = "LIBART";
			LIBART.ReadOnly = true;
			LIBART.Size = new Size(390, 26);
			LIBART.TabIndex = 42;
			Button5.Location = new Point(204, 42);
			Button5.Margin = new Padding(3, 4, 3, 4);
			Button5.Name = "Button5";
			Button5.Size = new Size(38, 28);
			Button5.TabIndex = 47;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.ForeColor = SystemColors.ActiveCaption;
			Label2.Location = new Point(282, 50);
			Label2.Name = "Label2";
			Label2.Size = new Size(54, 18);
			Label2.TabIndex = 3;
			Label2.Text = "Libelle";
			B_rechercher.BackgroundImage = (Image)componentResourceManager.GetObject("B_rechercher.BackgroundImage");
			B_rechercher.Location = new Point(771, 39);
			B_rechercher.Margin = new Padding(3, 4, 3, 4);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(148, 34);
			B_rechercher.TabIndex = 2;
			B_rechercher.Text = "     Rechercher";
			B_rechercher.UseVisualStyleBackColor = true;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(17, 48);
			Label1.Name = "Label1";
			Label1.Size = new Size(47, 18);
			Label1.TabIndex = 0;
			Label1.Text = "Code";
			REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(83, 44);
			REFART.Margin = new Padding(3, 4, 3, 4);
			REFART.Name = "REFART";
			REFART.Size = new Size(140, 26);
			REFART.TabIndex = 5;
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.Controls.Add(STOK);
			GroupBox2.Controls.Add(Label21);
			GroupBox2.Controls.Add(STKMIN);
			GroupBox2.Controls.Add(Label24);
			GroupBox2.Controls.Add(STKMAG);
			GroupBox2.Controls.Add(Label26);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox2.Location = new Point(14, 182);
			GroupBox2.Margin = new Padding(3, 4, 3, 4);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Padding = new Padding(3, 4, 3, 4);
			GroupBox2.Size = new Size(1080, 76);
			GroupBox2.TabIndex = 36;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Etat Stock";
			STOK.Location = new Point(122, 27);
			STOK.Margin = new Padding(3, 4, 3, 4);
			STOK.Name = "STOK";
			STOK.ReadOnly = true;
			STOK.Size = new Size(149, 26);
			STOK.TabIndex = 41;
			Label21.AutoSize = true;
			Label21.BackColor = Color.Transparent;
			Label21.ForeColor = SystemColors.ActiveCaption;
			Label21.Location = new Point(7, 30);
			Label21.Name = "Label21";
			Label21.Size = new Size(93, 18);
			Label21.TabIndex = 40;
			Label21.Text = "Stock actuel";
			STKMIN.Location = new Point(708, 27);
			STKMIN.Margin = new Padding(3, 4, 3, 4);
			STKMIN.Name = "STKMIN";
			STKMIN.ReadOnly = true;
			STKMIN.Size = new Size(187, 26);
			STKMIN.TabIndex = 39;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.ForeColor = SystemColors.ActiveCaption;
			Label24.Location = new Point(635, 30);
			Label24.Name = "Label24";
			Label24.Size = new Size(56, 18);
			Label24.TabIndex = 38;
			Label24.Text = "Stkmin";
			STKMAG.Location = new Point(406, 21);
			STKMAG.Margin = new Padding(3, 4, 3, 4);
			STKMAG.Name = "STKMAG";
			STKMAG.ReadOnly = true;
			STKMAG.Size = new Size(149, 26);
			STKMAG.TabIndex = 37;
			Label26.AutoSize = true;
			Label26.BackColor = Color.Transparent;
			Label26.ForeColor = SystemColors.ActiveCaption;
			Label26.Location = new Point(328, 30);
			Label26.Name = "Label26";
			Label26.Size = new Size(60, 18);
			Label26.TabIndex = 36;
			Label26.Text = "Stkmax";
			GroupBox3.BackColor = Color.Transparent;
			GroupBox3.Controls.Add(dgv1);
			GroupBox3.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox3.Location = new Point(16, 278);
			GroupBox3.Margin = new Padding(3, 4, 3, 4);
			GroupBox3.Name = "GroupBox3";
			GroupBox3.Padding = new Padding(3, 4, 3, 4);
			GroupBox3.Size = new Size(614, 409);
			GroupBox3.TabIndex = 37;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Suivi Entrée stock";
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.BackgroundColor = Color.White;
			dgv1.BorderStyle = BorderStyle.Fixed3D;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(8, 32);
			dgv1.Margin = new Padding(3, 5, 3, 5);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(600, 368);
			dgv1.TabIndex = 13;
			GroupBox4.BackColor = Color.Transparent;
			GroupBox4.Controls.Add(DGV2);
			GroupBox4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox4.Location = new Point(645, 278);
			GroupBox4.Margin = new Padding(3, 4, 3, 4);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Padding = new Padding(3, 4, 3, 4);
			GroupBox4.Size = new Size(613, 409);
			GroupBox4.TabIndex = 38;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Suivi Sortie stock";
			DGV2.AllowUserToAddRows = false;
			DGV2.AllowUserToDeleteRows = false;
			DGV2.BackgroundColor = Color.White;
			DGV2.BorderStyle = BorderStyle.Fixed3D;
			DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV2.Location = new Point(6, 32);
			DGV2.Margin = new Padding(3, 5, 3, 5);
			DGV2.Name = "DGV2";
			DGV2.ReadOnly = true;
			DGV2.Size = new Size(600, 368);
			DGV2.TabIndex = 13;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1354, 728);
			base.Controls.Add(GroupBox3);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(GroupBox4);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Histo_Article";
			Text = "Historique Article";
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(GroupBox3, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			GroupBox3.ResumeLayout(false);
			((ISupportInitialize)dgv1).EndInit();
			GroupBox4.ResumeLayout(false);
			((ISupportInitialize)DGV2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				dgv1.DataSource = null;
				dgv1.Rows.Clear();
				DGV2.DataSource = null;
				DGV2.Rows.Clear();
				Globals.ClearTextBox(this);
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select LIBART, STOK, STKMIN, STKMAG from ARTICLE_D where REFART ='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					STOK.Text = mySqlDataReader["STOK"].ToString();
					STKMIN.Text = mySqlDataReader["STKMIN"].ToString();
					STKMAG.Text = mySqlDataReader["STKMAG"].ToString();
				}
				else
				{
					MessageBox.Show("ARTICLE not found");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				MySqlCommand mySqlCommand2 = new MySqlCommand();
				mySqlCommand2.Connection = Globals.conn;
				mySqlCommand2.CommandText = "select DATE_ENTREE, REFART CODE, LIBART ARTICLE,QUANTITE,PRIX_UE from entree_stock where REFART ='" + REFART.Text + "'";
				mySqlCommand2.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
				mySqlCommand2.CommandType = CommandType.Text;
				if (mySqlDataReader2.Read())
				{
					mySqlDataReader2.Close();
					mySqlDataReader2.Dispose();
					string selectCommandText = "select DATE_ENTREE, REFART CODE, LIBART ARTICLE,QUANTITE,PRIX_UE from entree_stock where REFART ='" + REFART.Text + "'";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					dgv1.DataSource = dataTable;
				}
				string query = "select DATE_SORTIE, REFART CODE, LIBART ARTICLE,QUANTITE from sortie_stock where REFART ='" + REFART.Text + "'";
				DGV2.DataSource = null;
				DGV2.Rows.Clear();
				Globals.LoadData(query, DGV2, "sortie_stock");
				FormatDGVE(dgv1);
				FormatDGVS(DGV2);
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
			}
		}

		private void Histo_Article_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
					mySqlDataAdapter.Fill(dataSet, "list");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
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
		}

		public void FormatDGVS(DataGridView Dgv)
		{
			checked
			{
				if (Dgv.Rows.Count > 0)
				{
					Dgv.Columns[0].HeaderCell.Value = "Date Sorite";
					Dgv.Columns[1].HeaderCell.Value = "Réf. Article";
					Dgv.Columns[2].HeaderCell.Value = "Lib. Article";
					Dgv.Columns[3].HeaderCell.Value = "quantite";
					Dgv.Columns[0].Width = 130;
					Dgv.Columns[1].Width = 150;
					Dgv.Columns[2].Width = 150;
					Dgv.Columns[3].Width = 80;
					DataGridView dataGridView = null;
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
					(dataGridView2 = Dgv).Width = dataGridView2.Width + (Dgv.RowHeadersWidth + 5);
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
					(dataGridView2 = Dgv).Height = dataGridView2.Height + (Dgv.ColumnHeadersHeight + 5);
					if (Dgv.Height <= 368)
					{
						Dgv.Height = Dgv.Height;
					}
					else
					{
						Dgv.Height = 368;
					}
					if (Dgv.Width <= 600)
					{
						Dgv.Width = Dgv.Width;
					}
					else
					{
						Dgv.Width = 600;
					}
				}
			}
		}

		public void FormatDGVE(DataGridView Dgv)
		{
			checked
			{
				if (Dgv.Rows.Count > 0)
				{
					Dgv.Columns[0].HeaderCell.Value = "Date Entrée";
					Dgv.Columns[1].HeaderCell.Value = "Réf. Article";
					Dgv.Columns[2].HeaderCell.Value = "Lib. Article";
					Dgv.Columns[3].HeaderCell.Value = "quantite";
					Dgv.Columns[4].HeaderCell.Value = "Prix U.";
					Dgv.Columns[0].Width = 110;
					Dgv.Columns[1].Width = 150;
					Dgv.Columns[2].Width = 150;
					Dgv.Columns[3].Width = 60;
					Dgv.Columns[4].Width = 80;
					DataGridView dataGridView = null;
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
					(dataGridView2 = Dgv).Height = dataGridView2.Height + (Dgv.ColumnHeadersHeight + 15);
					if (Dgv.Height <= 368)
					{
						Dgv.Height = Dgv.Height;
					}
					else
					{
						Dgv.Height = 368;
					}
					if (Dgv.Width <= 600)
					{
						Dgv.Width = Dgv.Width;
					}
					else
					{
						Dgv.Width = 600;
					}
				}
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "HART";
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

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		private void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
					goto IL_00ed;
				}
				if (Operators.CompareString(REFART.Text, "", false) != 0)
				{
					MessageBox.Show("Article no trouvé!", "Article");
					REFART.Text = "";
					REFART.Focus();
					goto IL_00ed;
				}
				goto end_IL_0001;
				IL_00ed:
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
	}
}
