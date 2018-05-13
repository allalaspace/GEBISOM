using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic;
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
	public class Histo_Client : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DGV2")]
		private DataGridView _DGV2;

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
		[AccessedThroughProperty("OK")]
		private Button _OK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label2")]
		private Label _label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDCLIENT")]
		private ComboBox _IDCLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar2")]
		private MonthCalendar _MonthCalendar2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DATEFF")]
		private TextBox _DATEFF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Affich")]
		private Button _Affich;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DATEF")]
		private TextBox _DATEF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		internal virtual DataGridView DGV2
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

		internal virtual Button OK
		{
			[CompilerGenerated]
			get
			{
				return _OK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = OK_Click;
				Button oK = _OK;
				if (oK != null)
				{
					oK.Click -= value2;
				}
				_OK = value;
				oK = _OK;
				if (oK != null)
				{
					oK.Click += value2;
				}
			}
		}

		internal virtual Label label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox IDCLIENT
		{
			[CompilerGenerated]
			get
			{
				return _IDCLIENT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = IDCLIENT_KeyDown;
				EventHandler value3 = IDCLIENT_SelectedIndexChanged;
				EventHandler value4 = IDCLIENT_Validated;
				ComboBox iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown -= value2;
					iDCLIENT.SelectedIndexChanged -= value3;
					iDCLIENT.Validated -= value4;
				}
				_IDCLIENT = value;
				iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown += value2;
					iDCLIENT.SelectedIndexChanged += value3;
					iDCLIENT.Validated += value4;
				}
			}
		}

		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return _Button11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button11_Click;
				Button button = _Button11;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button11 = value;
				button = _Button11;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_rechercher
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

		internal virtual Button Button22
		{
			[CompilerGenerated]
			get
			{
				return _Button22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button22_Click;
				Button button = _Button22;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button22 = value;
				button = _Button22;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual MonthCalendar MonthCalendar2
		{
			[CompilerGenerated]
			get
			{
				return _MonthCalendar2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DateRangeEventHandler value2 = MonthCalendar2_DateSelected;
				MonthCalendar monthCalendar = _MonthCalendar2;
				if (monthCalendar != null)
				{
					monthCalendar.DateSelected -= value2;
				}
				_MonthCalendar2 = value;
				monthCalendar = _MonthCalendar2;
				if (monthCalendar != null)
				{
					monthCalendar.DateSelected += value2;
				}
			}
		}

		internal virtual TextBox DATEFF
		{
			[CompilerGenerated]
			get
			{
				return _DATEFF;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DATETF_Click;
				TextBox dATEFF = _DATEFF;
				if (dATEFF != null)
				{
					dATEFF.Click -= value2;
				}
				_DATEFF = value;
				dATEFF = _DATEFF;
				if (dATEFF != null)
				{
					dATEFF.Click += value2;
				}
			}
		}

		internal virtual Label Label8
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Affich
		{
			[CompilerGenerated]
			get
			{
				return _Affich;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Affich_Click;
				Button affich = _Affich;
				if (affich != null)
				{
					affich.Click -= value2;
				}
				_Affich = value;
				affich = _Affich;
				if (affich != null)
				{
					affich.Click += value2;
				}
			}
		}

		internal virtual MonthCalendar MonthCalendar1
		{
			[CompilerGenerated]
			get
			{
				return _MonthCalendar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DateRangeEventHandler value2 = MonthCalendar1_DateSelected;
				MonthCalendar monthCalendar = _MonthCalendar1;
				if (monthCalendar != null)
				{
					monthCalendar.DateSelected -= value2;
				}
				_MonthCalendar1 = value;
				monthCalendar = _MonthCalendar1;
				if (monthCalendar != null)
				{
					monthCalendar.DateSelected += value2;
				}
			}
		}

		internal virtual TextBox DATEF
		{
			[CompilerGenerated]
			get
			{
				return _DATEF;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DATET_Click;
				TextBox dATEF = _DATEF;
				if (dATEF != null)
				{
					dATEF.Click -= value2;
				}
				_DATEF = value;
				dATEF = _DATEF;
				if (dATEF != null)
				{
					dATEF.Click += value2;
				}
			}
		}

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Histo_Client()
		{
			base.Load += Histo_Client_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Histo_Client));
			DGV2 = new DataGridView();
			total = new TextBox();
			Label14 = new Label();
			OK = new Button();
			IDCLIENT = new ComboBox();
			label2 = new Label();
			Button11 = new Button();
			GroupBox2 = new GroupBox();
			B_rechercher = new Button();
			Button22 = new Button();
			MonthCalendar2 = new MonthCalendar();
			DATEFF = new TextBox();
			Label8 = new Label();
			Affich = new Button();
			MonthCalendar1 = new MonthCalendar();
			DATEF = new TextBox();
			Label1 = new Label();
			((ISupportInitialize)DGV2).BeginInit();
			GroupBox2.SuspendLayout();
			base.SuspendLayout();
			DGV2.AllowUserToAddRows = false;
			DGV2.AllowUserToDeleteRows = false;
			DGV2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			DGV2.BackgroundColor = Color.White;
			DGV2.BorderStyle = BorderStyle.Fixed3D;
			DGV2.Location = new Point(34, 306);
			DGV2.Margin = new Padding(3, 5, 3, 5);
			DGV2.Name = "DGV2";
			DGV2.ReadOnly = true;
			DGV2.Size = new Size(985, 364);
			DGV2.TabIndex = 21;
			total.BackColor = Color.CornflowerBlue;
			total.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			total.Location = new Point(1190, 570);
			total.Margin = new Padding(3, 4, 3, 4);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(168, 29);
			total.TabIndex = 51;
			total.Text = "0.00";
			total.TextAlign = HorizontalAlignment.Center;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(1213, 522);
			Label14.Name = "Label14";
			Label14.Size = new Size(122, 29);
			Label14.TabIndex = 50;
			Label14.Text = "Total Achat";
			OK.BackColor = Color.RoyalBlue;
			OK.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			OK.Location = new Point(1204, 645);
			OK.Margin = new Padding(3, 5, 3, 5);
			OK.Name = "OK";
			OK.Size = new Size(145, 54);
			OK.TabIndex = 52;
			OK.Text = "OK";
			OK.UseVisualStyleBackColor = false;
			IDCLIENT.AutoCompleteMode = AutoCompleteMode.Suggest;
			IDCLIENT.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDCLIENT.FormattingEnabled = true;
			IDCLIENT.Location = new Point(469, 26);
			IDCLIENT.Margin = new Padding(5, 4, 5, 4);
			IDCLIENT.Name = "IDCLIENT";
			IDCLIENT.Size = new Size(139, 26);
			IDCLIENT.TabIndex = 55;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(376, 29);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(91, 18);
			label2.TabIndex = 53;
			label2.Text = "Code Client";
			Button11.Location = new Point(592, 24);
			Button11.Margin = new Padding(3, 4, 3, 4);
			Button11.Name = "Button11";
			Button11.Size = new Size(34, 29);
			Button11.TabIndex = 57;
			Button11.Text = "...";
			Button11.UseVisualStyleBackColor = true;
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.Controls.Add(Button11);
			GroupBox2.Controls.Add(B_rechercher);
			GroupBox2.Controls.Add(IDCLIENT);
			GroupBox2.Controls.Add(Button22);
			GroupBox2.Controls.Add(label2);
			GroupBox2.Controls.Add(MonthCalendar2);
			GroupBox2.Controls.Add(DATEFF);
			GroupBox2.Controls.Add(Label8);
			GroupBox2.Controls.Add(Affich);
			GroupBox2.Controls.Add(MonthCalendar1);
			GroupBox2.Controls.Add(DATEF);
			GroupBox2.Controls.Add(Label1);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox2.Location = new Point(42, 59);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(1165, 239);
			GroupBox2.TabIndex = 61;
			GroupBox2.TabStop = false;
			B_rechercher.BackColor = Color.Transparent;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.FlatStyle = FlatStyle.Flat;
			B_rechercher.ForeColor = Color.Transparent;
			B_rechercher.Image = (Image)componentResourceManager.GetObject("B_rechercher.Image");
			B_rechercher.Location = new Point(613, 147);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(143, 47);
			B_rechercher.TabIndex = 77;
			B_rechercher.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(252, 147);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 76;
			Button22.UseVisualStyleBackColor = false;
			MonthCalendar2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar2.Location = new Point(787, 68);
			MonthCalendar2.Name = "MonthCalendar2";
			MonthCalendar2.TabIndex = 73;
			MonthCalendar2.Visible = false;
			DATEFF.Location = new Point(671, 68);
			DATEFF.Name = "DATEFF";
			DATEFF.Size = new Size(120, 26);
			DATEFF.TabIndex = 72;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(610, 71);
			Label8.Margin = new Padding(4, 0, 4, 0);
			Label8.Name = "Label8";
			Label8.Size = new Size(62, 18);
			Label8.TabIndex = 71;
			Label8.Text = "Date fin";
			Affich.BackColor = Color.CornflowerBlue;
			Affich.BackgroundImage = Resources.Deconnexion1;
			Affich.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Affich.ForeColor = SystemColors.ActiveCaptionText;
			Affich.Location = new Point(22, 194);
			Affich.Margin = new Padding(3, 4, 3, 4);
			Affich.Name = "Affich";
			Affich.Size = new Size(110, 38);
			Affich.TabIndex = 59;
			Affich.Text = "Afficher Tout";
			Affich.UseVisualStyleBackColor = false;
			MonthCalendar1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar1.Location = new Point(379, 68);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 58;
			MonthCalendar1.Visible = false;
			DATEF.Location = new Point(259, 68);
			DATEF.Name = "DATEF";
			DATEF.Size = new Size(120, 26);
			DATEF.TabIndex = 57;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(164, 71);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(88, 18);
			Label1.TabIndex = 56;
			Label1.Text = "Date Début";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(OK);
			base.Controls.Add(DGV2);
			base.Controls.Add(total);
			base.Controls.Add(Label14);
			base.Controls.Add(GroupBox2);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Histo_Client";
			Text = "Historique Client";
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(total, 0);
			base.Controls.SetChildIndex(DGV2, 0);
			base.Controls.SetChildIndex(OK, 0);
			((ISupportInitialize)DGV2).EndInit();
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Histo_Client_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DATEFF.Text = DateTime.Now.ToShortDateString();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.cmd.Connection = Globals.conn;
					string query = "SELECT T.IDCLIENT,C.NOM,T.DATE_FACT,T.VENDEUR,T.NUM_FACT, V.QTE,V.PRIX_V,V.REM,V.TotalTTC_DF  FROM VENTE V,TICKET T,CLIENT C WHERE T.NUM_FACT=V.NUM_FACT AND T.IDCLIENT = C.IDCLIENT";
					DGV2.DataSource = null;
					DGV2.Rows.Clear();
					Globals.LoadData(query, DGV2, "CLIENT");
					FormatDGV(DGV2);
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from TICKET";
					decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value) + " DT";
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT ";
					mySqlDataAdapter.Fill(dataSet, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["IDCLIENT"].ToString());
					}
					IDCLIENT.AutoCompleteSource = AutoCompleteSource.CustomSource;
					IDCLIENT.AutoCompleteCustomSource = autoCompleteStringCollection;
					IDCLIENT.AutoCompleteMode = AutoCompleteMode.Suggest;
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

		private void OK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(DATEFF.Text, "", false) == 0)
				{
					DATEFF.Text = DateTime.Now.ToShortDateString();
				}
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				string query;
				if (Operators.CompareString(DATEF.Text, "", false) != 0 & Operators.CompareString(IDCLIENT.Text, "", false) != 0)
				{
					query = "SELECT T.IDCLIENT,C.NOM,T.DATE_FACT,T.VENDEUR,T.NUM_FACT,V.QTE,V.PRIX_V,V.REM,V.TotalTTC_DF  FROM VENTE V,TICKET T,CLIENT C WHERE T.NUM_FACT=V.NUM_FACT AND T.IDCLIENT = C.IDCLIENT AND C.IDCLIENT='" + IDCLIENT.Text + "' AND DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from TICKET where IDCLIENT='" + IDCLIENT.Text + "' AND DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value) + " DT";
				}
				else if (Operators.CompareString(DATEF.Text, "", false) == 0 & Operators.CompareString(IDCLIENT.Text, "", false) != 0)
				{
					query = "SELECT T.IDCLIENT,C.NOM,T.DATE_FACT,T.VENDEUR,T.NUM_FACT,V.QTE,V.PRIX_V,V.REM,V.TotalTTC_DF  FROM VENTE V,TICKET T,CLIENT C WHERE T.NUM_FACT=V.NUM_FACT AND T.IDCLIENT = C.IDCLIENT AND C.IDCLIENT='" + IDCLIENT.Text + "'";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from TICKET where  IDCLIENT='" + IDCLIENT.Text + "' ";
					decimal value2 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value2) + " DT";
				}
				else if (Operators.CompareString(DATEF.Text, "", false) != 0 & Operators.CompareString(IDCLIENT.Text, "", false) == 0)
				{
					query = "SELECT T.IDCLIENT,C.NOM,T.DATE_FACT,T.VENDEUR,T.NUM_FACT,V.QTE,V.PRIX_V,V.REM,V.TotalTTC_DF  FROM VENTE V,TICKET T,CLIENT C WHERE T.NUM_FACT=V.NUM_FACT AND T.IDCLIENT = C.IDCLIENT AND DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from TICKET where DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value3 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value3) + " DT";
				}
				else
				{
					query = "SELECT T.IDCLIENT,C.NOM,T.DATE_FACT,T.VENDEUR,T.NUM_FACT, V.QTE,V.PRIX_V,V.REM,V.TotalTTC_DF  FROM VENTE V,TICKET T,CLIENT C WHERE T.NUM_FACT=V.NUM_FACT";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from ticket";
					decimal value4 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value4) + " DT";
				}
				DGV2.DataSource = null;
				DGV2.Rows.Clear();
				Globals.LoadData(query, DGV2, "CLIENT");
				FormatDGV(DGV2);
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

		public void FormatDGV(DataGridView Dgv)
		{
			if (Dgv.Rows.Count > 0)
			{
				Dgv.RowHeadersVisible = false;
				Dgv.Columns[0].HeaderCell.Value = "ID client";
				Dgv.Columns[1].HeaderCell.Value = "Nom";
				Dgv.Columns[2].HeaderCell.Value = "Date Facture";
				Dgv.Columns[3].HeaderCell.Value = "Vendeur";
				Dgv.Columns[4].HeaderCell.Value = "Num Facture";
				Dgv.Columns[5].HeaderCell.Value = "Qte";
				Dgv.Columns[6].HeaderCell.Value = "Prix U.";
				Dgv.Columns[7].HeaderCell.Value = "Remise";
				Dgv.Columns[8].HeaderCell.Value = "Total DT";
				Dgv.Columns[0].Width = 120;
				Dgv.Columns[1].Width = 150;
				Dgv.Columns[2].Width = 130;
				Dgv.Columns[3].Width = 120;
				Dgv.Columns[4].Width = 100;
				Dgv.Columns[5].Width = 70;
				Dgv.Columns[6].Width = 100;
				Dgv.Columns[7].Width = 60;
				Dgv.Columns[8].Width = 110;
				DataGridView dataGridView = null;
				DataGridView dataGridView2 = null;
				int num = checked(Dgv.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
					}
				}
			}
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Affich_code_client.Show();
				string query = "select distinct IDCLIENT,NOM from CLIENT";
				MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
				MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "CLIENT");
				DataGridView dgvC = MyProject.Forms.Affich_code_client.dgvC;
				dgvC.Columns[0].HeaderCell.Value = "Id. Client";
				dgvC.Columns[1].HeaderCell.Value = "Nom";
				dgvC.Columns[0].Width = 140;
				dgvC.Columns[1].Width = 240;
				dgvC = null;
				int num = checked(MyProject.Forms.Affich_code_client.dgvC.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

		private void IDCLIENT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button11_Click(1, e);
				e.Handled = true;
			}
		}

		private void IDCLIENT_SelectedIndexChanged(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
			Globals.ClearComboBox(this);
		}

		private void Affich_Click(object sender, EventArgs e)
		{
			Histo_Client_Load(RuntimeHelpers.GetObjectValue(sender), e);
			Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void DATET_Click(object sender, EventArgs e)
		{
			MonthCalendar1.Visible = true;
			DATEF.Text = "";
		}

		private void DATETF_Click(object sender, EventArgs e)
		{
			MonthCalendar2.Visible = true;
			DATEFF.Text = "";
		}

		private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			DATEF.Text = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
			MonthCalendar1.Visible = false;
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void MonthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
		{
			DATEFF.Text = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy");
			MonthCalendar2.Visible = false;
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void IDCLIENT_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT where IDCLIENT='" + IDCLIENT.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				IDCLIENT.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					IDCLIENT_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					mySqlDataReader.Close();
					IDCLIENT.Text = "";
					MessageBox.Show("Ce Client n'existe pas,Etes !", "Client!");
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
