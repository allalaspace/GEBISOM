using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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
	public class Frm_Fact : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NUMFACT")]
		private ComboBox _NUMFACT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CRV")]
		private CrystalReportViewer _CRV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nom_mail")]
		private Label _Nom_mail;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TIMBRE")]
		private CheckBox _TIMBRE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REMISE")]
		private CheckBox _REMISE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LB_Article")]
		private ListBox _LB_Article;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TIMVAL")]
		private TextBox _TIMVAL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REMVAL")]
		private TextBox _REMVAL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("BtnPrint")]
		private Button _BtnPrint;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnValid")]
		private Button _btnValid;

		public string TYPEFACT;

		public string TABLEFACT;

		public string PARAMFACT;

		public string CHEMINRPT;

		public string Nommail;

		public string NOMFICHJOINT;

		public string PROFIL;

		private ReportDocument cryRpt;

		internal virtual ComboBox NUMFACT
		{
			[CompilerGenerated]
			get
			{
				return _NUMFACT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = NUMFACT_Click;
				ComboBox nUMFACT = _NUMFACT;
				if (nUMFACT != null)
				{
					nUMFACT.Click -= value2;
				}
				_NUMFACT = value;
				nUMFACT = _NUMFACT;
				if (nUMFACT != null)
				{
					nUMFACT.Click += value2;
				}
			}
		}

		internal virtual CrystalReportViewer CRV
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

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Label Nom_mail
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox TIMBRE
		{
			[CompilerGenerated]
			get
			{
				return _TIMBRE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TIMBRE_CheckedChanged;
				CheckBox tIMBRE = _TIMBRE;
				if (tIMBRE != null)
				{
					tIMBRE.CheckedChanged -= value2;
				}
				_TIMBRE = value;
				tIMBRE = _TIMBRE;
				if (tIMBRE != null)
				{
					tIMBRE.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox REMISE
		{
			[CompilerGenerated]
			get
			{
				return _REMISE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = REMISE_CheckedChanged;
				CheckBox rEMISE = _REMISE;
				if (rEMISE != null)
				{
					rEMISE.CheckedChanged -= value2;
				}
				_REMISE = value;
				rEMISE = _REMISE;
				if (rEMISE != null)
				{
					rEMISE.CheckedChanged += value2;
				}
			}
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

		internal virtual TextBox TIMVAL
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox REMVAL
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button BtnPrint
		{
			[CompilerGenerated]
			get
			{
				return _BtnPrint;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = BtnPrint_Click;
				Button btnPrint = _BtnPrint;
				if (btnPrint != null)
				{
					btnPrint.Click -= value2;
				}
				_BtnPrint = value;
				btnPrint = _BtnPrint;
				if (btnPrint != null)
				{
					btnPrint.Click += value2;
				}
			}
		}

		internal virtual Button btnValid
		{
			[CompilerGenerated]
			get
			{
				return _btnValid;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnValid_Click;
				Button btnValid = _btnValid;
				if (btnValid != null)
				{
					btnValid.Click -= value2;
				}
				_btnValid = value;
				btnValid = _btnValid;
				if (btnValid != null)
				{
					btnValid.Click += value2;
				}
			}
		}

		public Frm_Fact()
		{
			base.Load += Frm_Fact_Load;
			PROFIL = "0";
			cryRpt = new ReportDocument();
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
			NUMFACT = new ComboBox();
			CRV = new CrystalReportViewer();
			Button1 = new Button();
			Label1 = new Label();
			Button5 = new Button();
			Nom_mail = new Label();
			TIMBRE = new CheckBox();
			REMISE = new CheckBox();
			LB_Article = new ListBox();
			TIMVAL = new TextBox();
			REMVAL = new TextBox();
			BtnPrint = new Button();
			btnValid = new Button();
			base.SuspendLayout();
			NUMFACT.FormattingEnabled = true;
			NUMFACT.Location = new Point(199, 75);
			NUMFACT.Name = "NUMFACT";
			NUMFACT.Size = new Size(153, 24);
			NUMFACT.TabIndex = 12;
			CRV.ActiveViewIndex = -1;
			CRV.BorderStyle = BorderStyle.FixedSingle;
			CRV.Cursor = Cursors.Default;
			CRV.Location = new Point(38, 134);
			CRV.Name = "CRV";
			CRV.Size = new Size(1196, 542);
			CRV.TabIndex = 11;
			Button1.BackColor = SystemColors.ButtonHighlight;
			Button1.Cursor = Cursors.Hand;
			Button1.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 178);
			Button1.ForeColor = SystemColors.ActiveCaptionText;
			Button1.Image = Resources.Button_Refresh_icon;
			Button1.ImageAlign = ContentAlignment.MiddleLeft;
			Button1.Location = new Point(786, 65);
			Button1.Name = "Button1";
			Button1.Size = new Size(170, 55);
			Button1.TabIndex = 10;
			Button1.Text = "Afficher Devis";
			Button1.TextAlign = ContentAlignment.MiddleRight;
			Button1.UseVisualStyleBackColor = false;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(12, 78);
			Label1.Name = "Label1";
			Label1.Size = new Size(181, 18);
			Label1.TabIndex = 9;
			Label1.Text = "Entrer Num Devis";
			Button5.BackgroundImage = Resources.Envoyer;
			Button5.Cursor = Cursors.Hand;
			Button5.Location = new Point(1171, 56);
			Button5.Name = "Button5";
			Button5.Size = new Size(63, 73);
			Button5.TabIndex = 119;
			Button5.UseVisualStyleBackColor = true;
			Nom_mail.BackColor = Color.Transparent;
			Nom_mail.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Nom_mail.Location = new Point(226, 111);
			Nom_mail.Name = "Nom_mail";
			Nom_mail.Size = new Size(158, 18);
			Nom_mail.TabIndex = 120;
			Nom_mail.Text = "N";
			Nom_mail.Visible = false;
			TIMBRE.AutoSize = true;
			TIMBRE.BackColor = Color.Transparent;
			TIMBRE.Cursor = Cursors.Hand;
			TIMBRE.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			TIMBRE.Location = new Point(376, 75);
			TIMBRE.Name = "TIMBRE";
			TIMBRE.Size = new Size(81, 23);
			TIMBRE.TabIndex = 121;
			TIMBRE.Text = "Timbre";
			TIMBRE.UseVisualStyleBackColor = false;
			REMISE.AutoSize = true;
			REMISE.BackColor = Color.Transparent;
			REMISE.Cursor = Cursors.Hand;
			REMISE.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			REMISE.Location = new Point(525, 75);
			REMISE.Name = "REMISE";
			REMISE.Size = new Size(85, 23);
			REMISE.TabIndex = 122;
			REMISE.Text = "Remise";
			REMISE.UseVisualStyleBackColor = false;
			LB_Article.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			LB_Article.FormattingEnabled = true;
			LB_Article.ItemHeight = 18;
			LB_Article.Items.AddRange(new object[2]
			{
				"Profil Nb",
				"Profil TN"
			});
			LB_Article.Location = new Point(644, 75);
			LB_Article.Name = "LB_Article";
			LB_Article.Size = new Size(113, 40);
			LB_Article.TabIndex = 123;
			LB_Article.TabStop = false;
			TIMVAL.Location = new Point(355, 104);
			TIMVAL.Name = "TIMVAL";
			TIMVAL.Size = new Size(116, 22);
			TIMVAL.TabIndex = 124;
			TIMVAL.Visible = false;
			REMVAL.Location = new Point(506, 104);
			REMVAL.Name = "REMVAL";
			REMVAL.Size = new Size(116, 22);
			REMVAL.TabIndex = 125;
			REMVAL.Visible = false;
			BtnPrint.Location = new Point(21, 99);
			BtnPrint.Name = "BtnPrint";
			BtnPrint.Size = new Size(63, 30);
			BtnPrint.TabIndex = 126;
			BtnPrint.Text = "BtnPrint";
			BtnPrint.UseVisualStyleBackColor = true;
			BtnPrint.Visible = false;
			btnValid.BackColor = Color.White;
			btnValid.Cursor = Cursors.Hand;
			btnValid.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnValid.Image = Resources.Save_icon;
			btnValid.ImageAlign = ContentAlignment.MiddleLeft;
			btnValid.Location = new Point(987, 65);
			btnValid.Name = "btnValid";
			btnValid.Size = new Size(142, 55);
			btnValid.TabIndex = 127;
			btnValid.Text = "Valider Facture";
			btnValid.TextAlign = ContentAlignment.MiddleRight;
			btnValid.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(btnValid);
			base.Controls.Add(BtnPrint);
			base.Controls.Add(REMVAL);
			base.Controls.Add(TIMVAL);
			base.Controls.Add(LB_Article);
			base.Controls.Add(REMISE);
			base.Controls.Add(TIMBRE);
			base.Controls.Add(Nom_mail);
			base.Controls.Add(Button5);
			base.Controls.Add(CRV);
			base.Controls.Add(Button1);
			base.Controls.Add(Label1);
			base.Controls.Add(NUMFACT);
			base.Location = new Point(0, 0);
			base.Name = "Frm_Fact";
			Text = "Devis";
			base.Controls.SetChildIndex(NUMFACT, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(CRV, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.Controls.SetChildIndex(Nom_mail, 0);
			base.Controls.SetChildIndex(TIMBRE, 0);
			base.Controls.SetChildIndex(REMISE, 0);
			base.Controls.SetChildIndex(LB_Article, 0);
			base.Controls.SetChildIndex(TIMVAL, 0);
			base.Controls.SetChildIndex(REMVAL, 0);
			base.Controls.SetChildIndex(BtnPrint, 0);
			base.Controls.SetChildIndex(btnValid, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				cryRpt.Load(CHEMINRPT);
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = true;
				connectionInfo2 = null;
				TableLogOnInfos tableLogOnInfos = new TableLogOnInfos();
				TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
				Tables tables = cryRpt.Database.Tables;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = tables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Table table = (Table)enumerator.Current;
						tableLogOnInfo = table.LogOnInfo;
						tableLogOnInfo.ConnectionInfo = connectionInfo;
						table.ApplyLogOnInfo(tableLogOnInfo);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				cryRpt.SetParameterValue(PARAMFACT, NUMFACT.Text);
				cryRpt.SetParameterValue("REMISEPARAM", Globals.convertDN(REMVAL.Text));
				cryRpt.SetParameterValue("TIMBREPARAM", Globals.convertDN(TIMVAL.Text));
				cryRpt.SetParameterValue("Profil_Adresse", PROFIL);
				CRV.ReportSource = cryRpt;
				CRV.Refresh();
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

		public void Frm_Fact_Load(object sender, EventArgs e)
		{
			try
			{
				LB_Article.SelectedItem = "Profil Nb";
				if (Operators.CompareString(TYPEFACT, "D", false) == 0)
				{
					PARAMFACT = "NUMDEVIS";
					TABLEFACT = "DEVIS";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_Devis.rpt";
					Label1.Text = "Entrer Num Devis";
					Button1.Text = "Afficher Devis";
					Nommail = "Devis";
					Text = "Devis";
				}
				else if (Operators.CompareString(TYPEFACT, "F", false) == 0)
				{
					PARAMFACT = "NUMTICKET";
					TABLEFACT = "TICKET";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_Facture.rpt";
					Label1.Text = "Entrer Num Facture";
					Button1.Text = "Afficher Facture";
					Text = "Facture";
					Nommail = "Facture";
				}
				else if (Operators.CompareString(TYPEFACT, "TIC", false) == 0)
				{
					PARAMFACT = "NUMTICKET";
					TABLEFACT = "TICKET";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_Ticket.rpt";
					Label1.Text = "Entrer Num Ticket";
					Button1.Text = "Afficher Ticket";
					Text = "Ticket";
					Nommail = "Ticket";
				}
				else if (Operators.CompareString(TYPEFACT, "BC", false) == 0)
				{
					PARAMFACT = "NUMBC";
					TABLEFACT = "BONC";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_BC.rpt";
					Label1.Text = "Entrer Num Bon C.";
					Button1.Text = "Afficher Bon C.";
					Text = "Bon Commande";
					Nommail = "BC";
				}
				else if (Operators.CompareString(TYPEFACT, "BL", false) == 0)
				{
					PARAMFACT = "NUMBL";
					TABLEFACT = "BONL";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_BL.rpt";
					Label1.Text = "Entrer Num Bon L.";
					Button1.Text = "Afficher Bon L.";
					Text = "Bon livraison";
					Nommail = "BL";
				}
				else if (Operators.CompareString(TYPEFACT, "DA", false) == 0)
				{
					PARAMFACT = "NUMDEVIS";
					TABLEFACT = "A_DEVIS";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_Devis.rpt";
					Label1.Text = "Entrer Num Devis";
					Button1.Text = "Afficher Devis Achat";
					Text = "Devis Achat";
					Nommail = "Devis Achat";
				}
				else if (Operators.CompareString(TYPEFACT, "BCA", false) == 0)
				{
					PARAMFACT = "NUMBONC";
					TABLEFACT = "A_BONC";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_BONC.rpt";
					Label1.Text = "Entrer Num Bon C.";
					Button1.Text = "Afficher Bon C.";
					Text = "Bon Commande Achat";
					Nommail = "BC Achat";
				}
				else if (Operators.CompareString(TYPEFACT, "BLA", false) == 0)
				{
					PARAMFACT = "NUMBONL";
					TABLEFACT = "A_BONL";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_BONL.rpt";
					Label1.Text = "Entrer Num Bon L.";
					Button1.Text = "Afficher Bon L.";
					Text = "Bon livraison Achat";
					Nommail = "BL Achat";
				}
				else if (Operators.CompareString(TYPEFACT, "FA", false) == 0)
				{
					PARAMFACT = "NUMFACT";
					TABLEFACT = "A_FACTURE";
					CHEMINRPT = "C:\\SIGC utility\\Reports\\Report_A_Facture.rpt";
					Label1.Text = "Entrer Num Facture";
					Button1.Text = "Afficher Facture";
					Text = "Facture Achat";
					Nommail = "Facture Achat";
				}
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select REMISE,TIMBRE from " + TABLEFACT + " where NUM_FACT ='" + NUMFACT.Text + "'";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					string text = mySqlDataReader["REMISE"].ToString();
					if (string.IsNullOrEmpty(text) | decimal.Compare(Globals.convertDN(text), decimal.Zero) == 0)
					{
						REMISE.Checked = false;
						REMVAL.Visible = false;
						REMVAL.Text = "0";
					}
					else
					{
						REMISE.Checked = true;
						REMVAL.Visible = true;
						REMVAL.Text = text;
					}
					string text2 = mySqlDataReader["TIMBRE"].ToString();
					if (string.IsNullOrEmpty(text2) | decimal.Compare(Globals.convertDN(text2), decimal.Zero) == 0)
					{
						TIMBRE.Checked = false;
						TIMVAL.Visible = false;
						TIMVAL.Text = "0";
					}
					else
					{
						TIMBRE.Checked = true;
						TIMVAL.Visible = true;
						TIMVAL.Text = text2;
					}
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				cryRpt.Load(CHEMINRPT);
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = true;
				connectionInfo2 = null;
				TableLogOnInfos tableLogOnInfos = new TableLogOnInfos();
				TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
				Tables tables = cryRpt.Database.Tables;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = tables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Table table = (Table)enumerator.Current;
						tableLogOnInfo = table.LogOnInfo;
						tableLogOnInfo.ConnectionInfo = connectionInfo;
						table.ApplyLogOnInfo(tableLogOnInfo);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				cryRpt.SetParameterValue(PARAMFACT, NUMFACT.Text);
				if (Operators.CompareString(TYPEFACT, "TIC", false) != 0)
				{
					cryRpt.SetParameterValue("REMISEPARAM", Globals.convertDN(REMVAL.Text));
					cryRpt.SetParameterValue("TIMBREPARAM", Globals.convertDN(TIMVAL.Text));
					cryRpt.SetParameterValue("Profil_Adresse", PROFIL);
				}
				CRV.ReportSource = cryRpt;
				CRV.Refresh();
				Nom_mail.Text = Nommail;
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

		private void NUMFACT_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = (("select distinct NUM_FACT from " + TABLEFACT) ?? "");
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				NUMFACT.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						NUMFACT.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				cryRpt.Load(CHEMINRPT);
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = true;
				connectionInfo2 = null;
				TableLogOnInfos tableLogOnInfos = new TableLogOnInfos();
				TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
				Tables tables = cryRpt.Database.Tables;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = tables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Table table = (Table)enumerator.Current;
						tableLogOnInfo = table.LogOnInfo;
						tableLogOnInfo.ConnectionInfo = connectionInfo;
						table.ApplyLogOnInfo(tableLogOnInfo);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				ParameterValues parameterValues = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
				parameterDiscreteValue.Value = NUMFACT.Text;
				ParameterFieldDefinitions parameterFields = cryRpt.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields[PARAMFACT];
				parameterValues = parameterFieldDefinition.CurrentValues;
				parameterValues.Clear();
				parameterValues.Add(parameterDiscreteValue);
				parameterFieldDefinition.ApplyCurrentValues(parameterValues);
				CRV.ReportSource = cryRpt;
				CRV.Refresh();
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
			try
			{
				DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
				PdfRtfWordFormatOptions formatOptions = new PdfRtfWordFormatOptions();
				NOMFICHJOINT = Nommail + " " + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
				diskFileDestinationOptions.DiskFileName = "C:\\SIGC utility\\Fichier joint\\" + NOMFICHJOINT + ".pdf";
				MyProject.Forms.Mail.chemin.Text = "C:\\SIGC utility\\Fichier joint\\" + NOMFICHJOINT + ".pdf";
				ExportOptions exportOptions = cryRpt.ExportOptions;
				ExportOptions exportOptions2 = exportOptions;
				exportOptions2.ExportDestinationType = ExportDestinationType.DiskFile;
				exportOptions2.ExportFormatType = ExportFormatType.PortableDocFormat;
				exportOptions2.DestinationOptions = diskFileDestinationOptions;
				exportOptions2.FormatOptions = formatOptions;
				exportOptions2 = null;
				cryRpt.Export();
				MyProject.Forms.Mail.Show();
				MyProject.Forms.Mail.BringToFront();
				MyProject.Forms.Mail.pathT.Text = "C:\\SIGC utility\\Fichier joint\\" + NOMFICHJOINT + ".pdf";
				MyProject.Forms.Mail.AjoutFJ_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.ToString(), MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void TIMBRE_CheckedChanged(object sender, EventArgs e)
		{
			if (TIMBRE.Checked)
			{
				TIMVAL.Visible = true;
			}
			else
			{
				TIMVAL.Visible = false;
			}
		}

		private void LB_Article_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(LB_Article.Text, "Profil Nb", false) == 0)
				{
					PROFIL = "0";
				}
				else if (Operators.CompareString(LB_Article.Text, "Profil TN", false) == 0)
				{
					PROFIL = "1";
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

		private void REMISE_CheckedChanged(object sender, EventArgs e)
		{
			if (REMISE.Checked)
			{
				REMVAL.Visible = true;
			}
			else
			{
				REMVAL.Visible = false;
			}
		}

		public void BtnPrint_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Imprimante non configurée", "Alerte");
		}

		private void btnValid_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string text = Strings.Replace(REMVAL.Text, ",", ".", 1, -1, CompareMethod.Binary);
				string text2 = Strings.Replace(TIMVAL.Text, ",", ".", 1, -1, CompareMethod.Binary);
				string query = "Update " + TABLEFACT + " set REMISE='" + text + "', TIMBRE='" + text2 + "' where NUM_FACT = '" + NUMFACT.Text + "'";
				Globals.ExecuteUpdateQuery(query);
				MessageBox.Show("Modification Apporté");
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
}
