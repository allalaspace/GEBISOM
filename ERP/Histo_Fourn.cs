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
	public class Histo_Fourn : Accueil
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
		[AccessedThroughProperty("OK")]
		private Button _OK;

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
		[AccessedThroughProperty("DGV2")]
		private DataGridView _DGV2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDFRS")]
		private ComboBox _IDFRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

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
		[AccessedThroughProperty("Affich")]
		private Button _Affich;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DATET")]
		private TextBox _DATET;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label2
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

		internal virtual DataGridView DGV2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox IDFRS
		{
			[CompilerGenerated]
			get
			{
				return _IDFRS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = IDFRS_KeyDown;
				EventHandler value3 = IDFRS_SelectedIndexChanged;
				EventHandler value4 = IDFRS_Validated;
				ComboBox iDFRS = _IDFRS;
				if (iDFRS != null)
				{
					iDFRS.KeyDown -= value2;
					iDFRS.SelectedIndexChanged -= value3;
					iDFRS.Validated -= value4;
				}
				_IDFRS = value;
				iDFRS = _IDFRS;
				if (iDFRS != null)
				{
					iDFRS.KeyDown += value2;
					iDFRS.SelectedIndexChanged += value3;
					iDFRS.Validated += value4;
				}
			}
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
				EventHandler value3 = DATET_TextChanged;
				TextBox dATET = _DATET;
				if (dATET != null)
				{
					dATET.Click -= value2;
					dATET.TextChanged -= value3;
				}
				_DATET = value;
				dATET = _DATET;
				if (dATET != null)
				{
					dATET.Click += value2;
					dATET.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label1
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

		public Histo_Fourn()
		{
			base.Load += Histo_Fourn_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Histo_Fourn));
			IDFRS = new ComboBox();
			GroupBox1 = new GroupBox();
			B_rechercher = new Button();
			Button22 = new Button();
			MonthCalendar2 = new MonthCalendar();
			DATETF = new TextBox();
			Label3 = new Label();
			Affich = new Button();
			MonthCalendar1 = new MonthCalendar();
			DATET = new TextBox();
			Label1 = new Label();
			Button5 = new Button();
			label2 = new Label();
			OK = new Button();
			total = new TextBox();
			Label14 = new Label();
			DGV2 = new DataGridView();
			GroupBox1.SuspendLayout();
			((ISupportInitialize)DGV2).BeginInit();
			base.SuspendLayout();
			IDFRS.AutoCompleteMode = AutoCompleteMode.Suggest;
			IDFRS.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDFRS.FormattingEnabled = true;
			IDFRS.Location = new Point(99, 31);
			IDFRS.Margin = new Padding(5, 4, 5, 4);
			IDFRS.Name = "IDFRS";
			IDFRS.Size = new Size(139, 26);
			IDFRS.TabIndex = 55;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Button22);
			GroupBox1.Controls.Add(MonthCalendar2);
			GroupBox1.Controls.Add(DATETF);
			GroupBox1.Controls.Add(Label3);
			GroupBox1.Controls.Add(Affich);
			GroupBox1.Controls.Add(MonthCalendar1);
			GroupBox1.Controls.Add(DATET);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(IDFRS);
			GroupBox1.Controls.Add(label2);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(14, 72);
			GroupBox1.Margin = new Padding(3, 4, 3, 4);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(3, 4, 3, 4);
			GroupBox1.Size = new Size(1220, 207);
			GroupBox1.TabIndex = 61;
			GroupBox1.TabStop = false;
			B_rechercher.BackColor = Color.Transparent;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.FlatStyle = FlatStyle.Flat;
			B_rechercher.ForeColor = Color.Transparent;
			B_rechercher.Image = (Image)componentResourceManager.GetObject("B_rechercher.Image");
			B_rechercher.Location = new Point(745, 153);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(143, 47);
			B_rechercher.TabIndex = 79;
			B_rechercher.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(319, 150);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 78;
			Button22.UseVisualStyleBackColor = false;
			MonthCalendar2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar2.Location = new Point(929, 35);
			MonthCalendar2.Name = "MonthCalendar2";
			MonthCalendar2.TabIndex = 70;
			MonthCalendar2.Visible = false;
			DATETF.Location = new Point(811, 35);
			DATETF.Name = "DATETF";
			DATETF.Size = new Size(120, 26);
			DATETF.TabIndex = 69;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.ForeColor = SystemColors.ActiveCaption;
			Label3.Location = new Point(742, 38);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(62, 18);
			Label3.TabIndex = 68;
			Label3.Text = "Date fin";
			Affich.BackColor = Color.CornflowerBlue;
			Affich.BackgroundImage = Resources.Deconnexion1;
			Affich.Cursor = Cursors.Hand;
			Affich.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Affich.ForeColor = SystemColors.ActiveCaptionText;
			Affich.Location = new Point(50, 162);
			Affich.Margin = new Padding(3, 4, 3, 4);
			Affich.Name = "Affich";
			Affich.Size = new Size(108, 37);
			Affich.TabIndex = 67;
			Affich.Text = "Afficher Tout";
			Affich.UseVisualStyleBackColor = false;
			MonthCalendar1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar1.Location = new Point(487, 32);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 66;
			MonthCalendar1.Visible = false;
			DATET.Location = new Point(367, 32);
			DATET.Name = "DATET";
			DATET.Size = new Size(120, 26);
			DATET.TabIndex = 65;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(275, 35);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(85, 18);
			Label1.TabIndex = 64;
			Label1.Text = "Date début";
			Button5.Location = new Point(223, 30);
			Button5.Margin = new Padding(3, 4, 3, 4);
			Button5.Name = "Button5";
			Button5.Size = new Size(30, 28);
			Button5.TabIndex = 56;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(22, 34);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(47, 18);
			label2.TabIndex = 53;
			label2.Text = "Code";
			OK.BackColor = Color.RoyalBlue;
			OK.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			OK.Location = new Point(569, 631);
			OK.Margin = new Padding(3, 5, 3, 5);
			OK.Name = "OK";
			OK.Size = new Size(159, 43);
			OK.TabIndex = 60;
			OK.Text = "OK";
			OK.UseVisualStyleBackColor = false;
			total.BackColor = Color.CornflowerBlue;
			total.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			total.Location = new Point(1003, 628);
			total.Margin = new Padding(3, 4, 3, 4);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(186, 29);
			total.TabIndex = 59;
			total.Text = "0.00";
			total.TextAlign = HorizontalAlignment.Center;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(846, 631);
			Label14.Name = "Label14";
			Label14.Size = new Size(124, 29);
			Label14.TabIndex = 58;
			Label14.Text = "Total Achat";
			DGV2.AllowUserToAddRows = false;
			DGV2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			DGV2.BackgroundColor = Color.White;
			DGV2.BorderStyle = BorderStyle.Fixed3D;
			DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV2.Location = new Point(14, 288);
			DGV2.Margin = new Padding(3, 5, 3, 5);
			DGV2.Name = "DGV2";
			DGV2.ReadOnly = true;
			DGV2.Size = new Size(1220, 326);
			DGV2.TabIndex = 57;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(OK);
			base.Controls.Add(DGV2);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(total);
			base.Controls.Add(Label14);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Histo_Fourn";
			Text = "Historique Fournisseur";
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(total, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(DGV2, 0);
			base.Controls.SetChildIndex(OK, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			((ISupportInitialize)DGV2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Histo_Fourn_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DATETF.Text = DateTime.Now.ToShortDateString();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.cmd.Connection = Globals.conn;
					string query = "select fournisseur,REFART,LIBART,quantite,PRIX_UE,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE from entree_stock";
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from entree_stock";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value) + " DT";
					DGV2.DataSource = null;
					DGV2.Rows.Clear();
					Globals.LoadData(query, DGV2, "Fourn");
					formatdgv(DGV2);
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct IDFRS from FOURN ";
					mySqlDataAdapter.Fill(dataSet, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["IDFRS"].ToString());
					}
					IDFRS.AutoCompleteSource = AutoCompleteSource.CustomSource;
					IDFRS.AutoCompleteCustomSource = autoCompleteStringCollection;
					IDFRS.AutoCompleteMode = AutoCompleteMode.Suggest;
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

		private void formatdgv(object dgv2)
		{
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Rows", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 0, false))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					0
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Fournisseur"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					1
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Réf. Article"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					2
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Lib. Article"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					3
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Qté"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					4
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Prix U."
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					5
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Date entrée"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					6
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Stock avant"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					7
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Stock après"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					8
				}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
				{
					"Type entrée"
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					0
				}, null, null, null), null, "Width", new object[1]
				{
					120
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					1
				}, null, null, null), null, "Width", new object[1]
				{
					140
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					2
				}, null, null, null), null, "Width", new object[1]
				{
					160
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					3
				}, null, null, null), null, "Width", new object[1]
				{
					100
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					4
				}, null, null, null), null, "Width", new object[1]
				{
					130
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					5
				}, null, null, null), null, "Width", new object[1]
				{
					120
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					6
				}, null, null, null), null, "Width", new object[1]
				{
					130
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					7
				}, null, null, null), null, "Width", new object[1]
				{
					130
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv2, null, "Columns", new object[1]
				{
					8
				}, null, null, null), null, "Width", new object[1]
				{
					130
				}, null, null, false, true);
				object obj = null;
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv2, null, "Rows", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1));
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						object[] obj2 = new object[1]
						{
							i
						};
						object[] array = obj2;
						bool[] obj3 = new bool[1]
						{
							true
						};
						bool[] array2 = obj3;
						object instance = NewLateBinding.LateGet(dgv2, null, "Rows", obj2, null, null, obj3);
						if (array2[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[1]
						{
							Color.LightBlue
						}, null, null, false, true);
					}
					else
					{
						object[] obj4 = new object[1]
						{
							i
						};
						object[] array = obj4;
						bool[] obj5 = new bool[1]
						{
							true
						};
						bool[] array2 = obj5;
						object instance = NewLateBinding.LateGet(dgv2, null, "Rows", obj4, null, null, obj5);
						if (array2[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[1]
						{
							Color.White
						}, null, null, false, true);
					}
				}
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Affich_ID_FRS.Show();
				string query = "select distinct IDFRS,NOMFRS from FOURN ";
				MyProject.Forms.Affich_ID_FRS.dgvF.DataSource = null;
				MyProject.Forms.Affich_ID_FRS.dgvF.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_ID_FRS.dgvF, "FOURN");
				DataGridView dgvF = MyProject.Forms.Affich_ID_FRS.dgvF;
				dgvF.Columns[0].HeaderCell.Value = "Id. Fournisseur";
				dgvF.Columns[1].HeaderCell.Value = "Nom Frs";
				dgvF.Columns[0].Width = 140;
				dgvF.Columns[1].Width = 240;
				dgvF = null;
				int num = checked(MyProject.Forms.Affich_ID_FRS.dgvF.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						MyProject.Forms.Affich_ID_FRS.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						MyProject.Forms.Affich_ID_FRS.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

		private void IDFRS_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		private void IDFRS_SelectedIndexChanged(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Affich_Click(object sender, EventArgs e)
		{
			Histo_Fourn_Load(RuntimeHelpers.GetObjectValue(sender), e);
			Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
			DATET.Text = "";
			DATETF.Text = "";
			IDFRS.Text = "";
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
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void MonthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
		{
			DATETF.Text = MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy");
			MonthCalendar2.Visible = false;
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void DATET_TextChanged(object sender, EventArgs e)
		{
		}

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				string query;
				if (Operators.CompareString(DATET.Text, "", false) != 0 & Operators.CompareString(IDFRS.Text, "", false) != 0)
				{
					query = "select fournisseur,REFART,LIBART,quantite,PRIX_UE,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE FROM ENTREE_STOCK where fournisseur='" + IDFRS.Text + "' AND DATE(date_entree) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from entree_stock where fournisseur='" + IDFRS.Text + "' AND DATE(date_entree) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value) + " DT";
				}
				else if (Operators.CompareString(DATET.Text, "", false) == 0 & Operators.CompareString(IDFRS.Text, "", false) != 0)
				{
					query = "select fournisseur,REFART,LIBART,quantite,PRIX_UE,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE FROM ENTREE_STOCK where fournisseur='" + IDFRS.Text + "'";
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from entree_stock where fournisseur='" + IDFRS.Text + "'";
					decimal value2 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value2) + " DT";
				}
				else if (Operators.CompareString(DATET.Text, "", false) != 0 & Operators.CompareString(IDFRS.Text, "", false) == 0)
				{
					query = "select fournisseur,REFART,LIBART,quantite,PRIX_UE,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE FROM ENTREE_STOCK where DATE(date_entree) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from entree_stock where DATE(date_entree) between STR_TO_DATE('" + DATET.Text + "', '%d/%m/%Y') AND  STR_TO_DATE('" + DATETF.Text + "', '%d/%m/%Y')";
					decimal value3 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value3) + " DT";
				}
				else
				{
					query = "select fournisseur,REFART,LIBART,quantite,PRIX_UE,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE FROM ENTREE_STOCK";
					Globals.cmd.CommandText = "select IFNULL(sum(quantite*PRIX_UE),0) from entree_stock";
					decimal value4 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					total.Text = Conversions.ToString(value4) + " DT";
				}
				DGV2.DataSource = null;
				DGV2.Rows.Clear();
				Globals.LoadData(query, DGV2, "FOURN");
				formatdgv(DGV2);
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

		private void IDFRS_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDFRS from FOURN where IDFRS ='" + IDFRS.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				IDFRS.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					IDFRS_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					MessageBox.Show("Ce Fournisseur n'existe pas!", "Fournisseur?");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
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
