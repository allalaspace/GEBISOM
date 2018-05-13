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
	public class Histo_Fact : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

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
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

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
		[AccessedThroughProperty("DATEFF")]
		private TextBox _DATEFF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

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
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_DA_BCA")]
		private Button _B_DA_BCA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_BC_BL")]
		private Button _B_BC_BL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_BL_Fact")]
		private Button _B_BL_Fact;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_BC_ES")]
		private Button _B_BC_ES;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Reg_Multi")]
		private Button _Reg_Multi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NUMFACTURE")]
		private ComboBox _NUMFACTURE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		public string TABLEFACT;

		public string TABLEDF;

		public int NUM_TICK;

		public int NUM_VENTE;

		public int NUM_DF;

		public int COD_S;

		public string REFART;

		public string LIBART;

		public string IDCLIENT;

		public string REGLEMENT0;

		public int NUMFACT_REG;

		internal virtual GroupBox GroupBox1
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
				EventHandler value3 = DATEF_Validated;
				TextBox dATEF = _DATEF;
				if (dATEF != null)
				{
					dATEF.Click -= value2;
					dATEF.Validated -= value3;
				}
				_DATEF = value;
				dATEF = _DATEF;
				if (dATEF != null)
				{
					dATEF.Click += value2;
					dATEF.Validated += value3;
				}
			}
		}

		internal virtual Label Label1
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

		internal virtual DataGridView DGV1
		{
			[CompilerGenerated]
			get
			{
				return _DGV1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = DGV1_CellContentDoubleClick;
				EventHandler value3 = DGV1_DoubleClick;
				DataGridView dGV = _DGV1;
				if (dGV != null)
				{
					dGV.CellContentDoubleClick -= value2;
					dGV.DoubleClick -= value3;
				}
				_DGV1 = value;
				dGV = _DGV1;
				if (dGV != null)
				{
					dGV.CellContentDoubleClick += value2;
					dGV.DoubleClick += value3;
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

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Label Label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return _Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button2_Click;
				Button button = _Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button2 = value;
				button = _Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return _Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button4_Click;
				Button button = _Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button4 = value;
				button = _Button4;
				if (button != null)
				{
					button.Click += value2;
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
				EventHandler value3 = DATEFF_Validated;
				TextBox dATEFF = _DATEFF;
				if (dATEFF != null)
				{
					dATEFF.Click -= value2;
					dATEFF.Validated -= value3;
				}
				_DATEFF = value;
				dATEFF = _DATEFF;
				if (dATEFF != null)
				{
					dATEFF.Click += value2;
					dATEFF.Validated += value3;
				}
			}
		}

		internal virtual Label Label8
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

		internal virtual Label Label9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_DA_BCA
		{
			[CompilerGenerated]
			get
			{
				return _B_DA_BCA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_DA_BCA_Click;
				Button b_DA_BCA = _B_DA_BCA;
				if (b_DA_BCA != null)
				{
					b_DA_BCA.Click -= value2;
				}
				_B_DA_BCA = value;
				b_DA_BCA = _B_DA_BCA;
				if (b_DA_BCA != null)
				{
					b_DA_BCA.Click += value2;
				}
			}
		}

		internal virtual Button B_BC_BL
		{
			[CompilerGenerated]
			get
			{
				return _B_BC_BL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_BC_BL_Click;
				Button b_BC_BL = _B_BC_BL;
				if (b_BC_BL != null)
				{
					b_BC_BL.Click -= value2;
				}
				_B_BC_BL = value;
				b_BC_BL = _B_BC_BL;
				if (b_BC_BL != null)
				{
					b_BC_BL.Click += value2;
				}
			}
		}

		internal virtual Label Label10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label11
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_BL_Fact
		{
			[CompilerGenerated]
			get
			{
				return _B_BL_Fact;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_BL_Fact_Click;
				Button b_BL_Fact = _B_BL_Fact;
				if (b_BL_Fact != null)
				{
					b_BL_Fact.Click -= value2;
				}
				_B_BL_Fact = value;
				b_BL_Fact = _B_BL_Fact;
				if (b_BL_Fact != null)
				{
					b_BL_Fact.Click += value2;
				}
			}
		}

		internal virtual Label Label12
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_BC_ES
		{
			[CompilerGenerated]
			get
			{
				return _B_BC_ES;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_BC_ES_Click;
				Button b_BC_ES = _B_BC_ES;
				if (b_BC_ES != null)
				{
					b_BC_ES.Click -= value2;
				}
				_B_BC_ES = value;
				b_BC_ES = _B_BC_ES;
				if (b_BC_ES != null)
				{
					b_BC_ES.Click += value2;
				}
			}
		}

		internal virtual Button Reg_Multi
		{
			[CompilerGenerated]
			get
			{
				return _Reg_Multi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Reg_Multi_Click;
				Button reg_Multi = _Reg_Multi;
				if (reg_Multi != null)
				{
					reg_Multi.Click -= value2;
				}
				_Reg_Multi = value;
				reg_Multi = _Reg_Multi;
				if (reg_Multi != null)
				{
					reg_Multi.Click += value2;
				}
			}
		}

        internal virtual ComboBox NUMFACTURE
		{
			[CompilerGenerated]
			get
			{
				return _NUMFACTURE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = NUMFACTURE_Click;
				EventHandler value3 = NUMFACTURE_SelectedIndexChanged;
				ComboBox nUMFACTURE = _NUMFACTURE;
				if (nUMFACTURE != null)
				{
					nUMFACTURE.Click -= value2;
					nUMFACTURE.SelectedIndexChanged -= value3;
				}
				_NUMFACTURE = value;
				nUMFACTURE = _NUMFACTURE;
				if (nUMFACTURE != null)
				{
					nUMFACTURE.Click += value2;
					nUMFACTURE.SelectedIndexChanged += value3;
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

		public Histo_Fact()
		{
			base.Load += Histo_Fact_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Histo_Fact));
			GroupBox1 = new GroupBox();
			Label12 = new Label();
			Label11 = new Label();
			B_BC_BL = new Button();
			B_BC_ES = new Button();
			Label10 = new Label();
			B_BL_Fact = new Button();
			Label9 = new Label();
			B_rechercher = new Button();
			Button22 = new Button();
			B_DA_BCA = new Button();
			MonthCalendar2 = new MonthCalendar();
			DATEFF = new TextBox();
			Label8 = new Label();
			Label6 = new Label();
			Affich = new Button();
			MonthCalendar1 = new MonthCalendar();
			Button4 = new Button();
			Label5 = new Label();
			DATEF = new TextBox();
			Label1 = new Label();
			Button3 = new Button();
			NUMFACTURE = new ComboBox();
			label2 = new Label();
			Button2 = new Button();
			Label4 = new Label();
			Button1 = new Button();
			DGV1 = new DataGridView();
			Button5 = new Button();
			total = new TextBox();
			Label14 = new Label();
			Reg_Multi = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			GroupBox1.SuspendLayout();
			((ISupportInitialize)DGV1).BeginInit();
			base.SuspendLayout();
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(Label12);
			GroupBox1.Controls.Add(Label11);
			GroupBox1.Controls.Add(B_BC_BL);
			GroupBox1.Controls.Add(B_BC_ES);
			GroupBox1.Controls.Add(Label10);
			GroupBox1.Controls.Add(B_BL_Fact);
			GroupBox1.Controls.Add(Label9);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Button22);
			GroupBox1.Controls.Add(B_DA_BCA);
			GroupBox1.Controls.Add(MonthCalendar2);
			GroupBox1.Controls.Add(DATEFF);
			GroupBox1.Controls.Add(Label8);
			GroupBox1.Controls.Add(Label6);
			GroupBox1.Controls.Add(Affich);
			GroupBox1.Controls.Add(MonthCalendar1);
			GroupBox1.Controls.Add(Button4);
			GroupBox1.Controls.Add(Label5);
			GroupBox1.Controls.Add(DATEF);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Button3);
			GroupBox1.Controls.Add(NUMFACTURE);
			GroupBox1.Controls.Add(label2);
			GroupBox1.Controls.Add(Button2);
			GroupBox1.Controls.Add(Label4);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(22, 70);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(1203, 239);
			GroupBox1.TabIndex = 60;
			GroupBox1.TabStop = false;
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label12.Location = new Point(1014, 213);
			Label12.Name = "Label12";
			Label12.Size = new Size(189, 16);
			Label12.TabIndex = 85;
			Label12.Text = "Bon cde--> Entrée stock total";
			Label12.Visible = false;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label11.Location = new Point(1021, 213);
			Label11.Name = "Label11";
			Label11.Size = new Size(183, 16);
			Label11.TabIndex = 83;
			Label11.Text = "Bon de livraison --> Facture";
			Label11.Visible = false;
			B_BC_BL.BackgroundImage = (Image)componentResourceManager.GetObject("B_BC_BL.BackgroundImage");
			B_BC_BL.Cursor = Cursors.Hand;
			B_BC_BL.Location = new Point(1057, 26);
			B_BC_BL.Margin = new Padding(3, 4, 3, 4);
			B_BC_BL.Name = "B_BC_BL";
			B_BC_BL.Size = new Size(110, 75);
			B_BC_BL.TabIndex = 80;
			B_BC_BL.UseVisualStyleBackColor = true;
			B_BC_BL.Visible = false;
			B_BC_ES.BackgroundImage = (Image)componentResourceManager.GetObject("B_BC_ES.BackgroundImage");
			B_BC_ES.Cursor = Cursors.Hand;
			B_BC_ES.Location = new Point(1056, 137);
			B_BC_ES.Margin = new Padding(3, 4, 3, 4);
			B_BC_ES.Name = "B_BC_ES";
			B_BC_ES.Size = new Size(110, 75);
			B_BC_ES.TabIndex = 84;
			B_BC_ES.UseVisualStyleBackColor = true;
			B_BC_ES.Visible = false;
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label10.Location = new Point(996, 105);
			Label10.Name = "Label10";
			Label10.Size = new Size(207, 16);
			Label10.TabIndex = 81;
			Label10.Text = "Bon de cde --> Bon de livraison";
			Label10.Visible = false;
			B_BL_Fact.BackgroundImage = (Image)componentResourceManager.GetObject("B_BL_Fact.BackgroundImage");
			B_BL_Fact.Cursor = Cursors.Hand;
			B_BL_Fact.Location = new Point(1057, 134);
			B_BL_Fact.Margin = new Padding(3, 4, 3, 4);
			B_BL_Fact.Name = "B_BL_Fact";
			B_BL_Fact.Size = new Size(110, 75);
			B_BL_Fact.TabIndex = 82;
			B_BL_Fact.UseVisualStyleBackColor = true;
			B_BL_Fact.Visible = false;
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label9.Location = new Point(1034, 216);
			Label9.Name = "Label9";
			Label9.Size = new Size(164, 16);
			Label9.TabIndex = 79;
			Label9.Text = "Devis.A --> Bon de cde.A";
			Label9.Visible = false;
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
			Button22.Location = new Point(197, 147);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 76;
			Button22.UseVisualStyleBackColor = false;
			B_DA_BCA.BackgroundImage = (Image)componentResourceManager.GetObject("B_DA_BCA.BackgroundImage");
			B_DA_BCA.Cursor = Cursors.Hand;
			B_DA_BCA.Location = new Point(1056, 137);
			B_DA_BCA.Margin = new Padding(3, 4, 3, 4);
			B_DA_BCA.Name = "B_DA_BCA";
			B_DA_BCA.Size = new Size(110, 75);
			B_DA_BCA.TabIndex = 78;
			B_DA_BCA.UseVisualStyleBackColor = true;
			B_DA_BCA.Visible = false;
			MonthCalendar2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar2.Location = new Point(756, 68);
			MonthCalendar2.Name = "MonthCalendar2";
			MonthCalendar2.TabIndex = 73;
			MonthCalendar2.Visible = false;
			DATEFF.Location = new Point(636, 68);
			DATEFF.Name = "DATEFF";
			DATEFF.Size = new Size(120, 26);
			DATEFF.TabIndex = 72;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(567, 71);
			Label8.Margin = new Padding(4, 0, 4, 0);
			Label8.Name = "Label8";
			Label8.Size = new Size(62, 18);
			Label8.TabIndex = 71;
			Label8.Text = "Date fin";
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label6.Location = new Point(1054, 216);
			Label6.Name = "Label6";
			Label6.Size = new Size(142, 16);
			Label6.TabIndex = 67;
			Label6.Text = "Devis --> Bon de c.de";
			Label6.Visible = false;
			Affich.BackColor = Color.CornflowerBlue;
			Affich.BackgroundImage = Resources.Deconnexion1;
			Affich.Cursor = Cursors.Hand;
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
			MonthCalendar1.Location = new Point(336, 68);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 58;
			MonthCalendar1.Visible = false;
			Button4.BackgroundImage = (Image)componentResourceManager.GetObject("Button4.BackgroundImage");
			Button4.Cursor = Cursors.Hand;
			Button4.Location = new Point(1057, 140);
			Button4.Margin = new Padding(3, 4, 3, 4);
			Button4.Name = "Button4";
			Button4.Size = new Size(110, 75);
			Button4.TabIndex = 66;
			Button4.UseVisualStyleBackColor = true;
			Button4.Visible = false;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(1030, 219);
			Label5.Name = "Label5";
			Label5.Size = new Size(158, 16);
			Label5.TabIndex = 65;
			Label5.Text = "Bon de C.de --> Facture";
			Label5.Visible = false;
			DATEF.Location = new Point(216, 68);
			DATEF.Name = "DATEF";
			DATEF.Size = new Size(120, 26);
			DATEF.TabIndex = 57;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(121, 71);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(88, 18);
			Label1.TabIndex = 56;
			Label1.Text = "Date Début";
			Button3.BackgroundImage = (Image)componentResourceManager.GetObject("Button3.BackgroundImage");
			Button3.Cursor = Cursors.Hand;
			Button3.Location = new Point(1057, 140);
			Button3.Margin = new Padding(3, 4, 3, 4);
			Button3.Name = "Button3";
			Button3.Size = new Size(110, 75);
			Button3.TabIndex = 64;
			Button3.UseVisualStyleBackColor = true;
			Button3.Visible = false;
			NUMFACTURE.FormattingEnabled = true;
			NUMFACTURE.Location = new Point(449, 30);
			NUMFACTURE.Margin = new Padding(4, 3, 4, 3);
			NUMFACTURE.Name = "NUMFACTURE";
			NUMFACTURE.Size = new Size(120, 26);
			NUMFACTURE.TabIndex = 55;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(344, 33);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(97, 18);
			label2.TabIndex = 53;
			label2.Text = "Num Facture";
			Button2.BackgroundImage = (Image)componentResourceManager.GetObject("Button2.BackgroundImage");
			Button2.Cursor = Cursors.Hand;
			Button2.Location = new Point(1057, 26);
			Button2.Margin = new Padding(3, 4, 3, 4);
			Button2.Name = "Button2";
			Button2.Size = new Size(110, 75);
			Button2.TabIndex = 62;
			Button2.UseVisualStyleBackColor = true;
			Button2.Visible = false;
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(1053, 105);
			Label4.Name = "Label4";
			Label4.Size = new Size(114, 16);
			Label4.TabIndex = 63;
			Label4.Text = "Devis --> Facture";
			Label4.Visible = false;
			Button1.BackColor = SystemColors.ButtonHighlight;
			Button1.Cursor = Cursors.Hand;
			Button1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.Image = Resources.facture_48_48;
			Button1.ImageAlign = ContentAlignment.MiddleLeft;
			Button1.Location = new Point(1197, 461);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(134, 51);
			Button1.TabIndex = 60;
			Button1.Text = "Imprimer";
			Button1.TextAlign = ContentAlignment.MiddleRight;
			Button1.UseVisualStyleBackColor = false;
			DGV1.AllowUserToAddRows = false;
			DGV1.AllowUserToDeleteRows = false;
			DGV1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			DGV1.BackgroundColor = Color.White;
			DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV1.Location = new Point(22, 316);
			DGV1.Margin = new Padding(3, 4, 3, 4);
			DGV1.Name = "DGV1";
			DGV1.ReadOnly = true;
			DGV1.Size = new Size(1134, 361);
			DGV1.TabIndex = 59;
			Button5.BackColor = SystemColors.ButtonHighlight;
			Button5.Cursor = Cursors.Hand;
			Button5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button5.Image = Resources.add_1_icon;
			Button5.ImageAlign = ContentAlignment.MiddleLeft;
			Button5.Location = new Point(1197, 520);
			Button5.Margin = new Padding(3, 4, 3, 4);
			Button5.Name = "Button5";
			Button5.Size = new Size(134, 46);
			Button5.TabIndex = 61;
			Button5.Text = "Details";
			Button5.TextAlign = ContentAlignment.MiddleRight;
			Button5.UseVisualStyleBackColor = false;
			total.BackColor = Color.CornflowerBlue;
			total.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			total.Location = new Point(1162, 648);
			total.Margin = new Padding(3, 4, 3, 4);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(196, 29);
			total.TabIndex = 64;
			total.Text = "0.00";
			total.TextAlign = HorizontalAlignment.Center;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(1207, 625);
			Label14.Name = "Label14";
			Label14.Size = new Size(124, 19);
			Label14.TabIndex = 63;
			Label14.Text = "Total Achat";
			Reg_Multi.BackColor = Color.White;
			Reg_Multi.BackgroundImageLayout = ImageLayout.Center;
			Reg_Multi.Cursor = Cursors.Hand;
			Reg_Multi.FlatStyle = FlatStyle.Flat;
			Reg_Multi.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Reg_Multi.ForeColor = Color.Black;
			Reg_Multi.Image = Resources.monnaie;
			Reg_Multi.ImageAlign = ContentAlignment.MiddleLeft;
			Reg_Multi.Location = new Point(1197, 345);
			Reg_Multi.Name = "Reg_Multi";
			Reg_Multi.Size = new Size(134, 48);
			Reg_Multi.TabIndex = 109;
			Reg_Multi.TabStop = false;
			Reg_Multi.Text = "Règlement";
			Reg_Multi.TextAlign = ContentAlignment.MiddleRight;
			Reg_Multi.UseVisualStyleBackColor = false;
			Reg_Multi.Visible = false;
			btnUpdate.BackColor = Color.White;
			btnUpdate.Cursor = Cursors.Hand;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.Image = Resources.edit_file_icon;
			btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdate.Location = new Point(1197, 405);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(134, 48);
			btnUpdate.TabIndex = 111;
			btnUpdate.Text = "Modifier";
			btnUpdate.TextAlign = ContentAlignment.MiddleRight;
			btnUpdate.UseVisualStyleBackColor = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(1197, 574);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(134, 42);
			btnDelete.TabIndex = 112;
			btnDelete.Text = "Supprimer";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(btnDelete);
			base.Controls.Add(btnUpdate);
			base.Controls.Add(Reg_Multi);
			base.Controls.Add(total);
			base.Controls.Add(Label14);
			base.Controls.Add(Button5);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(DGV1);
			base.Controls.Add(Button1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Histo_Fact";
			Text = "Histo_Fact";
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(DGV1, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(total, 0);
			base.Controls.SetChildIndex(Reg_Multi, 0);
			base.Controls.SetChildIndex(btnUpdate, 0);
			base.Controls.SetChildIndex(btnDelete, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			((ISupportInitialize)DGV1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Histo_Fact_Load(object sender, EventArgs e)
		{
			try
			{
				DATEFF.Text = DateTime.Now.ToShortDateString();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				string query = "select NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, round(TOTALTTC_FACT,3),REMISE,TIMBRE, " + REGLEMENT0 + " from " + TABLEFACT + " group by NUM_FACT desc";
				DGV1.DataSource = null;
				DGV1.Rows.Clear();
				Globals.LoadData(query, DGV1, "FACT");
				Globals.cmd.CommandText = (("select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT) ?? "");
				decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
				total.Text = Conversions.ToString(value) + " DT";
				DataGridView dGV = DGV1;
				dGV.Columns[0].HeaderCell.Value = "Num. Facture";
				dGV.Columns[1].HeaderCell.Value = "Date Facture";
				dGV.Columns[2].HeaderCell.Value = "Client";
				dGV.Columns[3].HeaderCell.Value = "Vendeur";
				dGV.Columns[4].HeaderCell.Value = "Total Facture";
				dGV.Columns[5].HeaderCell.Value = "Remise";
				dGV.Columns[6].HeaderCell.Value = "Timbre";
				dGV.Columns[0].Width = 100;
				dGV.Columns[1].Width = 120;
				dGV.Columns[2].Width = 230;
				dGV.Columns[3].Width = 136;
				dGV.Columns[4].Width = 130;
				dGV.Columns[5].Width = 60;
				dGV.Columns[6].Width = 60;
				dGV = null;
				if (Operators.ConditionalCompareObjectEqual(DGV1.Columns[7].HeaderCell.Value, "R", false))
				{
					DGV1.Columns[7].Visible = false;
				}
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

		private void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				string query;
				if (Operators.CompareString(DATEF.Text, "", false) != 0 & Operators.CompareString(NUMFACTURE.Text, "", false) != 0)
				{
					query = "select NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, round(TOTALTTC_FACT,3),REMISE,TIMBRE, " + REGLEMENT0 + " from " + TABLEFACT + " where NUM_FACT='" + NUMFACTURE.Text + "' AND DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT + " where NUM_FACT='" + NUMFACTURE.Text + "' AND DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value) + " DT";
				}
				else if (Operators.CompareString(DATEF.Text, "", false) == 0 & Operators.CompareString(NUMFACTURE.Text, "", false) != 0)
				{
					query = "select NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, round(TOTALTTC_FACT,3),REMISE,TIMBRE,  " + REGLEMENT0 + " from " + TABLEFACT + " where  NUM_FACT='" + NUMFACTURE.Text + "'";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT + " where  NUM_FACT='" + NUMFACTURE.Text + "'";
					decimal value2 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value2) + " DT";
				}
				else if (Operators.CompareString(DATEF.Text, "", false) != 0 & Operators.CompareString(NUMFACTURE.Text, "", false) == 0)
				{
					query = "select NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, round(TOTALTTC_FACT,3),REMISE,TIMBRE, " + REGLEMENT0 + " from " + TABLEFACT + " where DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					Globals.cmd.CommandText = "select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT + " where DATE(DATE_FACT) between STR_TO_DATE('" + DATEF.Text + "', '%d/%m/%Y') AND STR_TO_DATE('" + DATEFF.Text + "', '%d/%m/%Y')";
					decimal value3 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value3) + " DT";
				}
				else
				{
					query = (("select NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, round(TOTALTTC_FACT,3),REMISE,TIMBRE, " + REGLEMENT0 + " from " + TABLEFACT) ?? "");
					Globals.cmd.CommandText = (("select IFNULL(sum(TOTALTTC_FACT),0) from " + TABLEFACT) ?? "");
					decimal value4 = Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
					total.Text = Conversions.ToString(value4) + " DT";
				}
				DGV1.DataSource = null;
				DGV1.Rows.Clear();
				Globals.LoadData(query, DGV1, "Fact");
				DataGridView dGV = DGV1;
				dGV.Columns[0].HeaderCell.Value = "Num. Facture";
				dGV.Columns[1].HeaderCell.Value = "Date Facture";
				dGV.Columns[2].HeaderCell.Value = "Client";
				dGV.Columns[3].HeaderCell.Value = "Vendeur";
				dGV.Columns[4].HeaderCell.Value = "Total Facture";
				dGV.Columns[5].HeaderCell.Value = "Remise";
				dGV.Columns[6].HeaderCell.Value = "Timbre";
				dGV.Columns[0].Width = 100;
				dGV.Columns[1].Width = 120;
				dGV.Columns[2].Width = 230;
				dGV.Columns[3].Width = 136;
				dGV.Columns[4].Width = 130;
				dGV.Columns[5].Width = 60;
				dGV.Columns[6].Width = 60;
				dGV = null;
				if (Operators.ConditionalCompareObjectEqual(DGV1.Columns[7].HeaderCell.Value, "R", false))
				{
					DGV1.Columns[7].Visible = false;
				}
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

		private void NUMFACTURE_Click(object sender, EventArgs e)
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
				NUMFACTURE.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						NUMFACTURE.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Globals.conn.Close();
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

		private void Affich_Click(object sender, EventArgs e)
		{
			Histo_Fact_Load(RuntimeHelpers.GetObjectValue(sender), e);
			Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
			DATEF.Text = "";
			NUMFACTURE.Text = "";
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(TABLEFACT, "TICKET", false) == 0)
			{
				Frm_Fact frm_Fact = new Frm_Fact();
				frm_Fact.TYPEFACT = "F";
				frm_Fact.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact.PARAMFACT = "NUMTICKET";
				frm_Fact.TABLEFACT = "TICKET";
				frm_Fact.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_Facture.rpt";
				frm_Fact.Label1.Text = "Entrer Num Facture";
				frm_Fact.Button1.Text = "Afficher Facture";
				frm_Fact.Text = "Facture";
				frm_Fact.Nommail = "Facture";
				frm_Fact.Show();
				frm_Fact.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "DEVIS", false) == 0)
			{
				Frm_Fact frm_Fact2 = new Frm_Fact();
				frm_Fact2.TYPEFACT = "D";
				frm_Fact2.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact2.PARAMFACT = "NUMDEVIS";
				frm_Fact2.TABLEFACT = "DEVIS";
				frm_Fact2.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_Devis.rpt";
				frm_Fact2.Label1.Text = "Entrer Num Devis";
				frm_Fact2.Button1.Text = "Afficher Devis";
				frm_Fact2.Text = "Devis";
				frm_Fact2.Nommail = "Devis";
				frm_Fact2.Show();
				frm_Fact2.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "BONC", false) == 0)
			{
				Frm_Fact frm_Fact3 = new Frm_Fact();
				frm_Fact3.TYPEFACT = "BC";
				frm_Fact3.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact3.PARAMFACT = "NUMBC";
				frm_Fact3.TABLEFACT = "BONC";
				frm_Fact3.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_BC.rpt";
				frm_Fact3.Label1.Text = "Entrer Num Bon C.";
				frm_Fact3.Button1.Text = "Afficher Bon C.";
				frm_Fact3.Text = "Bon Commande";
				frm_Fact3.Nommail = "BC";
				frm_Fact3.Show();
				frm_Fact3.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "BONL", false) == 0)
			{
				Frm_Fact frm_Fact4 = new Frm_Fact();
				frm_Fact4.TYPEFACT = "BL";
				frm_Fact4.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact4.PARAMFACT = "NUMBL";
				frm_Fact4.TABLEFACT = "BONL";
				frm_Fact4.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_BL.rpt";
				frm_Fact4.Label1.Text = "Entrer Num Bon L.";
				frm_Fact4.Button1.Text = "Afficher Bon L.";
				frm_Fact4.Text = "Bon livraison";
				frm_Fact4.Nommail = "BL";
				frm_Fact4.Show();
				frm_Fact4.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "A_FACTURE", false) == 0)
			{
				Frm_Fact frm_Fact5 = new Frm_Fact();
				frm_Fact5.TYPEFACT = "FA";
				frm_Fact5.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact5.PARAMFACT = "NUMFACT";
				frm_Fact5.TABLEFACT = "A_FACTURE";
				frm_Fact5.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_Facture.rpt";
				frm_Fact5.Label1.Text = "Entrer Num Facture";
				frm_Fact5.Button1.Text = "Afficher Facture";
				frm_Fact5.Text = "Facture Achat";
				frm_Fact5.Nommail = "Facture Achat";
				frm_Fact5.Show();
				frm_Fact5.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "A_DEVIS", false) == 0)
			{
				Frm_Fact frm_Fact6 = new Frm_Fact();
				frm_Fact6.TYPEFACT = "DA";
				frm_Fact6.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact6.PARAMFACT = "NUMDEVIS";
				frm_Fact6.TABLEFACT = "A_DEVIS";
				frm_Fact6.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_Devis.rpt";
				frm_Fact6.Label1.Text = "Entrer Num Devis";
				frm_Fact6.Button1.Text = "Afficher Devis";
				frm_Fact6.Text = "Devis Achat";
				frm_Fact6.Nommail = "Devis Achat";
				frm_Fact6.Show();
				frm_Fact6.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "A_BONC", false) == 0)
			{
				Frm_Fact frm_Fact7 = new Frm_Fact();
				frm_Fact7.TYPEFACT = "BCA";
				frm_Fact7.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact7.PARAMFACT = "NUMBONC";
				frm_Fact7.TABLEFACT = "A_BONC";
				frm_Fact7.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_BONC.rpt";
				frm_Fact7.Label1.Text = "Entrer Num Bon C.de";
				frm_Fact7.Button1.Text = "Afficher Bon C.de";
				frm_Fact7.Text = "Bon de Commande Achat";
				frm_Fact7.Nommail = "BC Achat";
				frm_Fact7.Show();
				frm_Fact7.BringToFront();
			}
			else if (Operators.CompareString(TABLEFACT, "A_BONL", false) == 0)
			{
				Frm_Fact frm_Fact8 = new Frm_Fact();
				frm_Fact8.TYPEFACT = "BLA";
				frm_Fact8.NUMFACT.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
				frm_Fact8.PARAMFACT = "NUMBONL";
				frm_Fact8.TABLEFACT = "A_BONL";
				frm_Fact8.CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_BONL.rpt";
				frm_Fact8.Label1.Text = "Entrer Num Bon L.";
				frm_Fact8.Button1.Text = "Afficher Bon L.";
				frm_Fact8.Text = "Bon de livraison Achat";
				frm_Fact8.Nommail = "BL Achat";
				frm_Fact8.Show();
				frm_Fact8.BringToFront();
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			transfert_Fact("DEVIS", "DETAIL_DEVIS", "TICKET", "VENTE", "Devis transformé en Facture", 1);
		}

		private void transfert_Fact(string TABLE_EF, string TABLE_EDF, string TABLE_SF, string TABLE_SDF, string messgeBox, int flag_Fact)
		{
			checked
			{
				try
				{
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					string text = ("select * from " + TABLE_SDF) ?? "";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
					MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					int num = dataTable.Rows.Count - 1;
					if (num == -1)
					{
						NUM_VENTE = 1;
					}
					else
					{
						mySqlCommand.CommandText = (("SELECT MAX(NUM_DF)+1 FROM " + TABLE_SDF) ?? "");
						NUM_VENTE = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
					}
					string text2 = ("select * from " + TABLE_SF) ?? "";
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(text2, Globals.conn);
					MySqlCommand mySqlCommand2 = new MySqlCommand(text2, Globals.conn);
					DataTable dataTable2 = new DataTable();
					mySqlDataAdapter2.Fill(dataTable2);
					int num2 = dataTable2.Rows.Count - 1;
					if (num2 == -1)
					{
						NUM_TICK = 1;
					}
					else
					{
						mySqlCommand2.CommandText = "SELECT MAX(NUM_FACT)+1 FROM " + TABLE_SF + " ";
						NUM_TICK = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
					}
					string text3 = "select * from " + TABLE_EDF + " where NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString();
					MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(text3, Globals.conn);
					MySqlCommand mySqlCommand3 = new MySqlCommand(text3, Globals.conn);
					DataTable dataTable3 = new DataTable();
					mySqlDataAdapter3.Fill(dataTable3);
					int count = dataTable3.Rows.Count;
					MySqlDataAdapter mySqlDataAdapter4 = new MySqlDataAdapter(text2, Globals.conn);
					MySqlCommand mySqlCommand4 = new MySqlCommand(text2, Globals.conn);
					mySqlCommand4.CommandText = "SELECT MIN(NUM_DF) FROM " + TABLE_EDF + " where NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString();
					NUM_DF = Conversions.ToInteger(mySqlCommand4.ExecuteScalar());
					DateTime now = DateTime.Now;
					DateTime dateTime = Conversions.ToDate(now.ToString("yyyy/MM/dd HH:mm:ss"));
					string query = "INSERT INTO " + TABLE_SF + " (NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, TOTALTTC_FACT, NOM_SOC, ADRESSE_SOC, USER_NAME, DATE_CREATION) SELECT " + Conversions.ToString(NUM_TICK) + ", '" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "', IDCLIENT, VENDEUR, TOTALTTC_FACT, NOM_SOC, ADRESSE_SOC, '" + Globals.Utilisateur + "', '" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "' FROM " + TABLE_EF + (" WHERE NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString());
					Globals.ExecuteInsertQuery(query);
					int num3 = count - 1;
					for (int i = 0; i <= num3; i++)
					{
						int value = NUM_VENTE + i;
						string query2 = "INSERT INTO " + TABLE_SDF + " (NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)SELECT " + Conversions.ToString(value) + ", REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, " + Conversions.ToString(NUM_TICK) + " FROM " + TABLE_EDF + " WHERE NUM_DF=(SELECT NUM_DF FROM " + TABLE_EDF + " WHERE NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString() + " GROUP BY NUM_DF LIMIT " + Conversions.ToString(i) + ",1)";
						Globals.ExecuteInsertQuery(query2);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM " + TABLE_SDF + " WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						if (flag_Fact == 1)
						{
							decimal num4 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar().ToString());
							MySqlCommand mySqlCommand5 = new MySqlCommand();
							mySqlCommand5.Connection = Globals.conn;
							mySqlCommand5.CommandText = "SELECT DF.REFART,DF.LIBART,DF.qte,F.IDCLIENT FROM " + TABLE_EDF + " DF," + TABLE_EF + " F where F.NUM_FACT=DF.NUM_FACT AND DF.NUM_DF=(SELECT NUM_DF FROM " + TABLE_EDF + " WHERE NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString() + " GROUP BY NUM_DF LIMIT " + Conversions.ToString(i) + ", 1 )";
							Globals.cmd.CommandType = CommandType.Text;
							decimal num5 = default(decimal);
							MySqlDataReader mySqlDataReader = mySqlCommand5.ExecuteReader();
							decimal value2 = default(decimal);
							if (mySqlDataReader.Read())
							{
								REFART = mySqlDataReader["REFART"].ToString();
								LIBART = mySqlDataReader["LIBART"].ToString();
								value2 = Conversions.ToDecimal(mySqlDataReader["qte"].ToString());
								IDCLIENT = mySqlDataReader["IDCLIENT"].ToString();
							}
							mySqlDataReader.Close();
							mySqlDataReader.Dispose();
							Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART + "'";
							decimal value3 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
							string text4 = Strings.Replace(Conversions.ToString(value3), ",", ".", 1, -1, CompareMethod.Binary);
							num5 = new decimal(unchecked(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value3), ".", ",", 1, -1, CompareMethod.Binary)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(value2), ".", ",", 1, -1, CompareMethod.Binary))));
							string text5 = Strings.Replace(Conversions.ToString(num5), ",", ".", 1, -1, CompareMethod.Binary);
							string cmdText = "UPDATE ARTICLE_D SET STOK=" + text5 + " WHERE REFART='" + REFART + "'";
							MySqlCommand mySqlCommand6 = new MySqlCommand(cmdText, Globals.conn);
							mySqlCommand6.ExecuteNonQuery();
							string text6 = "select * from sortie_stock";
							MySqlDataAdapter mySqlDataAdapter5 = new MySqlDataAdapter(text6, Globals.conn);
							MySqlCommand mySqlCommand7 = new MySqlCommand(text6, Globals.conn);
							DataTable dataTable4 = new DataTable();
							mySqlDataAdapter5.Fill(dataTable4);
							int num6 = dataTable4.Rows.Count - 1;
							if (num6 == -1)
							{
								COD_S = 1;
							}
							else
							{
								mySqlCommand7.CommandText = "SELECT MAX(code_sortie)+1 FROM sortie_stock ";
								COD_S = Conversions.ToInteger(mySqlCommand7.ExecuteScalar());
							}
							string text7 = Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary);
							string[] obj = new string[17]
							{
								"INSERT INTO sortie_stock(REFART, LIBART, quantite, client, Date_sortie, Code_sortie, STOCK_AVANT, STOCK_APRES,TYPE_SORTIE)VALUES('",
								REFART,
								"', '",
								LIBART,
								"', '",
								text7,
								"','",
								IDCLIENT,
								"','",
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								null
							};
							now = DateTime.Now;
							obj[9] = now.ToString("yyyy-MM-dd H:mm:ss");
							obj[10] = "',";
							obj[11] = Conversions.ToString(COD_S);
							obj[12] = ", '";
							obj[13] = text4;
							obj[14] = "','";
							obj[15] = text5;
							obj[16] = "','Vente')";
							string query3 = string.Concat(obj);
							Globals.ExecuteInsertQuery(query3);
						}
					}
					MessageBox.Show(messgeBox);
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

		private void Button3_Click(object sender, EventArgs e)
		{
			transfert_Fact("BONC", "DETAIL_BONC", "TICKET", "VENTE", "Bon de commande transformé en Facture", 1);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			transfert_Fact("DEVIS", "DETAIL_DEVIS", "BONC", "DETAIL_BONC", "Devis transformé en Bon de commande", 0);
		}

		private void DGV1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MyProject.Forms.Histo_Vente.TABLEFACT = TABLEFACT;
			MyProject.Forms.Histo_Vente.Text = "Historique " + TABLEFACT;
			MyProject.Forms.Histo_Vente.TABLEDF = TABLEDF;
			MyProject.Forms.Histo_Vente.NUMTICKET.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
			MyProject.Forms.Histo_Vente.Show();
			MyProject.Forms.Histo_Vente.BringToFront();
			MyProject.Forms.Histo_Vente.b_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Vente.TABLEFACT = TABLEFACT;
			MyProject.Forms.Histo_Vente.Text = "Historique " + TABLEFACT;
			MyProject.Forms.Histo_Vente.TABLEDF = TABLEDF;
			MyProject.Forms.Histo_Vente.NUMTICKET.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
			MyProject.Forms.Histo_Vente.Show();
			MyProject.Forms.Histo_Vente.BringToFront();
			MyProject.Forms.Histo_Vente.b_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearComboBox(this);
			Globals.ClearTextBox(this);
		}

		private void NUMFACTURE_SelectedIndexChanged(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void DATEF_Validated(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void DATEFF_Validated(object sender, EventArgs e)
		{
			B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void B_DA_BCA_Click(object sender, EventArgs e)
		{
			transfert_Fact("A_DEVIS", "A_DETAIL_DEVIS", "A_BONC", "A_DETAIL_BONC", "Devis.A transformé en BC.A", 0);
		}

		private void B_BC_BL_Click(object sender, EventArgs e)
		{
			transfert_Fact("BONC", "DETAIL_BONC", "BONL", "DETAIL_BONL", "'Bon de commande' transformé en 'Bon de livraison'", 0);
		}

		private void B_BL_Fact_Click(object sender, EventArgs e)
		{
			transfert_Fact("BONL", "DETAIL_BONL", "TICKET", "VENTE", "'Bon de livraison' transformé en 'Facture'", 1);
		}

		private void B_BC_ES_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					string text = "select * from A_DETAIL_BONC where NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
					MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					int count = dataTable.Rows.Count;
					MySqlCommand mySqlCommand2 = new MySqlCommand();
					mySqlCommand2.Connection = Globals.conn;
					mySqlCommand2.CommandText = "SELECT MIN(NUM_DF) FROM A_DETAIL_BONC where NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString();
					NUM_DF = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
					object obj = default(object);
					object loopObj = default(object);
					if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, count - 1, 1, ref loopObj, ref obj))
					{
						do
						{
							MySqlCommand mySqlCommand3 = new MySqlCommand();
							mySqlCommand3.Connection = Globals.conn;
							mySqlCommand3.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT DF.REFART,DF.LIBART,DF.qte,F.IDCLIENT FROM A_DETAIL_BONC DF,A_BONC F where F.NUM_FACT=DF.NUM_FACT AND DF.NUM_DF=(SELECT NUM_DF FROM A_DETAIL_BONC WHERE NUM_FACT=" + DGV1.CurrentRow.Cells[0].Value.ToString() + " GROUP BY NUM_DF LIMIT ", Operators.AddObject(obj, 1)), ",1)"));
							Globals.cmd.CommandType = CommandType.Text;
							decimal num = default(decimal);
							MySqlDataReader mySqlDataReader = mySqlCommand3.ExecuteReader();
							decimal value = default(decimal);
							if (mySqlDataReader.Read())
							{
								REFART = mySqlDataReader["REFART"].ToString();
								LIBART = mySqlDataReader["LIBART"].ToString();
								value = Conversions.ToDecimal(mySqlDataReader["qte"].ToString());
								IDCLIENT = mySqlDataReader["IDCLIENT"].ToString();
							}
							mySqlDataReader.Close();
							mySqlDataReader.Dispose();
							Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART + "'";
							decimal value2 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
							string text2 = Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary);
							num = decimal.Add(Globals.convertDN(Strings.Replace(Conversions.ToString(value2), ".", ",", 1, -1, CompareMethod.Binary)), Globals.convertDN(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)));
							string text3 = Strings.Replace(Conversions.ToString(num), ",", ".", 1, -1, CompareMethod.Binary);
							string cmdText = "UPDATE ARTICLE_D SET STOK=" + text3 + " WHERE REFART='" + REFART + "'";
							MySqlCommand mySqlCommand4 = new MySqlCommand(cmdText, Globals.conn);
							mySqlCommand4.ExecuteNonQuery();
							string text4 = "select * from entree_stock";
							MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(text4, Globals.conn);
							MySqlCommand mySqlCommand5 = new MySqlCommand(text4, Globals.conn);
							DataTable dataTable2 = new DataTable();
							mySqlDataAdapter2.Fill(dataTable2);
							int num2 = dataTable2.Rows.Count - 1;
							if (num2 == -1)
							{
								COD_S = 1;
							}
							else
							{
								mySqlCommand5.CommandText = "SELECT MAX(code_entree)+1 FROM entree_stock ";
								COD_S = Conversions.ToInteger(mySqlCommand5.ExecuteScalar());
							}
							string text5 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
							string query = "INSERT INTO entree_stock(REFART, LIBART, quantite, fournisseur, Date_entree, Code_entree, STOCK_AVANT, STOCK_APRES,TYPE_entree)VALUES('" + REFART + "', '" + LIBART + "', '" + text5 + "','" + IDCLIENT + "','" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "'," + Conversions.ToString(COD_S) + ", '" + text2 + "','" + text3 + "','A partir Bon Cde')";
							Globals.ExecuteInsertQuery(query);
						}
						while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
					}
					MessageBox.Show("Bon de commande Achat transformé en entrée stock");
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

		private void Reg_Multi_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Reglement.NUMFACTURE.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
			MyProject.Forms.Reglement.Show();
			MyProject.Forms.Reglement.BringToFront();
			MyProject.Forms.Reglement.Mode_Regl.Text = "";
			MyProject.Forms.Reglement.code.Text = "";
			MyProject.Forms.Reglement.flag_multi = 1;
			MyProject.Forms.Reglement.flag.Text = "1";
		}

		private void DGV1_DoubleClick(object sender, EventArgs e)
		{
			Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Modif_Fact modif_Fact = new Modif_Fact();
			modif_Fact.NUM_DEV = Conversions.ToInteger(DGV1.CurrentRow.Cells[0].Value.ToString());
			modif_Fact.TABLEFACT = TABLEFACT;
			modif_Fact.Show();
			modif_Fact.BringToFront();
			modif_Fact.HISTOCLIENT.Visible = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Modif_Fact modif_Fact = new Modif_Fact();
			modif_Fact.NUM_DEV = Conversions.ToInteger(DGV1.CurrentRow.Cells[0].Value.ToString());
			modif_Fact.TABLEFACT = TABLEFACT;
			modif_Fact.Modif_Fact_Load(RuntimeHelpers.GetObjectValue(sender), e);
			modif_Fact.Initier_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
