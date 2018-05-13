using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Accueil : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GestionStockToolStripMenuItem")]
		private ToolStripMenuItem _GestionStockToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MembreToolStripMenuItem")]
		private ToolStripMenuItem _MembreToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AfficherToolStripMenuItem3")]
		private ToolStripMenuItem _AfficherToolStripMenuItem3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("image_accueil")]
		private PictureBox _image_accueil;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ArticleToolStripMenuItem")]
		private ToolStripMenuItem _ArticleToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FournisseurToolStripMenuItem")]
		private ToolStripMenuItem _FournisseurToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ClientToolStripMenuItem")]
		private ToolStripMenuItem _ClientToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("VenteToolStripMenuItem")]
		private ToolStripMenuItem _VenteToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OutilsToolStripMenuItem")]
		private ToolStripMenuItem _OutilsToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AjouterUnUtilisateurToolStripMenuItem")]
		private ToolStripMenuItem _AjouterUnUtilisateurToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_EXIT")]
		private Button _B_EXIT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MajClientToolStripMenuItem")]
		private ToolStripMenuItem _MajClientToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoriqueClientToolStripMenuItem")]
		private ToolStripMenuItem _HistoriqueClientToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoriqueArticleToolStripMenuItem")]
		private ToolStripMenuItem _HistoriqueArticleToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MajFournisseurToolStripMenuItem")]
		private ToolStripMenuItem _MajFournisseurToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoriqueFournisseurToolStripMenuItem")]
		private ToolStripMenuItem _HistoriqueFournisseurToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("StatistiquesToolStripMenuItem")]
		private ToolStripMenuItem _StatistiquesToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("EvolutionStockToolStripMenuItem")]
		private ToolStripMenuItem _EvolutionStockToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CalendrierToolStripMenuItem")]
		private ToolStripMenuItem _CalendrierToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FacturationToolStripMenuItem")]
		private ToolStripMenuItem _FacturationToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MajFacturationToolStripMenuItem")]
		private ToolStripMenuItem _MajFacturationToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoriqqToolStripMenuItem")]
		private ToolStripMenuItem _HistoriqqToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigator1")]
		private BindingNavigator _BindingNavigator1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorAddNewItem")]
		private ToolStripButton _BindingNavigatorAddNewItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorCountItem")]
		private ToolStripLabel _BindingNavigatorCountItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorDeleteItem")]
		private ToolStripButton _BindingNavigatorDeleteItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorMoveFirstItem")]
		private ToolStripButton _BindingNavigatorMoveFirstItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorMovePreviousItem")]
		private ToolStripButton _BindingNavigatorMovePreviousItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorSeparator")]
		private ToolStripSeparator _BindingNavigatorSeparator;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorPositionItem")]
		private ToolStripTextBox _BindingNavigatorPositionItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorSeparator1")]
		private ToolStripSeparator _BindingNavigatorSeparator1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorMoveNextItem")]
		private ToolStripButton _BindingNavigatorMoveNextItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorMoveLastItem")]
		private ToolStripButton _BindingNavigatorMoveLastItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BindingNavigatorSeparator2")]
		private ToolStripSeparator _BindingNavigatorSeparator2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ACCEDEBindingNavigatorSaveItem")]
		private ToolStripButton _ACCEDEBindingNavigatorSaveItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ImprimerToolStripMenuItem")]
		private ToolStripMenuItem _ImprimerToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CalculatriceToolStripMenuItem")]
		private ToolStripMenuItem _CalculatriceToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DétailsArticleToolStripMenuItem")]
		private ToolStripMenuItem _DétailsArticleToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("InforamtionsSociétéToolStripMenuItem")]
		private ToolStripMenuItem _InforamtionsSociétéToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_Accueil")]
		private Button _B_Accueil;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("VenteCommercialeToolStripMenuItem")]
		private ToolStripMenuItem _VenteCommercialeToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AfficherToolStripMenuItem")]
		private ToolStripMenuItem _AfficherToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("SortieStockToolStripMenuItem1")]
		private ToolStripMenuItem _SortieStockToolStripMenuItem1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MembresToolStripMenuItem")]
		private ToolStripMenuItem _MembresToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DevisToolStripMenuItem")]
		private ToolStripMenuItem _DevisToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoDevisToolStripMenuItem")]
		private ToolStripMenuItem _HistoDevisToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CréerUnDevisToolStripMenuItem")]
		private ToolStripMenuItem _CréerUnDevisToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CréerUnBonDeCommandeToolStripMenuItem")]
		private ToolStripMenuItem _CréerUnBonDeCommandeToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CréerUnBonDeLivraisonToolStripMenuItem")]
		private ToolStripMenuItem _CréerUnBonDeLivraisonToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoBonCdeToolStripMenuItem")]
		private ToolStripMenuItem _HistoBonCdeToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoBonLivraisionToolStripMenuItem")]
		private ToolStripMenuItem _HistoBonLivraisionToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem8")]
		private ToolStripMenuItem _ToolStripMenuItem8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CréerUnFactureAchatToolStripMenuItem")]
		private ToolStripMenuItem _CréerUnFactureAchatToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RésolutionÉcranToolStripMenuItem")]
		private ToolStripMenuItem _RésolutionÉcranToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ImprimÉcranToolStripMenuItem")]
		private ToolStripMenuItem _ImprimÉcranToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Imprim_ecran")]
		private Button _Imprim_ecran;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OFGSelectImage1")]
		private OpenFileDialog _OFGSelectImage1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Decon")]
		private Button _Decon;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("HistoriqueTicketsToolStripMenuItem")]
		private ToolStripMenuItem _HistoriqueTicketsToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ChiffreDaffaireToolStripMenuItem")]
		private ToolStripMenuItem _ChiffreDaffaireToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Top10ToolStripMenuItem")]
		private ToolStripMenuItem _Top10ToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Top10ArticleToolStripMenuItem1")]
		private ToolStripMenuItem _Top10ArticleToolStripMenuItem1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FournisseurToolStripMenuItem1")]
		private ToolStripMenuItem _FournisseurToolStripMenuItem1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ClientToolStripMenuItem1")]
		private ToolStripMenuItem _ClientToolStripMenuItem1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MailOutlookToolStripMenuItem")]
		private ToolStripMenuItem _MailOutlookToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MailingClientToolStripMenuItem")]
		private ToolStripMenuItem _MailingClientToolStripMenuItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("statusStrip1")]
		private StatusStrip _statusStrip1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("User_Screen")]
		private ToolStripStatusLabel _User_Screen;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("toolStripStatusLabel3")]
		private ToolStripStatusLabel _toolStripStatusLabel3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("toolStripStatusLabel2")]
		private ToolStripStatusLabel _toolStripStatusLabel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("toolStripProgressBar1")]
		private ToolStripProgressBar _toolStripProgressBar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("toolStripStatusLabel5")]
		private ToolStripStatusLabel _toolStripStatusLabel5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NOM_SOC")]
		private ToolStripStatusLabel _NOM_SOC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripStatusLabel6")]
		private ToolStripStatusLabel _ToolStripStatusLabel6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("timer")]
		private ToolStripStatusLabel _timer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripProgressBar2")]
		private ToolStripProgressBar _ToolStripProgressBar2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem _ToolStripMenuItem5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem6")]
		private ToolStripMenuItem _ToolStripMenuItem6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem7")]
		private ToolStripMenuItem _ToolStripMenuItem7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem9")]
		private ToolStripMenuItem _ToolStripMenuItem9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem10")]
		private ToolStripMenuItem _ToolStripMenuItem10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem11")]
		private ToolStripMenuItem _ToolStripMenuItem11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		private Bitmap memoryImage;

		internal virtual MenuStrip MenuStrip1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem GestionStockToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem MembreToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem AfficherToolStripMenuItem3
		{
			[CompilerGenerated]
			get
			{
				return _AfficherToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = AfficherToolStripMenuItem3_Click;
				ToolStripMenuItem afficherToolStripMenuItem = _AfficherToolStripMenuItem3;
				if (afficherToolStripMenuItem != null)
				{
					afficherToolStripMenuItem.Click -= value2;
				}
				_AfficherToolStripMenuItem3 = value;
				afficherToolStripMenuItem = _AfficherToolStripMenuItem3;
				if (afficherToolStripMenuItem != null)
				{
					afficherToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return _Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer1_Tick;
				Timer timer = _Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				_Timer1 = value;
				timer = _Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual PictureBox image_accueil
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem ArticleToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem FournisseurToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem ClientToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem VenteToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem OutilsToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem AjouterUnUtilisateurToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _AjouterUnUtilisateurToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = AjouterUnUtilisateurToolStripMenuItem_Click;
				ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem = _AjouterUnUtilisateurToolStripMenuItem;
				if (ajouterUnUtilisateurToolStripMenuItem != null)
				{
					ajouterUnUtilisateurToolStripMenuItem.Click -= value2;
				}
				_AjouterUnUtilisateurToolStripMenuItem = value;
				ajouterUnUtilisateurToolStripMenuItem = _AjouterUnUtilisateurToolStripMenuItem;
				if (ajouterUnUtilisateurToolStripMenuItem != null)
				{
					ajouterUnUtilisateurToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Button B_EXIT
		{
			[CompilerGenerated]
			get
			{
				return _B_EXIT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_EXIT_Click;
				Button b_EXIT = _B_EXIT;
				if (b_EXIT != null)
				{
					b_EXIT.Click -= value2;
				}
				_B_EXIT = value;
				b_EXIT = _B_EXIT;
				if (b_EXIT != null)
				{
					b_EXIT.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem MajClientToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MajClientToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MajClientToolStripMenuItem_Click;
				ToolStripMenuItem majClientToolStripMenuItem = _MajClientToolStripMenuItem;
				if (majClientToolStripMenuItem != null)
				{
					majClientToolStripMenuItem.Click -= value2;
				}
				_MajClientToolStripMenuItem = value;
				majClientToolStripMenuItem = _MajClientToolStripMenuItem;
				if (majClientToolStripMenuItem != null)
				{
					majClientToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoriqueClientToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoriqueClientToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoriqueClientToolStripMenuItem_Click;
				ToolStripMenuItem historiqueClientToolStripMenuItem = _HistoriqueClientToolStripMenuItem;
				if (historiqueClientToolStripMenuItem != null)
				{
					historiqueClientToolStripMenuItem.Click -= value2;
				}
				_HistoriqueClientToolStripMenuItem = value;
				historiqueClientToolStripMenuItem = _HistoriqueClientToolStripMenuItem;
				if (historiqueClientToolStripMenuItem != null)
				{
					historiqueClientToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoriqueArticleToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoriqueArticleToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoriqueArticleToolStripMenuItem_Click;
				ToolStripMenuItem historiqueArticleToolStripMenuItem = _HistoriqueArticleToolStripMenuItem;
				if (historiqueArticleToolStripMenuItem != null)
				{
					historiqueArticleToolStripMenuItem.Click -= value2;
				}
				_HistoriqueArticleToolStripMenuItem = value;
				historiqueArticleToolStripMenuItem = _HistoriqueArticleToolStripMenuItem;
				if (historiqueArticleToolStripMenuItem != null)
				{
					historiqueArticleToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem MajFournisseurToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MajFournisseurToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MajFournisseurToolStripMenuItem_Click;
				ToolStripMenuItem majFournisseurToolStripMenuItem = _MajFournisseurToolStripMenuItem;
				if (majFournisseurToolStripMenuItem != null)
				{
					majFournisseurToolStripMenuItem.Click -= value2;
				}
				_MajFournisseurToolStripMenuItem = value;
				majFournisseurToolStripMenuItem = _MajFournisseurToolStripMenuItem;
				if (majFournisseurToolStripMenuItem != null)
				{
					majFournisseurToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoriqueFournisseurToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoriqueFournisseurToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoriqueFournisseurToolStripMenuItem_Click;
				ToolStripMenuItem historiqueFournisseurToolStripMenuItem = _HistoriqueFournisseurToolStripMenuItem;
				if (historiqueFournisseurToolStripMenuItem != null)
				{
					historiqueFournisseurToolStripMenuItem.Click -= value2;
				}
				_HistoriqueFournisseurToolStripMenuItem = value;
				historiqueFournisseurToolStripMenuItem = _HistoriqueFournisseurToolStripMenuItem;
				if (historiqueFournisseurToolStripMenuItem != null)
				{
					historiqueFournisseurToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem StatistiquesToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem EvolutionStockToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _EvolutionStockToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = EvolutionStockToolStripMenuItem_Click;
				ToolStripMenuItem evolutionStockToolStripMenuItem = _EvolutionStockToolStripMenuItem;
				if (evolutionStockToolStripMenuItem != null)
				{
					evolutionStockToolStripMenuItem.Click -= value2;
				}
				_EvolutionStockToolStripMenuItem = value;
				evolutionStockToolStripMenuItem = _EvolutionStockToolStripMenuItem;
				if (evolutionStockToolStripMenuItem != null)
				{
					evolutionStockToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem CalendrierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CalendrierToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CalendrierToolStripMenuItem_Click;
				ToolStripMenuItem calendrierToolStripMenuItem = _CalendrierToolStripMenuItem;
				if (calendrierToolStripMenuItem != null)
				{
					calendrierToolStripMenuItem.Click -= value2;
				}
				_CalendrierToolStripMenuItem = value;
				calendrierToolStripMenuItem = _CalendrierToolStripMenuItem;
				if (calendrierToolStripMenuItem != null)
				{
					calendrierToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem FacturationToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem MajFacturationToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MajFacturationToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MajFacturationToolStripMenuItem_Click;
				ToolStripMenuItem majFacturationToolStripMenuItem = _MajFacturationToolStripMenuItem;
				if (majFacturationToolStripMenuItem != null)
				{
					majFacturationToolStripMenuItem.Click -= value2;
				}
				_MajFacturationToolStripMenuItem = value;
				majFacturationToolStripMenuItem = _MajFacturationToolStripMenuItem;
				if (majFacturationToolStripMenuItem != null)
				{
					majFacturationToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoriqqToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoriqqToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoriqqToolStripMenuItem_Click;
				ToolStripMenuItem historiqqToolStripMenuItem = _HistoriqqToolStripMenuItem;
				if (historiqqToolStripMenuItem != null)
				{
					historiqqToolStripMenuItem.Click -= value2;
				}
				_HistoriqqToolStripMenuItem = value;
				historiqqToolStripMenuItem = _HistoriqqToolStripMenuItem;
				if (historiqqToolStripMenuItem != null)
				{
					historiqqToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual BindingNavigator BindingNavigator1
		{
			[CompilerGenerated]
			get
			{
				return _BindingNavigator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = BindingNavigator1_RefreshItems;
				BindingNavigator bindingNavigator = _BindingNavigator1;
				if (bindingNavigator != null)
				{
					bindingNavigator.RefreshItems -= value2;
				}
				_BindingNavigator1 = value;
				bindingNavigator = _BindingNavigator1;
				if (bindingNavigator != null)
				{
					bindingNavigator.RefreshItems += value2;
				}
			}
		}

		internal virtual ToolStripButton BindingNavigatorAddNewItem
		{
			[CompilerGenerated]
			get
			{
				return _BindingNavigatorAddNewItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = BindingNavigatorAddNewItem_Click;
				ToolStripButton bindingNavigatorAddNewItem = _BindingNavigatorAddNewItem;
				if (bindingNavigatorAddNewItem != null)
				{
					bindingNavigatorAddNewItem.Click -= value2;
				}
				_BindingNavigatorAddNewItem = value;
				bindingNavigatorAddNewItem = _BindingNavigatorAddNewItem;
				if (bindingNavigatorAddNewItem != null)
				{
					bindingNavigatorAddNewItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripLabel BindingNavigatorCountItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton BindingNavigatorDeleteItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton BindingNavigatorMoveFirstItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton BindingNavigatorMovePreviousItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripSeparator BindingNavigatorSeparator
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripTextBox BindingNavigatorPositionItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripSeparator BindingNavigatorSeparator1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton BindingNavigatorMoveNextItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton BindingNavigatorMoveLastItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripSeparator BindingNavigatorSeparator2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton ACCEDEBindingNavigatorSaveItem
		{
			[CompilerGenerated]
			get
			{
				return _ACCEDEBindingNavigatorSaveItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ACCEDEBindingNavigatorSaveItem_Click;
				ToolStripButton aCCEDEBindingNavigatorSaveItem = _ACCEDEBindingNavigatorSaveItem;
				if (aCCEDEBindingNavigatorSaveItem != null)
				{
					aCCEDEBindingNavigatorSaveItem.Click -= value2;
				}
				_ACCEDEBindingNavigatorSaveItem = value;
				aCCEDEBindingNavigatorSaveItem = _ACCEDEBindingNavigatorSaveItem;
				if (aCCEDEBindingNavigatorSaveItem != null)
				{
					aCCEDEBindingNavigatorSaveItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ImprimerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _ImprimerToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ImprimerToolStripMenuItem_Click;
				ToolStripMenuItem imprimerToolStripMenuItem = _ImprimerToolStripMenuItem;
				if (imprimerToolStripMenuItem != null)
				{
					imprimerToolStripMenuItem.Click -= value2;
				}
				_ImprimerToolStripMenuItem = value;
				imprimerToolStripMenuItem = _ImprimerToolStripMenuItem;
				if (imprimerToolStripMenuItem != null)
				{
					imprimerToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual PrintDocument PrintDocument1
		{
			[CompilerGenerated]
			get
			{
				return _PrintDocument1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				PrintPageEventHandler value2 = PrintDocument1_PrintPage;
				PrintEventHandler value3 = PrintDocument1_EndPrint;
				PrintDocument printDocument = _PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage -= value2;
					printDocument.EndPrint -= value3;
				}
				_PrintDocument1 = value;
				printDocument = _PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage += value2;
					printDocument.EndPrint += value3;
				}
			}
		}

		internal virtual ToolStripMenuItem CalculatriceToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CalculatriceToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CalculatriceToolStripMenuItem_Click;
				ToolStripMenuItem calculatriceToolStripMenuItem = _CalculatriceToolStripMenuItem;
				if (calculatriceToolStripMenuItem != null)
				{
					calculatriceToolStripMenuItem.Click -= value2;
				}
				_CalculatriceToolStripMenuItem = value;
				calculatriceToolStripMenuItem = _CalculatriceToolStripMenuItem;
				if (calculatriceToolStripMenuItem != null)
				{
					calculatriceToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem DétailsArticleToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _DétailsArticleToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DétailsArticleToolStripMenuItem_Click;
				ToolStripMenuItem détailsArticleToolStripMenuItem = _DétailsArticleToolStripMenuItem;
				if (détailsArticleToolStripMenuItem != null)
				{
					détailsArticleToolStripMenuItem.Click -= value2;
				}
				_DétailsArticleToolStripMenuItem = value;
				détailsArticleToolStripMenuItem = _DétailsArticleToolStripMenuItem;
				if (détailsArticleToolStripMenuItem != null)
				{
					détailsArticleToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem InforamtionsSociétéToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _InforamtionsSociétéToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = InforamtionsSociétéToolStripMenuItem_Click;
				ToolStripMenuItem inforamtionsSociétéToolStripMenuItem = _InforamtionsSociétéToolStripMenuItem;
				if (inforamtionsSociétéToolStripMenuItem != null)
				{
					inforamtionsSociétéToolStripMenuItem.Click -= value2;
				}
				_InforamtionsSociétéToolStripMenuItem = value;
				inforamtionsSociétéToolStripMenuItem = _InforamtionsSociétéToolStripMenuItem;
				if (inforamtionsSociétéToolStripMenuItem != null)
				{
					inforamtionsSociétéToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Button B_Accueil
		{
			[CompilerGenerated]
			get
			{
				return _B_Accueil;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_Accueil_Click;
				Button b_Accueil = _B_Accueil;
				if (b_Accueil != null)
				{
					b_Accueil.Click -= value2;
				}
				_B_Accueil = value;
				b_Accueil = _B_Accueil;
				if (b_Accueil != null)
				{
					b_Accueil.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem VenteCommercialeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _VenteCommercialeToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = VenteCommercialeToolStripMenuItem_Click;
				ToolStripMenuItem venteCommercialeToolStripMenuItem = _VenteCommercialeToolStripMenuItem;
				if (venteCommercialeToolStripMenuItem != null)
				{
					venteCommercialeToolStripMenuItem.Click -= value2;
				}
				_VenteCommercialeToolStripMenuItem = value;
				venteCommercialeToolStripMenuItem = _VenteCommercialeToolStripMenuItem;
				if (venteCommercialeToolStripMenuItem != null)
				{
					venteCommercialeToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem AfficherToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _AfficherToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = AfficherToolStripMenuItem_Click;
				ToolStripMenuItem afficherToolStripMenuItem = _AfficherToolStripMenuItem;
				if (afficherToolStripMenuItem != null)
				{
					afficherToolStripMenuItem.Click -= value2;
				}
				_AfficherToolStripMenuItem = value;
				afficherToolStripMenuItem = _AfficherToolStripMenuItem;
				if (afficherToolStripMenuItem != null)
				{
					afficherToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem SortieStockToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return _SortieStockToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = SortieStockToolStripMenuItem1_Click;
				ToolStripMenuItem sortieStockToolStripMenuItem = _SortieStockToolStripMenuItem1;
				if (sortieStockToolStripMenuItem != null)
				{
					sortieStockToolStripMenuItem.Click -= value2;
				}
				_SortieStockToolStripMenuItem1 = value;
				sortieStockToolStripMenuItem = _SortieStockToolStripMenuItem1;
				if (sortieStockToolStripMenuItem != null)
				{
					sortieStockToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem MembresToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MembresToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MembresToolStripMenuItem_Click;
				ToolStripMenuItem membresToolStripMenuItem = _MembresToolStripMenuItem;
				if (membresToolStripMenuItem != null)
				{
					membresToolStripMenuItem.Click -= value2;
				}
				_MembresToolStripMenuItem = value;
				membresToolStripMenuItem = _MembresToolStripMenuItem;
				if (membresToolStripMenuItem != null)
				{
					membresToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem DevisToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem HistoDevisToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoDevisToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoDevisToolStripMenuItem_Click;
				ToolStripMenuItem histoDevisToolStripMenuItem = _HistoDevisToolStripMenuItem;
				if (histoDevisToolStripMenuItem != null)
				{
					histoDevisToolStripMenuItem.Click -= value2;
				}
				_HistoDevisToolStripMenuItem = value;
				histoDevisToolStripMenuItem = _HistoDevisToolStripMenuItem;
				if (histoDevisToolStripMenuItem != null)
				{
					histoDevisToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem CréerUnDevisToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CréerUnDevisToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CréerUnDevisToolStripMenuItem_Click;
				ToolStripMenuItem créerUnDevisToolStripMenuItem = _CréerUnDevisToolStripMenuItem;
				if (créerUnDevisToolStripMenuItem != null)
				{
					créerUnDevisToolStripMenuItem.Click -= value2;
				}
				_CréerUnDevisToolStripMenuItem = value;
				créerUnDevisToolStripMenuItem = _CréerUnDevisToolStripMenuItem;
				if (créerUnDevisToolStripMenuItem != null)
				{
					créerUnDevisToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem CréerUnBonDeCommandeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CréerUnBonDeCommandeToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CréerUnBonDeCommandeToolStripMenuItem_Click;
				ToolStripMenuItem créerUnBonDeCommandeToolStripMenuItem = _CréerUnBonDeCommandeToolStripMenuItem;
				if (créerUnBonDeCommandeToolStripMenuItem != null)
				{
					créerUnBonDeCommandeToolStripMenuItem.Click -= value2;
				}
				_CréerUnBonDeCommandeToolStripMenuItem = value;
				créerUnBonDeCommandeToolStripMenuItem = _CréerUnBonDeCommandeToolStripMenuItem;
				if (créerUnBonDeCommandeToolStripMenuItem != null)
				{
					créerUnBonDeCommandeToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem CréerUnBonDeLivraisonToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CréerUnBonDeLivraisonToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CréerUnBonDeLivraisonToolStripMenuItem_Click;
				ToolStripMenuItem créerUnBonDeLivraisonToolStripMenuItem = _CréerUnBonDeLivraisonToolStripMenuItem;
				if (créerUnBonDeLivraisonToolStripMenuItem != null)
				{
					créerUnBonDeLivraisonToolStripMenuItem.Click -= value2;
				}
				_CréerUnBonDeLivraisonToolStripMenuItem = value;
				créerUnBonDeLivraisonToolStripMenuItem = _CréerUnBonDeLivraisonToolStripMenuItem;
				if (créerUnBonDeLivraisonToolStripMenuItem != null)
				{
					créerUnBonDeLivraisonToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoBonCdeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoBonCdeToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoBonCdeToolStripMenuItem_Click;
				ToolStripMenuItem histoBonCdeToolStripMenuItem = _HistoBonCdeToolStripMenuItem;
				if (histoBonCdeToolStripMenuItem != null)
				{
					histoBonCdeToolStripMenuItem.Click -= value2;
				}
				_HistoBonCdeToolStripMenuItem = value;
				histoBonCdeToolStripMenuItem = _HistoBonCdeToolStripMenuItem;
				if (histoBonCdeToolStripMenuItem != null)
				{
					histoBonCdeToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoBonLivraisionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoBonLivraisionToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoBonLivraisionToolStripMenuItem_Click;
				ToolStripMenuItem histoBonLivraisionToolStripMenuItem = _HistoBonLivraisionToolStripMenuItem;
				if (histoBonLivraisionToolStripMenuItem != null)
				{
					histoBonLivraisionToolStripMenuItem.Click -= value2;
				}
				_HistoBonLivraisionToolStripMenuItem = value;
				histoBonLivraisionToolStripMenuItem = _HistoBonLivraisionToolStripMenuItem;
				if (histoBonLivraisionToolStripMenuItem != null)
				{
					histoBonLivraisionToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ProgressBar ProgressBar1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem1 = value;
				toolStripMenuItem = _ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem8
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem8_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem8 = value;
				toolStripMenuItem = _ToolStripMenuItem8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem CréerUnFactureAchatToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _CréerUnFactureAchatToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CréerUnFactureAchatToolStripMenuItem_Click;
				ToolStripMenuItem créerUnFactureAchatToolStripMenuItem = _CréerUnFactureAchatToolStripMenuItem;
				if (créerUnFactureAchatToolStripMenuItem != null)
				{
					créerUnFactureAchatToolStripMenuItem.Click -= value2;
				}
				_CréerUnFactureAchatToolStripMenuItem = value;
				créerUnFactureAchatToolStripMenuItem = _CréerUnFactureAchatToolStripMenuItem;
				if (créerUnFactureAchatToolStripMenuItem != null)
				{
					créerUnFactureAchatToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem RésolutionÉcranToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _RésolutionÉcranToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = RésolutionÉcranToolStripMenuItem_Click;
				ToolStripMenuItem résolutionÉcranToolStripMenuItem = _RésolutionÉcranToolStripMenuItem;
				if (résolutionÉcranToolStripMenuItem != null)
				{
					résolutionÉcranToolStripMenuItem.Click -= value2;
				}
				_RésolutionÉcranToolStripMenuItem = value;
				résolutionÉcranToolStripMenuItem = _RésolutionÉcranToolStripMenuItem;
				if (résolutionÉcranToolStripMenuItem != null)
				{
					résolutionÉcranToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ImprimÉcranToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Imprim_ecran
		{
			[CompilerGenerated]
			get
			{
				return _Imprim_ecran;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Imprim_ecran_Click;
				Button imprim_ecran = _Imprim_ecran;
				if (imprim_ecran != null)
				{
					imprim_ecran.Click -= value2;
				}
				_Imprim_ecran = value;
				imprim_ecran = _Imprim_ecran;
				if (imprim_ecran != null)
				{
					imprim_ecran.Click += value2;
				}
			}
		}

		internal virtual OpenFileDialog OFGSelectImage1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Decon
		{
			[CompilerGenerated]
			get
			{
				return _Decon;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Decon_Click;
				Button decon = _Decon;
				if (decon != null)
				{
					decon.Click -= value2;
				}
				_Decon = value;
				decon = _Decon;
				if (decon != null)
				{
					decon.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem HistoriqueTicketsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _HistoriqueTicketsToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = HistoriqueTicketsToolStripMenuItem_Click;
				ToolStripMenuItem historiqueTicketsToolStripMenuItem = _HistoriqueTicketsToolStripMenuItem;
				if (historiqueTicketsToolStripMenuItem != null)
				{
					historiqueTicketsToolStripMenuItem.Click -= value2;
				}
				_HistoriqueTicketsToolStripMenuItem = value;
				historiqueTicketsToolStripMenuItem = _HistoriqueTicketsToolStripMenuItem;
				if (historiqueTicketsToolStripMenuItem != null)
				{
					historiqueTicketsToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ChiffreDaffaireToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _ChiffreDaffaireToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ChiffreDaffaireToolStripMenuItem_Click;
				ToolStripMenuItem chiffreDaffaireToolStripMenuItem = _ChiffreDaffaireToolStripMenuItem;
				if (chiffreDaffaireToolStripMenuItem != null)
				{
					chiffreDaffaireToolStripMenuItem.Click -= value2;
				}
				_ChiffreDaffaireToolStripMenuItem = value;
				chiffreDaffaireToolStripMenuItem = _ChiffreDaffaireToolStripMenuItem;
				if (chiffreDaffaireToolStripMenuItem != null)
				{
					chiffreDaffaireToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Top10ToolStripMenuItem
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem Top10ArticleToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return _Top10ArticleToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Top10ArticleToolStripMenuItem1_Click;
				ToolStripMenuItem top10ArticleToolStripMenuItem = _Top10ArticleToolStripMenuItem1;
				if (top10ArticleToolStripMenuItem != null)
				{
					top10ArticleToolStripMenuItem.Click -= value2;
				}
				_Top10ArticleToolStripMenuItem1 = value;
				top10ArticleToolStripMenuItem = _Top10ArticleToolStripMenuItem1;
				if (top10ArticleToolStripMenuItem != null)
				{
					top10ArticleToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem FournisseurToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return _FournisseurToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = FournisseurToolStripMenuItem1_Click;
				ToolStripMenuItem fournisseurToolStripMenuItem = _FournisseurToolStripMenuItem1;
				if (fournisseurToolStripMenuItem != null)
				{
					fournisseurToolStripMenuItem.Click -= value2;
				}
				_FournisseurToolStripMenuItem1 = value;
				fournisseurToolStripMenuItem = _FournisseurToolStripMenuItem1;
				if (fournisseurToolStripMenuItem != null)
				{
					fournisseurToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ClientToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return _ClientToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ClientToolStripMenuItem1_Click;
				ToolStripMenuItem clientToolStripMenuItem = _ClientToolStripMenuItem1;
				if (clientToolStripMenuItem != null)
				{
					clientToolStripMenuItem.Click -= value2;
				}
				_ClientToolStripMenuItem1 = value;
				clientToolStripMenuItem = _ClientToolStripMenuItem1;
				if (clientToolStripMenuItem != null)
				{
					clientToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem MailOutlookToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MailOutlookToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MailOutlookToolStripMenuItem_Click;
				ToolStripMenuItem mailOutlookToolStripMenuItem = _MailOutlookToolStripMenuItem;
				if (mailOutlookToolStripMenuItem != null)
				{
					mailOutlookToolStripMenuItem.Click -= value2;
				}
				_MailOutlookToolStripMenuItem = value;
				mailOutlookToolStripMenuItem = _MailOutlookToolStripMenuItem;
				if (mailOutlookToolStripMenuItem != null)
				{
					mailOutlookToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem MailingClientToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _MailingClientToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MailingClientToolStripMenuItem_Click;
				ToolStripMenuItem mailingClientToolStripMenuItem = _MailingClientToolStripMenuItem;
				if (mailingClientToolStripMenuItem != null)
				{
					mailingClientToolStripMenuItem.Click -= value2;
				}
				_MailingClientToolStripMenuItem = value;
				mailingClientToolStripMenuItem = _MailingClientToolStripMenuItem;
				if (mailingClientToolStripMenuItem != null)
				{
					mailingClientToolStripMenuItem.Click += value2;
				}
			}
		}

		public virtual StatusStrip statusStrip1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ToolStripStatusLabel User_Screen
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel toolStripStatusLabel3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel toolStripStatusLabel2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripProgressBar toolStripProgressBar1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel toolStripStatusLabel5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel NOM_SOC
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel ToolStripStatusLabel6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripStatusLabel timer
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

        internal virtual ToolStripProgressBar ToolStripProgressBar2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem5
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem5_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem5 = value;
				toolStripMenuItem = _ToolStripMenuItem5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem6_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem6 = value;
				toolStripMenuItem = _ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem7
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem7_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem7 = value;
				toolStripMenuItem = _ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem9
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem9_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem9 = value;
				toolStripMenuItem = _ToolStripMenuItem9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem10
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem10_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem10;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem10 = value;
				toolStripMenuItem = _ToolStripMenuItem10;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem11
		{
			[CompilerGenerated]
			get
			{
				return _ToolStripMenuItem11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem11_Click;
				ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem11;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				_ToolStripMenuItem11 = value;
				toolStripMenuItem = _ToolStripMenuItem11;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return _PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PictureBox1_Click;
				PictureBox pictureBox = _PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				_PictureBox1 = value;
				pictureBox = _PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		internal virtual ToolStripButton ToolStripButton1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ToolStripButton ToolStripButton2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Accueil()
		{
			base.KeyDown += Accueil_KeyDown;
			base.Load += Accueil_Load;
			base.SizeChanged += Accueil_SizeChanged;
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

		//[DebuggerStepThrough]
		public void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Accueil));
			MenuStrip1 = new MenuStrip();
			ArticleToolStripMenuItem = new ToolStripMenuItem();
			DétailsArticleToolStripMenuItem = new ToolStripMenuItem();
			HistoriqueArticleToolStripMenuItem = new ToolStripMenuItem();
			FournisseurToolStripMenuItem = new ToolStripMenuItem();
			MajFournisseurToolStripMenuItem = new ToolStripMenuItem();
			HistoriqueFournisseurToolStripMenuItem = new ToolStripMenuItem();
			ClientToolStripMenuItem = new ToolStripMenuItem();
			MajClientToolStripMenuItem = new ToolStripMenuItem();
			HistoriqueClientToolStripMenuItem = new ToolStripMenuItem();
			MailingClientToolStripMenuItem = new ToolStripMenuItem();
			GestionStockToolStripMenuItem = new ToolStripMenuItem();
			AfficherToolStripMenuItem = new ToolStripMenuItem();
			SortieStockToolStripMenuItem1 = new ToolStripMenuItem();
			MembresToolStripMenuItem = new ToolStripMenuItem();
			DevisToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem1 = new ToolStripMenuItem();
			ToolStripMenuItem5 = new ToolStripMenuItem();
			ToolStripMenuItem6 = new ToolStripMenuItem();
			ToolStripMenuItem7 = new ToolStripMenuItem();
			CréerUnFactureAchatToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem8 = new ToolStripMenuItem();
			ToolStripMenuItem9 = new ToolStripMenuItem();
			ToolStripMenuItem10 = new ToolStripMenuItem();
			ToolStripMenuItem11 = new ToolStripMenuItem();
			VenteToolStripMenuItem = new ToolStripMenuItem();
			VenteCommercialeToolStripMenuItem = new ToolStripMenuItem();
			HistoriqueTicketsToolStripMenuItem = new ToolStripMenuItem();
			HistoriqqToolStripMenuItem = new ToolStripMenuItem();
			FacturationToolStripMenuItem = new ToolStripMenuItem();
			CréerUnDevisToolStripMenuItem = new ToolStripMenuItem();
			CréerUnBonDeCommandeToolStripMenuItem = new ToolStripMenuItem();
			CréerUnBonDeLivraisonToolStripMenuItem = new ToolStripMenuItem();
			MajFacturationToolStripMenuItem = new ToolStripMenuItem();
			HistoDevisToolStripMenuItem = new ToolStripMenuItem();
			HistoBonCdeToolStripMenuItem = new ToolStripMenuItem();
			HistoBonLivraisionToolStripMenuItem = new ToolStripMenuItem();
			MembreToolStripMenuItem = new ToolStripMenuItem();
			AfficherToolStripMenuItem3 = new ToolStripMenuItem();
			StatistiquesToolStripMenuItem = new ToolStripMenuItem();
			EvolutionStockToolStripMenuItem = new ToolStripMenuItem();
			ChiffreDaffaireToolStripMenuItem = new ToolStripMenuItem();
			Top10ToolStripMenuItem = new ToolStripMenuItem();
			Top10ArticleToolStripMenuItem1 = new ToolStripMenuItem();
			FournisseurToolStripMenuItem1 = new ToolStripMenuItem();
			ClientToolStripMenuItem1 = new ToolStripMenuItem();
			OutilsToolStripMenuItem = new ToolStripMenuItem();
			ImprimerToolStripMenuItem = new ToolStripMenuItem();
			AjouterUnUtilisateurToolStripMenuItem = new ToolStripMenuItem();
			InforamtionsSociétéToolStripMenuItem = new ToolStripMenuItem();
			CalendrierToolStripMenuItem = new ToolStripMenuItem();
			CalculatriceToolStripMenuItem = new ToolStripMenuItem();
			RésolutionÉcranToolStripMenuItem = new ToolStripMenuItem();
			ImprimÉcranToolStripMenuItem = new ToolStripMenuItem();
			MailOutlookToolStripMenuItem = new ToolStripMenuItem();
			Timer1 = new Timer(components);
			image_accueil = new PictureBox();
			B_EXIT = new Button();
			BindingNavigator1 = new BindingNavigator(components);
			BindingNavigatorAddNewItem = new ToolStripButton();
			BindingNavigatorCountItem = new ToolStripLabel();
			BindingNavigatorDeleteItem = new ToolStripButton();
			BindingNavigatorMoveFirstItem = new ToolStripButton();
			BindingNavigatorMovePreviousItem = new ToolStripButton();
			BindingNavigatorSeparator = new ToolStripSeparator();
			BindingNavigatorPositionItem = new ToolStripTextBox();
			BindingNavigatorSeparator1 = new ToolStripSeparator();
			BindingNavigatorMoveNextItem = new ToolStripButton();
			BindingNavigatorMoveLastItem = new ToolStripButton();
			BindingNavigatorSeparator2 = new ToolStripSeparator();
			ACCEDEBindingNavigatorSaveItem = new ToolStripButton();
			ToolStripSeparator1 = new ToolStripSeparator();
			ToolStripProgressBar2 = new ToolStripProgressBar();
			ToolStripButton1 = new ToolStripButton();
			ToolStripButton2 = new ToolStripButton();
			PrintDocument1 = new PrintDocument();
			B_Accueil = new Button();
			ProgressBar1 = new ProgressBar();
			Imprim_ecran = new Button();
			OFGSelectImage1 = new OpenFileDialog();
			Decon = new Button();
			statusStrip1 = new StatusStrip();
			User_Screen = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripProgressBar1 = new ToolStripProgressBar();
			toolStripStatusLabel5 = new ToolStripStatusLabel();
			NOM_SOC = new ToolStripStatusLabel();
			ToolStripStatusLabel6 = new ToolStripStatusLabel();
			timer = new ToolStripStatusLabel();
			PictureBox1 = new PictureBox();
			MenuStrip1.SuspendLayout();
			((ISupportInitialize)image_accueil).BeginInit();
			((ISupportInitialize)BindingNavigator1).BeginInit();
			BindingNavigator1.SuspendLayout();
			statusStrip1.SuspendLayout();
			((ISupportInitialize)PictureBox1).BeginInit();
			base.SuspendLayout();
			MenuStrip1.BackColor = Color.White;
			MenuStrip1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MenuStrip1.Items.AddRange(new ToolStripItem[10]
			{
				ArticleToolStripMenuItem,
				FournisseurToolStripMenuItem,
				ClientToolStripMenuItem,
				GestionStockToolStripMenuItem,
				DevisToolStripMenuItem,
				VenteToolStripMenuItem,
				FacturationToolStripMenuItem,
				MembreToolStripMenuItem,
				StatistiquesToolStripMenuItem,
				OutilsToolStripMenuItem
			});
			MenuStrip1.Location = new Point(0, 0);
			MenuStrip1.Name = "MenuStrip1";
			MenuStrip1.Padding = new Padding(7, 3, 0, 3);
			MenuStrip1.Size = new Size(1350, 28);
			MenuStrip1.TabIndex = 0;
			MenuStrip1.Text = "MenuStrip1";
			ArticleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
			{
				DétailsArticleToolStripMenuItem,
				HistoriqueArticleToolStripMenuItem
			});
			ArticleToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ArticleToolStripMenuItem.Name = "ArticleToolStripMenuItem";
			ArticleToolStripMenuItem.Size = new Size(66, 22);
			ArticleToolStripMenuItem.Text = "Article";
			DétailsArticleToolStripMenuItem.Name = "DétailsArticleToolStripMenuItem";
			DétailsArticleToolStripMenuItem.Size = new Size(198, 22);
			DétailsArticleToolStripMenuItem.Text = "M.à.j Article";
			HistoriqueArticleToolStripMenuItem.Name = "HistoriqueArticleToolStripMenuItem";
			HistoriqueArticleToolStripMenuItem.Size = new Size(198, 22);
			HistoriqueArticleToolStripMenuItem.Text = "Historique Article";
			FournisseurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
			{
				MajFournisseurToolStripMenuItem,
				HistoriqueFournisseurToolStripMenuItem
			});
			FournisseurToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem";
			FournisseurToolStripMenuItem.Size = new Size(105, 22);
			FournisseurToolStripMenuItem.Text = "Fournisseur";
			MajFournisseurToolStripMenuItem.Name = "MajFournisseurToolStripMenuItem";
			MajFournisseurToolStripMenuItem.Size = new Size(238, 22);
			MajFournisseurToolStripMenuItem.Text = "M.à.j Fournisseur";
			HistoriqueFournisseurToolStripMenuItem.Name = "HistoriqueFournisseurToolStripMenuItem";
			HistoriqueFournisseurToolStripMenuItem.Size = new Size(238, 22);
			HistoriqueFournisseurToolStripMenuItem.Text = "Historique Fournisseur";
			ClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				MajClientToolStripMenuItem,
				HistoriqueClientToolStripMenuItem,
				MailingClientToolStripMenuItem
			});
			ClientToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
			ClientToolStripMenuItem.Size = new Size(61, 22);
			ClientToolStripMenuItem.Text = "Client";
			MajClientToolStripMenuItem.Name = "MajClientToolStripMenuItem";
			MajClientToolStripMenuItem.Size = new Size(194, 22);
			MajClientToolStripMenuItem.Text = "M.à.j Client";
			HistoriqueClientToolStripMenuItem.Name = "HistoriqueClientToolStripMenuItem";
			HistoriqueClientToolStripMenuItem.Size = new Size(194, 22);
			HistoriqueClientToolStripMenuItem.Text = "Historique Client";
			MailingClientToolStripMenuItem.Name = "MailingClientToolStripMenuItem";
			MailingClientToolStripMenuItem.Size = new Size(194, 22);
			MailingClientToolStripMenuItem.Text = "Mailing Client";
			GestionStockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				AfficherToolStripMenuItem,
				SortieStockToolStripMenuItem1,
				MembresToolStripMenuItem
			});
			GestionStockToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			GestionStockToolStripMenuItem.Name = "GestionStockToolStripMenuItem";
			GestionStockToolStripMenuItem.Size = new Size(60, 22);
			GestionStockToolStripMenuItem.Text = "Stock";
			AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem";
			AfficherToolStripMenuItem.Size = new Size(166, 22);
			AfficherToolStripMenuItem.Text = "Stock Global";
			SortieStockToolStripMenuItem1.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			SortieStockToolStripMenuItem1.Name = "SortieStockToolStripMenuItem1";
			SortieStockToolStripMenuItem1.Size = new Size(166, 22);
			SortieStockToolStripMenuItem1.Text = "Sortie Stock";
			MembresToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			MembresToolStripMenuItem.Name = "MembresToolStripMenuItem";
			MembresToolStripMenuItem.Size = new Size(166, 22);
			MembresToolStripMenuItem.Text = "Entrée Stock";
			DevisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[9]
			{
				ToolStripMenuItem1,
				ToolStripMenuItem5,
				ToolStripMenuItem6,
				ToolStripMenuItem7,
				CréerUnFactureAchatToolStripMenuItem,
				ToolStripMenuItem8,
				ToolStripMenuItem9,
				ToolStripMenuItem10,
				ToolStripMenuItem11
			});
			DevisToolStripMenuItem.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			DevisToolStripMenuItem.Name = "DevisToolStripMenuItem";
			DevisToolStripMenuItem.Size = new Size(64, 22);
			DevisToolStripMenuItem.Text = "Achat";
			ToolStripMenuItem1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			ToolStripMenuItem1.Size = new Size(259, 22);
			ToolStripMenuItem1.Text = "Entrée Stock";
			ToolStripMenuItem5.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			ToolStripMenuItem5.Size = new Size(259, 22);
			ToolStripMenuItem5.Text = "Créer un Devis Achat";
			ToolStripMenuItem5.Visible = false;
			ToolStripMenuItem6.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			ToolStripMenuItem6.Size = new Size(259, 22);
			ToolStripMenuItem6.Text = "Créer un B.C Achat";
			ToolStripMenuItem6.Visible = false;
			ToolStripMenuItem7.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			ToolStripMenuItem7.Size = new Size(259, 22);
			ToolStripMenuItem7.Text = "Créer un B.L Achat";
			ToolStripMenuItem7.Visible = false;
			CréerUnFactureAchatToolStripMenuItem.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CréerUnFactureAchatToolStripMenuItem.Name = "CréerUnFactureAchatToolStripMenuItem";
			CréerUnFactureAchatToolStripMenuItem.Size = new Size(259, 22);
			CréerUnFactureAchatToolStripMenuItem.Text = "Créer une Facture Achat";
			ToolStripMenuItem8.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem8.Name = "ToolStripMenuItem8";
			ToolStripMenuItem8.Size = new Size(259, 22);
			ToolStripMenuItem8.Text = "Histo Facturation Achat";
			ToolStripMenuItem9.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem9.Name = "ToolStripMenuItem9";
			ToolStripMenuItem9.Size = new Size(259, 22);
			ToolStripMenuItem9.Text = "Histo Devis Achat";
			ToolStripMenuItem9.Visible = false;
			ToolStripMenuItem10.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem10.Name = "ToolStripMenuItem10";
			ToolStripMenuItem10.Size = new Size(259, 22);
			ToolStripMenuItem10.Text = "Histo B.C Achat";
			ToolStripMenuItem10.Visible = false;
			ToolStripMenuItem11.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			ToolStripMenuItem11.Name = "ToolStripMenuItem11";
			ToolStripMenuItem11.Size = new Size(259, 22);
			ToolStripMenuItem11.Text = "Histo B.L Achat";
			ToolStripMenuItem11.Visible = false;
			VenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				VenteCommercialeToolStripMenuItem,
				HistoriqueTicketsToolStripMenuItem,
				HistoriqqToolStripMenuItem
			});
			VenteToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			VenteToolStripMenuItem.Name = "VenteToolStripMenuItem";
			VenteToolStripMenuItem.Size = new Size(59, 22);
			VenteToolStripMenuItem.Text = "Vente";
			VenteCommercialeToolStripMenuItem.Name = "VenteCommercialeToolStripMenuItem";
			VenteCommercialeToolStripMenuItem.Size = new Size(244, 22);
			VenteCommercialeToolStripMenuItem.Text = "Vente Commerciale";
			HistoriqueTicketsToolStripMenuItem.Name = "HistoriqueTicketsToolStripMenuItem";
			HistoriqueTicketsToolStripMenuItem.Size = new Size(244, 22);
			HistoriqueTicketsToolStripMenuItem.Text = "Historique Tickets";
			HistoriqqToolStripMenuItem.Name = "HistoriqqToolStripMenuItem";
			HistoriqqToolStripMenuItem.Size = new Size(244, 22);
			HistoriqqToolStripMenuItem.Text = "Historique Détails Vente";
			FacturationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[7]
			{
				CréerUnDevisToolStripMenuItem,
				CréerUnBonDeCommandeToolStripMenuItem,
				CréerUnBonDeLivraisonToolStripMenuItem,
				MajFacturationToolStripMenuItem,
				HistoDevisToolStripMenuItem,
				HistoBonCdeToolStripMenuItem,
				HistoBonLivraisionToolStripMenuItem
			});
			FacturationToolStripMenuItem.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			FacturationToolStripMenuItem.Name = "FacturationToolStripMenuItem";
			FacturationToolStripMenuItem.Size = new Size(106, 22);
			FacturationToolStripMenuItem.Text = "Facturation";
			CréerUnDevisToolStripMenuItem.Name = "CréerUnDevisToolStripMenuItem";
			CréerUnDevisToolStripMenuItem.Size = new Size(206, 22);
			CréerUnDevisToolStripMenuItem.Text = "Créer un Devis";
			CréerUnBonDeCommandeToolStripMenuItem.Name = "CréerUnBonDeCommandeToolStripMenuItem";
			CréerUnBonDeCommandeToolStripMenuItem.Size = new Size(206, 22);
			CréerUnBonDeCommandeToolStripMenuItem.Text = "Créer un B.C";
			CréerUnBonDeLivraisonToolStripMenuItem.Name = "CréerUnBonDeLivraisonToolStripMenuItem";
			CréerUnBonDeLivraisonToolStripMenuItem.Size = new Size(206, 22);
			CréerUnBonDeLivraisonToolStripMenuItem.Text = "Créer un B.L";
			MajFacturationToolStripMenuItem.Name = "MajFacturationToolStripMenuItem";
			MajFacturationToolStripMenuItem.Size = new Size(206, 22);
			MajFacturationToolStripMenuItem.Text = "Histo Facturation";
			HistoDevisToolStripMenuItem.Name = "HistoDevisToolStripMenuItem";
			HistoDevisToolStripMenuItem.Size = new Size(206, 22);
			HistoDevisToolStripMenuItem.Text = "Histo Devis";
			HistoBonCdeToolStripMenuItem.Name = "HistoBonCdeToolStripMenuItem";
			HistoBonCdeToolStripMenuItem.Size = new Size(206, 22);
			HistoBonCdeToolStripMenuItem.Text = "Histo B.C";
			HistoBonLivraisionToolStripMenuItem.Name = "HistoBonLivraisionToolStripMenuItem";
			HistoBonLivraisionToolStripMenuItem.Size = new Size(206, 22);
			HistoBonLivraisionToolStripMenuItem.Text = "Histo B.L";
			MembreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
			{
				AfficherToolStripMenuItem3
			});
			MembreToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			MembreToolStripMenuItem.Name = "MembreToolStripMenuItem";
			MembreToolStripMenuItem.Size = new Size(91, 22);
			MembreToolStripMenuItem.Text = "Personnel";
			AfficherToolStripMenuItem3.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			AfficherToolStripMenuItem3.Name = "AfficherToolStripMenuItem3";
			AfficherToolStripMenuItem3.Size = new Size(189, 22);
			AfficherToolStripMenuItem3.Text = "Màj. Personnel";
			StatistiquesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				EvolutionStockToolStripMenuItem,
				ChiffreDaffaireToolStripMenuItem,
				Top10ToolStripMenuItem
			});
			StatistiquesToolStripMenuItem.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			StatistiquesToolStripMenuItem.Name = "StatistiquesToolStripMenuItem";
			StatistiquesToolStripMenuItem.Size = new Size(109, 22);
			StatistiquesToolStripMenuItem.Text = "Statistiques";
			EvolutionStockToolStripMenuItem.Name = "EvolutionStockToolStripMenuItem";
			EvolutionStockToolStripMenuItem.Size = new Size(197, 22);
			EvolutionStockToolStripMenuItem.Text = "Evolution Stock";
			ChiffreDaffaireToolStripMenuItem.Name = "ChiffreDaffaireToolStripMenuItem";
			ChiffreDaffaireToolStripMenuItem.Size = new Size(197, 22);
			ChiffreDaffaireToolStripMenuItem.Text = "Tableau de bord";
			Top10ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				Top10ArticleToolStripMenuItem1,
				FournisseurToolStripMenuItem1,
				ClientToolStripMenuItem1
			});
			Top10ToolStripMenuItem.Name = "Top10ToolStripMenuItem";
			Top10ToolStripMenuItem.Size = new Size(197, 22);
			Top10ToolStripMenuItem.Text = "Top 10";
			Top10ArticleToolStripMenuItem1.Name = "Top10ArticleToolStripMenuItem1";
			Top10ArticleToolStripMenuItem1.Size = new Size(169, 22);
			Top10ArticleToolStripMenuItem1.Text = "Article";
			FournisseurToolStripMenuItem1.Name = "FournisseurToolStripMenuItem1";
			FournisseurToolStripMenuItem1.Size = new Size(169, 22);
			FournisseurToolStripMenuItem1.Text = "Fournisseur";
			ClientToolStripMenuItem1.Name = "ClientToolStripMenuItem1";
			ClientToolStripMenuItem1.Size = new Size(169, 22);
			ClientToolStripMenuItem1.Text = "Client";
			OutilsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
			{
				ImprimerToolStripMenuItem,
				AjouterUnUtilisateurToolStripMenuItem,
				InforamtionsSociétéToolStripMenuItem,
				CalendrierToolStripMenuItem,
				CalculatriceToolStripMenuItem,
				RésolutionÉcranToolStripMenuItem,
				ImprimÉcranToolStripMenuItem,
				MailOutlookToolStripMenuItem
			});
			OutilsToolStripMenuItem.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem";
			OutilsToolStripMenuItem.Size = new Size(62, 22);
			OutilsToolStripMenuItem.Text = "Outils";
			ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem";
			ImprimerToolStripMenuItem.Size = new Size(235, 22);
			ImprimerToolStripMenuItem.Text = "Imprimer";
			AjouterUnUtilisateurToolStripMenuItem.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			AjouterUnUtilisateurToolStripMenuItem.Name = "AjouterUnUtilisateurToolStripMenuItem";
			AjouterUnUtilisateurToolStripMenuItem.Size = new Size(235, 22);
			AjouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un utilisateur";
			InforamtionsSociétéToolStripMenuItem.Name = "InforamtionsSociétéToolStripMenuItem";
			InforamtionsSociétéToolStripMenuItem.Size = new Size(235, 22);
			InforamtionsSociétéToolStripMenuItem.Text = "Inforamtions Société";
			CalendrierToolStripMenuItem.Name = "CalendrierToolStripMenuItem";
			CalendrierToolStripMenuItem.Size = new Size(235, 22);
			CalendrierToolStripMenuItem.Text = "Calendrier";
			CalculatriceToolStripMenuItem.Name = "CalculatriceToolStripMenuItem";
			CalculatriceToolStripMenuItem.Size = new Size(235, 22);
			CalculatriceToolStripMenuItem.Text = "Calculatrice";
			RésolutionÉcranToolStripMenuItem.Name = "RésolutionÉcranToolStripMenuItem";
			RésolutionÉcranToolStripMenuItem.Size = new Size(235, 22);
			RésolutionÉcranToolStripMenuItem.Text = "Résolution écran";
			ImprimÉcranToolStripMenuItem.Name = "ImprimÉcranToolStripMenuItem";
			ImprimÉcranToolStripMenuItem.Size = new Size(235, 22);
			ImprimÉcranToolStripMenuItem.Text = "Imprim écran";
			MailOutlookToolStripMenuItem.Name = "MailOutlookToolStripMenuItem";
			MailOutlookToolStripMenuItem.Size = new Size(235, 22);
			MailOutlookToolStripMenuItem.Text = "Envoyer un mail";
			//image_accueil.Image = Resources.images2;
			//image_accueil.Location = new Point(1270, 55);
			//image_accueil.Margin = new Padding(3, 4, 3, 4);
			//image_accueil.Name = "image_accueil";
			//image_accueil.Size = new Size(79, 162);
			//image_accueil.SizeMode = PictureBoxSizeMode.StretchImage;
			//image_accueil.TabIndex = 2;
			//image_accueil.TabStop = false;
			//B_EXIT.BackgroundImage = (Image)componentResourceManager.GetObject("B_EXIT.BackgroundImage");
			//B_EXIT.Cursor = Cursors.Hand;
			//B_EXIT.Location = new Point(1177, 8);
			//B_EXIT.Name = "B_EXIT";
			//B_EXIT.Size = new Size(39, 40);
			//B_EXIT.TabIndex = 101;
			//B_EXIT.TabStop = false;
			BindingNavigator1.AddNewItem = BindingNavigatorAddNewItem;
			BindingNavigator1.BackColor = Color.White;
			BindingNavigator1.CountItem = BindingNavigatorCountItem;
			BindingNavigator1.DeleteItem = BindingNavigatorDeleteItem;
			BindingNavigator1.Items.AddRange(new ToolStripItem[16]
			{
				BindingNavigatorMoveFirstItem,
				BindingNavigatorMovePreviousItem,
				BindingNavigatorSeparator,
				BindingNavigatorPositionItem,
				BindingNavigatorCountItem,
				BindingNavigatorSeparator1,
				BindingNavigatorMoveNextItem,
				BindingNavigatorMoveLastItem,
				BindingNavigatorSeparator2,
				BindingNavigatorAddNewItem,
				ACCEDEBindingNavigatorSaveItem,
				BindingNavigatorDeleteItem,
				ToolStripSeparator1,
				ToolStripProgressBar2,
				ToolStripButton1,
				ToolStripButton2
			});
			BindingNavigator1.Location = new Point(0, 28);
			BindingNavigator1.MoveFirstItem = BindingNavigatorMoveFirstItem;
			BindingNavigator1.MoveLastItem = BindingNavigatorMoveLastItem;
			BindingNavigator1.MoveNextItem = BindingNavigatorMoveNextItem;
			BindingNavigator1.MovePreviousItem = BindingNavigatorMovePreviousItem;
			BindingNavigator1.Name = "BindingNavigator1";
			BindingNavigator1.PositionItem = BindingNavigatorPositionItem;
			BindingNavigator1.Size = new Size(1350, 25);
			BindingNavigator1.TabIndex = 3;
			BindingNavigator1.Text = "BindingNavigator1";
			BindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorAddNewItem.Image");
			BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
			BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorAddNewItem.Size = new Size(23, 22);
			BindingNavigatorAddNewItem.Text = "Add new";
			BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
			BindingNavigatorCountItem.Size = new Size(37, 22);
			BindingNavigatorCountItem.Text = "de {0}";
			BindingNavigatorCountItem.ToolTipText = "Total number of items";
			BindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorDeleteItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorDeleteItem.Image");
			BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
			BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorDeleteItem.Size = new Size(23, 22);
			BindingNavigatorDeleteItem.Text = "Delete";
			BindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorMoveFirstItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorMoveFirstItem.Image");
			BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
			BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorMoveFirstItem.Size = new Size(23, 22);
			BindingNavigatorMoveFirstItem.Text = "Move first";
			BindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorMovePreviousItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorMovePreviousItem.Image");
			BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
			BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorMovePreviousItem.Size = new Size(23, 22);
			BindingNavigatorMovePreviousItem.Text = "Move previous";
			BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
			BindingNavigatorSeparator.Size = new Size(6, 25);
			BindingNavigatorPositionItem.AccessibleName = "Position";
			BindingNavigatorPositionItem.AutoSize = false;
			BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
			BindingNavigatorPositionItem.Size = new Size(37, 21);
			BindingNavigatorPositionItem.Text = "0";
			BindingNavigatorPositionItem.ToolTipText = "Current position";
			BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
			BindingNavigatorSeparator1.Size = new Size(6, 25);
			BindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorMoveNextItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorMoveNextItem.Image");
			BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
			BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorMoveNextItem.Size = new Size(23, 22);
			BindingNavigatorMoveNextItem.Text = "Move next";
			BindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//BindingNavigatorMoveLastItem.Image = (Image)componentResourceManager.GetObject("BindingNavigatorMoveLastItem.Image");
			BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
			BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			BindingNavigatorMoveLastItem.Size = new Size(23, 22);
			BindingNavigatorMoveLastItem.Text = "Move last";
			BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
			BindingNavigatorSeparator2.Size = new Size(6, 25);
			ACCEDEBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//ACCEDEBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("ACCEDEBindingNavigatorSaveItem.Image");
			ACCEDEBindingNavigatorSaveItem.Name = "ACCEDEBindingNavigatorSaveItem";
			ACCEDEBindingNavigatorSaveItem.Size = new Size(23, 22);
			ACCEDEBindingNavigatorSaveItem.Text = "Save Data";
			ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripSeparator1.Size = new Size(6, 25);
			ToolStripProgressBar2.Name = "ToolStripProgressBar2";
			ToolStripProgressBar2.Size = new Size(100, 22);
			ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//ToolStripButton1.Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			ToolStripButton1.ImageTransparentColor = Color.Magenta;
			ToolStripButton1.Name = "ToolStripButton1";
			ToolStripButton1.Size = new Size(23, 22);
			ToolStripButton1.Text = "ToolStripButton1";
			ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			//ToolStripButton2.Image = (Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			ToolStripButton2.ImageTransparentColor = Color.Magenta;
			ToolStripButton2.Name = "ToolStripButton2";
			ToolStripButton2.Size = new Size(23, 22);
			ToolStripButton2.Text = "ToolStripButton2";
			B_Accueil.BackColor = Color.Transparent;
			//B_Accueil.BackgroundImage = (Image)componentResourceManager.GetObject("B_Accueil.BackgroundImage");
			B_Accueil.BackgroundImageLayout = ImageLayout.Stretch;
			B_Accueil.Cursor = Cursors.Hand;
			B_Accueil.Location = new Point(1270, 217);
			B_Accueil.Name = "B_Accueil";
			B_Accueil.Size = new Size(79, 90);
			B_Accueil.TabIndex = 102;
			B_Accueil.TabStop = false;
			B_Accueil.UseVisualStyleBackColor = false;
			ProgressBar1.Location = new Point(284, 30);
			ProgressBar1.Name = "ProgressBar1";
			ProgressBar1.Size = new Size(100, 23);
			ProgressBar1.TabIndex = 7;
			Imprim_ecran.Cursor = Cursors.Hand;
			Imprim_ecran.ForeColor = SystemColors.ActiveCaptionText;
			Imprim_ecran.Location = new Point(1260, 308);
			Imprim_ecran.Name = "Imprim_ecran";
			Imprim_ecran.Size = new Size(98, 31);
			Imprim_ecran.TabIndex = 103;
			Imprim_ecran.TabStop = false;
			Imprim_ecran.Text = "Imprim écran";
			Imprim_ecran.UseVisualStyleBackColor = true;
			OFGSelectImage1.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP";
			Decon.BackColor = SystemColors.ControlLightLight;
			Decon.Cursor = Cursors.Hand;
			Decon.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Decon.ForeColor = SystemColors.ActiveCaptionText;
			//Decon.Image = Resources.logoff_15259;
			Decon.ImageAlign = ContentAlignment.MiddleLeft;
			Decon.Location = new Point(1236, 4);
			Decon.Name = "Decon";
			Decon.Size = new Size(113, 48);
			Decon.TabIndex = 104;
			Decon.TabStop = false;
			Decon.Text = "Déconnexion";
			Decon.TextAlign = ContentAlignment.MiddleRight;
			Decon.UseVisualStyleBackColor = false;
			statusStrip1.BackColor = SystemColors.ControlLight;
			statusStrip1.Items.AddRange(new ToolStripItem[8]
			{
				User_Screen,
				toolStripStatusLabel3,
				toolStripStatusLabel2,
				toolStripProgressBar1,
				toolStripStatusLabel5,
				NOM_SOC,
				ToolStripStatusLabel6,
				timer
			});
			statusStrip1.Location = new Point(0, 717);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1350, 24);
			statusStrip1.TabIndex = 108;
			statusStrip1.Text = "statusStrip1";
			User_Screen.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			User_Screen.ForeColor = Color.Navy;
			User_Screen.Name = "User_Screen";
			User_Screen.Size = new Size(52, 19);
			User_Screen.Text = "User:";
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(76, 19);
			toolStripStatusLabel3.Text = "                       ";
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(76, 19);
			toolStripStatusLabel2.Text = "                       ";
			toolStripProgressBar1.Name = "toolStripProgressBar1";
			toolStripProgressBar1.Size = new Size(100, 18);
			toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			toolStripStatusLabel5.Size = new Size(76, 19);
			toolStripStatusLabel5.Text = "                       ";
			NOM_SOC.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			NOM_SOC.ForeColor = Color.Navy;
			NOM_SOC.Name = "NOM_SOC";
			NOM_SOC.Size = new Size(115, 19);
			NOM_SOC.Text = "Nom société:";
			ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
			ToolStripStatusLabel6.Size = new Size(76, 19);
			ToolStripStatusLabel6.Text = "                       ";
			timer.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			timer.ForeColor = SystemColors.HotTrack;
			timer.Name = "timer";
			timer.Size = new Size(50, 19);
			timer.Text = "Time";
			PictureBox1.BackColor = Color.White;
			PictureBox1.Cursor = Cursors.Hand;
			//PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox1.Location = new Point(845, 0);
			PictureBox1.Margin = new Padding(3, 4, 3, 4);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(68, 48);
			PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 109;
			PictureBox1.TabStop = false;
			PictureBox1.Visible = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			//BackgroundImage = Resources.arrière_plan_blanc_V2;
			BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(1350, 741);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(statusStrip1);
			base.Controls.Add(Decon);
			base.Controls.Add(B_EXIT);
			base.Controls.Add(BindingNavigator1);
			base.Controls.Add(Imprim_ecran);
			base.Controls.Add(ProgressBar1);
			base.Controls.Add(B_Accueil);
			base.Controls.Add(image_accueil);
			base.Controls.Add(MenuStrip1);
			Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = MenuStrip1;
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Accueil";
			Text = "Accueil";
			MenuStrip1.ResumeLayout(false);
			MenuStrip1.PerformLayout();
			((ISupportInitialize)image_accueil).EndInit();
			((ISupportInitialize)BindingNavigator1).EndInit();
			BindingNavigator1.ResumeLayout(false);
			BindingNavigator1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			((ISupportInitialize)PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void EntréeStockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
		}

		private void SortieStockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
			MyProject.Forms.Gestion_Article_Com.FlagNew = Conversions.ToInteger("1");
		}

		private void AfficherToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
		}

		private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Ajout_entree_Stock.Show();
			MyProject.Forms.Ajout_entree_Stock.BringToFront();
		}

		private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
			MessageBox.Show("Double click sur la ligne à modifier");
		}

		private void QuitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void QuitterToutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir femer toutes les fenêtres ouvertes?", "Fermeture?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Application.Exit();
			}
		}

		private void AfficherToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
			MyProject.Forms.Sortie_Stock.BringToFront();
		}

		private void ModifierToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
			MyProject.Forms.Sortie_Stock.BringToFront();
			MessageBox.Show("Double click sur la ligne à modifier");
		}

		private void AjouterToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Ajout_sortie_Stock.Show();
			MyProject.Forms.Ajout_sortie_Stock.BringToFront();
		}

		private void AjouterToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.info_perso.Show();
			MyProject.Forms.info_perso.BringToFront();
		}

		private void ModifierToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Modif_info_perso.Show();
			MyProject.Forms.Modif_info_perso.BringToFront();
		}

		private void AfficherToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Affich_membres.Show();
			MyProject.Forms.Affich_membres.BringToFront();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			timer.Text = Strings.Format(DateAndTime.Now, "dd/MM/yyyy   HH:mm:ss");
			if (ProgressBar1.Value == ProgressBar1.Maximum)
			{
				Timer1.Enabled = false;
			}
			else
			{
				ProgressBar1.Value = checked(ProgressBar1.Value + 1);
			}
		}

		private void Accueil_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		public void Accueil_Load(object sender, EventArgs e)
		{
			try
			{
				AutoSize = false;
				base.WindowState = FormWindowState.Maximized;
				Screen.FromControl(this);
				Timer1.Start();
				Globals.Societe();
				NOM_SOC.Text = "Société: " + Globals.NOMSOC;
				User_Screen.Text = "User: " + Globals.Utilisateur;
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
			}
		}

		private void AjouterUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_User.Show();
			MyProject.Forms.Gestion_User.BringToFront();
		}

		private void B_EXIT_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir femer toutes les fenêtres ouvertes?", "Fermeture?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Application.Exit();
			}
		}

		private void MajClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
		}

		private void HistoriqueClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Client.Show();
			MyProject.Forms.Histo_Client.BringToFront();
		}

		private void HistoriqueArticleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Article.Show();
			MyProject.Forms.Histo_Article.BringToFront();
		}

		private void MajFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
			MyProject.Forms.Gestion_Fourn.BringToFront();
		}

		private void HistoriqueFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.BringToFront();
		}

		private void EvolutionStockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Stat_Stock.Show();
			MyProject.Forms.Stat_Stock.BringToFront();
		}

		private void CalendrierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Affich_Calendar.Show();
			MyProject.Forms.Affich_Calendar.BringToFront();
		}

		private void VenteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Vente.Show();
			MyProject.Forms.Gestion_Vente.LB_Article.SelectedItem = "Article Montée";
			MyProject.Forms.Gestion_Vente.GB_MONT.Visible = true;
			MyProject.Forms.Gestion_Vente.GB_COM.Visible = false;
			MyProject.Forms.Gestion_Vente.BringToFront();
			MyProject.Forms.Gestion_Vente.REFART.Focus();
		}

		private void HistoriqqToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Vente.TABLEFACT = "TICKET";
			MyProject.Forms.Histo_Vente.TABLEDF = "VENTE";
			MyProject.Forms.Histo_Vente.Show();
			MyProject.Forms.Histo_Vente.BringToFront();
		}

		private void ACCEDEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
		}

		private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
		{
			base.Validate();
		}

		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			base.Validate();
		}

		public void ImprimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CaptureScreen();
			PrintDocument1.Print();
		}

		[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

		private void CaptureScreen()
		{
			Graphics graphics = base.CreateGraphics();
			Size size = base.Size;
			memoryImage = new Bitmap(size.Width, size.Height, graphics);
			Graphics graphics2 = Graphics.FromImage(memoryImage);
			IntPtr hdc = graphics.GetHdc();
			IntPtr hdc2 = graphics2.GetHdc();
			IntPtr hdcDest = hdc2;
			Rectangle clientRectangle = base.ClientRectangle;
			int width = clientRectangle.Width;
			clientRectangle = base.ClientRectangle;
			BitBlt(hdcDest, 0, 0, width, clientRectangle.Height, hdc, 0, 0, 13369376);
			graphics.ReleaseHdc(hdc);
			graphics2.ReleaseHdc(hdc2);
		}

		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void PrintDocument1_EndPrint(object sender, PrintEventArgs e)
		{
			MessageBox.Show("Fin d'impression");
		}

		private void CalculatriceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\WINDOWS\\system32\\calc.exe");
		}

		private void DétailsArticleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
			MyProject.Forms.Gestion_Article_Com.LB_Article.SelectedItem = "Article Commercial";
		}

		private void InforamtionsSociétéToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Info_Societe.Show();
			MyProject.Forms.Info_Societe.BringToFront();
		}

		private void B_Accueil_Click(object sender, EventArgs e)
		{
			Timer1.Enabled = true;
			MyProject.Forms.FrmAccueil.Show();
			MyProject.Forms.FrmAccueil.BringToFront();
		}

		private void VenteCommercialeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Vente.Show();
			MyProject.Forms.Gestion_Vente.LB_Article.SelectedItem = "Article Commercial";
			MyProject.Forms.Gestion_Vente.GB_MONT.Visible = false;
			MyProject.Forms.Gestion_Vente.GB_COM.Visible = true;
			MyProject.Forms.Gestion_Vente.BringToFront();
			MyProject.Forms.Gestion_Vente.REFART_C.Focus();
		}

		private void AfficherToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
			MyProject.Forms.Gestion_stock.BringToFront();
		}

		private void CréerUnDevisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact1.TYPEFACT = "D";
			//Globals.Ajout_Fact1.Show();
			//Globals.Ajout_Fact1.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact1);
			//Globals.ClearComboBox(Globals.Ajout_Fact1);
			//Globals.Ajout_Fact1.HISTOCLIENT.Visible = true;
		}

		private void CréerUnBonDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact2.TYPEFACT = "BC";
			//Globals.Ajout_Fact2.Show();
			//Globals.Ajout_Fact2.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact2);
			//Globals.ClearComboBox(Globals.Ajout_Fact2);
			//Globals.Ajout_Fact2.HISTOCLIENT.Visible = true;
		}

		private void CréerUnBonDeLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact3.TYPEFACT = "BL";
			//Globals.Ajout_Fact3.Show();
			//Globals.Ajout_Fact3.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact3);
			//Globals.ClearComboBox(Globals.Ajout_Fact3);
			//Globals.Ajout_Fact3.HISTOCLIENT.Visible = true;
		}

		private void MajFacturationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "TICKET";
			histo_Fact.TABLEDF = "VENTE";
			histo_Fact.REGLEMENT0 = "mode_regl Reglement,(montant_regl-totalttc_fact) Rendu";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.Show();
			histo_Fact.BringToFront();
			histo_Fact.Reg_Multi.Visible = true;
		}

		private void HistoDevisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "DEVIS";
			histo_Fact.TABLEDF = "DETAIL_DEVIS";
			histo_Fact.Text = "Historique Devis";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.Button2.Visible = true;
			histo_Fact.Label4.Visible = true;
			histo_Fact.Button4.Visible = true;
			histo_Fact.Label6.Visible = true;
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void HistoBonCdeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "BONC";
			histo_Fact.TABLEDF = "DETAIL_BONC";
			histo_Fact.Text = "Historique Bon de commande";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.Button3.Visible = true;
			histo_Fact.Label5.Visible = true;
			histo_Fact.B_BC_BL.Visible = true;
			histo_Fact.Label10.Visible = true;
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void HistoBonLivraisionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "BONL";
			histo_Fact.TABLEDF = "DETAIL_BONL";
			histo_Fact.Text = "Historique Bon de livraison";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.B_BL_Fact.Visible = true;
			histo_Fact.Label11.Visible = true;
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			AfficherToolStripMenuItem1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			AjouterToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			ModifierToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact4.TYPEFACT = "DA";
			//Globals.Ajout_Fact4.FRS.Visible = true;
			//Globals.Ajout_Fact4.LinkLabel2.Visible = true;
			//Globals.Ajout_Fact4.Label29.Visible = true;
			//Globals.Ajout_Fact4.Button1.Visible = true;
			//Globals.Ajout_Fact4.Label1.Visible = true;
			//Globals.Ajout_Fact4.Label3.Visible = true;
			//Globals.Ajout_Fact4.Button2.Visible = true;
			//Globals.Ajout_Fact4.Show();
			//Globals.Ajout_Fact4.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact4);
			//Globals.ClearComboBox(Globals.Ajout_Fact4);
		}

		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact5.TYPEFACT = "BCA";
			//Globals.Ajout_Fact5.FRS.Visible = true;
			//Globals.Ajout_Fact5.LinkLabel2.Visible = true;
			//Globals.Ajout_Fact5.Label29.Visible = true;
			//Globals.Ajout_Fact5.Button1.Visible = true;
			//Globals.Ajout_Fact5.Label1.Visible = true;
			//Globals.Ajout_Fact5.Label3.Visible = true;
			//Globals.Ajout_Fact5.Button2.Visible = true;
			//Globals.Ajout_Fact5.Show();
			//Globals.Ajout_Fact5.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact5);
			//Globals.ClearComboBox(Globals.Ajout_Fact5);
		}

		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact6.TYPEFACT = "BLA";
			//Globals.Ajout_Fact6.FRS.Visible = true;
			//Globals.Ajout_Fact6.LinkLabel2.Visible = true;
			//Globals.Ajout_Fact6.Label29.Visible = true;
			//Globals.Ajout_Fact6.Button1.Visible = true;
			//Globals.Ajout_Fact6.Label1.Visible = true;
			//Globals.Ajout_Fact6.Label3.Visible = true;
			//Globals.Ajout_Fact6.Button2.Visible = true;
			//Globals.Ajout_Fact6.Show();
			//Globals.Ajout_Fact6.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact6);
			//Globals.ClearComboBox(Globals.Ajout_Fact6);
		}

		private void CréerUnFactureAchatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Globals.Ajout_Fact7.TYPEFACT = "FA";
			//Globals.Ajout_Fact7.FRS.Visible = true;
			//Globals.Ajout_Fact7.LinkLabel2.Visible = true;
			//Globals.Ajout_Fact7.Label29.Visible = true;
			//Globals.Ajout_Fact7.Button1.Visible = true;
			//Globals.Ajout_Fact7.Label1.Visible = true;
			//Globals.Ajout_Fact7.Label3.Visible = true;
			//Globals.Ajout_Fact7.Button2.Visible = true;
			//Globals.Ajout_Fact7.Show();
			//Globals.Ajout_Fact7.BringToFront();
			//Globals.ClearTextBox(Globals.Ajout_Fact7);
			//Globals.ClearComboBox(Globals.Ajout_Fact7);
		}

		private void ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "A_FACTURE";
			histo_Fact.TABLEDF = "A_DETAIL_FACTURE";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void ToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "A_DEVIS";
			histo_Fact.TABLEDF = "A_DETAIL_DEVIS";
			histo_Fact.Text = "Historique Devis";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.B_DA_BCA.Visible = true;
			histo_Fact.Label9.Visible = true;
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "A_BONC";
			histo_Fact.TABLEDF = "A_DETAIL_BONC";
			histo_Fact.Text = "Historique Bon de commande";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.B_BC_ES.Visible = true;
			histo_Fact.Label12.Visible = true;
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void ToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "A_BONL";
			histo_Fact.TABLEDF = "A_DETAIL_BONL";
			histo_Fact.Text = "Historique Bon de livraison";
			histo_Fact.REGLEMENT0 = "null R";
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void Accueil_SizeChanged(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
				workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
			}
		}

		private void RésolutionÉcranToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Resolution_ecran.Show();
		}

		private void Deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.WParam.ToInt32() == 13)
			{
				SendKeys.Send("{Tab}");
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void EnvoyerUnMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential("VOTRE_EMAIL_ICI", "VOTRE_MOT_DE_PASSE_ICI");
			try
			{
				smtpClient.Port = 25;
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.EnableSsl = true;
				mailMessage.From = new MailAddress("ADRESSE_DE_LEMETTEUR_ICI");
				mailMessage.To.Add("ADRESSE_DU_DESTINATAIRE_ICI");
				Attachment item = new Attachment("LIEN_DE_LA_PIECE_JOINTE_EVENTUELLE_ICI");
				mailMessage.Attachments.Add(item);
				mailMessage.Subject = "SUJET_DU_MESSAGE_ICI";
				mailMessage.Body = "CONTENU_DU_MESSAGE_ICI";
				smtpClient.Send(mailMessage);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Imprim_ecran_Click(object sender, EventArgs e)
		{
			try
			{
				Rectangle bounds = Screen.PrimaryScreen.Bounds;
				Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppRgb);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
				bitmap.Save("C:\\SIGC utility\\imprim écran\\imprim_écran " + DateTime.Now.ToString("yyyy_MM_dd HH_mm") + ".jpg");
				MessageBox.Show("Imprim écran enregistré dans C:\\SIGC utility\\imprim écran\\");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}

		private void Decon_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir se déconnecter et femer toutes les fenêtres ouvertes?", "Déconnexion?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (dialogResult != DialogResult.No)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						form.Hide();
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				MyProject.Forms.Authent.Show();
				MyProject.Forms.Authent.TextBox1.Text = "";
				MyProject.Forms.Authent.TextBox2.Text = "";
			}
		}

		private void HistoriqueTicketsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "TICKET";
			histo_Fact.TABLEDF = "VENTE";
			histo_Fact.REGLEMENT0 = "mode_regl Reglement,(montant_regl-totalttc_fact) Rendu";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void ChiffreDaffaireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
		}

		private void Top10ArticleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
			stat_CA.CB_Article.Checked = true;
			stat_CA.CB_Frs.Visible = false;
			stat_CA.CB_Client.Visible = false;
		}

		private void FournisseurToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
			stat_CA.CB_Frs.Checked = true;
			stat_CA.CB_Article.Visible = false;
			stat_CA.CB_Client.Visible = false;
		}

		private void ClientToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
			stat_CA.CB_Client.Checked = true;
			stat_CA.CB_Article.Visible = false;
			stat_CA.CB_Frs.Visible = false;
		}

		private void PièceJointeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential("mehdi.gastli@gmail.com", "Gastli83_m");
			try
			{
				smtpClient.Port = 25;
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.EnableSsl = true;
				mailMessage.From = new MailAddress("mehdi.gastli@gmail.com");
				mailMessage.To.Add("mg.essait@gmail.com");
				Attachment item = new Attachment("C:\\SIGC utility\\Fichier joint\\facture.pdf");
				mailMessage.Attachments.Add(item);
				mailMessage.Subject = "Sujet";
				mailMessage.Body = "Veuillez trouver ci-joint...";
				smtpClient.Send(mailMessage);
				MessageBox.Show("Message envoyé avec succès");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("Send failure: " + ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void MailOutlookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Mail.Show();
			MyProject.Forms.Mail.BringToFront();
		}

		private void MailingClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Mail.Show();
			MyProject.Forms.Mail.BringToFront();
		}

		private void AfficherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
			MyProject.Forms.Gestion_stock.BringToFront();
		}

		private void MembresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
		}

		private void SortieStockToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
			MyProject.Forms.Sortie_Stock.BringToFront();
		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.gebisom.com/");
		}
	}
}
