using ERP.My.Resources;
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
	public class Resolution_ecran : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("longueur")]
		private TextBox _longueur;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("largeur")]
		private TextBox _largeur;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("User_Screen")]
		private Label _User_Screen;

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

		internal virtual Label Label13
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

		internal virtual TextBox longueur
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox largeur
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label User_Screen
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Resolution_ecran()
		{
			base.KeyDown += Resolution_ecran_KeyDown;
			base.Load += Resolution_ecran_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Resolution_ecran));
			Label2 = new Label();
			Label1 = new Label();
			Valider = new Button();
			Button22 = new Button();
			Label13 = new Label();
			Label15 = new Label();
			longueur = new TextBox();
			largeur = new TextBox();
			User_Screen = new Label();
			base.SuspendLayout();
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(248, 126);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(35, 15);
			Label2.TabIndex = 77;
			Label2.Text = "Pixel";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(248, 71);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(35, 15);
			Label1.TabIndex = 76;
			Label1.Text = "Pixel";
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(297, 179);
			Valider.Name = "Valider";
			Valider.Size = new Size(143, 47);
			Valider.TabIndex = 75;
			Valider.UseVisualStyleBackColor = false;
			Button22.BackColor = Color.Transparent;
			Button22.BackgroundImage = (Image)componentResourceManager.GetObject("Button22.BackgroundImage");
			Button22.Cursor = Cursors.Hand;
			Button22.FlatStyle = FlatStyle.Flat;
			Button22.ForeColor = Color.Transparent;
			Button22.Location = new Point(53, 179);
			Button22.Name = "Button22";
			Button22.Size = new Size(127, 47);
			Button22.TabIndex = 74;
			Button22.UseVisualStyleBackColor = false;
			Label13.AutoSize = true;
			Label13.BackColor = Color.Transparent;
			Label13.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label13.Location = new Point(68, 67);
			Label13.Margin = new Padding(4, 0, 4, 0);
			Label13.Name = "Label13";
			Label13.Size = new Size(69, 19);
			Label13.TabIndex = 73;
			Label13.Text = "Largeur";
			Label15.AutoSize = true;
			Label15.BackColor = Color.Transparent;
			Label15.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label15.Location = new Point(55, 122);
			Label15.Margin = new Padding(4, 0, 4, 0);
			Label15.Name = "Label15";
			Label15.Size = new Size(84, 19);
			Label15.TabIndex = 72;
			Label15.Text = "Longueur";
			longueur.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			longueur.Location = new Point(142, 122);
			longueur.Margin = new Padding(4);
			longueur.Name = "longueur";
			longueur.Size = new Size(101, 27);
			longueur.TabIndex = 71;
			largeur.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			largeur.Location = new Point(145, 67);
			largeur.Margin = new Padding(4);
			largeur.Name = "largeur";
			largeur.Size = new Size(98, 27);
			largeur.TabIndex = 70;
			User_Screen.BackColor = Color.Transparent;
			User_Screen.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			User_Screen.ImageAlign = ContentAlignment.MiddleRight;
			User_Screen.Location = new Point(119, -2);
			User_Screen.Name = "User_Screen";
			User_Screen.Size = new Size(371, 28);
			User_Screen.TabIndex = 78;
			User_Screen.TextAlign = ContentAlignment.TopRight;
			base.AutoScaleDimensions = new SizeF(10f, 19f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(490, 274);
			base.Controls.Add(User_Screen);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(Valider);
			base.Controls.Add(Button22);
			base.Controls.Add(Label13);
			base.Controls.Add(Label15);
			base.Controls.Add(longueur);
			base.Controls.Add(largeur);
			Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			base.Margin = new Padding(5, 4, 5, 4);
			base.Name = "Resolution_ecran";
			Text = "Résolution écran";
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
				string cmdText = "UPDATE Utilisateur SET longueur_ecran='" + longueur.Text + "' ,largeur_ecran= '" + largeur.Text + "'  where matricule_Uti= '" + Globals.Utilisateur + "' ";
				MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
				mySqlCommand.ExecuteNonQuery();
				base.Close();
				MessageBox.Show("La résolution a été changé");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
		}

		private void Resolution_ecran_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Resolution_ecran_Load(object sender, EventArgs e)
		{
			try
			{
				User_Screen.Text = Globals.Utilisateur;
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select longueur_ecran,largeur_ecran from UTILISATEUR where matricule_Uti= '" + Globals.Utilisateur + "' ";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					longueur.Text = mySqlDataReader["longueur_ecran"].ToString();
					largeur.Text = mySqlDataReader["largeur_ecran"].ToString();
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
	}
}
