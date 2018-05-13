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
	public class Ajout_sortie_Stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Date_Sortie")]
		private TextBox _Date_Sortie;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("quantite")]
		private TextBox _quantite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CODSTEXT")]
		private TextBox _CODSTEXT;

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
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

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
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CLIENT")]
		private ComboBox _CLIENT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Valider")]
		private Button _Valider;

		public string COD;

		public int CODS;

		internal virtual ComboBox LIBART
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

		internal virtual TextBox Date_Sortie
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

		internal virtual TextBox quantite
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox CODSTEXT
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

		internal virtual Label Label9
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
				EventHandler value2 = REFART_Click;
				KeyEventHandler value3 = REFART_KeyDown;
				EventHandler value4 = REFART_SelectedIndexChanged;
				EventHandler value5 = REFART_Validated;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click -= value2;
					rEFART.KeyDown -= value3;
					rEFART.SelectedIndexChanged -= value4;
					rEFART.Validated -= value5;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click += value2;
					rEFART.KeyDown += value3;
					rEFART.SelectedIndexChanged += value4;
					rEFART.Validated += value5;
				}
			}
		}

		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return _Button11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button11_Click;
				Button button = _Button11;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button11 = value;
				button = _Button11;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public virtual ComboBox CLIENT
		{
			[CompilerGenerated]
			get
			{
				return _CLIENT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = CLIENT_KeyDown;
				EventHandler value3 = CLIENT_SelectedIndexChanged;
				EventHandler value4 = CLIENT_Validated;
				ComboBox cLIENT = _CLIENT;
				if (cLIENT != null)
				{
					cLIENT.KeyDown -= value2;
					cLIENT.SelectedIndexChanged -= value3;
					cLIENT.Validated -= value4;
				}
				_CLIENT = value;
				cLIENT = _CLIENT;
				if (cLIENT != null)
				{
					cLIENT.KeyDown += value2;
					cLIENT.SelectedIndexChanged += value3;
					cLIENT.Validated += value4;
				}
			}
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

		public Ajout_sortie_Stock()
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ajout_sortie_Stock));
			LIBART = new ComboBox();
			Label6 = new Label();
			Date_Sortie = new TextBox();
			Label5 = new Label();
			quantite = new TextBox();
			CODSTEXT = new TextBox();
			Label2 = new Label();
			Label12 = new Label();
			Label9 = new Label();
			Label1 = new Label();
			Type_Sortie = new TextBox();
			Button5 = new Button();
			REFART = new ComboBox();
			Button11 = new Button();
			CLIENT = new ComboBox();
			Valider = new Button();
			base.SuspendLayout();
			LIBART.DropDownStyle = ComboBoxStyle.Simple;
			LIBART.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(154, 144);
			LIBART.Margin = new Padding(3, 4, 3, 4);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(270, 26);
			LIBART.TabIndex = 2;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label6.Location = new Point(44, 411);
			Label6.Name = "Label6";
			Label6.Size = new Size(93, 19);
			Label6.TabIndex = 40;
			Label6.Text = "Date Sortie";
			Date_Sortie.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Date_Sortie.Location = new Point(154, 411);
			Date_Sortie.Margin = new Padding(3, 4, 3, 4);
			Date_Sortie.Name = "Date_Sortie";
			Date_Sortie.Size = new Size(161, 26);
			Date_Sortie.TabIndex = 5;
			Date_Sortie.TabStop = false;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label5.Location = new Point(77, 271);
			Label5.Name = "Label5";
			Label5.Size = new Size(53, 19);
			Label5.TabIndex = 38;
			Label5.Text = "Client";
			quantite.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			quantite.Location = new Point(154, 203);
			quantite.Margin = new Padding(3, 4, 3, 4);
			quantite.Name = "quantite";
			quantite.Size = new Size(77, 26);
			quantite.TabIndex = 3;
			CODSTEXT.Location = new Point(445, 91);
			CODSTEXT.Margin = new Padding(3, 4, 3, 4);
			CODSTEXT.Name = "CODSTEXT";
			CODSTEXT.ReadOnly = true;
			CODSTEXT.Size = new Size(77, 22);
			CODSTEXT.TabIndex = 44;
			CODSTEXT.TabStop = false;
			CODSTEXT.Visible = false;
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label2.Location = new Point(59, 94);
			Label2.Name = "Label2";
			Label2.Size = new Size(90, 19);
			Label2.TabIndex = 57;
			Label2.Text = "Réf. Article";
			Label12.AutoSize = true;
			Label12.BackColor = Color.Transparent;
			Label12.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label12.Location = new Point(59, 144);
			Label12.Name = "Label12";
			Label12.Size = new Size(88, 19);
			Label12.TabIndex = 56;
			Label12.Text = "Lib. Article";
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label9.Location = new Point(64, 203);
			Label9.Name = "Label9";
			Label9.Size = new Size(73, 19);
			Label9.TabIndex = 53;
			Label9.Text = "Quantité";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(44, 342);
			Label1.Name = "Label1";
			Label1.Size = new Size(95, 19);
			Label1.TabIndex = 60;
			Label1.Text = "Type Sortie";
			Type_Sortie.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Type_Sortie.Location = new Point(154, 342);
			Type_Sortie.Margin = new Padding(3, 4, 3, 4);
			Type_Sortie.Name = "Type_Sortie";
			Type_Sortie.Size = new Size(161, 26);
			Type_Sortie.TabIndex = 6;
			Button5.Location = new Point(391, 92);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 62;
			Button5.TabStop = false;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(154, 94);
			REFART.Name = "REFART";
			REFART.Size = new Size(254, 26);
			REFART.TabIndex = 1;
			Button11.Location = new Point(365, 265);
			Button11.Name = "Button11";
			Button11.Size = new Size(33, 28);
			Button11.TabIndex = 64;
			Button11.TabStop = false;
			Button11.Text = "...";
			Button11.UseVisualStyleBackColor = true;
			CLIENT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			CLIENT.AutoCompleteSource = AutoCompleteSource.ListItems;
			CLIENT.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			CLIENT.FormattingEnabled = true;
			CLIENT.Location = new Point(154, 266);
			CLIENT.Margin = new Padding(4, 3, 4, 3);
			CLIENT.Name = "CLIENT";
			CLIENT.Size = new Size(230, 26);
			CLIENT.TabIndex = 4;
			Valider.BackColor = Color.Transparent;
			Valider.Cursor = Cursors.Hand;
			Valider.FlatStyle = FlatStyle.Flat;
			Valider.ForeColor = Color.Transparent;
			Valider.Image = (Image)componentResourceManager.GetObject("Valider.Image");
			Valider.Location = new Point(554, 203);
			Valider.Name = "Valider";
			Valider.Size = new Size(147, 52);
			Valider.TabIndex = 104;
			Valider.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1358, 728);
			base.Controls.Add(Valider);
			base.Controls.Add(Button11);
			base.Controls.Add(CLIENT);
			base.Controls.Add(Button5);
			base.Controls.Add(REFART);
			base.Controls.Add(Label1);
			base.Controls.Add(Type_Sortie);
			base.Controls.Add(Label2);
			base.Controls.Add(Label12);
			base.Controls.Add(Label9);
			base.Controls.Add(CODSTEXT);
			base.Controls.Add(LIBART);
			base.Controls.Add(Label6);
			base.Controls.Add(Date_Sortie);
			base.Controls.Add(Label5);
			base.Controls.Add(quantite);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Ajout_sortie_Stock";
			Text = "Ajout Sortie Stock";
			base.Controls.SetChildIndex(quantite, 0);
			base.Controls.SetChildIndex(Label5, 0);
			base.Controls.SetChildIndex(Date_Sortie, 0);
			base.Controls.SetChildIndex(Label6, 0);
			base.Controls.SetChildIndex(LIBART, 0);
			base.Controls.SetChildIndex(CODSTEXT, 0);
			base.Controls.SetChildIndex(Label9, 0);
			base.Controls.SetChildIndex(Label12, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Type_Sortie, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(REFART, 0);
			base.Controls.SetChildIndex(Button5, 0);
			base.Controls.SetChildIndex(CLIENT, 0);
			base.Controls.SetChildIndex(Button11, 0);
			base.Controls.SetChildIndex(Valider, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
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
			Date_Sortie.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
					mySqlCommand2.CommandText = "select distinct IDCLIENT from CLIENT ";
					mySqlDataAdapter2.Fill(dataSet2, "list2");
					AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
					int num2 = dataSet2.Tables[0].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						autoCompleteStringCollection2.Add(dataSet2.Tables[0].Rows[j]["IDCLIENT"].ToString());
					}
					CLIENT.AutoCompleteSource = AutoCompleteSource.CustomSource;
					CLIENT.AutoCompleteCustomSource = autoCompleteStringCollection2;
					CLIENT.AutoCompleteMode = AutoCompleteMode.Suggest;
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

		private void REFART_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						REFART.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
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
			if (Globals.conn.State == ConnectionState.Closed)
			{
				Globals.conn.Open();
			}
			Globals.cmd.Connection = Globals.conn;
			Globals.cmd.CommandText = "select * from ARTICLE_D where REFART ='" + REFART.Text + "'";
			MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
			Globals.cmd.CommandType = CommandType.Text;
			if (mySqlDataReader.Read())
			{
				LIBART.Text = mySqlDataReader["LIBART"].ToString();
			}
			else
			{
				MessageBox.Show("ARTICLE non trouvé");
			}
			mySqlDataReader.Close();
			mySqlDataReader.Dispose();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.flag_COD = "ASS";
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

		private void CLIENT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 120)
			{
				Button11_Click(1, e);
				e.Handled = true;
			}
		}

		private void CLIENT_SelectedIndexChanged(object sender, EventArgs e)
		{
			Type_Sortie.Focus();
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				MyProject.Forms.Affich_code_client.Show();
				string query = "select distinct IDCLIENT,NOM from CLIENT";
				MyProject.Forms.Affich_code_client.dgvC.DataSource = null;
				MyProject.Forms.Affich_code_client.dgvC.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code_client.dgvC, "CLIENT");
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

		private void CLIENT_Validated(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct IDCLIENT from CLIENT where IDCLIENT='" + CLIENT.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				CLIENT.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					CLIENT_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show("Ce Client n'existe pas,Etes vous sûre de vouloir ajouter ce Client?", "Ajout Client?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.No)
					{
						base.Close();
						CLIENT.Text = "";
					}
					else
					{
						MyProject.Forms.Gestion_Client.Show();
						MyProject.Forms.Gestion_Client.BringToFront();
						ClearTextBox(MyProject.Forms.Gestion_Client);
						Globals.ClearComboBox(MyProject.Forms.Gestion_Client);
						MyProject.Forms.Gestion_Client.IDCLIENT.Text = CLIENT.Text;
						MyProject.Forms.Gestion_Client.IDCLIENT_Validated(RuntimeHelpers.GetObjectValue(sender), e);
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
					string text = "select * from sortie_stock";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(text, Globals.conn);
					MySqlCommand mySqlCommand = new MySqlCommand(text, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					int num = checked(dataTable.Rows.Count - 1);
					if (num == -1)
					{
						CODS = 1;
					}
					else
					{
						mySqlCommand.CommandText = "SELECT MAX(code_sortie)+1 FROM SORTIE_stock ";
						CODS = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
					}
					CODSTEXT.Text = Conversions.ToString(CODS);
					COD = REFART.Text;
					Globals.cmd.CommandText = "SELECT IFNULL(STOK,0) FROM ARTICLE_D where REFART='" + COD + "'";
					decimal value = Conversions.ToDecimal(Globals.cmd.ExecuteScalar());
					decimal num2 = default(decimal);
					num2 = new decimal(Conversions.ToDouble(Strings.Replace(Conversions.ToString(value), ".", ",", 1, -1, CompareMethod.Binary)) - Convert.ToDouble(Globals.convertDN(quantite.Text)));
					string cmdText = "INSERT INTO Sortie_stock(REFART, LIBART, quantite, client, date_sortie, Type_Sortie, CODE_SORTIE, STOCK_AVANT, STOCK_APRES)VALUES('" + COD + "', '" + LIBART.Text + "', '" + Strings.Replace(quantite.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Strings.Replace(CLIENT.Text, ",", ".", 1, -1, CompareMethod.Binary) + "', '" + Globals.NowDate.ToString("yyyy-MM-dd H:mm:ss") + "', '" + Type_Sortie.Text + "', '" + Conversions.ToString(CODS) + "','" + Conversions.ToString(value) + "', '" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + "')";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText, Globals.conn);
					string cmdText2 = "UPDATE ARTICLE_D SET STOK=" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Binary) + " WHERE REFART='" + COD + "'";
					MySqlCommand mySqlCommand3 = new MySqlCommand(cmdText2, Globals.conn);
					mySqlCommand2.ExecuteNonQuery();
					mySqlCommand3.ExecuteNonQuery();
					MyProject.Forms.Sortie_Stock.Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					MessageBox.Show("Stock Sorti");
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
		}

		private void Valider_Enter(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Etes vous sûre de vouloir valider cette sortie du stock?", "Enregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (dialogResult != DialogResult.No)
			{
				Valider_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D where REFART ='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				REFART.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
					goto IL_00ed;
				}
				if (Operators.CompareString(REFART.Text, "", false) != 0)
				{
					MessageBox.Show("Article no trouvé!", "Article");
					REFART.Text = "";
					REFART.Focus();
					goto IL_00ed;
				}
				goto end_IL_0001;
				IL_00ed:
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (Globals.conn != null)
				{
					Globals.conn.Close();
				}
				end_IL_0001:;
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
}
