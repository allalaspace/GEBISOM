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
	public class Modif_Vente : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TOTAL_V")]
		private TextBox _TOTAL_V;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

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
		[AccessedThroughProperty("REMISE")]
		private TextBox _REMISE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("QTE")]
		private TextBox _QTE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_V")]
		private TextBox _PRIX_V;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		public int NUMVENTE;

		public decimal ValRem;

		internal virtual ComboBox LIBART
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

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TOTAL_V
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnUpdate
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate_Click;
				Button btnUpdate = _btnUpdate;
				if (btnUpdate != null)
				{
					btnUpdate.Click -= value2;
				}
				_btnUpdate = value;
				btnUpdate = _btnUpdate;
				if (btnUpdate != null)
				{
					btnUpdate.Click += value2;
				}
			}
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

		internal virtual TextBox REMISE
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
				EventHandler value2 = Remise_Validated;
				TextBox rEMISE = _REMISE;
				if (rEMISE != null)
				{
					rEMISE.Validated -= value2;
				}
				_REMISE = value;
				rEMISE = _REMISE;
				if (rEMISE != null)
				{
					rEMISE.Validated += value2;
				}
			}
		}

		internal virtual TextBox QTE
		{
			[CompilerGenerated]
			get
			{
				return _QTE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = qte_Validated;
				TextBox qTE = _QTE;
				if (qTE != null)
				{
					qTE.Validated -= value2;
				}
				_QTE = value;
				qTE = _QTE;
				if (qTE != null)
				{
					qTE.Validated += value2;
				}
			}
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
				EventHandler value2 = REFART_Click;
				EventHandler value3 = REFART_SelectedIndexChanged;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click -= value2;
					rEFART.SelectedIndexChanged -= value3;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click += value2;
					rEFART.SelectedIndexChanged += value3;
				}
			}
		}

		public Modif_Vente()
		{
			base.KeyDown += Modif_Vente_KeyDown;
			base.Load += Modif_Vente_Load;
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
			LIBART = new ComboBox();
			Label7 = new Label();
			Label5 = new Label();
			TOTAL_V = new TextBox();
			btnUpdate = new Button();
			Label4 = new Label();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			REMISE = new TextBox();
			QTE = new TextBox();
			PRIX_V = new TextBox();
			REFART = new ComboBox();
			base.SuspendLayout();
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(133, 77);
			LIBART.Margin = new Padding(4);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(346, 26);
			LIBART.TabIndex = 2;
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label7.Location = new Point(21, 32);
			Label7.Margin = new Padding(4, 0, 4, 0);
			Label7.Name = "Label7";
			Label7.Size = new Size(90, 19);
			Label7.TabIndex = 31;
			Label7.Text = "Réf. Article";
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(21, 302);
			Label5.Margin = new Padding(4, 0, 4, 0);
			Label5.Name = "Label5";
			Label5.Size = new Size(93, 19);
			Label5.TabIndex = 27;
			Label5.Text = "Total Vente";
			TOTAL_V.Location = new Point(131, 302);
			TOTAL_V.Margin = new Padding(4);
			TOTAL_V.Name = "TOTAL_V";
			TOTAL_V.ReadOnly = true;
			TOTAL_V.Size = new Size(160, 26);
			TOTAL_V.TabIndex = 26;
			btnUpdate.BackColor = Color.White;
			btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.Image = Resources.edit_file_icon;
			btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdate.Location = new Point(450, 153);
			btnUpdate.Margin = new Padding(4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(124, 57);
			btnUpdate.TabIndex = 25;
			btnUpdate.Text = "Modifier";
			btnUpdate.TextAlign = ContentAlignment.MiddleRight;
			btnUpdate.UseVisualStyleBackColor = false;
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(21, 249);
			Label4.Margin = new Padding(4, 0, 4, 0);
			Label4.Name = "Label4";
			Label4.Size = new Size(66, 19);
			Label4.TabIndex = 24;
			Label4.Text = "Remise";
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(21, 188);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(73, 19);
			Label3.TabIndex = 23;
			Label3.Text = "Quantité";
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(21, 137);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(59, 19);
			Label2.TabIndex = 22;
			Label2.Text = "Prix U.";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(11, 80);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(110, 19);
			Label1.TabIndex = 21;
			Label1.Text = "Libelle Article\r\n";
			REMISE.Location = new Point(131, 245);
			REMISE.Margin = new Padding(4);
			REMISE.Name = "REMISE";
			REMISE.Size = new Size(98, 26);
			REMISE.TabIndex = 5;
			QTE.Location = new Point(131, 184);
			QTE.Margin = new Padding(4);
			QTE.Name = "QTE";
			QTE.Size = new Size(98, 26);
			QTE.TabIndex = 4;
			PRIX_V.Location = new Point(133, 133);
			PRIX_V.Margin = new Padding(4);
			PRIX_V.Name = "PRIX_V";
			PRIX_V.Size = new Size(157, 26);
			PRIX_V.TabIndex = 3;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(133, 29);
			REFART.Name = "REFART";
			REFART.Size = new Size(203, 26);
			REFART.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(622, 352);
			base.Controls.Add(REFART);
			base.Controls.Add(LIBART);
			base.Controls.Add(Label7);
			base.Controls.Add(Label5);
			base.Controls.Add(TOTAL_V);
			base.Controls.Add(btnUpdate);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(REMISE);
			base.Controls.Add(QTE);
			base.Controls.Add(PRIX_V);
			Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 6, 4, 6);
			base.Name = "Modif_Vente";
			Text = "Modification Vente";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				decimal d = new decimal(Convert.ToDouble(Globals.convertDN(REMISE.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_V.Text)));
				TOTAL_V.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_V.Text), d), Globals.convertDN(QTE.Text)));
				string query = "UPDATE VENTE SET LIBART='" + LIBART.Text + "', PRIX_V='" + PRIX_V.Text + "', QTE='" + QTE.Text + "',REM='" + REMISE.Text + "', TotalTTC_DF='" + TOTAL_V.Text + "' WHERE NUM_DF='" + Conversions.ToString(NUMVENTE) + "'";
				Globals.ExecuteUpdateQuery(query);
				Globals.ClearTextBox(this);
				string query2 = "select REFART,LIBART,PRIX_V,QTE,REM,TotalTTC_DF,NUM_DF from VENTE where NUM_FACT='" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "'";
				MyProject.Forms.Gestion_Vente.dgv1.DataSource = null;
				MyProject.Forms.Gestion_Vente.dgv1.Rows.Clear();
				Globals.LoadData(query2, MyProject.Forms.Gestion_Vente.dgv1, "Vente");
				MyProject.Forms.Gestion_Vente.formatDGV(MyProject.Forms.Gestion_Vente.dgv1);
				MyProject.Forms.Gestion_Vente.Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				base.Close();
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
				QTE.Text = Strings.Replace(QTE.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem = new decimal(Convert.ToDouble(Globals.convertDN(REMISE.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_V.Text)));
				TOTAL_V.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_V.Text), ValRem), Globals.convertDN(QTE.Text)));
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
				REMISE.Text = Strings.Replace(REMISE.Text, ".", ",", 1, -1, CompareMethod.Binary);
				ValRem = new decimal(Convert.ToDouble(Globals.convertDN(REMISE.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_V.Text)));
				TOTAL_V.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_V.Text), ValRem), Globals.convertDN(QTE.Text)));
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
				ValRem = new decimal(Convert.ToDouble(Globals.convertDN(REMISE.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_V.Text)));
				TOTAL_V.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_V.Text), ValRem), Globals.convertDN(QTE.Text)));
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

		private void REFART_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select distinct REFART from ARTICLE_D where REFART LIKE '" + REFART.Text + "%'";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REFART.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Globals.conn.Close();
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

		private void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
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
					QTE.Text = "1";
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					REMISE.Text = mySqlDataReader["REM"].ToString();
					if (Operators.CompareString(REMISE.Text, "", false) == 0)
					{
						REMISE.Text = "0";
					}
					PRIX_V.Text = mySqlDataReader["PRIX_V"].ToString();
					if (Operators.CompareString(PRIX_V.Text, "", false) == 0)
					{
						PRIX_V.Text = "0";
					}
					ValRem = new decimal(Convert.ToDouble(Globals.convertDN(REMISE.Text)) * 0.01 * Convert.ToDouble(Globals.convertDN(PRIX_V.Text)));
					TOTAL_V.Text = Conversions.ToString(decimal.Multiply(decimal.Subtract(Globals.convertDN(PRIX_V.Text), Globals.convertDN(ValRem)), Globals.convertDN(QTE.Text)));
				}
				else
				{
					MessageBox.Show("ARTICLE not found");
				}
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

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.WParam.ToInt32() == 13)
			{
				SendKeys.Send("{Tab}");
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void Modif_Vente_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Modif_Vente_Load(object sender, EventArgs e)
		{
		}
	}
}
