using ERP.My;
using ERP.My.Resources;
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
	public class Modif_info_perso : Accueil
	{
		private IContainer components;

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
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("remarque")]
		private TextBox _remarque;

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
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("temps_libre")]
		private TextBox _temps_libre;

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
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

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
		[AccessedThroughProperty("permis_voiture")]
		private ComboBox _permis_voiture;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("type_activite")]
		private TextBox _type_activite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

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
		[AccessedThroughProperty("Date_nais")]
		private TextBox _Date_nais;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Sexe")]
		private ComboBox _Sexe;

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
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Gouvernorat")]
		private TextBox _Gouvernorat;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Ville")]
		private TextBox _Ville;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

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
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nom")]
		private TextBox _Nom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tel3")]
		private TextBox _tel3;

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
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

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
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("adresse")]
		private TextBox _adresse;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("code_postal")]
		private TextBox _code_postal;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("code_perso")]
		private TextBox _code_perso;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("nom_prenom")]
		private ComboBox _nom_prenom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("statut")]
		private ComboBox _statut;

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

		internal virtual GroupBox GroupBox1
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

		internal virtual ComboBox permis_voiture
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

		internal virtual Label Label22
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

		internal virtual TextBox Date_nais
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

		internal virtual Label Label8
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

		internal virtual TextBox Gouvernorat
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

		internal virtual Label Label9
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

		internal virtual Label Label4
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

		internal virtual TextBox Nom
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

		internal virtual Label Label14
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

		internal virtual TextBox code_postal
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox code_perso
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox nom_prenom
		{
			[CompilerGenerated]
			get
			{
				return _nom_prenom;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = nom_prenom_SelectedIndexChanged;
				ComboBox nom_prenom = _nom_prenom;
				if (nom_prenom != null)
				{
					nom_prenom.SelectedIndexChanged -= value2;
				}
				_nom_prenom = value;
				nom_prenom = _nom_prenom;
				if (nom_prenom != null)
				{
					nom_prenom.SelectedIndexChanged += value2;
				}
			}
		}

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

		internal virtual ComboBox statut
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Modif_info_perso()
		{
			base.Load += Modif_info_perso_Load;
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
			Label48 = new Label();
			Label49 = new Label();
			Date_inscri = new TextBox();
			Label45 = new Label();
			twitter = new TextBox();
			Label46 = new Label();
			skype = new TextBox();
			Label47 = new Label();
			facebook = new TextBox();
			Label44 = new Label();
			remarque = new TextBox();
			Label43 = new Label();
			plus_A_donner = new TextBox();
			Label40 = new Label();
			temps_libre = new TextBox();
			Label39 = new Label();
			activite_prec = new TextBox();
			Label41 = new Label();
			activite_prefere = new TextBox();
			Label42 = new Label();
			competence = new TextBox();
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
			Label24 = new Label();
			formation = new TextBox();
			Label25 = new Label();
			niv_scolaire = new TextBox();
			Label26 = new Label();
			societe = new TextBox();
			Label27 = new Label();
			profession = new TextBox();
			permis_voiture = new ComboBox();
			type_activite = new TextBox();
			Label22 = new Label();
			Label15 = new Label();
			tel1 = new TextBox();
			Date_nais = new TextBox();
			Sexe = new ComboBox();
			Label2 = new Label();
			Label1 = new Label();
			Num_ci = new TextBox();
			Prenom = new TextBox();
			Label8 = new Label();
			Label3 = new Label();
			Gouvernorat = new TextBox();
			Ville = new TextBox();
			Label9 = new Label();
			Label6 = new Label();
			Nationalite = new TextBox();
			Label5 = new Label();
			Label4 = new Label();
			Label16 = new Label();
			Nom = new TextBox();
			tel3 = new TextBox();
			statut_soc = new ComboBox();
			Label20 = new Label();
			Label21 = new Label();
			Label17 = new Label();
			mail2 = new TextBox();
			Label19 = new Label();
			mail1 = new TextBox();
			Label14 = new Label();
			Label13 = new Label();
			tel2 = new TextBox();
			Label18 = new Label();
			adresse = new TextBox();
			code_postal = new TextBox();
			code_perso = new TextBox();
			Label7 = new Label();
			nom_prenom = new ComboBox();
			btnNew = new Button();
			statut = new ComboBox();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			Label48.AutoSize = true;
			Label48.Location = new Point(385, 765);
			Label48.Name = "Label48";
			Label48.Size = new Size(96, 15);
			Label48.TabIndex = 183;
			Label48.Text = "Date inscription";
			Label49.AutoSize = true;
			Label49.BackColor = Color.Transparent;
			Label49.Location = new Point(117, 765);
			Label49.Name = "Label49";
			Label49.Size = new Size(141, 15);
			Label49.TabIndex = 182;
			Label49.Text = "Statut dans association";
			Date_inscri.Location = new Point(496, 759);
			Date_inscri.Name = "Date_inscri";
			Date_inscri.Size = new Size(108, 21);
			Date_inscri.TabIndex = 152;
			Label45.AutoSize = true;
			Label45.Location = new Point(501, 606);
			Label45.Name = "Label45";
			Label45.Size = new Size(47, 15);
			Label45.TabIndex = 181;
			Label45.Text = "Twitter";
			twitter.Location = new Point(552, 603);
			twitter.Name = "twitter";
			twitter.Size = new Size(109, 21);
			twitter.TabIndex = 148;
			Label46.AutoSize = true;
			Label46.Location = new Point(302, 606);
			Label46.Name = "Label46";
			Label46.Size = new Size(42, 15);
			Label46.TabIndex = 180;
			Label46.Text = "Skype";
			skype.Location = new Point(356, 603);
			skype.Name = "skype";
			skype.Size = new Size(120, 21);
			skype.TabIndex = 147;
			Label47.AutoSize = true;
			Label47.BackColor = Color.Transparent;
			Label47.Location = new Point(116, 606);
			Label47.Name = "Label47";
			Label47.Size = new Size(62, 15);
			Label47.TabIndex = 179;
			Label47.Text = "Facebook";
			facebook.Location = new Point(189, 603);
			facebook.Name = "facebook";
			facebook.Size = new Size(96, 21);
			facebook.TabIndex = 144;
			Label44.AutoSize = true;
			Label44.Location = new Point(666, 566);
			Label44.Name = "Label44";
			Label44.Size = new Size(73, 15);
			Label44.TabIndex = 178;
			Label44.Text = "Remarques";
			remarque.Location = new Point(743, 563);
			remarque.Name = "remarque";
			remarque.Size = new Size(437, 21);
			remarque.TabIndex = 143;
			Label43.AutoSize = true;
			Label43.BackColor = Color.Transparent;
			Label43.Location = new Point(116, 566);
			Label43.Name = "Label43";
			Label43.Size = new Size(186, 15);
			Label43.TabIndex = 177;
			Label43.Text = "Le plus à donner à l'association";
			plus_A_donner.Location = new Point(304, 566);
			plus_A_donner.Name = "plus_A_donner";
			plus_A_donner.Size = new Size(357, 21);
			plus_A_donner.TabIndex = 142;
			Label40.AutoSize = true;
			Label40.Location = new Point(620, 516);
			Label40.Name = "Label40";
			Label40.Size = new Size(168, 15);
			Label40.TabIndex = 176;
			Label40.Text = "Temps libre pour bénévolats";
			temps_libre.Location = new Point(788, 513);
			temps_libre.Name = "temps_libre";
			temps_libre.Size = new Size(386, 21);
			temps_libre.TabIndex = 141;
			Label39.AutoSize = true;
			Label39.BackColor = Color.Transparent;
			Label39.Location = new Point(116, 516);
			Label39.Name = "Label39";
			Label39.Size = new Size(138, 15);
			Label39.TabIndex = 175;
			Label39.Text = "Activités précéndentes";
			activite_prec.Location = new Point(254, 513);
			activite_prec.Name = "activite_prec";
			activite_prec.Size = new Size(357, 21);
			activite_prec.TabIndex = 140;
			Label41.AutoSize = true;
			Label41.Location = new Point(584, 479);
			Label41.Name = "Label41";
			Label41.Size = new Size(108, 15);
			Label41.TabIndex = 174;
			Label41.Text = "Activités préférés";
			activite_prefere.Location = new Point(693, 476);
			activite_prefere.Name = "activite_prefere";
			activite_prefere.Size = new Size(481, 21);
			activite_prefere.TabIndex = 139;
			Label42.AutoSize = true;
			Label42.BackColor = Color.Transparent;
			Label42.Location = new Point(115, 479);
			Label42.Name = "Label42";
			Label42.Size = new Size(86, 15);
			Label42.TabIndex = 173;
			Label42.Text = "Compétences";
			competence.Location = new Point(207, 476);
			competence.Name = "competence";
			competence.Size = new Size(365, 21);
			competence.TabIndex = 138;
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
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(139, 359);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(1034, 98);
			GroupBox1.TabIndex = 172;
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
			niv3.Location = new Point(935, 28);
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
			niv6.Location = new Point(935, 63);
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
			lang5.Location = new Point(433, 58);
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
			lang4.Location = new Point(102, 58);
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
			lang3.Location = new Point(794, 28);
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
			lang6.Location = new Point(794, 60);
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
			lang2.Location = new Point(433, 23);
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
			Label37.Location = new Point(717, 63);
			Label37.Name = "Label37";
			Label37.Size = new Size(71, 16);
			Label37.TabIndex = 116;
			Label37.Text = "Langage6";
			Label38.AutoSize = true;
			Label38.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label38.Location = new Point(884, 64);
			Label38.Name = "Label38";
			Label38.Size = new Size(52, 16);
			Label38.TabIndex = 117;
			Label38.Text = "Niveau";
			Label35.AutoSize = true;
			Label35.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label35.Location = new Point(717, 29);
			Label35.Name = "Label35";
			Label35.Size = new Size(71, 16);
			Label35.TabIndex = 112;
			Label35.Text = "Langage3";
			Label36.AutoSize = true;
			Label36.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label36.Location = new Point(884, 30);
			Label36.Name = "Label36";
			Label36.Size = new Size(52, 16);
			Label36.TabIndex = 113;
			Label36.Text = "Niveau";
			Label33.AutoSize = true;
			Label33.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label33.Location = new Point(359, 60);
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
			Label31.Location = new Point(359, 28);
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
			Label29.Location = new Point(31, 56);
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
			lang1.Location = new Point(102, 25);
			lang1.Name = "lang1";
			lang1.Size = new Size(84, 24);
			lang1.TabIndex = 21;
			Label28.AutoSize = true;
			Label28.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label28.Location = new Point(31, 28);
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
			Label24.AutoSize = true;
			Label24.BackColor = Color.Transparent;
			Label24.Location = new Point(238, 309);
			Label24.Name = "Label24";
			Label24.Size = new Size(128, 15);
			Label24.TabIndex = 171;
			Label24.Text = "Formation/Date/Place";
			formation.Location = new Point(371, 306);
			formation.Name = "formation";
			formation.Size = new Size(743, 21);
			formation.TabIndex = 137;
			Label25.AutoSize = true;
			Label25.Location = new Point(614, 263);
			Label25.Name = "Label25";
			Label25.Size = new Size(94, 15);
			Label25.TabIndex = 170;
			Label25.Text = "Niveau scolaire";
			niv_scolaire.Location = new Point(712, 260);
			niv_scolaire.Name = "niv_scolaire";
			niv_scolaire.Size = new Size(92, 21);
			niv_scolaire.TabIndex = 136;
			Label26.AutoSize = true;
			Label26.Location = new Point(436, 263);
			Label26.Name = "Label26";
			Label26.Size = new Size(50, 15);
			Label26.TabIndex = 169;
			Label26.Text = "Société";
			societe.Location = new Point(490, 260);
			societe.Name = "societe";
			societe.Size = new Size(120, 21);
			societe.TabIndex = 135;
			Label27.AutoSize = true;
			Label27.Location = new Point(250, 263);
			Label27.Name = "Label27";
			Label27.Size = new Size(69, 15);
			Label27.TabIndex = 168;
			Label27.Text = "Profession";
			profession.Location = new Point(323, 260);
			profession.Name = "profession";
			profession.Size = new Size(96, 21);
			profession.TabIndex = 134;
			permis_voiture.FormattingEnabled = true;
			permis_voiture.Items.AddRange(new object[2]
			{
				"Oui",
				"Non"
			});
			permis_voiture.Location = new Point(1095, 212);
			permis_voiture.Name = "permis_voiture";
			permis_voiture.Size = new Size(84, 23);
			permis_voiture.TabIndex = 133;
			type_activite.Location = new Point(878, 211);
			type_activite.Name = "type_activite";
			type_activite.Size = new Size(108, 21);
			type_activite.TabIndex = 131;
			Label22.AutoSize = true;
			Label22.Location = new Point(584, 217);
			Label22.Name = "Label22";
			Label22.Size = new Size(78, 15);
			Label22.TabIndex = 165;
			Label22.Text = "Statut social";
			Label15.AutoSize = true;
			Label15.Location = new Point(439, 169);
			Label15.Name = "Label15";
			Label15.Size = new Size(73, 15);
			Label15.TabIndex = 160;
			Label15.Text = "Téléphone1";
			tel1.Location = new Point(512, 166);
			tel1.Name = "tel1";
			tel1.Size = new Size(75, 21);
			tel1.TabIndex = 126;
			Date_nais.Location = new Point(1111, 77);
			Date_nais.Name = "Date_nais";
			Date_nais.Size = new Size(108, 21);
			Date_nais.TabIndex = 120;
			Sexe.FormattingEnabled = true;
			Sexe.Items.AddRange(new object[2]
			{
				"Male",
				"Femelle"
			});
			Sexe.Location = new Point(627, 73);
			Sexe.Name = "Sexe";
			Sexe.Size = new Size(91, 23);
			Sexe.TabIndex = 118;
			Label2.AutoSize = true;
			Label2.Location = new Point(412, 78);
			Label2.Name = "Label2";
			Label2.Size = new Size(55, 15);
			Label2.TabIndex = 146;
			Label2.Text = " Prénom";
			Label1.AutoSize = true;
			Label1.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.Location = new Point(259, 77);
			Label1.Name = "Label1";
			Label1.Size = new Size(37, 16);
			Label1.TabIndex = 145;
			Label1.Text = "Nom";
			Num_ci.Location = new Point(850, 75);
			Num_ci.Name = "Num_ci";
			Num_ci.Size = new Size(108, 21);
			Num_ci.TabIndex = 119;
			Prenom.Location = new Point(474, 75);
			Prenom.Name = "Prenom";
			Prenom.Size = new Size(106, 21);
			Prenom.TabIndex = 117;
			Label8.AutoSize = true;
			Label8.Location = new Point(255, 169);
			Label8.Name = "Label8";
			Label8.Size = new Size(77, 15);
			Label8.TabIndex = 156;
			Label8.Text = "Gouvernorat";
			Label3.AutoSize = true;
			Label3.Location = new Point(586, 78);
			Label3.Name = "Label3";
			Label3.Size = new Size(36, 15);
			Label3.TabIndex = 149;
			Label3.Text = "Sexe";
			Gouvernorat.Location = new Point(338, 166);
			Gouvernorat.Name = "Gouvernorat";
			Gouvernorat.Size = new Size(92, 21);
			Gouvernorat.TabIndex = 125;
			Ville.Location = new Point(958, 123);
			Ville.Name = "Ville";
			Ville.Size = new Size(92, 21);
			Ville.TabIndex = 124;
			Label9.AutoSize = true;
			Label9.Location = new Point(921, 126);
			Label9.Name = "Label9";
			Label9.Size = new Size(31, 15);
			Label9.TabIndex = 157;
			Label9.Text = "Ville";
			Label6.AutoSize = true;
			Label6.Location = new Point(251, 126);
			Label6.Name = "Label6";
			Label6.Size = new Size(67, 15);
			Label6.TabIndex = 154;
			Label6.Text = "Nationalité";
			Nationalite.Location = new Point(324, 123);
			Nationalite.Name = "Nationalite";
			Nationalite.Size = new Size(96, 21);
			Nationalite.TabIndex = 121;
			Label5.AutoSize = true;
			Label5.Location = new Point(998, 77);
			Label5.Name = "Label5";
			Label5.Size = new Size(88, 15);
			Label5.TabIndex = 153;
			Label5.Text = "Date naissnce";
			Label4.AutoSize = true;
			Label4.Location = new Point(738, 78);
			Label4.Name = "Label4";
			Label4.Size = new Size(111, 15);
			Label4.TabIndex = 151;
			Label4.Text = "Num carte identité";
			Label16.AutoSize = true;
			Label16.Location = new Point(738, 123);
			Label16.Name = "Label16";
			Label16.Size = new Size(82, 15);
			Label16.TabIndex = 159;
			Label16.Text = "Code Postale";
			Nom.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Nom.Location = new Point(300, 75);
			Nom.Name = "Nom";
			Nom.Size = new Size(108, 22);
			Nom.TabIndex = 116;
			tel3.Location = new Point(861, 169);
			tel3.Name = "tel3";
			tel3.Size = new Size(75, 21);
			tel3.TabIndex = 128;
			statut_soc.FormattingEnabled = true;
			statut_soc.Items.AddRange(new object[3]
			{
				"célibataire",
				"Marié",
				"Marié+Enfant"
			});
			statut_soc.Location = new Point(662, 211);
			statut_soc.Name = "statut_soc";
			statut_soc.Size = new Size(84, 23);
			statut_soc.TabIndex = 132;
			Label20.AutoSize = true;
			Label20.Location = new Point(999, 215);
			Label20.Name = "Label20";
			Label20.Size = new Size(90, 15);
			Label20.TabIndex = 167;
			Label20.Text = "Permis voiture";
			Label21.AutoSize = true;
			Label21.Location = new Point(780, 214);
			Label21.Name = "Label21";
			Label21.Size = new Size(78, 15);
			Label21.TabIndex = 166;
			Label21.Text = "Type activité";
			Label17.AutoSize = true;
			Label17.Location = new Point(411, 217);
			Label17.Name = "Label17";
			Label17.Size = new Size(37, 15);
			Label17.TabIndex = 164;
			Label17.Text = "Mail2";
			mail2.Location = new Point(453, 214);
			mail2.Name = "mail2";
			mail2.Size = new Size(119, 21);
			mail2.TabIndex = 130;
			Label19.AutoSize = true;
			Label19.Location = new Point(253, 217);
			Label19.Name = "Label19";
			Label19.Size = new Size(37, 15);
			Label19.TabIndex = 163;
			Label19.Text = "Mail1";
			mail1.Location = new Point(291, 214);
			mail1.Name = "mail1";
			mail1.Size = new Size(110, 21);
			mail1.TabIndex = 129;
			Label14.AutoSize = true;
			Label14.Location = new Point(783, 169);
			Label14.Name = "Label14";
			Label14.Size = new Size(73, 15);
			Label14.TabIndex = 162;
			Label14.Text = "Téléphone3";
			Label13.AutoSize = true;
			Label13.Location = new Point(605, 169);
			Label13.Name = "Label13";
			Label13.Size = new Size(73, 15);
			Label13.TabIndex = 161;
			Label13.Text = "Téléphone2";
			tel2.Location = new Point(682, 166);
			tel2.Name = "tel2";
			tel2.Size = new Size(75, 21);
			tel2.TabIndex = 127;
			Label18.AutoSize = true;
			Label18.Location = new Point(424, 126);
			Label18.Name = "Label18";
			Label18.Size = new Size(55, 15);
			Label18.TabIndex = 158;
			Label18.Text = "Adresse";
			adresse.Location = new Point(485, 120);
			adresse.Name = "adresse";
			adresse.Size = new Size(241, 21);
			adresse.TabIndex = 122;
			code_postal.Location = new Point(824, 120);
			code_postal.Name = "code_postal";
			code_postal.Size = new Size(78, 21);
			code_postal.TabIndex = 123;
			code_perso.Location = new Point(57, 112);
			code_perso.Name = "code_perso";
			code_perso.Size = new Size(88, 21);
			code_perso.TabIndex = 186;
			code_perso.Visible = false;
			Label7.BackColor = Color.Transparent;
			Label7.ForeColor = SystemColors.Highlight;
			Label7.Location = new Point(41, 181);
			Label7.Name = "Label7";
			Label7.Size = new Size(146, 36);
			Label7.TabIndex = 192;
			Label7.Text = "Selectionner le nom/prénom à modifier";
			Label7.TextAlign = ContentAlignment.MiddleCenter;
			nom_prenom.FormattingEnabled = true;
			nom_prenom.Location = new Point(44, 223);
			nom_prenom.Name = "nom_prenom";
			nom_prenom.Size = new Size(150, 23);
			nom_prenom.TabIndex = 191;
			btnNew.BackColor = Color.CornflowerBlue;
			btnNew.FlatStyle = FlatStyle.System;
			btnNew.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNew.Location = new Point(57, 273);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(94, 44);
			btnNew.TabIndex = 190;
			btnNew.Text = "Modifier";
			btnNew.UseVisualStyleBackColor = false;
			statut.FormattingEnabled = true;
			statut.Items.AddRange(new object[3]
			{
				"Ouvrier",
				"Cadre",
				"Manager"
			});
			statut.Location = new Point(264, 759);
			statut.Name = "statut";
			statut.Size = new Size(109, 23);
			statut.TabIndex = 193;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1370, 748);
			base.Controls.Add(statut);
			base.Controls.Add(Label7);
			base.Controls.Add(nom_prenom);
			base.Controls.Add(btnNew);
			base.Controls.Add(code_perso);
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
			base.Controls.Add(type_activite);
			base.Controls.Add(Label22);
			base.Controls.Add(Label15);
			base.Controls.Add(tel1);
			base.Controls.Add(Date_nais);
			base.Controls.Add(Sexe);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(Num_ci);
			base.Controls.Add(Prenom);
			base.Controls.Add(Label8);
			base.Controls.Add(Label3);
			base.Controls.Add(Gouvernorat);
			base.Controls.Add(Ville);
			base.Controls.Add(Label9);
			base.Controls.Add(Label6);
			base.Controls.Add(Nationalite);
			base.Controls.Add(Label5);
			base.Controls.Add(Label4);
			base.Controls.Add(Label16);
			base.Controls.Add(Nom);
			base.Controls.Add(tel3);
			base.Controls.Add(statut_soc);
			base.Controls.Add(Label20);
			base.Controls.Add(Label21);
			base.Controls.Add(Label17);
			base.Controls.Add(mail2);
			base.Controls.Add(Label19);
			base.Controls.Add(mail1);
			base.Controls.Add(Label14);
			base.Controls.Add(Label13);
			base.Controls.Add(tel2);
			base.Controls.Add(Label18);
			base.Controls.Add(adresse);
			base.Controls.Add(code_postal);
			Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(4);
			base.Name = "Modif_info_perso";
			Text = "Modif info personnel";
			base.Controls.SetChildIndex(code_postal, 0);
			base.Controls.SetChildIndex(adresse, 0);
			base.Controls.SetChildIndex(Label18, 0);
			base.Controls.SetChildIndex(tel2, 0);
			base.Controls.SetChildIndex(Label13, 0);
			base.Controls.SetChildIndex(Label14, 0);
			base.Controls.SetChildIndex(mail1, 0);
			base.Controls.SetChildIndex(Label19, 0);
			base.Controls.SetChildIndex(mail2, 0);
			base.Controls.SetChildIndex(Label17, 0);
			base.Controls.SetChildIndex(Label21, 0);
			base.Controls.SetChildIndex(Label20, 0);
			base.Controls.SetChildIndex(statut_soc, 0);
			base.Controls.SetChildIndex(tel3, 0);
			base.Controls.SetChildIndex(Nom, 0);
			base.Controls.SetChildIndex(Label16, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(Nationalite, 0);
			base.Controls.SetChildIndex(Label6, 0);
			base.Controls.SetChildIndex(Label9, 0);
			base.Controls.SetChildIndex(Ville, 0);
			base.Controls.SetChildIndex(Gouvernorat, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(Label8, 0);
			base.Controls.SetChildIndex(Prenom, 0);
			base.Controls.SetChildIndex(Num_ci, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Sexe, 0);
			base.Controls.SetChildIndex(Date_nais, 0);
			base.Controls.SetChildIndex(tel1, 0);
			base.Controls.SetChildIndex(Label15, 0);
			base.Controls.SetChildIndex(Label22, 0);
			base.Controls.SetChildIndex(type_activite, 0);
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
			base.Controls.SetChildIndex(code_perso, 0);
			base.Controls.SetChildIndex(btnNew, 0);
			base.Controls.SetChildIndex(nom_prenom, 0);
			base.Controls.SetChildIndex(Label7, 0);
			base.Controls.SetChildIndex(statut, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Modif_info_perso_Load(object sender, EventArgs e)
		{
			MySqlCommand mySqlCommand = new MySqlCommand();
			try
			{
				Globals.conn.Open();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select concat(prenom,concat(' ',nom)) from info_perso";
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				nom_prenom.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						nom_prenom.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void btnNew_Click(object sender, EventArgs e)
		{
			try
			{
				string cmdText = "UPDATE info_perso SET Nom='" + Nom.Text + "', Prenom='" + Prenom.Text + "', Sexe='" + Sexe.Text + "', Num_ci='" + Num_ci.Text + "', Date_nais='" + Date_nais.Text + "', Nationalite='" + Nationalite.Text + "', Gouvernorat='" + Gouvernorat.Text + "', Ville='" + Ville.Text + "',adresse='" + adresse.Text + "',code_postale='" + code_postal.Text + "',tel='" + tel1.Text + "',tel2='" + tel2.Text + "', tel3='" + tel3.Text + "',mail='" + MyProject.Forms.Mail.Text + "', mail2='" + mail2.Text + "', statut_soc='" + statut_soc.Text + "', type_activite='" + type_activite.Text + "', permis_voiture='" + permis_voiture.Text + "', profession='" + profession.Text + "', societe='" + societe.Text + "', niv_scolaire='" + niv_scolaire.Text + "',formations='" + formation.Text + "',competences='" + competence.Text + "',activite_prefere='" + activite_prefere.Text + "',activite_prec='" + activite_prec.Text + "',temps_libre='" + temps_libre.Text + "',plus_A_donner='" + plus_A_donner.Text + "',remarque='" + remarque.Text + "',facbook='" + facebook.Text + "',skype='" + skype.Text + "',twiter='" + twitter.Text + "',statut_association='" + statut_soc.Text + "',Date_inscription='" + Date_inscri.Text + "', lang1='" + lang1.Text + "', niv1='" + niv1.Text + "', lang2='" + lang2.Text + "', niv2='" + niv2.Text + "', lang3='" + lang3.Text + "', niv3='" + niv3.Text + "', lang4='" + lang4.Text + "', niv4='" + niv4.Text + "', lang5='" + lang5.Text + "', niv5='" + niv5.Text + "', lang6='" + lang6.Text + "', niv6='" + niv6.Text + "' where code_perso ='" + code_perso.Text + "'";
				MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
				Globals.conn.Open();
				mySqlCommand.ExecuteNonQuery();
				Globals.conn.Close();
				ClearTextBox(this);
				RefreshDGV();
				base.Close();
				Globals.conn.Close();
				MessageBox.Show("Mofication apportée");
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
			string selectCommandText = "select * from info_perso";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("info_perso");
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

		private void nom_prenom_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select * from info_perso where concat(prenom,concat(' ',nom)) ='" + nom_prenom.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				mySqlCommand.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					code_perso.Text = mySqlDataReader["code_perso"].ToString();
					Nom.Text = mySqlDataReader["nom"].ToString();
					Prenom.Text = mySqlDataReader["prenom"].ToString();
					Sexe.Text = mySqlDataReader["sexe"].ToString();
					Num_ci.Text = mySqlDataReader["num_ci"].ToString();
					Date_nais.Text = mySqlDataReader["date_nais"].ToString();
					Nationalite.Text = mySqlDataReader["nationalite"].ToString();
					Gouvernorat.Text = mySqlDataReader["gouvernorat"].ToString();
					Ville.Text = mySqlDataReader["ville"].ToString();
					adresse.Text = mySqlDataReader["adresse"].ToString();
					code_postal.Text = mySqlDataReader["code_postale"].ToString();
					tel1.Text = mySqlDataReader["tel"].ToString();
					tel2.Text = mySqlDataReader["tel2"].ToString();
					tel3.Text = mySqlDataReader["tel3"].ToString();
					mail1.Text = mySqlDataReader["mail"].ToString();
					mail2.Text = mySqlDataReader["mail2"].ToString();
					statut_soc.Text = mySqlDataReader["statut_soc"].ToString();
					type_activite.Text = mySqlDataReader["type_activite"].ToString();
					permis_voiture.Text = mySqlDataReader["permis_voiture"].ToString();
					profession.Text = mySqlDataReader["profession"].ToString();
					societe.Text = mySqlDataReader["societe"].ToString();
					niv_scolaire.Text = mySqlDataReader["niv_scolaire"].ToString();
					formation.Text = mySqlDataReader["formations"].ToString();
					competence.Text = mySqlDataReader["competences"].ToString();
					activite_prefere.Text = mySqlDataReader["activite_prefere"].ToString();
					activite_prec.Text = mySqlDataReader["activite_prec"].ToString();
					temps_libre.Text = mySqlDataReader["temps_libre"].ToString();
					plus_A_donner.Text = mySqlDataReader["plus_A_donner"].ToString();
					remarque.Text = mySqlDataReader["remarque"].ToString();
					facebook.Text = mySqlDataReader["facbook"].ToString();
					skype.Text = mySqlDataReader["skype"].ToString();
					twitter.Text = mySqlDataReader["twiter"].ToString();
					statut.Text = mySqlDataReader["statut_association"].ToString();
					Date_inscri.Text = mySqlDataReader["date_inscription"].ToString();
					lang1.Text = mySqlDataReader["lang1"].ToString();
					niv1.Text = mySqlDataReader["niv1"].ToString();
					lang2.Text = mySqlDataReader["lang2"].ToString();
					niv2.Text = mySqlDataReader["niv2"].ToString();
					lang3.Text = mySqlDataReader["lang3"].ToString();
					niv3.Text = mySqlDataReader["niv3"].ToString();
					lang4.Text = mySqlDataReader["lang4"].ToString();
					niv4.Text = mySqlDataReader["niv4"].ToString();
					lang5.Text = mySqlDataReader["lang5"].ToString();
					niv5.Text = mySqlDataReader["niv5"].ToString();
					lang6.Text = mySqlDataReader["lang6"].ToString();
					niv6.Text = mySqlDataReader["niv6"].ToString();
				}
				else
				{
					MessageBox.Show("Membre non trouvé");
				}
				mySqlDataReader.Dispose();
				mySqlCommand.Dispose();
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
				Globals.conn.Close();
			}
		}
	}
}
