using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
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
	public class Gestion_Article_Mont : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_imprimer")]
		private Button _b_imprimer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label22")]
		private Label _label22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PWD")]
		private TextBox _PWD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_enregistrer")]
		private Button _b_enregistrer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("groupBox6")]
		private GroupBox _groupBox6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label29")]
		private Label _label29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("User")]
		private Label _User;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel2")]
		private LinkLabel _LinkLabel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTALQc")]
		private TextBox _TOTALQc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvQc")]
		private DataGridView _dgvQc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REF_QC")]
		private ComboBox _REF_QC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MO_QC")]
		private TextBox _MO_QC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("QTE_QC")]
		private TextBox _QTE_QC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_QC")]
		private TextBox _PRIX_QC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTAL")]
		private Label _TOTAL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ShapeContainer2")]
		private ShapeContainer _ShapeContainer2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LineShape2")]
		private LineShape _LineShape2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel3")]
		private LinkLabel _LinkLabel3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTALACC")]
		private TextBox _TOTALACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvACC")]
		private DataGridView _dgvACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REF_ACC")]
		private ComboBox _REF_ACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MO_ACC")]
		private TextBox _MO_ACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("QTE_ACC")]
		private TextBox _QTE_ACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_ACC")]
		private TextBox _PRIX_ACC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_MP")]
		private TextBox _PRIX_MP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("QTE_MP")]
		private TextBox _QTE_MP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MO_MP")]
		private TextBox _MO_MP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REF_MP")]
		private ComboBox _REF_MP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMP")]
		private DataGridView _dgvMP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTALMP")]
		private TextBox _TOTALMP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Modifier")]
		private Button _Modifier;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox _GroupBox10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("QTE_FAC")]
		private TextBox _QTE_FAC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_FAC")]
		private TextBox _PRIX_FAC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TotalFAC")]
		private TextBox _TotalFAC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel4")]
		private LinkLabel _LinkLabel4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REF_FAC")]
		private ComboBox _REF_FAC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MO_FAC")]
		private TextBox _MO_FAC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GAMME")]
		private TextBox _GAMME;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DIMENSION")]
		private TextBox _DIMENSION;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FACADE")]
		private ListBox _FACADE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		public string NewArticle;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Items;

		public int FalgNew;

		public int COD_E;

		public int NUM_MP;

		public int NUM_Qc;

		public int NUM_ACC;

		public int NUM_FAC;

		public decimal prix_revient;

		internal virtual Label Label2
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

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button b_imprimer
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label22
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PWD
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
				Button b_enregistrer = _b_enregistrer;
				if (b_enregistrer != null)
				{
					b_enregistrer.Click -= value2;
				}
				_b_enregistrer = value;
				b_enregistrer = _b_enregistrer;
				if (b_enregistrer != null)
				{
					b_enregistrer.Click += value2;
				}
			}
		}

		internal virtual GroupBox groupBox6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label29
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label User
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

		public virtual ComboBox LIBART
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

		internal virtual LinkLabel LinkLabel2
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel2_LinkClicked;
				LinkLabel linkLabel = _LinkLabel2;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				_LinkLabel2 = value;
				linkLabel = _LinkLabel2;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual Button Button7
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

		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return _Button8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button8_Click;
				Button button = _Button8;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button8 = value;
				button = _Button8;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TOTALQc
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvQc
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox REF_QC
		{
			[CompilerGenerated]
			get
			{
				return _REF_QC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = REF_QC_Click;
				EventHandler value3 = REF_QC_SelectedIndexChanged;
				ComboBox rEF_QC = _REF_QC;
				if (rEF_QC != null)
				{
					rEF_QC.Click -= value2;
					rEF_QC.SelectedIndexChanged -= value3;
				}
				_REF_QC = value;
				rEF_QC = _REF_QC;
				if (rEF_QC != null)
				{
					rEF_QC.Click += value2;
					rEF_QC.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual TextBox MO_QC
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

		internal virtual TextBox QTE_QC
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

		internal virtual TextBox PRIX_QC
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

		internal virtual Label Label10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox8
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label TOTAL
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

		internal virtual ShapeContainer ShapeContainer2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LineShape LineShape2
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

		internal virtual LinkLabel LinkLabel3
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel3_LinkClicked;
				LinkLabel linkLabel = _LinkLabel3;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				_LinkLabel3 = value;
				linkLabel = _LinkLabel3;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual Button Button3
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
				EventHandler value2 = Button4_Click_1;
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

		internal virtual TextBox TOTALACC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvACC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox REF_ACC
		{
			[CompilerGenerated]
			get
			{
				return _REF_ACC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = REF_ACC_Click;
				EventHandler value3 = REF_ACC_SelectedIndexChanged;
				ComboBox rEF_ACC = _REF_ACC;
				if (rEF_ACC != null)
				{
					rEF_ACC.Click -= value2;
					rEF_ACC.SelectedIndexChanged -= value3;
				}
				_REF_ACC = value;
				rEF_ACC = _REF_ACC;
				if (rEF_ACC != null)
				{
					rEF_ACC.Click += value2;
					rEF_ACC.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual TextBox MO_ACC
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

		internal virtual TextBox QTE_ACC
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

		internal virtual TextBox PRIX_ACC
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

		internal virtual Label Label16
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

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PRIX_MP
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

		internal virtual TextBox QTE_MP
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label30
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox MO_MP
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox REF_MP
		{
			[CompilerGenerated]
			get
			{
				return _REF_MP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = REF_MP_Click;
				EventHandler value3 = REF_MP_SelectedIndexChanged;
				ComboBox rEF_MP = _REF_MP;
				if (rEF_MP != null)
				{
					rEF_MP.Click -= value2;
					rEF_MP.SelectedIndexChanged -= value3;
				}
				_REF_MP = value;
				rEF_MP = _REF_MP;
				if (rEF_MP != null)
				{
					rEF_MP.Click += value2;
					rEF_MP.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual GroupBox GroupBox5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvMP
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TOTALMP
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Label Label25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel1_LinkClicked;
				LinkLabel linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				_LinkLabel1 = value;
				linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual Button Valider
		{
			[CompilerGenerated]
			get
			{
				return _Valider;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Valider_Click;
				Button valider = _Valider;
				if (valider != null)
				{
					valider.Click -= value2;
				}
				_Valider = value;
				valider = _Valider;
				if (valider != null)
				{
					valider.Click += value2;
				}
			}
		}

		internal virtual Button Modifier
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button15
		{
			[CompilerGenerated]
			get
			{
				return _Button15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button15_Click;
				Button button = _Button15;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button15 = value;
				button = _Button15;
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

		internal virtual Button Button9
		{
			[CompilerGenerated]
			get
			{
				return _Button9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button9_Click;
				Button button = _Button9;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button9 = value;
				button = _Button9;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button12
		{
			[CompilerGenerated]
			get
			{
				return _Button12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button12_Click;
				Button button = _Button12;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button12 = value;
				button = _Button12;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button13
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox QTE_FAC
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

		internal virtual TextBox PRIX_FAC
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

		internal virtual Label Label23
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TotalFAC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LinkLabel LinkLabel4
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel4_LinkClicked;
				LinkLabel linkLabel = _LinkLabel4;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				_LinkLabel4 = value;
				linkLabel = _LinkLabel4;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		internal virtual Button Button18
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label17
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button19
		{
			[CompilerGenerated]
			get
			{
				return _Button19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button19_Click;
				Button button = _Button19;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button19 = value;
				button = _Button19;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox REF_FAC
		{
			[CompilerGenerated]
			get
			{
				return _REF_FAC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = REF_FAC_Click;
				EventHandler value3 = REF_FAC_SelectedIndexChanged;
				ComboBox rEF_FAC = _REF_FAC;
				if (rEF_FAC != null)
				{
					rEF_FAC.Click -= value2;
					rEF_FAC.SelectedIndexChanged -= value3;
				}
				_REF_FAC = value;
				rEF_FAC = _REF_FAC;
				if (rEF_FAC != null)
				{
					rEF_FAC.Click += value2;
					rEF_FAC.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual TextBox MO_FAC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label18
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox GAMME
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

		internal virtual TextBox DIMENSION
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label20
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

		internal virtual Button Button14
		{
			[CompilerGenerated]
			get
			{
				return _Button14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button14_Click;
				Button button = _Button14;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button14 = value;
				button = _Button14;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ListBox FACADE
		{
			[CompilerGenerated]
			get
			{
				return _FACADE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = FACADE_SelectedIndexChanged;
				ListBox fACADE = _FACADE;
				if (fACADE != null)
				{
					fACADE.SelectedIndexChanged -= value2;
				}
				_FACADE = value;
				fACADE = _FACADE;
				if (fACADE != null)
				{
					fACADE.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Button Button16
		{
			[CompilerGenerated]
			get
			{
				return _Button16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button16_Click;
				Button button = _Button16;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button16 = value;
				button = _Button16;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button17
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private object Items
		{
			[CompilerGenerated]
			get
			{
				return _Items;
			}
			[CompilerGenerated]
			set
			{
				_Items = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public Gestion_Article_Mont()
		{
			base.Load += Gestion_Article_Load;
			FalgNew = 0;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_Article_Mont));
			Label2 = new Label();
			B_rechercher = new Button();
			GroupBox1 = new GroupBox();
			Button5 = new Button();
			REFART = new ComboBox();
			Label1 = new Label();
			LIBART = new ComboBox();
			b_imprimer = new Button();
			label22 = new Label();
			PWD = new TextBox();
			b_enregistrer = new Button();
			groupBox6 = new GroupBox();
			User = new Label();
			label29 = new Label();
			GroupBox3 = new GroupBox();
			Button9 = new Button();
			Button10 = new Button();
			Button1 = new Button();
			LinkLabel2 = new LinkLabel();
			Button7 = new Button();
			Label4 = new Label();
			Button8 = new Button();
			TOTALQc = new TextBox();
			GroupBox7 = new GroupBox();
			dgvQc = new DataGridView();
			REF_QC = new ComboBox();
			MO_QC = new TextBox();
			Label7 = new Label();
			QTE_QC = new TextBox();
			Label8 = new Label();
			PRIX_QC = new TextBox();
			Label9 = new Label();
			Label10 = new Label();
			GroupBox8 = new GroupBox();
			TOTAL = new Label();
			Label11 = new Label();
			ShapeContainer2 = new ShapeContainer();
			LineShape2 = new LineShape();
			GroupBox4 = new GroupBox();
			Button12 = new Button();
			Button13 = new Button();
			Button2 = new Button();
			LinkLabel3 = new LinkLabel();
			Button3 = new Button();
			Label12 = new Label();
			Button4 = new Button();
			TOTALACC = new TextBox();
			GroupBox9 = new GroupBox();
			dgvACC = new DataGridView();
			REF_ACC = new ComboBox();
			MO_ACC = new TextBox();
			Label13 = new Label();
			QTE_ACC = new TextBox();
			Label14 = new Label();
			PRIX_ACC = new TextBox();
			Label15 = new Label();
			Label16 = new Label();
			Label3 = new Label();
			Label5 = new Label();
			PRIX_MP = new TextBox();
			Label6 = new Label();
			QTE_MP = new TextBox();
			Label30 = new Label();
			MO_MP = new TextBox();
			REF_MP = new ComboBox();
			GroupBox5 = new GroupBox();
			dgvMP = new DataGridView();
			TOTALMP = new TextBox();
			Button11 = new Button();
			Label25 = new Label();
			Button6 = new Button();
			LinkLabel1 = new LinkLabel();
			Valider = new Button();
			Modifier = new Button();
			Button15 = new Button();
			GroupBox2 = new GroupBox();
			GroupBox10 = new GroupBox();
			Button16 = new Button();
			Button17 = new Button();
			FACADE = new ListBox();
			Button14 = new Button();
			QTE_FAC = new TextBox();
			Label24 = new Label();
			PRIX_FAC = new TextBox();
			Label26 = new Label();
			Label23 = new Label();
			TotalFAC = new TextBox();
			LinkLabel4 = new LinkLabel();
			Button18 = new Button();
			Label17 = new Label();
			Button19 = new Button();
			TextBox1 = new TextBox();
			REF_FAC = new ComboBox();
			MO_FAC = new TextBox();
			Label18 = new Label();
			GAMME = new TextBox();
			Label19 = new Label();
			DIMENSION = new TextBox();
			Label20 = new Label();
			Label21 = new Label();
			GroupBox1.SuspendLayout();
			groupBox6.SuspendLayout();
			GroupBox3.SuspendLayout();
			GroupBox7.SuspendLayout();
			((ISupportInitialize)dgvQc).BeginInit();
			GroupBox8.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox9.SuspendLayout();
			((ISupportInitialize)dgvACC).BeginInit();
			GroupBox5.SuspendLayout();
			((ISupportInitialize)dgvMP).BeginInit();
			GroupBox2.SuspendLayout();
			GroupBox10.SuspendLayout();
			base.SuspendLayout();
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.ForeColor = SystemColors.ActiveCaption;
			Label2.Location = new Point(210, 22);
			Label2.Name = "Label2";
			Label2.Size = new Size(54, 18);
			Label2.TabIndex = 3;
			Label2.Text = "Libelle";
			B_rechercher.BackgroundImage = (Image)componentResourceManager.GetObject("B_rechercher.BackgroundImage");
			B_rechercher.Location = new Point(555, 35);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(127, 28);
			B_rechercher.TabIndex = 2;
			B_rechercher.Text = "     Rechercher";
			B_rechercher.UseVisualStyleBackColor = true;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Label2);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox1.Location = new Point(6, 56);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(687, 81);
			GroupBox1.TabIndex = 27;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Référence";
			Button5.Location = new Point(171, 18);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 46;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(68, 20);
			REFART.Name = "REFART";
			REFART.Size = new Size(121, 26);
			REFART.TabIndex = 14;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(24, 23);
			Label1.Name = "Label1";
			Label1.Size = new Size(47, 18);
			Label1.TabIndex = 0;
			Label1.Text = "Code";
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(264, 20);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(285, 26);
			LIBART.Sorted = true;
			LIBART.TabIndex = 6;
			b_imprimer.BackgroundImage = (Image)componentResourceManager.GetObject("b_imprimer.BackgroundImage");
			b_imprimer.Location = new Point(240, 52);
			b_imprimer.Name = "b_imprimer";
			b_imprimer.Size = new Size(123, 28);
			b_imprimer.TabIndex = 6;
			b_imprimer.Text = "       Imprimer";
			b_imprimer.UseVisualStyleBackColor = true;
			label22.AutoSize = true;
			label22.BackColor = Color.Transparent;
			label22.ForeColor = SystemColors.ActiveCaption;
			label22.Location = new Point(-5, 51);
			label22.Name = "label22";
			label22.Size = new Size(103, 18);
			label22.TabIndex = 5;
			label22.Text = "Mot de passe";
			PWD.Location = new Point(104, 48);
			PWD.Name = "PWD";
			PWD.Size = new Size(107, 26);
			PWD.TabIndex = 4;
			PWD.Text = "0";
			PWD.UseSystemPasswordChar = true;
			b_enregistrer.BackgroundImage = (Image)componentResourceManager.GetObject("b_enregistrer.BackgroundImage");
			b_enregistrer.Location = new Point(196, 17);
			b_enregistrer.Name = "b_enregistrer";
			b_enregistrer.Size = new Size(166, 28);
			b_enregistrer.TabIndex = 2;
			b_enregistrer.Text = "     Enregistrer Article";
			b_enregistrer.UseVisualStyleBackColor = true;
			groupBox6.BackColor = Color.Transparent;
			groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
			groupBox6.Controls.Add(User);
			groupBox6.Controls.Add(b_imprimer);
			groupBox6.Controls.Add(label22);
			groupBox6.Controls.Add(PWD);
			groupBox6.Controls.Add(b_enregistrer);
			groupBox6.Controls.Add(label29);
			groupBox6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			groupBox6.Location = new Point(699, 60);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(368, 80);
			groupBox6.TabIndex = 31;
			groupBox6.TabStop = false;
			groupBox6.Text = "User";
			User.BackColor = Color.White;
			User.ForeColor = Color.Red;
			User.Location = new Point(67, 19);
			User.Name = "User";
			User.Size = new Size(116, 26);
			User.TabIndex = 7;
			User.UseMnemonic = false;
			label29.AutoSize = true;
			label29.BackColor = Color.Transparent;
			label29.ForeColor = SystemColors.ActiveCaption;
			label29.Location = new Point(20, 22);
			label29.Name = "label29";
			label29.Size = new Size(41, 18);
			label29.TabIndex = 0;
			label29.Text = "User";
			GroupBox3.BackColor = Color.Transparent;
			GroupBox3.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox3.Controls.Add(Button9);
			GroupBox3.Controls.Add(Button10);
			GroupBox3.Controls.Add(Button1);
			GroupBox3.Controls.Add(LinkLabel2);
			GroupBox3.Controls.Add(Button7);
			GroupBox3.Controls.Add(Label4);
			GroupBox3.Controls.Add(Button8);
			GroupBox3.Controls.Add(TOTALQc);
			GroupBox3.Controls.Add(GroupBox7);
			GroupBox3.Controls.Add(REF_QC);
			GroupBox3.Controls.Add(MO_QC);
			GroupBox3.Controls.Add(Label7);
			GroupBox3.Controls.Add(QTE_QC);
			GroupBox3.Controls.Add(Label8);
			GroupBox3.Controls.Add(PRIX_QC);
			GroupBox3.Controls.Add(Label9);
			GroupBox3.Controls.Add(Label10);
			GroupBox3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox3.Location = new Point(6, 288);
			GroupBox3.Name = "GroupBox3";
			GroupBox3.Size = new Size(1252, 150);
			GroupBox3.TabIndex = 50;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Quincaillerie";
			Button9.BackColor = Color.Transparent;
			Button9.BackgroundImage = (Image)componentResourceManager.GetObject("Button9.BackgroundImage");
			Button9.Cursor = Cursors.Hand;
			Button9.FlatStyle = FlatStyle.Flat;
			Button9.ForeColor = Color.Transparent;
			Button9.Location = new Point(1183, 37);
			Button9.Name = "Button9";
			Button9.Size = new Size(58, 52);
			Button9.TabIndex = 55;
			Button9.UseVisualStyleBackColor = false;
			Button10.BackColor = Color.Transparent;
			Button10.BackgroundImage = (Image)componentResourceManager.GetObject("Button10.BackgroundImage");
			Button10.Cursor = Cursors.Hand;
			Button10.FlatStyle = FlatStyle.Flat;
			Button10.ForeColor = Color.Transparent;
			Button10.Location = new Point(1107, 36);
			Button10.Name = "Button10";
			Button10.Size = new Size(49, 54);
			Button10.TabIndex = 54;
			Button10.UseVisualStyleBackColor = false;
			Button1.BackColor = Color.Transparent;
			Button1.Cursor = Cursors.Hand;
			Button1.FlatStyle = FlatStyle.Flat;
			Button1.ForeColor = Color.Transparent;
			Button1.Image = (Image)componentResourceManager.GetObject("Button1.Image");
			Button1.Location = new Point(379, 58);
			Button1.Name = "Button1";
			Button1.Size = new Size(134, 47);
			Button1.TabIndex = 49;
			Button1.UseVisualStyleBackColor = false;
			LinkLabel2.AutoSize = true;
			LinkLabel2.Location = new Point(19, 84);
			LinkLabel2.Name = "LinkLabel2";
			LinkLabel2.Size = new Size(93, 18);
			LinkLabel2.TabIndex = 20;
			LinkLabel2.TabStop = true;
			LinkLabel2.Text = "Nouveau Qc";
			Button7.Location = new Point(337, 22);
			Button7.Name = "Button7";
			Button7.Size = new Size(33, 28);
			Button7.TabIndex = 48;
			Button7.Text = "...";
			Button7.UseVisualStyleBackColor = true;
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.ForeColor = SystemColors.ActiveCaption;
			Label4.Location = new Point(1131, 96);
			Label4.Name = "Label4";
			Label4.Size = new Size(100, 18);
			Label4.TabIndex = 9;
			Label4.Text = "Prix total Q.C";
			Button8.BackgroundImage = (Image)componentResourceManager.GetObject("Button8.BackgroundImage");
			Button8.Location = new Point(38, 58);
			Button8.Margin = new Padding(3, 4, 3, 4);
			Button8.Name = "Button8";
			Button8.Size = new Size(69, 70);
			Button8.TabIndex = 26;
			Button8.UseVisualStyleBackColor = true;
			TOTALQc.BackColor = Color.LemonChiffon;
			TOTALQc.Location = new Point(1127, 114);
			TOTALQc.Name = "TOTALQc";
			TOTALQc.ReadOnly = true;
			TOTALQc.Size = new Size(103, 26);
			TOTALQc.TabIndex = 8;
			GroupBox7.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox7.Controls.Add(dgvQc);
			GroupBox7.Location = new Point(519, 9);
			GroupBox7.Name = "GroupBox7";
			GroupBox7.Size = new Size(582, 137);
			GroupBox7.TabIndex = 26;
			GroupBox7.TabStop = false;
			GroupBox7.Text = "Qc utilisé";
			dgvQc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvQc.BackgroundColor = Color.White;
			dgvQc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvQc.Location = new Point(6, 17);
			dgvQc.Margin = new Padding(3, 4, 3, 4);
			dgvQc.Name = "dgvQc";
			dgvQc.ReadOnly = true;
			dgvQc.Size = new Size(570, 114);
			dgvQc.TabIndex = 21;
			REF_QC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REF_QC.AutoCompleteSource = AutoCompleteSource.ListItems;
			REF_QC.FormattingEnabled = true;
			REF_QC.Location = new Point(234, 24);
			REF_QC.Name = "REF_QC";
			REF_QC.Size = new Size(121, 26);
			REF_QC.TabIndex = 47;
			MO_QC.Location = new Point(234, 120);
			MO_QC.Name = "MO_QC";
			MO_QC.Size = new Size(125, 26);
			MO_QC.TabIndex = 4;
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.ForeColor = SystemColors.ActiveCaption;
			Label7.Location = new Point(117, 122);
			Label7.Name = "Label7";
			Label7.Size = new Size(105, 18);
			Label7.TabIndex = 0;
			Label7.Text = "Main d'ouevre";
			QTE_QC.Location = new Point(234, 88);
			QTE_QC.Name = "QTE_QC";
			QTE_QC.Size = new Size(125, 26);
			QTE_QC.TabIndex = 8;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(143, 91);
			Label8.Name = "Label8";
			Label8.Size = new Size(66, 18);
			Label8.TabIndex = 7;
			Label8.Text = "Quantité";
			PRIX_QC.Location = new Point(234, 56);
			PRIX_QC.Name = "PRIX_QC";
			PRIX_QC.Size = new Size(125, 26);
			PRIX_QC.TabIndex = 6;
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.ForeColor = SystemColors.ActiveCaption;
			Label9.Location = new Point(143, 59);
			Label9.Name = "Label9";
			Label9.Size = new Size(63, 18);
			Label9.TabIndex = 5;
			Label9.Text = "Prix Q.c";
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.ForeColor = SystemColors.ActiveCaption;
			Label10.Location = new Point(128, 27);
			Label10.Name = "Label10";
			Label10.Size = new Size(94, 18);
			Label10.TabIndex = 3;
			Label10.Text = "Quincaillerie";
			GroupBox8.BackColor = Color.LemonChiffon;
			GroupBox8.Controls.Add(TOTAL);
			GroupBox8.Controls.Add(Label11);
			GroupBox8.Controls.Add(ShapeContainer2);
			GroupBox8.Location = new Point(1080, 56);
			GroupBox8.Name = "GroupBox8";
			GroupBox8.Size = new Size(178, 84);
			GroupBox8.TabIndex = 51;
			GroupBox8.TabStop = false;
			TOTAL.Font = new Font("Arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			TOTAL.Location = new Point(9, 46);
			TOTAL.Name = "TOTAL";
			TOTAL.Size = new Size(163, 35);
			TOTAL.TabIndex = 3;
			TOTAL.Text = "0.00 DT";
			TOTAL.TextAlign = ContentAlignment.MiddleCenter;
			Label11.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label11.Location = new Point(20, 14);
			Label11.Name = "Label11";
			Label11.Size = new Size(141, 26);
			Label11.TabIndex = 1;
			Label11.Text = "Prix Article";
			ShapeContainer2.Location = new Point(3, 18);
			ShapeContainer2.Margin = new Padding(0);
			ShapeContainer2.Name = "ShapeContainer2";
			ShapeContainer2.Shapes.AddRange(new Shape[1]
			{
				LineShape2
			});
			ShapeContainer2.Size = new Size(172, 63);
			ShapeContainer2.TabIndex = 2;
			ShapeContainer2.TabStop = false;
			LineShape2.BorderColor = SystemColors.AppWorkspace;
			LineShape2.Name = "LineShape2";
			LineShape2.X1 = -12;
			LineShape2.X2 = 170;
			LineShape2.Y1 = 27;
			LineShape2.Y2 = 28;
			GroupBox4.BackColor = Color.Transparent;
			GroupBox4.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox4.Controls.Add(Button12);
			GroupBox4.Controls.Add(Button13);
			GroupBox4.Controls.Add(Button2);
			GroupBox4.Controls.Add(LinkLabel3);
			GroupBox4.Controls.Add(Button3);
			GroupBox4.Controls.Add(Label12);
			GroupBox4.Controls.Add(Button4);
			GroupBox4.Controls.Add(TOTALACC);
			GroupBox4.Controls.Add(GroupBox9);
			GroupBox4.Controls.Add(REF_ACC);
			GroupBox4.Controls.Add(MO_ACC);
			GroupBox4.Controls.Add(Label13);
			GroupBox4.Controls.Add(QTE_ACC);
			GroupBox4.Controls.Add(Label14);
			GroupBox4.Controls.Add(PRIX_ACC);
			GroupBox4.Controls.Add(Label15);
			GroupBox4.Controls.Add(Label16);
			GroupBox4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox4.Location = new Point(6, 440);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Size = new Size(1252, 151);
			GroupBox4.TabIndex = 52;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Accessoire";
			Button12.BackColor = Color.Transparent;
			Button12.BackgroundImage = (Image)componentResourceManager.GetObject("Button12.BackgroundImage");
			Button12.Cursor = Cursors.Hand;
			Button12.FlatStyle = FlatStyle.Flat;
			Button12.ForeColor = Color.Transparent;
			Button12.Location = new Point(1183, 24);
			Button12.Name = "Button12";
			Button12.Size = new Size(58, 52);
			Button12.TabIndex = 55;
			Button12.UseVisualStyleBackColor = false;
			Button13.BackColor = Color.Transparent;
			Button13.BackgroundImage = (Image)componentResourceManager.GetObject("Button13.BackgroundImage");
			Button13.Cursor = Cursors.Hand;
			Button13.FlatStyle = FlatStyle.Flat;
			Button13.ForeColor = Color.Transparent;
			Button13.Location = new Point(1107, 22);
			Button13.Name = "Button13";
			Button13.Size = new Size(49, 54);
			Button13.TabIndex = 54;
			Button13.UseVisualStyleBackColor = false;
			Button2.BackColor = Color.Transparent;
			Button2.Cursor = Cursors.Hand;
			Button2.FlatStyle = FlatStyle.Flat;
			Button2.ForeColor = Color.Transparent;
			Button2.Image = (Image)componentResourceManager.GetObject("Button2.Image");
			Button2.Location = new Point(379, 58);
			Button2.Name = "Button2";
			Button2.Size = new Size(134, 47);
			Button2.TabIndex = 49;
			Button2.UseVisualStyleBackColor = false;
			LinkLabel3.AutoSize = true;
			LinkLabel3.Location = new Point(19, 84);
			LinkLabel3.Name = "LinkLabel3";
			LinkLabel3.Size = new Size(100, 18);
			LinkLabel3.TabIndex = 20;
			LinkLabel3.TabStop = true;
			LinkLabel3.Text = "Nouveau Acc";
			Button3.Location = new Point(337, 24);
			Button3.Name = "Button3";
			Button3.Size = new Size(33, 28);
			Button3.TabIndex = 48;
			Button3.Text = "...";
			Button3.UseVisualStyleBackColor = true;
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.ForeColor = SystemColors.ActiveCaption;
			Label12.Location = new Point(1125, 97);
			Label12.Name = "Label12";
			Label12.Size = new Size(99, 18);
			Label12.TabIndex = 9;
			Label12.Text = "Prix total Acc";
			Button4.BackgroundImage = (Image)componentResourceManager.GetObject("Button4.BackgroundImage");
			Button4.Location = new Point(38, 58);
			Button4.Margin = new Padding(3, 4, 3, 4);
			Button4.Name = "Button4";
			Button4.Size = new Size(69, 70);
			Button4.TabIndex = 26;
			Button4.UseVisualStyleBackColor = true;
			TOTALACC.BackColor = Color.LemonChiffon;
			TOTALACC.Location = new Point(1128, 118);
			TOTALACC.Name = "TOTALACC";
			TOTALACC.ReadOnly = true;
			TOTALACC.Size = new Size(103, 26);
			TOTALACC.TabIndex = 8;
			GroupBox9.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox9.Controls.Add(dgvACC);
			GroupBox9.Location = new Point(519, 9);
			GroupBox9.Name = "GroupBox9";
			GroupBox9.Size = new Size(582, 138);
			GroupBox9.TabIndex = 26;
			GroupBox9.TabStop = false;
			GroupBox9.Text = "Acc utilisé";
			dgvACC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvACC.BackgroundColor = Color.White;
			dgvACC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvACC.Location = new Point(6, 17);
			dgvACC.Margin = new Padding(3, 4, 3, 4);
			dgvACC.Name = "dgvACC";
			dgvACC.ReadOnly = true;
			dgvACC.Size = new Size(570, 116);
			dgvACC.TabIndex = 21;
			REF_ACC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REF_ACC.AutoCompleteSource = AutoCompleteSource.ListItems;
			REF_ACC.FormattingEnabled = true;
			REF_ACC.Location = new Point(234, 25);
			REF_ACC.Name = "REF_ACC";
			REF_ACC.Size = new Size(121, 26);
			REF_ACC.TabIndex = 47;
			MO_ACC.Location = new Point(234, 121);
			MO_ACC.Name = "MO_ACC";
			MO_ACC.Size = new Size(125, 26);
			MO_ACC.TabIndex = 4;
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.ForeColor = SystemColors.ActiveCaption;
			Label13.Location = new Point(117, 124);
			Label13.Name = "Label13";
			Label13.Size = new Size(105, 18);
			Label13.TabIndex = 0;
			Label13.Text = "Main d'ouevre";
			QTE_ACC.Location = new Point(234, 89);
			QTE_ACC.Name = "QTE_ACC";
			QTE_ACC.Size = new Size(125, 26);
			QTE_ACC.TabIndex = 8;
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.ForeColor = SystemColors.ActiveCaption;
			Label14.Location = new Point(143, 92);
			Label14.Name = "Label14";
			Label14.Size = new Size(66, 18);
			Label14.TabIndex = 7;
			Label14.Text = "Quantité";
			PRIX_ACC.Location = new Point(234, 57);
			PRIX_ACC.Name = "PRIX_ACC";
			PRIX_ACC.Size = new Size(125, 26);
			PRIX_ACC.TabIndex = 6;
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.ForeColor = SystemColors.ActiveCaption;
			Label15.Location = new Point(140, 59);
			Label15.Name = "Label15";
			Label15.Size = new Size(66, 18);
			Label15.TabIndex = 5;
			Label15.Text = "Prix Acc";
			Label16.AutoSize = true;
			Label16.BackColor = Color.Transparent;
			Label16.ForeColor = SystemColors.ActiveCaption;
			Label16.Location = new Point(128, 24);
			Label16.Name = "Label16";
			Label16.Size = new Size(87, 18);
			Label16.TabIndex = 3;
			Label16.Text = "Accessoire";
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.ForeColor = SystemColors.ActiveCaption;
			Label3.Location = new Point(106, 24);
			Label3.Name = "Label3";
			Label3.Size = new Size(128, 18);
			Label3.TabIndex = 3;
			Label3.Text = "Matière première";
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(143, 56);
			Label5.Name = "Label5";
			Label5.Size = new Size(67, 18);
			Label5.TabIndex = 5;
			Label5.Text = "Prix M.P";
			PRIX_MP.Location = new Point(234, 56);
			PRIX_MP.Name = "PRIX_MP";
			PRIX_MP.Size = new Size(125, 26);
			PRIX_MP.TabIndex = 6;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(143, 91);
			Label6.Name = "Label6";
			Label6.Size = new Size(66, 18);
			Label6.TabIndex = 7;
			Label6.Text = "Quantité";
			QTE_MP.Location = new Point(234, 88);
			QTE_MP.Name = "QTE_MP";
			QTE_MP.Size = new Size(125, 26);
			QTE_MP.TabIndex = 8;
			Label30.AutoSize = true;
			Label30.BackColor = Color.Transparent;
			Label30.ForeColor = SystemColors.ActiveCaption;
			Label30.Location = new Point(120, 122);
			Label30.Name = "Label30";
			Label30.Size = new Size(105, 18);
			Label30.TabIndex = 0;
			Label30.Text = "Main d'ouevre";
			MO_MP.Location = new Point(234, 119);
			MO_MP.Name = "MO_MP";
			MO_MP.Size = new Size(125, 26);
			MO_MP.TabIndex = 4;
			REF_MP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REF_MP.AutoCompleteSource = AutoCompleteSource.ListItems;
			REF_MP.FormattingEnabled = true;
			REF_MP.Location = new Point(234, 24);
			REF_MP.Name = "REF_MP";
			REF_MP.Size = new Size(121, 26);
			REF_MP.TabIndex = 47;
			GroupBox5.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox5.Controls.Add(dgvMP);
			GroupBox5.Location = new Point(519, 8);
			GroupBox5.Name = "GroupBox5";
			GroupBox5.Size = new Size(582, 141);
			GroupBox5.TabIndex = 26;
			GroupBox5.TabStop = false;
			GroupBox5.Text = "M.P utilisé";
			dgvMP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvMP.BackgroundColor = Color.White;
			dgvMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMP.Location = new Point(6, 17);
			dgvMP.Margin = new Padding(3, 4, 3, 4);
			dgvMP.Name = "dgvMP";
			dgvMP.ReadOnly = true;
			dgvMP.Size = new Size(570, 121);
			dgvMP.TabIndex = 21;
			TOTALMP.BackColor = Color.LemonChiffon;
			TOTALMP.Location = new Point(1124, 117);
			TOTALMP.Name = "TOTALMP";
			TOTALMP.ReadOnly = true;
			TOTALMP.Size = new Size(103, 26);
			TOTALMP.TabIndex = 8;
			Button11.BackgroundImage = (Image)componentResourceManager.GetObject("Button11.BackgroundImage");
			Button11.Location = new Point(35, 56);
			Button11.Margin = new Padding(3, 4, 3, 4);
			Button11.Name = "Button11";
			Button11.Size = new Size(69, 70);
			Button11.TabIndex = 26;
			Button11.UseVisualStyleBackColor = true;
			Label25.AutoSize = true;
			Label25.BackColor = Color.Transparent;
			Label25.ForeColor = SystemColors.ActiveCaption;
			Label25.Location = new Point(1124, 96);
			Label25.Name = "Label25";
			Label25.Size = new Size(100, 18);
			Label25.TabIndex = 9;
			Label25.Text = "Prix total M.P";
			Button6.Location = new Point(338, 22);
			Button6.Name = "Button6";
			Button6.Size = new Size(33, 28);
			Button6.TabIndex = 48;
			Button6.Text = "...";
			Button6.UseVisualStyleBackColor = true;
			LinkLabel1.AutoSize = true;
			LinkLabel1.Location = new Point(15, 82);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new Size(101, 18);
			LinkLabel1.TabIndex = 20;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Nouveau M.P";
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(379, 58);
			Valider.Name = "Valider";
			Valider.Size = new Size(134, 47);
			Valider.TabIndex = 49;
			Valider.UseVisualStyleBackColor = false;
			Modifier.BackColor = Color.Transparent;
			Modifier.BackgroundImage = (Image)componentResourceManager.GetObject("Modifier.BackgroundImage");
			Modifier.Cursor = Cursors.Hand;
			Modifier.FlatStyle = FlatStyle.Flat;
			Modifier.ForeColor = Color.Transparent;
			Modifier.Location = new Point(1107, 28);
			Modifier.Name = "Modifier";
			Modifier.Size = new Size(49, 54);
			Modifier.TabIndex = 52;
			Modifier.UseVisualStyleBackColor = false;
			Button15.BackColor = Color.Transparent;
			Button15.BackgroundImage = (Image)componentResourceManager.GetObject("Button15.BackgroundImage");
			Button15.Cursor = Cursors.Hand;
			Button15.FlatStyle = FlatStyle.Flat;
			Button15.ForeColor = Color.Transparent;
			Button15.Location = new Point(1183, 24);
			Button15.Name = "Button15";
			Button15.Size = new Size(58, 52);
			Button15.TabIndex = 53;
			Button15.UseVisualStyleBackColor = false;
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox2.Controls.Add(Button15);
			GroupBox2.Controls.Add(Modifier);
			GroupBox2.Controls.Add(Valider);
			GroupBox2.Controls.Add(LinkLabel1);
			GroupBox2.Controls.Add(Button6);
			GroupBox2.Controls.Add(Label25);
			GroupBox2.Controls.Add(Button11);
			GroupBox2.Controls.Add(TOTALMP);
			GroupBox2.Controls.Add(GroupBox5);
			GroupBox2.Controls.Add(REF_MP);
			GroupBox2.Controls.Add(MO_MP);
			GroupBox2.Controls.Add(Label30);
			GroupBox2.Controls.Add(QTE_MP);
			GroupBox2.Controls.Add(Label6);
			GroupBox2.Controls.Add(PRIX_MP);
			GroupBox2.Controls.Add(Label5);
			GroupBox2.Controls.Add(Label3);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox2.Location = new Point(6, 142);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(1252, 148);
			GroupBox2.TabIndex = 28;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Matière première";
			GroupBox10.BackColor = Color.Transparent;
			GroupBox10.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox10.Controls.Add(Button16);
			GroupBox10.Controls.Add(Button17);
			GroupBox10.Controls.Add(FACADE);
			GroupBox10.Controls.Add(Button14);
			GroupBox10.Controls.Add(QTE_FAC);
			GroupBox10.Controls.Add(Label24);
			GroupBox10.Controls.Add(PRIX_FAC);
			GroupBox10.Controls.Add(Label26);
			GroupBox10.Controls.Add(Label23);
			GroupBox10.Controls.Add(TotalFAC);
			GroupBox10.Controls.Add(LinkLabel4);
			GroupBox10.Controls.Add(Button18);
			GroupBox10.Controls.Add(Label17);
			GroupBox10.Controls.Add(Button19);
			GroupBox10.Controls.Add(TextBox1);
			GroupBox10.Controls.Add(REF_FAC);
			GroupBox10.Controls.Add(MO_FAC);
			GroupBox10.Controls.Add(Label18);
			GroupBox10.Controls.Add(GAMME);
			GroupBox10.Controls.Add(Label19);
			GroupBox10.Controls.Add(DIMENSION);
			GroupBox10.Controls.Add(Label20);
			GroupBox10.Controls.Add(Label21);
			GroupBox10.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox10.Location = new Point(6, 597);
			GroupBox10.Name = "GroupBox10";
			GroupBox10.Size = new Size(1252, 91);
			GroupBox10.TabIndex = 56;
			GroupBox10.TabStop = false;
			GroupBox10.Text = "Façade";
			Button16.BackColor = Color.Transparent;
			Button16.BackgroundImage = (Image)componentResourceManager.GetObject("Button16.BackgroundImage");
			Button16.Cursor = Cursors.Hand;
			Button16.FlatStyle = FlatStyle.Flat;
			Button16.ForeColor = Color.Transparent;
			Button16.Location = new Point(1067, 15);
			Button16.Name = "Button16";
			Button16.Size = new Size(58, 52);
			Button16.TabIndex = 57;
			Button16.UseVisualStyleBackColor = false;
			Button17.BackColor = Color.Transparent;
			Button17.BackgroundImage = (Image)componentResourceManager.GetObject("Button17.BackgroundImage");
			Button17.Cursor = Cursors.Hand;
			Button17.FlatStyle = FlatStyle.Flat;
			Button17.ForeColor = Color.Transparent;
			Button17.Location = new Point(1012, 14);
			Button17.Name = "Button17";
			Button17.Size = new Size(49, 54);
			Button17.TabIndex = 56;
			Button17.UseVisualStyleBackColor = false;
			FACADE.FormattingEnabled = true;
			FACADE.ItemHeight = 18;
			FACADE.Location = new Point(869, 14);
			FACADE.Name = "FACADE";
			FACADE.Size = new Size(137, 76);
			FACADE.TabIndex = 57;
			Button14.BackColor = Color.Transparent;
			Button14.Cursor = Cursors.Hand;
			Button14.FlatStyle = FlatStyle.Flat;
			Button14.ForeColor = Color.Transparent;
			Button14.Image = (Image)componentResourceManager.GetObject("Button14.Image");
			Button14.Location = new Point(729, 28);
			Button14.Name = "Button14";
			Button14.Size = new Size(134, 47);
			Button14.TabIndex = 56;
			Button14.UseVisualStyleBackColor = false;
			QTE_FAC.Location = new Point(415, 55);
			QTE_FAC.Name = "QTE_FAC";
			QTE_FAC.Size = new Size(98, 26);
			QTE_FAC.TabIndex = 54;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.ForeColor = SystemColors.ActiveCaption;
			Label24.Location = new Point(335, 57);
			Label24.Name = "Label24";
			Label24.Size = new Size(66, 18);
			Label24.TabIndex = 53;
			Label24.Text = "Quantité";
			PRIX_FAC.Location = new Point(221, 53);
			PRIX_FAC.Name = "PRIX_FAC";
			PRIX_FAC.Size = new Size(108, 26);
			PRIX_FAC.TabIndex = 52;
			Label26.AutoSize = true;
			Label26.BackColor = Color.Transparent;
			Label26.ForeColor = SystemColors.ActiveCaption;
			Label26.Location = new Point(133, 56);
			Label26.Name = "Label26";
			Label26.Size = new Size(93, 18);
			Label26.TabIndex = 51;
			Label26.Text = "Prix Façade";
			Label23.AutoSize = true;
			Label23.BackColor = Color.Transparent;
			Label23.ForeColor = SystemColors.ActiveCaption;
			Label23.Location = new Point(1131, 34);
			Label23.Name = "Label23";
			Label23.Size = new Size(93, 18);
			Label23.TabIndex = 50;
			Label23.Text = "Prix Façade";
			TotalFAC.BackColor = Color.LemonChiffon;
			TotalFAC.Location = new Point(1128, 54);
			TotalFAC.Name = "TotalFAC";
			TotalFAC.ReadOnly = true;
			TotalFAC.Size = new Size(103, 26);
			TotalFAC.TabIndex = 49;
			LinkLabel4.AutoSize = true;
			LinkLabel4.Location = new Point(6, 43);
			LinkLabel4.Name = "LinkLabel4";
			LinkLabel4.Size = new Size(127, 18);
			LinkLabel4.TabIndex = 20;
			LinkLabel4.TabStop = true;
			LinkLabel4.Text = "Nouveau Façade";
			Button18.Location = new Point(296, 24);
			Button18.Name = "Button18";
			Button18.Size = new Size(33, 28);
			Button18.TabIndex = 48;
			Button18.Text = "...";
			Button18.UseVisualStyleBackColor = true;
			Button18.Visible = false;
			Label17.AutoSize = true;
			Label17.BackColor = Color.Transparent;
			Label17.ForeColor = SystemColors.ActiveCaption;
			Label17.Location = new Point(1097, 155);
			Label17.Name = "Label17";
			Label17.Size = new Size(99, 18);
			Label17.TabIndex = 9;
			Label17.Text = "Prix total Acc";
			Button19.BackgroundImage = (Image)componentResourceManager.GetObject("Button19.BackgroundImage");
			Button19.Location = new Point(35, 17);
			Button19.Margin = new Padding(3, 4, 3, 4);
			Button19.Name = "Button19";
			Button19.Size = new Size(69, 70);
			Button19.TabIndex = 26;
			Button19.UseVisualStyleBackColor = true;
			TextBox1.Location = new Point(1203, 152);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(103, 26);
			TextBox1.TabIndex = 8;
			REF_FAC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REF_FAC.AutoCompleteSource = AutoCompleteSource.ListItems;
			REF_FAC.FormattingEnabled = true;
			REF_FAC.Location = new Point(193, 25);
			REF_FAC.Name = "REF_FAC";
			REF_FAC.Size = new Size(121, 26);
			REF_FAC.TabIndex = 47;
			REF_FAC.Visible = false;
			MO_FAC.Location = new Point(617, 57);
			MO_FAC.Name = "MO_FAC";
			MO_FAC.Size = new Size(94, 26);
			MO_FAC.TabIndex = 4;
			Label18.AutoSize = true;
			Label18.BackColor = Color.Transparent;
			Label18.ForeColor = SystemColors.ActiveCaption;
			Label18.Location = new Point(516, 59);
			Label18.Name = "Label18";
			Label18.Size = new Size(105, 18);
			Label18.TabIndex = 0;
			Label18.Text = "Main d'ouevre";
			GAMME.Location = new Point(584, 25);
			GAMME.Name = "GAMME";
			GAMME.Size = new Size(127, 26);
			GAMME.TabIndex = 8;
			Label19.AutoSize = true;
			Label19.BackColor = Color.Transparent;
			Label19.ForeColor = SystemColors.ActiveCaption;
			Label19.Location = new Point(522, 28);
			Label19.Name = "Label19";
			Label19.Size = new Size(64, 18);
			Label19.TabIndex = 7;
			Label19.Text = "Gamme";
			DIMENSION.Location = new Point(415, 26);
			DIMENSION.Name = "DIMENSION";
			DIMENSION.Size = new Size(98, 26);
			DIMENSION.TabIndex = 6;
			Label20.AutoSize = true;
			Label20.BackColor = Color.Transparent;
			Label20.ForeColor = SystemColors.ActiveCaption;
			Label20.Location = new Point(335, 29);
			Label20.Name = "Label20";
			Label20.Size = new Size(83, 18);
			Label20.TabIndex = 5;
			Label20.Text = "Dimension";
			Label21.AutoSize = true;
			Label21.BackColor = Color.Transparent;
			Label21.ForeColor = SystemColors.ActiveCaption;
			Label21.Location = new Point(128, 26);
			Label21.Name = "Label21";
			Label21.Size = new Size(62, 18);
			Label21.TabIndex = 3;
			Label21.Text = "Façade";
			Label21.Visible = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(GroupBox10);
			base.Controls.Add(GroupBox3);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(GroupBox4);
			base.Controls.Add(groupBox6);
			base.Controls.Add(GroupBox8);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Gestion_Article_Mont";
			Text = "Article montée";
			base.Controls.SetChildIndex(GroupBox8, 0);
			base.Controls.SetChildIndex(groupBox6, 0);
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(GroupBox3, 0);
			base.Controls.SetChildIndex(GroupBox10, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			GroupBox3.ResumeLayout(false);
			GroupBox3.PerformLayout();
			GroupBox7.ResumeLayout(false);
			((ISupportInitialize)dgvQc).EndInit();
			GroupBox8.ResumeLayout(false);
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox9.ResumeLayout(false);
			((ISupportInitialize)dgvACC).EndInit();
			GroupBox5.ResumeLayout(false);
			((ISupportInitialize)dgvMP).EndInit();
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			GroupBox10.ResumeLayout(false);
			GroupBox10.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
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
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select LIBART from ARTICLE_D where REFART ='" + REFART.Text + "'";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					AlimDGVMP();
					AlimDGVQC();
					AlimDGVACC();
					LB_FACADE();
					TotalFAC.Text = "";
				}
				else
				{
					MessageBox.Show("ARTICLE non trouvé");
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_enregistrer_Click(object sender, EventArgs e)
		{
			decimal value = decimal.Subtract(prix_revient, Globals.convertDN(TotalFAC.Text));
			string text = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				if (Operators.CompareString(NewArticle, "Oui", false) == 0)
				{
					string query = "INSERT INTO ARTICLE_D(REFART, LIBART, PRIX_REVIENT,TYPE_ART)VALUES('" + REFART.Text + "', '" + LIBART.Text + "', '" + text + "','Article montée')";
					Globals.ExecuteInsertQuery(query);
					MessageBox.Show("Article ajouté");
					NewArticle = "Non";
				}
				else
				{
					string query2 = "Update ARTICLE_D set LIBART='" + LIBART.Text + "', PRIX_REVIENT='" + text + "' where REFART = '" + REFART.Text + "'";
					Globals.ExecuteUpdateQuery(query2);
					MessageBox.Show("Modification Apporté");
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

		private void Gestion_Article_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					User.Text = Globals.Utilisateur;
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where TYPE_ART='Article montée'";
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

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			REF_MP.Text = "";
			PRIX_MP.Text = "";
			QTE_MP.Text = "";
			MO_MP.Text = "";
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
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where REFART LIKE '" + REFART.Text + "%'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else if ((double)FalgNew == Conversions.ToDouble("0"))
				{
					DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir ajouter un article?", "Ajout Article?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						REFART.Text = "";
						LIBART.Text = "";
						dgvMP.DataSource = null;
						dgvQc.DataSource = null;
						dgvACC.DataSource = null;
						REF_MP.Text = "";
						REF_QC.Text = "";
						REF_ACC.Text = "";
						Globals.ClearTextBox(this);
					}
					else
					{
						Globals.ClearTextBox(this);
						LIBART.Text = "";
						dgvMP.DataSource = null;
						dgvQc.DataSource = null;
						dgvACC.DataSource = null;
						REF_MP.Text = "";
						REF_QC.Text = "";
						REF_ACC.Text = "";
						NewArticle = "Oui";
					}
				}
				else
				{
					Globals.ClearTextBox(this);
					LIBART.Text = "";
					dgvMP.Rows.Clear();
					dgvQc.Rows.Clear();
					dgvACC.Rows.Clear();
					NewArticle = "Oui";
					FalgNew = Conversions.ToInteger("0");
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

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "ARTM";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D where TYPE_ART='Article montée'";
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

		private void Button11_Click(object sender, EventArgs e)
		{
			REF_MP.Text = "";
			PRIX_MP.Text = "";
			QTE_MP.Text = "";
			MO_MP.Text = "";
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			REF_QC.Text = "";
			PRIX_QC.Text = "";
			QTE_QC.Text = "";
			MO_QC.Text = "";
		}

		private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			REF_QC.Text = "";
			PRIX_QC.Text = "";
			QTE_QC.Text = "";
			MO_QC.Text = "";
		}

		private void REF_MP_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REF_MP from MATIERE_PREMIERE";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REF_MP.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REF_MP.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void REF_QC_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REF_QC from QUINCAILLERIE";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REF_QC.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REF_QC.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void REF_ACC_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REF_ACC from ACCESSOIRE";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REF_ACC.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REF_ACC.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void REF_MP_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from MATIERE_PREMIERE where REF_MP ='" + REF_MP.Text + "' limit 1";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					PRIX_MP.Text = mySqlDataReader["PRIX_MP"].ToString();
					QTE_MP.Text = mySqlDataReader["QTE_MP"].ToString();
					MO_MP.Text = mySqlDataReader["MO_MP"].ToString();
				}
				else
				{
					MessageBox.Show("MP non trouvé");
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		private void Valider_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(PRIX_MP.Text) + Globals.controlNum(QTE_MP.Text) + Globals.controlNum(MO_MP.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from MATIERE_PREMIERE";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_MP = 1;
						}
						else
						{
							mySqlCommand.CommandText = "SELECT MAX(NUM_MP)+1 FROM MATIERE_PREMIERE";
							NUM_MP = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						decimal value = decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_MP.Text), Globals.convertDN(QTE_MP.Text)), Globals.convertDN(MO_MP.Text));
						string text2 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						string text3 = Strings.Replace(PRIX_MP.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(MO_MP.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(QTE_MP.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO MATIERE_PREMIERE(NUM_MP, REF_MP, PRIX_MP, QTE_MP, MO_MP, REFART, TOTAL_MP)VALUES('" + Conversions.ToString(NUM_MP) + "', '" + REF_MP.Text + "','" + text3 + "','" + text5 + "','" + text4 + "','" + REFART.Text + "','" + text2 + "')";
						Globals.ExecuteInsertQuery(query);
						AlimDGVMP();
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

		public void AlimDGVMP()
		{
			string query = "select REF_MP, PRIX_MP, QTE_MP, MO_MP,TOTAL_MP,REFART,NUM_MP from MATIERE_PREMIERE where REFART='" + REFART.Text + "'";
			Globals.cmd.CommandText = "SELECT IFNULL(SUM(Total_MP),0) FROM MATIERE_PREMIERE WHERE REFART='" + REFART.Text + "'";
			TOTALMP.Text = Globals.cmd.ExecuteScalar().ToString();
			prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
			TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
			this.dgvMP.DataSource = null;
			this.dgvMP.Rows.Clear();
			Globals.LoadData(query, this.dgvMP, "MP");
			DataGridView dgvMP = this.dgvMP;
			dgvMP.Columns[0].HeaderCell.Value = "Réf. MP";
			dgvMP.Columns[1].HeaderCell.Value = "Prix MP";
			dgvMP.Columns[2].HeaderCell.Value = "Qté MP";
			dgvMP.Columns[3].HeaderCell.Value = "M.O MP";
			dgvMP.Columns[4].HeaderCell.Value = "Total MP";
			dgvMP.Columns[5].HeaderCell.Value = "Réf.Art";
			dgvMP.Columns[6].HeaderCell.Value = "NUMMP";
			dgvMP.Columns[5].Visible = false;
			dgvMP.Columns[6].Visible = false;
			dgvMP = null;
			int num = checked(this.dgvMP.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					this.dgvMP.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					this.dgvMP.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
		}

		private void Button15_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM MATIERE_PREMIERE WHERE NUM_MP='" + dgvMP.CurrentRow.Cells[6].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					dgvMP.Rows.Remove(dgvMP.CurrentRow);
					AlimDGVMP();
					MessageBox.Show("Ligne supprimé");
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

		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(PRIX_QC.Text) + Globals.controlNum(QTE_QC.Text) + Globals.controlNum(MO_QC.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from QUINCAILLERIE";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_Qc = 1;
						}
						else
						{
							mySqlCommand.CommandText = "SELECT MAX(NUM_Qc)+1 FROM QUINCAILLERIE";
							NUM_Qc = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						decimal value = decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_QC.Text), Globals.convertDN(QTE_QC.Text)), Globals.convertDN(MO_QC.Text));
						string text2 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						string text3 = Strings.Replace(PRIX_QC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(MO_QC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(QTE_QC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO QUINCAILLERIE(NUM_Qc, REF_Qc, PRIX_Qc, QTE_Qc, MO_Qc, REFART, TOTAL_Qc)VALUES('" + Conversions.ToString(NUM_Qc) + "', '" + REF_QC.Text + "','" + text3 + "','" + text5 + "','" + text4 + "','" + REFART.Text + "','" + text2 + "')";
						Globals.ExecuteInsertQuery(query);
						AlimDGVQC();
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
		}

		public void AlimDGVQC()
		{
			string query = "select REF_Qc, PRIX_Qc, QTE_Qc, MO_Qc,TOTAL_Qc,REFART,NUM_Qc from QUINCAILLERIE where REFART='" + REFART.Text + "'";
			Globals.cmd.CommandText = "SELECT IFNULL(SUM(Total_Qc),0) FROM QUINCAILLERIE WHERE REFART='" + REFART.Text + "'";
			TOTALQc.Text = Globals.cmd.ExecuteScalar().ToString();
			prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
			TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
			this.dgvQc.DataSource = null;
			this.dgvQc.Rows.Clear();
			Globals.LoadData(query, this.dgvQc, "Qc");
			DataGridView dgvQc = this.dgvQc;
			dgvQc.Columns[0].HeaderCell.Value = "Réf. Qc";
			dgvQc.Columns[1].HeaderCell.Value = "Prix Qc";
			dgvQc.Columns[2].HeaderCell.Value = "Qté Qc";
			dgvQc.Columns[3].HeaderCell.Value = "M.O Qc";
			dgvQc.Columns[4].HeaderCell.Value = "Total Qc";
			dgvQc.Columns[5].HeaderCell.Value = "Réf.Art";
			dgvQc.Columns[6].HeaderCell.Value = "NUMQc";
			dgvQc.Columns[5].Visible = false;
			dgvQc.Columns[6].Visible = false;
			dgvQc = null;
			int num = checked(this.dgvQc.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					this.dgvQc.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					this.dgvQc.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
		}

		private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			REF_ACC.Text = "";
			PRIX_ACC.Text = "";
			QTE_ACC.Text = "";
			MO_ACC.Text = "";
		}

		private void Button4_Click_1(object sender, EventArgs e)
		{
			REF_ACC.Text = "";
			PRIX_ACC.Text = "";
			QTE_ACC.Text = "";
			MO_ACC.Text = "";
		}

		private void REF_ACC_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from ACCESSOIRE where REF_ACC ='" + REF_ACC.Text + "' limit 1";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					PRIX_ACC.Text = mySqlDataReader["PRIX_ACC"].ToString();
					QTE_ACC.Text = mySqlDataReader["QTE_ACC"].ToString();
					MO_ACC.Text = mySqlDataReader["MO_ACC"].ToString();
				}
				else
				{
					MessageBox.Show("ACC non trouvé");
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		private void REF_QC_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from QUINCAILLERIE where REF_QC ='" + REF_QC.Text + "' limit 1";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					PRIX_QC.Text = mySqlDataReader["PRIX_QC"].ToString();
					QTE_QC.Text = mySqlDataReader["QTE_QC"].ToString();
					MO_QC.Text = mySqlDataReader["MO_QC"].ToString();
				}
				else
				{
					MessageBox.Show("QC non trouvé");
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(PRIX_ACC.Text) + Globals.controlNum(QTE_ACC.Text) + Globals.controlNum(MO_ACC.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
						goto end_IL_0001;
					}
					if (Globals.conn.State != 0)
					{
						goto IL_0062;
					}
					goto IL_0062;
					IL_0062:
					string text = "select * from ACCESSOIRE";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
					MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
					MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					int num = dataTable.Rows.Count - 1;
					if (num == -1)
					{
						NUM_ACC = 1;
					}
					else
					{
						mySqlCommand.CommandText = "SELECT MAX(NUM_ACC)+1 FROM ACCESSOIRE";
						NUM_ACC = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
					}
					decimal value = decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_ACC.Text), Globals.convertDN(QTE_ACC.Text)), Globals.convertDN(MO_ACC.Text));
					string text2 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
					string text3 = Strings.Replace(PRIX_ACC.Text, ",", ".", 1, -1, CompareMethod.Binary);
					string text4 = Strings.Replace(MO_ACC.Text, ",", ".", 1, -1, CompareMethod.Binary);
					string text5 = Strings.Replace(QTE_ACC.Text, ",", ".", 1, -1, CompareMethod.Binary);
					string query = "INSERT INTO ACCESSOIRE(NUM_ACC, REF_ACC, PRIX_ACC, QTE_ACC, MO_ACC, REFART, TOTAL_ACC)VALUES('" + Conversions.ToString(NUM_ACC) + "', '" + REF_ACC.Text + "','" + text3 + "','" + text5 + "','" + text4 + "','" + REFART.Text + "','" + text2 + "')";
					Globals.ExecuteInsertQuery(query);
					AlimDGVACC();
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

		public void AlimDGVACC()
		{
			string query = "select REF_ACC, PRIX_ACC, QTE_ACC, MO_ACC,TOTAL_ACC,REFART,NUM_ACC from ACCESSOIRE where REFART='" + REFART.Text + "'";
			Globals.cmd.CommandText = "SELECT IFNULL(SUM(Total_ACC),0) FROM ACCESSOIRE WHERE REFART='" + REFART.Text + "'";
			TOTALACC.Text = Globals.cmd.ExecuteScalar().ToString();
			prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
			TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
			this.dgvACC.DataSource = null;
			this.dgvACC.Rows.Clear();
			Globals.LoadData(query, this.dgvACC, "ACC");
			DataGridView dgvACC = this.dgvACC;
			dgvACC.Columns[0].HeaderCell.Value = "Réf. Acc";
			dgvACC.Columns[1].HeaderCell.Value = "Prix Acc";
			dgvACC.Columns[2].HeaderCell.Value = "Qté Acc";
			dgvACC.Columns[3].HeaderCell.Value = "M.O Acc";
			dgvACC.Columns[4].HeaderCell.Value = "Total Acc";
			dgvACC.Columns[5].HeaderCell.Value = "Réf.Art";
			dgvACC.Columns[6].HeaderCell.Value = "NUMAcc";
			dgvACC.Columns[5].Visible = false;
			dgvACC.Columns[6].Visible = false;
			dgvACC = null;
			int num = checked(this.dgvACC.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					this.dgvACC.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					this.dgvACC.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM QUINCAILLERIE WHERE NUM_Qc='" + dgvQc.CurrentRow.Cells[6].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					dgvQc.Rows.Remove(dgvQc.CurrentRow);
					AlimDGVQC();
					MessageBox.Show("Ligne supprimé");
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

		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM ACCESSOIRE WHERE NUM_ACC='" + dgvACC.CurrentRow.Cells[6].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					dgvACC.Rows.Remove(dgvACC.CurrentRow);
					AlimDGVACC();
					MessageBox.Show("Ligne supprimé");
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

		private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			GAMME.Text = "";
			DIMENSION.Text = "";
			REF_FAC.Text = "";
			PRIX_FAC.Text = "";
			QTE_FAC.Text = "";
			MO_FAC.Text = "";
			Label21.Visible = Conversions.ToBoolean("True");
			REF_FAC.Visible = Conversions.ToBoolean("True");
			Button18.Visible = Conversions.ToBoolean("True");
		}

		private void Button19_Click(object sender, EventArgs e)
		{
			GAMME.Text = "";
			DIMENSION.Text = "";
			REF_FAC.Text = "";
			PRIX_FAC.Text = "";
			QTE_FAC.Text = "";
			MO_FAC.Text = "";
			Label21.Visible = Conversions.ToBoolean("True");
			REF_FAC.Visible = Conversions.ToBoolean("True");
			Button18.Visible = Conversions.ToBoolean("True");
		}

		private void REF_FAC_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REF_FAC from FACADE";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REF_FAC.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REF_FAC.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void REF_FAC_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from FACADE where REF_FAC ='" + REF_FAC.Text + "' limit 1";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					GAMME.Text = mySqlDataReader["GAMME"].ToString();
					DIMENSION.Text = mySqlDataReader["DIMENSION"].ToString();
					PRIX_FAC.Text = mySqlDataReader["PRIX_FAC"].ToString();
					QTE_FAC.Text = mySqlDataReader["QTE_FAC"].ToString();
					MO_FAC.Text = mySqlDataReader["MO_FAC"].ToString();
					TotalFAC.Text = Conversions.ToString(decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_FAC.Text), Globals.convertDN(QTE_FAC.Text)), Globals.convertDN(MO_FAC.Text)));
					prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
					TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		private void Button14_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(PRIX_FAC.Text) + Globals.controlNum(QTE_FAC.Text) + Globals.controlNum(MO_FAC.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from FACADE";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_FAC = 1;
						}
						else
						{
							mySqlCommand.CommandText = "SELECT MAX(NUM_FAC)+1 FROM FACADE";
							NUM_FAC = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						decimal value = decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_FAC.Text), Globals.convertDN(QTE_FAC.Text)), Globals.convertDN(MO_FAC.Text));
						string text2 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						string text3 = Strings.Replace(PRIX_FAC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(MO_FAC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(QTE_FAC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO FACADE(NUM_FAC, REF_FAC, PRIX_FAC, QTE_FAC, MO_FAC, REFART, TOTAL_FAC, GAMME, DIMENSION)VALUES('" + Conversions.ToString(NUM_FAC) + "', '" + REF_FAC.Text + "','" + text3 + "','" + text5 + "','" + text4 + "','" + REFART.Text + "','" + text2 + "','" + GAMME.Text + "', '" + DIMENSION.Text + "')";
						Globals.ExecuteInsertQuery(query);
						CalcultotalFac();
						LB_FACADE();
						MessageBox.Show("Façade ajoutée");
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						Label21.Visible = Conversions.ToBoolean("False");
						REF_FAC.Visible = Conversions.ToBoolean("False");
						Button18.Visible = Conversions.ToBoolean("False");
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

		public void LB_FACADE()
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REF_FAC from FACADE WHERE REFART='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				FACADE.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						FACADE.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		public void CalcultotalFac()
		{
			TotalFAC.Text = Conversions.ToString(decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_FAC.Text), Globals.convertDN(QTE_FAC.Text)), Globals.convertDN(MO_FAC.Text)));
			prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
			TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
		}

		private void FACADE_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from FACADE where REF_FAC ='" + FACADE.Text + "' limit 1";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					GAMME.Text = mySqlDataReader["GAMME"].ToString();
					DIMENSION.Text = mySqlDataReader["DIMENSION"].ToString();
					PRIX_FAC.Text = mySqlDataReader["PRIX_FAC"].ToString();
					QTE_FAC.Text = mySqlDataReader["QTE_FAC"].ToString();
					MO_FAC.Text = mySqlDataReader["MO_FAC"].ToString();
					TotalFAC.Text = Conversions.ToString(decimal.Add(decimal.Multiply(Globals.convertDN(PRIX_FAC.Text), Globals.convertDN(QTE_FAC.Text)), Globals.convertDN(MO_FAC.Text)));
					prix_revient = decimal.Add(decimal.Add(decimal.Add(Globals.convertDN(TOTALMP.Text), Globals.convertDN(TOTALQc.Text)), Globals.convertDN(TOTALACC.Text)), Globals.convertDN(TotalFAC.Text));
					TOTAL.Text = Conversions.ToString(prix_revient) + " DT";
				}
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
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

		private void Button16_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM FACADE WHERE NUM_FAC=(select NUM_FAC FROM FACADE where REF_FAC='" + FACADE.Text + "' AND REFART= '" + REFART.Text + "')";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.ExecuteNonQuery();
					LB_FACADE();
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					MessageBox.Show("Ligne supprimé");
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
