using Microsoft.VisualBasic.CompilerServices;
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
	public class stat_CA : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

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
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CB_Article")]
		private CheckBox _CB_Article;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CB_Frs")]
		private CheckBox _CB_Frs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CB_Client")]
		private CheckBox _CB_Client;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Total_Achat")]
		private TextBox _Total_Achat;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		public string TABLEFACT;

		public string TABLEDF;

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual DataGridView dgv1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox CB_Article
		{
			[CompilerGenerated]
			get
			{
				return _CB_Article;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CB_Article_CheckedChanged;
				CheckBox cB_Article = _CB_Article;
				if (cB_Article != null)
				{
					cB_Article.CheckedChanged -= value2;
				}
				_CB_Article = value;
				cB_Article = _CB_Article;
				if (cB_Article != null)
				{
					cB_Article.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CB_Frs
		{
			[CompilerGenerated]
			get
			{
				return _CB_Frs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CB_Frs_CheckedChanged;
				CheckBox cB_Frs = _CB_Frs;
				if (cB_Frs != null)
				{
					cB_Frs.CheckedChanged -= value2;
				}
				_CB_Frs = value;
				cB_Frs = _CB_Frs;
				if (cB_Frs != null)
				{
					cB_Frs.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CB_Client
		{
			[CompilerGenerated]
			get
			{
				return _CB_Client;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CB_Client_CheckedChanged;
				CheckBox cB_Client = _CB_Client;
				if (cB_Client != null)
				{
					cB_Client.CheckedChanged -= value2;
				}
				_CB_Client = value;
				cB_Client = _CB_Client;
				if (cB_Client != null)
				{
					cB_Client.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox Total_Achat
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

		internal virtual GroupBox GroupBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public stat_CA()
		{
			base.Load += stat_CA_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(stat_CA));
			GroupBox1 = new GroupBox();
			B_rechercher = new Button();
			total = new TextBox();
			Label14 = new Label();
			MonthCalendar2 = new MonthCalendar();
			DATEFF = new TextBox();
			Label8 = new Label();
			MonthCalendar1 = new MonthCalendar();
			DATEF = new TextBox();
			Label1 = new Label();
			dgv1 = new DataGridView();
			CB_Article = new CheckBox();
			CB_Frs = new CheckBox();
			CB_Client = new CheckBox();
			Total_Achat = new TextBox();
			Label2 = new Label();
			GroupBox2 = new GroupBox();
			GroupBox1.SuspendLayout();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox2.SuspendLayout();
			base.SuspendLayout();
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(total);
			GroupBox1.Controls.Add(Label14);
			GroupBox1.Controls.Add(MonthCalendar2);
			GroupBox1.Controls.Add(DATEFF);
			GroupBox1.Controls.Add(Label8);
			GroupBox1.Controls.Add(MonthCalendar1);
			GroupBox1.Controls.Add(DATEF);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(43, 68);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(1042, 280);
			GroupBox1.TabIndex = 105;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "CA";
			B_rechercher.BackColor = Color.Transparent;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.FlatStyle = FlatStyle.Flat;
			B_rechercher.ForeColor = Color.Transparent;
			B_rechercher.Image = (Image)componentResourceManager.GetObject("B_rechercher.Image");
			B_rechercher.Location = new Point(55, 168);
			B_rechercher.Margin = new Padding(2, 3, 2, 3);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(146, 50);
			B_rechercher.TabIndex = 82;
			B_rechercher.UseVisualStyleBackColor = false;
			total.BackColor = Color.CornflowerBlue;
			total.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			total.Location = new Point(464, 239);
			total.Margin = new Padding(2, 4, 2, 4);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(222, 29);
			total.TabIndex = 81;
			total.Text = "0.00";
			total.TextAlign = HorizontalAlignment.Center;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(286, 242);
			Label14.Margin = new Padding(2, 0, 2, 0);
			Label14.Name = "Label14";
			Label14.Size = new Size(174, 26);
			Label14.TabIndex = 80;
			Label14.Text = "Chiffre d'affaire";
			MonthCalendar2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar2.Location = new Point(686, 31);
			MonthCalendar2.Name = "MonthCalendar2";
			MonthCalendar2.TabIndex = 79;
			MonthCalendar2.Visible = false;
			DATEFF.Location = new Point(566, 31);
			DATEFF.Name = "DATEFF";
			DATEFF.ReadOnly = true;
			DATEFF.Size = new Size(120, 26);
			DATEFF.TabIndex = 78;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(507, 34);
			Label8.Margin = new Padding(4, 0, 4, 0);
			Label8.Name = "Label8";
			Label8.Size = new Size(62, 18);
			Label8.TabIndex = 77;
			Label8.Text = "Date fin";
			MonthCalendar1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar1.Location = new Point(276, 29);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 76;
			MonthCalendar1.Visible = false;
			DATEF.Location = new Point(161, 28);
			DATEF.Name = "DATEF";
			DATEF.ReadOnly = true;
			DATEF.Size = new Size(120, 26);
			DATEF.TabIndex = 75;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(66, 31);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(88, 18);
			Label1.TabIndex = 74;
			Label1.Text = "Date Début";
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.BackgroundColor = Color.White;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(23, 23);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(1073, 271);
			dgv1.TabIndex = 106;
			CB_Article.AutoSize = true;
			CB_Article.BackColor = Color.Transparent;
			CB_Article.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CB_Article.Location = new Point(132, 358);
			CB_Article.Name = "CB_Article";
			CB_Article.Size = new Size(157, 27);
			CB_Article.TabIndex = 107;
			CB_Article.Text = "Top 10 Article";
			CB_Article.UseVisualStyleBackColor = false;
			CB_Frs.AutoSize = true;
			CB_Frs.BackColor = Color.Transparent;
			CB_Frs.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CB_Frs.Location = new Point(383, 358);
			CB_Frs.Name = "CB_Frs";
			CB_Frs.Size = new Size(211, 27);
			CB_Frs.TabIndex = 108;
			CB_Frs.Text = "Top 10 Fournisseur";
			CB_Frs.UseVisualStyleBackColor = false;
			CB_Client.AutoSize = true;
			CB_Client.BackColor = Color.Transparent;
			CB_Client.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CB_Client.Location = new Point(729, 358);
			CB_Client.Name = "CB_Client";
			CB_Client.Size = new Size(151, 27);
			CB_Client.TabIndex = 109;
			CB_Client.Text = "Top 10 Client";
			CB_Client.UseVisualStyleBackColor = false;
			Total_Achat.BackColor = Color.CornflowerBlue;
			Total_Achat.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Total_Achat.Location = new Point(1138, 649);
			Total_Achat.Margin = new Padding(3, 4, 3, 4);
			Total_Achat.Name = "Total_Achat";
			Total_Achat.ReadOnly = true;
			Total_Achat.Size = new Size(196, 29);
			Total_Achat.TabIndex = 111;
			Total_Achat.Text = "0.00";
			Total_Achat.TextAlign = HorizontalAlignment.Center;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(1184, 616);
			Label2.Name = "Label2";
			Label2.Size = new Size(124, 29);
			Label2.TabIndex = 110;
			Label2.Text = "Total Achat";
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.Controls.Add(dgv1);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox2.Location = new Point(12, 391);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(1102, 297);
			GroupBox2.TabIndex = 112;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Top 10";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(Total_Achat);
			base.Controls.Add(Label2);
			base.Controls.Add(CB_Client);
			base.Controls.Add(CB_Frs);
			base.Controls.Add(CB_Article);
			base.Controls.Add(GroupBox1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "stat_CA";
			Text = "Tableau de bord";
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(CB_Article, 0);
			base.Controls.SetChildIndex(CB_Frs, 0);
			base.Controls.SetChildIndex(CB_Client, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Total_Achat, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			((ISupportInitialize)dgv1).EndInit();
			GroupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void stat_CA_Load(object sender, EventArgs e)
		{
			TextBox dATEFF = DATEFF;
			DateTime dateTime = DateTime.Now;
			dATEFF.Text = dateTime.ToString("dd/MM/yyyy");
			TextBox dATEF = DATEF;
			dateTime = DateTime.Now;
			dateTime = dateTime.AddDays(-30.0);
			dATEF.Text = dateTime.ToString("dd/MM/yyyy");
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				TABLEFACT = "TICKET";
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				if (Operators.CompareString(DATEF.Text, "", false) != 0)
				{
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT + " where DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value) + " DT";
				}
				else
				{
					Globals.cmd.CommandText = (("select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT) ?? "");
					decimal value2 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value2) + " DT";
				}
				if (CB_Article.Checked)
				{
					CB_Article_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (CB_Frs.Checked)
				{
					CB_Frs_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (CB_Client.Checked)
				{
					CB_Client_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void CB_Article_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (CB_Article.Checked)
				{
					CB_Frs.Checked = false;
					CB_Client.Checked = false;
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.cmd.Connection = Globals.conn;
					string query = "SELECT T.REFART \"Ref. Article\", A.LIBART \"Lib. Article\", T.tot \"Total achat\" FROM (SELECT V.REFART, IFNULL(SUM(V.TotalTTC_DF),0) tot FROM VENTE V,TICKET T where V.NUM_FACT=T.NUM_FACT AND DATE(T.DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y') GROUP BY REFART ORDER BY tot DESC) T, ARTICLE_D A WHERE A.REFART=T.REFART LIMIT 10";
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
					Globals.LoadData(query, dgv1, "FACT");
					Globals.cmd.CommandText = "select IFNULL(sum(V.TotalTTC_DF),0) from VENTE V,TICKET T where V.NUM_FACT=T.NUM_FACT AND DATE(T.DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					Total_Achat.Text = Conversions.ToString(value) + " DT";
					formatDGV(dgv1);
				}
				else
				{
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
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

		public void formatDGV(DataGridView DGV1)
		{
			DGV1.Columns[0].Width = 300;
			DGV1.Columns[1].Width = 300;
			DGV1.Columns[2].Width = 200;
			DataGridView dataGridView = null;
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
		}

		private void CB_Client_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (CB_Client.Checked)
				{
					CB_Frs.Checked = false;
					CB_Article.Checked = false;
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.cmd.Connection = Globals.conn;
					string query = "SELECT T.IDCLIENT,c.NOM \"Nom Client\",T.tot \"Total achat\" FROM (SELECT IFNULL(T.IDCLIENT,'Client Passager') IDCLIENT, IFNULL(SUM(T.TOTALTTC_FACT),0) tot FROM TICKET T WHERE DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y') GROUP BY  IDCLIENT ORDER BY tot DESC) T ,Client c where c.IDCLIENT=T.IDCLIENT LIMIT 10";
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
					Globals.LoadData(query, dgv1, "T.Client");
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from TICKET where DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					Total_Achat.Text = Conversions.ToString(value) + " DT";
					formatDGV(dgv1);
				}
				else
				{
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
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

		private void CB_Frs_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (CB_Frs.Checked)
				{
					CB_Client.Checked = false;
					CB_Article.Checked = false;
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.cmd.Connection = Globals.conn;
					string query = "SELECT E.IDFRS, F.NOMFRS \"Nom Frs\", E.tot \"Total achat\" FROM (SELECT IFNULL(fournisseur,'Non assigné') IDFRS, IFNULL(SUM(quantite*PRIX_UE),0) tot FROM ENTREE_STOCK where DATE(date_entree) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y') GROUP BY fournisseur ORDER BY tot DESC) E, FOURN F WHERE F.IDFRS=E.IDFRS LIMIT 10";
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
					Globals.LoadData(query, dgv1, "FRS");
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from ENTREE_STOCK where DATE(date_entree) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					Total_Achat.Text = Conversions.ToString(value) + " DT";
					formatDGV(dgv1);
				}
				else
				{
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
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
