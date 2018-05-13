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
	public class Ajout_entree_Stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("quantite")]
		private TextBox _quantite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_Entree")]
		private TextBox _Date_Entree;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODETEXT")]
		private TextBox _CODETEXT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("fournisseur")]
		private ComboBox _fournisseur;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PRIX_A")]
		private TextBox _PRIX_A;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TYPE_ENTREE")]
		private ComboBox _TYPE_ENTREE;

		public string COD;

		public int COD_E;

		public MySqlCommand cmd;

		internal virtual TextBox quantite
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

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox Date_Entree
		{
			[CompilerGenerated]
			get
			{
				return _Date_Entree;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Date_Entree_Click;
				TextBox date_Entree = _Date_Entree;
				if (date_Entree != null)
				{
					date_Entree.Click -= value2;
				}
				_Date_Entree = value;
				date_Entree = _Date_Entree;
				if (date_Entree != null)
				{
					date_Entree.Click += value2;
				}
			}
		}

		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox LIBART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CODETEXT
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

		internal virtual Label Label12
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

		internal virtual MonthCalendar MonthCalendar1
		{
			[CompilerGenerated]
			get
			{
				return _MonthCalendar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DateRangeEventHandler value2 = MonthCalendar1_DateChanged;
				MonthCalendar monthCalendar = _MonthCalendar1;
				if (monthCalendar != null)
				{
					monthCalendar.DateChanged -= value2;
				}
				_MonthCalendar1 = value;
				monthCalendar = _MonthCalendar1;
				if (monthCalendar != null)
				{
					monthCalendar.DateChanged += value2;
				}
			}
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
				KeyEventHandler value2 = REFART_KeyDown;
				EventHandler value3 = REFART_SelectedIndexChanged;
				EventHandler value4 = REFART_Validated;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.KeyDown -= value2;
					rEFART.SelectedIndexChanged -= value3;
					rEFART.Validated -= value4;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.KeyDown += value2;
					rEFART.SelectedIndexChanged += value3;
					rEFART.Validated += value4;
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
				Button button = _Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button1 = value;
				button = _Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public virtual ComboBox fournisseur
		{
			[CompilerGenerated]
			get
			{
				return _fournisseur;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = fournisseur_KeyDown;
				EventHandler value3 = fournisseur_Validated;
				ComboBox fournisseur = _fournisseur;
				if (fournisseur != null)
				{
					fournisseur.KeyDown -= value2;
					fournisseur.Validated -= value3;
				}
				_fournisseur = value;
				fournisseur = _fournisseur;
				if (fournisseur != null)
				{
					fournisseur.KeyDown += value2;
					fournisseur.Validated += value3;
				}
			}
		}

		internal virtual Label Label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox PRIX_A
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
				EventHandler value3 = Valider_Enter;
				Button valider = _Valider;
				if (valider != null)
				{
					valider.Click -= value2;
					valider.Enter -= value3;
				}
				_Valider = value;
				valider = _Valider;
				if (valider != null)
				{
					valider.Click += value2;
					valider.Enter += value3;
				}
			}
		}

		internal virtual ComboBox TYPE_ENTREE
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Ajout_entree_Stock()
		{
			base.Load += frmNew_Load;
			cmd = new MySqlCommand();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ajout_entree_Stock));
			quantite = new TextBox();
			Label3 = new Label();
			Label5 = new Label();
			Date_Entree = new TextBox();
			Label6 = new Label();
			LIBART = new ComboBox();
			CODETEXT = new TextBox();
			Label2 = new Label();
			Label12 = new Label();
			fournisseur = new ComboBox();
			Label1 = new Label();
			MonthCalendar1 = new MonthCalendar();
			Button5 = new Button();
			REFART = new ComboBox();
			Button1 = new Button();
			Label4 = new Label();
			PRIX_A = new TextBox();
			Valider = new Button();
			TYPE_ENTREE = new ComboBox();
			base.SuspendLayout();
			quantite.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			quantite.Location = new Point(146, 202);
			quantite.Margin = new Padding(3, 4, 3, 4);
			quantite.Name = "quantite";
			quantite.Size = new Size(126, 26);
			quantite.TabIndex = 3;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(30, 206);
			Label3.Name = "Label3";
			Label3.Size = new Size(73, 19);
			Label3.TabIndex = 23;
			Label3.Text = "Quantité";
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(12, 343);
			Label5.Name = "Label5";
			Label5.Size = new Size(102, 19);
			Label5.TabIndex = 27;
			Label5.Text = "Fournisseur";
			Date_Entree.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Date_Entree.Location = new Point(144, 486);
			Date_Entree.Margin = new Padding(3, 4, 3, 4);
			Date_Entree.Name = "Date_Entree";
			Date_Entree.ReadOnly = true;
			Date_Entree.Size = new Size(199, 26);
			Date_Entree.TabIndex = 6;
			Date_Entree.TabStop = false;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label6.Location = new Point(10, 486);
			Label6.Name = "Label6";
			Label6.Size = new Size(96, 19);
			Label6.TabIndex = 29;
			Label6.Text = "Date entrée";
			LIBART.DropDownStyle = ComboBoxStyle.Simple;
			LIBART.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(146, 143);
			LIBART.Margin = new Padding(3, 4, 3, 4);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(270, 26);
			LIBART.TabIndex = 2;
			CODETEXT.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			CODETEXT.Location = new Point(424, 92);
			CODETEXT.Margin = new Padding(3, 4, 3, 4);
			CODETEXT.Name = "CODETEXT";
			CODETEXT.ReadOnly = true;
			CODETEXT.Size = new Size(77, 26);
			CODETEXT.TabIndex = 45;
			CODETEXT.Visible = false;
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(23, 92);
			Label2.Name = "Label2";
			Label2.Size = new Size(90, 19);
			Label2.TabIndex = 52;
			Label2.Text = "Réf. Article";
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label12.Location = new Point(25, 146);
			Label12.Name = "Label12";
			Label12.Size = new Size(88, 19);
			Label12.TabIndex = 46;
			Label12.Text = "Lib. Article";
			fournisseur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			fournisseur.AutoCompleteSource = AutoCompleteSource.ListItems;
			fournisseur.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			fournisseur.FormattingEnabled = true;
			fournisseur.Location = new Point(146, 338);
			fournisseur.Name = "fournisseur";
			fournisseur.Size = new Size(212, 26);
			fournisseur.TabIndex = 5;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(12, 410);
			Label1.Name = "Label1";
			Label1.Size = new Size(98, 19);
			Label1.TabIndex = 55;
			Label1.Text = "Type entrée";
			MonthCalendar1.Location = new Point(146, 486);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 56;
			MonthCalendar1.TabStop = false;
			MonthCalendar1.Visible = false;
			Button5.Location = new Point(385, 90);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 64;
			Button5.TabStop = false;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(148, 92);
			REFART.Name = "REFART";
			REFART.Size = new Size(254, 26);
			REFART.TabIndex = 1;
			Button1.Location = new Point(335, 337);
			Button1.Name = "Button1";
			Button1.Size = new Size(33, 28);
			Button1.TabIndex = 65;
			Button1.TabStop = false;
			Button1.Text = "...";
			Button1.UseVisualStyleBackColor = true;
			Label4.AutoSize = true;
			Label4.BackColor = Color.Transparent;
			Label4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label4.Location = new Point(14, 271);
			Label4.Name = "Label4";
			Label4.Size = new Size(109, 19);
			Label4.TabIndex = 67;
			Label4.Text = "Prix U. article";
			PRIX_A.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			PRIX_A.Location = new Point(146, 267);
			PRIX_A.Margin = new Padding(3, 4, 3, 4);
			PRIX_A.Name = "PRIX_A";
			PRIX_A.ReadOnly = true;
			PRIX_A.Size = new Size(126, 26);
			PRIX_A.TabIndex = 4;
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(495, 265);
			Valider.Name = "Valider";
			Valider.Size = new Size(147, 52);
			Valider.TabIndex = 105;
			Valider.UseVisualStyleBackColor = false;
			TYPE_ENTREE.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TYPE_ENTREE.FormattingEnabled = true;
			TYPE_ENTREE.Items.AddRange(new object[2]
			{
				"Ajout stock",
				"Retour"
			});
			TYPE_ENTREE.Location = new Point(146, 410);
			TYPE_ENTREE.Margin = new Padding(3, 4, 3, 4);
			TYPE_ENTREE.Name = "TYPE_ENTREE";
			TYPE_ENTREE.Size = new Size(177, 26);
			TYPE_ENTREE.TabIndex = 109;
			TYPE_ENTREE.Text = "Ajout stock";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(TYPE_ENTREE);
			base.Controls.Add(Valider);
			base.Controls.Add(Label4);
			base.Controls.Add(PRIX_A);
			base.Controls.Add(Button1);
			base.Controls.Add(Button5);
			base.Controls.Add(REFART);
			base.Controls.Add(MonthCalendar1);
			base.Controls.Add(Label1);
			base.Controls.Add(fournisseur);
			base.Controls.Add(Label2);
			base.Controls.Add(Label12);
			base.Controls.Add(CODETEXT);
			base.Controls.Add(LIBART);
			base.Controls.Add(Label6);
			base.Controls.Add(Date_Entree);
			base.Controls.Add(Label5);
			base.Controls.Add(Label3);
			base.Controls.Add(quantite);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Ajout_entree_Stock";
			Text = "Ajout au Stock existant";
			base.Controls.SetChildIndex(quantite, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(Date_Entree, 0);
			base.Controls.SetChildIndex(Label6, 0);
			base.Controls.SetChildIndex(LIBART, 0);
			base.Controls.SetChildIndex(CODETEXT, 0);
			base.Controls.SetChildIndex(Label12, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(fournisseur, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(MonthCalendar1, 0);
			base.Controls.SetChildIndex(REFART, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(PRIX_A, 0);
			base.Controls.SetChildIndex(Label4, 0);
			base.Controls.SetChildIndex(Valider, 0);
			base.Controls.SetChildIndex(TYPE_ENTREE, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void RefreshDGV()
		{
			if (Globals.conn.State == ConnectionState.Closed)
			{
				Globals.conn.Open();
			}
			MyProject.Forms.Entree_Stock.dgv1.DataSource = null;
			MyProject.Forms.Entree_Stock.dgv1.Rows.Clear();
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

		private void frmNew_Load(object sender, EventArgs e)
		{
			Date_Entree.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
			checked
			{
				try
				{
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.Connection = Globals.conn;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
					mySqlDataAdapter.Fill(dataSet, "list");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
					MySqlCommand mySqlCommand2 = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand2);
					DataSet dataSet2 = new DataSet();
					mySqlCommand2.Connection = Globals.conn;
					mySqlCommand2.CommandText = "select distinct IDFRS from FOURN ";
					mySqlDataAdapter2.Fill(dataSet2, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
					int num2 = dataSet2.Tables[0].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						autoCompleteStringCollection2.Add(dataSet2.Tables[0].Rows[j]["IDFRS"].ToString());
					}
					fournisseur.AutoCompleteSource = AutoCompleteSource.CustomSource;
					fournisseur.AutoCompleteCustomSource = autoCompleteStringCollection2;
					fournisseur.AutoCompleteMode = AutoCompleteMode.Suggest;
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
		}

		private void Date_Entree_Click(object sender, EventArgs e)
		{
			MonthCalendar1.Visible = true;
			Date_Entree.Text = "";
		}

		private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			TextBox date_Entree = Date_Entree;
			DateTime dateTime = MonthCalendar1.SelectionStart;
			string str = dateTime.ToString("dd/MM/yyyy");
			dateTime = DateTime.Now;
			date_Entree.Text = str + " " + dateTime.ToString("HH:mm:ss");
			MonthCalendar1.Visible = false;
		}

		private void REFART_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button5_Click(1, e);
				e.Handled = true;
			}
		}

		public void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				cmd.Connection = Globals.conn;
				cmd.CommandText = "select * from ARTICLE_D where REFART ='" + REFART.Text + "'";
				MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
				cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					PRIX_A.Text = mySqlDataReader["PRIX_ATTC"].ToString();
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
				}
				else
				{
					MessageBox.Show("ARTICLE non trouvé");
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

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				cmd.Connection = Globals.conn;
				Globals.flag_COD = "AES";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ARTICLE_D";
				MyProject.Forms.Affich_code.dgvA.DataSource = null;
				MyProject.Forms.Affich_code.dgvA.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code.dgvA, "ARTICLE");
				DataGridView dgvA = MyProject.Forms.Affich_code.dgvA;
				dgvA.Columns[0].HeaderCell.Value = "Réf. Article";
				dgvA.Columns[1].HeaderCell.Value = "Nom";
				dgvA.Columns[0].Width = 140;
				dgvA.Columns[1].Width = 240;
				dgvA = null;
				int num = checked(MyProject.Forms.Affich_code.dgvA.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						MyProject.Forms.Affich_code.dgvA.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						MyProject.Forms.Affich_code.dgvA.Rows[i].DefaultCellStyle.BackColor = Color.White;
					}
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

		private void fournisseur_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button1_Click(1, e);
				e.Handled = true;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				cmd.Connection = Globals.conn;
				Globals.flag_COD = "AES";
				MyProject.Forms.Affich_ID_FRS.Show();
				string query = "select distinct IDFRS,NOMFRS from FOURN ";
				MyProject.Forms.Affich_ID_FRS.dgvF.DataSource = null;
				MyProject.Forms.Affich_ID_FRS.dgvF.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_ID_FRS.dgvF, "FOURN");
				DataGridView dgvF = MyProject.Forms.Affich_ID_FRS.dgvF;
				dgvF.Columns[0].HeaderCell.Value = "Id. Fournisseur";
				dgvF.Columns[1].HeaderCell.Value = "Nom Frs";
				dgvF.Columns[0].Width = 140;
				dgvF.Columns[1].Width = 240;
				dgvF = null;
				int num = checked(MyProject.Forms.Affich_ID_FRS.dgvF.Rows.Count - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					if (i % 2 == 1)
					{
						MyProject.Forms.Affich_ID_FRS.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						MyProject.Forms.Affich_ID_FRS.dgvF.Rows[i].DefaultCellStyle.BackColor = Color.White;
					}
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

		private void fournisseur_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDFRS from FOURN where IDFRS='" + fournisseur.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				fournisseur.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					TYPE_ENTREE.Focus();
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show("Ce Fournisseur n'existe pas,Etes vous sûre de vouloir ajouter ce Fournisseur?", "Ajout Fournisseur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						fournisseur.Text = "";
					}
					else
					{
						MyProject.Forms.Gestion_Fourn.Show();
						MyProject.Forms.Gestion_Fourn.BringToFront();
						ClearTextBox(MyProject.Forms.Gestion_Fourn);
						Globals.ClearComboBox(MyProject.Forms.Gestion_Fourn);
						MyProject.Forms.Gestion_Fourn.IDFRS.Text = fournisseur.Text;
						MyProject.Forms.Gestion_Fourn.IDFRS_Validated(RuntimeHelpers.GetObjectValue(sender), e);
					}
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

		private void REFART_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where REFART LIKE '" + REFART.Text + "%'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
					LIBART.Focus();
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir ajouter un article?", "Ajout Article?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						REFART.Text = "";
						LIBART.Text = "";
						ClearTextBox(this);
						fournisseur.Text = "";
						REFART.Focus();
					}
					else
					{
						MyProject.Forms.Gestion_Article_Com.Show();
						MyProject.Forms.Gestion_Article_Com.REFART.Text = REFART.Text;
						MyProject.Forms.Gestion_Article_Com.REFART_Validated(RuntimeHelpers.GetObjectValue(sender), e);
					}
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

		private void Valider_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Globals.controlNum(quantite.Text) + Globals.controlNum(PRIX_A.Text) > 0)
					{
						MessageBox.Show("Merci de bien saisir un nombre valide !");
					}
					else
					{
						if (Globals.conn.State == ConnectionState.Closed)
						{
							Globals.conn.Open();
						}
						string text = "select * from entree_stock";
						MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
						MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
						DataTable dataTable = new DataTable();
						mySqlDataAdapter.Fill(dataTable);
						int num = dataTable.Rows.Count - 1;
						if (num == -1)
						{
							COD_E = 1;
						}
						else
						{
							mySqlCommand.CommandText = "SELECT MAX(code_entree)+1 FROM entree_stock ";
							COD_E = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
						}
						COD = REFART.Text;
						CODETEXT.Text = Conversions.ToString(COD_E);
						cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + COD + "'";
						decimal value = Conversions.ToDecimal(cmd.ExecuteScalar());
						decimal num2 = default(decimal);
						num2 = decimal.Add(Globals.convertDN(quantite.Text), Conversions.ToDecimal(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)));
						string cmdText = "UPDATE ARTICLE_D SET PRIX_ATTC=" + Strings.Replace(PRIX_A.Text, ",", ".", 1, -1, CompareMethod.Binary) + ", STOK=" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + " WHERE REFART='" + COD + "'";
						MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
						string cmdText2 = "INSERT INTO entree_stock(REFART, LIBART, quantite,PRIX_UE, fournisseur, date_entree, Code_entree, STOCK_AVANT, STOCK_APRES,TYPE_ENTREE)VALUES('" + COD + "', '" + LIBART.Text + "', '" + Strings.Replace(quantite.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(PRIX_A.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + fournisseur.Text + "', '" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', '" + Conversions.ToString(COD_E) + "', '" + Conversions.ToString(value) + "', '" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + "', '" + TYPE_ENTREE.Text + "')";
						MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText2, Globals.conn);
						mySqlCommand3.ExecuteNonQuery();
						mySqlCommand2.ExecuteNonQuery();
						MyProject.Forms.Entree_Stock.btnInit_Click(RuntimeHelpers.GetObjectValue(sender), e);
						if (Globals.conn != null)
						{
							Globals.conn.Close();
						}
						MessageBox.Show("Stock ajouté");
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

		private void Valider_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir valider cette entrée stock?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Valider_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}
}
