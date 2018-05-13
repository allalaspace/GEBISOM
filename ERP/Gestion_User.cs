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
	public class Gestion_User : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("button2")]
		private Button _button2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MAIL_USER")]
		private TextBox _MAIL_USER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		private string T1;

		private string T2;

		private string T3;

		private string T4;

		private string StrSql;

		public DataTable dt;

		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return _Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label6_Click;
				Label label = _Label6;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label6 = value;
				label = _Label6;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox3
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

		internal virtual TextBox TextBox4
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

		internal virtual GroupBox GroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TextBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox TextBox1
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

		internal virtual Label Label1
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

		internal virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button button2
		{
			[CompilerGenerated]
			get
			{
				return _button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button2_Click;
				EventHandler value3 = button2_Enter;
				Button button = _button2;
				if (button != null)
				{
					button.Click -= value2;
					button.Enter -= value3;
				}
				_button2 = value;
				button = _button2;
				if (button != null)
				{
					button.Click += value2;
					button.Enter += value3;
				}
			}
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
				EventHandler value3 = Button1_Enter;
				Button button = _Button1;
				if (button != null)
				{
					button.Click -= value2;
					button.Enter -= value3;
				}
				_Button1 = value;
				button = _Button1;
				if (button != null)
				{
					button.Click += value2;
					button.Enter += value3;
				}
			}
		}

		internal virtual TextBox MAIL_USER
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

		public Gestion_User()
		{
			base.Load += formajout_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gestion_User));
			Label6 = new Label();
			TextBox3 = new TextBox();
			Label4 = new Label();
			TextBox4 = new TextBox();
			Label5 = new Label();
			GroupBox1 = new GroupBox();
			MAIL_USER = new TextBox();
			Label8 = new Label();
			Button1 = new Button();
			TextBox2 = new TextBox();
			TextBox1 = new TextBox();
			Label3 = new Label();
			Label1 = new Label();
			Label2 = new Label();
			Label7 = new Label();
			button2 = new Button();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			Label6.BackColor = Color.WhiteSmoke;
			Label6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label6.Location = new Point(338, 33);
			Label6.Name = "Label6";
			Label6.Size = new Size(51, 24);
			Label6.TabIndex = 19;
			TextBox3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox3.Location = new Point(308, 116);
			TextBox3.Name = "TextBox3";
			TextBox3.PasswordChar = '*';
			TextBox3.Size = new Size(154, 26);
			TextBox3.TabIndex = 2;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label4.Location = new Point(185, 116);
			Label4.Name = "Label4";
			Label4.Size = new Size(119, 23);
			Label4.TabIndex = 17;
			Label4.Text = "Mot De Passe";
			TextBox4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox4.Location = new Point(308, 76);
			TextBox4.Name = "TextBox4";
			TextBox4.Size = new Size(154, 26);
			TextBox4.TabIndex = 1;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label5.Location = new Point(185, 76);
			Label5.Name = "Label5";
			Label5.Size = new Size(112, 23);
			Label5.TabIndex = 14;
			Label5.Text = "MATRICULE";
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.Controls.Add(MAIL_USER);
			GroupBox1.Controls.Add(Label8);
			GroupBox1.Controls.Add(Button1);
			GroupBox1.Controls.Add(TextBox2);
			GroupBox1.Controls.Add(TextBox1);
			GroupBox1.Controls.Add(Label3);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Label2);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox1.Location = new Point(124, 244);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(523, 220);
			GroupBox1.TabIndex = 4;
			GroupBox1.TabStop = false;
			MAIL_USER.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MAIL_USER.Location = new Point(184, 176);
			MAIL_USER.Name = "MAIL_USER";
			MAIL_USER.Size = new Size(154, 26);
			MAIL_USER.TabIndex = 6;
			Label8.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label8.Location = new Point(52, 179);
			Label8.Name = "Label8";
			Label8.Size = new Size(121, 23);
			Label8.TabIndex = 28;
			Label8.Text = "MAIL USER";
			Button1.BackColor = Color.Transparent;
			Button1.Cursor = Cursors.Hand;
			Button1.FlatStyle = FlatStyle.Flat;
			Button1.ForeColor = Color.Transparent;
			Button1.Image = (Image)componentResourceManager.GetObject("Button1.Image");
			Button1.Location = new Point(361, 92);
			Button1.Name = "Button1";
			Button1.Size = new Size(143, 47);
			Button1.TabIndex = 7;
			Button1.UseVisualStyleBackColor = false;
			TextBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox2.Location = new Point(184, 128);
			TextBox2.Name = "TextBox2";
			TextBox2.PasswordChar = '*';
			TextBox2.Size = new Size(154, 26);
			TextBox2.TabIndex = 5;
			TextBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox1.Location = new Point(184, 80);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(154, 26);
			TextBox1.TabIndex = 4;
			Label3.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label3.ForeColor = SystemColors.Highlight;
			Label3.Location = new Point(8, 38);
			Label3.Name = "Label3";
			Label3.Size = new Size(509, 18);
			Label3.TabIndex = 5;
			Label3.Text = "Donner la matricule et le mot de passe que vous voulez ajouter (Champs sur 5 caractères)";
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.Location = new Point(61, 80);
			Label1.Name = "Label1";
			Label1.Size = new Size(112, 23);
			Label1.TabIndex = 2;
			Label1.Text = "MATRICULE";
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label2.Location = new Point(43, 131);
			Label2.Name = "Label2";
			Label2.Size = new Size(137, 23);
			Label2.TabIndex = 3;
			Label2.Text = "MOT DE PASSE";
			Label7.BackColor = Color.Transparent;
			Label7.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label7.ForeColor = SystemColors.MenuHighlight;
			Label7.Location = new Point(41, 33);
			Label7.Name = "Label7";
			Label7.Size = new Size(387, 26);
			Label7.TabIndex = 20;
			Label7.Text = "Entrer votre matricule et mot de passe";
			button2.BackColor = Color.Transparent;
			button2.Cursor = Cursors.Hand;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = Color.Transparent;
			button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
			button2.Location = new Point(399, 173);
			button2.Name = "button2";
			button2.Size = new Size(143, 47);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(821, 476);
			base.Controls.Add(button2);
			base.Controls.Add(Label7);
			base.Controls.Add(Label6);
			base.Controls.Add(TextBox3);
			base.Controls.Add(Label4);
			base.Controls.Add(TextBox4);
			base.Controls.Add(Label5);
			base.Controls.Add(GroupBox1);
			base.Name = "Gestion_User";
			Text = "Gestion Utilisateur";
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.conn = new MySqlConnection(Globals.connStr);
				StrSql = "SELECT UTILISATEUR.* FROM UTILISATEUR";
				Globals.da.SelectCommand = new MySqlCommand(StrSql, Globals.conn);
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.ds.Clear();
				Globals.da.Fill(Globals.ds, "UTILISATEUR");
				dt = Globals.ds.Tables["UTILISATEUR"];
				DataRow dataRow = Globals.ds.Tables["UTILISATEUR"].NewRow();
				dataRow["MATRICULE_UTI"] = TextBox1.Text;
				dataRow["MOT_PASSE"] = TextBox2.Text;
				dataRow["longueur_ecran"] = Globals.screenHeight;
				dataRow["largeur_ecran"] = Globals.screenWidth;
				dataRow["MAIL"] = MAIL_USER.Text;
				Globals.ds.Tables["UTILISATEUR"].Rows.Add(dataRow);
				MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(Globals.da);
				Globals.da.Update(Globals.ds, "UTILISATEUR");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			finally
			{
				Globals.ds.Clear();
				Globals.da.Fill(Globals.ds, "UTILISATEUR");
				dt = Globals.ds.Tables["UTILISATEUR"];
				Globals.conn.Dispose();
			}
			Globals.conn.Close();
			base.Show();
			Interaction.MsgBox("Utilisateur ajouté", MsgBoxStyle.OkOnly, null);
			Button1.Enabled = false;
		}

		private void formajout_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
				workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
				GroupBox1.Visible = false;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Globals.conn = new MySqlConnection(Globals.connStr);
			StrSql = "SELECT UTILISATEUR.* FROM UTILISATEUR";
			Globals.da.SelectCommand = new MySqlCommand(StrSql, Globals.conn);
			if (Globals.conn.State == ConnectionState.Closed)
			{
				Globals.conn.Open();
			}
			Globals.ds.Clear();
			Globals.da.Fill(Globals.ds, "UTILISATEUR");
			dt = Globals.ds.Tables["UTILISATEUR"];
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					T3 = TextBox4.Text;
					T4 = TextBox3.Text;
					T1 = dt.Rows[i]["MATRICULE_UTI"].ToString();
					T2 = dt.Rows[i]["MOT_PASSE"].ToString();
					int num2 = string.Compare(T3, T1);
					int num3 = string.Compare(T4, T2);
					if (num2 == 0 & num3 == 0)
					{
						GroupBox1.Visible = true;
						Globals.conn.Close();
						return;
					}
				}
			}
			string text = Conversions.ToString((int)MessageBox.Show("NUMERO DE MATRICULE ET\\OU MOT DE PASSE INCORRECTE"));
		}

		private void Label6_Click(object sender, EventArgs e)
		{
			GroupBox1.Visible = true;
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

		private void button2_Enter(object sender, EventArgs e)
		{
			Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Button1_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir ajouter cet utilisateur?", "Ajout Utilisateur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}
}
