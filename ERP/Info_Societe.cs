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
	public class Info_Societe : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Adresse_Soc")]
		private TextBox _Adresse_Soc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Nom_Soc")]
		private TextBox _Nom_Soc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ADRESSE2")]
		private TextBox _ADRESSE2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TEL")]
		private TextBox _TEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TEL2")]
		private TextBox _TEL2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("FAX")]
		private TextBox _FAX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("EMAIL")]
		private TextBox _EMAIL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TVA")]
		private TextBox _TVA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RIB")]
		private TextBox _RIB;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RIB2")]
		private TextBox _RIB2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		private string StrSql;

		public DataTable dt;

		internal virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Adresse_Soc
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

		internal virtual TextBox Nom_Soc
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

		internal virtual Button Valider
		{
			[CompilerGenerated]
			get
			{
				return _Valider;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Valider_Click;
				Button valider = _Valider;
				if (valider != null)
				{
					valider.Click -= value2;
				}
				_Valider = value;
				valider = _Valider;
				if (valider != null)
				{
					valider.Click += value2;
				}
			}
		}

		internal virtual Button Button22
		{
			[CompilerGenerated]
			get
			{
				return _Button22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button22_Click;
				Button button = _Button22;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button22 = value;
				button = _Button22;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox ADRESSE2
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

		internal virtual TextBox TEL
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

		internal virtual TextBox TEL2
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

		internal virtual TextBox FAX
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

		internal virtual TextBox EMAIL
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label8
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TVA
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox RIB
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

		internal virtual TextBox RIB2
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

		public Info_Societe()
		{
			base.KeyDown += Info_Societe_KeyDown;
			base.Load += Info_Societe_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Info_Societe));
			Label7 = new Label();
			Adresse_Soc = new TextBox();
			Label4 = new Label();
			Nom_Soc = new TextBox();
			Label5 = new Label();
			Valider = new Button();
			Button22 = new Button();
			ADRESSE2 = new TextBox();
			Label1 = new Label();
			TEL = new TextBox();
			Label2 = new Label();
			TEL2 = new TextBox();
			Label3 = new Label();
			FAX = new TextBox();
			Label6 = new Label();
			EMAIL = new TextBox();
			Label8 = new Label();
			TVA = new TextBox();
			Label10 = new Label();
			RIB = new TextBox();
			Label9 = new Label();
			RIB2 = new TextBox();
			Label11 = new Label();
			base.SuspendLayout();
			Label7.BackColor = Color.Transparent;
			Label7.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label7.ForeColor = SystemColors.MenuHighlight;
			Label7.Location = new Point(178, 50);
			Label7.Name = "Label7";
			Label7.Size = new Size(328, 26);
			Label7.TabIndex = 28;
			Label7.Text = "Entrer les informations de la société:";
			Adresse_Soc.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Adresse_Soc.Location = new Point(150, 169);
			Adresse_Soc.Name = "Adresse_Soc";
			Adresse_Soc.Size = new Size(536, 26);
			Adresse_Soc.TabIndex = 22;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label4.Location = new Point(15, 169);
			Label4.Name = "Label4";
			Label4.Size = new Size(129, 23);
			Label4.TabIndex = 26;
			Label4.Text = "Adresse société";
			Nom_Soc.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Nom_Soc.Location = new Point(150, 123);
			Nom_Soc.Name = "Nom_Soc";
			Nom_Soc.Size = new Size(536, 26);
			Nom_Soc.TabIndex = 21;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label5.Location = new Point(27, 123);
			Label5.Name = "Label5";
			Label5.Size = new Size(117, 23);
			Label5.TabIndex = 25;
			Label5.Text = "Nom Société";
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(401, 524);
			Valider.Name = "Valider";
			Valider.Size = new Size(143, 47);
			Valider.TabIndex = 77;
			Valider.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(150, 524);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 76;
			Button22.UseVisualStyleBackColor = false;
			ADRESSE2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			ADRESSE2.Location = new Point(150, 228);
			ADRESSE2.Name = "ADRESSE2";
			ADRESSE2.Size = new Size(536, 26);
			ADRESSE2.TabIndex = 78;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.Location = new Point(-2, 228);
			Label1.Name = "Label1";
			Label1.Size = new Size(146, 23);
			Label1.TabIndex = 79;
			Label1.Text = "Adresse société 2";
			TEL.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TEL.Location = new Point(150, 281);
			TEL.Name = "TEL";
			TEL.Size = new Size(154, 26);
			TEL.TabIndex = 80;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label2.Location = new Point(89, 281);
			Label2.Name = "Label2";
			Label2.Size = new Size(55, 23);
			Label2.TabIndex = 81;
			Label2.Text = "Tél";
			TEL2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TEL2.Location = new Point(401, 281);
			TEL2.Name = "TEL2";
			TEL2.Size = new Size(154, 26);
			TEL2.TabIndex = 82;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label3.Location = new Point(340, 284);
			Label3.Name = "Label3";
			Label3.Size = new Size(55, 23);
			Label3.TabIndex = 83;
			Label3.Text = "Tél 2";
			FAX.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			FAX.Location = new Point(150, 330);
			FAX.Name = "FAX";
			FAX.Size = new Size(154, 26);
			FAX.TabIndex = 84;
			Label6.BackColor = Color.Transparent;
			Label6.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label6.Location = new Point(99, 330);
			Label6.Name = "Label6";
			Label6.Size = new Size(55, 23);
			Label6.TabIndex = 85;
			Label6.Text = "Fax";
			EMAIL.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			EMAIL.Location = new Point(401, 333);
			EMAIL.Name = "EMAIL";
			EMAIL.Size = new Size(285, 26);
			EMAIL.TabIndex = 86;
			Label8.BackColor = Color.Transparent;
			Label8.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label8.Location = new Point(350, 333);
			Label8.Name = "Label8";
			Label8.Size = new Size(55, 23);
			Label8.TabIndex = 87;
			Label8.Text = "Email";
			TVA.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TVA.Location = new Point(150, 375);
			TVA.Name = "TVA";
			TVA.Size = new Size(536, 26);
			TVA.TabIndex = 88;
			Label10.BackColor = Color.Transparent;
			Label10.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label10.Location = new Point(89, 378);
			Label10.Name = "Label10";
			Label10.Size = new Size(55, 23);
			Label10.TabIndex = 89;
			Label10.Text = "TVA";
			RIB.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RIB.Location = new Point(150, 425);
			RIB.Name = "RIB";
			RIB.Size = new Size(536, 26);
			RIB.TabIndex = 90;
			Label9.BackColor = Color.Transparent;
			Label9.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label9.Location = new Point(89, 428);
			Label9.Name = "Label9";
			Label9.Size = new Size(55, 23);
			Label9.TabIndex = 91;
			Label9.Text = "RIB";
			RIB2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RIB2.Location = new Point(150, 476);
			RIB2.Name = "RIB2";
			RIB2.Size = new Size(536, 26);
			RIB2.TabIndex = 92;
			Label11.BackColor = Color.Transparent;
			Label11.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label11.Location = new Point(89, 479);
			Label11.Name = "Label11";
			Label11.Size = new Size(55, 23);
			Label11.TabIndex = 93;
			Label11.Text = "RIB2";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(700, 583);
			base.Controls.Add(RIB2);
			base.Controls.Add(Label11);
			base.Controls.Add(RIB);
			base.Controls.Add(Label9);
			base.Controls.Add(TVA);
			base.Controls.Add(Label10);
			base.Controls.Add(EMAIL);
			base.Controls.Add(Label8);
			base.Controls.Add(FAX);
			base.Controls.Add(Label6);
			base.Controls.Add(TEL2);
			base.Controls.Add(Label3);
			base.Controls.Add(TEL);
			base.Controls.Add(Label2);
			base.Controls.Add(ADRESSE2);
			base.Controls.Add(Label1);
			base.Controls.Add(Valider);
			base.Controls.Add(Button22);
			base.Controls.Add(Label7);
			base.Controls.Add(Adresse_Soc);
			base.Controls.Add(Label4);
			base.Controls.Add(Nom_Soc);
			base.Controls.Add(Label5);
			base.Name = "Info_Societe";
			Text = "Informations Société";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Valider_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string text = "SELECT * FROM SOCIETE";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					Globals.conn = new MySqlConnection(Globals.connStr);
					StrSql = "SELECT SOCIETE.* FROM SOCIETE";
					Globals.da.SelectCommand = new MySqlCommand(StrSql, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					Globals.ds.Clear();
					Globals.da.Fill(Globals.ds, "SOCIETE");
					dataTable = Globals.ds.Tables["SOCIETE"];
					DataRow dataRow = Globals.ds.Tables["SOCIETE"].NewRow();
					dataRow["NOM_SOC"] = Nom_Soc.Text;
					dataRow["ADRESSE_SOC"] = Adresse_Soc.Text;
					dataRow["ADRESSE2"] = ADRESSE2.Text;
					dataRow["TEL"] = TEL.Text;
					dataRow["TEL2"] = TEL2.Text;
					dataRow["FAX"] = FAX.Text;
					dataRow["EMAIL"] = EMAIL.Text;
					dataRow["TVA"] = TVA.Text;
					dataRow["RIB"] = RIB.Text;
					dataRow["RIB2"] = RIB2.Text;
					Globals.ds.Tables["SOCIETE"].Rows.Add(dataRow);
					MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(Globals.da);
					Globals.da.Update(Globals.ds, "SOCIETE");
					base.Show();
					Interaction.MsgBox("Société ajoutée", MsgBoxStyle.OkOnly, null);
					base.Close();
					Valider.Enabled = false;
				}
				else
				{
					string cmdText = "UPDATE SOCIETE SET nom_soc='" + Nom_Soc.Text + "' ,adresse_soc= '" + Adresse_Soc.Text + "',ADRESSE2='" + ADRESSE2.Text + "' ,TEL= '" + TEL.Text + "',TEL2='" + TEL2.Text + "' ,FAX= '" + FAX.Text + "',EMAIL='" + EMAIL.Text + "' ,TVA= '" + TVA.Text + "',RIB='" + RIB.Text + "' ,RIB2= '" + RIB2.Text + "' WHERE nom_soc= '" + Globals.NOMSOC + "'";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
					mySqlCommand2.ExecuteNonQuery();
					Interaction.MsgBox("Informations société mis à jour", MsgBoxStyle.OkOnly, null);
					base.Close();
				}
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				Globals.Societe();
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

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
		}

		private void Info_Societe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Info_Societe_Load(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select * from SOCIETE";
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					Nom_Soc.Text = mySqlDataReader["NOM_SOC"].ToString();
					Adresse_Soc.Text = mySqlDataReader["ADRESSE_SOC"].ToString();
					ADRESSE2.Text = mySqlDataReader["ADRESSE2"].ToString();
					TEL.Text = mySqlDataReader["TEL"].ToString();
					TEL2.Text = mySqlDataReader["TEL2"].ToString();
					FAX.Text = mySqlDataReader["FAX"].ToString();
					EMAIL.Text = mySqlDataReader["EMAIL"].ToString();
					TVA.Text = mySqlDataReader["TVA"].ToString();
					RIB.Text = mySqlDataReader["RIB"].ToString();
					RIB2.Text = mySqlDataReader["RIB2"].ToString();
				}
				Nom_Soc.Focus();
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
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
	}
}
