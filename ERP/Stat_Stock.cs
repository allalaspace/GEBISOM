using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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
	public class Stat_Stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CRV")]
		private CrystalReportViewer _CRV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_Affich")]
		private Button _B_Affich;

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
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		internal virtual CrystalReportViewer CRV
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button B_Affich
		{
			[CompilerGenerated]
			get
			{
				return _B_Affich;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = B_Affich_Click;
				Button b_Affich = _B_Affich;
				if (b_Affich != null)
				{
					b_Affich.Click -= value2;
				}
				_B_Affich = value;
				b_Affich = _B_Affich;
				if (b_Affich != null)
				{
					b_Affich.Click += value2;
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

		public Stat_Stock()
		{
			base.Load += Stat_Stock_Load;
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
			B_Affich = new Button();
			Label1 = new Label();
			Button5 = new Button();
			REFART = new ComboBox();
			base.SuspendLayout();
			CRV.ActiveViewIndex = -1;
			CRV.BorderStyle = BorderStyle.FixedSingle;
			CRV.Cursor = Cursors.Default;
			CRV.Location = new Point(22, 152);
			CRV.Margin = new Padding(3, 4, 3, 4);
			CRV.Name = "CRV";
			CRV.Size = new Size(1212, 519);
			CRV.TabIndex = 15;
			CRV.ToolPanelWidth = 233;
			B_Affich.BackColor = SystemColors.ButtonHighlight;
			B_Affich.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 178);
			B_Affich.ForeColor = SystemColors.ActiveCaptionText;
			B_Affich.Image = Resources.Button_Refresh_icon;
			B_Affich.ImageAlign = ContentAlignment.MiddleLeft;
			B_Affich.Location = new Point(463, 67);
			B_Affich.Margin = new Padding(3, 4, 3, 4);
			B_Affich.Name = "B_Affich";
			B_Affich.Size = new Size(129, 54);
			B_Affich.TabIndex = 14;
			B_Affich.Text = "Afficher";
			B_Affich.TextAlign = ContentAlignment.MiddleRight;
			B_Affich.UseVisualStyleBackColor = false;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(145, 86);
			Label1.Name = "Label1";
			Label1.Size = new Size(53, 18);
			Label1.TabIndex = 13;
			Label1.Text = "Article";
			Button5.BackColor = SystemColors.ButtonHighlight;
			Button5.Location = new Point(399, 82);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 26);
			Button5.TabIndex = 107;
			Button5.TabStop = false;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = false;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(221, 84);
			REFART.Name = "REFART";
			REFART.Size = new Size(194, 24);
			REFART.TabIndex = 106;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Button5);
			base.Controls.Add(REFART);
			base.Controls.Add(CRV);
			base.Controls.Add(Label1);
			base.Controls.Add(B_Affich);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Stat_Stock";
			Text = "Statistique Stock";
			base.Controls.SetChildIndex(B_Affich, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(CRV, 0);
			base.Controls.SetChildIndex(REFART, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Stat_Stock_Load(object sender, EventArgs e)
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
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
				mySqlDataAdapter.Fill(dataSet, "list");
				AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
				ReportDocument reportDocument;
				ConnectionInfo connectionInfo;
				Tables tables;
				checked
				{
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
					reportDocument = new ReportDocument();
					reportDocument.Load("C:\\SIGC utility\\Reports\\Report_Suivi_Stock.rpt");
					connectionInfo = new ConnectionInfo();
					ConnectionInfo connectionInfo2 = connectionInfo;
					connectionInfo2.ServerName = "erp_db";
					connectionInfo2.DatabaseName = "";
					connectionInfo2.UserID = Globals.BDUSER;
					connectionInfo2.Password = Globals.BDPW;
					connectionInfo2.IntegratedSecurity = false;
					connectionInfo2 = null;
					TableLogOnInfos tableLogOnInfos = new TableLogOnInfos();
					TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
					tables = reportDocument.Database.Tables;
				}
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = tables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Table table = (Table)enumerator.Current;
						TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
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
				parameterDiscreteValue.Value = REFART.Text;
				ParameterFieldDefinitions parameterFields = reportDocument.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["REFART_P"];
				parameterValues = parameterFieldDefinition.CurrentValues;
				parameterValues.Clear();
				parameterValues.Add(parameterDiscreteValue);
				parameterFieldDefinition.ApplyCurrentValues(parameterValues);
				CRV.ReportSource = reportDocument;
				CRV.Refresh();
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

		public void B_Affich_Click(object sender, EventArgs e)
		{
			try
			{
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\SIGC utility\\Reports\\Report_Suivi_Stock.rpt");
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
				parameterDiscreteValue.Value = REFART.Text;
				ParameterFieldDefinitions parameterFields = reportDocument.DataDefinition.ParameterFields;
				ParameterFieldDefinition parameterFieldDefinition = parameterFields["REFART_P"];
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

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.flag_COD = "STATSTK";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D";
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

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		private void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void REFART_Validated(object sender, EventArgs e)
		{
			B_Affich_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
