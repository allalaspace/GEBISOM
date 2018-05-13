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
	public class FrmFacture : Accueil
	{
		private IContainer components;

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
		[AccessedThroughProperty("NUMFACT")]
		private ComboBox _NUMFACT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CRV")]
		private CrystalReportViewer _CRV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("EnvoiMail")]
		private Button _EnvoiMail;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TIMBRE")]
		private CheckBox _TIMBRE;

		public string Nommail;

		public string NOMFICHJOINT;

		private ReportDocument cryRpt;

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

		internal virtual Button EnvoiMail
		{
			[CompilerGenerated]
			get
			{
				return _EnvoiMail;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = EnvoiMail_Click;
				Button envoiMail = _EnvoiMail;
				if (envoiMail != null)
				{
					envoiMail.Click -= value2;
				}
				_EnvoiMail = value;
				envoiMail = _EnvoiMail;
				if (envoiMail != null)
				{
					envoiMail.Click += value2;
				}
			}
		}

		internal virtual CheckBox TIMBRE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public FrmFacture()
		{
			base.Load += FrmFacture_Load;
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
			Button1 = new Button();
			Label1 = new Label();
			NUMFACT = new ComboBox();
			CRV = new CrystalReportViewer();
			EnvoiMail = new Button();
			TIMBRE = new CheckBox();
			base.SuspendLayout();
			Button1.BackColor = SystemColors.ButtonHighlight;
			Button1.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 178);
			Button1.ForeColor = SystemColors.ActiveCaptionText;
			Button1.Image = Resources.Button_Refresh_icon;
			Button1.ImageAlign = ContentAlignment.MiddleLeft;
			Button1.Location = new Point(718, 73);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(176, 54);
			Button1.TabIndex = 6;
			Button1.Text = "Afficher Facture";
			Button1.TextAlign = ContentAlignment.MiddleRight;
			Button1.UseVisualStyleBackColor = false;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(50, 85);
			Label1.Name = "Label1";
			Label1.Size = new Size(147, 18);
			Label1.TabIndex = 5;
			Label1.Text = "Entrer Num Facture";
			NUMFACT.FormattingEnabled = true;
			NUMFACT.Location = new Point(229, 81);
			NUMFACT.Margin = new Padding(3, 4, 3, 4);
			NUMFACT.Name = "NUMFACT";
			NUMFACT.Size = new Size(201, 24);
			NUMFACT.TabIndex = 8;
			CRV.ActiveViewIndex = -1;
			CRV.BorderStyle = BorderStyle.FixedSingle;
			CRV.Cursor = Cursors.Default;
			CRV.Location = new Point(14, 148);
			CRV.Margin = new Padding(3, 4, 3, 4);
			CRV.Name = "CRV";
			CRV.Size = new Size(1229, 518);
			CRV.TabIndex = 7;
			CRV.ToolPanelWidth = 233;
			EnvoiMail.BackgroundImage = Resources.Envoyer;
			EnvoiMail.Location = new Point(831, 59);
			EnvoiMail.Name = "EnvoiMail";
			EnvoiMail.Size = new Size(63, 82);
			EnvoiMail.TabIndex = 119;
			EnvoiMail.UseVisualStyleBackColor = true;
			TIMBRE.AutoSize = true;
			TIMBRE.BackColor = Color.Transparent;
			TIMBRE.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			TIMBRE.Location = new Point(459, 81);
			TIMBRE.Name = "TIMBRE";
			TIMBRE.Size = new Size(81, 23);
			TIMBRE.TabIndex = 120;
			TIMBRE.Text = "Timbre";
			TIMBRE.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(TIMBRE);
			base.Controls.Add(EnvoiMail);
			base.Controls.Add(CRV);
			base.Controls.Add(NUMFACT);
			base.Controls.Add(Label1);
			base.Controls.Add(Button1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "FrmFacture";
			Text = "Facture";
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(NUMFACT, 0);
			base.Controls.SetChildIndex(CRV, 0);
			base.Controls.SetChildIndex(EnvoiMail, 0);
			base.Controls.SetChildIndex(TIMBRE, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				cryRpt.Load("C:\\SIGC utility\\Reports\\Report_Facture.rpt");
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = false;
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
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["NUMTICKET"];
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
		}

		private void FrmFacture_Load(object sender, EventArgs e)
		{
			try
			{
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\SIGC utility\\Reports\\Report_Facture.rpt");
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = false;
				connectionInfo2 = null;
				TableLogOnInfos tableLogOnInfos = new TableLogOnInfos();
				TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
				Tables tables = reportDocument.Database.Tables;
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
				if (Operators.CompareString(NUMFACT.Text, "", false) != 0)
				{
					parameterDiscreteValue.Value = NUMFACT.Text;
				}
				else
				{
					parameterDiscreteValue.Value = "0";
				}
				ParameterFieldDefinitions parameterFields = reportDocument.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["NUMTICKET"];
				parameterValues = parameterFieldDefinition.CurrentValues;
				parameterValues.Clear();
				parameterValues.Add(parameterDiscreteValue);
				parameterFieldDefinition.ApplyCurrentValues(parameterValues);
				CRV.ReportSource = reportDocument;
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
				mySqlCommand.CommandText = "select distinct NUM_FACT from TICKET";
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

		private void EnvoiMail_Click(object sender, EventArgs e)
		{
			try
			{
				cryRpt.Load("C:\\SIGC utility\\Reports\\Report_Facture.rpt");
				ConnectionInfo connectionInfo = new ConnectionInfo();
				ConnectionInfo connectionInfo2 = connectionInfo;
				connectionInfo2.ServerName = "erp_db";
				connectionInfo2.DatabaseName = "";
				connectionInfo2.UserID = Globals.BDUSER;
				connectionInfo2.Password = Globals.BDPW;
				connectionInfo2.IntegratedSecurity = false;
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
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["NUMTICKET"];
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
				Nommail = "Facture";
				NOMFICHJOINT = Nommail + " " + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
				diskFileDestinationOptions.DiskFileName = "C:\\SIGC utility\\Fichier joint\\ " + NOMFICHJOINT + " .pdf";
				MyProject.Forms.Mail.chemin.Text = "C:\\SIGC utility\\Fichier joint\\ " + NOMFICHJOINT + " .pdf";
				ExportOptions exportOptions = cryRpt.ExportOptions;
				ExportOptions exportOptions2 = exportOptions;
				exportOptions2.ExportDestinationType = ExportDestinationType.DiskFile;
				exportOptions2.ExportFormatType = ExportFormatType.PortableDocFormat;
				exportOptions2.DestinationOptions = diskFileDestinationOptions;
				exportOptions2.FormatOptions = formatOptions;
				exportOptions2 = null;
				cryRpt.Export();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.ToString(), MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}
	}
}
