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
	public class Reglement : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Mode_Regl")]
		private ComboBox _Mode_Regl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Montant_DREG")]
		private TextBox _Montant_DREG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("code")]
		private Label _code;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODE_DREG")]
		private TextBox _CODE_DREG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider_Regl")]
		private Button _Valider_Regl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("label2")]
		private Label _label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NUMFACTURE")]
		private ComboBox _NUMFACTURE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("flag")]
		private Label _flag;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Mode_Regl2")]
		private ComboBox _Mode_Regl2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Montant_DREG2")]
		private TextBox _Montant_DREG2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("code2")]
		private Label _code2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODE_DREG2")]
		private TextBox _CODE_DREG2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Old_Regl")]
		private TextBox _Old_Regl;

		public int NUM_DREG;

		public int flag_multi;

		public decimal MONTANTREGL;

		public int FLAG_HISTO;

		public virtual ComboBox Mode_Regl
		{
			[CompilerGenerated]
			get
			{
				return _Mode_Regl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Mode_Regl_Click;
				EventHandler value3 = Mode_Reg_SelectedIndexChanged;
				ComboBox mode_Regl = _Mode_Regl;
				if (mode_Regl != null)
				{
					mode_Regl.Click -= value2;
					mode_Regl.SelectedIndexChanged -= value3;
				}
				_Mode_Regl = value;
				mode_Regl = _Mode_Regl;
				if (mode_Regl != null)
				{
					mode_Regl.Click += value2;
					mode_Regl.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual Label Label24
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Montant_DREG
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

		internal virtual Label code
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CODE_DREG
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Valider_Regl
		{
			[CompilerGenerated]
			get
			{
				return _Valider_Regl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Valider_Regl_Click;
				EventHandler value3 = Valider_Regl_Enter;
				Button valider_Regl = _Valider_Regl;
				if (valider_Regl != null)
				{
					valider_Regl.Click -= value2;
					valider_Regl.Enter -= value3;
				}
				_Valider_Regl = value;
				valider_Regl = _Valider_Regl;
				if (valider_Regl != null)
				{
					valider_Regl.Click += value2;
					valider_Regl.Enter += value3;
				}
			}
		}

		internal virtual Button Button29
		{
			[CompilerGenerated]
			get
			{
				return _Button29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button29_Click;
				Button button = _Button29;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button29 = value;
				button = _Button29;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual ComboBox NUMFACTURE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label flag
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

		public virtual ComboBox Mode_Regl2
		{
			[CompilerGenerated]
			get
			{
				return _Mode_Regl2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Mode_Regl2_Click;
				EventHandler value3 = Mode_Regl2_SelectedIndexChanged;
				ComboBox mode_Regl = _Mode_Regl2;
				if (mode_Regl != null)
				{
					mode_Regl.Click -= value2;
					mode_Regl.SelectedIndexChanged -= value3;
				}
				_Mode_Regl2 = value;
				mode_Regl = _Mode_Regl2;
				if (mode_Regl != null)
				{
					mode_Regl.Click += value2;
					mode_Regl.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual TextBox Montant_DREG2
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

		internal virtual Label code2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CODE_DREG2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = LinkLabel1_Enter;
				LinkLabelLinkClickedEventHandler value3 = LinkLabel1_LinkClicked;
				LinkLabel linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.Enter -= value2;
					linkLabel.LinkClicked -= value3;
				}
				_LinkLabel1 = value;
				linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.Enter += value2;
					linkLabel.LinkClicked += value3;
				}
			}
		}

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Old_Regl
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Reglement()
		{
			base.KeyDown += Reglement_KeyDown;
			base.Load += Reglement_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Reglement));
			Mode_Regl = new ComboBox();
			Label24 = new Label();
			Montant_DREG = new TextBox();
			Label1 = new Label();
			code = new Label();
			CODE_DREG = new TextBox();
			Valider_Regl = new Button();
			Button29 = new Button();
			NUMFACTURE = new ComboBox();
			label2 = new Label();
			flag = new Label();
			Label4 = new Label();
			Mode_Regl2 = new ComboBox();
			Montant_DREG2 = new TextBox();
			Label3 = new Label();
			code2 = new Label();
			CODE_DREG2 = new TextBox();
			LinkLabel1 = new LinkLabel();
			Label5 = new Label();
			Old_Regl = new TextBox();
			base.SuspendLayout();
			Mode_Regl.AllowDrop = true;
			Mode_Regl.FormattingEnabled = true;
			Mode_Regl.Location = new Point(186, 59);
			Mode_Regl.Margin = new Padding(4);
			Mode_Regl.Name = "Mode_Regl";
			Mode_Regl.Size = new Size(202, 26);
			Mode_Regl.TabIndex = 1;
			Label24.BackColor = Color.Transparent;
			Label24.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label24.Location = new Point(43, 62);
			Label24.Margin = new Padding(4, 0, 4, 0);
			Label24.Name = "Label24";
			Label24.Size = new Size(146, 30);
			Label24.TabIndex = 48;
			Label24.Text = "Mode Réglement";
			Montant_DREG.Location = new Point(186, 157);
			Montant_DREG.Name = "Montant_DREG";
			Montant_DREG.Size = new Size(153, 26);
			Montant_DREG.TabIndex = 3;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(85, 157);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(94, 30);
			Label1.TabIndex = 51;
			Label1.Text = "Montant";
			code.BackColor = Color.Transparent;
			code.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			code.Location = new Point(19, 112);
			code.Margin = new Padding(4, 0, 4, 0);
			code.Name = "code";
			code.Size = new Size(170, 25);
			code.TabIndex = 52;
			code.TextAlign = ContentAlignment.MiddleCenter;
			CODE_DREG.Location = new Point(186, 109);
			CODE_DREG.Name = "CODE_DREG";
			CODE_DREG.Size = new Size(153, 26);
			CODE_DREG.TabIndex = 2;
			Valider_Regl.BackColor = Color.Transparent;
			Valider_Regl.Cursor = Cursors.Hand;
			Valider_Regl.FlatStyle = FlatStyle.Flat;
			Valider_Regl.ForeColor = Color.Transparent;
			Valider_Regl.Image = (Image)componentResourceManager.GetObject("Valider_Regl.Image");
			Valider_Regl.Location = new Point(470, 226);
			Valider_Regl.Name = "Valider_Regl";
			Valider_Regl.Size = new Size(143, 47);
			Valider_Regl.TabIndex = 9;
			Valider_Regl.UseVisualStyleBackColor = false;
			Button29.BackColor = Color.Transparent;
			Button29.BackgroundImage = (Image)componentResourceManager.GetObject("Button29.BackgroundImage");
			Button29.Cursor = Cursors.Hand;
			Button29.FlatStyle = FlatStyle.Flat;
			Button29.ForeColor = Color.Transparent;
			Button29.Location = new Point(234, 226);
			Button29.Name = "Button29";
			Button29.Size = new Size(127, 47);
			Button29.TabIndex = 53;
			Button29.UseVisualStyleBackColor = false;
			NUMFACTURE.AllowDrop = true;
			NUMFACTURE.FormattingEnabled = true;
			NUMFACTURE.ItemHeight = 18;
			NUMFACTURE.Location = new Point(629, 16);
			NUMFACTURE.Margin = new Padding(4, 3, 4, 3);
			NUMFACTURE.MaxDropDownItems = 10;
			NUMFACTURE.Name = "NUMFACTURE";
			NUMFACTURE.Size = new Size(120, 26);
			NUMFACTURE.TabIndex = 63;
			NUMFACTURE.Visible = false;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ActiveCaption;
			label2.Location = new Point(524, 19);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(97, 18);
			label2.TabIndex = 62;
			label2.Text = "Num Facture";
			label2.Visible = false;
			flag.AutoSize = true;
			flag.Location = new Point(241, 9);
			flag.Name = "flag";
			flag.Size = new Size(0, 18);
			flag.TabIndex = 64;
			flag.Visible = false;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(442, 62);
			Label4.Margin = new Padding(4, 0, 4, 0);
			Label4.Name = "Label4";
			Label4.Size = new Size(146, 30);
			Label4.TabIndex = 59;
			Label4.Text = "Mode Réglement";
			Label4.Visible = false;
			Mode_Regl2.FormattingEnabled = true;
			Mode_Regl2.Location = new Point(596, 59);
			Mode_Regl2.Margin = new Padding(4);
			Mode_Regl2.Name = "Mode_Regl2";
			Mode_Regl2.Size = new Size(202, 26);
			Mode_Regl2.TabIndex = 6;
			Mode_Regl2.Visible = false;
			Montant_DREG2.Location = new Point(596, 157);
			Montant_DREG2.Name = "Montant_DREG2";
			Montant_DREG2.Size = new Size(153, 26);
			Montant_DREG2.TabIndex = 8;
			Montant_DREG2.Visible = false;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(485, 160);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(94, 30);
			Label3.TabIndex = 60;
			Label3.Text = "Montant";
			Label3.Visible = false;
			code2.BackColor = Color.Transparent;
			code2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			code2.Location = new Point(418, 112);
			code2.Margin = new Padding(4, 0, 4, 0);
			code2.Name = "code2";
			code2.Size = new Size(170, 25);
			code2.TabIndex = 61;
			code2.TextAlign = ContentAlignment.MiddleCenter;
			code2.Visible = false;
			CODE_DREG2.Location = new Point(596, 109);
			CODE_DREG2.Name = "CODE_DREG2";
			CODE_DREG2.Size = new Size(153, 26);
			CODE_DREG2.TabIndex = 7;
			CODE_DREG2.Visible = false;
			LinkLabel1.AutoSize = true;
			LinkLabel1.Location = new Point(414, 62);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new Size(189, 18);
			LinkLabel1.TabIndex = 5;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Ajouter un autre réglement";
			LinkLabel1.Visible = false;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(264, 7);
			Label5.Margin = new Padding(4, 0, 4, 0);
			Label5.Name = "Label5";
			Label5.Size = new Size(115, 30);
			Label5.TabIndex = 66;
			Label5.Text = "Montant réglé";
			Old_Regl.Location = new Point(386, 7);
			Old_Regl.Name = "Old_Regl";
			Old_Regl.ReadOnly = true;
			Old_Regl.Size = new Size(131, 26);
			Old_Regl.TabIndex = 65;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(813, 296);
			base.Controls.Add(Label5);
			base.Controls.Add(Old_Regl);
			base.Controls.Add(flag);
			base.Controls.Add(NUMFACTURE);
			base.Controls.Add(label2);
			base.Controls.Add(LinkLabel1);
			base.Controls.Add(CODE_DREG2);
			base.Controls.Add(code2);
			base.Controls.Add(Label3);
			base.Controls.Add(Montant_DREG2);
			base.Controls.Add(Mode_Regl2);
			base.Controls.Add(Label4);
			base.Controls.Add(Valider_Regl);
			base.Controls.Add(Button29);
			base.Controls.Add(CODE_DREG);
			base.Controls.Add(code);
			base.Controls.Add(Label1);
			base.Controls.Add(Montant_DREG);
			base.Controls.Add(Mode_Regl);
			base.Controls.Add(Label24);
			Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4);
			base.Name = "Reglement";
			Text = "Règlement";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Mode_Regl_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select distinct Mode_Regl from Reglement";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Mode_Regl.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						Mode_Regl.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
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

		private void Mode_Reg_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(Mode_Regl.Text, "Espece", false) == 0)
			{
				code.Text = "Nombre de pièces";
			}
			else if (Operators.CompareString(Mode_Regl.Text, "Carte", false) == 0)
			{
				code.Text = "Code Carte";
			}
			else if (Operators.CompareString(Mode_Regl.Text, "Cheque", false) == 0)
			{
				code.Text = "Code Chèque";
			}
			else if (Operators.CompareString(Mode_Regl.Text, "Autre", false) == 0)
			{
				code.Text = "Type";
			}
		}

		private void Reglement_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Reglement_Load(object sender, EventArgs e)
		{
			Mode_Regl.Focus();
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
				workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
				try
				{
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					MySqlCommand mySqlCommand = new MySqlCommand();
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "SELECT IFNULL(SUM(MONTANT_DREG),0) FROM DETAIL_REGLEMENT WHERE NUM_FACT='" + NUMFACTURE.Text + "'";
					Old_Regl.Text = Conversions.ToString(mySqlCommand.ExecuteScalar());
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

		private void Button29_Click(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
			Globals.ClearComboBox(this);
		}

		private void LinkLabel1_Enter(object sender, EventArgs e)
		{
			LinkLabel1.Visible = false;
			Label3.Visible = true;
			Label4.Visible = true;
			code2.Visible = true;
			Mode_Regl2.Visible = true;
			CODE_DREG2.Visible = true;
			Montant_DREG2.Visible = true;
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel1.Visible = false;
			Label3.Visible = true;
			Label4.Visible = true;
			code2.Visible = true;
			Mode_Regl2.Visible = true;
			CODE_DREG2.Visible = true;
			Montant_DREG2.Visible = true;
		}

		private void Mode_Regl2_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = "select distinct Mode_Regl from Reglement";
				Globals.cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Mode_Regl2.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						Mode_Regl2.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
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

		private void Mode_Regl2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(Mode_Regl2.Text, "Espece", false) == 0)
			{
				code2.Text = "Nombre de pièces";
			}
			else if (Operators.CompareString(Mode_Regl2.Text, "Carte", false) == 0)
			{
				code2.Text = "Code Carte";
			}
			else if (Operators.CompareString(Mode_Regl2.Text, "Cheque", false) == 0)
			{
				code2.Text = "Code Chèque";
			}
			else if (Operators.CompareString(Mode_Regl2.Text, "Autre", false) == 0)
			{
				code2.Text = "Type";
			}
		}

		private void Valider_Regl_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(Montant_DREG.Text) + Globals.controlNum(Montant_DREG2.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from DETAIL_REGLEMENT";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							NUM_DREG = 1;
						}
						else
						{
							mySqlCommand.CommandText = "SELECT MAX(NUM_DREG)+1 FROM DETAIL_REGLEMENT";
							NUM_DREG = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						if (flag_multi == 1)
						{
							string text2 = Mode_Regl.Text + "+" + Mode_Regl2.Text;
							string text3 = CODE_DREG.Text + "+" + CODE_DREG2.Text;
							decimal num2 = decimal.Add(Globals.convertDN(Montant_DREG.Text), Globals.convertDN(Montant_DREG2.Text));
							string cmdText;
							if (Conversions.ToDouble(flag.Text) == 1.0)
							{
								string query = "INSERT INTO DETAIL_REGLEMENT(NUM_DREG, MODE_REGL, CODE_DREG, MONTANT_DREG, NUM_FACT)VALUES('" + Conversions.ToString(NUM_DREG) + "','" + text2 + "','" + text3 + "','" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + "','" + NUMFACTURE.Text + "')";
								Globals.ExecuteInsertQuery(query);
								decimal value = Globals.convertDN(NUMFACTURE.Text);
								cmdText = "UPDATE TICKET t1 SET MODE_REGL='" + text2 + "',MONTANT_REGL =(SELECT IFNULL(SUM(MONTANT_DREG),0) MONTANT_DREG FROM DETAIL_REGLEMENT t2 WHERE NUM_FACT='" + Conversions.ToString(value) + "' GROUP BY NUM_FACT) WHERE EXISTS (Select 1 FROM DETAIL_REGLEMENT t2 WHERE(t1.NUM_FACT = t2.NUM_FACT) AND t1.NUM_FACT='" + Conversions.ToString(value) + "')";
							}
							else
							{
								string query = "INSERT INTO DETAIL_REGLEMENT(NUM_DREG, MODE_REGL, CODE_DREG, MONTANT_DREG, NUM_FACT)VALUES('" + Conversions.ToString(NUM_DREG) + "','" + text2 + "','" + text3 + "','" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + "','" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "')";
								Globals.ExecuteInsertQuery(query);
								cmdText = "UPDATE TICKET t1 SET MODE_REGL='" + text2 + "',MONTANT_REGL =(SELECT IFNULL(SUM(MONTANT_DREG),0) MONTANT_DREG FROM DETAIL_REGLEMENT t2 WHERE NUM_FACT='" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "' GROUP BY NUM_FACT) WHERE EXISTS (Select 1 FROM DETAIL_REGLEMENT t2 WHERE(t1.NUM_FACT = t2.NUM_FACT) AND t1.NUM_FACT='" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "')";
								MONTANTREGL = num2;
								MyProject.Forms.Gestion_Vente.Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
							}
							MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
							mySqlCommand2.ExecuteNonQuery();
						}
						else
						{
							string query2 = "INSERT INTO DETAIL_REGLEMENT(NUM_DREG, MODE_REGL, CODE_DREG, MONTANT_DREG, NUM_FACT)VALUES('" + Conversions.ToString(NUM_DREG) + "','" + Mode_Regl.Text + "','" + CODE_DREG.Text + "','" + Montant_DREG.Text + "','" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "')";
							Globals.ExecuteInsertQuery(query2);
							string cmdText2 = "UPDATE TICKET t1 SET MODE_REGL='" + Mode_Regl.Text + "', MONTANT_REGL =(SELECT IFNULL(SUM(MONTANT_DREG),0) MONTANT_DREG FROM DETAIL_REGLEMENT t2 WHERE NUM_FACT='" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "' GROUP BY NUM_FACT) WHERE EXISTS (Select 1 FROM DETAIL_REGLEMENT t2 WHERE(t1.NUM_FACT = t2.NUM_FACT) AND t1.NUM_FACT='" + Conversions.ToString(MyProject.Forms.Gestion_Vente.NUM_TICK) + "')";
							MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText2, Globals.conn);
							mySqlCommand3.ExecuteNonQuery();
							MONTANTREGL = Globals.convertDN(Montant_DREG.Text);
							MyProject.Forms.Gestion_Vente.Reste_A_Payer_Click(RuntimeHelpers.GetObjectValue(sender), e);
						}
						MessageBox.Show("Réglement validé");
						base.Close();
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

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.WParam.ToInt32() == 13)
			{
				SendKeys.Send("{Tab}");
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void Valider_Regl_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir valider ce règlement?", "Règlement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Valider_Regl_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}
}
