using ERP.My;
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
	public class Modif_entree_stock : Accueil
	{
		private IContainer components;

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
		[AccessedThroughProperty("Date_entree")]
		private TextBox _Date_entree;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Fournisseur")]
		private TextBox _Fournisseur;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Code_entree")]
		private TextBox _Code_entree;

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
		[AccessedThroughProperty("TYPE_ENTREE")]
		private TextBox _TYPE_ENTREE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private TextBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private TextBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		public decimal Ancien_quantite;

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

		internal virtual TextBox Date_entree
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Fournisseur
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Code_entree
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

		internal virtual TextBox TYPE_ENTREE
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

		internal virtual TextBox REFART
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

		public Modif_entree_stock()
		{
			base.Load += Modif_entree_stock_Load;
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
			btnUpdate = new Button();
			quantite = new TextBox();
			Date_entree = new TextBox();
			Fournisseur = new TextBox();
			Code_entree = new TextBox();
			Label11 = new Label();
			Label12 = new Label();
			Label13 = new Label();
			Label14 = new Label();
			Label15 = new Label();
			Label1 = new Label();
			TYPE_ENTREE = new TextBox();
			LIBART = new TextBox();
			REFART = new TextBox();
			GroupBox1 = new GroupBox();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			btnUpdate.BackColor = Color.CornflowerBlue;
			btnUpdate.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
			btnUpdate.Location = new Point(536, 182);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(105, 39);
			btnUpdate.TabIndex = 24;
			btnUpdate.Text = "Modifier";
			btnUpdate.UseVisualStyleBackColor = false;
			quantite.Location = new Point(126, 143);
			quantite.Margin = new Padding(3, 4, 3, 4);
			quantite.Name = "quantite";
			quantite.Size = new Size(121, 26);
			quantite.TabIndex = 18;
			Date_entree.Location = new Point(125, 263);
			Date_entree.Margin = new Padding(3, 4, 3, 4);
			Date_entree.Name = "Date_entree";
			Date_entree.Size = new Size(232, 26);
			Date_entree.TabIndex = 34;
			Fournisseur.Location = new Point(124, 195);
			Fournisseur.Margin = new Padding(3, 4, 3, 4);
			Fournisseur.Name = "Fournisseur";
			Fournisseur.Size = new Size(233, 26);
			Fournisseur.TabIndex = 32;
			Code_entree.Location = new Point(401, 28);
			Code_entree.Margin = new Padding(3, 4, 3, 4);
			Code_entree.Name = "Code_entree";
			Code_entree.ReadOnly = true;
			Code_entree.Size = new Size(77, 26);
			Code_entree.TabIndex = 58;
			Code_entree.Visible = false;
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label11.Location = new Point(16, 31);
			Label11.Name = "Label11";
			Label11.Size = new Size(90, 18);
			Label11.TabIndex = 65;
			Label11.Text = "Réf. Article";
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label12.Location = new Point(18, 93);
			Label12.Name = "Label12";
			Label12.Size = new Size(88, 18);
			Label12.TabIndex = 64;
			Label12.Text = "Lib. Article";
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label13.Location = new Point(12, 268);
			Label13.Name = "Label13";
			Label13.Size = new Size(95, 18);
			Label13.TabIndex = 63;
			Label13.Text = "Date entrée";
			Label14.AutoSize = true;
			Label14.BackColor = Color.Transparent;
			Label14.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label14.Location = new Point(5, 200);
			Label14.Name = "Label14";
			Label14.Size = new Size(101, 18);
			Label14.TabIndex = 62;
			Label14.Text = "Fournisseur";
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label15.Location = new Point(26, 152);
			Label15.Name = "Label15";
			Label15.Size = new Size(72, 18);
			Label15.TabIndex = 61;
			Label15.Text = "Quantité";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.Location = new Point(12, 332);
			Label1.Name = "Label1";
			Label1.Size = new Size(97, 18);
			Label1.TabIndex = 67;
			Label1.Text = "Type entrée";
			TYPE_ENTREE.Location = new Point(126, 329);
			TYPE_ENTREE.Margin = new Padding(3, 4, 3, 4);
			TYPE_ENTREE.Name = "TYPE_ENTREE";
			TYPE_ENTREE.Size = new Size(231, 26);
			TYPE_ENTREE.TabIndex = 66;
			LIBART.Location = new Point(126, 83);
			LIBART.Margin = new Padding(3, 4, 3, 4);
			LIBART.Name = "LIBART";
			LIBART.ReadOnly = true;
			LIBART.Size = new Size(233, 26);
			LIBART.TabIndex = 69;
			REFART.Location = new Point(126, 28);
			REFART.Margin = new Padding(3, 4, 3, 4);
			REFART.Name = "REFART";
			REFART.ReadOnly = true;
			REFART.Size = new Size(233, 26);
			REFART.TabIndex = 68;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(btnUpdate);
			GroupBox1.Controls.Add(Code_entree);
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Controls.Add(quantite);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Fournisseur);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Date_entree);
			GroupBox1.Controls.Add(TYPE_ENTREE);
			GroupBox1.Controls.Add(Label15);
			GroupBox1.Controls.Add(Label11);
			GroupBox1.Controls.Add(Label14);
			GroupBox1.Controls.Add(Label12);
			GroupBox1.Controls.Add(Label13);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(57, 104);
			GroupBox1.Margin = new Padding(2, 3, 2, 3);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(2, 3, 2, 3);
			GroupBox1.Size = new Size(689, 408);
			GroupBox1.TabIndex = 105;
			GroupBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			base.ClientSize = new Size(1056, 647);
			base.Controls.Add(GroupBox1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Modif_entree_stock";
			Text = "Modif Entree Stock";
			base.Controls.SetChildIndex(GroupBox1, 0);
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Modif_entree_stock_Load(object sender, EventArgs e)
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
					string cmdText = "select quantite from entree_stock where code_entree= '" + Code_entree.Text + "' ";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Ancien_quantite = Conversions.ToDecimal(mySqlCommand.ExecuteScalar());
					string cmdText2 = "select STOK from ARTICLE_D where REFART='" + REFART.Text + "'";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, Globals.conn);
					mySqlCommand2.Parameters.Add(new MySqlParameter("@REFART", REFART.Text));
					decimal num = Conversions.ToDecimal(mySqlCommand2.ExecuteScalar());
					decimal value = new decimal(Convert.ToDouble(Globals.convertDN(quantite.Text)) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Ancien_quantite), ".", ",", 1, -1, CompareMethod.Binary)));
					string cmdText3 = "UPDATE article_D SET STOK=STOK + '" + Strings.Replace(Conversions.ToString(value), ",", ".", 1, -1, CompareMethod.Binary) + "' WHERE REFART='" + REFART.Text + "'";
					MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText3, Globals.conn);
					decimal value2 = new decimal(Convert.ToDouble(decimal.Add(num, Globals.convertDN(quantite.Text))) - Conversions.ToDouble(Strings.Replace(Conversions.ToString(Ancien_quantite), ".", ",", 1, -1, CompareMethod.Binary)));
					string cmdText4 = "UPDATE entree_stock SET REFART='" + REFART.Text + "', LIBART='" + REFART.Text + "',quantite='" + Strings.Replace(quantite.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', fournisseur='" + Fournisseur.Text + "', date_entree='" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "',TYPE_ENTREE='" + TYPE_ENTREE.Text + "', STOCK_AVANT='" + Conversions.ToString(num) + "', STOCK_APRES='" + Strings.Replace(Conversions.ToString(value2), ",", ".", 1, -1, CompareMethod.Binary) + "' WHERE code_entree='" + Code_entree.Text + "'";
					MySqlCommand mySqlCommand4 = new MySqlCommand(cmdText4, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand4.ExecuteNonQuery();
					mySqlCommand3.ExecuteNonQuery();
					RefreshDGV();
					Globals.clorerDGV(MyProject.Forms.Entree_Stock.dgv1);
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
			string selectCommandText = "select * from entree_stock";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("entree_stock");
			mySqlDataAdapter.Fill(dataTable);
			MyProject.Forms.Entree_Stock.dgv1.DataSource = dataTable;
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

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select * from entree_stock where LIBART ='" + LIBART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				mySqlCommand.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					REFART.Text = mySqlDataReader["REFART"].ToString();
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					quantite.Text = mySqlDataReader["quantite"].ToString();
					Fournisseur.Text = mySqlDataReader["fournisseur"].ToString();
					Date_entree.Text = mySqlDataReader["date_entree"].ToString();
				}
				else
				{
					MessageBox.Show("Article non trouvé");
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
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
		}

		private void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
