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
	public class Gestion_Vente : Accueil
	{
		private IContainer components;

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
		[AccessedThroughProperty("ShapeContainer1")]
		private ShapeContainer _ShapeContainer1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LineShape1")]
		private LineShape _LineShape1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Reste_A_Payer")]
		private Label _Reste_A_Payer;

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
		[AccessedThroughProperty("Reg_Cheque")]
		private Button _Reg_Cheque;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Reg_Carte")]
		private Button _Reg_Carte;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_Rem_General")]
		private Button _B_Rem_General;

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
		[AccessedThroughProperty("Reg_espece")]
		private Button _Reg_espece;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Reg_Multi")]
		private Button _Reg_Multi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HISTOCLIENT")]
		private Button _HISTOCLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Suprim1ligne")]
		private Button _Suprim1ligne;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Modifier")]
		private Button _Modifier;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Comment")]
		private TextBox _Comment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

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
		[AccessedThroughProperty("Valider_ticket")]
		private Button _Valider_ticket;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GB_MONT")]
		private GroupBox _GB_MONT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("IDCLIENT")]
		private ComboBox _IDCLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Enregistrer")]
		private Button _Enregistrer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("transp")]
		private TextBox _transp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GB_COM")]
		private GroupBox _GB_COM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LB_Article")]
		private ListBox _LB_Article;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FACADE")]
		private ListBox _FACADE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

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
		[AccessedThroughProperty("PRIX_POSE")]
		private TextBox _PRIX_POSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("stock")]
		private Label _stock;

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
		[AccessedThroughProperty("PRIX_V")]
		private TextBox _PRIX_V;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ValRem")]
		private TextBox _ValRem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Remise")]
		private TextBox _Remise;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("qte")]
		private TextBox _qte;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button26")]
		private Button _Button26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button25")]
		private Button _Button25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Affich_image_M")]
		private Button _Affich_image_M;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("stock_C")]
		private Label _stock_C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider_C")]
		private Button _Valider_C;

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
		[AccessedThroughProperty("Affich_image")]
		private Button _Affich_image;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Remise_general")]
		private TextBox _Remise_general;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Initier")]
		private Button _Initier;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AffichTicket")]
		private CheckBox _AffichTicket;

		public int NUM_TICK;

		public int NUM_VENTE;

		public int flag_tick;

		public int COD_S;

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

		internal virtual ShapeContainer ShapeContainer1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LineShape LineShape1
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

		internal virtual Label Reste_A_Payer
		{
			[CompilerGenerated]
			get
			{
				return _Reste_A_Payer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Reste_A_Payer_Click;
				Label reste_A_Payer = _Reste_A_Payer;
				if (reste_A_Payer != null)
				{
					reste_A_Payer.Click -= value2;
				}
				_Reste_A_Payer = value;
				reste_A_Payer = _Reste_A_Payer;
				if (reste_A_Payer != null)
				{
					reste_A_Payer.Click += value2;
				}
			}
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
				DataGridViewCellEventHandler value3 = dgv1_CellContentClick;
				DataGridView dgv = _dgv1;
				if (dgv != null)
				{
					dgv.DoubleClick -= value2;
					dgv.CellContentClick -= value3;
				}
				_dgv1 = value;
				dgv = _dgv1;
				if (dgv != null)
				{
					dgv.DoubleClick += value2;
					dgv.CellContentClick += value3;
				}
			}
		}

		internal virtual Button Reg_Cheque
		{
			[CompilerGenerated]
			get
			{
				return _Reg_Cheque;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Reg_Cheque_Click;
				EventHandler value3 = Reg_cheque_Enter;
				Button reg_Cheque = _Reg_Cheque;
				if (reg_Cheque != null)
				{
					reg_Cheque.Click -= value2;
					reg_Cheque.Enter -= value3;
				}
				_Reg_Cheque = value;
				reg_Cheque = _Reg_Cheque;
				if (reg_Cheque != null)
				{
					reg_Cheque.Click += value2;
					reg_Cheque.Enter += value3;
				}
			}
		}

		internal virtual Button Reg_Carte
		{
			[CompilerGenerated]
			get
			{
				return _Reg_Carte;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Reg_Carte_Click;
				EventHandler value3 = Reg_carte_Enter;
				Button reg_Carte = _Reg_Carte;
				if (reg_Carte != null)
				{
					reg_Carte.Click -= value2;
					reg_Carte.Enter -= value3;
				}
				_Reg_Carte = value;
				reg_Carte = _Reg_Carte;
				if (reg_Carte != null)
				{
					reg_Carte.Click += value2;
					reg_Carte.Enter += value3;
				}
			}
		}

		internal virtual Button Button4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_Rem_General
		{
			[CompilerGenerated]
			get
			{
				return _B_Rem_General;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_Rem_General_Click;
				Button b_Rem_General = _B_Rem_General;
				if (b_Rem_General != null)
				{
					b_Rem_General.Click -= value2;
				}
				_B_Rem_General = value;
				b_Rem_General = _B_Rem_General;
				if (b_Rem_General != null)
				{
					b_Rem_General.Click += value2;
				}
			}
		}

		internal virtual Button Button6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Reg_espece
		{
			[CompilerGenerated]
			get
			{
				return _Reg_espece;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Reg_espece_Click;
				EventHandler value3 = Reg_espece_Enter;
				Button reg_espece = _Reg_espece;
				if (reg_espece != null)
				{
					reg_espece.Click -= value2;
					reg_espece.Enter -= value3;
				}
				_Reg_espece = value;
				reg_espece = _Reg_espece;
				if (reg_espece != null)
				{
					reg_espece.Click += value2;
					reg_espece.Enter += value3;
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
				EventHandler value3 = Reg_multi_Enter;
				Button reg_Multi = _Reg_Multi;
				if (reg_Multi != null)
				{
					reg_Multi.Click -= value2;
					reg_Multi.Enter -= value3;
				}
				_Reg_Multi = value;
				reg_Multi = _Reg_Multi;
				if (reg_Multi != null)
				{
					reg_Multi.Click += value2;
					reg_Multi.Enter += value3;
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

		internal virtual GroupBox GroupBox3
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

		internal virtual GroupBox GroupBox5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Suprim1ligne
		{
			[CompilerGenerated]
			get
			{
				return _Suprim1ligne;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Suprim1ligne_Click;
				Button suprim1ligne = _Suprim1ligne;
				if (suprim1ligne != null)
				{
					suprim1ligne.Click -= value2;
				}
				_Suprim1ligne = value;
				suprim1ligne = _Suprim1ligne;
				if (suprim1ligne != null)
				{
					suprim1ligne.Click += value2;
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

		internal virtual Button Button14
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Comment
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

		internal virtual GroupBox GroupBox6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Button Valider_ticket
		{
			[CompilerGenerated]
			get
			{
				return _Valider_ticket;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Valider_ticket_Click;
				EventHandler value3 = Valider_ticket_Enter;
				Button valider_ticket = _Valider_ticket;
				if (valider_ticket != null)
				{
					valider_ticket.Click -= value2;
					valider_ticket.Enter -= value3;
				}
				_Valider_ticket = value;
				valider_ticket = _Valider_ticket;
				if (valider_ticket != null)
				{
					valider_ticket.Click += value2;
					valider_ticket.Enter += value3;
				}
			}
		}

		internal virtual GroupBox GB_MONT
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

		internal virtual Label Label7
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
				EventHandler value3 = IDCLIENT_Validated;
				EventHandler value4 = IDCLIENT_TextChanged;
				ComboBox iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown -= value2;
					iDCLIENT.Validated -= value3;
					iDCLIENT.TextChanged -= value4;
				}
				_IDCLIENT = value;
				iDCLIENT = _IDCLIENT;
				if (iDCLIENT != null)
				{
					iDCLIENT.KeyDown += value2;
					iDCLIENT.Validated += value3;
					iDCLIENT.TextChanged += value4;
				}
			}
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

		internal virtual TextBox transp
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

		internal virtual GroupBox GB_COM
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

		internal virtual Label Label27
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

		internal virtual GroupBox GroupBox8
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

		internal virtual TextBox PRIX_POSE
		{
			[CompilerGenerated]
			get
			{
				return _PRIX_POSE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PRIX_POSE_Validated;
				TextBox pRIX_POSE = _PRIX_POSE;
				if (pRIX_POSE != null)
				{
					pRIX_POSE.Validated -= value2;
				}
				_PRIX_POSE = value;
				pRIX_POSE = _PRIX_POSE;
				if (pRIX_POSE != null)
				{
					pRIX_POSE.Validated += value2;
				}
			}
		}

		internal virtual Label Label15
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

		internal virtual Label stock
		{
			[CompilerGenerated]
			get
			{
				return _stock;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = stock_Click;
				Label stock = _stock;
				if (stock != null)
				{
					stock.Click -= value2;
				}
				_stock = value;
				stock = _stock;
				if (stock != null)
				{
					stock.Click += value2;
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
				EventHandler value2 = PRIX_V_Validated;
				TextBox pRIX_V = _PRIX_V;
				if (pRIX_V != null)
				{
					pRIX_V.Validated -= value2;
				}
				_PRIX_V = value;
				pRIX_V = _PRIX_V;
				if (pRIX_V != null)
				{
					pRIX_V.Validated += value2;
				}
			}
		}

		internal virtual Label Label13
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox ValRem
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

		internal virtual TextBox Remise
		{
			[CompilerGenerated]
			get
			{
				return _Remise;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Remise_Validated;
				TextBox remise = _Remise;
				if (remise != null)
				{
					remise.Validated -= value2;
				}
				_Remise = value;
				remise = _Remise;
				if (remise != null)
				{
					remise.Validated += value2;
				}
			}
		}

		internal virtual Label Label11
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox qte
		{
			[CompilerGenerated]
			get
			{
				return _qte;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = qte_Validated;
				TextBox qte = _qte;
				if (qte != null)
				{
					qte.Validated -= value2;
				}
				_qte = value;
				qte = _qte;
				if (qte != null)
				{
					qte.Validated += value2;
				}
			}
		}

		internal virtual Label Label10
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

		public virtual ComboBox LIBART
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

		internal virtual Button Button26
		{
			[CompilerGenerated]
			get
			{
				return _Button26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button26_Click;
				Button button = _Button26;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button26 = value;
				button = _Button26;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Affich_image_M
		{
			[CompilerGenerated]
			get
			{
				return _Affich_image_M;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Affich_image_M_Click;
				Button affich_image_M = _Affich_image_M;
				if (affich_image_M != null)
				{
					affich_image_M.Click -= value2;
				}
				_Affich_image_M = value;
				affich_image_M = _Affich_image_M;
				if (affich_image_M != null)
				{
					affich_image_M.Click += value2;
				}
			}
		}

		internal virtual Label Label8
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
				EventHandler value2 = stock_c_Click;
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
			[CompilerGenerated]
			get
			{
				return _Button21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button21_Click;
				Button button = _Button21;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button21 = value;
				button = _Button21;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button23
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Affich_image
		{
			[CompilerGenerated]
			get
			{
				return _Affich_image;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Affich_image_Click;
				Button affich_image = _Affich_image;
				if (affich_image != null)
				{
					affich_image.Click -= value2;
				}
				_Affich_image = value;
				affich_image = _Affich_image;
				if (affich_image != null)
				{
					affich_image.Click += value2;
				}
			}
		}

		internal virtual Label Label24
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

		internal virtual Label Label25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Remise_general
		{
			[CompilerGenerated]
			get
			{
				return _Remise_general;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Remise_general_Validated;
				TextBox remise_general = _Remise_general;
				if (remise_general != null)
				{
					remise_general.Validated -= value2;
				}
				_Remise_general = value;
				remise_general = _Remise_general;
				if (remise_general != null)
				{
					remise_general.Validated += value2;
				}
			}
		}

		internal virtual ToolTip ToolTip1
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

		internal virtual CheckBox AffichTicket
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Gestion_Vente()
		{
			base.Load += Gestion_Vente_Load;
			base.FormClosing += Gestion_Vente_FormClosing;
			flag_tick = 1;
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
			components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_Vente));
			GroupBox1 = new GroupBox();
			Reste_A_Payer = new Label();
			Label1 = new Label();
			ShapeContainer1 = new ShapeContainer();
			LineShape1 = new LineShape();
			GroupBox2 = new GroupBox();
			TOTALV = new Label();
			Label2 = new Label();
			ShapeContainer2 = new ShapeContainer();
			LineShape2 = new LineShape();
			dgv1 = new DataGridView();
			Reg_Cheque = new Button();
			Reg_Carte = new Button();
			Button4 = new Button();
			B_Rem_General = new Button();
			Button6 = new Button();
			Button7 = new Button();
			Reg_espece = new Button();
			Reg_Multi = new Button();
			Button1 = new Button();
			GroupBox3 = new GroupBox();
			Remise_general = new TextBox();
			GroupBox4 = new GroupBox();
			Label16 = new Label();
			Label27 = new Label();
			LinkLabel1 = new LinkLabel();
			Button11 = new Button();
			IDCLIENT = new ComboBox();
			HISTOCLIENT = new Button();
			Button16 = new Button();
			GroupBox5 = new GroupBox();
			Button13 = new Button();
			Button14 = new Button();
			Suprim1ligne = new Button();
			Modifier = new Button();
			Comment = new TextBox();
			Label5 = new Label();
			GroupBox6 = new GroupBox();
			AffichTicket = new CheckBox();
			Label3 = new Label();
			VlidFacture = new Button();
			Button17 = new Button();
			Valider_ticket = new Button();
			GB_MONT = new GroupBox();
			FACADE = new ListBox();
			Valider = new Button();
			Button22 = new Button();
			Label23 = new Label();
			TotalFAC = new TextBox();
			PRIX_POSE = new TextBox();
			Label15 = new Label();
			Button12 = new Button();
			stock = new Label();
			total = new TextBox();
			Label14 = new Label();
			PRIX_V = new TextBox();
			Label13 = new Label();
			ValRem = new TextBox();
			Label12 = new Label();
			Remise = new TextBox();
			Label11 = new Label();
			qte = new TextBox();
			Label10 = new Label();
			Label9 = new Label();
			LIBART = new ComboBox();
			REFART = new ComboBox();
			Button26 = new Button();
			Button25 = new Button();
			Affich_image_M = new Button();
			Label8 = new Label();
			GroupBox9 = new GroupBox();
			Label7 = new Label();
			Label6 = new Label();
			LB_Article = new ListBox();
			GB_COM = new GroupBox();
			Initier = new Button();
			Button20 = new Button();
			Button29 = new Button();
			stock_C = new Label();
			Valider_C = new Button();
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
			Affich_image = new Button();
			Label24 = new Label();
			Enregistrer = new Button();
			transp = new TextBox();
			Label4 = new Label();
			Button19 = new Button();
			GroupBox7 = new GroupBox();
			GroupBox8 = new GroupBox();
			Label25 = new Label();
			ToolTip1 = new ToolTip(components);
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox3.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox5.SuspendLayout();
			GroupBox6.SuspendLayout();
			GB_MONT.SuspendLayout();
			GroupBox9.SuspendLayout();
			GB_COM.SuspendLayout();
			GroupBox7.SuspendLayout();
			GroupBox8.SuspendLayout();
			base.SuspendLayout();
			GroupBox1.BackColor = Color.PowderBlue;
			GroupBox1.Controls.Add(Reste_A_Payer);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(ShapeContainer1);
			GroupBox1.Location = new Point(1180, 556);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(178, 119);
			GroupBox1.TabIndex = 18;
			GroupBox1.TabStop = false;
			Reste_A_Payer.Font = new Font("Arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Reste_A_Payer.Location = new Point(6, 56);
			Reste_A_Payer.Name = "Reste_A_Payer";
			Reste_A_Payer.Size = new Size(163, 44);
			Reste_A_Payer.TabIndex = 2;
			Reste_A_Payer.Text = "0.00 DT";
			Reste_A_Payer.TextAlign = ContentAlignment.MiddleCenter;
			Label1.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(13, 17);
			Label1.Name = "Label1";
			Label1.Size = new Size(153, 26);
			Label1.TabIndex = 0;
			Label1.Text = "Reste à Payer ";
			ShapeContainer1.Location = new Point(3, 18);
			ShapeContainer1.Margin = new Padding(0);
			ShapeContainer1.Name = "ShapeContainer1";
			ShapeContainer1.Shapes.AddRange(new Shape[1]
			{
				LineShape1
			});
			ShapeContainer1.Size = new Size(172, 98);
			ShapeContainer1.TabIndex = 1;
			ShapeContainer1.TabStop = false;
			LineShape1.BorderColor = SystemColors.AppWorkspace;
			LineShape1.Name = "LineShape1";
			LineShape1.X1 = -6;
			LineShape1.X2 = 194;
			LineShape1.Y1 = 26;
			LineShape1.Y2 = 27;
			GroupBox2.BackColor = Color.LemonChiffon;
			GroupBox2.Controls.Add(TOTALV);
			GroupBox2.Controls.Add(Label2);
			GroupBox2.Controls.Add(ShapeContainer2);
			GroupBox2.Location = new Point(1180, 423);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(178, 127);
			GroupBox2.TabIndex = 19;
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
			ShapeContainer2.Size = new Size(172, 106);
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
			dgv1.BackgroundColor = Color.White;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(8, 12);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(979, 231);
			dgv1.TabIndex = 20;
			Reg_Cheque.BackColor = Color.Transparent;
			Reg_Cheque.BackgroundImage = (Image)componentResourceManager.GetObject("Reg_Cheque.BackgroundImage");
			Reg_Cheque.Cursor = Cursors.Hand;
			Reg_Cheque.FlatStyle = FlatStyle.Flat;
			Reg_Cheque.ForeColor = Color.Transparent;
			Reg_Cheque.Location = new Point(10, 96);
			Reg_Cheque.Name = "Reg_Cheque";
			Reg_Cheque.Size = new Size(75, 62);
			Reg_Cheque.TabIndex = 61;
			Reg_Cheque.TabStop = false;
			Reg_Cheque.UseVisualStyleBackColor = false;
			Reg_Carte.BackColor = Color.Transparent;
			Reg_Carte.BackgroundImage = (Image)componentResourceManager.GetObject("Reg_Carte.BackgroundImage");
			Reg_Carte.Cursor = Cursors.Hand;
			Reg_Carte.FlatStyle = FlatStyle.Flat;
			Reg_Carte.ForeColor = Color.Transparent;
			Reg_Carte.Location = new Point(10, 164);
			Reg_Carte.Name = "Reg_Carte";
			Reg_Carte.Size = new Size(75, 65);
			Reg_Carte.TabIndex = 62;
			Reg_Carte.TabStop = false;
			Reg_Carte.UseVisualStyleBackColor = false;
			Button4.BackColor = Color.Transparent;
			Button4.BackgroundImage = (Image)componentResourceManager.GetObject("Button4.BackgroundImage");
			Button4.Cursor = Cursors.Hand;
			Button4.FlatStyle = FlatStyle.Flat;
			Button4.ForeColor = Color.Transparent;
			Button4.Location = new Point(313, 20);
			Button4.Name = "Button4";
			Button4.Size = new Size(60, 62);
			Button4.TabIndex = 57;
			Button4.TabStop = false;
			Button4.UseVisualStyleBackColor = false;
			B_Rem_General.BackColor = Color.Transparent;
			B_Rem_General.BackgroundImage = (Image)componentResourceManager.GetObject("B_Rem_General.BackgroundImage");
			B_Rem_General.Cursor = Cursors.Hand;
			B_Rem_General.FlatStyle = FlatStyle.Flat;
			B_Rem_General.ForeColor = Color.Transparent;
			B_Rem_General.Location = new Point(229, 18);
			B_Rem_General.Name = "B_Rem_General";
			B_Rem_General.Size = new Size(81, 68);
			B_Rem_General.TabIndex = 56;
			B_Rem_General.TabStop = false;
			B_Rem_General.UseVisualStyleBackColor = false;
			Button6.BackColor = Color.Transparent;
			Button6.BackgroundImage = (Image)componentResourceManager.GetObject("Button6.BackgroundImage");
			Button6.Cursor = Cursors.Hand;
			Button6.FlatStyle = FlatStyle.Flat;
			Button6.ForeColor = Color.Transparent;
			Button6.Location = new Point(82, 20);
			Button6.Name = "Button6";
			Button6.Size = new Size(64, 68);
			Button6.TabIndex = 54;
			Button6.TabStop = false;
			Button6.UseVisualStyleBackColor = false;
			Button7.BackColor = Color.Transparent;
			Button7.BackgroundImage = (Image)componentResourceManager.GetObject("Button7.BackgroundImage");
			Button7.Cursor = Cursors.Hand;
			Button7.FlatStyle = FlatStyle.Flat;
			Button7.ForeColor = Color.Transparent;
			Button7.Location = new Point(152, 20);
			Button7.Name = "Button7";
			Button7.Size = new Size(71, 68);
			Button7.TabIndex = 55;
			Button7.TabStop = false;
			Button7.UseVisualStyleBackColor = false;
			Reg_espece.BackColor = Color.Transparent;
			Reg_espece.BackgroundImage = (Image)componentResourceManager.GetObject("Reg_espece.BackgroundImage");
			Reg_espece.Cursor = Cursors.Hand;
			Reg_espece.FlatStyle = FlatStyle.Flat;
			Reg_espece.ForeColor = Color.Transparent;
			Reg_espece.Location = new Point(10, 21);
			Reg_espece.Name = "Reg_espece";
			Reg_espece.Size = new Size(75, 68);
			Reg_espece.TabIndex = 60;
			Reg_espece.TabStop = false;
			Reg_espece.UseVisualStyleBackColor = false;
			Reg_Multi.BackColor = Color.Transparent;
			Reg_Multi.BackgroundImage = (Image)componentResourceManager.GetObject("Reg_Multi.BackgroundImage");
			Reg_Multi.Cursor = Cursors.Hand;
			Reg_Multi.Enabled = false;
			Reg_Multi.FlatStyle = FlatStyle.Flat;
			Reg_Multi.ForeColor = Color.Transparent;
			Reg_Multi.Location = new Point(10, 234);
			Reg_Multi.Name = "Reg_Multi";
			Reg_Multi.Size = new Size(79, 63);
			Reg_Multi.TabIndex = 63;
			Reg_Multi.TabStop = false;
			Reg_Multi.UseVisualStyleBackColor = false;
			Button1.BackColor = Color.Transparent;
			Button1.BackgroundImage = (Image)componentResourceManager.GetObject("Button1.BackgroundImage");
			Button1.Cursor = Cursors.Hand;
			Button1.FlatStyle = FlatStyle.Flat;
			Button1.ForeColor = Color.Transparent;
			Button1.Location = new Point(-5, 21);
			Button1.Name = "Button1";
			Button1.Size = new Size(81, 68);
			Button1.TabIndex = 53;
			Button1.TabStop = false;
			Button1.UseVisualStyleBackColor = false;
			GroupBox3.BackColor = SystemColors.Menu;
			GroupBox3.Controls.Add(Remise_general);
			GroupBox3.Controls.Add(Button6);
			GroupBox3.Controls.Add(Button1);
			GroupBox3.Controls.Add(Button4);
			GroupBox3.Controls.Add(B_Rem_General);
			GroupBox3.Controls.Add(Button7);
			GroupBox3.Location = new Point(879, 250);
			GroupBox3.Name = "GroupBox3";
			GroupBox3.Size = new Size(382, 94);
			GroupBox3.TabIndex = 31;
			GroupBox3.TabStop = false;
			Remise_general.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Remise_general.Location = new Point(229, 43);
			Remise_general.Name = "Remise_general";
			Remise_general.Size = new Size(81, 26);
			Remise_general.TabIndex = 58;
			Remise_general.TextAlign = HorizontalAlignment.Center;
			Remise_general.Visible = false;
			GroupBox4.BackColor = SystemColors.Menu;
			GroupBox4.Controls.Add(Label16);
			GroupBox4.Controls.Add(Label27);
			GroupBox4.Controls.Add(LinkLabel1);
			GroupBox4.Controls.Add(Button11);
			GroupBox4.Controls.Add(IDCLIENT);
			GroupBox4.Controls.Add(HISTOCLIENT);
			GroupBox4.Controls.Add(Button16);
			GroupBox4.Location = new Point(1022, 100);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Size = new Size(236, 148);
			GroupBox4.TabIndex = 32;
			GroupBox4.TabStop = false;
			Label16.BackColor = Color.Transparent;
			Label16.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label16.Location = new Point(191, 49);
			Label16.Name = "Label16";
			Label16.Size = new Size(39, 18);
			Label16.TabIndex = 72;
			Label16.Text = "(F11)";
			Label27.BackColor = Color.Transparent;
			Label27.Location = new Point(188, 49);
			Label27.Name = "Label27";
			Label27.Size = new Size(37, 18);
			Label27.TabIndex = 70;
			LinkLabel1.AutoSize = true;
			LinkLabel1.Location = new Point(8, 62);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new Size(94, 16);
			LinkLabel1.TabIndex = 51;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Nouveau Client";
			Button11.Location = new Point(209, 22);
			Button11.Name = "Button11";
			Button11.Size = new Size(27, 28);
			Button11.TabIndex = 47;
			Button11.TabStop = false;
			Button11.Text = "...";
			Button11.UseVisualStyleBackColor = true;
			IDCLIENT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			IDCLIENT.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDCLIENT.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			IDCLIENT.FormattingEnabled = true;
			IDCLIENT.Location = new Point(69, 23);
			IDCLIENT.Margin = new Padding(4, 3, 4, 3);
			IDCLIENT.Name = "IDCLIENT";
			IDCLIENT.Size = new Size(158, 26);
			IDCLIENT.TabIndex = 50;
			HISTOCLIENT.BackColor = Color.Transparent;
			HISTOCLIENT.BackgroundImage = (Image)componentResourceManager.GetObject("HISTOCLIENT.BackgroundImage");
			HISTOCLIENT.Cursor = Cursors.Hand;
			HISTOCLIENT.FlatStyle = FlatStyle.Flat;
			HISTOCLIENT.ForeColor = Color.Transparent;
			HISTOCLIENT.Location = new Point(27, 92);
			HISTOCLIENT.Name = "HISTOCLIENT";
			HISTOCLIENT.Size = new Size(189, 47);
			HISTOCLIENT.TabIndex = 52;
			HISTOCLIENT.TabStop = false;
			HISTOCLIENT.UseVisualStyleBackColor = false;
			Button16.BackColor = Color.Transparent;
			Button16.BackgroundImage = (Image)componentResourceManager.GetObject("Button16.BackgroundImage");
			Button16.Cursor = Cursors.Hand;
			Button16.FlatStyle = FlatStyle.Flat;
			Button16.ForeColor = Color.Transparent;
			Button16.Location = new Point(27, 21);
			Button16.Name = "Button16";
			Button16.Size = new Size(197, 45);
			Button16.TabIndex = 29;
			Button16.TabStop = false;
			Button16.UseVisualStyleBackColor = false;
			GroupBox5.BackColor = SystemColors.Menu;
			GroupBox5.Controls.Add(Button13);
			GroupBox5.Controls.Add(Button14);
			GroupBox5.Controls.Add(Suprim1ligne);
			GroupBox5.Controls.Add(Modifier);
			GroupBox5.Location = new Point(12, 345);
			GroupBox5.Name = "GroupBox5";
			GroupBox5.Size = new Size(70, 255);
			GroupBox5.TabIndex = 33;
			GroupBox5.TabStop = false;
			Button13.BackColor = Color.Transparent;
			Button13.BackgroundImage = (Image)componentResourceManager.GetObject("Button13.BackgroundImage");
			Button13.Cursor = Cursors.Hand;
			Button13.FlatStyle = FlatStyle.Flat;
			Button13.ForeColor = Color.Transparent;
			Button13.Location = new Point(9, 132);
			Button13.Name = "Button13";
			Button13.Size = new Size(55, 55);
			Button13.TabIndex = 82;
			Button13.UseVisualStyleBackColor = false;
			Button14.BackColor = Color.Transparent;
			Button14.BackgroundImage = (Image)componentResourceManager.GetObject("Button14.BackgroundImage");
			Button14.Cursor = Cursors.Hand;
			Button14.FlatStyle = FlatStyle.Flat;
			Button14.ForeColor = Color.Transparent;
			Button14.Location = new Point(6, 193);
			Button14.Name = "Button14";
			Button14.Size = new Size(63, 57);
			Button14.TabIndex = 83;
			Button14.UseVisualStyleBackColor = false;
			Suprim1ligne.BackColor = Color.Transparent;
			Suprim1ligne.BackgroundImage = (Image)componentResourceManager.GetObject("Suprim1ligne.BackgroundImage");
			Suprim1ligne.Cursor = Cursors.Hand;
			Suprim1ligne.FlatStyle = FlatStyle.Flat;
			Suprim1ligne.ForeColor = Color.Transparent;
			Suprim1ligne.Location = new Point(6, 71);
			Suprim1ligne.Name = "Suprim1ligne";
			Suprim1ligne.Size = new Size(58, 55);
			Suprim1ligne.TabIndex = 81;
			Suprim1ligne.UseVisualStyleBackColor = false;
			Modifier.BackColor = Color.Transparent;
			Modifier.BackgroundImage = (Image)componentResourceManager.GetObject("Modifier.BackgroundImage");
			Modifier.Cursor = Cursors.Hand;
			Modifier.FlatStyle = FlatStyle.Flat;
			Modifier.ForeColor = Color.Transparent;
			Modifier.Location = new Point(11, 11);
			Modifier.Name = "Modifier";
			Modifier.Size = new Size(49, 54);
			Modifier.TabIndex = 80;
			Modifier.UseVisualStyleBackColor = false;
			Comment.Location = new Point(744, 649);
			Comment.Name = "Comment";
			Comment.Size = new Size(436, 22);
			Comment.TabIndex = 70;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(923, 623);
			Label5.Name = "Label5";
			Label5.Size = new Size(112, 21);
			Label5.TabIndex = 38;
			Label5.Text = "Commentaire:";
			GroupBox6.BackColor = SystemColors.Menu;
			GroupBox6.Controls.Add(AffichTicket);
			GroupBox6.Controls.Add(Label3);
			GroupBox6.Controls.Add(VlidFacture);
			GroupBox6.Controls.Add(Button17);
			GroupBox6.Controls.Add(Valider_ticket);
			GroupBox6.Location = new Point(43, 606);
			GroupBox6.Name = "GroupBox6";
			GroupBox6.Size = new Size(584, 77);
			GroupBox6.TabIndex = 33;
			GroupBox6.TabStop = false;
			AffichTicket.AutoSize = true;
			AffichTicket.Location = new Point(0, 0);
			AffichTicket.Name = "AffichTicket";
			AffichTicket.Size = new Size(109, 20);
			AffichTicket.TabIndex = 79;
			AffichTicket.Text = "Afficher Ticket";
			AffichTicket.UseVisualStyleBackColor = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(125, 44);
			Label3.Name = "Label3";
			Label3.Size = new Size(39, 18);
			Label3.TabIndex = 71;
			Label3.Text = "(F10)";
			VlidFacture.BackColor = Color.Transparent;
			VlidFacture.BackgroundImage = (Image)componentResourceManager.GetObject("VlidFacture.BackgroundImage");
			VlidFacture.Cursor = Cursors.Hand;
			VlidFacture.FlatStyle = FlatStyle.Flat;
			VlidFacture.ForeColor = Color.Transparent;
			VlidFacture.Location = new Point(385, 21);
			VlidFacture.Name = "VlidFacture";
			VlidFacture.Size = new Size(181, 47);
			VlidFacture.TabIndex = 67;
			VlidFacture.UseVisualStyleBackColor = false;
			Button17.BackColor = Color.Transparent;
			Button17.BackgroundImage = (Image)componentResourceManager.GetObject("Button17.BackgroundImage");
			Button17.Cursor = Cursors.Hand;
			Button17.FlatStyle = FlatStyle.Flat;
			Button17.ForeColor = Color.Transparent;
			Button17.Location = new Point(192, 20);
			Button17.Name = "Button17";
			Button17.Size = new Size(187, 47);
			Button17.TabIndex = 66;
			Button17.UseVisualStyleBackColor = false;
			Valider_ticket.BackColor = Color.Transparent;
			Valider_ticket.BackgroundImage = (Image)componentResourceManager.GetObject("Valider_ticket.BackgroundImage");
			Valider_ticket.Cursor = Cursors.Hand;
			Valider_ticket.FlatStyle = FlatStyle.Flat;
			Valider_ticket.ForeColor = Color.Transparent;
			Valider_ticket.Location = new Point(6, 21);
			Valider_ticket.Name = "Valider_ticket";
			Valider_ticket.Size = new Size(180, 47);
			Valider_ticket.TabIndex = 65;
			Valider_ticket.UseVisualStyleBackColor = false;
			GB_MONT.BackColor = Color.Transparent;
			GB_MONT.Controls.Add(FACADE);
			GB_MONT.Controls.Add(Valider);
			GB_MONT.Controls.Add(Button22);
			GB_MONT.Controls.Add(Label23);
			GB_MONT.Controls.Add(TotalFAC);
			GB_MONT.Controls.Add(PRIX_POSE);
			GB_MONT.Controls.Add(Label15);
			GB_MONT.Controls.Add(Button12);
			GB_MONT.Controls.Add(stock);
			GB_MONT.Controls.Add(total);
			GB_MONT.Controls.Add(Label14);
			GB_MONT.Controls.Add(PRIX_V);
			GB_MONT.Controls.Add(Label13);
			GB_MONT.Controls.Add(ValRem);
			GB_MONT.Controls.Add(Label12);
			GB_MONT.Controls.Add(Remise);
			GB_MONT.Controls.Add(Label11);
			GB_MONT.Controls.Add(qte);
			GB_MONT.Controls.Add(Label10);
			GB_MONT.Controls.Add(Label9);
			GB_MONT.Controls.Add(LIBART);
			GB_MONT.Controls.Add(REFART);
			GB_MONT.Controls.Add(Button26);
			GB_MONT.Controls.Add(Button25);
			GB_MONT.Controls.Add(Affich_image_M);
			GB_MONT.Controls.Add(Label8);
			GB_MONT.Location = new Point(12, 97);
			GB_MONT.Name = "GB_MONT";
			GB_MONT.Size = new Size(861, 242);
			GB_MONT.TabIndex = 2;
			GB_MONT.TabStop = false;
			GB_MONT.Visible = false;
			FACADE.BackColor = SystemColors.Control;
			FACADE.FormattingEnabled = true;
			FACADE.ItemHeight = 16;
			FACADE.Location = new Point(12, 88);
			FACADE.Name = "FACADE";
			FACADE.Size = new Size(166, 68);
			FACADE.TabIndex = 64;
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(710, 70);
			Valider.Name = "Valider";
			Valider.Size = new Size(143, 47);
			Valider.TabIndex = 65;
			Valider.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(723, 159);
			Button22.Name = "Button22";
			Button22.Size = new Size(124, 47);
			Button22.TabIndex = 66;
			Button22.TabStop = false;
			Button22.UseVisualStyleBackColor = false;
			Label23.AutoSize = true;
			Label23.BackColor = Color.Transparent;
			Label23.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label23.ForeColor = SystemColors.ActiveCaption;
			Label23.Location = new Point(48, 164);
			Label23.Name = "Label23";
			Label23.Size = new Size(99, 19);
			Label23.TabIndex = 85;
			Label23.Text = "Prix Façade";
			TotalFAC.BackColor = Color.LemonChiffon;
			TotalFAC.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TotalFAC.Location = new Point(42, 186);
			TotalFAC.Name = "TotalFAC";
			TotalFAC.ReadOnly = true;
			TotalFAC.Size = new Size(114, 26);
			TotalFAC.TabIndex = 84;
			TotalFAC.TabStop = false;
			TotalFAC.Text = "0";
			PRIX_POSE.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			PRIX_POSE.Location = new Point(610, 136);
			PRIX_POSE.Name = "PRIX_POSE";
			PRIX_POSE.Size = new Size(81, 26);
			PRIX_POSE.TabIndex = 83;
			PRIX_POSE.TabStop = false;
			PRIX_POSE.Text = "0";
			Label15.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label15.Location = new Point(600, 113);
			Label15.Name = "Label15";
			Label15.Size = new Size(92, 21);
			Label15.TabIndex = 82;
			Label15.Text = "Prix Pose";
			Button12.Location = new Point(315, 31);
			Button12.Name = "Button12";
			Button12.Size = new Size(37, 28);
			Button12.TabIndex = 77;
			Button12.TabStop = false;
			Button12.Text = "...";
			Button12.UseVisualStyleBackColor = true;
			stock.AutoSize = true;
			stock.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			stock.ForeColor = SystemColors.HotTrack;
			stock.Location = new Point(152, 63);
			stock.Name = "stock";
			stock.Size = new Size(51, 19);
			stock.TabIndex = 81;
			stock.Text = "stock";
			total.BackColor = SystemColors.MenuHighlight;
			total.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			total.Location = new Point(533, 177);
			total.Name = "total";
			total.ReadOnly = true;
			total.Size = new Size(158, 29);
			total.TabIndex = 80;
			total.TabStop = false;
			total.Text = "0.00";
			Label14.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(480, 180);
			Label14.Name = "Label14";
			Label14.Size = new Size(47, 21);
			Label14.TabIndex = 79;
			Label14.Text = "Total";
			PRIX_V.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			PRIX_V.Location = new Point(286, 138);
			PRIX_V.Name = "PRIX_V";
			PRIX_V.Size = new Size(81, 26);
			PRIX_V.TabIndex = 78;
			PRIX_V.TabStop = false;
			PRIX_V.Text = "0.00";
			Label13.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label13.Location = new Point(292, 118);
			Label13.Name = "Label13";
			Label13.Size = new Size(60, 21);
			Label13.TabIndex = 76;
			Label13.Text = "Prix U.";
			ValRem.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			ValRem.Location = new Point(487, 136);
			ValRem.Name = "ValRem";
			ValRem.ReadOnly = true;
			ValRem.Size = new Size(81, 26);
			ValRem.TabIndex = 75;
			ValRem.TabStop = false;
			ValRem.Text = "0.00";
			Label12.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label12.Location = new Point(378, 118);
			Label12.Name = "Label12";
			Label12.Size = new Size(86, 16);
			Label12.TabIndex = 74;
			Label12.Text = "%Remise";
			Remise.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Remise.Location = new Point(383, 138);
			Remise.Name = "Remise";
			Remise.Size = new Size(81, 26);
			Remise.TabIndex = 63;
			Remise.Text = "0.00";
			Label11.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label11.Location = new Point(484, 118);
			Label11.Name = "Label11";
			Label11.Size = new Size(84, 21);
			Label11.TabIndex = 73;
			Label11.Text = "Rem.  DT";
			qte.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			qte.Location = new Point(182, 138);
			qte.Name = "qte";
			qte.Size = new Size(81, 26);
			qte.TabIndex = 61;
			qte.Text = "1";
			Label10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label10.Location = new Point(192, 118);
			Label10.Name = "Label10";
			Label10.Size = new Size(67, 21);
			Label10.TabIndex = 72;
			Label10.Text = "Qté";
			Label9.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label9.Location = new Point(374, 36);
			Label9.Name = "Label9";
			Label9.Size = new Size(96, 22);
			Label9.TabIndex = 71;
			Label9.Text = "Lib. Article";
			LIBART.DropDownStyle = ComboBoxStyle.Simple;
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(470, 34);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(228, 24);
			LIBART.TabIndex = 70;
			LIBART.TabStop = false;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(99, 32);
			REFART.Name = "REFART";
			REFART.Size = new Size(231, 24);
			REFART.TabIndex = 60;
			Button26.BackColor = Color.Transparent;
			Button26.BackgroundImage = (Image)componentResourceManager.GetObject("Button26.BackgroundImage");
			Button26.Cursor = Cursors.Hand;
			Button26.FlatStyle = FlatStyle.Flat;
			Button26.ForeColor = Color.Transparent;
			Button26.Location = new Point(353, 32);
			Button26.Name = "Button26";
			Button26.Size = new Size(20, 29);
			Button26.TabIndex = 69;
			Button26.TabStop = false;
			Button26.UseVisualStyleBackColor = false;
			Button25.BackColor = Color.Transparent;
			Button25.BackgroundImage = (Image)componentResourceManager.GetObject("Button25.BackgroundImage");
			Button25.Cursor = Cursors.Hand;
			Button25.FlatStyle = FlatStyle.Flat;
			Button25.ForeColor = Color.Transparent;
			Button25.Location = new Point(378, 70);
			Button25.Name = "Button25";
			Button25.Size = new Size(45, 36);
			Button25.TabIndex = 68;
			Button25.TabStop = false;
			Button25.UseVisualStyleBackColor = false;
			Affich_image_M.BackColor = Color.Transparent;
			Affich_image_M.BackgroundImage = (Image)componentResourceManager.GetObject("Affich_image_M.BackgroundImage");
			Affich_image_M.Cursor = Cursors.Hand;
			Affich_image_M.FlatStyle = FlatStyle.Flat;
			Affich_image_M.ForeColor = Color.Transparent;
			Affich_image_M.Location = new Point(286, 65);
			Affich_image_M.Name = "Affich_image_M";
			Affich_image_M.Size = new Size(44, 47);
			Affich_image_M.TabIndex = 67;
			Affich_image_M.TabStop = false;
			Affich_image_M.UseVisualStyleBackColor = false;
			Label8.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label8.Location = new Point(8, 34);
			Label8.Name = "Label8";
			Label8.Size = new Size(91, 22);
			Label8.TabIndex = 62;
			Label8.Text = "Réf. Article";
			GroupBox9.BackColor = Color.Transparent;
			GroupBox9.Controls.Add(Label7);
			GroupBox9.Controls.Add(Label6);
			GroupBox9.Controls.Add(LB_Article);
			GroupBox9.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox9.Location = new Point(6, 56);
			GroupBox9.Name = "GroupBox9";
			GroupBox9.Size = new Size(726, 54);
			GroupBox9.TabIndex = 28;
			GroupBox9.TabStop = false;
			Label7.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label7.Location = new Point(663, 22);
			Label7.Name = "Label7";
			Label7.Size = new Size(54, 28);
			Label7.TabIndex = 1;
			Label7.Text = "Vente";
			Label6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label6.Location = new Point(19, 22);
			Label6.Name = "Label6";
			Label6.Size = new Size(130, 28);
			Label6.TabIndex = 0;
			Label6.Text = "Article N°";
			LB_Article.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			LB_Article.FormattingEnabled = true;
			LB_Article.ItemHeight = 18;
			LB_Article.Items.AddRange(new object[2]
			{
				"Article Commercial",
				"Article Montée"
			});
			LB_Article.Location = new Point(274, 12);
			LB_Article.Name = "LB_Article";
			LB_Article.Size = new Size(163, 40);
			LB_Article.TabIndex = 69;
			LB_Article.TabStop = false;
			LB_Article.Visible = false;
			GB_COM.BackColor = Color.Transparent;
			GB_COM.Controls.Add(Initier);
			GB_COM.Controls.Add(Button20);
			GB_COM.Controls.Add(Button29);
			GB_COM.Controls.Add(stock_C);
			GB_COM.Controls.Add(Valider_C);
			GB_COM.Controls.Add(total_C);
			GB_COM.Controls.Add(Label17);
			GB_COM.Controls.Add(PRIX_VC);
			GB_COM.Controls.Add(Label18);
			GB_COM.Controls.Add(ValRem_C);
			GB_COM.Controls.Add(Label19);
			GB_COM.Controls.Add(Remise_C);
			GB_COM.Controls.Add(Label20);
			GB_COM.Controls.Add(qte_C);
			GB_COM.Controls.Add(Label21);
			GB_COM.Controls.Add(Label22);
			GB_COM.Controls.Add(LIBART_C);
			GB_COM.Controls.Add(REFART_C);
			GB_COM.Controls.Add(Button21);
			GB_COM.Controls.Add(Button23);
			GB_COM.Controls.Add(Affich_image);
			GB_COM.Controls.Add(Label24);
			GB_COM.Location = new Point(6, 104);
			GB_COM.Name = "GB_COM";
			GB_COM.Size = new Size(867, 240);
			GB_COM.TabIndex = 1;
			GB_COM.TabStop = false;
			Initier.BackColor = Color.White;
			Initier.Cursor = Cursors.Hand;
			Initier.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Initier.Image = Resources.Button_Refresh_icon;
			Initier.ImageAlign = ContentAlignment.MiddleLeft;
			Initier.Location = new Point(302, 179);
			Initier.Margin = new Padding(3, 4, 3, 4);
			Initier.Name = "Initier";
			Initier.Size = new Size(114, 55);
			Initier.TabIndex = 78;
			Initier.Text = "Initier";
			Initier.TextAlign = ContentAlignment.MiddleRight;
			Initier.UseVisualStyleBackColor = false;
			Button20.Location = new Point(322, 35);
			Button20.Name = "Button20";
			Button20.Size = new Size(32, 28);
			Button20.TabIndex = 67;
			Button20.TabStop = false;
			Button20.Text = "...";
			Button20.UseVisualStyleBackColor = true;
			Button29.BackColor = Color.Transparent;
			Button29.BackgroundImage = (Image)componentResourceManager.GetObject("Button29.BackgroundImage");
			Button29.Cursor = Cursors.Hand;
			Button29.FlatStyle = FlatStyle.Flat;
			Button29.ForeColor = Color.Transparent;
			Button29.Location = new Point(732, 159);
			Button29.Name = "Button29";
			Button29.Size = new Size(127, 47);
			Button29.TabIndex = 56;
			Button29.TabStop = false;
			Button29.UseVisualStyleBackColor = false;
			stock_C.AutoSize = true;
			stock_C.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			stock_C.ForeColor = SystemColors.HotTrack;
			stock_C.Location = new Point(159, 70);
			stock_C.Name = "stock_C";
			stock_C.Size = new Size(53, 19);
			stock_C.TabIndex = 71;
			stock_C.Text = "Stock";
			Valider_C.BackColor = Color.Transparent;
			Valider_C.Cursor = Cursors.Hand;
			Valider_C.FlatStyle = FlatStyle.Flat;
			Valider_C.ForeColor = Color.Transparent;
			Valider_C.Image = (Image)componentResourceManager.GetObject("Valider_C.Image");
			Valider_C.Location = new Point(716, 70);
			Valider_C.Name = "Valider_C";
			Valider_C.Size = new Size(143, 47);
			Valider_C.TabIndex = 54;
			Valider_C.UseVisualStyleBackColor = false;
			total_C.BackColor = SystemColors.MenuHighlight;
			total_C.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			total_C.Location = new Point(573, 133);
			total_C.Name = "total_C";
			total_C.ReadOnly = true;
			total_C.Size = new Size(127, 29);
			total_C.TabIndex = 70;
			total_C.TabStop = false;
			total_C.Text = "0.00";
			Label17.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label17.Location = new Point(600, 109);
			Label17.Name = "Label17";
			Label17.Size = new Size(63, 21);
			Label17.TabIndex = 69;
			Label17.Text = "Total";
			PRIX_VC.Location = new Point(162, 133);
			PRIX_VC.Name = "PRIX_VC";
			PRIX_VC.Size = new Size(110, 22);
			PRIX_VC.TabIndex = 53;
			PRIX_VC.TabStop = false;
			PRIX_VC.Text = "0.00";
			Label18.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label18.Location = new Point(187, 109);
			Label18.Name = "Label18";
			Label18.Size = new Size(60, 21);
			Label18.TabIndex = 66;
			Label18.Text = "Prix U.";
			ValRem_C.Location = new Point(398, 133);
			ValRem_C.Name = "ValRem_C";
			ValRem_C.ReadOnly = true;
			ValRem_C.Size = new Size(113, 22);
			ValRem_C.TabIndex = 65;
			ValRem_C.TabStop = false;
			ValRem_C.Text = "0.00";
			Label19.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label19.Location = new Point(300, 105);
			Label19.Name = "Label19";
			Label19.Size = new Size(67, 21);
			Label19.TabIndex = 64;
			Label19.Text = "%Rem.";
			Remise_C.Location = new Point(294, 133);
			Remise_C.Name = "Remise_C";
			Remise_C.ReadOnly = true;
			Remise_C.Size = new Size(81, 22);
			Remise_C.TabIndex = 77;
			Remise_C.Text = "0.00";
			Label20.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label20.Location = new Point(419, 106);
			Label20.Name = "Label20";
			Label20.Size = new Size(81, 21);
			Label20.TabIndex = 63;
			Label20.Text = "Rem.  DT";
			qte_C.Location = new Point(51, 133);
			qte_C.Name = "qte_C";
			qte_C.Size = new Size(96, 22);
			qte_C.TabIndex = 52;
			qte_C.Text = "1";
			Label21.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label21.Location = new Point(78, 109);
			Label21.Name = "Label21";
			Label21.Size = new Size(42, 21);
			Label21.TabIndex = 62;
			Label21.Text = "Qté";
			Label22.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label22.Location = new Point(379, 39);
			Label22.Name = "Label22";
			Label22.Size = new Size(94, 22);
			Label22.TabIndex = 61;
			Label22.Text = "Lib. Article";
			LIBART_C.DropDownStyle = ComboBoxStyle.Simple;
			LIBART_C.FormattingEnabled = true;
			LIBART_C.Location = new Point(477, 37);
			LIBART_C.Name = "LIBART_C";
			LIBART_C.Size = new Size(234, 24);
			LIBART_C.TabIndex = 60;
			LIBART_C.TabStop = false;
			REFART_C.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART_C.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART_C.FormattingEnabled = true;
			REFART_C.Location = new Point(100, 37);
			REFART_C.Name = "REFART_C";
			REFART_C.Size = new Size(239, 24);
			REFART_C.TabIndex = 51;
			Button21.BackColor = Color.Transparent;
			Button21.BackgroundImage = (Image)componentResourceManager.GetObject("Button21.BackgroundImage");
			Button21.Cursor = Cursors.Hand;
			Button21.FlatStyle = FlatStyle.Flat;
			Button21.ForeColor = Color.Transparent;
			Button21.Location = new Point(355, 37);
			Button21.Name = "Button21";
			Button21.Size = new Size(20, 24);
			Button21.TabIndex = 59;
			Button21.TabStop = false;
			Button21.UseVisualStyleBackColor = false;
			Button23.BackColor = Color.Transparent;
			Button23.BackgroundImage = (Image)componentResourceManager.GetObject("Button23.BackgroundImage");
			Button23.Cursor = Cursors.Hand;
			Button23.FlatStyle = FlatStyle.Flat;
			Button23.ForeColor = Color.Transparent;
			Button23.Location = new Point(309, 69);
			Button23.Name = "Button23";
			Button23.Size = new Size(45, 36);
			Button23.TabIndex = 58;
			Button23.TabStop = false;
			Button23.UseVisualStyleBackColor = false;
			Affich_image.BackColor = Color.Transparent;
			Affich_image.BackgroundImage = (Image)componentResourceManager.GetObject("Affich_image.BackgroundImage");
			Affich_image.Cursor = Cursors.Hand;
			Affich_image.FlatStyle = FlatStyle.Flat;
			Affich_image.ForeColor = Color.Transparent;
			Affich_image.Location = new Point(391, 66);
			Affich_image.Name = "Affich_image";
			Affich_image.Size = new Size(44, 47);
			Affich_image.TabIndex = 57;
			Affich_image.TabStop = false;
			Affich_image.UseVisualStyleBackColor = false;
			Label24.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label24.Location = new Point(7, 41);
			Label24.Name = "Label24";
			Label24.Size = new Size(94, 22);
			Label24.TabIndex = 53;
			Label24.Text = "Réf. Article";
			Enregistrer.Location = new Point(633, 650);
			Enregistrer.Name = "Enregistrer";
			Enregistrer.Size = new Size(90, 40);
			Enregistrer.TabIndex = 35;
			Enregistrer.TabStop = false;
			Enregistrer.Text = "Enregistrer";
			Enregistrer.UseVisualStyleBackColor = true;
			Enregistrer.Visible = false;
			transp.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			transp.Location = new Point(900, 128);
			transp.Name = "transp";
			transp.Size = new Size(91, 26);
			transp.TabIndex = 40;
			transp.Text = "0.00";
			transp.Visible = false;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(874, 100);
			Label4.Name = "Label4";
			Label4.Size = new Size(146, 21);
			Label4.TabIndex = 51;
			Label4.Text = "Frais Tranasport";
			Label4.Visible = false;
			Button19.BackColor = Color.CornflowerBlue;
			Button19.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button19.Location = new Point(879, 180);
			Button19.Margin = new Padding(3, 4, 3, 4);
			Button19.Name = "Button19";
			Button19.Size = new Size(141, 40);
			Button19.TabIndex = 53;
			Button19.Text = "Valider F.Transport";
			Button19.UseVisualStyleBackColor = false;
			Button19.Visible = false;
			GroupBox7.BackColor = Color.Transparent;
			GroupBox7.Controls.Add(dgv1);
			GroupBox7.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox7.Location = new Point(82, 350);
			GroupBox7.Name = "GroupBox7";
			GroupBox7.Size = new Size(995, 250);
			GroupBox7.TabIndex = 104;
			GroupBox7.TabStop = false;
			GroupBox8.Controls.Add(Reg_Cheque);
			GroupBox8.Controls.Add(Reg_Multi);
			GroupBox8.Controls.Add(Reg_Carte);
			GroupBox8.Controls.Add(Reg_espece);
			GroupBox8.Location = new Point(1083, 345);
			GroupBox8.Name = "GroupBox8";
			GroupBox8.Size = new Size(91, 299);
			GroupBox8.TabIndex = 105;
			GroupBox8.TabStop = false;
			GroupBox8.Text = "Règlement";
			Label25.BackColor = Color.Transparent;
			Label25.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label25.ForeColor = SystemColors.HotTrack;
			Label25.Location = new Point(1159, 345);
			Label25.Name = "Label25";
			Label25.Size = new Size(39, 18);
			Label25.TabIndex = 72;
			Label25.Text = "(F12)";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Label25);
			base.Controls.Add(GroupBox8);
			base.Controls.Add(GroupBox7);
			base.Controls.Add(GroupBox9);
			base.Controls.Add(Button19);
			base.Controls.Add(GroupBox4);
			base.Controls.Add(transp);
			base.Controls.Add(Label4);
			base.Controls.Add(GroupBox3);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(Label5);
			base.Controls.Add(Comment);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(Enregistrer);
			base.Controls.Add(GroupBox5);
			base.Controls.Add(GroupBox6);
			base.Controls.Add(GB_COM);
			base.Controls.Add(GB_MONT);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Gestion_Vente";
			Text = "Gestion Vente";
			base.Controls.SetChildIndex(GB_MONT, 0);
			base.Controls.SetChildIndex(GB_COM, 0);
			base.Controls.SetChildIndex(GroupBox6, 0);
			base.Controls.SetChildIndex(GroupBox5, 0);
			base.Controls.SetChildIndex(Enregistrer, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(Comment, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(GroupBox3, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(transp, 0);
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(Button19, 0);
			base.Controls.SetChildIndex(GroupBox9, 0);
			base.Controls.SetChildIndex(GroupBox7, 0);
			base.Controls.SetChildIndex(GroupBox8, 0);
			base.Controls.SetChildIndex(Label25, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox2.ResumeLayout(false);
			((ISupportInitialize)dgv1).EndInit();
			GroupBox3.ResumeLayout(false);
			GroupBox3.PerformLayout();
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox5.ResumeLayout(false);
			GroupBox6.ResumeLayout(false);
			GroupBox6.PerformLayout();
			GB_MONT.ResumeLayout(false);
			GB_MONT.PerformLayout();
			GroupBox9.ResumeLayout(false);
			GB_COM.ResumeLayout(false);
			GB_COM.PerformLayout();
			GroupBox7.ResumeLayout(false);
			GroupBox8.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
		}

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button12_Click(1, e);
				e.Handled = true;
			}
			if (e.KeyValue == 121)
			{
				Valider_ticket.Focus();
				e.Handled = true;
			}
			if (e.KeyValue == 122)
			{
				IDCLIENT.Focus();
				e.Handled = true;
			}
			if (e.KeyValue == 123)
			{
				Reg_espece.Focus();
				e.Handled = true;
			}
		}

		private void REFART_C_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button20_Click(1, e);
				e.Handled = true;
			}
			if (e.KeyValue == 121)
			{
				Valider_ticket.Focus();
				e.Handled = true;
			}
			if (e.KeyValue == 122)
			{
				IDCLIENT.Focus();
				e.Handled = true;
			}
			if (e.KeyValue == 123)
			{
				Reg_espece.Focus();
				e.Handled = true;
			}
		}

		public void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.ClearTextBox(this);
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from ARTICLE_D where REFART ='" + REFART.Text + "'";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					qte.Text = "1";
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					Remise.Text = mySqlDataReader["REM"].ToString();
					if (Operators.CompareString(Remise.Text, "", false) == 0)
					{
						Remise.Text = "0";
					}
					PRIX_V.Text = mySqlDataReader["PRIX_REVIENT"].ToString();
					if (Operators.CompareString(PRIX_V.Text, "", false) == 0)
					{
						PRIX_V.Text = "0";
					}
					if (Operators.CompareString(PRIX_POSE.Text, "", false) == 0)
					{
						PRIX_POSE.Text = "0";
					}
					if (Operators.CompareString(TotalFAC.Text, "", false) == 0)
					{
						TotalFAC.Text = "0";
					}
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					LB_FACADE();
					ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
					total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
				}
				else
				{
					MessageBox.Show("ARTICLE non trouvé");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				stock_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void qte_Validated(object sender, EventArgs e)
		{
			try
			{
				qte.Text = Strings.Replace(qte.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
				total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
				stock_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Remise_Validated(object sender, EventArgs e)
		{
			try
			{
				Remise.Text = Strings.Replace(Remise.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
				total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
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

		private void PRIX_V_Validated(object sender, EventArgs e)
		{
			try
			{
				PRIX_V.Text = Strings.Replace(PRIX_V.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
				total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
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
					if (Globals.controlNum(PRIX_V.Text) + Globals.controlNum(qte.Text) + Globals.controlNum(Remise.Text) + Globals.controlNum(total.Text) + Globals.controlNum(TotalFAC.Text) + Globals.controlNum(PRIX_POSE.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from VENTE";
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
							mySqlCommand.CommandText = "SELECT MAX(NUM_DF)+1 FROM VENTE";
							NUM_VENTE = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						if (flag_tick == 1)
						{
							string text2 = "select * from TICKET";
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
								mySqlCommand2.CommandText = "SELECT MAX(NUM_FACT)+1 FROM TICKET ";
								NUM_TICK = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
							}
						}
						decimal value = decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(TotalFAC.Text));
						string text3 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(Remise.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(qte.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text6 = Strings.Replace(total.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO VENTE(NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)VALUES('" + Conversions.ToString(NUM_VENTE) + "','" + REFART.Text + "','" + LIBART.Text + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + Conversions.ToString(NUM_TICK) + "')";
						Globals.ExecuteInsertQuery(query);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM VENTE WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						TOTALV.Text = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Globals.cmd.ExecuteScalar()), 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault).ToString();
						Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) STOK,IFNULL(STKMIN,0) STKMIN FROM ARTICLE_D where REFART='" + REFART.Text + "'";
						MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
						decimal num3 = default(decimal);
						decimal value2 = default(decimal);
						if (mySqlDataReader.Read())
						{
							num3 = Conversions.ToDecimal(mySqlDataReader["STKMIN"].ToString());
							value2 = Conversions.ToDecimal(mySqlDataReader["STOK"].ToString());
						}
						mySqlDataReader.Close();
						mySqlDataReader.Dispose();
						decimal num4 = default(decimal);
						num4 = new decimal(unchecked(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value2), ".", ",", 1, -1, CompareMethod.Binary)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Globals.convertDN(qte.Text)), ".", ",", 1, -1, CompareMethod.Binary))));
						if (decimal.Compare(num4, num3) < 0)
						{
							MessageBox.Show("Stock minimum " + Conversions.ToString(num3) + " permis atteint, Veuillez alimenter le stock !", "Alerte Stock");
						}
						string text7 = Strings.Replace(Conversions.ToString(num4), ",", ".", 1, -1, CompareMethod.Binary);
						string cmdText = "UPDATE ARTICLE_D SET STOK=" + text7 + " WHERE REFART='" + REFART.Text + "'";
						MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText, Globals.conn);
						mySqlCommand3.ExecuteNonQuery();
						if (flag_tick == 1)
						{
							string text8 = Strings.Replace(TOTALV.Text, ",", ".", 1, -1, CompareMethod.Binary);
							string query2 = "INSERT INTO TICKET(NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, TOTALTTC_FACT, NOM_SOC, ADRESSE_SOC)VALUES('" + Conversions.ToString(NUM_TICK) + "', '" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', '" + IDCLIENT.Text + "', '" + Globals.Utilisateur + "','" + text8 + "', '" + Globals.NOMSOC + "', '" + Globals.ADRESSESOC + "')";
							Globals.ExecuteInsertQuery(query2);
							flag_tick = 0;
						}
						string text9 = "select * from sortie_stock";
						MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(text9, Globals.conn);
						MySqlCommand mySqlCommand4 = new MySqlCommand(text9, Globals.conn);
						DataTable dataTable3 = new DataTable();
						mySqlDataAdapter3.Fill(dataTable3);
						int num5 = dataTable3.Rows.Count - 1;
						if (num5 == -1)
						{
							COD_S = 1;
						}
						else
						{
							mySqlCommand4.CommandText = "SELECT MAX(code_sortie)+1 FROM sortie_stock ";
							COD_S = Conversions.ToInteger(mySqlCommand4.ExecuteScalar());
						}
						DateTime dateTime = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
						string text10 = Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary);
						string query3 = "INSERT INTO sortie_stock(REFART, LIBART, quantite, client, Date_sortie, Code_sortie, STOCK_AVANT, STOCK_APRES,TYPE_SORTIE)VALUES('" + REFART.Text + "', '" + LIBART.Text + "', '" + text5 + "','" + IDCLIENT.Text + "','" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "'," + Conversions.ToString(COD_S) + ", '" + text10 + "','" + text7 + "','Vente')";
						Globals.ExecuteInsertQuery(query3);
						Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
						string query4 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from VENTE where NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						dgv1.DataSource = null;
						dgv1.Rows.Clear();
						Globals.LoadData(query4, dgv1, "Vente");
						formatDGV(dgv1);
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						Globals.ClearTextBox(this);
						REFART.Text = "";
						LIBART.Text = "";
						REFART.Focus();
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

		public void formatDGV(object dgv1)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				0
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Réf. Article"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				1
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Nom"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				2
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Prix"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				3
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Qté"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				4
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Remise"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				5
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"Total"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				6
			}, null, null, null), null, "HeaderCell", new object[0], null, null, null), null, "Value", new object[1]
			{
				"NUMVENTE"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				2
			}, null, null, null), null, "DefaultCellStyle", new object[0], null, null, null), null, "Format", new object[1]
			{
				"N3"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				0
			}, null, null, null), null, "Width", new object[1]
			{
				200
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				1
			}, null, null, null), null, "Width", new object[1]
			{
				230
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				2
			}, null, null, null), null, "Width", new object[1]
			{
				150
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				3
			}, null, null, null), null, "Width", new object[1]
			{
				100
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				4
			}, null, null, null), null, "Width", new object[1]
			{
				100
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				5
			}, null, null, null), null, "Width", new object[1]
			{
				150
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				6
			}, null, null, null), null, "Visible", new object[1]
			{
				false
			}, null, null, false, true);
			object obj = null;
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Rows", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1));
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
					object instance = NewLateBinding.LateGet(dgv1, null, "Rows", obj2, null, null, obj3);
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
					object instance = NewLateBinding.LateGet(dgv1, null, "Rows", obj4, null, null, obj5);
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

		private void Valider_ticket_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			Frm_Fact frm_Fact = new Frm_Fact();
			frm_Fact.TYPEFACT = "TIC";
			frm_Fact.NUMFACT.Text = Conversions.ToString(NUM_TICK);
			flag_tick = 1;
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			TOTALV.Text = "";
			Reste_A_Payer.Text = "";
			Label1.Text = "Reste à Payer";
			IDCLIENT.Text = "Anonyme";
			MessageBox.Show("Ticket validé");
			frm_Fact.Frm_Fact_Load(RuntimeHelpers.GetObjectValue(sender), e);
			frm_Fact.BtnPrint_Click(RuntimeHelpers.GetObjectValue(sender), e);
			if (AffichTicket.Checked)
			{
				frm_Fact.Show();
			}
			REFART.Focus();
		}

		private void ajout_Comment()
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				DateTime dateTime = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
				string text = Strings.Replace(TOTALV.Text, ",", ".", 1, -1, CompareMethod.Binary);
				string cmdText = "UPDATE TICKET SET COMMENTAIRE='" + Comment.Text + "',DATE_FACT='" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "', IDCLIENT='" + IDCLIENT.Text + "', VENDEUR='" + Globals.Utilisateur + "', TOTALTTC_FACT='" + text + "' WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
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

		private void Button26_Click(object sender, EventArgs e)
		{
			REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
			REFART.Text = "";
			LIBART.Text = "";
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
				Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Suprim1ligne_Click(object sender, EventArgs e)
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
						Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
			string cmdText = "DELETE FROM VENTE WHERE NUM_DF='" + NUMDFAS + "'";
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
			mySqlCommand.ExecuteNonQuery();
			string text = Strings.Replace(PRIX_VC.Text, ",", ".", 1, -1, CompareMethod.Binary);
			string text2 = Strings.Replace(Remise_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
			string text3 = Strings.Replace(qte_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
			string text4 = Strings.Replace(total_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
			mySqlCommand.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM VENTE WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
			TOTALV.Text = mySqlCommand.ExecuteScalar().ToString();
			string cmdText2 = "UPDATE ARTICLE_D SET STOK=STOK +'" + dgv1.CurrentRow.Cells[3].Value.ToString() + "' WHERE REFART='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
			MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, Globals.conn);
			mySqlCommand2.ExecuteNonQuery();
			string cmdText3 = "DELETE FROM SORTIE_STOCK WHERE NUM_DF='" + NUMDFAS + "'";
			MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText3, Globals.conn);
			mySqlCommand3.ExecuteNonQuery();
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
			MyProject.Forms.Histo_Client.BringToFront();
			MyProject.Forms.Histo_Client.IDCLIENT.Text = IDCLIENT.Text;
			MyProject.Forms.Histo_Client.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void VlidFacture_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			Frm_Fact frm_Fact = new Frm_Fact();
			frm_Fact.TYPEFACT = "F";
			frm_Fact.NUMFACT.Text = Conversions.ToString(NUM_TICK);
			frm_Fact.TIMBRE.Visible = true;
			frm_Fact.REMISE.Visible = true;
			flag_tick = 1;
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			TOTALV.Text = "";
			Label1.Text = "Reste à Payer";
			Reste_A_Payer.Text = "";
			IDCLIENT.Text = "Anonyme";
			MessageBox.Show("Facture validé");
			frm_Fact.Show();
		}

		private void Button17_Click(object sender, EventArgs e)
		{
			ajout_Comment();
			flag_tick = 1;
			dgv1.DataSource = null;
			dgv1.Rows.Clear();
			TOTALV.Text = "";
			Reste_A_Payer.Text = "";
			Label1.Text = "Reste à Payer";
			IDCLIENT.Text = "Anonyme";
			MessageBox.Show("Ticket validé");
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

		private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv1.CurrentRow.Cells[0].Value = REFART.Text;
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

		public void stock_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART.Text + "'";
				decimal value = Conversions.ToDecimal(Operators.SubtractObject(Globals.cmd.ExecuteScalar(), Globals.convertDN(qte.Text)));
				stock.Text = "Stock: " + Conversions.ToString(value);
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

		public void stock_c_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + REFART_C.Text + "'";
				decimal value = Conversions.ToDecimal(Operators.SubtractObject(Globals.cmd.ExecuteScalar(), Globals.convertDN(qte.Text)));
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

		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.flag_COD = "VM";
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

		private void FACADE_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from FACADE WHERE NUM_FAC=(select NUM_FAC FROM FACADE where \r\n                 =1 AND REF_FAC='" + FACADE.Text + "' AND REFART= '" + REFART.Text + "')";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					TotalFAC.Text = mySqlDataReader["Total_FAC"].ToString();
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				Globals.cmd.Dispose();
				ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
				total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
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
						string text = "select * from VENTE";
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
							mySqlCommand.CommandText = "SELECT MAX(NUM_DF)+1 FROM VENTE";
							NUM_VENTE = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						if (flag_tick == 1)
						{
							string text2 = "select * from TICKET";
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
								mySqlCommand2.CommandText = "SELECT MAX(NUM_FACT)+1 FROM TICKET ";
								NUM_TICK = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
							}
						}
						string text3 = Strings.Replace(transp.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO VENTE(NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)VALUES('" + Conversions.ToString(NUM_VENTE) + "','F.Transport','F.Transport','" + text3 + "','0','1','" + text3 + "','" + Conversions.ToString(NUM_TICK) + "')";
						Globals.ExecuteInsertQuery(query);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM VENTE WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						TOTALV.Text = Globals.cmd.ExecuteScalar().ToString();
						string text4 = Strings.Replace(TOTALV.Text, ",", ".", 1, -1, CompareMethod.Binary);
						if (flag_tick == 1)
						{
							DateTime dateTime = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
							string query2 = "INSERT INTO TICKET(NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, TOTALTTC_FACT)VALUES('" + Conversions.ToString(NUM_TICK) + "', '" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "', '" + IDCLIENT.Text + "', '" + Globals.Utilisateur + "','" + text4 + "')";
							Globals.ExecuteInsertQuery(query2);
							flag_tick = 0;
						}
						string query3 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from VENTE where NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						dgv1.DataSource = null;
						dgv1.Rows.Clear();
						Globals.LoadData(query3, dgv1, "Vente");
						formatDGV(dgv1);
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						Globals.ClearTextBox(this);
						REFART.Text = "";
						LIBART.Text = "";
						Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Button16_Click(object sender, EventArgs e)
		{
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
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
					PRIX_VC.Text = mySqlDataReader["PRIX_V"].ToString();
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
				stock_c_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
						string text = "select * from VENTE";
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
							mySqlCommand.CommandText = "SELECT MAX(NUM_DF)+1 FROM VENTE";
							NUM_VENTE = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						if (flag_tick == 1)
						{
							string text2 = "select * from TICKET";
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
								mySqlCommand2.CommandText = "SELECT MAX(NUM_FACT)+1 FROM TICKET ";
								NUM_TICK = Conversions.ToInteger(mySqlCommand2.ExecuteScalar());
							}
						}
						string text3 = Strings.Replace(PRIX_VC.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text4 = Strings.Replace(Remise_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text5 = Strings.Replace(qte_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string text6 = Strings.Replace(total_C.Text, ",", ".", 1, -1, CompareMethod.Binary);
						string query = "INSERT INTO VENTE(NUM_DF, REFART, LIBART, PRIX_V, REM, QTE, TotalTTC_DF, NUM_FACT)VALUES('" + Conversions.ToString(NUM_VENTE) + "','" + REFART_C.Text + "','" + LIBART_C.Text + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + Conversions.ToString(NUM_TICK) + "')";
						Globals.ExecuteInsertQuery(query);
						Globals.cmd.CommandText = "SELECT IFNULL(SUM(TotalTTC_DF),0) FROM VENTE WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						TOTALV.Text = Globals.cmd.ExecuteScalar().ToString();
						Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) STOK, IFNULL(STKMIN,0) STKMIN FROM ARTICLE_D where REFART='" + REFART_C.Text + "'";
						MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
						decimal value = default(decimal);
						decimal num3 = default(decimal);
						if (mySqlDataReader.Read())
						{
							value = Conversions.ToDecimal(mySqlDataReader["STOK"].ToString());
							num3 = Conversions.ToDecimal(mySqlDataReader["STKMIN"].ToString());
						}
						mySqlDataReader.Close();
						mySqlDataReader.Dispose();
						string text7 = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
						decimal num4 = default(decimal);
						num4 = new decimal(unchecked(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Globals.convertDN(qte_C.Text)), ".", ",", 1, -1, CompareMethod.Binary))));
						if (decimal.Compare(num4, num3) < 0)
						{
							MessageBox.Show("Stock minimum " + Conversions.ToString(num3) + " permis atteint, Veuillez alimenter le stock !", "Alerte Stock");
						}
						string text8 = Strings.Replace(Conversions.ToString(num4), ",", ".", 1, -1, CompareMethod.Binary);
						string cmdText = "UPDATE ARTICLE_D SET STOK=" + text8 + " WHERE REFART='" + REFART_C.Text + "'";
						MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText, Globals.conn);
						mySqlCommand3.ExecuteNonQuery();
						if (flag_tick == 1)
						{
							DateTime dateTime = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
							string text9 = Strings.Replace(TOTALV.Text, ",", ".", 1, -1, CompareMethod.Binary);
							string query2 = "INSERT INTO TICKET(NUM_FACT, DATE_FACT, IDCLIENT, VENDEUR, TOTALTTC_FACT, NOM_SOC, ADRESSE_SOC)VALUES('" + Conversions.ToString(NUM_TICK) + "', '" + dateTime.ToString("yyyy-MM-dd H:mm:ss") + "', '" + IDCLIENT.Text + "', '" + Globals.Utilisateur + "','" + text9 + "', '" + Globals.NOMSOC + "', '" + Globals.ADRESSESOC + "')";
							Globals.ExecuteInsertQuery(query2);
							flag_tick = 0;
						}
						string text10 = "select * from sortie_stock";
						MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(text10, Globals.conn);
						MySqlCommand mySqlCommand4 = new MySqlCommand(text10, Globals.conn);
						DataTable dataTable3 = new DataTable();
						mySqlDataAdapter3.Fill(dataTable3);
						int num5 = dataTable3.Rows.Count - 1;
						if (num5 == -1)
						{
							COD_S = 1;
						}
						else
						{
							mySqlCommand4.CommandText = "SELECT MAX(code_sortie)+1 FROM sortie_stock ";
							COD_S = Conversions.ToInteger(mySqlCommand4.ExecuteScalar());
						}
						string query3 = "INSERT INTO sortie_stock(REFART, LIBART, quantite, client, Date_sortie, Code_sortie, STOCK_AVANT, STOCK_APRES,TYPE_SORTIE,NUM_DF)VALUES('" + REFART_C.Text + "', '" + LIBART_C.Text + "', '" + text5 + "','" + IDCLIENT.Text + "','" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "'," + Conversions.ToString(COD_S) + ", '" + text7 + "','" + text8 + "','Vente','" + Conversions.ToString(NUM_VENTE) + "')";
						Globals.ExecuteInsertQuery(query3);
						string query4 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from VENTE where NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						dgv1.DataSource = null;
						dgv1.Rows.Clear();
						Globals.LoadData(query4, dgv1, "Vente");
						formatDGV(dgv1);
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						Globals.ClearTextBox(this);
						REFART_C.Text = "";
						LIBART_C.Text = "";
						stock_C.Text = "";
						Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				Globals.flag_COD = "VC";
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
				stock_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void PRIX_POSE_Validated(object sender, EventArgs e)
		{
			try
			{
				PRIX_POSE.Text = Strings.Replace(PRIX_POSE.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise.Text)) * 0.01 * Convert.ToDouble(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text))));
				total.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(decimal.Add(decimal.Add(Globals.convertDN(PRIX_V.Text), Globals.convertDN(PRIX_POSE.Text)), Globals.convertDN(TotalFAC.Text)), Globals.convertDN(ValRem.Text)), Globals.convertDN(qte.Text)));
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

		private void LB_Article_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(LB_Article.Text, "Article Commercial", false) == 0)
			{
				LB_Article.SelectedItem = "Article Commercial";
				GB_MONT.Visible = false;
				GB_COM.Visible = true;
			}
			else if (Operators.CompareString(LB_Article.Text, "Article Montée", false) == 0)
			{
				LB_Article.SelectedItem = "Article Montée";
				GB_MONT.Visible = true;
				GB_COM.Visible = false;
			}
		}

		private void Gestion_Vente_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					IDCLIENT.Text = "Anonyme";
					REFART_C.Focus();
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
					MySqlCommand mySqlCommand2 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand2);
					DataSet dataSet2 = new DataSet();
					mySqlCommand2.Connection = Globals.conn;
					mySqlCommand2.CommandText = "select distinct REFART from ARTICLE_D WHERE TYPE_ART='COMMERCIALE'";
					mySqlDataAdapter2.Fill(dataSet2, "list0");
					AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
					int num2 = dataSet2.Tables[0].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						autoCompleteStringCollection2.Add(dataSet2.Tables[0].Rows[j]["REFART"].ToString());
					}
					REFART_C.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART_C.AutoCompleteCustomSource = autoCompleteStringCollection2;
					REFART_C.AutoCompleteMode = AutoCompleteMode.Suggest;
					MySqlCommand mySqlCommand3 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(mySqlCommand3);
					DataSet dataSet3 = new DataSet();
					mySqlCommand3.Connection = Globals.conn;
					mySqlCommand3.CommandText = "select distinct IDCLIENT from CLIENT ";
					mySqlDataAdapter3.Fill(dataSet3, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection3 = new AutoCompleteStringCollection();
					int num3 = dataSet3.Tables[0].Rows.Count - 1;
					for (int k = 0; k <= num3; k++)
					{
						autoCompleteStringCollection3.Add(dataSet3.Tables[0].Rows[k]["IDCLIENT"].ToString());
					}
					IDCLIENT.AutoCompleteSource = AutoCompleteSource.CustomSource;
					IDCLIENT.AutoCompleteCustomSource = autoCompleteStringCollection3;
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

		private void IDCLIENT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button11_Click(1, e);
				e.Handled = true;
			}
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
				mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT where IDCLIENT LIKE '" + IDCLIENT.Text + "%'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				IDCLIENT.Items.Clear();
				if (!mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					DialogResult dialogResult = MessageBox.Show("Ce Client n'existe pas,Etes vous sûre de vouloir ajouter ce Client?", "Ajout Client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						IDCLIENT.Text = "";
					}
					else
					{
						MyProject.Forms.Gestion_Client.Show();
						MyProject.Forms.Gestion_Client.BringToFront();
						Globals.ClearTextBox(MyProject.Forms.Gestion_Client);
						Globals.ClearComboBox(MyProject.Forms.Gestion_Client);
						MyProject.Forms.Gestion_Client.IDCLIENT.Text = IDCLIENT.Text;
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

		private void Reg_espece_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Reglement.Show();
			MyProject.Forms.Reglement.BringToFront();
			MyProject.Forms.Reglement.Mode_Regl.Text = "Espece";
			MyProject.Forms.Reglement.code.Text = "Nombre de pièces";
		}

		private void Reg_Carte_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Reglement.Show();
			MyProject.Forms.Reglement.BringToFront();
			MyProject.Forms.Reglement.Mode_Regl.Text = "Carte";
			MyProject.Forms.Reglement.code.Text = "Code Carte";
		}

		private void Reg_Cheque_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Reglement.Show();
			MyProject.Forms.Reglement.BringToFront();
			MyProject.Forms.Reglement.Mode_Regl.Text = "Cheque";
			MyProject.Forms.Reglement.code.Text = "Code Cheque";
		}

		private void Reg_Multi_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Reglement.Show();
			MyProject.Forms.Reglement.BringToFront();
			MyProject.Forms.Reglement.Mode_Regl.Text = "";
			MyProject.Forms.Reglement.code.Text = "";
			MyProject.Forms.Reglement.LinkLabel1.Visible = true;
			MyProject.Forms.Reglement.flag_multi = 1;
		}

		public void Reste_A_Payer_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select IFNULL(sum(MONTANT_DREG),0) from DETAIL_REGLEMENT where NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
				decimal value = Conversions.ToDecimal(mySqlCommand.ExecuteScalar());
				decimal num = default(decimal);
				num = decimal.Subtract(Globals.convertDN(TOTALV.Text), Conversions.ToDecimal(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)));
				Reste_A_Payer.Text = Conversions.ToString(decimal.Round(num, 3, MidpointRounding.AwayFromZero));
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				if (decimal.Compare(num, decimal.Zero) < 0)
				{
					Label1.Text = "A rendre (DT)";
					Reste_A_Payer.Text = Conversions.ToString(decimal.Round(decimal.Negate(num), 3, MidpointRounding.AwayFromZero));
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

		private void Affich_image_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Image_ARTICLE.Show();
			MyProject.Forms.Image_ARTICLE.REFART.Text = REFART_C.Text;
			MyProject.Forms.Image_ARTICLE.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Affich_image_M_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Image_ARTICLE.Show();
			MyProject.Forms.Image_ARTICLE.BringToFront();
			MyProject.Forms.Image_ARTICLE.REFART.Text = REFART.Text;
			MyProject.Forms.Image_ARTICLE.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Valider_C_Enter(object sender, EventArgs e)
		{
			if (Operators.CompareString(REFART_C.Text, "", false) == 0)
			{
				MessageBox.Show("Veuillez entrer un article");
				REFART.Focus();
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

		private void Button21_Click(object sender, EventArgs e)
		{
			REFART_C_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Valider_ticket_Enter(object sender, EventArgs e)
		{
			Valider_ticket_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Reg_espece_Enter(object sender, EventArgs e)
		{
			Reg_espece_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Reg_carte_Enter(object sender, EventArgs e)
		{
			Reg_Carte_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Reg_cheque_Enter(object sender, EventArgs e)
		{
			Reg_Cheque_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Reg_multi_Enter(object sender, EventArgs e)
		{
			Reg_Multi_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void B_Rem_General_Click(object sender, EventArgs e)
		{
		}

		private void Remise_general_Validated(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir appliquer une remise générale à cet achat?", "Remise générale?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					ValRem_C.Text = Conversions.ToString(Convert.ToDouble(Globals.convertDN(Remise_general.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(TOTALV.Text)));
					decimal value = new decimal(Convert.ToDouble(Globals.convertDN(TOTALV.Text)) - Convert.ToDouble(Globals.convertDN(Remise_general.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(TOTALV.Text)));
					string text = Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary);
					string text2 = Strings.Replace(Remise_general.Text, ",", ".", 1, -1, CompareMethod.Binary);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					string cmdText = "UPDATE TICKET SET TOTALTTC_FACT='" + text + "',REMISE_GEN='" + text2 + "' WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					mySqlCommand.ExecuteNonQuery();
					MessageBox.Show("Remise générale appliquée");
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

		private void IDCLIENT_TextChanged(object sender, EventArgs e)
		{
		}

		private void Valider_C_Validated(object sender, EventArgs e)
		{
			if (Operators.CompareString(REFART_C.Text, "", false) != 0)
			{
				Valider_C_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Initier_Click(object sender, EventArgs e)
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
						string cmdText = "DELETE FROM TICKET WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
						string cmdText2 = "DELETE FROM DETAIL_REGLEMENT WHERE NUM_FACT='" + Conversions.ToString(NUM_TICK) + "'";
						MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, Globals.conn);
						mySqlCommand2.ExecuteNonQuery();
						TOTALV.Text = "";
						REFART_C.Focus();
						Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

		private void Gestion_Vente_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (dgv1.RowCount > 0)
			{
				switch (MessageBox.Show("Vous avez des ventes non validés, Voulez-vous vraiment fermer et supprimer ces ventes?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
				case DialogResult.Yes:
					e.Cancel = false;
					Initier_Click(RuntimeHelpers.GetObjectValue(sender), e);
					break;
				case DialogResult.No:
					e.Cancel = true;
					break;
				}
			}
		}
	}
}
