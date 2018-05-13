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
	public class Gestion_Client : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CHARGE")]
		private TextBox _CHARGE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label32")]
		private Label _label32;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label4")]
		private Label _label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RESP")]
		private TextBox _RESP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label9")]
		private Label _label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TYPVENTE")]
		private ComboBox _TYPVENTE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

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
		[AccessedThroughProperty("CONTACT")]
		private TextBox _CONTACT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TYPTVA")]
		private ComboBox _TYPTVA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label30")]
		private Label _label30;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("checkedListBox1")]
		private CheckedListBox _checkedListBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MONT")]
		private TextBox _MONT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("groupBox3")]
		private GroupBox _groupBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label25")]
		private Label _label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("COTION")]
		private TextBox _COTION;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label28")]
		private Label _label28;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MODEREGL")]
		private ComboBox _MODEREGL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBFAM")]
		private TextBox _LIBFAM;

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
		[AccessedThroughProperty("FAMCLI")]
		private TextBox _FAMCLI;

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
		[AccessedThroughProperty("CODETVA")]
		private TextBox _CODETVA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TIMBRE")]
		private TextBox _TIMBRE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label20")]
		private Label _label20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FAX2")]
		private TextBox _FAX2;

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
		[AccessedThroughProperty("Région")]
		private TextBox _Région;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label100")]
		private Label _Label100;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

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
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label3")]
		private Label _label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label2")]
		private Label _label2;

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
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FAX")]
		private TextBox _FAX;

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
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

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
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nom")]
		private TextBox _Nom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		public string NewClient;

		internal virtual TextBox CHARGE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label32
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

		internal virtual TextBox RESP
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox TYPVENTE
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

		internal virtual ComboBox TYPTVA
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label30
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckedListBox checkedListBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox MONT
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual GroupBox groupBox3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label25
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox COTION
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label label28
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

		internal virtual ComboBox MODEREGL
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

		internal virtual TextBox LIBFAM
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

		internal virtual TextBox FAMCLI
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

		internal virtual Label Label7
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

		internal virtual Label label20
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox FAX2
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

		internal virtual TextBox Région
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label100
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

		internal virtual Label Label22
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

		internal virtual Label label2
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

		internal virtual Label Label5
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

		internal virtual Label Label34
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

		internal virtual TextBox Nom
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

		public Gestion_Client()
		{
			base.Load += Gestion_Client_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_Client));
			CHARGE = new TextBox();
			label32 = new Label();
			label4 = new Label();
			RESP = new TextBox();
			label9 = new Label();
			TYPVENTE = new ComboBox();
			GroupBox2 = new GroupBox();
			MAIL = new TextBox();
			Label15 = new Label();
			label20 = new Label();
			FAX2 = new TextBox();
			GSM3 = new TextBox();
			label17 = new Label();
			CONTACT3 = new TextBox();
			label18 = new Label();
			GSM2 = new TextBox();
			Label13 = new Label();
			CONTACT2 = new TextBox();
			TEL = new TextBox();
			Label14 = new Label();
			label16 = new Label();
			GSM1 = new TextBox();
			Label11 = new Label();
			CONTACT1 = new TextBox();
			Label12 = new Label();
			Label5 = new Label();
			GSM = new TextBox();
			FAX = new TextBox();
			Label10 = new Label();
			CONTACT = new TextBox();
			Label6 = new Label();
			TYPTVA = new ComboBox();
			label30 = new Label();
			checkedListBox1 = new CheckedListBox();
			MONT = new TextBox();
			groupBox3 = new GroupBox();
			label25 = new Label();
			COTION = new TextBox();
			label28 = new Label();
			GroupBox4 = new GroupBox();
			Label34 = new Label();
			Label33 = new Label();
			MODEREGL = new ComboBox();
			Label19 = new Label();
			LIBFAM = new TextBox();
			Label23 = new Label();
			ECHEANCE = new TextBox();
			Label24 = new Label();
			FAMCLI = new TextBox();
			Label26 = new Label();
			REMISE = new TextBox();
			Label27 = new Label();
			CODETVA = new TextBox();
			Label8 = new Label();
			Label7 = new Label();
			TIMBRE = new TextBox();
			Région = new TextBox();
			Label100 = new Label();
			B_rechercher = new Button();
			IDCLIENT = new ComboBox();
			VILLE = new TextBox();
			Label29 = new Label();
			ADRESSE = new TextBox();
			GroupBox1 = new GroupBox();
			Nom = new TextBox();
			Button11 = new Button();
			Label22 = new Label();
			label3 = new Label();
			label2 = new Label();
			groupBox6 = new GroupBox();
			btnDelete = new Button();
			b_imprimer = new Button();
			b_enregistrer = new Button();
			Button23 = new Button();
			Label21 = new Label();
			GroupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox1.SuspendLayout();
			groupBox6.SuspendLayout();
			base.SuspendLayout();
			CHARGE.Location = new Point(517, 257);
			CHARGE.Margin = new Padding(4, 3, 4, 3);
			CHARGE.Name = "CHARGE";
			CHARGE.Size = new Size(155, 26);
			CHARGE.TabIndex = 19;
			label32.AutoSize = true;
			label32.BackColor = Color.Transparent;
			label32.ForeColor = SystemColors.ActiveCaption;
			label32.Location = new Point(994, 28);
			label32.Margin = new Padding(4, 0, 4, 0);
			label32.Name = "label32";
			label32.Size = new Size(85, 18);
			label32.TabIndex = 23;
			label32.Text = "Type Vente";
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.ForeColor = SystemColors.ActiveCaption;
			label4.Location = new Point(432, 257);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(82, 18);
			label4.TabIndex = 33;
			label4.Text = "Charge de";
			RESP.Location = new Point(110, 254);
			RESP.Margin = new Padding(4, 3, 4, 3);
			RESP.Name = "RESP";
			RESP.Size = new Size(229, 26);
			RESP.TabIndex = 18;
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.ForeColor = SystemColors.ActiveCaption;
			label9.Location = new Point(8, 257);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(100, 18);
			label9.TabIndex = 31;
			label9.Text = "Responsable";
			TYPVENTE.DisplayMember = "Prix_1";
			TYPVENTE.FormattingEnabled = true;
			TYPVENTE.Items.AddRange(new object[3]
			{
				"Prix_1",
				"Prix_2",
				"Prix_3"
			});
			TYPVENTE.Location = new Point(1089, 23);
			TYPVENTE.Margin = new Padding(4, 3, 4, 3);
			TYPVENTE.Name = "TYPVENTE";
			TYPVENTE.Size = new Size(130, 26);
			TYPVENTE.TabIndex = 27;
			TYPVENTE.Text = "Prix_1";
			GroupBox2.BackColor = Color.Transparent;
			GroupBox2.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox2.Controls.Add(CHARGE);
			GroupBox2.Controls.Add(MAIL);
			GroupBox2.Controls.Add(Label15);
			GroupBox2.Controls.Add(label20);
			GroupBox2.Controls.Add(label4);
			GroupBox2.Controls.Add(FAX2);
			GroupBox2.Controls.Add(RESP);
			GroupBox2.Controls.Add(label9);
			GroupBox2.Controls.Add(GSM3);
			GroupBox2.Controls.Add(label17);
			GroupBox2.Controls.Add(CONTACT3);
			GroupBox2.Controls.Add(label18);
			GroupBox2.Controls.Add(GSM2);
			GroupBox2.Controls.Add(Label13);
			GroupBox2.Controls.Add(CONTACT2);
			GroupBox2.Controls.Add(TEL);
			GroupBox2.Controls.Add(Label14);
			GroupBox2.Controls.Add(label16);
			GroupBox2.Controls.Add(GSM1);
			GroupBox2.Controls.Add(Label11);
			GroupBox2.Controls.Add(CONTACT1);
			GroupBox2.Controls.Add(Label12);
			GroupBox2.Controls.Add(Label5);
			GroupBox2.Controls.Add(GSM);
			GroupBox2.Controls.Add(FAX);
			GroupBox2.Controls.Add(Label10);
			GroupBox2.Controls.Add(CONTACT);
			GroupBox2.Controls.Add(Label6);
			GroupBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox2.Location = new Point(32, 177);
			GroupBox2.Margin = new Padding(4, 3, 4, 3);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Padding = new Padding(4, 3, 4, 3);
			GroupBox2.Size = new Size(710, 288);
			GroupBox2.TabIndex = 43;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Coordonnées";
			MAIL.Location = new Point(110, 25);
			MAIL.Margin = new Padding(4, 3, 4, 3);
			MAIL.Name = "MAIL";
			MAIL.Size = new Size(428, 26);
			MAIL.TabIndex = 6;
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.ForeColor = SystemColors.ActiveCaption;
			Label15.Location = new Point(45, 25);
			Label15.Margin = new Padding(4, 0, 4, 0);
			Label15.Name = "Label15";
			Label15.Size = new Size(37, 18);
			Label15.TabIndex = 27;
			Label15.Text = "Mail";
			label20.AutoSize = true;
			label20.BackColor = Color.Transparent;
			label20.ForeColor = SystemColors.ActiveCaption;
			label20.Location = new Point(467, 62);
			label20.Margin = new Padding(4, 0, 4, 0);
			label20.Name = "label20";
			label20.Size = new Size(43, 18);
			label20.TabIndex = 29;
			label20.Text = "Fax2";
			FAX2.Location = new Point(517, 59);
			FAX2.Margin = new Padding(4, 3, 4, 3);
			FAX2.Name = "FAX2";
			FAX2.Size = new Size(155, 26);
			FAX2.TabIndex = 9;
			GSM3.Location = new Point(517, 216);
			GSM3.Margin = new Padding(4, 3, 4, 3);
			GSM3.Name = "GSM3";
			GSM3.Size = new Size(155, 26);
			GSM3.TabIndex = 17;
			label17.AutoSize = true;
			label17.BackColor = Color.Transparent;
			label17.ForeColor = SystemColors.ActiveCaption;
			label17.Location = new Point(460, 220);
			label17.Margin = new Padding(4, 0, 4, 0);
			label17.Name = "label17";
			label17.Size = new Size(50, 18);
			label17.TabIndex = 29;
			label17.Text = "Gsm3";
			CONTACT3.Location = new Point(110, 217);
			CONTACT3.Margin = new Padding(4, 3, 4, 3);
			CONTACT3.Name = "CONTACT3";
			CONTACT3.Size = new Size(322, 26);
			CONTACT3.TabIndex = 16;
			label18.AutoSize = true;
			label18.BackColor = Color.Transparent;
			label18.ForeColor = SystemColors.ActiveCaption;
			label18.Location = new Point(29, 220);
			label18.Margin = new Padding(4, 0, 4, 0);
			label18.Name = "label18";
			label18.Size = new Size(71, 18);
			label18.TabIndex = 27;
			label18.Text = "Contact3";
			GSM2.Location = new Point(517, 175);
			GSM2.Margin = new Padding(4, 3, 4, 3);
			GSM2.Name = "GSM2";
			GSM2.Size = new Size(155, 26);
			GSM2.TabIndex = 15;
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.ForeColor = SystemColors.ActiveCaption;
			Label13.Location = new Point(464, 178);
			Label13.Margin = new Padding(4, 0, 4, 0);
			Label13.Name = "Label13";
			Label13.Size = new Size(50, 18);
			Label13.TabIndex = 23;
			Label13.Text = "Gsm2";
			CONTACT2.Location = new Point(110, 175);
			CONTACT2.Margin = new Padding(4, 3, 4, 3);
			CONTACT2.Name = "CONTACT2";
			CONTACT2.Size = new Size(322, 26);
			CONTACT2.TabIndex = 14;
			TEL.Location = new Point(110, 59);
			TEL.Margin = new Padding(4, 3, 4, 3);
			TEL.Name = "TEL";
			TEL.Size = new Size(126, 26);
			TEL.TabIndex = 7;
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.ForeColor = SystemColors.ActiveCaption;
			Label14.Location = new Point(31, 178);
			Label14.Margin = new Padding(4, 0, 4, 0);
			Label14.Name = "Label14";
			Label14.Size = new Size(71, 18);
			Label14.TabIndex = 21;
			Label14.Text = "Contact2";
			label16.AutoSize = true;
			label16.BackColor = Color.Transparent;
			label16.ForeColor = SystemColors.ActiveCaption;
			label16.Location = new Point(44, 62);
			label16.Margin = new Padding(4, 0, 4, 0);
			label16.Name = "label16";
			label16.Size = new Size(27, 18);
			label16.TabIndex = 0;
			label16.Text = "Tel";
			GSM1.Location = new Point(517, 136);
			GSM1.Margin = new Padding(4, 3, 4, 3);
			GSM1.Name = "GSM1";
			GSM1.Size = new Size(155, 26);
			GSM1.TabIndex = 13;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.ForeColor = SystemColors.ActiveCaption;
			Label11.Location = new Point(464, 139);
			Label11.Margin = new Padding(4, 0, 4, 0);
			Label11.Name = "Label11";
			Label11.Size = new Size(50, 18);
			Label11.TabIndex = 19;
			Label11.Text = "Gsm1";
			CONTACT1.Location = new Point(110, 136);
			CONTACT1.Margin = new Padding(4, 3, 4, 3);
			CONTACT1.Name = "CONTACT1";
			CONTACT1.Size = new Size(322, 26);
			CONTACT1.TabIndex = 12;
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.ForeColor = SystemColors.ActiveCaption;
			Label12.Location = new Point(29, 136);
			Label12.Margin = new Padding(4, 0, 4, 0);
			Label12.Name = "Label12";
			Label12.Size = new Size(71, 18);
			Label12.TabIndex = 17;
			Label12.Text = "Contact1";
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(261, 62);
			Label5.Margin = new Padding(4, 0, 4, 0);
			Label5.Name = "Label5";
			Label5.Size = new Size(34, 18);
			Label5.TabIndex = 5;
			Label5.Text = "Fax";
			GSM.Location = new Point(517, 95);
			GSM.Margin = new Padding(4, 3, 4, 3);
			GSM.Name = "GSM";
			GSM.Size = new Size(155, 26);
			GSM.TabIndex = 11;
			FAX.Location = new Point(314, 59);
			FAX.Margin = new Padding(4, 3, 4, 3);
			FAX.Name = "FAX";
			FAX.Size = new Size(118, 26);
			FAX.TabIndex = 8;
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.ForeColor = SystemColors.ActiveCaption;
			Label10.Location = new Point(468, 95);
			Label10.Margin = new Padding(4, 0, 4, 0);
			Label10.Name = "Label10";
			Label10.Size = new Size(41, 18);
			Label10.TabIndex = 15;
			Label10.Text = "Gsm";
			CONTACT.Location = new Point(110, 95);
			CONTACT.Margin = new Padding(4, 3, 4, 3);
			CONTACT.Name = "CONTACT";
			CONTACT.Size = new Size(322, 26);
			CONTACT.TabIndex = 10;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(29, 98);
			Label6.Margin = new Padding(4, 0, 4, 0);
			Label6.Name = "Label6";
			Label6.Size = new Size(62, 18);
			Label6.TabIndex = 7;
			Label6.Text = "Contact";
			TYPTVA.DisplayMember = "Assujetti";
			TYPTVA.FormattingEnabled = true;
			TYPTVA.Items.AddRange(new object[3]
			{
				"Assujetti",
				"Non Assujetti",
				"Exonoré"
			});
			TYPTVA.Location = new Point(838, 24);
			TYPTVA.Margin = new Padding(4, 3, 4, 3);
			TYPTVA.Name = "TYPTVA";
			TYPTVA.Size = new Size(148, 26);
			TYPTVA.TabIndex = 26;
			TYPTVA.Text = "Assujetti";
			label30.AutoSize = true;
			label30.BackColor = Color.Transparent;
			label30.ForeColor = SystemColors.ActiveCaption;
			label30.Location = new Point(754, 28);
			label30.Margin = new Padding(4, 0, 4, 0);
			label30.Name = "label30";
			label30.Size = new Size(75, 18);
			label30.TabIndex = 20;
			label30.Text = "Type TVA";
			checkedListBox1.BackColor = Color.FromArgb(128, 128, 255);
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[3]
			{
				"Non Autorisé",
				"Autorisé",
				"Comptant"
			});
			checkedListBox1.Location = new Point(24, 47);
			checkedListBox1.Margin = new Padding(4, 3, 4, 3);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(134, 67);
			checkedListBox1.TabIndex = 60;
			MONT.Location = new Point(98, 157);
			MONT.Margin = new Padding(4, 3, 4, 3);
			MONT.Name = "MONT";
			MONT.Size = new Size(120, 26);
			MONT.TabIndex = 40;
			groupBox3.BackColor = Color.Transparent;
			groupBox3.Controls.Add(MONT);
			groupBox3.Controls.Add(checkedListBox1);
			groupBox3.Controls.Add(label25);
			groupBox3.Controls.Add(COTION);
			groupBox3.Controls.Add(label28);
			groupBox3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			groupBox3.Location = new Point(752, 225);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(396, 240);
			groupBox3.TabIndex = 48;
			groupBox3.TabStop = false;
			label25.AutoSize = true;
			label25.BackColor = Color.Transparent;
			label25.ForeColor = SystemColors.ActiveCaption;
			label25.Location = new Point(29, 157);
			label25.Margin = new Padding(4, 0, 4, 0);
			label25.Name = "label25";
			label25.Size = new Size(63, 18);
			label25.TabIndex = 35;
			label25.Text = "Montant";
			COTION.Location = new Point(98, 194);
			COTION.Margin = new Padding(4, 3, 4, 3);
			COTION.Name = "COTION";
			COTION.Size = new Size(120, 26);
			COTION.TabIndex = 41;
			label28.AutoSize = true;
			label28.BackColor = Color.Transparent;
			label28.ForeColor = SystemColors.ActiveCaption;
			label28.Location = new Point(25, 198);
			label28.Margin = new Padding(4, 0, 4, 0);
			label28.Name = "label28";
			label28.Size = new Size(54, 18);
			label28.TabIndex = 33;
			label28.Text = "Cotion";
			GroupBox4.BackColor = Color.Transparent;
			GroupBox4.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox4.Controls.Add(Label34);
			GroupBox4.Controls.Add(Label33);
			GroupBox4.Controls.Add(label32);
			GroupBox4.Controls.Add(TYPVENTE);
			GroupBox4.Controls.Add(TYPTVA);
			GroupBox4.Controls.Add(label30);
			GroupBox4.Controls.Add(MODEREGL);
			GroupBox4.Controls.Add(Label19);
			GroupBox4.Controls.Add(LIBFAM);
			GroupBox4.Controls.Add(Label23);
			GroupBox4.Controls.Add(ECHEANCE);
			GroupBox4.Controls.Add(Label24);
			GroupBox4.Controls.Add(FAMCLI);
			GroupBox4.Controls.Add(Label26);
			GroupBox4.Controls.Add(REMISE);
			GroupBox4.Controls.Add(Label27);
			GroupBox4.Controls.Add(CODETVA);
			GroupBox4.Controls.Add(Label8);
			GroupBox4.Controls.Add(Label7);
			GroupBox4.Controls.Add(TIMBRE);
			GroupBox4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox4.Location = new Point(32, 471);
			GroupBox4.Margin = new Padding(4, 3, 4, 3);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Padding = new Padding(4, 3, 4, 3);
			GroupBox4.Size = new Size(1223, 102);
			GroupBox4.TabIndex = 44;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Divers";
			Label34.Location = new Point(520, 27);
			Label34.Name = "Label34";
			Label34.Size = new Size(24, 21);
			Label34.TabIndex = 33;
			Label34.Text = "%";
			Label33.Location = new Point(321, 24);
			Label33.Name = "Label33";
			Label33.Size = new Size(35, 21);
			Label33.TabIndex = 32;
			Label33.Text = "DT";
			MODEREGL.DisplayMember = "Espèce";
			MODEREGL.FormattingEnabled = true;
			MODEREGL.Items.AddRange(new object[4]
			{
				"Espèce",
				"Traite",
				"Chèque",
				"Virement"
			});
			MODEREGL.Location = new Point(630, 24);
			MODEREGL.Margin = new Padding(4, 3, 4, 3);
			MODEREGL.Name = "MODEREGL";
			MODEREGL.Size = new Size(103, 26);
			MODEREGL.TabIndex = 25;
			MODEREGL.Text = "Espèce";
			Label19.AutoSize = true;
			Label19.BackColor = Color.Transparent;
			Label19.ForeColor = SystemColors.ActiveCaption;
			Label19.Location = new Point(551, 27);
			Label19.Margin = new Padding(4, 0, 4, 0);
			Label19.Name = "Label19";
			Label19.Size = new Size(71, 18);
			Label19.TabIndex = 18;
			Label19.Text = "Modereg";
			LIBFAM.Location = new Point(296, 60);
			LIBFAM.Margin = new Padding(4, 3, 4, 3);
			LIBFAM.Name = "LIBFAM";
			LIBFAM.Size = new Size(455, 26);
			LIBFAM.TabIndex = 29;
			Label23.AutoSize = true;
			Label23.BackColor = Color.Transparent;
			Label23.ForeColor = SystemColors.ActiveCaption;
			Label23.Location = new Point(877, 60);
			Label23.Margin = new Padding(4, 0, 4, 0);
			Label23.Name = "Label23";
			Label23.Size = new Size(78, 18);
			Label23.TabIndex = 9;
			Label23.Text = "Echeance";
			ECHEANCE.Location = new Point(967, 57);
			ECHEANCE.Margin = new Padding(4, 3, 4, 3);
			ECHEANCE.Name = "ECHEANCE";
			ECHEANCE.Size = new Size(221, 26);
			ECHEANCE.TabIndex = 30;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.ForeColor = SystemColors.ActiveCaption;
			Label24.Location = new Point(190, 61);
			Label24.Margin = new Padding(4, 0, 4, 0);
			Label24.Name = "Label24";
			Label24.Size = new Size(103, 18);
			Label24.TabIndex = 7;
			Label24.Text = "Libelle famille";
			FAMCLI.Location = new Point(86, 61);
			FAMCLI.Margin = new Padding(4, 3, 4, 3);
			FAMCLI.Name = "FAMCLI";
			FAMCLI.Size = new Size(99, 26);
			FAMCLI.TabIndex = 28;
			Label26.AutoSize = true;
			Label26.BackColor = Color.Transparent;
			Label26.ForeColor = SystemColors.ActiveCaption;
			Label26.Location = new Point(12, 65);
			Label26.Margin = new Padding(4, 0, 4, 0);
			Label26.Name = "Label26";
			Label26.Size = new Size(59, 18);
			Label26.TabIndex = 3;
			Label26.Text = "Famille";
			REMISE.Location = new Point(448, 24);
			REMISE.Margin = new Padding(4, 3, 4, 3);
			REMISE.Name = "REMISE";
			REMISE.Size = new Size(70, 26);
			REMISE.TabIndex = 24;
			Label27.AutoSize = true;
			Label27.BackColor = Color.Transparent;
			Label27.ForeColor = SystemColors.ActiveCaption;
			Label27.Location = new Point(388, 27);
			Label27.Margin = new Padding(4, 0, 4, 0);
			Label27.Name = "Label27";
			Label27.Size = new Size(62, 18);
			Label27.TabIndex = 0;
			Label27.Text = "Remise";
			CODETVA.Location = new Point(88, 24);
			CODETVA.Margin = new Padding(4, 3, 4, 3);
			CODETVA.Name = "CODETVA";
			CODETVA.Size = new Size(102, 26);
			CODETVA.TabIndex = 22;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.ForeColor = SystemColors.ActiveCaption;
			Label8.Location = new Point(4, 31);
			Label8.Margin = new Padding(4, 0, 4, 0);
			Label8.Name = "Label8";
			Label8.Size = new Size(81, 18);
			Label8.TabIndex = 11;
			Label8.Text = "Code TVA";
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.ForeColor = SystemColors.ActiveCaption;
			Label7.Location = new Point(204, 27);
			Label7.Margin = new Padding(4, 0, 4, 0);
			Label7.Name = "Label7";
			Label7.Size = new Size(56, 18);
			Label7.TabIndex = 13;
			Label7.Text = "Timbre";
			TIMBRE.Location = new Point(262, 22);
			TIMBRE.Margin = new Padding(4, 3, 4, 3);
			TIMBRE.Name = "TIMBRE";
			TIMBRE.Size = new Size(52, 26);
			TIMBRE.TabIndex = 23;
			Région.Location = new Point(680, 68);
			Région.Margin = new Padding(4, 3, 4, 3);
			Région.Name = "Région";
			Région.Size = new Size(120, 26);
			Région.TabIndex = 5;
			Label100.AutoSize = true;
			Label100.BackColor = Color.Transparent;
			Label100.ForeColor = SystemColors.ActiveCaption;
			Label100.Location = new Point(617, 72);
			Label100.Margin = new Padding(4, 0, 4, 0);
			Label100.Name = "Label100";
			Label100.Size = new Size(58, 18);
			Label100.TabIndex = 14;
			Label100.Text = "Région";
			B_rechercher.BackColor = Color.White;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.ForeColor = SystemColors.ActiveCaptionText;
			B_rechercher.Image = Resources.Actions_document_find_icon1;
			B_rechercher.ImageAlign = ContentAlignment.MiddleLeft;
			B_rechercher.Location = new Point(806, 16);
			B_rechercher.Margin = new Padding(4, 3, 4, 3);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(132, 43);
			B_rechercher.TabIndex = 52;
			B_rechercher.TabStop = false;
			B_rechercher.Text = "     Rechercher";
			B_rechercher.TextAlign = ContentAlignment.MiddleRight;
			B_rechercher.UseVisualStyleBackColor = false;
			IDCLIENT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			IDCLIENT.AutoCompleteSource = AutoCompleteSource.ListItems;
			IDCLIENT.FormattingEnabled = true;
			IDCLIENT.Location = new Point(70, 25);
			IDCLIENT.Margin = new Padding(4, 3, 4, 3);
			IDCLIENT.Name = "IDCLIENT";
			IDCLIENT.Size = new Size(282, 26);
			IDCLIENT.TabIndex = 1;
			VILLE.Location = new Point(485, 68);
			VILLE.Margin = new Padding(4, 3, 4, 3);
			VILLE.Name = "VILLE";
			VILLE.Size = new Size(128, 26);
			VILLE.TabIndex = 4;
			Label29.AutoSize = true;
			Label29.BackColor = Color.Transparent;
			Label29.ForeColor = SystemColors.ActiveCaption;
			Label29.Location = new Point(446, 72);
			Label29.Margin = new Padding(4, 0, 4, 0);
			Label29.Name = "Label29";
			Label29.Size = new Size(38, 18);
			Label29.TabIndex = 7;
			Label29.Text = "Ville";
			ADRESSE.Location = new Point(70, 68);
			ADRESSE.Margin = new Padding(4, 3, 4, 3);
			ADRESSE.Name = "ADRESSE";
			ADRESSE.Size = new Size(368, 26);
			ADRESSE.TabIndex = 3;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(Nom);
			GroupBox1.Controls.Add(Button11);
			GroupBox1.Controls.Add(Région);
			GroupBox1.Controls.Add(Label100);
			GroupBox1.Controls.Add(IDCLIENT);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(VILLE);
			GroupBox1.Controls.Add(Label29);
			GroupBox1.Controls.Add(ADRESSE);
			GroupBox1.Controls.Add(Label22);
			GroupBox1.Controls.Add(label3);
			GroupBox1.Controls.Add(label2);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(32, 66);
			GroupBox1.Margin = new Padding(4, 3, 4, 3);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(4, 3, 4, 3);
			GroupBox1.Size = new Size(955, 105);
			GroupBox1.TabIndex = 0;
			GroupBox1.TabStop = false;
			Nom.Location = new Point(485, 26);
			Nom.Margin = new Padding(4, 3, 4, 3);
			Nom.Name = "Nom";
			Nom.Size = new Size(315, 26);
			Nom.TabIndex = 53;
			Button11.BackColor = Color.White;
			Button11.Cursor = Cursors.Hand;
			Button11.Location = new Point(324, 23);
			Button11.Name = "Button11";
			Button11.Size = new Size(33, 28);
			Button11.TabIndex = 51;
			Button11.TabStop = false;
			Button11.Text = "...";
			Button11.UseVisualStyleBackColor = false;
			Label22.AutoSize = true;
			Label22.BackColor = Color.Transparent;
			Label22.ForeColor = SystemColors.ActiveCaption;
			Label22.Location = new Point(5, 72);
			Label22.Margin = new Padding(4, 0, 4, 0);
			Label22.Name = "Label22";
			Label22.Size = new Size(67, 18);
			Label22.TabIndex = 5;
			Label22.Text = "Adresse";
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.ForeColor = SystemColors.ActiveCaption;
			label3.Location = new Point(373, 26);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(111, 18);
			label3.TabIndex = 3;
			label3.Text = "Raison sociale";
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(19, 26);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(47, 18);
			label2.TabIndex = 0;
			label2.Text = "Code";
			groupBox6.BackColor = Color.Transparent;
			groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
			groupBox6.Controls.Add(btnDelete);
			groupBox6.Controls.Add(b_imprimer);
			groupBox6.Controls.Add(b_enregistrer);
			groupBox6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			groupBox6.Location = new Point(32, 579);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(938, 100);
			groupBox6.TabIndex = 47;
			groupBox6.TabStop = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(346, 35);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(168, 43);
			btnDelete.TabIndex = 34;
			btnDelete.Text = "Supprimer Client";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			b_imprimer.BackColor = Color.White;
			b_imprimer.BackgroundImage = (Image)componentResourceManager.GetObject("b_imprimer.BackgroundImage");
			b_imprimer.Cursor = Cursors.Hand;
			b_imprimer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_imprimer.ForeColor = SystemColors.ActiveCaptionText;
			b_imprimer.Image = Resources.print_icon;
			b_imprimer.ImageAlign = ContentAlignment.MiddleLeft;
			b_imprimer.Location = new Point(599, 35);
			b_imprimer.Name = "b_imprimer";
			b_imprimer.Size = new Size(125, 43);
			b_imprimer.TabIndex = 33;
			b_imprimer.Text = "Imprimer";
			b_imprimer.TextAlign = ContentAlignment.MiddleRight;
			b_imprimer.UseVisualStyleBackColor = false;
			b_enregistrer.BackColor = Color.White;
			b_enregistrer.Cursor = Cursors.Hand;
			b_enregistrer.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
			b_enregistrer.Image = Resources.Save_icon;
			b_enregistrer.ImageAlign = ContentAlignment.MiddleLeft;
			b_enregistrer.Location = new Point(123, 35);
			b_enregistrer.Name = "b_enregistrer";
			b_enregistrer.Size = new Size(137, 44);
			b_enregistrer.TabIndex = 32;
			b_enregistrer.Text = "     Enregistrer";
			b_enregistrer.TextAlign = ContentAlignment.MiddleRight;
			b_enregistrer.UseVisualStyleBackColor = false;
			Button23.BackgroundImage = (Image)componentResourceManager.GetObject("Button23.BackgroundImage");
			Button23.Location = new Point(1042, 82);
			Button23.Margin = new Padding(3, 4, 3, 4);
			Button23.Name = "Button23";
			Button23.Size = new Size(86, 74);
			Button23.TabIndex = 50;
			Button23.TabStop = false;
			Button23.UseVisualStyleBackColor = true;
			Label21.AutoSize = true;
			Label21.BackColor = Color.Transparent;
			Label21.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label21.Location = new Point(1027, 160);
			Label21.Name = "Label21";
			Label21.Size = new Size(113, 16);
			Label21.TabIndex = 49;
			Label21.Text = "Historique Client";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Button23);
			base.Controls.Add(Label21);
			base.Controls.Add(groupBox6);
			base.Controls.Add(GroupBox2);
			base.Controls.Add(groupBox3);
			base.Controls.Add(GroupBox4);
			base.Controls.Add(GroupBox1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(4, 6, 4, 6);
			base.Name = "Gestion_Client";
			Text = "Gestion Client";
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(GroupBox4, 0);
			base.Controls.SetChildIndex(groupBox3, 0);
			base.Controls.SetChildIndex(GroupBox2, 0);
			base.Controls.SetChildIndex(groupBox6, 0);
			base.Controls.SetChildIndex(Label21, 0);
			base.Controls.SetChildIndex(Button23, 0);
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			groupBox6.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Gestion_Client_Load(object sender, EventArgs e)
		{
			base.KeyPreview = true;
			base.KeyUp += KeyUpHandler;
			checked
			{
				try
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT ";
					mySqlDataAdapter.Fill(dataSet, "list");
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

		private void IDCLIENT_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from CLIENT where IDCLIENT ='" + IDCLIENT.Text + "'";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					Nom.Text = mySqlDataReader["NOM"].ToString();
					ADRESSE.Text = mySqlDataReader["ADRESSE"].ToString();
					VILLE.Text = mySqlDataReader["VILLE"].ToString();
					Région.Text = mySqlDataReader["Region"].ToString();
					TEL.Text = mySqlDataReader["TEL1"].ToString();
					FAX.Text = mySqlDataReader["FAX"].ToString();
					FAX2.Text = mySqlDataReader["FAX2"].ToString();
					CONTACT1.Text = mySqlDataReader["CONTACT1"].ToString();
					GSM1.Text = mySqlDataReader["GSM1"].ToString();
					CONTACT2.Text = mySqlDataReader["CONTACT2"].ToString();
					GSM2.Text = mySqlDataReader["GSM2"].ToString();
					CONTACT3.Text = mySqlDataReader["CONTACT3"].ToString();
					GSM3.Text = mySqlDataReader["GSM3"].ToString();
					MAIL.Text = mySqlDataReader["MAIL"].ToString();
					FAMCLI.Text = mySqlDataReader["FAMCLI"].ToString();
					LIBFAM.Text = mySqlDataReader["LIBFAM"].ToString();
					CODETVA.Text = mySqlDataReader["CODETVA"].ToString();
					TYPTVA.Text = mySqlDataReader["TYPTVA"].ToString();
					REMISE.Text = mySqlDataReader["REM"].ToString();
					ECHEANCE.Text = mySqlDataReader["ECHEANCE"].ToString();
					MODEREGL.Text = mySqlDataReader["MODEREGL"].ToString();
					TIMBRE.Text = mySqlDataReader["TIMBRE"].ToString();
					CONTACT.Text = mySqlDataReader["CONTACT"].ToString();
					GSM.Text = mySqlDataReader["GSM"].ToString();
					CHARGE.Text = mySqlDataReader["CHARGE"].ToString();
					RESP.Text = mySqlDataReader["RESP"].ToString();
					ECHEANCE.Text = mySqlDataReader["ECHEANCE"].ToString();
					TYPVENTE.Text = mySqlDataReader["TYPVENTE"].ToString();
					MONT.Text = mySqlDataReader["MONT"].ToString();
				}
				Nom.Focus();
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
				Globals.ClearTextBox(this);
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from CLIENT where IDCLIENT ='" + IDCLIENT.Text + "'";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					Nom.Text = mySqlDataReader["NOM"].ToString();
					ADRESSE.Text = mySqlDataReader["ADRESSE"].ToString();
					VILLE.Text = mySqlDataReader["VILLE"].ToString();
					Région.Text = mySqlDataReader["Region"].ToString();
					TEL.Text = mySqlDataReader["TEL1"].ToString();
					FAX.Text = mySqlDataReader["FAX"].ToString();
					FAX2.Text = mySqlDataReader["FAX2"].ToString();
					CONTACT1.Text = mySqlDataReader["CONTACT1"].ToString();
					GSM1.Text = mySqlDataReader["GSM1"].ToString();
					CONTACT2.Text = mySqlDataReader["CONTACT2"].ToString();
					GSM2.Text = mySqlDataReader["GSM2"].ToString();
					CONTACT3.Text = mySqlDataReader["CONTACT3"].ToString();
					GSM3.Text = mySqlDataReader["GSM3"].ToString();
					MAIL.Text = mySqlDataReader["MAIL"].ToString();
					FAMCLI.Text = mySqlDataReader["FAMCLI"].ToString();
					LIBFAM.Text = mySqlDataReader["LIBFAM"].ToString();
					CODETVA.Text = mySqlDataReader["CODETVA"].ToString();
					TYPTVA.Text = mySqlDataReader["TYPTVA"].ToString();
					REMISE.Text = mySqlDataReader["REM"].ToString();
					ECHEANCE.Text = mySqlDataReader["ECHEANCE"].ToString();
					MODEREGL.Text = mySqlDataReader["MODEREGL"].ToString();
					TIMBRE.Text = mySqlDataReader["TIMBRE"].ToString();
					CONTACT.Text = mySqlDataReader["CONTACT"].ToString();
					GSM.Text = mySqlDataReader["GSM"].ToString();
					CHARGE.Text = mySqlDataReader["CHARGE"].ToString();
					RESP.Text = mySqlDataReader["RESP"].ToString();
					ECHEANCE.Text = mySqlDataReader["ECHEANCE"].ToString();
					TYPVENTE.Text = mySqlDataReader["TYPVENTE"].ToString();
					MONT.Text = mySqlDataReader["MONT"].ToString();
				}
				else
				{
					MessageBox.Show("ARTICLE not found");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				Globals.conn.Close();
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

		private void b_enregistrer_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				if ((Operators.CompareString(REMISE.Text, "", false) != 0 & Operators.CompareString(TIMBRE.Text, "", false) != 0) && checked(Globals.controlNum(REMISE.Text) + Globals.controlNum(TIMBRE.Text)) > 0)
				{
					MessageBox.Show("Merci de bien saisir un nombre valide !");
				}
				else
				{
					string text = Strings.Replace(REMISE.Text, ",", ".", 1, -1, CompareMethod.Binary);
					string text2 = Strings.Replace(TIMBRE.Text, ",", ".", 1, -1, CompareMethod.Binary);
					if (Operators.CompareString(NewClient, "Oui", false) == 0)
					{
						string query = "INSERT INTO CLIENT(IDCLIENT, Nom, ADRESSE, VILLE, Region, TEL1, FAX, FAX2, CONTACT1, GSM1, CONTACT2, GSM2, CONTACT3, GSM3, MAIL, FAMCLI, LIBFAM, CODETVA, TYPTVA, REM, ECHEANCE, MODEREGL, TIMBRE, CONTACT, GSM, CHARGE, RESP, TYPVENTE, MONT)VALUES('" + IDCLIENT.Text + "', '" + Nom.Text + "', '" + ADRESSE.Text + "', '" + VILLE.Text + "', '" + Région.Text + "', '" + TEL.Text + "','" + FAX.Text + "', '" + FAX2.Text + "', '" + CONTACT1.Text + "', '" + GSM1.Text + "', '" + CONTACT2.Text + "', '" + GSM2.Text + "', '" + CONTACT3.Text + "', '" + GSM3.Text + "', '" + MAIL.Text + "', '" + FAMCLI.Text + "', '" + LIBFAM.Text + "', '" + CODETVA.Text + "', '" + TYPTVA.Text + "', '" + text + "', '" + ECHEANCE.Text + "', '" + MODEREGL.Text + "', '" + text2 + "', '" + CONTACT.Text + "', '" + GSM.Text + "', '" + CHARGE.Text + "', '" + RESP.Text + "', '" + TYPVENTE.Text + "', '" + MONT.Text + "')";
						Globals.ExecuteInsertQuery(query);
						MessageBox.Show("Client Ajouté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						Gestion_Client_Load(RuntimeHelpers.GetObjectValue(sender), e);
						IDCLIENT.Focus();
						NewClient = "Non";
					}
					else
					{
						string query2 = "Update CLIENT set Nom='" + Nom.Text + "', ADRESSE='" + ADRESSE.Text + "', VILLE='" + VILLE.Text + "', Region='" + Région.Text + "', TEL1='" + TEL.Text + "', FAX='" + FAX.Text + "', FAX2='" + FAX2.Text + "', CONTACT1='" + CONTACT1.Text + "', GSM1='" + GSM1.Text + "', CONTACT2='" + CONTACT2.Text + "', GSM2='" + GSM2.Text + "', CONTACT3='" + CONTACT3.Text + "', GSM3='" + GSM3.Text + "', MAIL='" + MAIL.Text + "', FAMCLI='" + FAMCLI.Text + "', LIBFAM='" + LIBFAM.Text + "', CODETVA='" + CODETVA.Text + "', TYPTVA='" + TYPTVA.Text + "', REM='" + text + "', ECHEANCE='" + ECHEANCE.Text + "', MODEREGL='" + MODEREGL.Text + "', TIMBRE='" + text2 + "', CONTACT='" + CONTACT.Text + "', GSM='" + GSM.Text + "', CHARGE='" + CHARGE.Text + "', RESP='" + RESP.Text + "', TYPVENTE='" + TYPVENTE.Text + "', MONT='" + MONT.Text + "' where IDCLIENT = '" + IDCLIENT.Text + "'";
						Globals.ExecuteUpdateQuery(query2);
						MessageBox.Show("Modification Apporté");
						Globals.ClearTextBox(this);
						Globals.ClearComboBox(this);
						IDCLIENT.Focus();
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

		public void IDCLIENT_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT where IDCLIENT = '" + IDCLIENT.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				IDCLIENT.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					IDCLIENT_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					if (Operators.CompareString(IDCLIENT.Text, "", false) != 0)
					{
						DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir ajouter un Client?", "Ajout Client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
						if (dialogResult == DialogResult.No)
						{
							base.Close();
							IDCLIENT.Text = "";
							Nom.Text = "";
							MODEREGL.Text = "";
							TYPTVA.Text = "";
							TYPVENTE.Text = "";
							Globals.ClearTextBox(this);
						}
						else
						{
							Globals.ClearTextBox(this);
							Nom.Text = "";
							MODEREGL.Text = "";
							TYPTVA.Text = "";
							TYPVENTE.Text = "";
							NewClient = "Oui";
							Nom.Focus();
						}
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

		private void Button23_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Client.Show();
			MyProject.Forms.Histo_Client.BringToFront();
			MyProject.Forms.Histo_Client.IDCLIENT.Text = IDCLIENT.Text;
			MyProject.Forms.Histo_Client.B_rechercher_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void KeyUpHandler(object o, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
			if (e.KeyCode == Keys.F9)
			{
				Button11_Click(1, e);
			}
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
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

		private void b_imprimer_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Accueil.ImprimerToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_list_Click(object sender, EventArgs e)
		{
			Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void b_enregistrer_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir enregistrer?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				b_enregistrer_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT ";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				IDCLIENT.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						IDCLIENT.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cet client?", "Suppression Client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM CLIENT WHERE IDCLIENT='" + IDCLIENT.Text + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					MessageBox.Show("Client supprimé");
					Globals.ClearTextBox(this);
					Globals.ClearComboBox(this);
					IDCLIENT.Focus();
					Gestion_Client_Load(e, e);
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
