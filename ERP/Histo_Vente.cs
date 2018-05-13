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
	public class Histo_Vente : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label2")]
		private Label _label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DGV1")]
		private DataGridView _DGV1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DATET")]
		private TextBox _DATET;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Affich")]
		private Button _Affich;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NUMTICKET")]
		private ComboBox _NUMTICKET;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar2")]
		private MonthCalendar _MonthCalendar2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DATETF")]
		private TextBox _DATETF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_rechercher")]
		private Button _b_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		public string TABLEFACT;

		public string TABLEDF;

		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return _GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = GroupBox1_Enter;
				GroupBox groupBox = _GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= value2;
				}
				_GroupBox1 = value;
				groupBox = _GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += value2;
				}
			}
		}

		internal virtual Label label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView DGV1
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

		internal virtual TextBox DATET
		{
			[CompilerGenerated]
			get
			{
				return _DATET;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DATET_Click;
				TextBox dATET = _DATET;
				if (dATET != null)
				{
					dATET.Click -= value2;
				}
				_DATET = value;
				dATET = _DATET;
				if (dATET != null)
				{
					dATET.Click += value2;
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

		public virtual ComboBox NUMTICKET
		{
			[CompilerGenerated]
			get
			{
				return _NUMTICKET;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = NUMTICKET_Click;
				EventHandler value3 = NUMTICKET_SelectedIndexChanged;
				ComboBox nUMTICKET = _NUMTICKET;
				if (nUMTICKET != null)
				{
					nUMTICKET.Click -= value2;
					nUMTICKET.SelectedIndexChanged -= value3;
				}
				_NUMTICKET = value;
				nUMTICKET = _NUMTICKET;
				if (nUMTICKET != null)
				{
					nUMTICKET.Click += value2;
					nUMTICKET.SelectedIndexChanged += value3;
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

		internal virtual TextBox DATETF
		{
			[CompilerGenerated]
			get
			{
				return _DATETF;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DATETF_Click;
				TextBox dATETF = _DATETF;
				if (dATETF != null)
				{
					dATETF.Click -= value2;
				}
				_DATETF = value;
				dATETF = _DATETF;
				if (dATETF != null)
				{
					dATETF.Click += value2;
				}
			}
		}

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button b_rechercher
		{
			[CompilerGenerated]
			get
			{
				return _b_rechercher;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = b_rechercher_Click;
				Button b_rechercher = _b_rechercher;
				if (b_rechercher != null)
				{
					b_rechercher.Click -= value2;
				}
				_b_rechercher = value;
				b_rechercher = _b_rechercher;
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

		public Histo_Vente()
		{
			base.Load += Histo_Vente_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Histo_Vente));
			GroupBox1 = new GroupBox();
			b_rechercher = new Button();
			Button22 = new Button();
			MonthCalendar2 = new MonthCalendar();
			DATETF = new TextBox();
			Label3 = new Label();
			Affich = new Button();
			MonthCalendar1 = new MonthCalendar();
			DATET = new TextBox();
			Label1 = new Label();
			NUMTICKET = new ComboBox();
			label2 = new Label();
			DGV1 = new DataGridView();
			GroupBox1.SuspendLayout();
			((ISupportInitialize)DGV1).BeginInit();
			base.SuspendLayout();
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(b_rechercher);
			GroupBox1.Controls.Add(Button22);
			GroupBox1.Controls.Add(MonthCalendar2);
			GroupBox1.Controls.Add(DATETF);
			GroupBox1.Controls.Add(Label3);
			GroupBox1.Controls.Add(Affich);
			GroupBox1.Controls.Add(MonthCalendar1);
			GroupBox1.Controls.Add(DATET);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(NUMTICKET);
			GroupBox1.Controls.Add(label2);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(78, 56);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(1123, 239);
			GroupBox1.TabIndex = 58;
			GroupBox1.TabStop = false;
			b_rechercher.BackColor = Color.Transparent;
			b_rechercher.Cursor = Cursors.Hand;
			b_rechercher.FlatStyle = FlatStyle.Flat;
			b_rechercher.ForeColor = Color.Transparent;
			b_rechercher.Image = (Image)componentResourceManager.GetObject("b_rechercher.Image");
			b_rechercher.Location = new Point(569, 140);
			b_rechercher.Name = "b_rechercher";
			b_rechercher.Size = new Size(143, 47);
			b_rechercher.TabIndex = 106;
			b_rechercher.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(192, 140);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 105;
			Button22.UseVisualStyleBackColor = false;
			MonthCalendar2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar2.Location = new Point(738, 71);
			MonthCalendar2.Name = "MonthCalendar2";
			MonthCalendar2.TabIndex = 62;
			MonthCalendar2.Visible = false;
			DATETF.Location = new Point(618, 71);
			DATETF.Name = "DATETF";
			DATETF.Size = new Size(120, 26);
			DATETF.TabIndex = 61;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.ForeColor = SystemColors.ActiveCaption;
			Label3.Location = new Point(549, 75);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(62, 18);
			Label3.TabIndex = 60;
			Label3.Text = "Date fin";
			Affich.BackColor = Color.CornflowerBlue;
			Affich.BackgroundImage = Resources.Deconnexion1;
			Affich.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Affich.ForeColor = SystemColors.ActiveCaptionText;
			Affich.Location = new Point(16, 199);
			Affich.Margin = new Padding(3, 4, 3, 4);
			Affich.Name = "Affich";
			Affich.Size = new Size(109, 37);
			Affich.TabIndex = 59;
			Affich.Text = "Afficher Tout";
			Affich.UseVisualStyleBackColor = false;
			MonthCalendar1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar1.Location = new Point(326, 72);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 58;
			MonthCalendar1.Visible = false;
			DATET.Location = new Point(206, 72);
			DATET.Name = "DATET";
			DATET.Size = new Size(120, 26);
			DATET.TabIndex = 57;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(114, 75);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(85, 18);
			Label1.TabIndex = 56;
			Label1.Text = "Date début";
			NUMTICKET.FormattingEnabled = true;
			NUMTICKET.Location = new Point(433, 25);
			NUMTICKET.Margin = new Padding(4, 3, 4, 3);
			NUMTICKET.Name = "NUMTICKET";
			NUMTICKET.Size = new Size(120, 26);
			NUMTICKET.TabIndex = 55;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(328, 28);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(97, 18);
			label2.TabIndex = 53;
			label2.Text = "Num Facture";
			DGV1.AllowUserToAddRows = false;
			DGV1.AllowUserToDeleteRows = false;
			DGV1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			DGV1.BackgroundColor = Color.White;
			DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV1.Location = new Point(78, 300);
			DGV1.Margin = new Padding(3, 4, 3, 4);
			DGV1.Name = "DGV1";
			DGV1.ReadOnly = true;
			DGV1.Size = new Size(1123, 363);
			DGV1.TabIndex = 57;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1354, 728);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(DGV1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Histo_Vente";
			Text = "Historique Vente";
			base.Controls.SetChildIndex(DGV1, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			((ISupportInitialize)DGV1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Histo_Vente_Load(object sender, EventArgs e)
		{
			try
			{
				DATETF.Text = DateTime.Now.ToShortDateString();
				string query = "select V.REFART,V.LIBART,V.PRIX_V,V.QTE,concat(V.REM,' %'),concat(V.TotalTTC_DF,' DT'),V.NUM_DF, V.NUM_FACT, T.DATE_FACT, T.IDCLIENT from " + TABLEDF + " V LEFT JOIN " + TABLEFACT + " T ON V.NUM_FACT=T.NUM_FACT";
				DGV1.DataSource = null;
				DGV1.Rows.Clear();
				Globals.LoadData(query, DGV1, TABLEDF);
				DataGridView dGV = DGV1;
				dGV.Columns[0].HeaderCell.Value = "Réf. Article";
				dGV.Columns[1].HeaderCell.Value = "Nom";
				dGV.Columns[2].HeaderCell.Value = "Prix";
				dGV.Columns[3].HeaderCell.Value = "Qté";
				dGV.Columns[4].HeaderCell.Value = "Remise";
				dGV.Columns[5].HeaderCell.Value = "Total";
				dGV.Columns[6].HeaderCell.Value = "Num Vente";
				dGV.Columns[7].HeaderCell.Value = "Num Facture";
				dGV.Columns[8].HeaderCell.Value = "Date Facture";
				dGV.Columns[9].HeaderCell.Value = "Client";
				dGV.Columns[0].Width = 140;
				dGV.Columns[1].Width = 240;
				dGV.Columns[2].Width = 100;
				dGV.Columns[3].Width = 60;
				dGV.Columns[4].Width = 60;
				dGV.Columns[5].Width = 120;
				dGV.Columns[7].Width = 110;
				dGV.Columns[8].Width = 130;
				dGV.Columns[9].Width = 100;
				dGV.Columns[6].Visible = false;
				dGV = null;
				int num = checked(DGV1.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						DGV1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						DGV1.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

		private void NUMTICKET_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = (("select distinct NUM_FACT from " + TABLEFACT) ?? "");
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				NUMTICKET.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						NUMTICKET.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void DATET_Click(object sender, EventArgs e)
		{
			MonthCalendar1.Visible = true;
			DATET.Text = "";
		}

		private void DATETF_Click(object sender, EventArgs e)
		{
			MonthCalendar2.Visible = true;
			DATETF.Text = "";
		}

		private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			DATET.Text = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
			MonthCalendar1.Visible = false;
			b_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void MonthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
		{
			DATETF.Text = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy");
			MonthCalendar2.Visible = false;
			b_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void NUMTICKET_SelectedIndexChanged(object sender, EventArgs e)
		{
			b_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Affich_Click(object sender, EventArgs e)
		{
			Histo_Vente_Load(RuntimeHelpers.GetObjectValue(sender), e);
			Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
			DATET.Text = "";
			DATETF.Text = "";
			NUMTICKET.Text = "";
		}

		public void b_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				DGV1.DataSource = null;
				DGV1.Rows.Clear();
				string query = (!(Operators.CompareString(DATET.Text, "", false) != 0 & Operators.CompareString(NUMTICKET.Text, "", false) != 0)) ? ((!(Operators.CompareString(DATET.Text, "", false) == 0 & Operators.CompareString(NUMTICKET.Text, "", false) != 0)) ? ((!(Operators.CompareString(DATET.Text, "", false) != 0 & Operators.CompareString(NUMTICKET.Text, "", false) == 0)) ? ("select V.REFART,V.LIBART,V.PRIX_V,V.QTE,concat(V.REM,' %'),concat(V.TotalTTC_DF,' DT'),V.NUM_DF, V.NUM_FACT, T.DATE_FACT, T.IDCLIENT from " + TABLEDF + " V LEFT JOIN " + TABLEFACT + " T ON V.NUM_FACT=T.NUM_FACT") : ("select V.REFART,V.LIBART,V.PRIX_V,V.QTE,concat(V.REM,' %'),concat(V.TotalTTC_DF,' DT'),V.NUM_DF, V.NUM_FACT, T.DATE_FACT, T.IDCLIENT from " + TABLEDF + " V LEFT JOIN " + TABLEFACT + " T ON V.NUM_FACT=T.NUM_FACT where DATE(T.DATE_FACT) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')")) : ("select V.REFART,V.LIBART,V.PRIX_V,V.QTE,concat(V.REM,' %'),concat(V.TotalTTC_DF,' DT'),V.NUM_DF, V.NUM_FACT, T.DATE_FACT, T.IDCLIENT from " + TABLEDF + " V LEFT JOIN " + TABLEFACT + " T ON V.NUM_FACT=T.NUM_FACT where V.NUM_FACT='" + NUMTICKET.Text + "'")) : ("select V.REFART,V.LIBART,V.PRIX_V,V.QTE,concat(V.REM,' %'),concat(V.TotalTTC_DF,' DT'),V.NUM_DF, V.NUM_FACT, T.DATE_FACT, T.IDCLIENT from " + TABLEDF + " V LEFT JOIN " + TABLEFACT + " T ON V.NUM_FACT=T.NUM_FACT where V.NUM_FACT='" + NUMTICKET.Text + "' AND DATE(T.DATE_FACT) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')");
				Globals.LoadData(query, DGV1, "Histo_Vente");
				DataGridView dGV = DGV1;
				dGV.Columns[0].HeaderCell.Value = "Réf. Article";
				dGV.Columns[1].HeaderCell.Value = "Nom";
				dGV.Columns[2].HeaderCell.Value = "Prix";
				dGV.Columns[3].HeaderCell.Value = "Qté";
				dGV.Columns[4].HeaderCell.Value = "Remise";
				dGV.Columns[5].HeaderCell.Value = "Total";
				dGV.Columns[6].HeaderCell.Value = "Num Vente";
				dGV.Columns[7].HeaderCell.Value = "Num Facture";
				dGV.Columns[8].HeaderCell.Value = "Date Facture";
				dGV.Columns[9].HeaderCell.Value = "Client";
				dGV.Columns[0].Width = 140;
				dGV.Columns[1].Width = 240;
				dGV.Columns[2].Width = 100;
				dGV.Columns[3].Width = 60;
				dGV.Columns[4].Width = 60;
				dGV.Columns[5].Width = 120;
				dGV.Columns[7].Width = 110;
				dGV.Columns[8].Width = 130;
				dGV.Columns[9].Width = 100;
				dGV.Columns[6].Visible = false;
				dGV = null;
				int num = checked(DGV1.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						DGV1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						DGV1.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearComboBox(this);
			Globals.ClearTextBox(this);
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}
	}
}
