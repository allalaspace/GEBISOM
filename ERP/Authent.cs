using ERP.My;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Authent : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("groupBox1")]
		private GroupBox _groupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("button1")]
		private Button _button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

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
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btnvalider")]
		private Button _Btnvalider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		private string T1;

		private string T2;

		private string T3;

		private string T4;

		public int t;

		private FrmAccueil accueil;

		public string VEROUIL;

		public DateTime STARTTIME;

		public virtual GroupBox groupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button button1
		{
			[CompilerGenerated]
			get
			{
				return _button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = button1_Click;
				Button button = _button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_button1 = value;
				button = _button1;
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

		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return _Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Label3_Click;
				Label label = _Label3;
				if (label != null)
				{
					label.Click -= value2;
				}
				_Label3 = value;
				label = _Label3;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		internal virtual Label Label2
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

		internal virtual TextBox TextBox2
		{
			[CompilerGenerated]
			get
			{
				return _TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox2_Validated;
				TextBox textBox = _TextBox2;
				if (textBox != null)
				{
					textBox.Validated -= value2;
				}
				_TextBox2 = value;
				textBox = _TextBox2;
				if (textBox != null)
				{
					textBox.Validated += value2;
				}
			}
		}

		public virtual Button Btnvalider
		{
			[CompilerGenerated]
			get
			{
				return _Btnvalider;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Btnvalider_Click;
				Button btnvalider = _Btnvalider;
				if (btnvalider != null)
				{
					btnvalider.Click -= value2;
				}
				_Btnvalider = value;
				btnvalider = _Btnvalider;
				if (btnvalider != null)
				{
					btnvalider.Click += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return _PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = PictureBox1_Click;
				PictureBox pictureBox = _PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				_PictureBox1 = value;
				pictureBox = _PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Authent()
		{
			base.KeyDown += Authent_KeyDown;
			base.Load += Authent_Load;
			t = 0;
			accueil = new FrmAccueil();
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

		//[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Authent));
			groupBox1 = new GroupBox();
			PictureBox1 = new PictureBox();
			button1 = new Button();
			Label1 = new Label();
			Label3 = new Label();
			Label2 = new Label();
			TextBox1 = new TextBox();
			Btnvalider = new Button();
			TextBox2 = new TextBox();
			PictureBox2 = new PictureBox();
			groupBox1.SuspendLayout();
			((ISupportInitialize)PictureBox1).BeginInit();
			((ISupportInitialize)PictureBox2).BeginInit();
			base.SuspendLayout();
			groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			groupBox1.BackColor = Color.Transparent;
			groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			groupBox1.Controls.Add(PictureBox2);
			groupBox1.Controls.Add(PictureBox1);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(Label1);
			groupBox1.Controls.Add(Label3);
			groupBox1.Controls.Add(Label2);
			groupBox1.Controls.Add(TextBox1);
			groupBox1.Controls.Add(Btnvalider);
			groupBox1.Controls.Add(TextBox2);
			groupBox1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(488, 172);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(682, 342);
			groupBox1.TabIndex = 15;
			groupBox1.TabStop = false;
			groupBox1.Text = "ERP";
			PictureBox1.BackColor = Color.Transparent;
			PictureBox1.Cursor = Cursors.Hand;
			//PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox1.Location = new Point(24, 43);
			PictureBox1.Margin = new Padding(3, 4, 3, 4);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(89, 68);
			PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 110;
			PictureBox1.TabStop = false;
			PictureBox1.Visible = false;
			button1.BackColor = SystemColors.ActiveBorder;
			//button1.BackgroundImage = (Image)componentResourceManager.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.None;
			button1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.Location = new Point(608, 257);
			button1.Name = "button1";
			button1.Size = new Size(68, 68);
			button1.TabIndex = 16;
			button1.UseVisualStyleBackColor = false;
			Label1.BackColor = Color.Transparent;
			Label1.FlatStyle = FlatStyle.Flat;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.ForeColor = SystemColors.ControlLightLight;
			Label1.Location = new Point(147, 43);
			Label1.Name = "Label1";
			Label1.Size = new Size(138, 23);
			Label1.TabIndex = 7;
			Label1.Text = "Login ID:";
			Label3.BackColor = Color.Transparent;
			Label3.Location = new Point(119, 43);
			Label3.Name = "Label3";
			Label3.Size = new Size(22, 139);
			Label3.TabIndex = 13;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label2.ForeColor = SystemColors.ControlLightLight;
			Label2.Location = new Point(147, 119);
			Label2.Name = "Label2";
			Label2.Size = new Size(138, 23);
			Label2.TabIndex = 11;
			Label2.Text = "Password:";
			TextBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox1.Location = new Point(159, 69);
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(173, 26);
			TextBox1.TabIndex = 8;
			Btnvalider.BackColor = Color.Transparent;
			//Btnvalider.BackgroundImage = (Image)componentResourceManager.GetObject("Btnvalider.BackgroundImage");
			Btnvalider.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Btnvalider.Location = new Point(310, 257);
			Btnvalider.Name = "Btnvalider";
			Btnvalider.Size = new Size(130, 68);
			Btnvalider.TabIndex = 10;
			Btnvalider.UseVisualStyleBackColor = false;
			TextBox2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox2.Location = new Point(159, 148);
			TextBox2.Name = "TextBox2";
			TextBox2.PasswordChar = '*';
			TextBox2.Size = new Size(175, 26);
			TextBox2.TabIndex = 9;
			PictureBox2.BackColor = Color.Transparent;
			PictureBox2.Cursor = Cursors.Arrow;
			//PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
			PictureBox2.Location = new Point(159, 280);
			PictureBox2.Margin = new Padding(3, 4, 3, 4);
			PictureBox2.Name = "PictureBox2";
			PictureBox2.Size = new Size(58, 45);
			PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			PictureBox2.TabIndex = 111;
			PictureBox2.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			//BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(groupBox1);
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Authent";
			Text = "Authentification";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((ISupportInitialize)PictureBox1).EndInit();
			((ISupportInitialize)PictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		public void Btnvalider_Click(object sender, EventArgs e)
		{
			try
			{
                //var connStr = ConfigurationManager.ConnectionStrings["ERP_ConnectionString"].ToString();
                //MySqlConnection conn = new MySqlConnection(connStr);
                //conn.Open();

                //string sql = "show tables";
                //MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                //MySqlDataReader rdr = cmd.ExecuteReader();

                //while (rdr.Read())
                //{
                //    var rdrb = rdr[0].ToString();
                //}
                //rdr.Close();


                if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string text = "select * from TRIAL";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					string cmdText = "INSERT INTO TRIAL(START_TIME,VEROUILLE)VALUES('" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "','')";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
					mySqlCommand2.ExecuteNonQuery();
				}
				else
				{
					Globals.cmd.Connection = Globals.conn;
					Globals.cmd.CommandText = "select START_TIME,VEROUILLE from TRIAL";
					Globals.cmd.CommandType = CommandType.Text;
					MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						STARTTIME = Conversions.ToDate(mySqlDataReader["START_TIME"]);
						VEROUIL = mySqlDataReader["VEROUILLE"].ToString();
					}
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
				}
				entrer();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				//Exception ex2 = ex;
				//MessageBox.Show(ex2.Message.ToString());
				//ProjectData.ClearProjectError();
			}
			finally
			{
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
		}

		private unsafe void entrer()
		{
			checked
			{
				try
				{
					if (Btnvalider.Left != 0)
					{
						//ref int reference;
						//*(ref reference = ref t) = reference + 1;
					}
					if (t > 3)
					{
						base.Close();
					}
					else
					{
						string text = "SELECT UTILISATEUR.* FROM UTILISATEUR";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						DataSet dataSet = new DataSet();
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.SelectCommand = new MySqlCommand(text, Globals.conn);
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						mySqlDataAdapter.Fill(dataSet, "UTILISATEUR");
						dataTable = dataSet.Tables["UTILISATEUR"];
						int num = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							T3 = TextBox1.Text;
							T4 = TextBox2.Text;
							T1 = dataTable.Rows[i]["MATRICULE_UTI"].ToString();
							T2 = dataTable.Rows[i]["MOT_PASSE"].ToString();
							Globals.Mail_user = dataTable.Rows[i]["MAIL"].ToString();
							int num2 = string.Compare(T3, T1);
							int num3 = string.Compare(T4, T2);
							if (num2 == 0 & num3 == 0)
							{
								Globals.Utilisateur = T1;
								Globals.MDP = T2;
								Globals.Mail_user = Globals.Mail_user;
								Globals.conn.Close();
								accueil.ShowDialog();
								base.Close();
								return;
							}
						}
						MessageBox.Show("Numéro de matricule et\\ou mot de passe incorrecte", "Erreur");
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
					Globals.conn.Close();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void Label3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.FrmAccueil.Show();
		}

		private void Authent_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Authent_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			Screen.FromControl(this);
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

		private void TextBox2_Validated(object sender, EventArgs e)
		{
			Btnvalider_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.gebisom.com/");
		}
	}
}
