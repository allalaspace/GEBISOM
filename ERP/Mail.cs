using ERP.My;
using ERP.My.Resources;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Mail : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("corps")]
		private RichTextBox _corps;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chemin")]
		private TextBox _chemin;

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
		[AccessedThroughProperty("sujet")]
		private TextBox _sujet;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("sendtocci")]
		private Button _sendtocci;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cci_destin")]
		private TextBox _cci_destin;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cc_destin")]
		private TextBox _cc_destin;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("sendtoCC")]
		private Button _sendtoCC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("destinataire")]
		private TextBox _destinataire;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("SendTo")]
		private Button _SendTo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Expediteur")]
		private Label _Expediteur;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OFDMail")]
		private OpenFileDialog _OFDMail;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CB_ttclient")]
		private CheckBox _CB_ttclient;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("pathT")]
		private TextBox _pathT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("AjoutFJ")]
		private Button _AjoutFJ;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		public string taille;

		public int nbrefichjoint;

		public int CODE_FJ;

		public int NUMMAIL;

		internal virtual RichTextBox corps
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox chemin
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

		internal virtual TextBox sujet
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button sendtocci
		{
			[CompilerGenerated]
			get
			{
				return _sendtocci;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = sendtocci_Click;
				Button sendtocci = _sendtocci;
				if (sendtocci != null)
				{
					sendtocci.Click -= value2;
				}
				_sendtocci = value;
				sendtocci = _sendtocci;
				if (sendtocci != null)
				{
					sendtocci.Click += value2;
				}
			}
		}

		internal virtual TextBox cci_destin
		{
			[CompilerGenerated]
			get
			{
				return _cci_destin;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = cci_destin_KeyDown;
				TextBox cci_destin = _cci_destin;
				if (cci_destin != null)
				{
					cci_destin.KeyDown -= value2;
				}
				_cci_destin = value;
				cci_destin = _cci_destin;
				if (cci_destin != null)
				{
					cci_destin.KeyDown += value2;
				}
			}
		}

		internal virtual TextBox cc_destin
		{
			[CompilerGenerated]
			get
			{
				return _cc_destin;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = cc_destin_KeyDown;
				TextBox cc_destin = _cc_destin;
				if (cc_destin != null)
				{
					cc_destin.KeyDown -= value2;
				}
				_cc_destin = value;
				cc_destin = _cc_destin;
				if (cc_destin != null)
				{
					cc_destin.KeyDown += value2;
				}
			}
		}

		internal virtual Button sendtoCC
		{
			[CompilerGenerated]
			get
			{
				return _sendtoCC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = sendtoCC_Click;
				Button sendtoCC = _sendtoCC;
				if (sendtoCC != null)
				{
					sendtoCC.Click -= value2;
				}
				_sendtoCC = value;
				sendtoCC = _sendtoCC;
				if (sendtoCC != null)
				{
					sendtoCC.Click += value2;
				}
			}
		}

		internal virtual TextBox destinataire
		{
			[CompilerGenerated]
			get
			{
				return _destinataire;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = destinataire_KeyDown;
				TextBox destinataire = _destinataire;
				if (destinataire != null)
				{
					destinataire.KeyDown -= value2;
				}
				_destinataire = value;
				destinataire = _destinataire;
				if (destinataire != null)
				{
					destinataire.KeyDown += value2;
				}
			}
		}

		internal virtual Button SendTo
		{
			[CompilerGenerated]
			get
			{
				return _SendTo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = SendTo_Click;
				Button sendTo = _SendTo;
				if (sendTo != null)
				{
					sendTo.Click -= value2;
				}
				_SendTo = value;
				sendTo = _SendTo;
				if (sendTo != null)
				{
					sendTo.Click += value2;
				}
			}
		}

		internal virtual Button Button4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Expediteur
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

		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return _Button6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button6_Click;
				Button button = _Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button6 = value;
				button = _Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual OpenFileDialog OFDMail
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox CB_ttclient
		{
			[CompilerGenerated]
			get
			{
				return _CB_ttclient;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CB_ttclient_CheckedChanged;
				CheckBox cB_ttclient = _CB_ttclient;
				if (cB_ttclient != null)
				{
					cB_ttclient.CheckedChanged -= value2;
				}
				_CB_ttclient = value;
				cB_ttclient = _CB_ttclient;
				if (cB_ttclient != null)
				{
					cB_ttclient.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox pathT
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button AjoutFJ
		{
			[CompilerGenerated]
			get
			{
				return _AjoutFJ;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = AjoutFJ_Click;
				Button ajoutFJ = _AjoutFJ;
				if (ajoutFJ != null)
				{
					ajoutFJ.Click -= value2;
				}
				_AjoutFJ = value;
				ajoutFJ = _AjoutFJ;
				if (ajoutFJ != null)
				{
					ajoutFJ.Click += value2;
				}
			}
		}

		internal virtual DataGridView dgv1
		{
			[CompilerGenerated]
			get
			{
				return _dgv1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = DataGridView1_CellContentClick;
				DataGridView dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellContentClick -= value2;
				}
				_dgv1 = value;
				dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellContentClick += value2;
				}
			}
		}

		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Mail()
		{
			base.Load += Mail_Load;
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
			corps = new RichTextBox();
			chemin = new TextBox();
			Label1 = new Label();
			Label2 = new Label();
			sujet = new TextBox();
			sendtocci = new Button();
			cci_destin = new TextBox();
			cc_destin = new TextBox();
			sendtoCC = new Button();
			destinataire = new TextBox();
			SendTo = new Button();
			Button4 = new Button();
			Expediteur = new Label();
			Button5 = new Button();
			Button6 = new Button();
			OFDMail = new OpenFileDialog();
			CB_ttclient = new CheckBox();
			pathT = new TextBox();
			AjoutFJ = new Button();
			dgv1 = new DataGridView();
			Label3 = new Label();
			((ISupportInitialize)dgv1).BeginInit();
			base.SuspendLayout();
			corps.Location = new Point(69, 473);
			corps.Name = "corps";
			corps.Size = new Size(754, 196);
			corps.TabIndex = 105;
			corps.Text = "";
			chemin.Location = new Point(193, 418);
			chemin.Name = "chemin";
			chemin.ReadOnly = true;
			chemin.Size = new Size(630, 22);
			chemin.TabIndex = 106;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(118, 419);
			Label1.Name = "Label1";
			Label1.Size = new Size(69, 18);
			Label1.TabIndex = 107;
			Label1.Text = "Attaché: ";
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label2.ForeColor = SystemColors.ActiveCaption;
			Label2.Location = new Point(126, 381);
			Label2.Name = "Label2";
			Label2.Size = new Size(53, 18);
			Label2.TabIndex = 109;
			Label2.Text = "Objet: ";
			sujet.Location = new Point(193, 380);
			sujet.Name = "sujet";
			sujet.Size = new Size(630, 22);
			sujet.TabIndex = 108;
			sendtocci.Cursor = Cursors.Hand;
			sendtocci.Location = new Point(112, 335);
			sendtocci.Name = "sendtocci";
			sendtocci.Size = new Size(75, 23);
			sendtocci.TabIndex = 110;
			sendtocci.Text = "CCi...";
			sendtocci.UseVisualStyleBackColor = true;
			cci_destin.Location = new Point(193, 336);
			cci_destin.Name = "cci_destin";
			cci_destin.Size = new Size(630, 22);
			cci_destin.TabIndex = 111;
			cc_destin.Location = new Point(193, 289);
			cc_destin.Name = "cc_destin";
			cc_destin.Size = new Size(630, 22);
			cc_destin.TabIndex = 113;
			sendtoCC.Cursor = Cursors.Hand;
			sendtoCC.Location = new Point(112, 288);
			sendtoCC.Name = "sendtoCC";
			sendtoCC.Size = new Size(75, 23);
			sendtoCC.TabIndex = 112;
			sendtoCC.Text = "Cc...";
			sendtoCC.UseVisualStyleBackColor = true;
			destinataire.Location = new Point(193, 251);
			destinataire.Name = "destinataire";
			destinataire.Size = new Size(630, 22);
			destinataire.TabIndex = 115;
			SendTo.Cursor = Cursors.Hand;
			SendTo.Location = new Point(112, 250);
			SendTo.Name = "SendTo";
			SendTo.Size = new Size(75, 23);
			SendTo.TabIndex = 114;
			SendTo.Text = "A...";
			SendTo.UseVisualStyleBackColor = true;
			Button4.Cursor = Cursors.Hand;
			Button4.Location = new Point(109, 213);
			Button4.Name = "Button4";
			Button4.Size = new Size(75, 23);
			Button4.TabIndex = 116;
			Button4.Text = "De";
			Button4.UseVisualStyleBackColor = true;
			Expediteur.AutoSize = true;
			Expediteur.BackColor = Color.Transparent;
			Expediteur.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Expediteur.ForeColor = SystemColors.ActiveCaption;
			Expediteur.Location = new Point(190, 217);
			Expediteur.Name = "Expediteur";
			Expediteur.Size = new Size(29, 18);
			Expediteur.TabIndex = 117;
			Expediteur.Text = "De";
			Button5.BackgroundImage = Resources.Envoyer;
			Button5.Cursor = Cursors.Hand;
			Button5.Location = new Point(22, 207);
			Button5.Name = "Button5";
			Button5.Size = new Size(63, 82);
			Button5.TabIndex = 118;
			Button5.UseVisualStyleBackColor = true;
			Button6.BackgroundImage = Resources.joindre_fichier1;
			Button6.Cursor = Cursors.Hand;
			Button6.Location = new Point(805, 56);
			Button6.Name = "Button6";
			Button6.Size = new Size(62, 82);
			Button6.TabIndex = 119;
			Button6.UseVisualStyleBackColor = true;
			CB_ttclient.AutoSize = true;
			CB_ttclient.BackColor = Color.Transparent;
			CB_ttclient.Cursor = Cursors.Hand;
			CB_ttclient.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CB_ttclient.Location = new Point(193, 176);
			CB_ttclient.Name = "CB_ttclient";
			CB_ttclient.Size = new Size(144, 22);
			CB_ttclient.TabIndex = 120;
			CB_ttclient.Text = "Tous les clients";
			CB_ttclient.UseVisualStyleBackColor = false;
			pathT.Location = new Point(545, 79);
			pathT.Name = "pathT";
			pathT.ReadOnly = true;
			pathT.Size = new Size(233, 22);
			pathT.TabIndex = 121;
			AjoutFJ.Cursor = Cursors.Hand;
			AjoutFJ.Location = new Point(620, 107);
			AjoutFJ.Name = "AjoutFJ";
			AjoutFJ.Size = new Size(82, 26);
			AjoutFJ.TabIndex = 122;
			AjoutFJ.Text = "Ajouter";
			AjoutFJ.UseVisualStyleBackColor = true;
			dgv1.BackgroundColor = Color.White;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.GridColor = SystemColors.ActiveCaptionText;
			dgv1.Location = new Point(430, 140);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(393, 95);
			dgv1.TabIndex = 123;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label3.ForeColor = SystemColors.ActiveCaption;
			Label3.Location = new Point(566, 149);
			Label3.Name = "Label3";
			Label3.Size = new Size(158, 18);
			Label3.TabIndex = 124;
			Label3.Text = "Pas de pièces jointes";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(Label3);
			base.Controls.Add(dgv1);
			base.Controls.Add(AjoutFJ);
			base.Controls.Add(pathT);
			base.Controls.Add(CB_ttclient);
			base.Controls.Add(Button6);
			base.Controls.Add(Button5);
			base.Controls.Add(Expediteur);
			base.Controls.Add(Button4);
			base.Controls.Add(destinataire);
			base.Controls.Add(SendTo);
			base.Controls.Add(cc_destin);
			base.Controls.Add(sendtoCC);
			base.Controls.Add(cci_destin);
			base.Controls.Add(sendtocci);
			base.Controls.Add(Label2);
			base.Controls.Add(sujet);
			base.Controls.Add(Label1);
			base.Controls.Add(corps);
			base.Controls.Add(chemin);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Mail";
			Text = "Mail";
			base.Controls.SetChildIndex(chemin, 0);
			base.Controls.SetChildIndex(corps, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(sujet, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(sendtocci, 0);
			base.Controls.SetChildIndex(cci_destin, 0);
			base.Controls.SetChildIndex(sendtoCC, 0);
			base.Controls.SetChildIndex(cc_destin, 0);
			base.Controls.SetChildIndex(SendTo, 0);
			base.Controls.SetChildIndex(destinataire, 0);
			base.Controls.SetChildIndex(Button4, 0);
			base.Controls.SetChildIndex(Expediteur, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.Controls.SetChildIndex(Button6, 0);
			base.Controls.SetChildIndex(CB_ttclient, 0);
			base.Controls.SetChildIndex(pathT, 0);
			base.Controls.SetChildIndex(AjoutFJ, 0);
			base.Controls.SetChildIndex(dgv1, 0);
			base.Controls.SetChildIndex(Label3, 0);
			((ISupportInitialize)dgv1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Mail_Load(object sender, EventArgs e)
		{
			Globals.ClearTextBox(this);
			Globals.ClearComboBox(this);
			Expediteur.Text = Globals.Mail_user;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
				workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				string text = "select * from Fichier_joint";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = dataTable.Rows.Count - 1;
				if (num == -1)
				{
					NUMMAIL = 1;
				}
				else
				{
					mySqlCommand.CommandText = "SELECT IFNULL(MAX(NUM_MAIL)+1,0) FROM Fichier_joint ";
					NUMMAIL = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
				}
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Outlook.Application application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
			MailItem mailItem = (MailItem)application.CreateItem(OlItemType.olMailItem);
			MailItem mailItem2 = mailItem;
			mailItem2.HTMLBody = corps.Text;
			mailItem2.Subject = sujet.Text;
			mailItem2.SentOnBehalfOfName = Globals.Mail_user;
			if (Operators.CompareString(destinataire.Text, "", false) != 0)
			{
				mailItem2.Recipients.Add(destinataire.Text);
			}
			checked
			{
				if (Operators.CompareString(chemin.Text, "", false) != 0)
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct Chemin from Fichier_joint where num_mail='" + Conversions.ToString(NUMMAIL) + "'";
					mySqlDataAdapter.Fill(dataSet, "FJ");
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						mailItem2.Attachments.Add(dataSet.Tables[0].Rows[i]["Chemin"].ToString(), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
					}
				}
				mailItem2.Importance = OlImportance.olImportanceHigh;
				mailItem2.Display(RuntimeHelpers.GetObjectValue(Missing.Value));
				mailItem2 = null;
				Mail_Load(RuntimeHelpers.GetObjectValue(sender), e);
				dgv1.DataSource = null;
				dgv1.Rows.Clear();
			}
		}

		public object CreateObjectInstance(string objectName)
		{
			if (objectName.LastIndexOf(".") == -1)
			{
				objectName = Assembly.GetEntryAssembly().GetName().Name + "." + objectName;
			}
			return RuntimeHelpers.GetObjectValue(Assembly.GetEntryAssembly().CreateInstance(objectName));
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			string empty = string.Empty;
			OFDMail.ShowDialog();
			empty = OFDMail.FileName;
			if (empty != null)
			{
				pathT.Text = empty;
			}
		}

		public string FileNameWithoutExtension(string FullPath)
		{
			return Path.GetFileNameWithoutExtension(FullPath);
		}

		public string Filelength(string FullPath)
		{
			FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(FullPath);
			taille = Conversions.ToString(fileInfo.Length) + " bytes.";
			return taille;
		}

		private void SendTo_Click(object sender, EventArgs e)
		{
			Globals.flag_COD_client = "Mail_A";
			MyProject.Forms.Affich_code_client.Show();
			MyProject.Forms.Affich_code_client.BringToFront();
			string query = "select distinct IDCLIENT,NOM, mail from CLIENT";
			MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
			MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
			Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "Affich");
			DataGridView dgvC = MyProject.Forms.Affich_code_client.dgvC;
			dgvC.Columns[0].HeaderCell.Value = "Id. Client";
			dgvC.Columns[1].HeaderCell.Value = "Nom";
			dgvC.Columns[0].Width = 140;
			dgvC.Columns[1].Width = 240;
			dgvC = null;
			int num = checked(MyProject.Forms.Affich_code_client.dgvC.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
		}

		private void destinataire_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				SendTo_Click(1, e);
				e.Handled = true;
			}
		}

		private void cc_destin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				sendtoCC_Click(1, e);
				e.Handled = true;
			}
		}

		private void cci_destin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				sendtocci_Click(1, e);
				e.Handled = true;
			}
		}

		private void sendtoCC_Click(object sender, EventArgs e)
		{
			Globals.flag_COD_client = "Mail_CC";
			MyProject.Forms.Affich_code_client.Show();
			MyProject.Forms.Affich_code_client.BringToFront();
			string query = "select distinct IDCLIENT,NOM, mail from CLIENT";
			MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
			MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
			Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "Affich");
			DataGridView dgvC = MyProject.Forms.Affich_code_client.dgvC;
			dgvC.Columns[0].HeaderCell.Value = "Id. Client";
			dgvC.Columns[1].HeaderCell.Value = "Nom";
			dgvC.Columns[0].Width = 140;
			dgvC.Columns[1].Width = 240;
			dgvC = null;
			int num = checked(MyProject.Forms.Affich_code_client.dgvC.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
		}

		private void sendtocci_Click(object sender, EventArgs e)
		{
			Globals.flag_COD_client = "Mail_CCi";
			MyProject.Forms.Affich_code_client.Show();
			MyProject.Forms.Affich_code_client.BringToFront();
			string query = "select distinct IDCLIENT,NOM, mail from CLIENT";
			MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
			MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
			Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "Affich");
			DataGridView dgvC = MyProject.Forms.Affich_code_client.dgvC;
			dgvC.Columns[0].HeaderCell.Value = "Id. Client";
			dgvC.Columns[1].HeaderCell.Value = "Nom";
			dgvC.Columns[0].Width = 140;
			dgvC.Columns[1].Width = 240;
			dgvC = null;
			int num = checked(MyProject.Forms.Affich_code_client.dgvC.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					MyProject.Forms.Affich_code_client.dgvC.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
		}

		private void CB_ttclient_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (CB_ttclient.Checked)
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct mail from CLIENT";
					mySqlDataAdapter.Fill(dataSet, "User");
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						TextBox destinataire;
						(destinataire = this.destinataire).Text = destinataire.Text + dataSet.Tables[0].Rows[i]["mail"].ToString() + ";";
					}
				}
				else
				{
					this.destinataire.Text = "";
				}
			}
		}

		public void AjoutFJ_Click(object sender, EventArgs e)
		{
			if (Globals.conn.State == ConnectionState.Closed)
			{
				Globals.conn.Open();
			}
			if (Operators.CompareString(pathT.Text, "", false) == 0)
			{
				MessageBox.Show("Merci de bien choisir un fihier !");
			}
			else
			{
				Label3.Visible = false;
				string text = "select * from Fichier_joint";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
				MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					CODE_FJ = 1;
				}
				else
				{
					mySqlCommand.CommandText = "SELECT MAX(code_fichier)+1 FROM Fichier_joint ";
					CODE_FJ = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
				}
				chemin.Text = FileNameWithoutExtension(pathT.Text);
				taille = Filelength(pathT.Text);
				MySqlCommand mySqlCommand2 = new MySqlCommand("INSERT INTO Fichier_joint(code_fichier, Nom, TAILLE, chemin, num_mail)VALUES('" + Conversions.ToString(CODE_FJ) + "', '" + FileNameWithoutExtension(pathT.Text) + "', '" + taille + "', @ch, '" + Conversions.ToString(NUMMAIL) + "')", Globals.conn);
				mySqlCommand2.Parameters.AddWithValue("@ch", pathT.Text);
				mySqlCommand2.ExecuteNonQuery();
				string query = "Select code_fichier, Nom, taille from Fichier_joint where num_mail='" + Conversions.ToString(NUMMAIL) + "'";
				dgv1.DataSource = null;
				dgv1.Columns.Clear();
				dgv1.Rows.Clear();
				Globals.LoadData(query, dgv1, "Fichier_joint");
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Supprimer";
				dataGridViewButtonColumn.Text = "Supprimer";
				dataGridViewButtonColumn.Name = "btn";
				dataGridViewButtonColumn.Width = 80;
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				dgv1.Columns.Insert(3, dataGridViewButtonColumn);
				formatDGV(dgv1);
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
			}
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM Fichier_joint WHERE code_fichier='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.ExecuteNonQuery();
					dgv1.Rows.Remove(dgv1.CurrentRow);
					goto IL_00df;
				}
				return;
			}
			goto IL_00df;
			IL_00df:
			if (Globals.conn != null)
			{
				Globals.conn.Close();
			}
		}

		public void formatDGV(object dgv1)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				0
			}, null, null, null), null, "visible", new object[1]
			{
				false
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				1
			}, null, null, null), null, "Width", new object[1]
			{
				150
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				2
			}, null, null, null), null, "Width", new object[1]
			{
				100
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dgv1, null, "Columns", new object[1]
			{
				3
			}, null, null, null), null, "Width", new object[1]
			{
				120
			}, null, null, false, true);
			object obj = null;
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(dgv1, null, "Rows", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					object[] obj2 = new object[1]
					{
						i
					};
					object[] array = obj2;
					bool[] obj3 = new bool[1]
					{
						true
					};
					bool[] array2 = obj3;
					object instance = NewLateBinding.LateGet(dgv1, null, "Rows", obj2, null, null, obj3);
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[1]
					{
						Color.LightBlue
					}, null, null, false, true);
				}
				else
				{
					object[] obj4 = new object[1]
					{
						i
					};
					object[] array = obj4;
					bool[] obj5 = new bool[1]
					{
						true
					};
					bool[] array2 = obj5;
					object instance = NewLateBinding.LateGet(dgv1, null, "Rows", obj4, null, null, obj5);
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[1]
					{
						Color.White
					}, null, null, false, true);
				}
			}
		}
	}
}
