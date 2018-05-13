using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ERP.My
{
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Accueil m_Accueil;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Affich_Calendar m_Affich_Calendar;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Affich_code m_Affich_code;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Affich_code_client m_Affich_code_client;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Affich_ID_FRS m_Affich_ID_FRS;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Affich_membres m_Affich_membres;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ajout_entree_Stock m_Ajout_entree_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ajout_Fact m_Ajout_Fact;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ajout_sortie_Stock m_Ajout_sortie_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ajout_Stock m_Ajout_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Authent m_Authent;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Entree_Stock m_Entree_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Fact m_Frm_Fact;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmAccueil m_FrmAccueil;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmFacture m_FrmFacture;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_Article_Com m_Gestion_Article_Com;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_Article_Mont m_Gestion_Article_Mont;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_Client m_Gestion_Client;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_Fourn m_Gestion_Fourn;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_stock m_Gestion_stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_User m_Gestion_User;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Gestion_Vente m_Gestion_Vente;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Histo_Article m_Histo_Article;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Histo_Client m_Histo_Client;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Histo_Fact m_Histo_Fact;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Histo_Fourn m_Histo_Fourn;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Histo_Vente m_Histo_Vente;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Image_ARTICLE m_Image_ARTICLE;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Imprim_info_perso m_Imprim_info_perso;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public info_perso m_info_perso;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Info_Societe m_Info_Societe;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Mail m_Mail;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Modif_entree_stock m_Modif_entree_stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Modif_Fact m_Modif_Fact;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Modif_info_perso m_Modif_info_perso;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Modif_sortie_stock m_Modif_sortie_stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Modif_Vente m_Modif_Vente;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Reglement m_Reglement;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Resolution_ecran m_Resolution_ecran;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Sortie_Stock m_Sortie_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public stat_CA m_stat_CA;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Stat_Stock m_Stat_Stock;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public test m_test;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Test0 m_Test0;

			public Accueil Accueil
			{
				[DebuggerHidden]
				get
				{
					m_Accueil = Create__Instance__(m_Accueil);
					return m_Accueil;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Accueil)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Accueil);
					}
				}
			}

			public Affich_Calendar Affich_Calendar
			{
				[DebuggerHidden]
				get
				{
					m_Affich_Calendar = Create__Instance__(m_Affich_Calendar);
					return m_Affich_Calendar;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Affich_Calendar)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Affich_Calendar);
					}
				}
			}

			public Affich_code Affich_code
			{
				[DebuggerHidden]
				get
				{
					m_Affich_code = Create__Instance__(m_Affich_code);
					return m_Affich_code;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Affich_code)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Affich_code);
					}
				}
			}

			public Affich_code_client Affich_code_client
			{
				[DebuggerHidden]
				get
				{
					m_Affich_code_client = Create__Instance__(m_Affich_code_client);
					return m_Affich_code_client;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Affich_code_client)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Affich_code_client);
					}
				}
			}

			public Affich_ID_FRS Affich_ID_FRS
			{
				[DebuggerHidden]
				get
				{
					m_Affich_ID_FRS = Create__Instance__(m_Affich_ID_FRS);
					return m_Affich_ID_FRS;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Affich_ID_FRS)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Affich_ID_FRS);
					}
				}
			}

			public Affich_membres Affich_membres
			{
				[DebuggerHidden]
				get
				{
					m_Affich_membres = Create__Instance__(m_Affich_membres);
					return m_Affich_membres;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Affich_membres)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Affich_membres);
					}
				}
			}

			public Ajout_entree_Stock Ajout_entree_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Ajout_entree_Stock = Create__Instance__(m_Ajout_entree_Stock);
					return m_Ajout_entree_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Ajout_entree_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Ajout_entree_Stock);
					}
				}
			}

			public Ajout_Fact Ajout_Fact
			{
				[DebuggerHidden]
				get
				{
					m_Ajout_Fact = Create__Instance__(m_Ajout_Fact);
					return m_Ajout_Fact;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Ajout_Fact)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Ajout_Fact);
					}
				}
			}

			public Ajout_sortie_Stock Ajout_sortie_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Ajout_sortie_Stock = Create__Instance__(m_Ajout_sortie_Stock);
					return m_Ajout_sortie_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Ajout_sortie_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Ajout_sortie_Stock);
					}
				}
			}

			public Ajout_Stock Ajout_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Ajout_Stock = Create__Instance__(m_Ajout_Stock);
					return m_Ajout_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Ajout_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Ajout_Stock);
					}
				}
			}

			public Authent Authent
			{
				[DebuggerHidden]
				get
				{
					m_Authent = Create__Instance__(m_Authent);
					return m_Authent;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Authent)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Authent);
					}
				}
			}

			public Entree_Stock Entree_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Entree_Stock = Create__Instance__(m_Entree_Stock);
					return m_Entree_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Entree_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Entree_Stock);
					}
				}
			}

			public Frm_Fact Frm_Fact
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Fact = Create__Instance__(m_Frm_Fact);
					return m_Frm_Fact;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Fact)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Fact);
					}
				}
			}

			public FrmAccueil FrmAccueil
			{
				[DebuggerHidden]
				get
				{
					m_FrmAccueil = Create__Instance__(m_FrmAccueil);
					return m_FrmAccueil;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_FrmAccueil)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_FrmAccueil);
					}
				}
			}

			public FrmFacture FrmFacture
			{
				[DebuggerHidden]
				get
				{
					m_FrmFacture = Create__Instance__(m_FrmFacture);
					return m_FrmFacture;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_FrmFacture)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_FrmFacture);
					}
				}
			}

			public Gestion_Article_Com Gestion_Article_Com
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_Article_Com = Create__Instance__(m_Gestion_Article_Com);
					return m_Gestion_Article_Com;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_Article_Com)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_Article_Com);
					}
				}
			}

			public Gestion_Article_Mont Gestion_Article_Mont
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_Article_Mont = Create__Instance__(m_Gestion_Article_Mont);
					return m_Gestion_Article_Mont;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_Article_Mont)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_Article_Mont);
					}
				}
			}

			public Gestion_Client Gestion_Client
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_Client = Create__Instance__(m_Gestion_Client);
					return m_Gestion_Client;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_Client)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_Client);
					}
				}
			}

			public Gestion_Fourn Gestion_Fourn
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_Fourn = Create__Instance__(m_Gestion_Fourn);
					return m_Gestion_Fourn;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_Fourn)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_Fourn);
					}
				}
			}

			public Gestion_stock Gestion_stock
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_stock = Create__Instance__(m_Gestion_stock);
					return m_Gestion_stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_stock);
					}
				}
			}

			public Gestion_User Gestion_User
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_User = Create__Instance__(m_Gestion_User);
					return m_Gestion_User;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_User)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_User);
					}
				}
			}

			public Gestion_Vente Gestion_Vente
			{
				[DebuggerHidden]
				get
				{
					m_Gestion_Vente = Create__Instance__(m_Gestion_Vente);
					return m_Gestion_Vente;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Gestion_Vente)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Gestion_Vente);
					}
				}
			}

			public Histo_Article Histo_Article
			{
				[DebuggerHidden]
				get
				{
					m_Histo_Article = Create__Instance__(m_Histo_Article);
					return m_Histo_Article;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Histo_Article)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Histo_Article);
					}
				}
			}

			public Histo_Client Histo_Client
			{
				[DebuggerHidden]
				get
				{
					m_Histo_Client = Create__Instance__(m_Histo_Client);
					return m_Histo_Client;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Histo_Client)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Histo_Client);
					}
				}
			}

			public Histo_Fact Histo_Fact
			{
				[DebuggerHidden]
				get
				{
					m_Histo_Fact = Create__Instance__(m_Histo_Fact);
					return m_Histo_Fact;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Histo_Fact)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Histo_Fact);
					}
				}
			}

			public Histo_Fourn Histo_Fourn
			{
				[DebuggerHidden]
				get
				{
					m_Histo_Fourn = Create__Instance__(m_Histo_Fourn);
					return m_Histo_Fourn;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Histo_Fourn)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Histo_Fourn);
					}
				}
			}

			public Histo_Vente Histo_Vente
			{
				[DebuggerHidden]
				get
				{
					m_Histo_Vente = Create__Instance__(m_Histo_Vente);
					return m_Histo_Vente;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Histo_Vente)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Histo_Vente);
					}
				}
			}

			public Image_ARTICLE Image_ARTICLE
			{
				[DebuggerHidden]
				get
				{
					m_Image_ARTICLE = Create__Instance__(m_Image_ARTICLE);
					return m_Image_ARTICLE;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Image_ARTICLE)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Image_ARTICLE);
					}
				}
			}

			public Imprim_info_perso Imprim_info_perso
			{
				[DebuggerHidden]
				get
				{
					m_Imprim_info_perso = Create__Instance__(m_Imprim_info_perso);
					return m_Imprim_info_perso;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Imprim_info_perso)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Imprim_info_perso);
					}
				}
			}

			public info_perso info_perso
			{
				[DebuggerHidden]
				get
				{
					m_info_perso = Create__Instance__(m_info_perso);
					return m_info_perso;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_info_perso)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_info_perso);
					}
				}
			}

			public Info_Societe Info_Societe
			{
				[DebuggerHidden]
				get
				{
					m_Info_Societe = Create__Instance__(m_Info_Societe);
					return m_Info_Societe;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Info_Societe)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Info_Societe);
					}
				}
			}

			public Mail Mail
			{
				[DebuggerHidden]
				get
				{
					m_Mail = Create__Instance__(m_Mail);
					return m_Mail;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Mail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Mail);
					}
				}
			}

			public Modif_entree_stock Modif_entree_stock
			{
				[DebuggerHidden]
				get
				{
					m_Modif_entree_stock = Create__Instance__(m_Modif_entree_stock);
					return m_Modif_entree_stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Modif_entree_stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Modif_entree_stock);
					}
				}
			}

			public Modif_Fact Modif_Fact
			{
				[DebuggerHidden]
				get
				{
					m_Modif_Fact = Create__Instance__(m_Modif_Fact);
					return m_Modif_Fact;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Modif_Fact)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Modif_Fact);
					}
				}
			}

			public Modif_info_perso Modif_info_perso
			{
				[DebuggerHidden]
				get
				{
					m_Modif_info_perso = Create__Instance__(m_Modif_info_perso);
					return m_Modif_info_perso;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Modif_info_perso)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Modif_info_perso);
					}
				}
			}

			public Modif_sortie_stock Modif_sortie_stock
			{
				[DebuggerHidden]
				get
				{
					m_Modif_sortie_stock = Create__Instance__(m_Modif_sortie_stock);
					return m_Modif_sortie_stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Modif_sortie_stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Modif_sortie_stock);
					}
				}
			}

			public Modif_Vente Modif_Vente
			{
				[DebuggerHidden]
				get
				{
					m_Modif_Vente = Create__Instance__(m_Modif_Vente);
					return m_Modif_Vente;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Modif_Vente)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Modif_Vente);
					}
				}
			}

			public Reglement Reglement
			{
				[DebuggerHidden]
				get
				{
					m_Reglement = Create__Instance__(m_Reglement);
					return m_Reglement;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Reglement)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Reglement);
					}
				}
			}

			public Resolution_ecran Resolution_ecran
			{
				[DebuggerHidden]
				get
				{
					m_Resolution_ecran = Create__Instance__(m_Resolution_ecran);
					return m_Resolution_ecran;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Resolution_ecran)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Resolution_ecran);
					}
				}
			}

			public Sortie_Stock Sortie_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Sortie_Stock = Create__Instance__(m_Sortie_Stock);
					return m_Sortie_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Sortie_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Sortie_Stock);
					}
				}
			}

			public stat_CA stat_CA
			{
				[DebuggerHidden]
				get
				{
					m_stat_CA = Create__Instance__(m_stat_CA);
					return m_stat_CA;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_stat_CA)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_stat_CA);
					}
				}
			}

			public Stat_Stock Stat_Stock
			{
				[DebuggerHidden]
				get
				{
					m_Stat_Stock = Create__Instance__(m_Stat_Stock);
					return m_Stat_Stock;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Stat_Stock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Stat_Stock);
					}
				}
			}

			public test test
			{
				[DebuggerHidden]
				get
				{
					m_test = Create__Instance__(m_test);
					return m_test;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_test)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_test);
					}
				}
			}

			public Test0 Test0
			{
				[DebuggerHidden]
				get
				{
					m_Test0 = Create__Instance__(m_Test0);
					return m_Test0;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Test0)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Test0);
					}
				}
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance?.IsDisposed ?? true)
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) //when (/*OpCode not supported: BlockContainer*/)
					{
						TargetInvocationException ex2;
						//string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex2.InnerException.Message);
						//throw new InvalidOperationException(resourceString, ex2.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = null;
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
