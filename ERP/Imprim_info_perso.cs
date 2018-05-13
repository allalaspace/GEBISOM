using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Imprim_info_perso : Accueil
	{
		private IContainer components;

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
		[AccessedThroughProperty("CODE_PERSO")]
		private TextBox _CODE_PERSO;

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

		internal virtual TextBox CODE_PERSO
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Imprim_info_perso()
		{
			base.Load += Imprim_info_perso_Load;
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
			CRV = new CrystalReportViewer();
			Button1 = new Button();
			Label1 = new Label();
			CODE_PERSO = new TextBox();
			base.SuspendLayout();
			CRV.ActiveViewIndex = -1;
			CRV.BorderStyle = BorderStyle.FixedSingle;
			CRV.Cursor = Cursors.Default;
			CRV.Location = new Point(25, 170);
			CRV.Margin = new Padding(3, 4, 3, 4);
			CRV.Name = "CRV";
			CRV.Size = new Size(1209, 501);
			CRV.TabIndex = 11;
			CRV.ToolPanelWidth = 233;
			Button1.BackColor = SystemColors.ButtonHighlight;
			Button1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Button1.Image = Resources.Button_Refresh_icon;
			Button1.ImageAlign = ContentAlignment.MiddleLeft;
			Button1.Location = new Point(579, 81);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(117, 57);
			Button1.TabIndex = 10;
			Button1.Text = "Afficher";
			Button1.TextAlign = ContentAlignment.MiddleRight;
			Button1.UseVisualStyleBackColor = false;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(49, 100);
			Label1.Name = "Label1";
			Label1.Size = new Size(193, 18);
			Label1.TabIndex = 9;
			Label1.Text = "Entrer Code du personnel";
			CODE_PERSO.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			CODE_PERSO.Location = new Point(282, 96);
			CODE_PERSO.Margin = new Padding(3, 4, 3, 4);
			CODE_PERSO.Name = "CODE_PERSO";
			CODE_PERSO.Size = new Size(270, 25);
			CODE_PERSO.TabIndex = 8;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(CRV);
			base.Controls.Add(Button1);
			base.Controls.Add(Label1);
			base.Controls.Add(CODE_PERSO);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Imprim_info_perso";
			Text = "Fiche personnel";
			base.Controls.SetChildIndex(CODE_PERSO, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(CRV, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Imprim_info_perso_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\SIGC utility\\Reports\\Report_perso_imprim.rpt");
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
				parameterDiscreteValue.Value = MyProject.Forms.Affich_membres.dgv1.CurrentRow.Cells[0].Value.ToString();
				CODE_PERSO.Text = MyProject.Forms.Affich_membres.dgv1.CurrentRow.Cells[0].Value.ToString();
				ParameterFieldDefinitions parameterFields = reportDocument.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["code_perso"];
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

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\SIGC utility\\Reports\\Report_perso_imprim.rpt");
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
				parameterDiscreteValue.Value = CODE_PERSO.Text;
				ParameterFieldDefinitions parameterFields = reportDocument.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["code_perso"];
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
	}
}
