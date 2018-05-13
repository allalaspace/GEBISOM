using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class info_perso : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Ville")]
		private TextBox _Ville;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Gouvernorat")]
		private TextBox _Gouvernorat;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nationalite")]
		private TextBox _Nationalite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nom")]
		private TextBox _Nom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Num_ci")]
		private TextBox _Num_ci;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Prenom")]
		private TextBox _Prenom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Sexe")]
		private ComboBox _Sexe;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_nais")]
		private TextBox _Date_nais;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tel1")]
		private TextBox _tel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("code_postal")]
		private TextBox _code_postal;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("adresse")]
		private TextBox _adresse;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tel2")]
		private TextBox _tel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("mail2")]
		private TextBox _mail2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("mail1")]
		private TextBox _mail1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("statut_soc")]
		private ComboBox _statut_soc;

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
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("type_activite")]
		private TextBox _type_activite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("permis_voiture")]
		private ComboBox _permis_voiture;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("formation")]
		private TextBox _formation;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv_scolaire")]
		private TextBox _niv_scolaire;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("societe")]
		private TextBox _societe;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("profession")]
		private TextBox _profession;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv1")]
		private ComboBox _niv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang1")]
		private ComboBox _lang1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("activite_prefere")]
		private TextBox _activite_prefere;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("competence")]
		private TextBox _competence;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("activite_prec")]
		private TextBox _activite_prec;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("temps_libre")]
		private TextBox _temps_libre;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("plus_A_donner")]
		private TextBox _plus_A_donner;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("remarque")]
		private TextBox _remarque;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("twitter")]
		private TextBox _twitter;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("skype")]
		private TextBox _skype;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("facebook")]
		private TextBox _facebook;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("statut")]
		private ComboBox _statut;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_inscri")]
		private TextBox _Date_inscri;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv3")]
		private ComboBox _niv3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv6")]
		private ComboBox _niv6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv4")]
		private ComboBox _niv4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv2")]
		private ComboBox _niv2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("niv5")]
		private ComboBox _niv5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang5")]
		private ComboBox _lang5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang4")]
		private ComboBox _lang4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang3")]
		private ComboBox _lang3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang6")]
		private ComboBox _lang6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lang2")]
		private ComboBox _lang2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tel3")]
		private TextBox _tel3;

		public string COD;

		public string CODLANG;

		internal virtual Button btnNew
		{
			[CompilerGenerated]
			get
			{
				return _btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNew_Click;
				Button btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click -= value2;
				}
				_btnNew = value;
				btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click += value2;
				}
			}
		}

		internal virtual Label Label9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Ville
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

		internal virtual TextBox Gouvernorat
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

		internal virtual TextBox Nationalite
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

		internal virtual TextBox Nom
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

		internal virtual Label Label3
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

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Num_ci
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Prenom
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox Sexe
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Date_nais
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

		internal virtual TextBox tel1
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

		internal virtual TextBox code_postal
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

		internal virtual TextBox adresse
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

		internal virtual TextBox tel2
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

		internal virtual Label Label17
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox mail2
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

		internal virtual TextBox mail1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox statut_soc
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

		internal virtual Label Label22
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox type_activite
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox permis_voiture
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

		internal virtual TextBox formation
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

		internal virtual TextBox niv_scolaire
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

		internal virtual TextBox societe
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

		internal virtual TextBox profession
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

		internal virtual ComboBox niv1
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

		internal virtual Label Label38
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

		internal virtual Label Label36
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

		internal virtual Label Label34
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

		internal virtual Label Label32
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

		internal virtual Label Label30
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label28
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

		internal virtual Label Label41
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox activite_prefere
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label42
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox competence
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label39
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox activite_prec
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label40
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox temps_libre
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label43
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox plus_A_donner
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label44
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox remarque
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label45
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox twitter
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label46
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox skype
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label47
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox facebook
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox statut
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label48
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label49
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Date_inscri
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox niv3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox niv6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox niv4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox niv2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox niv5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox lang2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox tel3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public info_perso()
		{
			base.Load += info_perso_Load;
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
			btnNew = new Button();
			Label9 = new Label();
			Ville = new TextBox();
			Label8 = new Label();
			Gouvernorat = new TextBox();
			Label6 = new Label();
			Nationalite = new TextBox();
			Label5 = new Label();
			Nom = new TextBox();
			Label4 = new Label();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			Num_ci = new TextBox();
			Prenom = new TextBox();
			Sexe = new ComboBox();
			Date_nais = new TextBox();
			Label15 = new Label();
			tel1 = new TextBox();
			Label16 = new Label();
			code_postal = new TextBox();
			Label18 = new Label();
			adresse = new TextBox();
			Label13 = new Label();
			tel2 = new TextBox();
			Label14 = new Label();
			Label17 = new Label();
			mail2 = new TextBox();
			Label19 = new Label();
			mail1 = new TextBox();
			statut_soc = new ComboBox();
			Label20 = new Label();
			Label21 = new Label();
			Label22 = new Label();
			type_activite = new TextBox();
			permis_voiture = new ComboBox();
			Label24 = new Label();
			formation = new TextBox();
			Label25 = new Label();
			niv_scolaire = new TextBox();
			Label26 = new Label();
			societe = new TextBox();
			Label27 = new Label();
			profession = new TextBox();
			GroupBox1 = new GroupBox();
			niv3 = new ComboBox();
			niv6 = new ComboBox();
			niv4 = new ComboBox();
			niv2 = new ComboBox();
			niv5 = new ComboBox();
			lang5 = new ComboBox();
			lang4 = new ComboBox();
			lang3 = new ComboBox();
			lang6 = new ComboBox();
			lang2 = new ComboBox();
			niv1 = new ComboBox();
			Label37 = new Label();
			Label38 = new Label();
			Label35 = new Label();
			Label36 = new Label();
			Label33 = new Label();
			Label34 = new Label();
			Label31 = new Label();
			Label32 = new Label();
			Label29 = new Label();
			Label30 = new Label();
			lang1 = new ComboBox();
			Label28 = new Label();
			Label23 = new Label();
			Label41 = new Label();
			activite_prefere = new TextBox();
			Label42 = new Label();
			competence = new TextBox();
			Label39 = new Label();
			activite_prec = new TextBox();
			Label40 = new Label();
			temps_libre = new TextBox();
			Label43 = new Label();
			plus_A_donner = new TextBox();
			Label44 = new Label();
			remarque = new TextBox();
			Label45 = new Label();
			twitter = new TextBox();
			Label46 = new Label();
			skype = new TextBox();
			Label47 = new Label();
			facebook = new TextBox();
			statut = new ComboBox();
			Label48 = new Label();
			Label49 = new Label();
			Date_inscri = new TextBox();
			tel3 = new TextBox();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			btnNew.BackColor = Color.White;
			btnNew.Cursor = Cursors.Hand;
			btnNew.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNew.Image = Resources.Save_icon;
			btnNew.ImageAlign = ContentAlignment.MiddleLeft;
			btnNew.Location = new Point(1114, 273);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(97, 46);
			btnNew.TabIndex = 50;
			btnNew.Text = "Ajouter";
			btnNew.TextAlign = ContentAlignment.MiddleRight;
			btnNew.UseVisualStyleBackColor = false;
			Label9.AutoSize = true;
			Label9.Location = new Point(778, 122);
			Label9.Name = "Label9";
			Label9.Size = new Size(31, 15);
			Label9.TabIndex = 53;
			Label9.Text = "Ville";
			Ville.Location = new Point(816, 118);
			Ville.Name = "Ville";
			Ville.Size = new Size(92, 21);
			Ville.TabIndex = 9;
			Label8.AutoSize = true;
			Label8.BackColor = Color.Transparent;
			Label8.Location = new Point(80, 164);
			Label8.Name = "Label8";
			Label8.Size = new Size(77, 15);
			Label8.TabIndex = 51;
			Label8.Text = "Gouvernorat";
			Gouvernorat.Location = new Point(164, 158);
			Gouvernorat.Name = "Gouvernorat";
			Gouvernorat.Size = new Size(92, 21);
			Gouvernorat.TabIndex = 10;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.Location = new Point(90, 122);
			Label6.Name = "Label6";
			Label6.Size = new Size(67, 15);
			Label6.TabIndex = 47;
			Label6.Text = "Nationalité";
			Nationalite.Location = new Point(162, 118);
			Nationalite.Name = "Nationalite";
			Nationalite.Size = new Size(96, 21);
			Nationalite.TabIndex = 6;
			Label5.AutoSize = true;
			Label5.Location = new Point(825, 74);
			Label5.Name = "Label5";
			Label5.Size = new Size(88, 15);
			Label5.TabIndex = 45;
			Label5.Text = "Date naissnce";
			Nom.Location = new Point(161, 72);
			Nom.Name = "Nom";
			Nom.Size = new Size(98, 21);
			Nom.TabIndex = 1;
			Label4.AutoSize = true;
			Label4.Location = new Point(600, 74);
			Label4.Name = "Label4";
			Label4.Size = new Size(111, 15);
			Label4.TabIndex = 42;
			Label4.Text = "Num carte identité";
			Label3.AutoSize = true;
			Label3.Location = new Point(448, 74);
			Label3.Name = "Label3";
			Label3.Size = new Size(36, 15);
			Label3.TabIndex = 41;
			Label3.Text = "Sexe";
			Label2.AutoSize = true;
			Label2.Location = new Point(264, 74);
			Label2.Name = "Label2";
			Label2.Size = new Size(55, 15);
			Label2.TabIndex = 40;
			Label2.Text = " Prénom";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Location = new Point(111, 74);
			Label1.Name = "Label1";
			Label1.Size = new Size(33, 15);
			Label1.TabIndex = 39;
			Label1.Text = "Nom";
			Num_ci.Location = new Point(724, 72);
			Num_ci.Name = "Num_ci";
			Num_ci.Size = new Size(96, 21);
			Num_ci.TabIndex = 4;
			Prenom.Location = new Point(325, 72);
			Prenom.Name = "Prenom";
			Prenom.Size = new Size(106, 21);
			Prenom.TabIndex = 2;
			Sexe.FormattingEnabled = true;
			Sexe.Items.AddRange(new object[2]
			{
				"Male",
				"Femelle"
			});
			Sexe.Location = new Point(489, 70);
			Sexe.Name = "Sexe";
			Sexe.Size = new Size(91, 23);
			Sexe.TabIndex = 3;
			Date_nais.Location = new Point(920, 72);
			Date_nais.Name = "Date_nais";
			Date_nais.Size = new Size(108, 21);
			Date_nais.TabIndex = 5;
			Label15.AutoSize = true;
			Label15.Location = new Point(267, 165);
			Label15.Name = "Label15";
			Label15.Size = new Size(73, 15);
			Label15.TabIndex = 70;
			Label15.Text = "Téléphone1";
			tel1.Location = new Point(348, 161);
			tel1.Name = "tel1";
			tel1.Size = new Size(75, 21);
			tel1.TabIndex = 11;
			Label16.AutoSize = true;
			Label16.Location = new Point(595, 118);
			Label16.Name = "Label16";
			Label16.Size = new Size(82, 15);
			Label16.TabIndex = 68;
			Label16.Text = "Code Postale";
			code_postal.Location = new Point(681, 115);
			code_postal.Name = "code_postal";
			code_postal.Size = new Size(78, 21);
			code_postal.TabIndex = 8;
			Label18.AutoSize = true;
			Label18.Location = new Point(281, 122);
			Label18.Name = "Label18";
			Label18.Size = new Size(55, 15);
			Label18.TabIndex = 64;
			Label18.Text = "Adresse";
			adresse.Location = new Point(342, 115);
			adresse.Name = "adresse";
			adresse.Size = new Size(241, 21);
			adresse.TabIndex = 7;
			Label13.AutoSize = true;
			Label13.Location = new Point(433, 165);
			Label13.Name = "Label13";
			Label13.Size = new Size(73, 15);
			Label13.TabIndex = 72;
			Label13.Text = "Téléphone2";
			tel2.Location = new Point(511, 161);
			tel2.Name = "tel2";
			tel2.Size = new Size(75, 21);
			tel2.TabIndex = 12;
			Label14.AutoSize = true;
			Label14.Location = new Point(611, 165);
			Label14.Name = "Label14";
			Label14.Size = new Size(73, 15);
			Label14.TabIndex = 74;
			Label14.Text = "Téléphone3";
			Label17.AutoSize = true;
			Label17.Location = new Point(287, 215);
			Label17.Name = "Label17";
			Label17.Size = new Size(37, 15);
			Label17.TabIndex = 78;
			Label17.Text = "Mail2";
			mail2.Location = new Point(329, 212);
			mail2.Name = "mail2";
			mail2.Size = new Size(119, 21);
			mail2.TabIndex = 15;
			Label19.AutoSize = true;
			Label19.BackColor = Color.Transparent;
			Label19.Location = new Point(113, 212);
			Label19.Name = "Label19";
			Label19.Size = new Size(37, 15);
			Label19.TabIndex = 76;
			Label19.Text = "Mail1";
			mail1.Location = new Point(161, 209);
			mail1.Name = "mail1";
			mail1.Size = new Size(110, 21);
			mail1.TabIndex = 14;
			statut_soc.FormattingEnabled = true;
			statut_soc.Items.AddRange(new object[3]
			{
				"célibataire",
				"Marié",
				"Marié+Enfant"
			});
			statut_soc.Location = new Point(548, 209);
			statut_soc.Name = "statut_soc";
			statut_soc.Size = new Size(74, 23);
			statut_soc.TabIndex = 16;
			Label20.AutoSize = true;
			Label20.Location = new Point(837, 215);
			Label20.Name = "Label20";
			Label20.Size = new Size(90, 15);
			Label20.TabIndex = 82;
			Label20.Text = "Permis voiture";
			Label21.AutoSize = true;
			Label21.Location = new Point(627, 215);
			Label21.Name = "Label21";
			Label21.Size = new Size(77, 15);
			Label21.TabIndex = 81;
			Label21.Text = "Type activité";
			Label22.AutoSize = true;
			Label22.Location = new Point(460, 215);
			Label22.Name = "Label22";
			Label22.Size = new Size(78, 15);
			Label22.TabIndex = 80;
			Label22.Text = "Statut social";
			type_activite.Location = new Point(725, 212);
			type_activite.Name = "type_activite";
			type_activite.Size = new Size(108, 21);
			type_activite.TabIndex = 16;
			permis_voiture.FormattingEnabled = true;
			permis_voiture.Items.AddRange(new object[2]
			{
				"Oui",
				"Non"
			});
			permis_voiture.Location = new Point(935, 212);
			permis_voiture.Name = "permis_voiture";
			permis_voiture.Size = new Size(73, 23);
			permis_voiture.TabIndex = 17;
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.Location = new Point(23, 304);
			Label24.Name = "Label24";
			Label24.Size = new Size(128, 15);
			Label24.TabIndex = 92;
			Label24.Text = "Formation/Date/Place";
			formation.Location = new Point(161, 301);
			formation.Name = "formation";
			formation.Size = new Size(738, 21);
			formation.TabIndex = 21;
			Label25.AutoSize = true;
			Label25.Location = new Point(446, 263);
			Label25.Name = "Label25";
			Label25.Size = new Size(94, 15);
			Label25.TabIndex = 90;
			Label25.Text = "Niveau scolaire";
			niv_scolaire.Location = new Point(554, 260);
			niv_scolaire.Name = "niv_scolaire";
			niv_scolaire.Size = new Size(92, 21);
			niv_scolaire.TabIndex = 20;
			Label26.AutoSize = true;
			Label26.Location = new Point(267, 263);
			Label26.Name = "Label26";
			Label26.Size = new Size(50, 15);
			Label26.TabIndex = 88;
			Label26.Text = "Société";
			societe.Location = new Point(321, 260);
			societe.Name = "societe";
			societe.Size = new Size(120, 21);
			societe.TabIndex = 19;
			Label27.AutoSize = true;
			Label27.BackColor = Color.Transparent;
			Label27.Location = new Point(82, 263);
			Label27.Name = "Label27";
			Label27.Size = new Size(69, 15);
			Label27.TabIndex = 86;
			Label27.Text = "Profession";
			profession.Location = new Point(161, 260);
			profession.Name = "profession";
			profession.Size = new Size(96, 21);
			profession.TabIndex = 18;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(niv3);
			GroupBox1.Controls.Add(niv6);
			GroupBox1.Controls.Add(niv4);
			GroupBox1.Controls.Add(niv2);
			GroupBox1.Controls.Add(niv5);
			GroupBox1.Controls.Add(lang5);
			GroupBox1.Controls.Add(lang4);
			GroupBox1.Controls.Add(lang3);
			GroupBox1.Controls.Add(lang6);
			GroupBox1.Controls.Add(lang2);
			GroupBox1.Controls.Add(niv1);
			GroupBox1.Controls.Add(Label37);
			GroupBox1.Controls.Add(Label38);
			GroupBox1.Controls.Add(Label35);
			GroupBox1.Controls.Add(Label36);
			GroupBox1.Controls.Add(Label33);
			GroupBox1.Controls.Add(Label34);
			GroupBox1.Controls.Add(Label31);
			GroupBox1.Controls.Add(Label32);
			GroupBox1.Controls.Add(Label29);
			GroupBox1.Controls.Add(Label30);
			GroupBox1.Controls.Add(lang1);
			GroupBox1.Controls.Add(Label28);
			GroupBox1.Controls.Add(Label23);
			GroupBox1.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(63, 348);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(1034, 98);
			GroupBox1.TabIndex = 93;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Langages";
			niv3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv3.FormattingEnabled = true;
			niv3.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv3.Location = new Point(929, 28);
			niv3.Name = "niv3";
			niv3.Size = new Size(84, 24);
			niv3.TabIndex = 26;
			niv6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv6.FormattingEnabled = true;
			niv6.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv6.Location = new Point(929, 63);
			niv6.Name = "niv6";
			niv6.Size = new Size(84, 24);
			niv6.TabIndex = 32;
			niv4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv4.FormattingEnabled = true;
			niv4.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv4.Location = new Point(248, 58);
			niv4.Name = "niv4";
			niv4.Size = new Size(84, 24);
			niv4.TabIndex = 28;
			niv2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv2.FormattingEnabled = true;
			niv2.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv2.Location = new Point(597, 27);
			niv2.Name = "niv2";
			niv2.Size = new Size(84, 24);
			niv2.TabIndex = 24;
			niv5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv5.FormattingEnabled = true;
			niv5.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv5.Location = new Point(597, 58);
			niv5.Name = "niv5";
			niv5.Size = new Size(84, 24);
			niv5.TabIndex = 30;
			lang5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang5.FormattingEnabled = true;
			lang5.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang5.Location = new Point(458, 58);
			lang5.Name = "lang5";
			lang5.Size = new Size(84, 24);
			lang5.TabIndex = 29;
			lang4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang4.FormattingEnabled = true;
			lang4.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang4.Location = new Point(96, 58);
			lang4.Name = "lang4";
			lang4.Size = new Size(84, 24);
			lang4.TabIndex = 27;
			lang3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang3.FormattingEnabled = true;
			lang3.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang3.Location = new Point(784, 27);
			lang3.Name = "lang3";
			lang3.Size = new Size(84, 24);
			lang3.TabIndex = 25;
			lang6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang6.FormattingEnabled = true;
			lang6.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang6.Location = new Point(784, 63);
			lang6.Name = "lang6";
			lang6.Size = new Size(84, 24);
			lang6.TabIndex = 31;
			lang2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang2.FormattingEnabled = true;
			lang2.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang2.Location = new Point(458, 23);
			lang2.Name = "lang2";
			lang2.Size = new Size(84, 24);
			lang2.TabIndex = 23;
			niv1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			niv1.FormattingEnabled = true;
			niv1.Items.AddRange(new object[3]
			{
				"Bilingue",
				"Courant",
				"Moyen"
			});
			niv1.Location = new Point(247, 23);
			niv1.Name = "niv1";
			niv1.Size = new Size(84, 24);
			niv1.TabIndex = 22;
			Label37.AutoSize = true;
			Label37.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label37.Location = new Point(707, 65);
			Label37.Name = "Label37";
			Label37.Size = new Size(71, 16);
			Label37.TabIndex = 116;
			Label37.Text = "Langage6";
			Label38.AutoSize = true;
			Label38.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label38.Location = new Point(878, 65);
			Label38.Name = "Label38";
			Label38.Size = new Size(52, 16);
			Label38.TabIndex = 117;
			Label38.Text = "Niveau";
			Label35.AutoSize = true;
			Label35.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label35.Location = new Point(707, 29);
			Label35.Name = "Label35";
			Label35.Size = new Size(71, 16);
			Label35.TabIndex = 112;
			Label35.Text = "Langage3";
			Label36.AutoSize = true;
			Label36.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label36.Location = new Point(878, 30);
			Label36.Name = "Label36";
			Label36.Size = new Size(52, 16);
			Label36.TabIndex = 113;
			Label36.Text = "Niveau";
			Label33.AutoSize = true;
			Label33.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label33.Location = new Point(384, 60);
			Label33.Name = "Label33";
			Label33.Size = new Size(71, 16);
			Label33.TabIndex = 108;
			Label33.Text = "Langage5";
			Label34.AutoSize = true;
			Label34.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label34.Location = new Point(546, 61);
			Label34.Name = "Label34";
			Label34.Size = new Size(52, 16);
			Label34.TabIndex = 109;
			Label34.Text = "Niveau";
			Label31.AutoSize = true;
			Label31.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label31.Location = new Point(384, 28);
			Label31.Name = "Label31";
			Label31.Size = new Size(71, 16);
			Label31.TabIndex = 104;
			Label31.Text = "Langage2";
			Label32.AutoSize = true;
			Label32.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label32.Location = new Point(546, 29);
			Label32.Name = "Label32";
			Label32.Size = new Size(52, 16);
			Label32.TabIndex = 105;
			Label32.Text = "Niveau";
			Label29.AutoSize = true;
			Label29.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label29.Location = new Point(19, 57);
			Label29.Name = "Label29";
			Label29.Size = new Size(71, 16);
			Label29.TabIndex = 100;
			Label29.Text = "Langage4";
			Label30.AutoSize = true;
			Label30.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label30.Location = new Point(192, 57);
			Label30.Name = "Label30";
			Label30.Size = new Size(52, 16);
			Label30.TabIndex = 101;
			Label30.Text = "Niveau";
			lang1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			lang1.FormattingEnabled = true;
			lang1.Items.AddRange(new object[10]
			{
				"Arabe",
				"Français",
				"Anglais",
				"Allemand",
				"Espagnol",
				"Italien",
				"Portuguais",
				"Russe",
				"Tchèque",
				"Polonais"
			});
			lang1.Location = new Point(96, 25);
			lang1.Name = "lang1";
			lang1.Size = new Size(84, 24);
			lang1.TabIndex = 21;
			Label28.AutoSize = true;
			Label28.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label28.Location = new Point(19, 28);
			Label28.Name = "Label28";
			Label28.Size = new Size(71, 16);
			Label28.TabIndex = 96;
			Label28.Text = "Langage1";
			Label23.AutoSize = true;
			Label23.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label23.Location = new Point(192, 29);
			Label23.Name = "Label23";
			Label23.Size = new Size(52, 16);
			Label23.TabIndex = 97;
			Label23.Text = "Niveau";
			Label41.AutoSize = true;
			Label41.Location = new Point(517, 464);
			Label41.Name = "Label41";
			Label41.Size = new Size(108, 15);
			Label41.TabIndex = 98;
			Label41.Text = "Activités préférés";
			activite_prefere.Location = new Point(636, 461);
			activite_prefere.Name = "activite_prefere";
			activite_prefere.Size = new Size(471, 21);
			activite_prefere.TabIndex = 34;
			Label42.AutoSize = true;
			Label42.BackColor = Color.Transparent;
			Label42.Location = new Point(49, 464);
			Label42.Name = "Label42";
			Label42.Size = new Size(86, 15);
			Label42.TabIndex = 96;
			Label42.Text = "Compétences";
			competence.Location = new Point(139, 461);
			competence.Name = "competence";
			competence.Size = new Size(367, 21);
			competence.TabIndex = 33;
			Label39.AutoSize = true;
			Label39.BackColor = Color.Transparent;
			Label39.Location = new Point(47, 499);
			Label39.Name = "Label39";
			Label39.Size = new Size(138, 15);
			Label39.TabIndex = 100;
			Label39.Text = "Activités précéndentes";
			activite_prec.Location = new Point(201, 496);
			activite_prec.Name = "activite_prec";
			activite_prec.Size = new Size(340, 21);
			activite_prec.TabIndex = 35;
			Label40.AutoSize = true;
			Label40.Location = new Point(551, 499);
			Label40.Name = "Label40";
			Label40.Size = new Size(167, 15);
			Label40.TabIndex = 102;
			Label40.Text = "Temps libre pour bénévolats";
			temps_libre.Location = new Point(738, 496);
			temps_libre.Name = "temps_libre";
			temps_libre.Size = new Size(368, 21);
			temps_libre.TabIndex = 36;
			Label43.AutoSize = true;
			Label43.BackColor = Color.Transparent;
			Label43.Location = new Point(46, 533);
			Label43.Name = "Label43";
			Label43.Size = new Size(186, 15);
			Label43.TabIndex = 104;
			Label43.Text = "Le plus à donner à l'association";
			plus_A_donner.Location = new Point(252, 530);
			plus_A_donner.Name = "plus_A_donner";
			plus_A_donner.Size = new Size(338, 21);
			plus_A_donner.TabIndex = 37;
			Label44.AutoSize = true;
			Label44.Location = new Point(595, 533);
			Label44.Name = "Label44";
			Label44.Size = new Size(73, 15);
			Label44.TabIndex = 106;
			Label44.Text = "Remarques";
			remarque.Location = new Point(672, 531);
			remarque.Name = "remarque";
			remarque.Size = new Size(437, 21);
			remarque.TabIndex = 38;
			Label45.AutoSize = true;
			Label45.Location = new Point(430, 576);
			Label45.Name = "Label45";
			Label45.Size = new Size(46, 15);
			Label45.TabIndex = 112;
			Label45.Text = "Twitter";
			twitter.Location = new Point(481, 573);
			twitter.Name = "twitter";
			twitter.Size = new Size(109, 21);
			twitter.TabIndex = 41;
			Label46.AutoSize = true;
			Label46.Location = new Point(231, 576);
			Label46.Name = "Label46";
			Label46.Size = new Size(42, 15);
			Label46.TabIndex = 110;
			Label46.Text = "Skype";
			skype.Location = new Point(285, 573);
			skype.Name = "skype";
			skype.Size = new Size(120, 21);
			skype.TabIndex = 40;
			Label47.AutoSize = true;
			Label47.BackColor = Color.Transparent;
			Label47.Location = new Point(46, 576);
			Label47.Name = "Label47";
			Label47.Size = new Size(62, 15);
			Label47.TabIndex = 108;
			Label47.Text = "Facebook";
			facebook.Location = new Point(118, 573);
			facebook.Name = "facebook";
			facebook.Size = new Size(96, 21);
			facebook.TabIndex = 39;
			statut.FormattingEnabled = true;
			statut.Items.AddRange(new object[3]
			{
				"Ouvrier",
				"Cadre",
				"Manager"
			});
			statut.Location = new Point(96, 615);
			statut.Name = "statut";
			statut.Size = new Size(109, 23);
			statut.TabIndex = 42;
			Label48.AutoSize = true;
			Label48.Location = new Point(246, 620);
			Label48.Name = "Label48";
			Label48.Size = new Size(73, 15);
			Label48.TabIndex = 115;
			Label48.Text = "Date Entrée";
			Label49.AutoSize = true;
			Label49.BackColor = Color.Transparent;
			Label49.Location = new Point(49, 618);
			Label49.Name = "Label49";
			Label49.Size = new Size(41, 15);
			Label49.TabIndex = 114;
			Label49.Text = "Statut";
			Date_inscri.Location = new Point(325, 617);
			Date_inscri.Name = "Date_inscri";
			Date_inscri.Size = new Size(108, 21);
			Date_inscri.TabIndex = 43;
			tel3.Location = new Point(689, 165);
			tel3.Name = "tel3";
			tel3.Size = new Size(75, 21);
			tel3.TabIndex = 13;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(tel3);
			base.Controls.Add(statut);
			base.Controls.Add(Label48);
			base.Controls.Add(Label49);
			base.Controls.Add(Date_inscri);
			base.Controls.Add(Label45);
			base.Controls.Add(twitter);
			base.Controls.Add(Label46);
			base.Controls.Add(skype);
			base.Controls.Add(Label47);
			base.Controls.Add(facebook);
			base.Controls.Add(Label44);
			base.Controls.Add(remarque);
			base.Controls.Add(Label43);
			base.Controls.Add(plus_A_donner);
			base.Controls.Add(Label40);
			base.Controls.Add(temps_libre);
			base.Controls.Add(Label39);
			base.Controls.Add(activite_prec);
			base.Controls.Add(Label41);
			base.Controls.Add(activite_prefere);
			base.Controls.Add(Label42);
			base.Controls.Add(competence);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(Label24);
			base.Controls.Add(formation);
			base.Controls.Add(Label25);
			base.Controls.Add(niv_scolaire);
			base.Controls.Add(Label26);
			base.Controls.Add(societe);
			base.Controls.Add(Label27);
			base.Controls.Add(profession);
			base.Controls.Add(permis_voiture);
			base.Controls.Add(statut_soc);
			base.Controls.Add(Label20);
			base.Controls.Add(Label21);
			base.Controls.Add(Label22);
			base.Controls.Add(type_activite);
			base.Controls.Add(Label17);
			base.Controls.Add(mail2);
			base.Controls.Add(Label19);
			base.Controls.Add(mail1);
			base.Controls.Add(Label14);
			base.Controls.Add(Label13);
			base.Controls.Add(tel2);
			base.Controls.Add(Label15);
			base.Controls.Add(tel1);
			base.Controls.Add(Label16);
			base.Controls.Add(code_postal);
			base.Controls.Add(Label18);
			base.Controls.Add(adresse);
			base.Controls.Add(Date_nais);
			base.Controls.Add(Sexe);
			base.Controls.Add(Label9);
			base.Controls.Add(Ville);
			base.Controls.Add(Label8);
			base.Controls.Add(Gouvernorat);
			base.Controls.Add(Label6);
			base.Controls.Add(Nationalite);
			base.Controls.Add(Label5);
			base.Controls.Add(Nom);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(Num_ci);
			base.Controls.Add(Prenom);
			base.Controls.Add(btnNew);
			Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "info_perso";
			Text = "Fiche de renseignements";
			base.Controls.SetChildIndex(btnNew, 0);
			base.Controls.SetChildIndex(Prenom, 0);
			base.Controls.SetChildIndex(Num_ci, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(Nom, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(Nationalite, 0);
			base.Controls.SetChildIndex(Label6, 0);
			base.Controls.SetChildIndex(Gouvernorat, 0);
			base.Controls.SetChildIndex(Label8, 0);
			base.Controls.SetChildIndex(Ville, 0);
			base.Controls.SetChildIndex(Label9, 0);
			base.Controls.SetChildIndex(Sexe, 0);
			base.Controls.SetChildIndex(Date_nais, 0);
			base.Controls.SetChildIndex(adresse, 0);
			base.Controls.SetChildIndex(Label18, 0);
			base.Controls.SetChildIndex(code_postal, 0);
			base.Controls.SetChildIndex(Label16, 0);
			base.Controls.SetChildIndex(tel1, 0);
			base.Controls.SetChildIndex(Label15, 0);
			base.Controls.SetChildIndex(tel2, 0);
			base.Controls.SetChildIndex(Label13, 0);
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(mail1, 0);
			base.Controls.SetChildIndex(Label19, 0);
			base.Controls.SetChildIndex(mail2, 0);
			base.Controls.SetChildIndex(Label17, 0);
			base.Controls.SetChildIndex(type_activite, 0);
			base.Controls.SetChildIndex(Label22, 0);
			base.Controls.SetChildIndex(Label21, 0);
			base.Controls.SetChildIndex(Label20, 0);
			base.Controls.SetChildIndex(statut_soc, 0);
			base.Controls.SetChildIndex(permis_voiture, 0);
			base.Controls.SetChildIndex(profession, 0);
			base.Controls.SetChildIndex(Label27, 0);
			base.Controls.SetChildIndex(societe, 0);
			base.Controls.SetChildIndex(Label26, 0);
			base.Controls.SetChildIndex(niv_scolaire, 0);
			base.Controls.SetChildIndex(Label25, 0);
			base.Controls.SetChildIndex(formation, 0);
			base.Controls.SetChildIndex(Label24, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			base.Controls.SetChildIndex(competence, 0);
			base.Controls.SetChildIndex(Label42, 0);
			base.Controls.SetChildIndex(activite_prefere, 0);
			base.Controls.SetChildIndex(Label41, 0);
			base.Controls.SetChildIndex(activite_prec, 0);
			base.Controls.SetChildIndex(Label39, 0);
			base.Controls.SetChildIndex(temps_libre, 0);
			base.Controls.SetChildIndex(Label40, 0);
			base.Controls.SetChildIndex(plus_A_donner, 0);
			base.Controls.SetChildIndex(Label43, 0);
			base.Controls.SetChildIndex(remarque, 0);
			base.Controls.SetChildIndex(Label44, 0);
			base.Controls.SetChildIndex(facebook, 0);
			base.Controls.SetChildIndex(Label47, 0);
			base.Controls.SetChildIndex(skype, 0);
			base.Controls.SetChildIndex(Label46, 0);
			base.Controls.SetChildIndex(twitter, 0);
			base.Controls.SetChildIndex(Label45, 0);
			base.Controls.SetChildIndex(Date_inscri, 0);
			base.Controls.SetChildIndex(Label49, 0);
			base.Controls.SetChildIndex(Label48, 0);
			base.Controls.SetChildIndex(statut, 0);
			base.Controls.SetChildIndex(tel3, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void info_perso_Load(object sender, EventArgs e)
		{
			Date_inscri.Text = Conversions.ToString(DateAndTime.Today);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				string text = "select * from INFO_PERSO";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					COD = Conversions.ToString(1);
				}
				else
				{
					mySqlCommand.CommandText = "SELECT MAX(code_perso)+1 FROM INFO_PERSO ";
					COD = Conversions.ToString(mySqlCommand.ExecuteScalar());
				}
				Globals.conn.Close();
				string cmdText = "INSERT INTO INFO_PERSO(code_perso,nom,prenom,sexe,num_ci,date_nais,nationalite,gouvernorat,ville,adresse,code_postale,tel,tel2,tel3,mail,mail2,statut_soc,type_activite,permis_voiture,profession,societe,niv_scolaire,formations,competences,activite_prefere,activite_prec,temps_libre,plus_A_Donner,Remarque,Facbook,Skype,Twiter,Statut_association,Date_inscription,lang1, niv1, lang2, niv2, lang3, niv3, lang4, niv4, lang5, niv5, lang6, niv6)VALUES('" + COD + "', '" + Nom.Text + "', '" + Prenom.Text + "', '" + Sexe.Text + "', '" + Num_ci.Text + "', '" + Date_nais.Text + "', '" + Nationalite.Text + "', '" + Gouvernorat.Text + "', '" + Ville.Text + "', '" + adresse.Text + "', '" + code_postal.Text + "', '" + tel1.Text + "', '" + tel2.Text + "', '" + tel3.Text + "', '" + MyProject.Forms.Mail.Text + "', '" + mail2.Text + "', '" + statut_soc.Text + "', '" + type_activite.Text + "', '" + permis_voiture.Text + "', '" + profession.Text + "', '" + societe.Text + "', '" + niv_scolaire.Text + "', '" + formation.Text + "', '" + competence.Text + "', '" + activite_prefere.Text + "', '" + activite_prec.Text + "', '" + temps_libre.Text + "', '" + plus_A_donner.Text + "', '" + remarque.Text + "', '" + facebook.Text + "', '" + skype.Text + "', '" + twitter.Text + "', '" + statut_soc.Text + "','" + Date_inscri.Text + "', '" + lang1.Text + "', '" + niv1.Text + "', '" + lang2.Text + "', '" + niv2.Text + "', '" + lang3.Text + "', '" + niv3.Text + "', '" + lang4.Text + "', '" + niv4.Text + "', '" + lang5.Text + "', '" + niv5.Text + "', '" + lang6.Text + "', '" + niv6.Text + "')";
				MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
				Globals.conn.Open();
				mySqlCommand2.ExecuteNonQuery();
				Globals.conn.Close();
				ClearTextBox(this);
				RefreshDGV();
				Globals.conn.Close();
				base.Close();
				MessageBox.Show("Membre ajouté");
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
				Globals.conn.Close();
			}
		}

		public void RefreshDGV()
		{
			string selectCommandText = "select * from INFO_PERSO";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("INFO_PERSO");
			mySqlDataAdapter.Fill(dataTable);
			MyProject.Forms.Affich_membres.dgv1.DataSource = dataTable;
		}

		public void ClearTextBox(Form FormName)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = FormName.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is TextBox)
					{
						((TextBox)control).Text = "";
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}
}
