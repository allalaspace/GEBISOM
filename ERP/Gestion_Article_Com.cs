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
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Gestion_Article_Com : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("groupBox6")]
		private GroupBox _groupBox6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_imprimer")]
		private Button _b_imprimer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("b_enregistrer")]
		private Button _b_enregistrer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MARGEMAX")]
		private TextBox _MARGEMAX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TVA")]
		private ComboBox _TVA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODBAR")]
		private TextBox _CODBAR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FDC")]
		private TextBox _FDC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REMISE")]
		private TextBox _REMISE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("fleche")]
		private Label _fleche;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

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
		[AccessedThroughProperty("UNIT")]
		private TextBox _UNIT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STKMIN")]
		private TextBox _STKMIN;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ETAGE")]
		private TextBox _ETAGE;

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
		[AccessedThroughProperty("RAYON")]
		private TextBox _RAYON;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

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
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OFGSelectImage")]
		private OpenFileDialog _OFGSelectImage;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STKALERT")]
		private TextBox _STKALERT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LB_Article")]
		private ListBox _LB_Article;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private TextBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_ATTC")]
		private TextBox _PRIX_ATTC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_AHT")]
		private TextBox _PRIX_AHT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_GROS")]
		private TextBox _PRIX_GROS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Prix_D2")]
		private TextBox _Prix_D2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_1")]
		private TextBox _PRIX_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Marge1")]
		private TextBox _Marge1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Marge2")]
		private TextBox _Marge2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Marge3")]
		private TextBox _Marge3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_V")]
		private TextBox _PRIX_V;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_HT")]
		private TextBox _PRIX_HT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabControl2")]
		private TabControl _TabControl2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NOMFRS")]
		private TextBox _NOMFRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FRS")]
		private ComboBox _FRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage5")]
		private TabPage _TabPage5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDFAM")]
		private TextBox _IDFAM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIB_FAM")]
		private TextBox _LIB_FAM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PV")]
		private ComboBox _PV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		public string NewArticle;

		public string TYPARTICLE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Items;

		public int FlagNew;

		public int COD_E;

		internal virtual Label Label2
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

		internal virtual Label Label18
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

		internal virtual TextBox MARGEMAX
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox TVA
		{
			[CompilerGenerated]
			get
			{
				return _TVA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TVA_Leave;
				EventHandler value3 = TVA_SelectedIndexChanged;
				ComboBox tVA = _TVA;
				if (tVA != null)
				{
					tVA.Leave -= value2;
					tVA.SelectedIndexChanged -= value3;
				}
				_TVA = value;
				tVA = _TVA;
				if (tVA != null)
				{
					tVA.Leave += value2;
					tVA.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual TextBox CODBAR
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

		internal virtual TextBox FDC
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

		internal virtual TextBox REMISE
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

		internal virtual Label Label33
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

		internal virtual Label Label34
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

		internal virtual Label Label32
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

		internal virtual Label fleche
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

		internal virtual TextBox UNIT
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

		internal virtual Label Label23
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox ETAGE
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

		internal virtual TextBox RAYON
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

		internal virtual GroupBox GroupBox1
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
				EventHandler value2 = REFART_SelectedIndexChanged;
				EventHandler value3 = REFART_Validated;
				KeyEventHandler value4 = REFART_KeyDown;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.SelectedIndexChanged -= value2;
					rEFART.Validated -= value3;
					rEFART.KeyDown -= value4;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.SelectedIndexChanged += value2;
					rEFART.Validated += value3;
					rEFART.KeyDown += value4;
				}
			}
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
				EventHandler value3 = B_rechercher_Enter;
				Button b_rechercher = _B_rechercher;
				if (b_rechercher != null)
				{
					b_rechercher.Click -= value2;
					b_rechercher.Enter -= value3;
				}
				_B_rechercher = value;
				b_rechercher = _B_rechercher;
				if (b_rechercher != null)
				{
					b_rechercher.Click += value2;
					b_rechercher.Enter += value3;
				}
			}
		}

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label31
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual OpenFileDialog OFGSelectImage
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return _Button6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button6_Click;
				Button button = _Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button6 = value;
				button = _Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return _Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button7_Click;
				Button button = _Button7;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button7 = value;
				button = _Button7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox STKALERT
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label35
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ListBox LB_Article
		{
			[CompilerGenerated]
			get
			{
				return _LB_Article;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = LB_Article_SelectedIndexChanged;
				ListBox lB_Article = _LB_Article;
				if (lB_Article != null)
				{
					lB_Article.SelectedIndexChanged -= value2;
				}
				_LB_Article = value;
				lB_Article = _LB_Article;
				if (lB_Article != null)
				{
					lB_Article.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TextBox LIBART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal new virtual PictureBox PictureBox1
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

		internal virtual TabPage TabPage2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PRIX_ATTC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PRIX_AHT
		{
			[CompilerGenerated]
			get
			{
				return _PRIX_AHT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PRIX_AHT_TextChanged;
				TextBox pRIX_AHT = _PRIX_AHT;
				if (pRIX_AHT != null)
				{
					pRIX_AHT.TextChanged -= value2;
				}
				_PRIX_AHT = value;
				pRIX_AHT = _PRIX_AHT;
				if (pRIX_AHT != null)
				{
					pRIX_AHT.TextChanged += value2;
				}
			}
		}

		internal virtual TextBox PRIX_GROS
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Prix_D2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PRIX_1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Marge1
		{
			[CompilerGenerated]
			get
			{
				return _Marge1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Marge1_Leave;
				TextBox marge = _Marge1;
				if (marge != null)
				{
					marge.Leave -= value2;
				}
				_Marge1 = value;
				marge = _Marge1;
				if (marge != null)
				{
					marge.Leave += value2;
				}
			}
		}

		internal virtual TextBox Marge2
		{
			[CompilerGenerated]
			get
			{
				return _Marge2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Marge2_Leave;
				TextBox marge = _Marge2;
				if (marge != null)
				{
					marge.Leave -= value2;
				}
				_Marge2 = value;
				marge = _Marge2;
				if (marge != null)
				{
					marge.Leave += value2;
				}
			}
		}

		internal virtual TextBox Marge3
		{
			[CompilerGenerated]
			get
			{
				return _Marge3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Marge3_Leave;
				TextBox marge = _Marge3;
				if (marge != null)
				{
					marge.Leave -= value2;
				}
				_Marge3 = value;
				marge = _Marge3;
				if (marge != null)
				{
					marge.Leave += value2;
				}
			}
		}

		internal virtual Label Label30
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

		internal virtual Label Label8
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

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label38
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label37
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

		internal virtual Label Label36
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

		internal virtual TabPage TabPage1
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

		internal virtual TextBox PRIX_V
		{
			[CompilerGenerated]
			get
			{
				return _PRIX_V;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PRIX_V_TextChanged;
				TextBox pRIX_V = _PRIX_V;
				if (pRIX_V != null)
				{
					pRIX_V.TextChanged -= value2;
				}
				_PRIX_V = value;
				pRIX_V = _PRIX_V;
				if (pRIX_V != null)
				{
					pRIX_V.TextChanged += value2;
				}
			}
		}

		internal virtual TextBox PRIX_HT
		{
			[CompilerGenerated]
			get
			{
				return _PRIX_HT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PRIX_HT_TextChanged;
				TextBox pRIX_HT = _PRIX_HT;
				if (pRIX_HT != null)
				{
					pRIX_HT.TextChanged -= value2;
				}
				_PRIX_HT = value;
				pRIX_HT = _PRIX_HT;
				if (pRIX_HT != null)
				{
					pRIX_HT.TextChanged += value2;
				}
			}
		}

		internal virtual Label Label28
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TabControl TabControl1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TabPage TabPage3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TabControl TabControl2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TabPage TabPage4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox NOMFRS
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

		internal virtual Label Label12
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

		public virtual ComboBox FRS
		{
			[CompilerGenerated]
			get
			{
				return _FRS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = FRS_SelectedIndexChanged_1;
				ComboBox fRS = _FRS;
				if (fRS != null)
				{
					fRS.SelectedIndexChanged -= value2;
				}
				_FRS = value;
				fRS = _FRS;
				if (fRS != null)
				{
					fRS.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TabPage TabPage5
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

		internal virtual TextBox IDFAM
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

		internal virtual TextBox LIB_FAM
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

		internal virtual ComboBox PV
		{
			[CompilerGenerated]
			get
			{
				return _PV;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PV_SelectedIndexChanged;
				ComboBox pV = _PV;
				if (pV != null)
				{
					pV.SelectedIndexChanged -= value2;
				}
				_PV = value;
				pV = _PV;
				if (pV != null)
				{
					pV.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox2
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

		public Gestion_Article_Com()
		{
			base.Load += Gestion_Article_Load;
			FlagNew = 0;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_Article_Com));
			Label2 = new Label();
			groupBox6 = new GroupBox();
			btnDelete = new Button();
			b_imprimer = new Button();
			b_enregistrer = new Button();
			Label18 = new Label();
			Label17 = new Label();
			MARGEMAX = new TextBox();
			CODBAR = new TextBox();
			Label11 = new Label();
			FDC = new TextBox();
			REMISE = new TextBox();
			Label16 = new Label();
			TVA = new ComboBox();
			Label14 = new Label();
			Label33 = new Label();
			GroupBox4 = new GroupBox();
			STKALERT = new TextBox();
			Label35 = new Label();
			fleche = new Label();
			Label19 = new Label();
			STOK = new TextBox();
			Label21 = new Label();
			UNIT = new TextBox();
			STKMIN = new TextBox();
			Label23 = new Label();
			ETAGE = new TextBox();
			Label24 = new Label();
			STKMAG = new TextBox();
			Label26 = new Label();
			RAYON = new TextBox();
			Label27 = new Label();
			Label34 = new Label();
			Button4 = new Button();
			Label32 = new Label();
			Button2 = new Button();
			Button3 = new Button();
			Button23 = new Button();
			Button5 = new Button();
			GroupBox1 = new GroupBox();
			LIBART = new TextBox();
			Button6 = new Button();
			REFART = new ComboBox();
			B_rechercher = new Button();
			Label1 = new Label();
			Button7 = new Button();
			Label31 = new Label();
			OFGSelectImage = new OpenFileDialog();
			LB_Article = new ListBox();
			PictureBox1 = new PictureBox();
			Button8 = new Button();
			TabPage2 = new TabPage();
			Label25 = new Label();
			PRIX_ATTC = new TextBox();
			PRIX_AHT = new TextBox();
			PRIX_GROS = new TextBox();
			Prix_D2 = new TextBox();
			PRIX_1 = new TextBox();
			Marge1 = new TextBox();
			Marge2 = new TextBox();
			Marge3 = new TextBox();
			Label30 = new Label();
			Label7 = new Label();
			Label8 = new Label();
			Label9 = new Label();
			Label3 = new Label();
			Label38 = new Label();
			Label37 = new Label();
			Label5 = new Label();
			Label36 = new Label();
			Label6 = new Label();
			TabPage1 = new TabPage();
			PV = new ComboBox();
			Label20 = new Label();
			PRIX_V = new TextBox();
			PRIX_HT = new TextBox();
			Label28 = new Label();
			TabControl1 = new TabControl();
			TabPage3 = new TabPage();
			TabControl2 = new TabControl();
			TabPage4 = new TabPage();
			NOMFRS = new TextBox();
			Label10 = new Label();
			LinkLabel1 = new LinkLabel();
			Button11 = new Button();
			Label12 = new Label();
			Button1 = new Button();
			FRS = new ComboBox();
			TabPage5 = new TabPage();
			Label15 = new Label();
			IDFAM = new TextBox();
			Label13 = new Label();
			LIB_FAM = new TextBox();
			GroupBox2 = new GroupBox();
			Label4 = new Label();
			groupBox6.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox1.SuspendLayout();
			((ISupportInitialize)PictureBox1).BeginInit();
			TabPage2.SuspendLayout();
			TabPage1.SuspendLayout();
			TabControl1.SuspendLayout();
			TabPage3.SuspendLayout();
			TabControl2.SuspendLayout();
			TabPage4.SuspendLayout();
			TabPage5.SuspendLayout();
			GroupBox2.SuspendLayout();
			base.SuspendLayout();
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.ForeColor = SystemColors.ActiveCaptionText;
			Label2.Location = new Point(310, 41);
			Label2.Name = "Label2";
			Label2.Size = new Size(54, 18);
			Label2.TabIndex = 3;
			Label2.Text = "Libelle";
			groupBox6.BackColor = Color.Transparent;
			groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
			groupBox6.Controls.Add(btnDelete);
			groupBox6.Controls.Add(b_imprimer);
			groupBox6.Controls.Add(b_enregistrer);
			groupBox6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			groupBox6.Location = new Point(276, 610);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(800, 64);
			groupBox6.TabIndex = 50;
			groupBox6.TabStop = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(398, 16);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(168, 43);
			btnDelete.TabIndex = 32;
			btnDelete.Text = "Supprimer Article";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			b_imprimer.BackColor = Color.White;
			b_imprimer.Cursor = Cursors.Hand;
			b_imprimer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_imprimer.Image = Resources.print_icon;
			b_imprimer.ImageAlign = ContentAlignment.MiddleLeft;
			b_imprimer.Location = new Point(659, 14);
			b_imprimer.Name = "b_imprimer";
			b_imprimer.Size = new Size(115, 46);
			b_imprimer.TabIndex = 31;
			b_imprimer.Text = "Imprimer";
			b_imprimer.TextAlign = ContentAlignment.MiddleRight;
			b_imprimer.UseVisualStyleBackColor = false;
			b_enregistrer.BackColor = Color.White;
			b_enregistrer.Cursor = Cursors.Hand;
			b_enregistrer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_enregistrer.Image = Resources.Save_icon;
			b_enregistrer.ImageAlign = ContentAlignment.MiddleLeft;
			b_enregistrer.Location = new Point(153, 13);
			b_enregistrer.Name = "b_enregistrer";
			b_enregistrer.Size = new Size(136, 47);
			b_enregistrer.TabIndex = 30;
			b_enregistrer.Text = "Enregistrer";
			b_enregistrer.TextAlign = ContentAlignment.MiddleRight;
			b_enregistrer.UseVisualStyleBackColor = false;
			Label18.AutoSize = true;
			Label18.BackColor = Color.Transparent;
			Label18.ForeColor = SystemColors.ActiveCaption;
			Label18.Location = new Point(253, 31);
			Label18.Name = "Label18";
			Label18.Size = new Size(71, 16);
			Label18.TabIndex = 18;
			Label18.Text = "Code barre";
			Label17.AutoSize = true;
			Label17.BackColor = Color.Transparent;
			Label17.ForeColor = SystemColors.ActiveCaption;
			Label17.Location = new Point(4, 82);
			Label17.Name = "Label17";
			Label17.Size = new Size(69, 16);
			Label17.TabIndex = 17;
			Label17.Text = "Margemax";
			MARGEMAX.Location = new Point(81, 79);
			MARGEMAX.Name = "MARGEMAX";
			MARGEMAX.Size = new Size(125, 22);
			MARGEMAX.TabIndex = 15;
			CODBAR.Location = new Point(347, 28);
			CODBAR.Name = "CODBAR";
			CODBAR.Size = new Size(125, 22);
			CODBAR.TabIndex = 16;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.ForeColor = SystemColors.ActiveCaption;
			Label11.Location = new Point(38, 33);
			Label11.Name = "Label11";
			Label11.Size = new Size(34, 16);
			Label11.TabIndex = 11;
			Label11.Text = "FDC";
			FDC.Location = new Point(81, 30);
			FDC.Name = "FDC";
			FDC.Size = new Size(125, 22);
			FDC.TabIndex = 14;
			REMISE.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			REMISE.Location = new Point(66, 94);
			REMISE.Name = "REMISE";
			REMISE.Size = new Size(70, 26);
			REMISE.TabIndex = 17;
			Label16.AutoSize = true;
			Label16.BackColor = Color.Transparent;
			Label16.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label16.ForeColor = SystemColors.ActiveCaptionText;
			Label16.Location = new Point(5, 99);
			Label16.Name = "Label16";
			Label16.Size = new Size(62, 18);
			Label16.TabIndex = 0;
			Label16.Text = "Remise";
			TVA.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TVA.FormattingEnabled = true;
			TVA.Items.AddRange(new object[5]
			{
				"18",
				"19",
				"12",
				"29",
				"6"
			});
			TVA.Location = new Point(66, 51);
			TVA.Name = "TVA";
			TVA.Size = new Size(72, 26);
			TVA.TabIndex = 13;
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label14.ForeColor = SystemColors.ActiveCaptionText;
			Label14.Location = new Point(15, 54);
			Label14.Name = "Label14";
			Label14.Size = new Size(38, 18);
			Label14.TabIndex = 5;
			Label14.Text = "TVA";
			Label33.AutoSize = true;
			Label33.BackColor = Color.Transparent;
			Label33.Cursor = Cursors.Hand;
			Label33.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label33.Location = new Point(1113, 629);
			Label33.Name = "Label33";
			Label33.Size = new Size(55, 16);
			Label33.TabIndex = 22;
			Label33.Text = "Entrées";
			GroupBox4.BackColor = Color.Transparent;
			GroupBox4.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox4.Controls.Add(STKALERT);
			GroupBox4.Controls.Add(Label35);
			GroupBox4.Controls.Add(fleche);
			GroupBox4.Controls.Add(Label19);
			GroupBox4.Controls.Add(STOK);
			GroupBox4.Controls.Add(Label21);
			GroupBox4.Controls.Add(UNIT);
			GroupBox4.Controls.Add(STKMIN);
			GroupBox4.Controls.Add(Label23);
			GroupBox4.Controls.Add(ETAGE);
			GroupBox4.Controls.Add(Label24);
			GroupBox4.Controls.Add(STKMAG);
			GroupBox4.Controls.Add(Label26);
			GroupBox4.Controls.Add(RAYON);
			GroupBox4.Controls.Add(Label27);
			GroupBox4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox4.ForeColor = SystemColors.ActiveCaption;
			GroupBox4.Location = new Point(276, 463);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Size = new Size(800, 141);
			GroupBox4.TabIndex = 49;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Stockage";
			STKALERT.Location = new Point(303, 109);
			STKALERT.Name = "STKALERT";
			STKALERT.Size = new Size(115, 26);
			STKALERT.TabIndex = 28;
			Label35.AutoSize = true;
			Label35.BackColor = Color.Transparent;
			Label35.ForeColor = SystemColors.ActiveCaptionText;
			Label35.Location = new Point(194, 112);
			Label35.Name = "Label35";
			Label35.Size = new Size(103, 18);
			Label35.TabIndex = 33;
			Label35.Text = "Stock d'alerte";
			fleche.AutoSize = true;
			fleche.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
			fleche.ForeColor = Color.Red;
			fleche.Location = new Point(441, 65);
			fleche.Name = "fleche";
			fleche.Size = new Size(50, 24);
			fleche.TabIndex = 19;
			fleche.Text = "---->";
			fleche.Visible = false;
			Label19.AutoSize = true;
			Label19.BackColor = Color.Transparent;
			Label19.ForeColor = SystemColors.ActiveCaptionText;
			Label19.Location = new Point(515, 21);
			Label19.Name = "Label19";
			Label19.Size = new Size(44, 18);
			Label19.TabIndex = 18;
			Label19.Text = "Unité";
			STOK.Location = new Point(569, 65);
			STOK.Name = "STOK";
			STOK.Size = new Size(114, 26);
			STOK.TabIndex = 27;
			Label21.AutoSize = true;
			Label21.BackColor = Color.Transparent;
			Label21.ForeColor = SystemColors.ActiveCaptionText;
			Label21.Location = new Point(515, 69);
			Label21.Name = "Label21";
			Label21.Size = new Size(48, 18);
			Label21.TabIndex = 13;
			Label21.Text = "Stock";
			UNIT.Location = new Point(572, 17);
			UNIT.Name = "UNIT";
			UNIT.Size = new Size(111, 26);
			UNIT.TabIndex = 24;
			STKMIN.Location = new Point(80, 66);
			STKMIN.Name = "STKMIN";
			STKMIN.Size = new Size(115, 26);
			STKMIN.TabIndex = 25;
			Label23.AutoSize = true;
			Label23.BackColor = Color.Transparent;
			Label23.ForeColor = SystemColors.ActiveCaptionText;
			Label23.Location = new Point(231, 24);
			Label23.Name = "Label23";
			Label23.Size = new Size(50, 18);
			Label23.TabIndex = 9;
			Label23.Text = "Etage";
			ETAGE.Location = new Point(303, 21);
			ETAGE.Name = "ETAGE";
			ETAGE.Size = new Size(115, 26);
			ETAGE.TabIndex = 23;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.ForeColor = SystemColors.ActiveCaptionText;
			Label24.Location = new Point(15, 68);
			Label24.Name = "Label24";
			Label24.Size = new Size(56, 18);
			Label24.TabIndex = 7;
			Label24.Text = "Stkmin";
			STKMAG.Location = new Point(303, 65);
			STKMAG.Name = "STKMAG";
			STKMAG.Size = new Size(115, 26);
			STKMAG.TabIndex = 26;
			Label26.AutoSize = true;
			Label26.BackColor = Color.Transparent;
			Label26.ForeColor = SystemColors.ActiveCaptionText;
			Label26.Location = new Point(227, 69);
			Label26.Name = "Label26";
			Label26.Size = new Size(60, 18);
			Label26.TabIndex = 3;
			Label26.Text = "Stkmax";
			RAYON.Location = new Point(81, 25);
			RAYON.Name = "RAYON";
			RAYON.Size = new Size(115, 26);
			RAYON.TabIndex = 22;
			Label27.AutoSize = true;
			Label27.BackColor = Color.Transparent;
			Label27.ForeColor = SystemColors.ActiveCaptionText;
			Label27.Location = new Point(20, 25);
			Label27.Name = "Label27";
			Label27.Size = new Size(52, 18);
			Label27.TabIndex = 0;
			Label27.Text = "Rayon";
			Label34.AutoSize = true;
			Label34.BackColor = Color.Transparent;
			Label34.Cursor = Cursors.Hand;
			Label34.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label34.Location = new Point(1156, 517);
			Label34.Name = "Label34";
			Label34.Size = new Size(87, 16);
			Label34.TabIndex = 32;
			Label34.Text = "Stock global";
			Button4.BackgroundImage = (Image)componentResourceManager.GetObject("Button4.BackgroundImage");
			Button4.Cursor = Cursors.Hand;
			Button4.Location = new Point(1160, 438);
			Button4.Margin = new Padding(3, 4, 3, 4);
			Button4.Name = "Button4";
			Button4.Size = new Size(73, 75);
			Button4.TabIndex = 50;
			Button4.TabStop = false;
			Button4.UseVisualStyleBackColor = true;
			Label32.AutoSize = true;
			Label32.BackColor = Color.Transparent;
			Label32.Cursor = Cursors.Hand;
			Label32.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label32.Location = new Point(1253, 629);
			Label32.Name = "Label32";
			Label32.Size = new Size(52, 16);
			Label32.TabIndex = 23;
			Label32.Text = "Sorties";
			Button2.BackgroundImage = (Image)componentResourceManager.GetObject("Button2.BackgroundImage");
			Button2.Cursor = Cursors.Hand;
			Button2.Location = new Point(1236, 550);
			Button2.Margin = new Padding(3, 4, 3, 4);
			Button2.Name = "Button2";
			Button2.Size = new Size(70, 75);
			Button2.TabIndex = 52;
			Button2.TabStop = false;
			Button2.UseVisualStyleBackColor = true;
			Button3.BackgroundImage = (Image)componentResourceManager.GetObject("Button3.BackgroundImage");
			Button3.Cursor = Cursors.Hand;
			Button3.Location = new Point(1104, 550);
			Button3.Margin = new Padding(3, 4, 3, 4);
			Button3.Name = "Button3";
			Button3.Size = new Size(73, 75);
			Button3.TabIndex = 51;
			Button3.TabStop = false;
			Button3.UseVisualStyleBackColor = true;
			Button23.BackgroundImage = (Image)componentResourceManager.GetObject("Button23.BackgroundImage");
			Button23.Location = new Point(1082, 59);
			Button23.Margin = new Padding(3, 4, 3, 4);
			Button23.Name = "Button23";
			Button23.Size = new Size(86, 74);
			Button23.TabIndex = 80;
			Button23.TabStop = false;
			Button23.UseVisualStyleBackColor = true;
			Button5.Location = new Point(253, 34);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 46;
			Button5.TabStop = false;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Controls.Add(Button6);
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Label2);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox1.Location = new Point(276, 59);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(800, 98);
			GroupBox1.TabIndex = 0;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Référence";
			LIBART.Location = new Point(370, 36);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(276, 26);
			LIBART.TabIndex = 37;
			Button6.BackColor = SystemColors.Window;
			Button6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button6.Image = Resources.add_1_icon;
			Button6.ImageAlign = ContentAlignment.MiddleLeft;
			Button6.Location = new Point(370, 64);
			Button6.Name = "Button6";
			Button6.Size = new Size(204, 34);
			Button6.TabIndex = 54;
			Button6.TabStop = false;
			Button6.Text = "Ajouter une image";
			Button6.TextAlign = ContentAlignment.MiddleRight;
			Button6.UseVisualStyleBackColor = false;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(77, 36);
			REFART.Name = "REFART";
			REFART.Size = new Size(194, 26);
			REFART.TabIndex = 1;
			B_rechercher.BackColor = Color.White;
			B_rechercher.Image = Resources.Actions_document_find_icon1;
			B_rechercher.ImageAlign = ContentAlignment.MiddleLeft;
			B_rechercher.Location = new Point(667, 31);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(127, 39);
			B_rechercher.TabIndex = 4;
			B_rechercher.TabStop = false;
			B_rechercher.Text = "Rechercher";
			B_rechercher.TextAlign = ContentAlignment.MiddleRight;
			B_rechercher.UseVisualStyleBackColor = false;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = SystemColors.ActiveCaptionText;
			Label1.Location = new Point(20, 39);
			Label1.Name = "Label1";
			Label1.Size = new Size(47, 18);
			Label1.TabIndex = 0;
			Label1.Text = "Code";
			Button7.BackColor = Color.White;
			Button7.Image = Resources.Pictures_Canon_icon;
			Button7.ImageAlign = ContentAlignment.MiddleLeft;
			Button7.Location = new Point(60, 137);
			Button7.Name = "Button7";
			Button7.Size = new Size(178, 32);
			Button7.TabIndex = 55;
			Button7.TabStop = false;
			Button7.Text = "Afficher Image Article";
			Button7.TextAlign = ContentAlignment.MiddleRight;
			Button7.UseVisualStyleBackColor = false;
			Label31.AutoSize = true;
			Label31.BackColor = Color.Transparent;
			Label31.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label31.Location = new Point(1079, 137);
			Label31.Name = "Label31";
			Label31.Size = new Size(117, 16);
			Label31.TabIndex = 51;
			Label31.Text = "Historique Article";
			OFGSelectImage.FileName = "OFGSelectImage";
			OFGSelectImage.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP";
			LB_Article.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			LB_Article.FormattingEnabled = true;
			LB_Article.ItemHeight = 18;
			LB_Article.Items.AddRange(new object[2]
			{
				"Article Commercial",
				"Article Montée"
			});
			LB_Article.Location = new Point(68, 78);
			LB_Article.Name = "LB_Article";
			LB_Article.Size = new Size(170, 40);
			LB_Article.TabIndex = 100;
			LB_Article.TabStop = false;
			LB_Article.Visible = false;
			PictureBox1.Location = new Point(52, 55);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(186, 76);
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			Button8.BackColor = Color.DarkRed;
			Button8.BackgroundImage = Resources.Button_Delete_icon;
			Button8.Cursor = Cursors.Hand;
			Button8.Location = new Point(52, 55);
			Button8.Name = "Button8";
			Button8.Size = new Size(23, 23);
			Button8.TabIndex = 109;
			Button8.UseVisualStyleBackColor = false;
			TabPage2.Controls.Add(Label25);
			TabPage2.Controls.Add(PRIX_ATTC);
			TabPage2.Controls.Add(PRIX_AHT);
			TabPage2.Controls.Add(PRIX_GROS);
			TabPage2.Controls.Add(Prix_D2);
			TabPage2.Controls.Add(PRIX_1);
			TabPage2.Controls.Add(Marge1);
			TabPage2.Controls.Add(Marge2);
			TabPage2.Controls.Add(Marge3);
			TabPage2.Controls.Add(Label30);
			TabPage2.Controls.Add(Label7);
			TabPage2.Controls.Add(Label8);
			TabPage2.Controls.Add(Label9);
			TabPage2.Controls.Add(Label3);
			TabPage2.Controls.Add(Label38);
			TabPage2.Controls.Add(Label37);
			TabPage2.Controls.Add(Label5);
			TabPage2.Controls.Add(Label36);
			TabPage2.Controls.Add(Label6);
			TabPage2.Location = new Point(4, 25);
			TabPage2.Name = "TabPage2";
			TabPage2.Padding = new Padding(3);
			TabPage2.Size = new Size(619, 115);
			TabPage2.TabIndex = 1;
			TabPage2.Text = "Achat";
			TabPage2.UseVisualStyleBackColor = true;
			Label25.AutoSize = true;
			Label25.BackColor = Color.Transparent;
			Label25.ForeColor = SystemColors.ActiveCaption;
			Label25.Location = new Point(7, 68);
			Label25.Name = "Label25";
			Label25.Size = new Size(94, 16);
			Label25.TabIndex = 46;
			Label25.Text = "Prix achat TTC";
			PRIX_ATTC.Location = new Point(105, 65);
			PRIX_ATTC.Name = "PRIX_ATTC";
			PRIX_ATTC.ReadOnly = true;
			PRIX_ATTC.Size = new Size(107, 22);
			PRIX_ATTC.TabIndex = 48;
			PRIX_AHT.Location = new Point(105, 34);
			PRIX_AHT.Name = "PRIX_AHT";
			PRIX_AHT.Size = new Size(107, 22);
			PRIX_AHT.TabIndex = 47;
			PRIX_GROS.Location = new Point(489, 78);
			PRIX_GROS.Name = "PRIX_GROS";
			PRIX_GROS.ReadOnly = true;
			PRIX_GROS.Size = new Size(114, 22);
			PRIX_GROS.TabIndex = 42;
			Prix_D2.Location = new Point(489, 50);
			Prix_D2.Name = "Prix_D2";
			Prix_D2.ReadOnly = true;
			Prix_D2.Size = new Size(114, 22);
			Prix_D2.TabIndex = 40;
			PRIX_1.Location = new Point(489, 22);
			PRIX_1.Name = "PRIX_1";
			PRIX_1.ReadOnly = true;
			PRIX_1.Size = new Size(114, 22);
			PRIX_1.TabIndex = 38;
			Marge1.Location = new Point(285, 19);
			Marge1.Name = "Marge1";
			Marge1.Size = new Size(68, 22);
			Marge1.TabIndex = 6;
			Marge2.Location = new Point(285, 51);
			Marge2.Name = "Marge2";
			Marge2.Size = new Size(68, 22);
			Marge2.TabIndex = 7;
			Marge3.Location = new Point(285, 83);
			Marge3.Name = "Marge3";
			Marge3.Size = new Size(68, 22);
			Marge3.TabIndex = 8;
			Label30.AutoSize = true;
			Label30.BackColor = Color.Transparent;
			Label30.ForeColor = SystemColors.ActiveCaption;
			Label30.Location = new Point(7, 38);
			Label30.Name = "Label30";
			Label30.Size = new Size(87, 16);
			Label30.TabIndex = 45;
			Label30.Text = "Prix achat HT";
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.ForeColor = SystemColors.ActiveCaption;
			Label7.Location = new Point(424, 84);
			Label7.Name = "Label7";
			Label7.Size = new Size(60, 16);
			Label7.TabIndex = 41;
			Label7.Text = "Prix gros";
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(406, 56);
			Label8.Name = "Label8";
			Label8.Size = new Size(77, 16);
			Label8.TabIndex = 39;
			Label8.Text = "Prix detail 2";
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.ForeColor = SystemColors.ActiveCaption;
			Label9.Location = new Point(404, 27);
			Label9.Name = "Label9";
			Label9.Size = new Size(77, 16);
			Label9.TabIndex = 37;
			Label9.Text = "Prix detail 1";
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.ForeColor = SystemColors.ActiveCaption;
			Label3.Location = new Point(228, 22);
			Label3.Name = "Label3";
			Label3.Size = new Size(44, 16);
			Label3.TabIndex = 3;
			Label3.Text = "Marge";
			Label38.Location = new Point(359, 85);
			Label38.Name = "Label38";
			Label38.Size = new Size(24, 21);
			Label38.TabIndex = 36;
			Label38.Text = "%";
			Label37.Location = new Point(360, 53);
			Label37.Name = "Label37";
			Label37.Size = new Size(24, 21);
			Label37.TabIndex = 35;
			Label37.Text = "%";
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(228, 56);
			Label5.Name = "Label5";
			Label5.Size = new Size(44, 16);
			Label5.TabIndex = 5;
			Label5.Text = "Marge";
			Label36.Location = new Point(358, 19);
			Label36.Name = "Label36";
			Label36.Size = new Size(24, 21);
			Label36.TabIndex = 34;
			Label36.Text = "%";
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(228, 89);
			Label6.Name = "Label6";
			Label6.Size = new Size(44, 16);
			Label6.TabIndex = 7;
			Label6.Text = "Marge";
			TabPage1.Controls.Add(PV);
			TabPage1.Controls.Add(Label20);
			TabPage1.Controls.Add(PRIX_V);
			TabPage1.Controls.Add(PRIX_HT);
			TabPage1.Controls.Add(Label28);
			TabPage1.Location = new Point(4, 25);
			TabPage1.Name = "TabPage1";
			TabPage1.Padding = new Padding(3);
			TabPage1.Size = new Size(619, 115);
			TabPage1.TabIndex = 0;
			TabPage1.Text = "Vente";
			TabPage1.UseVisualStyleBackColor = true;
			PV.DropDownStyle = ComboBoxStyle.DropDownList;
			PV.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			PV.FormattingEnabled = true;
			PV.Items.AddRange(new object[2]
			{
				"PV HT",
				"PV TTC"
			});
			PV.Location = new Point(52, 42);
			PV.Name = "PV";
			PV.Size = new Size(93, 26);
			PV.TabIndex = 23;
			Label20.AutoSize = true;
			Label20.BackColor = Color.Transparent;
			Label20.ForeColor = SystemColors.ActiveCaptionText;
			Label20.Location = new Point(481, 72);
			Label20.Name = "Label20";
			Label20.Size = new Size(92, 16);
			Label20.TabIndex = 22;
			Label20.Text = "Prix vente TTC";
			Label20.Visible = false;
			PRIX_V.Location = new Point(174, 44);
			PRIX_V.Name = "PRIX_V";
			PRIX_V.Size = new Size(107, 22);
			PRIX_V.TabIndex = 21;
			PRIX_V.Visible = false;
			PRIX_HT.Location = new Point(174, 44);
			PRIX_HT.Name = "PRIX_HT";
			PRIX_HT.Size = new Size(107, 22);
			PRIX_HT.TabIndex = 20;
			Label28.AutoSize = true;
			Label28.BackColor = Color.Transparent;
			Label28.ForeColor = SystemColors.ActiveCaptionText;
			Label28.Location = new Point(481, 97);
			Label28.Name = "Label28";
			Label28.Size = new Size(85, 16);
			Label28.TabIndex = 19;
			Label28.Text = "Prix vente HT";
			Label28.Visible = false;
			TabControl1.Controls.Add(TabPage1);
			TabControl1.Controls.Add(TabPage2);
			TabControl1.Controls.Add(TabPage3);
			TabControl1.Location = new Point(157, 16);
			TabControl1.Name = "TabControl1";
			TabControl1.SelectedIndex = 0;
			TabControl1.Size = new Size(627, 144);
			TabControl1.TabIndex = 37;
			TabPage3.Controls.Add(FDC);
			TabPage3.Controls.Add(Label11);
			TabPage3.Controls.Add(MARGEMAX);
			TabPage3.Controls.Add(Label17);
			TabPage3.Controls.Add(Label18);
			TabPage3.Controls.Add(CODBAR);
			TabPage3.Location = new Point(4, 25);
			TabPage3.Name = "TabPage3";
			TabPage3.Size = new Size(619, 115);
			TabPage3.TabIndex = 2;
			TabPage3.Text = "Autres";
			TabPage3.UseVisualStyleBackColor = true;
			TabControl2.Controls.Add(TabPage4);
			TabControl2.Controls.Add(TabPage5);
			TabControl2.Location = new Point(276, 323);
			TabControl2.Name = "TabControl2";
			TabControl2.SelectedIndex = 0;
			TabControl2.Size = new Size(808, 134);
			TabControl2.TabIndex = 111;
			TabPage4.Controls.Add(NOMFRS);
			TabPage4.Controls.Add(Label10);
			TabPage4.Controls.Add(LinkLabel1);
			TabPage4.Controls.Add(Button11);
			TabPage4.Controls.Add(Label12);
			TabPage4.Controls.Add(Button1);
			TabPage4.Controls.Add(FRS);
			TabPage4.Location = new Point(4, 25);
			TabPage4.Name = "TabPage4";
			TabPage4.Padding = new Padding(3);
			TabPage4.Size = new Size(800, 105);
			TabPage4.TabIndex = 0;
			TabPage4.Text = "Fournisseur";
			TabPage4.UseVisualStyleBackColor = true;
			NOMFRS.Location = new Point(144, 65);
			NOMFRS.Name = "NOMFRS";
			NOMFRS.ReadOnly = true;
			NOMFRS.Size = new Size(265, 22);
			NOMFRS.TabIndex = 63;
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.ForeColor = SystemColors.ActiveCaptionText;
			Label10.Location = new Point(59, 68);
			Label10.Name = "Label10";
			Label10.Size = new Size(45, 16);
			Label10.TabIndex = 62;
			Label10.Text = "Libelle";
			LinkLabel1.AutoSize = true;
			LinkLabel1.Cursor = Cursors.Hand;
			LinkLabel1.Location = new Point(416, 30);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new Size(129, 16);
			LinkLabel1.TabIndex = 61;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Nouveau Fournisseur";
			Button11.BackgroundImage = (Image)componentResourceManager.GetObject("Button11.BackgroundImage");
			Button11.Cursor = Cursors.Hand;
			Button11.Location = new Point(437, 14);
			Button11.Margin = new Padding(3, 4, 3, 4);
			Button11.Name = "Button11";
			Button11.Size = new Size(69, 70);
			Button11.TabIndex = 60;
			Button11.TabStop = false;
			Button11.UseVisualStyleBackColor = true;
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.ForeColor = SystemColors.ActiveCaptionText;
			Label12.Location = new Point(21, 26);
			Label12.Name = "Label12";
			Label12.Size = new Size(110, 16);
			Label12.TabIndex = 9;
			Label12.Text = "Code Fournisseur";
			Button1.Location = new Point(300, 20);
			Button1.Name = "Button1";
			Button1.Size = new Size(29, 28);
			Button1.TabIndex = 19;
			Button1.TabStop = false;
			Button1.Text = "...";
			Button1.UseVisualStyleBackColor = true;
			FRS.AutoCompleteMode = AutoCompleteMode.Suggest;
			FRS.AutoCompleteSource = AutoCompleteSource.ListItems;
			FRS.FormattingEnabled = true;
			FRS.Location = new Point(144, 22);
			FRS.Name = "FRS";
			FRS.Size = new Size(172, 24);
			FRS.Sorted = true;
			FRS.TabIndex = 18;
			TabPage5.Controls.Add(Label15);
			TabPage5.Controls.Add(IDFAM);
			TabPage5.Controls.Add(Label13);
			TabPage5.Controls.Add(LIB_FAM);
			TabPage5.Location = new Point(4, 25);
			TabPage5.Name = "TabPage5";
			TabPage5.Padding = new Padding(3);
			TabPage5.Size = new Size(800, 105);
			TabPage5.TabIndex = 1;
			TabPage5.Text = "Famille";
			TabPage5.UseVisualStyleBackColor = true;
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.ForeColor = SystemColors.ActiveCaption;
			Label15.Location = new Point(28, 24);
			Label15.Name = "Label15";
			Label15.Size = new Size(50, 16);
			Label15.TabIndex = 22;
			Label15.Text = "Famille";
			IDFAM.Location = new Point(89, 21);
			IDFAM.Name = "IDFAM";
			IDFAM.Size = new Size(159, 22);
			IDFAM.TabIndex = 23;
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.ForeColor = SystemColors.ActiveCaption;
			Label13.Location = new Point(28, 65);
			Label13.Name = "Label13";
			Label13.Size = new Size(45, 16);
			Label13.TabIndex = 7;
			Label13.Text = "Libelle";
			LIB_FAM.Location = new Point(88, 62);
			LIB_FAM.Name = "LIB_FAM";
			LIB_FAM.Size = new Size(313, 22);
			LIB_FAM.TabIndex = 21;
			GroupBox2.BackColor = SystemColors.ButtonHighlight;
			GroupBox2.Controls.Add(Label4);
			GroupBox2.Controls.Add(TabControl1);
			GroupBox2.Controls.Add(Label14);
			GroupBox2.Controls.Add(REMISE);
			GroupBox2.Controls.Add(Label16);
			GroupBox2.Controls.Add(TVA);
			GroupBox2.Location = new Point(276, 157);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(800, 166);
			GroupBox2.TabIndex = 112;
			GroupBox2.TabStop = false;
			Label4.Location = new Point(138, 99);
			Label4.Name = "Label4";
			Label4.Size = new Size(17, 21);
			Label4.TabIndex = 49;
			Label4.Text = "%";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(TabControl2);
			base.Controls.Add(Label32);
			base.Controls.Add(Label34);
			base.Controls.Add(Button2);
			base.Controls.Add(Label33);
			base.Controls.Add(Button8);
			base.Controls.Add(Button4);
			base.Controls.Add(Button3);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(LB_Article);
			base.Controls.Add(Button7);
			base.Controls.Add(groupBox6);
			base.Controls.Add(GroupBox4);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(Label31);
			base.Controls.Add(Button23);
			Cursor = Cursors.Hand;
			base.Location = new Point(0, 0);
			base.Name = "Gestion_Article_Com";
			Text = "Article commercial";
			base.Controls.SetChildIndex(Button23, 0);
			base.Controls.SetChildIndex(Label31, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(groupBox6, 0);
			base.Controls.SetChildIndex(Button7, 0);
			base.Controls.SetChildIndex(LB_Article, 0);
			base.Controls.SetChildIndex(PictureBox1, 0);
			base.Controls.SetChildIndex(Button3, 0);
			base.Controls.SetChildIndex(Button4, 0);
			base.Controls.SetChildIndex(Button8, 0);
			base.Controls.SetChildIndex(Label33, 0);
			base.Controls.SetChildIndex(Button2, 0);
			base.Controls.SetChildIndex(Label34, 0);
			base.Controls.SetChildIndex(Label32, 0);
			base.Controls.SetChildIndex(TabControl2, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			groupBox6.ResumeLayout(false);
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			((ISupportInitialize)PictureBox1).EndInit();
			TabPage2.ResumeLayout(false);
			TabPage2.PerformLayout();
			TabPage1.ResumeLayout(false);
			TabPage1.PerformLayout();
			TabControl1.ResumeLayout(false);
			TabPage3.ResumeLayout(false);
			TabPage3.PerformLayout();
			TabControl2.ResumeLayout(false);
			TabPage4.ResumeLayout(false);
			TabPage4.PerformLayout();
			TabPage5.ResumeLayout(false);
			TabPage5.PerformLayout();
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				PictureBox1.Image = null;
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from ARTICLE_D where REFART ='" + REFART.Text + "'";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					PRIX_AHT.Text = mySqlDataReader["PRIX_AHT"].ToString();
					PRIX_ATTC.Text = mySqlDataReader["PRIX_ATTC"].ToString();
					PRIX_V.Text = mySqlDataReader["PRIX_V"].ToString();
					PRIX_HT.Text = mySqlDataReader["PRIX_HT"].ToString();
					Marge1.Text = mySqlDataReader["Marge1"].ToString();
					Marge2.Text = mySqlDataReader["Marge2"].ToString();
					Marge3.Text = mySqlDataReader["Marge3"].ToString();
					PRIX_GROS.Text = mySqlDataReader["PRIX_ATTC"].ToString() + mySqlDataReader["PRIX_GROS"].ToString();
					PRIX_1.Text = mySqlDataReader["PRIX_DET"].ToString();
					Prix_D2.Text = mySqlDataReader["PRIX_DET"].ToString();
					FDC.Text = mySqlDataReader["FDC"].ToString();
					IDFAM.Text = mySqlDataReader["IDFAM"].ToString();
					RAYON.Text = mySqlDataReader["RAYON"].ToString();
					ETAGE.Text = mySqlDataReader["ETAGE"].ToString();
					REMISE.Text = mySqlDataReader["REM"].ToString();
					UNIT.Text = mySqlDataReader["UNIT"].ToString();
					TVA.Text = mySqlDataReader["TVA"].ToString();
					STOK.Text = mySqlDataReader["STOK"].ToString();
					STKMIN.Text = mySqlDataReader["STKMIN"].ToString();
					STKMAG.Text = mySqlDataReader["STKMAG"].ToString();
					STKALERT.Text = mySqlDataReader["STKALERT"].ToString();
					IDFAM.Text = mySqlDataReader["IDFAM"].ToString();
					LIB_FAM.Text = mySqlDataReader["LIB_FAM"].ToString();
					MARGEMAX.Text = mySqlDataReader["MARGEMAX"].ToString();
					FRS.Text = mySqlDataReader["FRS"].ToString();
					if (!(mySqlDataReader["Photo"] == null | mySqlDataReader["Photo"] == DBNull.Value))
					{
						byte[] buffer = (byte[])mySqlDataReader["Photo"];
						Image image = null;
						MemoryStream stream = new MemoryStream(buffer);
						PictureBox1.Image = Image.FromStream(stream);
					}
					else
					{
						PictureBox1.Image = null;
					}
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					FRS_Validated(RuntimeHelpers.GetObjectValue(sender), e);
					CODBAR.Text = REFART.Text;
				}
				LIBART.Focus();
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

		public void B_rechercher_Click(object sender, EventArgs e)
		{
			try
			{
				REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void b_enregistrer_Click(object sender, EventArgs e)
		{
			MemoryStream memoryStream = new MemoryStream();
			if (PictureBox1.Image != null)
			{
				PictureBox1.Image.Save(memoryStream, ImageFormat.Jpeg);
			}
			try
			{
				if (Operators.CompareString(PV.Text, "PV TTC", false) == 0)
				{
					PRIX_HT.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_V.Text)) - Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_V.Text), Globals.convertDN(TVA.Text))) * 0.01);
				}
				else
				{
					PRIX_V.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_HT.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_HT.Text), Globals.convertDN(TVA.Text))) * 0.01);
				}
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				if (checked(Globals.controlNum(PRIX_AHT.Text) + Globals.controlNum(PRIX_ATTC.Text) + Globals.controlNum(PRIX_V.Text) + Globals.controlNum(PRIX_HT.Text) + Globals.controlNum(Marge1.Text) + Globals.controlNum(Marge2.Text) + Globals.controlNum(Marge3.Text) + Globals.controlNum(PRIX_1.Text) + Globals.controlNum(FDC.Text) + Globals.controlNum(REMISE.Text) + Globals.controlNum(TVA.Text) + Globals.controlNum(STOK.Text) + Globals.controlNum(STKMIN.Text) + Globals.controlNum(STKMAG.Text) + Globals.controlNum(MARGEMAX.Text) + Globals.controlNum(STKALERT.Text)) > 0)
				{
					MessageBox.Show("Merci de bien saisir un nombre valide !");
				}
				else if (Operators.CompareString(TVA.Text, "", false) == 0)
				{
					MessageBox.Show("Veuillez entrer TVA");
					TVA.Focus();
				}
				else if (Operators.CompareString(PRIX_HT.Text, "", false) == 0)
				{
					MessageBox.Show("Veuillez entrer Prix vente HT");
					PRIX_HT.Focus();
				}
				else if (Operators.CompareString(PRIX_V.Text, "", false) == 0)
				{
					MessageBox.Show("Veuillez entrer Prix vente TTC");
					PRIX_V.Focus();
				}
				else
				{
					string text = "select * from entree_stock";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
					MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					int num = checked(dataTable.Rows.Count - 1);
					if (num == -1)
					{
						COD_E = 1;
					}
					else
					{
						mySqlCommand.CommandText = "SELECT MAX(code_entree)+1 FROM entree_stock ";
						COD_E = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
					}
					if (Operators.CompareString(NewArticle, "Oui", false) == 0)
					{
						MySqlCommand mySqlCommand2 = new MySqlCommand("INSERT INTO ARTICLE_D(REFART, LIBART, PRIX_AHT, PRIX_ATTC,PRIX_V, PRIX_HT, Marge1, Marge2, Marge3, PRIX_DET, FDC, IDFAM, RAYON, ETAGE, REM, UNIT, TVA, STOK, STKMIN, STKMAG,STKALERT, LIB_FAM, MARGEMAX, FRS, NOMFRS,TYPE_ART,Photo)VALUES('" + REFART.Text + "', '" + LIBART.Text + "', '" + Strings.Replace(PRIX_AHT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(PRIX_ATTC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(PRIX_V.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(PRIX_HT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(Marge1.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(Marge2.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(Marge3.Text, ",", ".", 1, -1, CompareMethod.Binary) + "','" + Strings.Replace(PRIX_1.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(FDC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + IDFAM.Text + "', '" + RAYON.Text + "', '" + ETAGE.Text + "', '" + Strings.Replace(REMISE.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + UNIT.Text + "', '" + Strings.Replace(TVA.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(STOK.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(STKMIN.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(STKMAG.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(STKALERT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + LIB_FAM.Text + "', '" + Strings.Replace(MARGEMAX.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + FRS.Text + "', '" + NOMFRS.Text + "','COMMERCIALE',@Photo)", Globals.conn);
						if (PictureBox1.Image != null)
						{
							mySqlCommand2.Parameters.Add("@Photo", MySqlDbType.VarBinary).Value = memoryStream.GetBuffer();
						}
						else
						{
							mySqlCommand2.Parameters.Add("@Photo", MySqlDbType.VarBinary).Value = DBNull.Value;
						}
						mySqlCommand2.ExecuteNonQuery();
						string query = "INSERT INTO entree_stock(REFART, LIBART, quantite,PRIX_UE, fournisseur, Date_entree, Code_entree, STOCK_AVANT, STOCK_APRES,TYPE_ENTREE)VALUES('" + REFART.Text + "', '" + LIBART.Text + "', '" + Strings.Replace(PRIX_ATTC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(STOK.Text, ",", ".", 1, -1, CompareMethod.Binary) + "','" + FRS.Text + "','" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "','" + Conversions.ToString(COD_E) + "','0','" + Strings.Replace(STOK.Text, ",", ".", 1, -1, CompareMethod.Binary) + "','Entrée intiale')";
						Globals.ExecuteInsertQuery(query);
						MessageBox.Show("Article Ajouté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						Gestion_Article_Load(RuntimeHelpers.GetObjectValue(sender), e);
						REFART.Focus();
						NewArticle = "Non";
					}
					else
					{
						Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART.Text + "'";
						decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
						decimal value2 = new decimal(Convert.ToDouble(Globals.convertDN(STOK.Text)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)));
						MySqlCommand mySqlCommand3 = new MySqlCommand("Update ARTICLE_D set LIBART='" + LIBART.Text + "', PRIX_AHT='" + Strings.Replace(PRIX_AHT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', PRIX_ATTC='" + Strings.Replace(PRIX_ATTC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', PRIX_V='" + Strings.Replace(PRIX_V.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', PRIX_HT='" + Strings.Replace(PRIX_HT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', Marge1='" + Strings.Replace(Marge1.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', Marge2='" + Strings.Replace(Marge2.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', Marge3='" + Strings.Replace(Marge3.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', PRIX_DET='" + Strings.Replace(PRIX_1.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', FDC='" + Strings.Replace(FDC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', IDFAM='" + IDFAM.Text + "', RAYON='" + RAYON.Text + "', ETAGE='" + ETAGE.Text + "', REM='" + Strings.Replace(REMISE.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', UNIT='" + UNIT.Text + "', TVA='" + Strings.Replace(TVA.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', STOK='" + Strings.Replace(STOK.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', STKMIN='" + Strings.Replace(STKMIN.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', STKMAG='" + Strings.Replace(STKMAG.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', STKALERT='" + Strings.Replace(STKALERT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', LIB_FAM='" + LIB_FAM.Text + "', MARGEMAX='" + Strings.Replace(MARGEMAX.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', FRS='" + FRS.Text + "', NOMFRS='" + NOMFRS.Text + "',Photo=@Photo where REFART = '" + REFART.Text + "'", Globals.conn);
						if (PictureBox1.Image != null)
						{
							mySqlCommand3.Parameters.Add("@Photo", MySqlDbType.VarBinary).Value = memoryStream.GetBuffer();
						}
						else
						{
							mySqlCommand3.Parameters.Add("@Photo", MySqlDbType.VarBinary).Value = DBNull.Value;
						}
						mySqlCommand3.ExecuteNonQuery();
						string query2 = "INSERT INTO entree_stock(REFART, LIBART, quantite, PRIX_UE, fournisseur, Date_entree, Code_entree, STOCK_AVANT, STOCK_APRES,TYPE_ENTREE)VALUES('" + REFART.Text + "', '" + LIBART.Text + "', '" + Strings.Replace(PRIX_ATTC.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary) + "','" + FRS.Text + "','" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "','" + Conversions.ToString(COD_E) + "','" + Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary) + "','" + Strings.Replace(STOK.Text, ",", ".", 1, -1, CompareMethod.Binary) + "','Changement stock init')";
						Globals.ExecuteInsertQuery(query2);
						MessageBox.Show("Modification Apporté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						REFART.Focus();
					}
					memoryStream.Close();
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

		private void Gestion_Article_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (PV.Items.Count > 0)
					{
						PV.SelectedIndex = 0;
					}
					if (Operators.CompareString(LB_Article.Text, "Article Commercial", false) == 0)
					{
						TYPARTICLE = "COMMERCIALE";
						Globals.flag_COD = "GARTCOM";
					}
					else if (Operators.CompareString(LB_Article.Text, "Article Montée", false) == 0)
					{
						LB_Article.SelectedItem = "Article Montée";
						TYPARTICLE = "Article montée";
						Globals.flag_COD = "ARTM";
					}
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where TYPE_ART='" + TYPARTICLE + "'";
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
					MySqlCommand mySqlCommand2 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand2);
					DataSet dataSet2 = new DataSet();
					mySqlCommand2.Connection = Globals.conn;
					mySqlCommand2.CommandText = "select distinct IDFRS from FOURN ";
					mySqlDataAdapter2.Fill(dataSet2, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
					int num2 = dataSet2.Tables[0].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						autoCompleteStringCollection2.Add(dataSet2.Tables[0].Rows[j]["IDFRS"].ToString());
					}
					FRS.AutoCompleteSource = AutoCompleteSource.CustomSource;
					FRS.AutoCompleteCustomSource = autoCompleteStringCollection2;
					FRS.AutoCompleteMode = AutoCompleteMode.Suggest;
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

		public void FRS_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select NOMFRS from FOURN where IDFRS ='" + FRS.Text + "'";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					NOMFRS.Text = mySqlDataReader["NOMFRS"].ToString();
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				NOMFRS.Focus();
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

		public void REFART_Validated(object sender, EventArgs e)
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
					goto IL_01fa;
				}
				if (Operators.CompareString(REFART.Text, "", false) != 0)
				{
					if (FlagNew == 0)
					{
						DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir ajouter un article?", "Ajout Article?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
						if (dialogResult == DialogResult.No)
						{
							base.Close();
							REFART.Text = "";
							LIBART.Text = "";
							TVA.Text = "";
							FRS.Text = "";
							Globals.ClearTextBox(this);
							REFART.Focus();
						}
						else
						{
							Globals.ClearTextBox(this);
							LIBART.Text = "";
							TVA.Text = "";
							FRS.Text = "";
							NewArticle = "Oui";
							LIBART.Focus();
						}
					}
					else
					{
						Globals.ClearTextBox(this);
						LIBART.Text = "";
						TVA.Text = "";
						FRS.Text = "";
						NewArticle = "Oui";
						FlagNew = 0;
					}
					goto IL_01fa;
				}
				goto end_IL_0001;
				IL_01fa:
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

		private void Marge1_Leave(object sender, EventArgs e)
		{
			try
			{
				Marge1.Text = Marge1.Text.Replace(".", ",");
				PRIX_1.Text = Conversions.ToString(Convert.ToDouble(Convert.ToDecimal(Globals.convertDN(PRIX_ATTC.Text))) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge1.Text))) * 0.01);
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
			}
		}

		private void Marge2_Leave(object sender, EventArgs e)
		{
			try
			{
				Marge2.Text = Marge2.Text.Replace(".", ",");
				Prix_D2.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge2.Text))) * 0.01);
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
			}
		}

		private void Marge3_Leave(object sender, EventArgs e)
		{
			try
			{
				Marge3.Text = Marge3.Text.Replace(".", ",");
				PRIX_GROS.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge3.Text))) * 0.01);
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
			}
		}

		private void PRIX_A_Leave(object sender, EventArgs e)
		{
			try
			{
				PRIX_ATTC.Text = PRIX_ATTC.Text.Replace(".", ",");
				PRIX_1.Text = Conversions.ToString(Convert.ToDouble(Convert.ToDecimal(Globals.convertDN(PRIX_ATTC.Text))) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge1.Text))) * 0.01);
				Prix_D2.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge2.Text))) * 0.01);
				PRIX_GROS.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge3.Text))) * 0.01);
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
			}
		}

		private void Prix_1_Click(object sender, EventArgs e)
		{
			try
			{
				PRIX_1.Text = Conversions.ToString(Convert.ToDouble(Convert.ToDecimal(Globals.convertDN(PRIX_ATTC.Text))) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge1.Text))) * 0.01);
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
			}
		}

		private void Prix_D2_Click(object sender, EventArgs e)
		{
			try
			{
				Prix_D2.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge2.Text))) * 0.01);
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
			}
		}

		private void Prix_GROS_Click(object sender, EventArgs e)
		{
			try
			{
				PRIX_GROS.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_ATTC.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_ATTC.Text), Globals.convertDN(Marge3.Text))) * 0.01);
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
			}
		}

		private void Button23_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Article.Show();
			MyProject.Forms.Histo_Article.REFART.Text = REFART.Text;
			MyProject.Forms.Histo_Article.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.flag_COD = "GARTCOM";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D where TYPE_ART='" + TYPARTICLE + "'";
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

		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (OFGSelectImage.ShowDialog() == DialogResult.OK)
				{
					PictureBox1.Image = Image.FromFile(OFGSelectImage.FileName);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Image_ARTICLE.Show();
			MyProject.Forms.Image_ARTICLE.REFART.Text = REFART.Text;
			MyProject.Forms.Image_ARTICLE.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void FRS_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDFRS from FOURN where IDFRS LIKE '" + FRS.Text + "%'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				FRS.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					FRS_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					DialogResult dialogResult = MessageBox.Show("Ce Fournisseur n'existe pas,Etes vous sûre de vouloir ajouter ce Fournisseur?", "Ajout Fournisseur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						FRS.Text = "";
						NOMFRS.Text = "";
					}
					else
					{
						MyProject.Forms.Gestion_Fourn.Show();
						MyProject.Forms.Gestion_Fourn.BringToFront();
						Globals.ClearTextBox(MyProject.Forms.Gestion_Fourn);
						Globals.ClearComboBox(MyProject.Forms.Gestion_Fourn);
						MyProject.Forms.Gestion_Fourn.IDFRS.Text = FRS.Text;
						MyProject.Forms.Gestion_Fourn.IDFRS_Validated(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void LB_Article_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Gestion_Article_Load(RuntimeHelpers.GetObjectValue(sender), e);
				if (Operators.CompareString(LB_Article.Text, "Article Commercial", false) == 0)
				{
					LB_Article.SelectedItem = "Article Commercial";
					TYPARTICLE = "COMMERCIALE";
					Globals.flag_COD = "GARTCOM";
					Globals.ClearTextBox(this);
					Globals.ClearComboBox(this);
				}
				else if (Operators.CompareString(LB_Article.Text, "Article Montée", false) == 0)
				{
					LB_Article.SelectedItem = "Article Montée";
					TYPARTICLE = "Article montée";
					Globals.flag_COD = "ARTM";
					Globals.ClearTextBox(this);
					Globals.ClearComboBox(this);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}

		private void B_rechercher_Enter(object sender, EventArgs e)
		{
		}

		private void b_enregistrer_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir enregistrer?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				b_enregistrer_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void b_imprimer_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Accueil.ImprimerToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		private void FRS_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button1_Click(1, e);
				e.Handled = true;
			}
		}

		private void TVA_Leave(object sender, EventArgs e)
		{
			try
			{
				PRIX_V.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_HT.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_HT.Text), Globals.convertDN(TVA.Text))) * 0.01);
				PRIX_ATTC.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_AHT.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_AHT.Text), Globals.convertDN(TVA.Text))) * 0.01);
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
			}
		}

		private void TVA_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			PictureBox1.Image = null;
		}

		private void PRIX_HT_TextChanged(object sender, EventArgs e)
		{
		}

		private void PRIX_AHT_TextChanged(object sender, EventArgs e)
		{
			try
			{
				PRIX_ATTC.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(PRIX_AHT.Text)) + Convert.ToDouble(decimal.Multiply(Globals.convertDN(PRIX_AHT.Text), Globals.convertDN(TVA.Text))) * 0.01);
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
			}
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Globals.flag_COD = "GAF";
			MyProject.Forms.Affich_ID_FRS.Show();
		}

		private void FRS_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cet article?", "Suppression Article?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM ARTICLE_D WHERE REFART='" + REFART.Text + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					MessageBox.Show("Article supprimé");
					Globals.ClearTextBox(this);
					Globals.ClearComboBox(this);
					REFART.Focus();
					Gestion_Article_Load(e, e);
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

		private void PV_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(PV.Text, "PV HT", false) == 0)
			{
				PRIX_V.Visible = false;
				PRIX_HT.Visible = true;
			}
			else if (Operators.CompareString(PV.Text, "PV TTC", false) == 0)
			{
				PRIX_V.Visible = true;
				PRIX_HT.Visible = false;
			}
		}

		private void PRIX_V_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
