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
	public class Modif_sortie_stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_sortie")]
		private TextBox _Date_sortie;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Client")]
		private TextBox _Client;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("quantite")]
		private TextBox _quantite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Type_Sortie")]
		private TextBox _Type_Sortie;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Code_sortie")]
		private TextBox _Code_sortie;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private TextBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private TextBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		public decimal Ancien_quantite;

		internal virtual TextBox Date_sortie
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Client
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

		internal virtual TextBox quantite
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

		internal virtual Label Label12
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

		internal virtual Label Label14
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

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Type_Sortie
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Code_sortie
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox REFART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox LIBART
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

		public Modif_sortie_stock()
		{
			base.Load += Modif_sortie_stock_Load;
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
			Date_sortie = new TextBox();
			Client = new TextBox();
			btnUpdate = new Button();
			quantite = new TextBox();
			Label11 = new Label();
			Label12 = new Label();
			Label13 = new Label();
			Label14 = new Label();
			Label15 = new Label();
			Label1 = new Label();
			Type_Sortie = new TextBox();
			Code_sortie = new TextBox();
			REFART = new TextBox();
			LIBART = new TextBox();
			GroupBox1 = new GroupBox();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			Date_sortie.Location = new Point(143, 277);
			Date_sortie.Margin = new Padding(3, 4, 3, 4);
			Date_sortie.Name = "Date_sortie";
			Date_sortie.ReadOnly = true;
			Date_sortie.Size = new Size(161, 26);
			Date_sortie.TabIndex = 53;
			Client.Location = new Point(143, 216);
			Client.Margin = new Padding(3, 4, 3, 4);
			Client.Name = "Client";
			Client.Size = new Size(233, 26);
			Client.TabIndex = 51;
			btnUpdate.BackColor = Color.CornflowerBlue;
			btnUpdate.BackgroundImage = Resources.Deconnexion1;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
			btnUpdate.Location = new Point(579, 190);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(111, 41);
			btnUpdate.TabIndex = 43;
			btnUpdate.Text = "Modifier";
			btnUpdate.UseVisualStyleBackColor = false;
			quantite.Location = new Point(145, 167);
			quantite.Margin = new Padding(3, 4, 3, 4);
			quantite.Name = "quantite";
			quantite.Size = new Size(121, 26);
			quantite.TabIndex = 37;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label11.Location = new Point(31, 60);
			Label11.Name = "Label11";
			Label11.Size = new Size(91, 19);
			Label11.TabIndex = 62;
			Label11.Text = "Réf. Article";
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label12.Location = new Point(31, 114);
			Label12.Name = "Label12";
			Label12.Size = new Size(89, 19);
			Label12.TabIndex = 61;
			Label12.Text = "Lib. Article";
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label13.Location = new Point(31, 170);
			Label13.Name = "Label13";
			Label13.Size = new Size(73, 19);
			Label13.TabIndex = 60;
			Label13.Text = "Quantité";
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label14.Location = new Point(30, 284);
			Label14.Name = "Label14";
			Label14.Size = new Size(93, 19);
			Label14.TabIndex = 59;
			Label14.Text = "Date Sortie";
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label15.Location = new Point(47, 221);
			Label15.Name = "Label15";
			Label15.Size = new Size(53, 19);
			Label15.TabIndex = 58;
			Label15.Text = "Client";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(30, 339);
			Label1.Name = "Label1";
			Label1.Size = new Size(96, 19);
			Label1.TabIndex = 64;
			Label1.Text = "Type Sortie";
			Type_Sortie.Location = new Point(143, 332);
			Type_Sortie.Margin = new Padding(3, 4, 3, 4);
			Type_Sortie.Name = "Type_Sortie";
			Type_Sortie.Size = new Size(161, 26);
			Type_Sortie.TabIndex = 63;
			Code_sortie.Location = new Point(427, 57);
			Code_sortie.Margin = new Padding(3, 4, 3, 4);
			Code_sortie.Name = "Code_sortie";
			Code_sortie.ReadOnly = true;
			Code_sortie.Size = new Size(77, 26);
			Code_sortie.TabIndex = 55;
			Code_sortie.Visible = false;
			REFART.Location = new Point(145, 57);
			REFART.Margin = new Padding(3, 4, 3, 4);
			REFART.Name = "REFART";
			REFART.ReadOnly = true;
			REFART.Size = new Size(233, 26);
			REFART.TabIndex = 66;
			LIBART.Location = new Point(143, 111);
			LIBART.Margin = new Padding(3, 4, 3, 4);
			LIBART.Name = "LIBART";
			LIBART.ReadOnly = true;
			LIBART.Size = new Size(233, 26);
			LIBART.TabIndex = 67;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(quantite);
			GroupBox1.Controls.Add(btnUpdate);
			GroupBox1.Controls.Add(Code_sortie);
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Controls.Add(Client);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Date_sortie);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Label15);
			GroupBox1.Controls.Add(Type_Sortie);
			GroupBox1.Controls.Add(Label14);
			GroupBox1.Controls.Add(Label11);
			GroupBox1.Controls.Add(Label13);
			GroupBox1.Controls.Add(Label12);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(60, 101);
			GroupBox1.Margin = new Padding(2, 3, 2, 3);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(2, 3, 2, 3);
			GroupBox1.Size = new Size(761, 451);
			GroupBox1.TabIndex = 105;
			GroupBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1056, 647);
			base.Controls.Add(GroupBox1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Modif_sortie_stock";
			Text = "Modif Sortie Stock";
			base.Controls.SetChildIndex(GroupBox1, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Modif_sortie_stock_Load(object sender, EventArgs e)
		{
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.controlNum(quantite.Text) > 0)
				{
					MessageBox.Show("Merci de bien saisir un nombre valide !");
				}
				else
				{
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					string cmdText = "select STOK from ARTICLE_D where REFART='" + REFART.Text + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					decimal value = Conversions.ToDecimal(mySqlCommand.ExecuteScalar());
					string cmdText2 = "select quantite from sortie_stock where CODE_SORTIE='" + Code_sortie.Text + "'";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, Globals.conn);
					Ancien_quantite = Conversions.ToDecimal(mySqlCommand2.ExecuteScalar());
					decimal num = default(decimal);
					num = decimal.Add(Convert.ToDecimal(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)), Convert.ToDecimal(Strings.Replace(Conversions.ToString(Ancien_quantite), ".", ",", 1, -1, CompareMethod.Binary)));
					decimal num2 = default(decimal);
					num2 = new decimal(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Globals.convertDN(quantite.Text)), ".", ",", 1, -1, CompareMethod.Binary)) + Conversions.ToDouble(Strings.Replace(Conversions.ToString(Ancien_quantite), ".", ",", 1, -1, CompareMethod.Binary)));
					string cmdText3 = "UPDATE sortie_stock SET REFART='" + REFART.Text + "',LIBART='" + LIBART.Text + "', quantite='" + Strings.Replace(quantite.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', client='" + Client.Text + "', date_sortie='" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', Type_Sortie='" + Type_Sortie.Text + "', STOCK_AVANT='" + Conversions.ToString(num) + "', STOCK_APRES='" + Conversions.ToString(num2) + "' WHERE code_sortie='" + Code_sortie.Text + "'";
					MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText3, Globals.conn);
					string cmdText4 = "UPDATE ARTICLE_D SET STOK=('" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + "') WHERE REFART='" + REFART.Text + "'";
					MySqlCommand mySqlCommand4 = new MySqlCommand(cmdText4, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand3.ExecuteNonQuery();
					mySqlCommand4.ExecuteNonQuery();
					RefreshDGV();
					MyProject.Forms.Sortie_Stock.FormatDGV(MyProject.Forms.Sortie_Stock.dgv1);
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					base.Close();
					MessageBox.Show("Mofication apportée");
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

		public void RefreshDGV()
		{
			string selectCommandText = "select * from sortie_stock order by code_sortie";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("sortie_stock");
			mySqlDataAdapter.Fill(dataTable);
			MyProject.Forms.Sortie_Stock.dgv1.DataSource = dataTable;
			MyProject.Forms.Sortie_Stock.FormatDGV(MyProject.Forms.Sortie_Stock.dgv1);
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

		private void LIBART_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
