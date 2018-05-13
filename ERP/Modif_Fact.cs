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
	public class Modif_Fact : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GB_COM")]
		private GroupBox _GB_COM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox11")]
		private GroupBox _GroupBox11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("stock_C")]
		private Label _stock_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("total_C")]
		private TextBox _total_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_VC")]
		private TextBox _PRIX_VC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ValRem_C")]
		private TextBox _ValRem_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Remise_C")]
		private TextBox _Remise_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("qte_C")]
		private TextBox _qte_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART_C")]
		private ComboBox _LIBART_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART_C")]
		private ComboBox _REFART_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button27")]
		private Button _Button27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox12")]
		private GroupBox _GroupBox12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Enregistrer")]
		private Button _Enregistrer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("transp")]
		private TextBox _transp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTALV")]
		private Label _TOTALV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

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
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LB_Article")]
		private ListBox _LB_Article;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

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
		[AccessedThroughProperty("IDCLIENT")]
		private ComboBox _IDCLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HISTOCLIENT")]
		private Button _HISTOCLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("VlidFacture")]
		private Button _VlidFacture;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("comment")]
		private TextBox _comment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Supprimer1ligne")]
		private Button _Supprimer1ligne;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Modifier")]
		private Button _Modifier;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider_C")]
		private Button _Valider_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

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
		[AccessedThroughProperty("LinkLabel2")]
		private LinkLabel _LinkLabel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Initier")]
		private Button _Initier;

		public string TYPEFACT;

		public string TABLEFACT;

		public string TABLEDETAIL;

		public int NUM_DEV;

		public int NUM_DF;

		public int flag_DEV;

		public int COD_S;

		internal virtual GroupBox GB_COM
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox11
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button20
		{
			[CompilerGenerated]
			get
			{
				return _Button20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button20_Click;
				Button button = _Button20;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button20 = value;
				button = _Button20;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label stock_C
		{
			[CompilerGenerated]
			get
			{
				return _stock_C;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = stock_C_Click;
				Label stock_C = _stock_C;
				if (stock_C != null)
				{
					stock_C.Click -= value2;
				}
				_stock_C = value;
				stock_C = _stock_C;
				if (stock_C != null)
				{
					stock_C.Click += value2;
				}
			}
		}

		internal virtual TextBox total_C
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

		internal virtual TextBox PRIX_VC
		{
			[CompilerGenerated]
			get
			{
				return _PRIX_VC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PRIX_VC_Validated;
				TextBox pRIX_VC = _PRIX_VC;
				if (pRIX_VC != null)
				{
					pRIX_VC.Validated -= value2;
				}
				_PRIX_VC = value;
				pRIX_VC = _PRIX_VC;
				if (pRIX_VC != null)
				{
					pRIX_VC.Validated += value2;
				}
			}
		}

		internal virtual Label Label18
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox ValRem_C
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

		internal virtual TextBox Remise_C
		{
			[CompilerGenerated]
			get
			{
				return _Remise_C;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Remise_C_Validated;
				TextBox remise_C = _Remise_C;
				if (remise_C != null)
				{
					remise_C.Validated -= value2;
				}
				_Remise_C = value;
				remise_C = _Remise_C;
				if (remise_C != null)
				{
					remise_C.Validated += value2;
				}
			}
		}

		internal virtual Label Label20
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox qte_C
		{
			[CompilerGenerated]
			get
			{
				return _qte_C;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = qte_C_Validated;
				TextBox qte_C = _qte_C;
				if (qte_C != null)
				{
					qte_C.Validated -= value2;
				}
				_qte_C = value;
				qte_C = _qte_C;
				if (qte_C != null)
				{
					qte_C.Validated += value2;
				}
			}
		}

		internal virtual Label Label21
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

		public virtual ComboBox LIBART_C
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox REFART_C
		{
			[CompilerGenerated]
			get
			{
				return _REFART_C;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = REFART_C_KeyDown;
				EventHandler value3 = REFART_C_SelectedIndexChanged;
				EventHandler value4 = REFART_C_Validated;
				ComboBox rEFART_C = _REFART_C;
				if (rEFART_C != null)
				{
					rEFART_C.KeyDown -= value2;
					rEFART_C.SelectedIndexChanged -= value3;
					rEFART_C.Validated -= value4;
				}
				_REFART_C = value;
				rEFART_C = _REFART_C;
				if (rEFART_C != null)
				{
					rEFART_C.KeyDown += value2;
					rEFART_C.SelectedIndexChanged += value3;
					rEFART_C.Validated += value4;
				}
			}
		}

		internal virtual Button Button21
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button23
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button27
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

		internal virtual GroupBox GroupBox12
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

		internal virtual Label Label26
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

		internal virtual Button Enregistrer
		{
			[CompilerGenerated]
			get
			{
				return _Enregistrer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Enregistrer_Click;
				Button enregistrer = _Enregistrer;
				if (enregistrer != null)
				{
					enregistrer.Click -= value2;
				}
				_Enregistrer = value;
				enregistrer = _Enregistrer;
				if (enregistrer != null)
				{
					enregistrer.Click += value2;
				}
			}
		}

		internal virtual TextBox transp
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

		internal virtual Label TOTALV
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
				EventHandler value2 = dgv1_DoubleClick;
				DataGridView dgv = _dgv1;
				if (dgv != null)
				{
					dgv.DoubleClick -= value2;
				}
				_dgv1 = value;
				dgv = _dgv1;
				if (dgv != null)
				{
					dgv.DoubleClick += value2;
				}
			}
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
				EventHandler value3 = Button19_Enter;
				Button button = _Button19;
				if (button != null)
				{
					button.Click -= value2;
					button.Enter -= value3;
				}
				_Button19 = value;
				button = _Button19;
				if (button != null)
				{
					button.Click += value2;
					button.Enter += value3;
				}
			}
		}

		internal virtual Label Label27
		{
			[CompilerGenerated]
			get
			{
				return _Label27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label27_Click;
				Label label = _Label27;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label27 = value;
				label = _Label27;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		internal virtual ListBox LB_Article
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
				ComboBox iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown -= value2;
					iDCLIENT.SelectedIndexChanged -= value3;
				}
				_IDCLIENT = value;
				iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown += value2;
					iDCLIENT.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual Button HISTOCLIENT
		{
			[CompilerGenerated]
			get
			{
				return _HISTOCLIENT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HISTO_CLIENT_Click;
				Button hISTOCLIENT = _HISTOCLIENT;
				if (hISTOCLIENT != null)
				{
					hISTOCLIENT.Click -= value2;
				}
				_HISTOCLIENT = value;
				hISTOCLIENT = _HISTOCLIENT;
				if (hISTOCLIENT != null)
				{
					hISTOCLIENT.Click += value2;
				}
			}
		}

		internal virtual Button Button16
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual GroupBox GroupBox6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label28
		{
			[CompilerGenerated]
			get
			{
				return _Label28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label28_Click;
				Label label = _Label28;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label28 = value;
				label = _Label28;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		internal virtual Button VlidFacture
		{
			[CompilerGenerated]
			get
			{
				return _VlidFacture;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = VlidFacture_Click;
				Button vlidFacture = _VlidFacture;
				if (vlidFacture != null)
				{
					vlidFacture.Click -= value2;
				}
				_VlidFacture = value;
				vlidFacture = _VlidFacture;
				if (vlidFacture != null)
				{
					vlidFacture.Click += value2;
				}
			}
		}

		internal virtual Button Button17
		{
			[CompilerGenerated]
			get
			{
				return _Button17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button17_Click;
				Button button = _Button17;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button17 = value;
				button = _Button17;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button18
		{
			[CompilerGenerated]
			get
			{
				return _Button18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button18_Click;
				Button button = _Button18;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button18 = value;
				button = _Button18;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox comment
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

		internal virtual Button Button13
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button14
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Supprimer1ligne
		{
			[CompilerGenerated]
			get
			{
				return _Supprimer1ligne;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Supprim_Click;
				Button supprimer1ligne = _Supprimer1ligne;
				if (supprimer1ligne != null)
				{
					supprimer1ligne.Click -= value2;
				}
				_Supprimer1ligne = value;
				supprimer1ligne = _Supprimer1ligne;
				if (supprimer1ligne != null)
				{
					supprimer1ligne.Click += value2;
				}
			}
		}

		internal virtual Button Modifier
		{
			[CompilerGenerated]
			get
			{
				return _Modifier;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Modifier_Click;
				Button modifier = _Modifier;
				if (modifier != null)
				{
					modifier.Click -= value2;
				}
				_Modifier = value;
				modifier = _Modifier;
				if (modifier != null)
				{
					modifier.Click += value2;
				}
			}
		}

		internal virtual Button Button10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Valider_C
		{
			[CompilerGenerated]
			get
			{
				return _Valider_C;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Valider_C_Click;
				EventHandler value3 = Valider_C_Enter;
				EventHandler value4 = Valider_C_Validated;
				Button valider_C = _Valider_C;
				if (valider_C != null)
				{
					valider_C.Click -= value2;
					valider_C.Enter -= value3;
					valider_C.Validated -= value4;
				}
				_Valider_C = value;
				valider_C = _Valider_C;
				if (valider_C != null)
				{
					valider_C.Click += value2;
					valider_C.Enter += value3;
					valider_C.Validated += value4;
				}
			}
		}

		internal virtual Button Button29
		{
			[CompilerGenerated]
			get
			{
				return _Button29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button29_Click;
				Button button = _Button29;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button29 = value;
				button = _Button29;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Label29
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
				KeyEventHandler value2 = FRS_KeyDown;
				EventHandler value3 = FRS_TextChanged;
				EventHandler value4 = FRS_Validated;
				ComboBox fRS = _FRS;
				if (fRS != null)
				{
					fRS.KeyDown -= value2;
					fRS.TextChanged -= value3;
					fRS.Validated -= value4;
				}
				_FRS = value;
				fRS = _FRS;
				if (fRS != null)
				{
					fRS.KeyDown += value2;
					fRS.TextChanged += value3;
					fRS.Validated += value4;
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

		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return _Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label1_Click_1;
				Label label = _Label1;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label1 = value;
				label = _Label1;
				if (label != null)
				{
					label.Click += value2;
				}
			}
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

		internal virtual Label Label3
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

		internal virtual Button Initier
		{
			[CompilerGenerated]
			get
			{
				return _Initier;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Initier_Click;
				Button initier = _Initier;
				if (initier != null)
				{
					initier.Click -= value2;
				}
				_Initier = value;
				initier = _Initier;
				if (initier != null)
				{
					initier.Click += value2;
				}
			}
		}

		public Modif_Fact()
		{
			base.Load += Modif_Fact_Load;
			flag_DEV = 1;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Modif_Fact));
			GB_COM = new GroupBox();
			GroupBox12 = new GroupBox();
			Label25 = new Label();
			Label26 = new Label();
			GroupBox11 = new GroupBox();
			Valider_C = new Button();
			Button29 = new Button();
			Button20 = new Button();
			stock_C = new Label();
			total_C = new TextBox();
			Label17 = new Label();
			PRIX_VC = new TextBox();
			Label18 = new Label();
			ValRem_C = new TextBox();
			Label19 = new Label();
			Remise_C = new TextBox();
			Label20 = new Label();
			qte_C = new TextBox();
			Label21 = new Label();
			Label22 = new Label();
			LIBART_C = new ComboBox();
			REFART_C = new ComboBox();
			Button21 = new Button();
			Button23 = new Button();
			Button27 = new Button();
			Label24 = new Label();
			Label4 = new Label();
			Enregistrer = new Button();
			transp = new TextBox();
			GroupBox2 = new GroupBox();
			TOTALV = new Label();
			Label2 = new Label();
			ShapeContainer2 = new ShapeContainer();
			LineShape2 = new LineShape();
			dgv1 = new DataGridView();
			Button19 = new Button();
			Label27 = new Label();
			LB_Article = new ListBox();
			GroupBox4 = new GroupBox();
			HISTOCLIENT = new Button();
			Label30 = new Label();
			Button2 = new Button();
			Label3 = new Label();
			Label1 = new Label();
			Button1 = new Button();
			FRS = new ComboBox();
			LinkLabel2 = new LinkLabel();
			LinkLabel1 = new LinkLabel();
			Button11 = new Button();
			Label29 = new Label();
			IDCLIENT = new ComboBox();
			Button16 = new Button();
			GroupBox6 = new GroupBox();
			Label28 = new Label();
			VlidFacture = new Button();
			Button17 = new Button();
			Button18 = new Button();
			GroupBox5 = new GroupBox();
			comment = new TextBox();
			Label5 = new Label();
			Button13 = new Button();
			Button14 = new Button();
			Supprimer1ligne = new Button();
			Modifier = new Button();
			Button10 = new Button();
			Initier = new Button();
			GB_COM.SuspendLayout();
			GroupBox12.SuspendLayout();
			GroupBox11.SuspendLayout();
			GroupBox2.SuspendLayout();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox4.SuspendLayout();
			GroupBox6.SuspendLayout();
			GroupBox5.SuspendLayout();
			base.SuspendLayout();
			GB_COM.BackColor = Color.Transparent;
			GB_COM.Controls.Add(GroupBox12);
			GB_COM.Controls.Add(GroupBox11);
			GB_COM.Location = new Point(21, 232);
			GB_COM.Name = "GB_COM";
			GB_COM.Size = new Size(460, 316);
			GB_COM.TabIndex = 2;
			GB_COM.TabStop = false;
			GroupBox12.BackColor = Color.Transparent;
			GroupBox12.Controls.Add(Label25);
			GroupBox12.Controls.Add(Label26);
			GroupBox12.Location = new Point(11, 15);
			GroupBox12.Name = "GroupBox12";
			GroupBox12.Size = new Size(442, 41);
			GroupBox12.TabIndex = 28;
			GroupBox12.TabStop = false;
			Label25.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label25.Location = new Point(373, 10);
			Label25.Name = "Label25";
			Label25.Size = new Size(54, 28);
			Label25.TabIndex = 1;
			Label25.Text = "Vente";
			Label26.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label26.Location = new Point(24, 10);
			Label26.Name = "Label26";
			Label26.Size = new Size(130, 28);
			Label26.TabIndex = 0;
			Label26.Text = "Article N°";
			GroupBox11.BackColor = Color.Transparent;
			GroupBox11.Controls.Add(Valider_C);
			GroupBox11.Controls.Add(Button29);
			GroupBox11.Controls.Add(Button20);
			GroupBox11.Controls.Add(stock_C);
			GroupBox11.Controls.Add(total_C);
			GroupBox11.Controls.Add(Label17);
			GroupBox11.Controls.Add(PRIX_VC);
			GroupBox11.Controls.Add(Label18);
			GroupBox11.Controls.Add(ValRem_C);
			GroupBox11.Controls.Add(Label19);
			GroupBox11.Controls.Add(Remise_C);
			GroupBox11.Controls.Add(Label20);
			GroupBox11.Controls.Add(qte_C);
			GroupBox11.Controls.Add(Label21);
			GroupBox11.Controls.Add(Label22);
			GroupBox11.Controls.Add(LIBART_C);
			GroupBox11.Controls.Add(REFART_C);
			GroupBox11.Controls.Add(Button21);
			GroupBox11.Controls.Add(Button23);
			GroupBox11.Controls.Add(Button27);
			GroupBox11.Controls.Add(Label24);
			GroupBox11.Location = new Point(6, 56);
			GroupBox11.Name = "GroupBox11";
			GroupBox11.Size = new Size(453, 258);
			GroupBox11.TabIndex = 29;
			GroupBox11.TabStop = false;
			Valider_C.BackColor = Color.Transparent;
			Valider_C.Cursor = Cursors.Hand;
			Valider_C.FlatStyle = FlatStyle.Flat;
			Valider_C.ForeColor = Color.Transparent;
			Valider_C.Image = (Image)componentResourceManager.GetObject("Valider_C.Image");
			Valider_C.Location = new Point(274, 193);
			Valider_C.Name = "Valider_C";
			Valider_C.Size = new Size(143, 47);
			Valider_C.TabIndex = 3;
			Valider_C.UseVisualStyleBackColor = false;
			Button29.BackColor = Color.Transparent;
			Button29.BackgroundImage = (Image)componentResourceManager.GetObject("Button29.BackgroundImage");
			Button29.Cursor = Cursors.Hand;
			Button29.FlatStyle = FlatStyle.Flat;
			Button29.ForeColor = Color.Transparent;
			Button29.Location = new Point(38, 193);
			Button29.Name = "Button29";
			Button29.Size = new Size(127, 47);
			Button29.TabIndex = 30;
			Button29.TabStop = false;
			Button29.UseVisualStyleBackColor = false;
			Button20.Location = new Point(274, 11);
			Button20.Name = "Button20";
			Button20.Size = new Size(33, 26);
			Button20.TabIndex = 47;
			Button20.TabStop = false;
			Button20.Text = "...";
			Button20.UseVisualStyleBackColor = true;
			stock_C.AutoSize = true;
			stock_C.Location = new Point(295, 58);
			stock_C.Name = "stock_C";
			stock_C.Size = new Size(0, 16);
			stock_C.TabIndex = 50;
			total_C.Location = new Point(364, 134);
			total_C.Name = "total_C";
			total_C.ReadOnly = true;
			total_C.Size = new Size(81, 22);
			total_C.TabIndex = 49;
			total_C.TabStop = false;
			total_C.Text = "0.00";
			Label17.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label17.Location = new Point(382, 110);
			Label17.Name = "Label17";
			Label17.Size = new Size(47, 21);
			Label17.TabIndex = 48;
			Label17.Text = "Total";
			PRIX_VC.Location = new Point(96, 134);
			PRIX_VC.Name = "PRIX_VC";
			PRIX_VC.ReadOnly = true;
			PRIX_VC.Size = new Size(81, 22);
			PRIX_VC.TabIndex = 47;
			PRIX_VC.TabStop = false;
			PRIX_VC.Text = "0.00";
			Label18.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label18.Location = new Point(117, 110);
			Label18.Name = "Label18";
			Label18.Size = new Size(60, 21);
			Label18.TabIndex = 46;
			Label18.Text = "Prix U.";
			ValRem_C.Location = new Point(274, 134);
			ValRem_C.Name = "ValRem_C";
			ValRem_C.ReadOnly = true;
			ValRem_C.Size = new Size(81, 22);
			ValRem_C.TabIndex = 45;
			ValRem_C.TabStop = false;
			ValRem_C.Text = "0.00";
			Label19.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label19.Location = new Point(201, 110);
			Label19.Name = "Label19";
			Label19.Size = new Size(63, 21);
			Label19.TabIndex = 44;
			Label19.Text = "%Rem.";
			Remise_C.Location = new Point(183, 134);
			Remise_C.Name = "Remise_C";
			Remise_C.ReadOnly = true;
			Remise_C.Size = new Size(81, 22);
			Remise_C.TabIndex = 43;
			Remise_C.TabStop = false;
			Remise_C.Text = "0.00";
			Label20.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label20.Location = new Point(274, 107);
			Label20.Name = "Label20";
			Label20.Size = new Size(75, 21);
			Label20.TabIndex = 42;
			Label20.Text = "Rem.  DT";
			qte_C.Location = new Point(9, 134);
			qte_C.Name = "qte_C";
			qte_C.Size = new Size(81, 22);
			qte_C.TabIndex = 2;
			qte_C.Text = "1";
			Label21.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label21.Location = new Point(29, 110);
			Label21.Name = "Label21";
			Label21.Size = new Size(31, 21);
			Label21.TabIndex = 40;
			Label21.Text = "Qté";
			Label22.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label22.Location = new Point(8, 55);
			Label22.Name = "Label22";
			Label22.Size = new Size(76, 22);
			Label22.TabIndex = 38;
			Label22.Text = "Lib. Article";
			LIBART_C.DropDownStyle = ComboBoxStyle.Simple;
			LIBART_C.FormattingEnabled = true;
			LIBART_C.Location = new Point(86, 55);
			LIBART_C.Name = "LIBART_C";
			LIBART_C.Size = new Size(203, 24);
			LIBART_C.TabIndex = 37;
			LIBART_C.TabStop = false;
			REFART_C.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART_C.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART_C.FormattingEnabled = true;
			REFART_C.Location = new Point(86, 13);
			REFART_C.Name = "REFART_C";
			REFART_C.Size = new Size(203, 24);
			REFART_C.TabIndex = 1;
			Button21.BackColor = Color.Transparent;
			Button21.Cursor = Cursors.Hand;
			Button21.FlatStyle = FlatStyle.Flat;
			Button21.ForeColor = Color.Transparent;
			Button21.Location = new Point(303, 13);
			Button21.Name = "Button21";
			Button21.Size = new Size(20, 24);
			Button21.TabIndex = 30;
			Button21.UseVisualStyleBackColor = false;
			Button23.BackColor = Color.Transparent;
			Button23.Cursor = Cursors.Hand;
			Button23.FlatStyle = FlatStyle.Flat;
			Button23.ForeColor = Color.Transparent;
			Button23.Location = new Point(383, 13);
			Button23.Name = "Button23";
			Button23.Size = new Size(45, 36);
			Button23.TabIndex = 27;
			Button23.UseVisualStyleBackColor = false;
			Button27.BackColor = Color.Transparent;
			Button27.Cursor = Cursors.Hand;
			Button27.FlatStyle = FlatStyle.Flat;
			Button27.ForeColor = Color.Transparent;
			Button27.Location = new Point(385, 55);
			Button27.Name = "Button27";
			Button27.Size = new Size(44, 47);
			Button27.TabIndex = 26;
			Button27.UseVisualStyleBackColor = false;
			Label24.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label24.Location = new Point(8, 18);
			Label24.Name = "Label24";
			Label24.Size = new Size(76, 22);
			Label24.TabIndex = 2;
			Label24.Text = "Réf. Article";
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(553, 486);
			Label4.Name = "Label4";
			Label4.Size = new Size(112, 21);
			Label4.TabIndex = 64;
			Label4.Text = "Frais Tranasport";
			Enregistrer.Location = new Point(575, 593);
			Enregistrer.Name = "Enregistrer";
			Enregistrer.Size = new Size(90, 40);
			Enregistrer.TabIndex = 63;
			Enregistrer.Text = "Enregistrer";
			Enregistrer.UseVisualStyleBackColor = true;
			Enregistrer.Visible = false;
			transp.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			transp.Location = new Point(669, 481);
			transp.Name = "transp";
			transp.Size = new Size(74, 26);
			transp.TabIndex = 15;
			transp.Text = "0.00";
			GroupBox2.BackColor = Color.LemonChiffon;
			GroupBox2.Controls.Add(TOTALV);
			GroupBox2.Controls.Add(Label2);
			GroupBox2.Controls.Add(ShapeContainer2);
			GroupBox2.Location = new Point(859, 56);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(178, 148);
			GroupBox2.TabIndex = 56;
			GroupBox2.TabStop = false;
			TOTALV.Font = new Font("Arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			TOTALV.Location = new Point(6, 56);
			TOTALV.Name = "TOTALV";
			TOTALV.Size = new Size(166, 57);
			TOTALV.TabIndex = 3;
			TOTALV.Text = "0.00 DT";
			TOTALV.TextAlign = ContentAlignment.MiddleCenter;
			Label2.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(41, 18);
			Label2.Name = "Label2";
			Label2.Size = new Size(111, 26);
			Label2.TabIndex = 1;
			Label2.Text = "Total (DT)";
			ShapeContainer2.Location = new Point(3, 18);
			ShapeContainer2.Margin = new Padding(0);
			ShapeContainer2.Name = "ShapeContainer2";
			ShapeContainer2.Shapes.AddRange(new Shape[1]
			{
				LineShape2
			});
			ShapeContainer2.Size = new Size(172, 127);
			ShapeContainer2.TabIndex = 2;
			ShapeContainer2.TabStop = false;
			LineShape2.BorderColor = SystemColors.AppWorkspace;
			LineShape2.Name = "LineShape2";
			LineShape2.X1 = -12;
			LineShape2.X2 = 170;
			LineShape2.Y1 = 27;
			LineShape2.Y2 = 28;
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv1.BackgroundColor = Color.White;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(509, 205);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(749, 259);
			dgv1.TabIndex = 57;
			Button19.BackColor = Color.CornflowerBlue;
			Button19.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button19.Location = new Point(578, 516);
			Button19.Margin = new Padding(3, 4, 3, 4);
			Button19.Name = "Button19";
			Button19.Size = new Size(141, 40);
			Button19.TabIndex = 16;
			Button19.Text = "Valider F.Transport";
			Button19.UseVisualStyleBackColor = false;
			Label27.Cursor = Cursors.Hand;
			Label27.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label27.Location = new Point(463, 37);
			Label27.Name = "Label27";
			Label27.Size = new Size(103, 30);
			Label27.TabIndex = 31;
			Label27.Text = "Afiicher Devis";
			LB_Article.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			LB_Article.FormattingEnabled = true;
			LB_Article.ItemHeight = 18;
			LB_Article.Items.AddRange(new object[2]
			{
				"Article Commercial",
				"Article Montée"
			});
			LB_Article.Location = new Point(164, 185);
			LB_Article.Name = "LB_Article";
			LB_Article.Size = new Size(170, 40);
			LB_Article.TabIndex = 68;
			LB_Article.TabStop = false;
			LB_Article.Visible = false;
			GroupBox4.BackColor = SystemColors.Menu;
			GroupBox4.Controls.Add(HISTOCLIENT);
			GroupBox4.Controls.Add(Label30);
			GroupBox4.Controls.Add(Button2);
			GroupBox4.Controls.Add(Label3);
			GroupBox4.Controls.Add(Label1);
			GroupBox4.Controls.Add(Button1);
			GroupBox4.Controls.Add(FRS);
			GroupBox4.Controls.Add(LinkLabel2);
			GroupBox4.Controls.Add(LinkLabel1);
			GroupBox4.Controls.Add(Button11);
			GroupBox4.Controls.Add(Label29);
			GroupBox4.Controls.Add(IDCLIENT);
			GroupBox4.Controls.Add(Button16);
			GroupBox4.Location = new Point(57, 62);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Size = new Size(424, 107);
			GroupBox4.TabIndex = 0;
			GroupBox4.TabStop = false;
			HISTOCLIENT.BackColor = Color.Transparent;
			HISTOCLIENT.BackgroundImage = (Image)componentResourceManager.GetObject("HISTOCLIENT.BackgroundImage");
			HISTOCLIENT.Cursor = Cursors.Hand;
			HISTOCLIENT.FlatStyle = FlatStyle.Flat;
			HISTOCLIENT.ForeColor = Color.Transparent;
			HISTOCLIENT.Location = new Point(224, 21);
			HISTOCLIENT.Name = "HISTOCLIENT";
			HISTOCLIENT.Size = new Size(189, 47);
			HISTOCLIENT.TabIndex = 23;
			HISTOCLIENT.TabStop = false;
			HISTOCLIENT.UseVisualStyleBackColor = false;
			HISTOCLIENT.Visible = false;
			Label30.Location = new Point(185, 50);
			Label30.Name = "Label30";
			Label30.Size = new Size(17, 13);
			Label30.TabIndex = 76;
			Button2.BackgroundImage = (Image)componentResourceManager.GetObject("Button2.BackgroundImage");
			Button2.Cursor = Cursors.Hand;
			Button2.Location = new Point(276, 7);
			Button2.Margin = new Padding(3, 4, 3, 4);
			Button2.Name = "Button2";
			Button2.Size = new Size(86, 74);
			Button2.TabIndex = 72;
			Button2.TabStop = false;
			Button2.UseVisualStyleBackColor = true;
			Button2.Visible = false;
			Label3.Location = new Point(298, 18);
			Label3.Name = "Label3";
			Label3.Size = new Size(115, 50);
			Label3.TabIndex = 72;
			Label3.Visible = false;
			Label1.BackColor = Color.Transparent;
			Label1.Cursor = Cursors.Hand;
			Label1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(247, 85);
			Label1.Name = "Label1";
			Label1.Size = new Size(158, 19);
			Label1.TabIndex = 72;
			Label1.Text = "Historique Fournisseur";
			Label1.Visible = false;
			Button1.Location = new Point(172, 23);
			Button1.Name = "Button1";
			Button1.Size = new Size(30, 28);
			Button1.TabIndex = 74;
			Button1.TabStop = false;
			Button1.Text = "...";
			Button1.UseVisualStyleBackColor = true;
			Button1.Visible = false;
			FRS.AutoCompleteMode = AutoCompleteMode.Suggest;
			FRS.AutoCompleteSource = AutoCompleteSource.ListItems;
			FRS.FormattingEnabled = true;
			FRS.Location = new Point(77, 25);
			FRS.Name = "FRS";
			FRS.Size = new Size(121, 24);
			FRS.Sorted = true;
			FRS.TabIndex = 1;
			FRS.Visible = false;
			LinkLabel2.AutoSize = true;
			LinkLabel2.Location = new Point(3, 68);
			LinkLabel2.Name = "LinkLabel2";
			LinkLabel2.Size = new Size(129, 16);
			LinkLabel2.TabIndex = 75;
			LinkLabel2.TabStop = true;
			LinkLabel2.Text = "Nouveau Fournisseur";
			LinkLabel2.Visible = false;
			LinkLabel1.AutoSize = true;
			LinkLabel1.Location = new Point(7, 68);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new Size(94, 16);
			LinkLabel1.TabIndex = 48;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Nouveau Client";
			Button11.Location = new Point(169, 23);
			Button11.Name = "Button11";
			Button11.Size = new Size(33, 28);
			Button11.TabIndex = 47;
			Button11.Text = "...";
			Button11.UseVisualStyleBackColor = true;
			Label29.BackColor = Color.Transparent;
			Label29.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label29.ForeColor = SystemColors.ActiveCaption;
			Label29.Location = new Point(74, 50);
			Label29.Name = "Label29";
			Label29.Size = new Size(128, 18);
			Label29.TabIndex = 73;
			Label29.Text = "Fournisseurs";
			Label29.Visible = false;
			IDCLIENT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			IDCLIENT.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDCLIENT.FormattingEnabled = true;
			IDCLIENT.Location = new Point(83, 25);
			IDCLIENT.Margin = new Padding(4, 3, 4, 3);
			IDCLIENT.Name = "IDCLIENT";
			IDCLIENT.Size = new Size(102, 24);
			IDCLIENT.TabIndex = 2;
			Button16.BackColor = Color.Transparent;
			Button16.BackgroundImage = (Image)componentResourceManager.GetObject("Button16.BackgroundImage");
			Button16.Cursor = Cursors.Hand;
			Button16.FlatStyle = FlatStyle.Flat;
			Button16.ForeColor = Color.Transparent;
			Button16.Location = new Point(27, 21);
			Button16.Name = "Button16";
			Button16.Size = new Size(175, 45);
			Button16.TabIndex = 29;
			Button16.TabStop = false;
			Button16.UseVisualStyleBackColor = false;
			GroupBox6.BackColor = SystemColors.Menu;
			GroupBox6.Controls.Add(Label28);
			GroupBox6.Controls.Add(Label27);
			GroupBox6.Controls.Add(VlidFacture);
			GroupBox6.Controls.Add(Button17);
			GroupBox6.Controls.Add(Button18);
			GroupBox6.Location = new Point(674, 572);
			GroupBox6.Name = "GroupBox6";
			GroupBox6.Size = new Size(584, 77);
			GroupBox6.TabIndex = 71;
			GroupBox6.TabStop = false;
			Label28.Cursor = Cursors.Hand;
			Label28.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label28.Location = new Point(147, 28);
			Label28.Name = "Label28";
			Label28.Size = new Size(46, 20);
			Label28.TabIndex = 32;
			Label28.Text = "Devis";
			VlidFacture.BackColor = Color.Transparent;
			VlidFacture.BackgroundImage = (Image)componentResourceManager.GetObject("VlidFacture.BackgroundImage");
			VlidFacture.Cursor = Cursors.Hand;
			VlidFacture.FlatStyle = FlatStyle.Flat;
			VlidFacture.ForeColor = Color.Transparent;
			VlidFacture.Location = new Point(385, 21);
			VlidFacture.Name = "VlidFacture";
			VlidFacture.Size = new Size(181, 47);
			VlidFacture.TabIndex = 30;
			VlidFacture.UseVisualStyleBackColor = false;
			Button17.BackColor = Color.Transparent;
			Button17.BackgroundImage = (Image)componentResourceManager.GetObject("Button17.BackgroundImage");
			Button17.Cursor = Cursors.Hand;
			Button17.FlatStyle = FlatStyle.Flat;
			Button17.ForeColor = Color.Transparent;
			Button17.Location = new Point(189, 21);
			Button17.Name = "Button17";
			Button17.Size = new Size(190, 47);
			Button17.TabIndex = 23;
			Button17.UseVisualStyleBackColor = false;
			Button18.BackColor = Color.Transparent;
			Button18.BackgroundImage = (Image)componentResourceManager.GetObject("Button18.BackgroundImage");
			Button18.Cursor = Cursors.Hand;
			Button18.FlatStyle = FlatStyle.Flat;
			Button18.ForeColor = Color.Transparent;
			Button18.Location = new Point(6, 21);
			Button18.Name = "Button18";
			Button18.Size = new Size(180, 47);
			Button18.TabIndex = 29;
			Button18.UseVisualStyleBackColor = false;
			GroupBox5.BackColor = SystemColors.Menu;
			GroupBox5.Controls.Add(comment);
			GroupBox5.Controls.Add(Label5);
			GroupBox5.Controls.Add(Button13);
			GroupBox5.Controls.Add(Button14);
			GroupBox5.Controls.Add(Supprimer1ligne);
			GroupBox5.Controls.Add(Modifier);
			GroupBox5.Controls.Add(Button10);
			GroupBox5.Location = new Point(749, 471);
			GroupBox5.Name = "GroupBox5";
			GroupBox5.Size = new Size(509, 77);
			GroupBox5.TabIndex = 70;
			GroupBox5.TabStop = false;
			comment.Location = new Point(357, 40);
			comment.Name = "comment";
			comment.Size = new Size(117, 22);
			comment.TabIndex = 39;
			comment.TabStop = false;
			Label5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(362, 16);
			Label5.Name = "Label5";
			Label5.Size = new Size(112, 21);
			Label5.TabIndex = 38;
			Label5.Text = "Commentaire:";
			Button13.BackColor = Color.Transparent;
			Button13.BackgroundImage = (Image)componentResourceManager.GetObject("Button13.BackgroundImage");
			Button13.Cursor = Cursors.Hand;
			Button13.FlatStyle = FlatStyle.Flat;
			Button13.ForeColor = Color.Transparent;
			Button13.Location = new Point(170, 15);
			Button13.Name = "Button13";
			Button13.Size = new Size(55, 55);
			Button13.TabIndex = 35;
			Button13.TabStop = false;
			Button13.UseVisualStyleBackColor = false;
			Button14.BackColor = Color.Transparent;
			Button14.BackgroundImage = (Image)componentResourceManager.GetObject("Button14.BackgroundImage");
			Button14.Cursor = Cursors.Hand;
			Button14.FlatStyle = FlatStyle.Flat;
			Button14.ForeColor = Color.Transparent;
			Button14.Location = new Point(231, 14);
			Button14.Name = "Button14";
			Button14.Size = new Size(63, 57);
			Button14.TabIndex = 36;
			Button14.TabStop = false;
			Button14.UseVisualStyleBackColor = false;
			Supprimer1ligne.BackColor = Color.Transparent;
			Supprimer1ligne.BackgroundImage = (Image)componentResourceManager.GetObject("Supprimer1ligne.BackgroundImage");
			Supprimer1ligne.Cursor = Cursors.Hand;
			Supprimer1ligne.FlatStyle = FlatStyle.Flat;
			Supprimer1ligne.ForeColor = Color.Transparent;
			Supprimer1ligne.Location = new Point(71, 15);
			Supprimer1ligne.Name = "Supprimer1ligne";
			Supprimer1ligne.Size = new Size(58, 55);
			Supprimer1ligne.TabIndex = 37;
			Supprimer1ligne.TabStop = false;
			Supprimer1ligne.UseVisualStyleBackColor = false;
			Modifier.BackColor = Color.Transparent;
			Modifier.BackgroundImage = (Image)componentResourceManager.GetObject("Modifier.BackgroundImage");
			Modifier.Cursor = Cursors.Hand;
			Modifier.FlatStyle = FlatStyle.Flat;
			Modifier.ForeColor = Color.Transparent;
			Modifier.Location = new Point(16, 16);
			Modifier.Name = "Modifier";
			Modifier.Size = new Size(49, 54);
			Modifier.TabIndex = 29;
			Modifier.TabStop = false;
			Modifier.UseVisualStyleBackColor = false;
			Button10.BackColor = Color.Transparent;
			Button10.BackgroundImage = (Image)componentResourceManager.GetObject("Button10.BackgroundImage");
			Button10.Cursor = Cursors.Hand;
			Button10.FlatStyle = FlatStyle.Flat;
			Button10.ForeColor = Color.Transparent;
			Button10.Location = new Point(135, 14);
			Button10.Name = "Button10";
			Button10.Size = new Size(38, 56);
			Button10.TabIndex = 34;
			Button10.TabStop = false;
			Button10.UseVisualStyleBackColor = false;
			Initier.BackColor = Color.White;
			Initier.Cursor = Cursors.Hand;
			Initier.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Initier.Image = Resources.Button_Refresh_icon;
			Initier.ImageAlign = ContentAlignment.MiddleLeft;
			Initier.Location = new Point(653, 142);
			Initier.Margin = new Padding(3, 4, 3, 4);
			Initier.Name = "Initier";
			Initier.Size = new Size(114, 55);
			Initier.TabIndex = 110;
			Initier.Text = "Initier";
			Initier.TextAlign = ContentAlignment.MiddleRight;
			Initier.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Initier);
			base.Controls.Add(GB_COM);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(dgv1);
			base.Controls.Add(Button19);
			base.Controls.Add(transp);
			base.Controls.Add(Label4);
			base.Controls.Add(Enregistrer);
			base.Controls.Add(GroupBox6);
			base.Controls.Add(GroupBox5);
			base.Controls.Add(LB_Article);
			base.Controls.Add(GroupBox4);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Modif_Fact";
			Text = "Ajout_Devis";
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(LB_Article, 0);
			base.Controls.SetChildIndex(GroupBox5, 0);
			base.Controls.SetChildIndex(GroupBox6, 0);
			base.Controls.SetChildIndex(Enregistrer, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(transp, 0);
			base.Controls.SetChildIndex(Button19, 0);
			base.Controls.SetChildIndex(dgv1, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(GB_COM, 0);
			base.Controls.SetChildIndex(Initier, 0);
			GB_COM.ResumeLayout(false);
			GroupBox12.ResumeLayout(false);
			GroupBox11.ResumeLayout(false);
			GroupBox11.PerformLayout();
			GroupBox2.ResumeLayout(false);
			((ISupportInitialize)dgv1).EndInit();
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox6.ResumeLayout(false);
			GroupBox5.ResumeLayout(false);
			GroupBox5.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button12_Click(1, e);
				e.Handled = true;
			}
		}

		private void Modifier_Click(object sender, EventArgs e)
		{
			try
			{
				REFART_C.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				LIBART_C.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
				PRIX_VC.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
				qte_C.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
				Remise_C.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
				total_C.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
				ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_C.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_VC.Text)));
				supprimer(dgv1.CurrentRow.Cells[6].Value.ToString());
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

		private void dgv1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Modif_Vente.Show();
				MyProject.Forms.Modif_Vente.REFART.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Modif_Vente.LIBART.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Modif_Vente.PRIX_V.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
				MyProject.Forms.Modif_Vente.QTE.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
				MyProject.Forms.Modif_Vente.REMISE.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
				MyProject.Forms.Modif_Vente.TOTAL_V.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
				MyProject.Forms.Modif_Vente.NUMVENTE = Conversions.ToInteger(dgv1.CurrentRow.Cells[6].Value.ToString());
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

		private void Supprim_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					if (dgv1.RowCount == 1)
					{
						Initier_Click(RuntimeHelpers.GetObjectValue(sender), e);
					}
					else
					{
						supprimer(dgv1.CurrentRow.Cells[6].Value.ToString());
						MessageBox.Show("Ligne supprimé");
					}
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

		private void supprimer(string NUMDFAS)
		{
			if (Globals.conn.State == ConnectionState.Closed)
			{
				Globals.conn.Open();
			}
			string cmdText = "DELETE FROM " + TABLEDETAIL + " WHERE NUM_DF='" + NUMDFAS + "'";
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
			mySqlCommand.ExecuteNonQuery();
			mySqlCommand.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM " + TABLEDETAIL + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
			TOTALV.Text = mySqlCommand.ExecuteScalar().ToString();
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
			REFART_C.Focus();
			dgv1.Rows.Remove(dgv1.CurrentRow);
		}

		private void HISTO_CLIENT_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Client.Show();
			MyProject.Forms.Histo_Client.IDCLIENT.Text = IDCLIENT.Text;
			MyProject.Forms.Histo_Client.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void VlidFacture_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			TOTALV.Text = "";
			IDCLIENT.Text = "";
			MessageBox.Show(TABLEFACT + " n:" + Conversions.ToString(NUM_DEV) + " modifié");
			if (Operators.CompareString(TABLEFACT, "TICKET", false) == 0)
			{
				Frm_Fact frm_Fact = new Frm_Fact();
				frm_Fact.TYPEFACT = "F";
				frm_Fact.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact2.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact3.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact4.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact5.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact6.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact7.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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
				frm_Fact8.NUMFACT.Text = Conversions.ToString(NUM_DEV);
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

		private void ajout_Comment()
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string text = Strings.Replace(TOTALV.Text, ",", ".", 1, -1, CompareMethod.Binary);
				string cmdText = "UPDATE " + TABLEFACT + " SET COMMENTAIRE='" + comment.Text + "',DATE_FACT='" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', IDCLIENT='" + IDCLIENT.Text + "', VENDEUR='" + Globals.Utilisateur + "', TOTALTTC_FACT='" + text + "' WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
				MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
				mySqlCommand.ExecuteNonQuery();
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

		private void Enregistrer_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Modif_Vente.REFART.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Modif_Vente.LIBART.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Modif_Vente.PRIX_V.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
				MyProject.Forms.Modif_Vente.QTE.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
				MyProject.Forms.Modif_Vente.REMISE.Text = Strings.Replace(dgv1.CurrentRow.Cells[4].Value.ToString(), " %", "", 1, -1, CompareMethod.Binary);
				MyProject.Forms.Modif_Vente.TOTAL_V.Text = Strings.Replace(dgv1.CurrentRow.Cells[5].Value.ToString(), " DT", "", 1, -1, CompareMethod.Binary);
				MyProject.Forms.Modif_Vente.NUMVENTE = Conversions.ToInteger(dgv1.CurrentRow.Cells[6].Value.ToString());
				MyProject.Forms.Modif_Vente.btnUpdate_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Affich_code_client.Show();
				MyProject.Forms.Affich_code_client.BringToFront();
				string query = "select distinct IDCLIENT,NOM from CLIENT";
				MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
				MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "Affich");
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

		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "AF";
				MyProject.Forms.Affich_code.Show();
				MyProject.Forms.Affich_code.BringToFront();
				string query = "select distinct REFART,LIBART from ARTICLE_D WHERE TYPE_ART='Article montée'";
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

		private void Button19_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(transp.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide pour F.Transport !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = ("select * from " + TABLEDETAIL) ?? "";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_DF = 1;
						}
						else
						{
							mySqlCommand.CommandText = (("SELECT MAX(NUM_DF)+1 FROM " + TABLEDETAIL) ?? "");
							NUM_DF = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						if (flag_DEV == 1)
						{
							string text2 = ("select * from " + TABLEFACT) ?? "";
							MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(text2, Globals.conn);
							MySqlCommand mySqlCommand2 = new MySqlCommand(text2, Globals.conn);
							DataTable dataTable2 = new DataTable();
							mySqlDataAdapter2.Fill(dataTable2);
							int num2 = dataTable2.Rows.Count - 1;
							if (num2 == -1)
							{
								NUM_DEV = 1;
							}
							else
							{
								mySqlCommand2.CommandText = "SELECT MAX(NUM_FACT)+1 FROM " + TABLEFACT + " ";
								NUM_DEV = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
							}
						}
						string text3 = Strings.Replace(transp.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO " + TABLEDETAIL + "(NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)VALUES('" + Conversions.ToString(NUM_DF) + "','F.Transport','F.Transport','" + text3 + "','0','1','" + text3 + "','" + Conversions.ToString(NUM_DEV) + "')";
						Globals.ExecuteInsertQuery(query);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM " + TABLEDETAIL + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
						decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
						string text4 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						TOTALV.Text = text4;
						if (flag_DEV == 1)
						{
							string query2 = "INSERT INTO " + TABLEFACT + "(NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, TOTALTTC_FACT)VALUES('" + Conversions.ToString(NUM_DEV) + "', '" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', '" + IDCLIENT.Text + "', '" + Globals.Utilisateur + "','" + TOTALV.Text + "')";
							Globals.ExecuteInsertQuery(query2);
							flag_DEV = 0;
						}
						string query3 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from " + TABLEDETAIL + " where NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
						dgv1.DataSource = null;
						dgv1.Rows.Clear();
						Globals.LoadData(query3, dgv1, " & TABLEDETAIL & ");
						DataGridView dgv = dgv1;
						dgv.Columns[0].HeaderCell.Value = "Réf. Article";
						dgv.Columns[1].HeaderCell.Value = "Nom";
						dgv.Columns[2].HeaderCell.Value = "Prix";
						dgv.Columns[3].HeaderCell.Value = "Qté";
						dgv.Columns[4].HeaderCell.Value = "Remise";
						dgv.Columns[5].HeaderCell.Value = "Total";
						dgv.Columns[6].HeaderCell.Value = "NUMDF";
						dgv.Columns[0].Width = 140;
						dgv.Columns[1].Width = 240;
						dgv.Columns[2].Width = 100;
						dgv.Columns[3].Width = 60;
						dgv.Columns[4].Width = 60;
						dgv.Columns[5].Width = 120;
						dgv.Columns[6].Visible = false;
						dgv = null;
						int num3 = dgv1.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (unchecked(i % 2) == 1)
							{
								dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
							}
							else
							{
								dgv1.Rows[i].DefaultCellStyle.BackColor = Color.White;
							}
						}
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

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
		}

		private void REFART_C_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button20_Click(1, e);
				e.Handled = true;
			}
		}

		public void REFART_C_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from ARTICLE_D where TYPE_ART='COMMERCIALE' AND REFART ='" + REFART_C.Text + "'";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					qte_C.Text = "1";
					LIBART_C.Text = mySqlDataReader["LIBART"].ToString();
					Remise_C.Text = mySqlDataReader["REM"].ToString();
					if (Operators.CompareString(Remise_C.Text, "", false) == 0)
					{
						Remise_C.Text = "0";
					}
					if (Operators.CompareString(TYPEFACT, "DA", false) == 0 || Operators.CompareString(TYPEFACT, "BCA", false) == 0 || Operators.CompareString(TYPEFACT, "BLA", false) == 0 || Operators.CompareString(TYPEFACT, "FA", false) == 0)
					{
						PRIX_VC.Text = mySqlDataReader["PRIX_ATTC"].ToString();
					}
					else
					{
						PRIX_VC.Text = mySqlDataReader["PRIX_V"].ToString();
					}
					if (Operators.CompareString(PRIX_VC.Text, "", false) == 0)
					{
						PRIX_VC.Text = "0";
					}
					ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_C.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_VC.Text)));
					total_C.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_VC.Text), Globals.convertDN(ValRem_C.Text)), Globals.convertDN(qte_C.Text)));
				}
				else
				{
					MessageBox.Show("ARTICLE not found");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				stock_C_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Button29_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
			REFART_C.Text = "";
			LIBART_C.Text = "";
		}

		private void Valider_C_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(PRIX_VC.Text) + Globals.controlNum(qte_C.Text) + Globals.controlNum(Remise_C.Text) + Globals.controlNum(total_C.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = ("select * from " + TABLEDETAIL) ?? "";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_DF = 1;
						}
						else
						{
							mySqlCommand.CommandText = (("SELECT MAX(NUM_DF)+1 FROM " + TABLEDETAIL) ?? "");
							NUM_DF = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						string text2 = Strings.Replace(PRIX_VC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text3 = Strings.Replace(Remise_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(qte_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(total_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO " + TABLEDETAIL + "(NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)VALUES('" + Conversions.ToString(NUM_DF) + "','" + REFART_C.Text + "','" + LIBART_C.Text + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + Conversions.ToString(NUM_DEV) + "')";
						Globals.ExecuteInsertQuery(query);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM " + TABLEDETAIL + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
						decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
						string text6 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						TOTALV.Text = text6;
						Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART_C.Text + "'";
						decimal value2 = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
						string text7 = Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary);
						decimal num2 = default(decimal);
						num2 = new decimal(unchecked(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value2), ".", ",", 1, -1, CompareMethod.Binary)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Globals.convertDN(qte_C.Text)), ".", ",", 1, -1, CompareMethod.Binary))));
						string text8 = Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary);
						string query2 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from " + TABLEDETAIL + " where NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
						dgv1.DataSource = null;
						dgv1.Rows.Clear();
						Globals.LoadData(query2, dgv1, " & TABLEDETAIL & ");
						DataGridView dgv = dgv1;
						dgv.Columns[0].HeaderCell.Value = "Réf. Article";
						dgv.Columns[1].HeaderCell.Value = "Nom";
						dgv.Columns[2].HeaderCell.Value = "Prix";
						dgv.Columns[3].HeaderCell.Value = "Qté";
						dgv.Columns[4].HeaderCell.Value = "Remise";
						dgv.Columns[5].HeaderCell.Value = "Total";
						dgv.Columns[6].HeaderCell.Value = "NUMDF";
						dgv.Columns[0].Width = 140;
						dgv.Columns[1].Width = 240;
						dgv.Columns[2].Width = 100;
						dgv.Columns[3].Width = 60;
						dgv.Columns[4].Width = 60;
						dgv.Columns[5].Width = 120;
						dgv.Columns[6].Visible = false;
						dgv = null;
						int num3 = dgv1.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (unchecked(i % 2) == 1)
							{
								dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
							}
							else
							{
								dgv1.Rows[i].DefaultCellStyle.BackColor = Color.White;
							}
						}
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						Globals.ClearTextBox(this);
						REFART_C.Text = "";
						LIBART_C.Text = "";
						stock_C.Text = "";
						REFART_C.Focus();
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

		private void Button20_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "AFC";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D WHERE TYPE_ART='COMMERCIALE'";
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

		private void qte_C_Validated(object sender, EventArgs e)
		{
			try
			{
				qte_C.Text = Strings.Replace(qte_C.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_C.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_VC.Text)));
				total_C.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_VC.Text), Globals.convertDN(ValRem_C.Text)), Globals.convertDN(qte_C.Text)));
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

		private void Remise_C_Validated(object sender, EventArgs e)
		{
			try
			{
				Remise_C.Text = Strings.Replace(Remise_C.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_C.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_VC.Text)));
				total_C.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_VC.Text), Globals.convertDN(ValRem_C.Text)), Globals.convertDN(qte_C.Text)));
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

		private void PRIX_VC_Validated(object sender, EventArgs e)
		{
			try
			{
				PRIX_VC.Text = Strings.Replace(PRIX_VC.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_C.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_VC.Text)));
				total_C.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_VC.Text), Globals.convertDN(ValRem_C.Text)), Globals.convertDN(qte_C.Text)));
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

		public void Modif_Fact_Load(object sender, EventArgs e)
		{
			GB_COM.Visible = true;
			LB_Article.SelectedItem = "Article Commercial";
			if (Operators.CompareString(TABLEFACT, "DEVIS", false) == 0)
			{
				TABLEFACT = "DEVIS";
				TABLEDETAIL = "DETAIL_DEVIS";
				Label27.Text = "Afficher Devis";
				Label28.Text = "Devis";
				Text = "Ajout Devis";
			}
			else if (Operators.CompareString(TABLEFACT, "TICKET", false) == 0)
			{
				TABLEFACT = "TICKET";
				TABLEDETAIL = "VENTE";
				Label27.Text = "Afficher Facture";
				Label28.Text = "Facture";
				Text = "Ajout Facture";
			}
			else if (Operators.CompareString(TABLEFACT, "BONC", false) == 0)
			{
				TABLEFACT = "BONC";
				TABLEDETAIL = "DETAIL_BONC";
				Label27.Text = "Afficher Bon";
				Label28.Text = "Bon";
				Text = "Ajout Bon Commande";
			}
			else if (Operators.CompareString(TABLEFACT, "BONL", false) == 0)
			{
				TABLEFACT = "BONL";
				TABLEDETAIL = "DETAIL_BONL";
				Label27.Text = "Afficher Bon";
				Label28.Text = "Bon";
				Text = "Ajout Bon livraison";
			}
			else if (Operators.CompareString(TABLEFACT, "A_DEVIS", false) == 0)
			{
				TABLEFACT = "A_DEVIS";
				TABLEDETAIL = "A_DETAIL_DEVIS";
				Label27.Text = "Afficher Devis";
				Label28.Text = "Devis";
				Text = "Ajout Devis Achat";
			}
			else if (Operators.CompareString(TABLEFACT, "A_BONC", false) == 0)
			{
				TABLEFACT = "A_BONC";
				TABLEDETAIL = "A_DETAIL_BONC";
				Label27.Text = "Afficher Bon";
				Label28.Text = "Bon";
				Text = "Ajout Bon Commande";
			}
			else if (Operators.CompareString(TABLEFACT, "A_BONL", false) == 0)
			{
				TABLEFACT = "A_BONL";
				TABLEDETAIL = "A_DETAIL_BONL";
				Label27.Text = "Afficher Bon";
				Label28.Text = "Bon";
				Text = "Ajout Bon livraison";
			}
			else if (Operators.CompareString(TABLEFACT, "A_FACTURE", false) == 0)
			{
				TABLEFACT = "A_FACTURE";
				TABLEDETAIL = "A_DETAIL_FACTURE";
				Label27.Text = "Afficher Facture";
				Label28.Text = "Facture";
				Text = "Ajout Facture";
				FRS.Visible = true;
				LinkLabel2.Visible = true;
				Label29.Visible = true;
				Button1.Visible = true;
				Label1.Visible = true;
				Label3.Visible = true;
				Button2.Visible = true;
			}
			checked
			{
				try
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D WHERE TYPE_ART='COMMERCIALE'";
					mySqlDataAdapter.Fill(dataSet, "list0");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART_C.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART_C.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART_C.AutoCompleteMode = AutoCompleteMode.Suggest;
					MySqlCommand mySqlCommand2 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand2);
					DataSet dataSet2 = new DataSet();
					mySqlCommand2.Connection = Globals.conn;
					mySqlCommand2.CommandText = "select distinct IDCLIENT from CLIENT ";
					mySqlDataAdapter2.Fill(dataSet2, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
					int num2 = dataSet2.Tables[0].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						autoCompleteStringCollection2.Add(dataSet2.Tables[0].Rows[j]["IDCLIENT"].ToString());
					}
					IDCLIENT.AutoCompleteSource = AutoCompleteSource.CustomSource;
					IDCLIENT.AutoCompleteCustomSource = autoCompleteStringCollection2;
					IDCLIENT.AutoCompleteMode = AutoCompleteMode.Suggest;
					MySqlCommand mySqlCommand3 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(mySqlCommand3);
					DataSet dataSet3 = new DataSet();
					mySqlCommand3.Connection = Globals.conn;
					mySqlCommand3.CommandText = "select distinct IDFRS from FOURN ";
					mySqlDataAdapter3.Fill(dataSet3, "list3");
					AutoCompleteStringCollection autoCompleteStringCollection3 = new AutoCompleteStringCollection();
					int num3 = dataSet3.Tables[0].Rows.Count - 1;
					for (int k = 0; k <= num3; k++)
					{
						autoCompleteStringCollection3.Add(dataSet3.Tables[0].Rows[k]["IDFRS"].ToString());
					}
					FRS.AutoCompleteSource = AutoCompleteSource.CustomSource;
					FRS.AutoCompleteCustomSource = autoCompleteStringCollection3;
					FRS.AutoCompleteMode = AutoCompleteMode.Suggest;
					string query = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from " + TABLEDETAIL + " where NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
					dgv1.DataSource = null;
					dgv1.Rows.Clear();
					Globals.LoadData(query, dgv1, " & TABLEDETAIL & ");
					DataGridView dgv = dgv1;
					dgv.Columns[0].HeaderCell.Value = "Réf. Article";
					dgv.Columns[1].HeaderCell.Value = "Nom";
					dgv.Columns[2].HeaderCell.Value = "Prix";
					dgv.Columns[3].HeaderCell.Value = "Qté";
					dgv.Columns[4].HeaderCell.Value = "Remise";
					dgv.Columns[5].HeaderCell.Value = "Total";
					dgv.Columns[6].HeaderCell.Value = "NUMDF";
					dgv.Columns[0].Width = 140;
					dgv.Columns[1].Width = 240;
					dgv.Columns[2].Width = 100;
					dgv.Columns[3].Width = 60;
					dgv.Columns[4].Width = 60;
					dgv.Columns[5].Width = 120;
					dgv.Columns[6].Visible = false;
					dgv = null;
					int num4 = dgv1.Rows.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (unchecked(l % 2) == 1)
						{
							dgv1.Rows[l].DefaultCellStyle.BackColor = Color.LightBlue;
						}
						else
						{
							dgv1.Rows[l].DefaultCellStyle.BackColor = Color.White;
						}
					}
					MySqlCommand mySqlCommand4 = new MySqlCommand();
					mySqlCommand4.Connection = Globals.conn;
					mySqlCommand4.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM " + TABLEDETAIL + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
					decimal value = Conversions.ToDecimal(mySqlCommand4.ExecuteScalar());
					string text = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
					TOTALV.Text = text;
					mySqlCommand4.CommandText = "SELECT IDCLIENT FROM " + TABLEFACT + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
					IDCLIENT.Text = Conversions.ToString(mySqlCommand4.ExecuteScalar());
					FRS.Text = Conversions.ToString(mySqlCommand4.ExecuteScalar());
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					Globals.ClearTextBox(this);
					REFART_C.Text = "";
					LIBART_C.Text = "";
					stock_C.Text = "";
					REFART_C.Focus();
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

		private void Label1_Click(object sender, EventArgs e)
		{
			VlidFacture_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
		}

		private void Label27_Click(object sender, EventArgs e)
		{
			VlidFacture_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button18_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			IDCLIENT.Text = "";
			TOTALV.Text = "";
			base.Close();
			MessageBox.Show(TABLEFACT + " n:" + Conversions.ToString(NUM_DEV) + " modifié");
		}

		private void Label28_Click(object sender, EventArgs e)
		{
			Button18_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Affich_ID_FRS.Show();
			MyProject.Forms.Affich_ID_FRS.BringToFront();
		}

		private void FRS_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button1_Click(1, e);
				e.Handled = true;
			}
		}

		private void FRS_TextChanged(object sender, EventArgs e)
		{
			IDCLIENT.Text = FRS.Text;
		}

		private void FRS_Validated(object sender, EventArgs e)
		{
			IDCLIENT.Text = FRS.Text;
		}

		private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.IDFRS.Text = FRS.Text;
			MyProject.Forms.Histo_Fourn.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Label1_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.IDFRS.Text = FRS.Text;
			MyProject.Forms.Histo_Fourn.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Valider_C_Enter(object sender, EventArgs e)
		{
			if (Operators.CompareString(REFART_C.Text, "", false) == 0)
			{
				MessageBox.Show("Veuillez entrer un article...");
				REFART_C.Focus();
			}
		}

		private void Button19_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir valider le prix transport?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Button19_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void REFART_C_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where REFART ='" + REFART_C.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART_C.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
					goto IL_00ed;
				}
				if (Operators.CompareString(REFART_C.Text, "", false) != 0)
				{
					MessageBox.Show("Article no trouvé!", "Article");
					REFART_C.Text = "";
					REFART_C.Focus();
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

		private void stock_C_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART_C.Text + "'";
				decimal value = Conversions.ToDecimal(Operators.SubtractObject(Globals.cmd.ExecuteScalar(), Globals.convertDN(qte_C.Text)));
				stock_C.Text = "Stock: " + Conversions.ToString(value);
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

		private void Button17_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			TOTALV.Text = "";
			IDCLIENT.Text = "";
			MessageBox.Show(TABLEFACT + " n:" + Conversions.ToString(NUM_DEV) + " modifié");
		}

		private void Valider_C_Validated(object sender, EventArgs e)
		{
			if (Operators.CompareString(REFART_C.Text, "", false) != 0)
			{
				Valider_C_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		public void Initier_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer ces données?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult != DialogResult.No)
					{
						int num = 0;
						int num2 = dgv1.RowCount - 1 - num;
						for (int i = 0; i <= num2; i++)
						{
							supprimer(dgv1.Rows[i - num].Cells[6].Value.ToString());
							num++;
						}
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string cmdText = "DELETE FROM " + TABLEFACT + " WHERE NUM_FACT='" + Conversions.ToString(NUM_DEV) + "'";
						MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
						mySqlCommand.ExecuteNonQuery();
						TOTALV.Text = "";
						REFART_C.Focus();
						MessageBox.Show("données supprimés!", "Suppression");
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
}
