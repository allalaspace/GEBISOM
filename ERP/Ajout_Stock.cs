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
	public class Ajout_Stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private TextBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NOMFRS")]
		private TextBox _NOMFRS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STKMAX")]
		private TextBox _STKMAX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private TextBox _LIBART;

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
		[AccessedThroughProperty("STKMIN")]
		private TextBox _STKMIN;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("STOK")]
		private TextBox _STOK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIB_FAM")]
		private TextBox _LIB_FAM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_Entree")]
		private TextBox _Date_Entree;

		public string COD;

		public int COD_E;

		internal virtual Button btnSave
		{
			[CompilerGenerated]
			get
			{
				return _btnSave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSave_Click;
				Button btnSave = _btnSave;
				if (btnSave != null)
				{
					btnSave.Click -= value2;
				}
				_btnSave = value;
				btnSave = _btnSave;
				if (btnSave != null)
				{
					btnSave.Click += value2;
				}
			}
		}

		internal virtual Label Label7
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

		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox NOMFRS
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

		internal virtual TextBox STKMAX
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

		internal virtual TextBox STKMIN
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox STOK
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox LIB_FAM
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

		internal virtual TextBox Date_Entree
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Ajout_Stock()
		{
			base.Load += frmNew_Load;
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
			btnSave = new Button();
			Label7 = new Label();
			REFART = new TextBox();
			Label6 = new Label();
			NOMFRS = new TextBox();
			Label5 = new Label();
			STKMAX = new TextBox();
			LIBART = new TextBox();
			Label4 = new Label();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			STKMIN = new TextBox();
			STOK = new TextBox();
			LIB_FAM = new TextBox();
			Label9 = new Label();
			Date_Entree = new TextBox();
			base.SuspendLayout();
			btnSave.BackColor = Color.CornflowerBlue;
			btnSave.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSave.Location = new Point(566, 180);
			btnSave.Margin = new Padding(4, 4, 4, 4);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(147, 56);
			btnSave.TabIndex = 17;
			btnSave.Text = "Ajouter";
			btnSave.UseVisualStyleBackColor = false;
			Label7.AutoSize = true;
			Label7.BackColor = Color.Transparent;
			Label7.Location = new Point(15, 108);
			Label7.Margin = new Padding(4, 0, 4, 0);
			Label7.Name = "Label7";
			Label7.Size = new Size(84, 18);
			Label7.TabIndex = 31;
			Label7.Text = "Réf. Article";
			REFART.Location = new Point(126, 104);
			REFART.Margin = new Padding(4, 4, 4, 4);
			REFART.Name = "REFART";
			REFART.ReadOnly = true;
			REFART.Size = new Size(71, 26);
			REFART.TabIndex = 30;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.Location = new Point(1, 433);
			Label6.Margin = new Padding(4, 0, 4, 0);
			Label6.Name = "Label6";
			Label6.Size = new Size(127, 18);
			Label6.TabIndex = 29;
			Label6.Text = "Nom Fournisseur";
			NOMFRS.Location = new Point(147, 433);
			NOMFRS.Margin = new Padding(4, 4, 4, 4);
			NOMFRS.Name = "NOMFRS";
			NOMFRS.Size = new Size(442, 26);
			NOMFRS.TabIndex = 28;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.Location = new Point(1, 378);
			Label5.Margin = new Padding(4, 0, 4, 0);
			Label5.Name = "Label5";
			Label5.Size = new Size(110, 18);
			Label5.TabIndex = 27;
			Label5.Text = "Stock maximal";
			STKMAX.Location = new Point(126, 378);
			STKMAX.Margin = new Padding(4, 4, 4, 4);
			STKMAX.Name = "STKMAX";
			STKMAX.Size = new Size(298, 26);
			STKMAX.TabIndex = 26;
			LIBART.Location = new Point(126, 161);
			LIBART.Margin = new Padding(4, 4, 4, 4);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(298, 26);
			LIBART.TabIndex = 25;
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.Location = new Point(1, 325);
			Label4.Margin = new Padding(4, 0, 4, 0);
			Label4.Name = "Label4";
			Label4.Size = new Size(106, 18);
			Label4.TabIndex = 24;
			Label4.Text = "Stock minimal";
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Location = new Point(15, 264);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(48, 18);
			Label3.TabIndex = 23;
			Label3.Text = "Stock";
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Location = new Point(15, 214);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(89, 18);
			Label2.TabIndex = 22;
			Label2.Text = "Lib. Famille";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Location = new Point(15, 164);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(82, 18);
			Label1.TabIndex = 21;
			Label1.Text = "Lib. Article";
			STKMIN.Location = new Point(126, 322);
			STKMIN.Margin = new Padding(4, 4, 4, 4);
			STKMIN.Name = "STKMIN";
			STKMIN.Size = new Size(298, 26);
			STKMIN.TabIndex = 20;
			STOK.Location = new Point(126, 260);
			STOK.Margin = new Padding(4, 4, 4, 4);
			STOK.Name = "STOK";
			STOK.Size = new Size(98, 26);
			STOK.TabIndex = 19;
			LIB_FAM.Location = new Point(129, 209);
			LIB_FAM.Margin = new Padding(4, 4, 4, 4);
			LIB_FAM.Name = "LIB_FAM";
			LIB_FAM.Size = new Size(179, 26);
			LIB_FAM.TabIndex = 18;
			Label9.AutoSize = true;
			Label9.Location = new Point(10, 542);
			Label9.Margin = new Padding(4, 0, 4, 0);
			Label9.Name = "Label9";
			Label9.Size = new Size(95, 18);
			Label9.TabIndex = 35;
			Label9.Text = "Date_entree";
			Date_Entree.Location = new Point(125, 539);
			Date_Entree.Margin = new Padding(4, 4, 4, 4);
			Date_Entree.Name = "Date_Entree";
			Date_Entree.Size = new Size(179, 26);
			Date_Entree.TabIndex = 34;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1370, 748);
			base.Controls.Add(Label9);
			base.Controls.Add(Date_Entree);
			base.Controls.Add(Label7);
			base.Controls.Add(REFART);
			base.Controls.Add(Label6);
			base.Controls.Add(NOMFRS);
			base.Controls.Add(Label5);
			base.Controls.Add(STKMAX);
			base.Controls.Add(LIBART);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(STKMIN);
			base.Controls.Add(STOK);
			base.Controls.Add(LIB_FAM);
			base.Controls.Add(btnSave);
			Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(4, 6, 4, 6);
			base.Name = "Ajout_Stock";
			Text = "Ajout Nouveau Stock";
			base.Controls.SetChildIndex(btnSave, 0);
			base.Controls.SetChildIndex(LIB_FAM, 0);
			base.Controls.SetChildIndex(STOK, 0);
			base.Controls.SetChildIndex(STKMIN, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(LIBART, 0);
			base.Controls.SetChildIndex(STKMAX, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(NOMFRS, 0);
			base.Controls.SetChildIndex(Label6, 0);
			base.Controls.SetChildIndex(REFART, 0);
			base.Controls.SetChildIndex(Label7, 0);
			base.Controls.SetChildIndex(Date_Entree, 0);
			base.Controls.SetChildIndex(Label9, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				string text = "select * from entree_stock";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					COD_E = 1;
				}
				else
				{
					mySqlCommand.CommandText = "SELECT MAX(code_entree)+1 FROM entree_stock ";
					COD_E = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
				}
				Globals.conn.Close();
				string cmdText = "INSERT INTO article_D(REFART, LIBART, LIB_FAM, STOK, STKMIN, STKMAX, NOMFRS)VALUES(:REFART, :LIBART, :LIB_FAM, :STOK, :STKMIN, :STKMAX, :NOMFRS)";
				MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
				mySqlCommand2.Parameters.Add(new MySqlParameter("@REFART", COD));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@LIBART", LIBART.Text));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@LIB_FAM", LIB_FAM.Text));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@STOK", STOK.Text));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@STKMIN", STKMIN.Text));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@STKMAX", STKMAX.Text));
				mySqlCommand2.Parameters.Add(new MySqlParameter("@NOMFRS", NOMFRS.Text));
				string cmdText2 = "INSERT INTO Entree_stock(REFART, LIBART, quantite, fournisseur, Date_entree, code_entree)VALUES(:REFART, :LIBART, :quantite, :fournisseur, :Date_entree, :code_entree)";
				MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText2, Globals.conn);
				mySqlCommand3.Parameters.Add(new MySqlParameter("@REFART", COD));
				mySqlCommand3.Parameters.Add(new MySqlParameter("@LIBART", LIBART.Text));
				mySqlCommand3.Parameters.Add(new MySqlParameter("@quantite", STOK.Text));
				mySqlCommand3.Parameters.Add(new MySqlParameter("@fournisseur", NOMFRS.Text));
				mySqlCommand3.Parameters.Add(new MySqlParameter("@Date_entree", Date_Entree.Text));
				mySqlCommand3.Parameters.Add(new MySqlParameter("@code_entree", COD_E));
				Globals.conn.Open();
				mySqlCommand2.ExecuteNonQuery();
				mySqlCommand3.ExecuteNonQuery();
				Globals.conn.Close();
				ClearTextBox(this);
				RefreshDGV();
				Globals.conn.Close();
				base.Close();
				MessageBox.Show("Element ajouté");
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
			string selectCommandText = "select * from article";
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
			DataTable dataTable = new DataTable("article");
			mySqlDataAdapter.Fill(dataTable);
			MyProject.Forms.Gestion_stock.dgv1.DataSource = dataTable;
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

		private void frmNew_Load(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				string text = "select * from article";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					COD = Conversions.ToString(1);
				}
				else
				{
					mySqlCommand.CommandText = "SELECT MAX(REFART)+1 FROM article ";
					COD = Conversions.ToString(mySqlCommand.ExecuteScalar());
				}
				Globals.conn.Close();
				REFART.Text = COD;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}
}
