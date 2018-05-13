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
	public class Gestion_Fourn : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GSM3")]
		private TextBox _GSM3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label17")]
		private Label _label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CONTACT3")]
		private TextBox _CONTACT3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label18")]
		private Label _label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TIMBRE")]
		private TextBox _TIMBRE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MAIL")]
		private TextBox _MAIL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GSM2")]
		private TextBox _GSM2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CONTACT2")]
		private TextBox _CONTACT2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GSM1")]
		private TextBox _GSM1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CONTACT1")]
		private TextBox _CONTACT1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GSM")]
		private TextBox _GSM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODETVA")]
		private TextBox _CODETVA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TEL2")]
		private TextBox _TEL2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CONTACT")]
		private TextBox _CONTACT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FAX")]
		private TextBox _FAX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TEL1")]
		private TextBox _TEL1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label4")]
		private Label _label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TEL")]
		private TextBox _TEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label16")]
		private Label _label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MODEREG")]
		private ComboBox _MODEREG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FAMILLE")]
		private TextBox _FAMILLE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ECHEANCE")]
		private TextBox _ECHEANCE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDFAM")]
		private TextBox _IDFAM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REMISE")]
		private TextBox _REMISE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_imprimer")]
		private Button _b_imprimer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("VILLE")]
		private TextBox _VILLE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ADRESSE")]
		private TextBox _ADRESSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label2")]
		private Label _label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label3")]
		private Label _label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("groupBox6")]
		private GroupBox _groupBox6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_enregistrer")]
		private Button _b_enregistrer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDFRS")]
		private ComboBox _IDFRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NOMFRS")]
		private ComboBox _NOMFRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		public string NewFourn;

		internal virtual TextBox GSM3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label17
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CONTACT3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label18
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TIMBRE
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

		internal virtual TextBox MAIL
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label15
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox GSM2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label13
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CONTACT2
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

		internal virtual TextBox GSM1
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

		internal virtual TextBox CONTACT1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label12
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox GSM
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CODETVA
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label8
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TEL2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CONTACT
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox FAX
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TEL1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TEL
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label16
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label19
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

		internal virtual ComboBox MODEREG
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox FAMILLE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label23
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox ECHEANCE
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

		internal virtual TextBox IDFAM
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

		internal virtual TextBox REMISE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label27
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button b_imprimer
		{
			[CompilerGenerated]
			get
			{
				return _b_imprimer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = b_imprimer_Click;
				Button b_imprimer = _b_imprimer;
				if (b_imprimer != null)
				{
					b_imprimer.Click -= value2;
				}
				_b_imprimer = value;
				b_imprimer = _b_imprimer;
				if (b_imprimer != null)
				{
					b_imprimer.Click += value2;
				}
			}
		}

		internal virtual TextBox VILLE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label29
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox ADRESSE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label22
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

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox groupBox6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button b_enregistrer
		{
			[CompilerGenerated]
			get
			{
				return _b_enregistrer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = b_enregistrer_Click;
				EventHandler value3 = b_enregistrer_Enter;
				Button b_enregistrer = _b_enregistrer;
				if (b_enregistrer != null)
				{
					b_enregistrer.Click -= value2;
					b_enregistrer.Enter -= value3;
				}
				_b_enregistrer = value;
				b_enregistrer = _b_enregistrer;
				if (b_enregistrer != null)
				{
					b_enregistrer.Click += value2;
					b_enregistrer.Enter += value3;
				}
			}
		}

		internal virtual Button Button23
		{
			[CompilerGenerated]
			get
			{
				return _Button23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button23_Click;
				Button button = _Button23;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button23 = value;
				button = _Button23;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Label21
		{
			[CompilerGenerated]
			get
			{
				return _Label21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label21_Click;
				Label label = _Label21;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label21 = value;
				label = _Label21;
				if (label != null)
				{
					label.Click += value2;
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

		public virtual ComboBox NOMFRS
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

		internal virtual Label Label25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label34
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		public Gestion_Fourn()
		{
			base.Load += Gestion_Fourn_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_Fourn));
			GSM3 = new TextBox();
			label17 = new Label();
			CONTACT3 = new TextBox();
			label18 = new Label();
			TIMBRE = new TextBox();
			GroupBox2 = new GroupBox();
			Label25 = new Label();
			MAIL = new TextBox();
			Label15 = new Label();
			GSM2 = new TextBox();
			Label13 = new Label();
			CONTACT2 = new TextBox();
			Label14 = new Label();
			GSM1 = new TextBox();
			Label11 = new Label();
			CONTACT1 = new TextBox();
			Label12 = new Label();
			GSM = new TextBox();
			Label10 = new Label();
			Label7 = new Label();
			CODETVA = new TextBox();
			Label8 = new Label();
			TEL2 = new TextBox();
			Label9 = new Label();
			CONTACT = new TextBox();
			Label6 = new Label();
			FAX = new TextBox();
			Label5 = new Label();
			TEL1 = new TextBox();
			label4 = new Label();
			TEL = new TextBox();
			label16 = new Label();
			Label19 = new Label();
			GroupBox4 = new GroupBox();
			Label34 = new Label();
			MODEREG = new ComboBox();
			FAMILLE = new TextBox();
			Label23 = new Label();
			ECHEANCE = new TextBox();
			Label24 = new Label();
			IDFAM = new TextBox();
			Label26 = new Label();
			REMISE = new TextBox();
			Label27 = new Label();
			b_imprimer = new Button();
			B_rechercher = new Button();
			VILLE = new TextBox();
			Label29 = new Label();
			ADRESSE = new TextBox();
			Label22 = new Label();
			label2 = new Label();
			GroupBox1 = new GroupBox();
			Button5 = new Button();
			NOMFRS = new ComboBox();
			IDFRS = new ComboBox();
			label3 = new Label();
			groupBox6 = new GroupBox();
			btnDelete = new Button();
			b_enregistrer = new Button();
			Button23 = new Button();
			Label21 = new Label();
			GroupBox2.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox1.SuspendLayout();
			groupBox6.SuspendLayout();
			base.SuspendLayout();
			GSM3.Location = new Point(518, 203);
			GSM3.Name = "GSM3";
			GSM3.Size = new Size(247, 26);
			GSM3.TabIndex = 18;
			label17.AutoSize = true;
			label17.BackColor = Color.Transparent;
			label17.ForeColor = SystemColors.ActiveCaption;
			label17.Location = new Point(467, 206);
			label17.Name = "label17";
			label17.Size = new Size(50, 18);
			label17.TabIndex = 29;
			label17.Text = "Gsm3";
			CONTACT3.Location = new Point(107, 203);
			CONTACT3.Name = "CONTACT3";
			CONTACT3.Size = new Size(247, 26);
			CONTACT3.TabIndex = 17;
			label18.AutoSize = true;
			label18.BackColor = Color.Transparent;
			label18.ForeColor = SystemColors.ActiveCaption;
			label18.Location = new Point(29, 206);
			label18.Name = "label18";
			label18.Size = new Size(71, 18);
			label18.TabIndex = 27;
			label18.Text = "Contact3";
			TIMBRE.Location = new Point(650, 55);
			TIMBRE.Name = "TIMBRE";
			TIMBRE.Size = new Size(56, 26);
			TIMBRE.TabIndex = 10;
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox2.Controls.Add(Label25);
			GroupBox2.Controls.Add(GSM3);
			GroupBox2.Controls.Add(label17);
			GroupBox2.Controls.Add(CONTACT3);
			GroupBox2.Controls.Add(label18);
			GroupBox2.Controls.Add(MAIL);
			GroupBox2.Controls.Add(Label15);
			GroupBox2.Controls.Add(GSM2);
			GroupBox2.Controls.Add(Label13);
			GroupBox2.Controls.Add(CONTACT2);
			GroupBox2.Controls.Add(Label14);
			GroupBox2.Controls.Add(GSM1);
			GroupBox2.Controls.Add(Label11);
			GroupBox2.Controls.Add(CONTACT1);
			GroupBox2.Controls.Add(Label12);
			GroupBox2.Controls.Add(GSM);
			GroupBox2.Controls.Add(Label10);
			GroupBox2.Controls.Add(TIMBRE);
			GroupBox2.Controls.Add(Label7);
			GroupBox2.Controls.Add(CODETVA);
			GroupBox2.Controls.Add(Label8);
			GroupBox2.Controls.Add(TEL2);
			GroupBox2.Controls.Add(Label9);
			GroupBox2.Controls.Add(CONTACT);
			GroupBox2.Controls.Add(Label6);
			GroupBox2.Controls.Add(FAX);
			GroupBox2.Controls.Add(Label5);
			GroupBox2.Controls.Add(TEL1);
			GroupBox2.Controls.Add(label4);
			GroupBox2.Controls.Add(TEL);
			GroupBox2.Controls.Add(label16);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox2.Location = new Point(26, 208);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(824, 277);
			GroupBox2.TabIndex = 36;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Coordonnées";
			Label25.Location = new Point(706, 58);
			Label25.Name = "Label25";
			Label25.Size = new Size(44, 18);
			Label25.TabIndex = 31;
			Label25.Text = "DT";
			MAIL.Location = new Point(107, 245);
			MAIL.Name = "MAIL";
			MAIL.Size = new Size(427, 26);
			MAIL.TabIndex = 19;
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.ForeColor = SystemColors.ActiveCaption;
			Label15.Location = new Point(40, 245);
			Label15.Name = "Label15";
			Label15.Size = new Size(37, 18);
			Label15.TabIndex = 25;
			Label15.Text = "Mail";
			GSM2.Location = new Point(518, 166);
			GSM2.Name = "GSM2";
			GSM2.Size = new Size(247, 26);
			GSM2.TabIndex = 16;
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.ForeColor = SystemColors.ActiveCaption;
			Label13.Location = new Point(467, 169);
			Label13.Name = "Label13";
			Label13.Size = new Size(50, 18);
			Label13.TabIndex = 23;
			Label13.Text = "Gsm2";
			CONTACT2.Location = new Point(107, 166);
			CONTACT2.Name = "CONTACT2";
			CONTACT2.Size = new Size(247, 26);
			CONTACT2.TabIndex = 15;
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.ForeColor = SystemColors.ActiveCaption;
			Label14.Location = new Point(29, 169);
			Label14.Name = "Label14";
			Label14.Size = new Size(71, 18);
			Label14.TabIndex = 21;
			Label14.Text = "Contact2";
			GSM1.Location = new Point(518, 129);
			GSM1.Name = "GSM1";
			GSM1.Size = new Size(247, 26);
			GSM1.TabIndex = 14;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.ForeColor = SystemColors.ActiveCaption;
			Label11.Location = new Point(467, 132);
			Label11.Name = "Label11";
			Label11.Size = new Size(50, 18);
			Label11.TabIndex = 19;
			Label11.Text = "Gsm1";
			CONTACT1.Location = new Point(107, 129);
			CONTACT1.Name = "CONTACT1";
			CONTACT1.Size = new Size(247, 26);
			CONTACT1.TabIndex = 13;
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.ForeColor = SystemColors.ActiveCaption;
			Label12.Location = new Point(30, 132);
			Label12.Name = "Label12";
			Label12.Size = new Size(71, 18);
			Label12.TabIndex = 17;
			Label12.Text = "Contact1";
			GSM.Location = new Point(518, 92);
			GSM.Name = "GSM";
			GSM.Size = new Size(247, 26);
			GSM.TabIndex = 12;
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.ForeColor = SystemColors.ActiveCaption;
			Label10.Location = new Point(467, 95);
			Label10.Name = "Label10";
			Label10.Size = new Size(41, 18);
			Label10.TabIndex = 15;
			Label10.Text = "Gsm";
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.ForeColor = SystemColors.ActiveCaption;
			Label7.Location = new Point(587, 58);
			Label7.Name = "Label7";
			Label7.Size = new Size(56, 18);
			Label7.TabIndex = 13;
			Label7.Text = "Timbre";
			CODETVA.Location = new Point(394, 55);
			CODETVA.Name = "CODETVA";
			CODETVA.Size = new Size(162, 26);
			CODETVA.TabIndex = 9;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(306, 58);
			Label8.Name = "Label8";
			Label8.Size = new Size(81, 18);
			Label8.TabIndex = 11;
			Label8.Text = "Code TVA";
			TEL2.Location = new Point(625, 22);
			TEL2.Name = "TEL2";
			TEL2.Size = new Size(140, 26);
			TEL2.TabIndex = 7;
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.ForeColor = SystemColors.ActiveCaption;
			Label9.Location = new Point(570, 25);
			Label9.Name = "Label9";
			Label9.Size = new Size(36, 18);
			Label9.TabIndex = 9;
			Label9.Text = "Tel2";
			CONTACT.Location = new Point(107, 92);
			CONTACT.Name = "CONTACT";
			CONTACT.Size = new Size(247, 26);
			CONTACT.TabIndex = 11;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(38, 95);
			Label6.Name = "Label6";
			Label6.Size = new Size(62, 18);
			Label6.TabIndex = 7;
			Label6.Text = "Contact";
			FAX.Location = new Point(107, 58);
			FAX.Name = "FAX";
			FAX.Size = new Size(178, 26);
			FAX.TabIndex = 8;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(54, 61);
			Label5.Name = "Label5";
			Label5.Size = new Size(34, 18);
			Label5.TabIndex = 5;
			Label5.Text = "Fax";
			TEL1.Location = new Point(394, 22);
			TEL1.Name = "TEL1";
			TEL1.Size = new Size(162, 26);
			TEL1.TabIndex = 6;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.ForeColor = SystemColors.ActiveCaption;
			label4.Location = new Point(339, 25);
			label4.Name = "label4";
			label4.Size = new Size(36, 18);
			label4.TabIndex = 3;
			label4.Text = "Tel1";
			TEL.Location = new Point(107, 19);
			TEL.Name = "TEL";
			TEL.Size = new Size(178, 26);
			TEL.TabIndex = 5;
			label16.AutoSize = true;
			label16.BackColor = Color.Transparent;
			label16.ForeColor = SystemColors.ActiveCaption;
			label16.Location = new Point(59, 22);
			label16.Name = "label16";
			label16.Size = new Size(27, 18);
			label16.TabIndex = 0;
			label16.Text = "Tel";
			Label19.AutoSize = true;
			Label19.BackColor = Color.Transparent;
			Label19.ForeColor = SystemColors.ActiveCaption;
			Label19.Location = new Point(538, 35);
			Label19.Name = "Label19";
			Label19.Size = new Size(71, 18);
			Label19.TabIndex = 18;
			Label19.Text = "Modereg";
			GroupBox4.BackColor = Color.Transparent;
			GroupBox4.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox4.Controls.Add(Label34);
			GroupBox4.Controls.Add(MODEREG);
			GroupBox4.Controls.Add(Label19);
			GroupBox4.Controls.Add(FAMILLE);
			GroupBox4.Controls.Add(Label23);
			GroupBox4.Controls.Add(ECHEANCE);
			GroupBox4.Controls.Add(Label24);
			GroupBox4.Controls.Add(IDFAM);
			GroupBox4.Controls.Add(Label26);
			GroupBox4.Controls.Add(REMISE);
			GroupBox4.Controls.Add(Label27);
			GroupBox4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox4.Location = new Point(26, 491);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Size = new Size(824, 100);
			GroupBox4.TabIndex = 37;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Divers";
			Label34.Location = new Point(163, 35);
			Label34.Name = "Label34";
			Label34.Size = new Size(27, 21);
			Label34.TabIndex = 34;
			Label34.Text = "%";
			MODEREG.DisplayMember = "Espèce";
			MODEREG.FormattingEnabled = true;
			MODEREG.Items.AddRange(new object[4]
			{
				"Espèce",
				"Traite",
				"Chèque",
				"Virement"
			});
			MODEREG.Location = new Point(625, 32);
			MODEREG.Name = "MODEREG";
			MODEREG.Size = new Size(149, 26);
			MODEREG.TabIndex = 22;
			MODEREG.Text = "Espèce";
			FAMILLE.Location = new Point(296, 68);
			FAMILLE.Name = "FAMILLE";
			FAMILLE.Size = new Size(454, 26);
			FAMILLE.TabIndex = 24;
			Label23.AutoSize = true;
			Label23.BackColor = Color.Transparent;
			Label23.ForeColor = SystemColors.ActiveCaption;
			Label23.Location = new Point(205, 32);
			Label23.Name = "Label23";
			Label23.Size = new Size(78, 18);
			Label23.TabIndex = 9;
			Label23.Text = "Echeance";
			ECHEANCE.Location = new Point(296, 32);
			ECHEANCE.Name = "ECHEANCE";
			ECHEANCE.Size = new Size(221, 26);
			ECHEANCE.TabIndex = 21;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.ForeColor = SystemColors.ActiveCaption;
			Label24.Location = new Point(190, 71);
			Label24.Name = "Label24";
			Label24.Size = new Size(103, 18);
			Label24.TabIndex = 7;
			Label24.Text = "Libelle famille";
			IDFAM.Location = new Point(84, 71);
			IDFAM.Name = "IDFAM";
			IDFAM.Size = new Size(100, 26);
			IDFAM.TabIndex = 23;
			Label26.AutoSize = true;
			Label26.BackColor = Color.Transparent;
			Label26.ForeColor = SystemColors.ActiveCaption;
			Label26.Location = new Point(11, 74);
			Label26.Name = "Label26";
			Label26.Size = new Size(59, 18);
			Label26.TabIndex = 3;
			Label26.Text = "Famille";
			REMISE.Location = new Point(84, 32);
			REMISE.Name = "REMISE";
			REMISE.Size = new Size(79, 26);
			REMISE.TabIndex = 20;
			Label27.AutoSize = true;
			Label27.BackColor = Color.Transparent;
			Label27.ForeColor = SystemColors.ActiveCaption;
			Label27.Location = new Point(16, 35);
			Label27.Name = "Label27";
			Label27.Size = new Size(62, 18);
			Label27.TabIndex = 0;
			Label27.Text = "Remise";
			b_imprimer.BackColor = Color.White;
			b_imprimer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_imprimer.ForeColor = SystemColors.ActiveCaptionText;
			b_imprimer.Image = Resources.print_icon;
			b_imprimer.ImageAlign = ContentAlignment.MiddleLeft;
			b_imprimer.Location = new Point(657, 20);
			b_imprimer.Name = "b_imprimer";
			b_imprimer.Size = new Size(117, 50);
			b_imprimer.TabIndex = 27;
			b_imprimer.Text = "       Imprimer";
			b_imprimer.UseVisualStyleBackColor = false;
			B_rechercher.BackColor = Color.White;
			B_rechercher.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			B_rechercher.ForeColor = SystemColors.ActiveCaptionText;
			B_rechercher.Image = Resources.Actions_document_find_icon1;
			B_rechercher.ImageAlign = ContentAlignment.MiddleLeft;
			B_rechercher.Location = new Point(642, 34);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(132, 47);
			B_rechercher.TabIndex = 51;
			B_rechercher.TabStop = false;
			B_rechercher.Text = "     Rechercher";
			B_rechercher.UseVisualStyleBackColor = false;
			VILLE.Location = new Point(585, 90);
			VILLE.Name = "VILLE";
			VILLE.Size = new Size(189, 26);
			VILLE.TabIndex = 4;
			Label29.AutoSize = true;
			Label29.BackColor = Color.Transparent;
			Label29.Location = new Point(531, 93);
			Label29.Name = "Label29";
			Label29.Size = new Size(38, 18);
			Label29.TabIndex = 7;
			Label29.Text = "Ville";
			ADRESSE.Location = new Point(69, 90);
			ADRESSE.Name = "ADRESSE";
			ADRESSE.Size = new Size(448, 26);
			ADRESSE.TabIndex = 3;
			Label22.AutoSize = true;
			Label22.BackColor = Color.Transparent;
			Label22.Location = new Point(6, 93);
			Label22.Name = "Label22";
			Label22.Size = new Size(67, 18);
			Label22.TabIndex = 5;
			Label22.Text = "Adresse";
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Location = new Point(18, 47);
			label2.Name = "label2";
			label2.Size = new Size(47, 18);
			label2.TabIndex = 0;
			label2.Text = "Code";
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(NOMFRS);
			GroupBox1.Controls.Add(IDFRS);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(VILLE);
			GroupBox1.Controls.Add(Label29);
			GroupBox1.Controls.Add(ADRESSE);
			GroupBox1.Controls.Add(Label22);
			GroupBox1.Controls.Add(label3);
			GroupBox1.Controls.Add(label2);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(26, 67);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(824, 126);
			GroupBox1.TabIndex = 0;
			GroupBox1.TabStop = false;
			Button5.BackColor = Color.White;
			Button5.Location = new Point(222, 44);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 50;
			Button5.TabStop = false;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = false;
			NOMFRS.DropDownStyle = ComboBoxStyle.Simple;
			NOMFRS.FormattingEnabled = true;
			NOMFRS.Location = new Point(330, 46);
			NOMFRS.Name = "NOMFRS";
			NOMFRS.Size = new Size(289, 26);
			NOMFRS.TabIndex = 2;
			IDFRS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			IDFRS.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDFRS.FormattingEnabled = true;
			IDFRS.Location = new Point(69, 46);
			IDFRS.Name = "IDFRS";
			IDFRS.Size = new Size(169, 26);
			IDFRS.TabIndex = 1;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Location = new Point(270, 49);
			label3.Name = "label3";
			label3.Size = new Size(54, 18);
			label3.TabIndex = 3;
			label3.Text = "Libelle";
			groupBox6.BackColor = Color.Transparent;
			groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
			groupBox6.Controls.Add(btnDelete);
			groupBox6.Controls.Add(b_imprimer);
			groupBox6.Controls.Add(b_enregistrer);
			groupBox6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			groupBox6.Location = new Point(26, 597);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(824, 83);
			groupBox6.TabIndex = 40;
			groupBox6.TabStop = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(349, 20);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(220, 50);
			btnDelete.TabIndex = 33;
			btnDelete.Text = "Supprimer Fournisseur";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			b_enregistrer.BackgroundImage = (Image)componentResourceManager.GetObject("b_enregistrer.BackgroundImage");
			b_enregistrer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_enregistrer.Image = Resources.Save_icon;
			b_enregistrer.ImageAlign = ContentAlignment.MiddleLeft;
			b_enregistrer.Location = new Point(152, 20);
			b_enregistrer.Name = "b_enregistrer";
			b_enregistrer.Size = new Size(131, 50);
			b_enregistrer.TabIndex = 26;
			b_enregistrer.Text = "Enregistrer";
			b_enregistrer.TextAlign = ContentAlignment.MiddleRight;
			b_enregistrer.UseVisualStyleBackColor = true;
			Button23.BackgroundImage = (Image)componentResourceManager.GetObject("Button23.BackgroundImage");
			Button23.Location = new Point(978, 85);
			Button23.Margin = new Padding(3, 4, 3, 4);
			Button23.Name = "Button23";
			Button23.Size = new Size(86, 74);
			Button23.TabIndex = 52;
			Button23.TabStop = false;
			Button23.UseVisualStyleBackColor = true;
			Label21.AutoSize = true;
			Label21.BackColor = Color.Transparent;
			Label21.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label21.Location = new Point(938, 163);
			Label21.Name = "Label21";
			Label21.Size = new Size(185, 19);
			Label21.TabIndex = 51;
			Label21.Text = "Historique Fournisseur";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Button23);
			base.Controls.Add(Label21);
			base.Controls.Add(groupBox6);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(GroupBox4);
			base.Controls.Add(GroupBox1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Gestion_Fourn";
			Text = "Gestion Fournisseur";
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(groupBox6, 0);
			base.Controls.SetChildIndex(Label21, 0);
			base.Controls.SetChildIndex(Button23, 0);
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			groupBox6.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Gestion_Fourn_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					base.KeyPreview = true;
					base.KeyUp += KeyUpHandler;
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct IDFRS from FOURN ";
					mySqlDataAdapter.Fill(Globals.ds, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = Globals.ds.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(Globals.ds.Tables[0].Rows[i]["IDFRS"].ToString());
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

		private void KeyUpHandler(object o, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
			if (e.KeyCode == Keys.F9)
			{
				Button5_Click(1, e);
			}
		}

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				IDFRS_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
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
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from FOURN where IDFRS ='" + IDFRS.Text + "'";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					NOMFRS.Text = mySqlDataReader["NOMFRS"].ToString();
					ADRESSE.Text = mySqlDataReader["ADRESSE"].ToString();
					VILLE.Text = mySqlDataReader["VILLE"].ToString();
					TEL.Text = mySqlDataReader["TEL"].ToString();
					TEL1.Text = mySqlDataReader["TEL1"].ToString();
					TEL2.Text = mySqlDataReader["TEL2"].ToString();
					FAX.Text = mySqlDataReader["FAX"].ToString();
					CONTACT.Text = mySqlDataReader["CONTACT"].ToString();
					CONTACT1.Text = mySqlDataReader["CONTACT1"].ToString();
					CONTACT2.Text = mySqlDataReader["CONTACT2"].ToString();
					CONTACT3.Text = mySqlDataReader["CONTACT3"].ToString();
					GSM.Text = mySqlDataReader["GSM"].ToString();
					GSM1.Text = mySqlDataReader["GSM1"].ToString();
					GSM2.Text = mySqlDataReader["GSM2"].ToString();
					GSM3.Text = mySqlDataReader["GSM3"].ToString();
					MAIL.Text = mySqlDataReader["MAIL"].ToString();
					IDFAM.Text = mySqlDataReader["IDFAM"].ToString();
					FAMILLE.Text = mySqlDataReader["FAMILLE"].ToString();
					CODETVA.Text = mySqlDataReader["CODTVA"].ToString();
					REMISE.Text = mySqlDataReader["REMISE"].ToString();
					ECHEANCE.Text = mySqlDataReader["ECHEANCE"].ToString();
					MODEREG.Text = mySqlDataReader["MODEREG"].ToString();
					TIMBRE.Text = mySqlDataReader["TIMBRE"].ToString();
				}
				NOMFRS.Focus();
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

		public void IDFRS_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDFRS from FOURN where IDFRS LIKE '" + IDFRS.Text + "%'";
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
					DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir ajouter un fournisseur?", "Ajout Fournisseur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						IDFRS.Text = "";
						NOMFRS.Text = "";
						MODEREG.Text = "";
						Globals.ClearTextBox(this);
					}
					else
					{
						Globals.ClearTextBox(this);
						NOMFRS.Text = "";
						MODEREG.Text = "";
						NewFourn = "Oui";
						NOMFRS.Focus();
					}
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

		private void b_enregistrer_Click(object sender, EventArgs e)
		{
			try
			{
				if ((Operators.CompareString(REMISE.Text, "", false) != 0 & Operators.CompareString(TIMBRE.Text, "", false) != 0) && checked(Globals.controlNum(REMISE.Text) + Globals.controlNum(TIMBRE.Text)) > 0)
				{
					MessageBox.Show("Merci de bien saisir un nombre valide !");
				}
				else
				{
					string text = Strings.Replace(REMISE.Text, ",", ".", 1, -1, CompareMethod.Binary);
					string text2 = Strings.Replace(TIMBRE.Text, ",", ".", 1, -1, CompareMethod.Binary);
					if (Operators.CompareString(NewFourn, "Oui", false) == 0)
					{
						string query = "INSERT INTO FOURN(IDFRS, NOMFRS, ADRESSE, VILLE, TEL, TEL1, TEL2, FAX, CONTACT1, CONTACT2, GSM1, GSM2, MAIL, IDFAM, FAMILLE, CODTVA, REMISE, ECHEANCE, MODEREG, TIMBRE, CONTACT, GSM, CONTACT3, GSM3)VALUES('" + IDFRS.Text + "', '" + NOMFRS.Text + "', '" + ADRESSE.Text + "', '" + VILLE.Text + "', '" + TEL.Text + "', '" + TEL1.Text + "','" + TEL2.Text + "', '" + FAX.Text + "', '" + CONTACT1.Text + "', '" + CONTACT2.Text + "', '" + GSM1.Text + "', '" + GSM2.Text + "', '" + MAIL.Text + "', '" + IDFAM.Text + "', '" + FAMILLE.Text + "', '" + CODETVA.Text + "', '" + text + "', '" + ECHEANCE.Text + "', '" + MODEREG.Text + "', '" + text2 + "', '" + CONTACT.Text + "', '" + GSM.Text + "', '" + CONTACT3.Text + "', '" + GSM3.Text + "')";
						Globals.ExecuteInsertQuery(query);
						NewFourn = "Non";
						MessageBox.Show("Fournisseur Ajouté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						Gestion_Fourn_Load(RuntimeHelpers.GetObjectValue(sender), e);
						IDFRS.Focus();
					}
					else
					{
						string query2 = "Update FOURN set NOMFRS='" + NOMFRS.Text + "', ADRESSE='" + ADRESSE.Text + "', VILLE='" + VILLE.Text + "', TEL='" + TEL.Text + "', TEL1='" + TEL1.Text + "', TEL2='" + TEL2.Text + "', FAX='" + FAX.Text + "', CONTACT1='" + CONTACT1.Text + "', CONTACT2='" + CONTACT2.Text + "', GSM1='" + GSM1.Text + "', GSM2='" + GSM2.Text + "', MAIL='" + MAIL.Text + "', IDFAM='" + IDFAM.Text + "', FAMILLE='" + FAMILLE.Text + "', CODTVA='" + CODETVA.Text + "', REMISE='" + text + "', ECHEANCE='" + ECHEANCE.Text + "', MODEREG='" + MODEREG.Text + "', TIMBRE='" + text2 + "', CONTACT='" + CONTACT.Text + "', GSM='" + GSM.Text + "', CONTACT3='" + CONTACT3.Text + "', GSM3='" + GSM3.Text + "' where IDFRS = '" + IDFRS.Text + "'";
						Globals.ExecuteUpdateQuery(query2);
						MessageBox.Show("Modification Apporté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						IDFRS.Focus();
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

		public void Button23_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.IDFRS.Text = IDFRS.Text;
			MyProject.Forms.Histo_Fourn.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.flag_COD = "GF";
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

		private void Label21_Click(object sender, EventArgs e)
		{
			Button23_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_imprimer_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Accueil.ImprimerToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_list_Click(object sender, EventArgs e)
		{
			Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_enregistrer_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir enregistrer?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				b_enregistrer_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer ce fournisseur?", "Suppression Fournisseur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM FOURN WHERE IDFRS='" + IDFRS.Text + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					MessageBox.Show("Fournisseur supprimé");
					Globals.ClearTextBox(this);
					Globals.ClearComboBox(this);
					IDFRS.Focus();
					Gestion_Fourn_Load(e, e);
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
