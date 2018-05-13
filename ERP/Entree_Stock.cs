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
	public class Entree_Stock : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnInit")]
		private Button _btnInit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

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
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

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
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("B_rechercher")]
		private Button _B_rechercher;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LIBART")]
		private ComboBox _LIBART;

		internal virtual Button btnNew
		{
			[CompilerGenerated]
			get
			{
				return _btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNew_Click;
				Button btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click -= value2;
				}
				_btnNew = value;
				btnNew = _btnNew;
				if (btnNew != null)
				{
					btnNew.Click += value2;
				}
			}
		}

		internal virtual Button btnDelete
		{
			[CompilerGenerated]
			get
			{
				return _btnDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDelete_Click;
				Button btnDelete = _btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click -= value2;
				}
				_btnDelete = value;
				btnDelete = _btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click += value2;
				}
			}
		}

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

		internal virtual Button btnInit
		{
			[CompilerGenerated]
			get
			{
				return _btnInit;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnInit_Click;
				Button btnInit = _btnInit;
				if (btnInit != null)
				{
					btnInit.Click -= value2;
				}
				_btnInit = value;
				btnInit = _btnInit;
				if (btnInit != null)
				{
					btnInit.Click += value2;
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
				DataGridViewCellEventHandler value2 = dgv1_CellDoubleClick;
				DataGridView dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellDoubleClick -= value2;
				}
				_dgv1 = value;
				dgv = _dgv1;
				if (dgv != null)
				{
					dgv.CellDoubleClick += value2;
				}
			}
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

		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return _Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button3_Click;
				Button button = _Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button3 = value;
				button = _Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox1
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

		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public virtual Button B_rechercher
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

		public virtual ComboBox LIBART
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Entree_Stock()
		{
			base.Load += Entree_Stock_Load;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Entree_Stock));
			btnNew = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnInit = new Button();
			dgv1 = new DataGridView();
			Label3 = new Label();
			Label1 = new Label();
			Button1 = new Button();
			Button3 = new Button();
			GroupBox1 = new GroupBox();
			Button5 = new Button();
			REFART = new ComboBox();
			Label5 = new Label();
			B_rechercher = new Button();
			Label6 = new Label();
			LIBART = new ComboBox();
			((ISupportInitialize)dgv1).BeginInit();
			GroupBox1.SuspendLayout();
			base.SuspendLayout();
			btnNew.BackColor = Color.White;
			btnNew.BackgroundImageLayout = ImageLayout.Zoom;
			btnNew.Cursor = Cursors.Hand;
			btnNew.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNew.Image = Resources.add_1_icon;
			btnNew.ImageAlign = ContentAlignment.MiddleLeft;
			btnNew.Location = new Point(0, 308);
			btnNew.Margin = new Padding(3, 4, 3, 4);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(113, 54);
			btnNew.TabIndex = 18;
			btnNew.Text = "Ajouter";
			btnNew.TextAlign = ContentAlignment.MiddleRight;
			btnNew.UseVisualStyleBackColor = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(0, 482);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(113, 46);
			btnDelete.TabIndex = 16;
			btnDelete.Text = "Supprimer";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			btnUpdate.BackColor = Color.White;
			btnUpdate.Cursor = Cursors.Hand;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.Image = Resources.edit_file_icon;
			btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdate.Location = new Point(0, 397);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(113, 49);
			btnUpdate.TabIndex = 14;
			btnUpdate.Text = "Modifier";
			btnUpdate.TextAlign = ContentAlignment.MiddleRight;
			btnUpdate.UseVisualStyleBackColor = false;
			btnInit.BackColor = Color.White;
			btnInit.Cursor = Cursors.Hand;
			btnInit.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnInit.Image = Resources.Button_Refresh_icon;
			btnInit.ImageAlign = ContentAlignment.MiddleLeft;
			btnInit.Location = new Point(0, 217);
			btnInit.Margin = new Padding(3, 4, 3, 4);
			btnInit.Name = "btnInit";
			btnInit.Size = new Size(113, 52);
			btnInit.TabIndex = 13;
			btnInit.Text = "Initier";
			btnInit.TextAlign = ContentAlignment.MiddleRight;
			btnInit.UseVisualStyleBackColor = false;
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv1.BackgroundColor = Color.White;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(119, 198);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(1125, 479);
			dgv1.TabIndex = 12;
			Label3.AutoSize = true;
			Label3.BackColor = Color.Transparent;
			Label3.Cursor = Cursors.Hand;
			Label3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label3.Location = new Point(1032, 150);
			Label3.Name = "Label3";
			Label3.Size = new Size(91, 16);
			Label3.TabIndex = 31;
			Label3.Text = "Sorties Stock";
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Cursor = Cursors.Hand;
			Label1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label1.Location = new Point(907, 150);
			Label1.Name = "Label1";
			Label1.Size = new Size(87, 16);
			Label1.TabIndex = 30;
			Label1.Text = "Stock global";
			Button1.BackgroundImage = (Image)componentResourceManager.GetObject("Button1.BackgroundImage");
			Button1.Cursor = Cursors.Hand;
			Button1.Location = new Point(1044, 71);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(70, 75);
			Button1.TabIndex = 29;
			Button1.UseVisualStyleBackColor = true;
			Button3.BackgroundImage = (Image)componentResourceManager.GetObject("Button3.BackgroundImage");
			Button3.Cursor = Cursors.Hand;
			Button3.Location = new Point(910, 71);
			Button3.Margin = new Padding(3, 4, 3, 4);
			Button3.Name = "Button3";
			Button3.Size = new Size(73, 75);
			Button3.TabIndex = 28;
			Button3.UseVisualStyleBackColor = true;
			GroupBox1.BackColor = Color.Transparent;
			GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
			GroupBox1.Controls.Add(Button5);
			GroupBox1.Controls.Add(REFART);
			GroupBox1.Controls.Add(Label5);
			GroupBox1.Controls.Add(B_rechercher);
			GroupBox1.Controls.Add(Label6);
			GroupBox1.Controls.Add(LIBART);
			GroupBox1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			GroupBox1.Location = new Point(12, 71);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Size = new Size(794, 98);
			GroupBox1.TabIndex = 48;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Référence";
			Button5.Cursor = Cursors.Hand;
			Button5.Location = new Point(250, 40);
			Button5.Name = "Button5";
			Button5.Size = new Size(33, 28);
			Button5.TabIndex = 46;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(59, 41);
			REFART.Name = "REFART";
			REFART.Size = new Size(206, 26);
			REFART.TabIndex = 14;
			Label5.AutoSize = true;
			Label5.BackColor = Color.Transparent;
			Label5.ForeColor = SystemColors.ActiveCaption;
			Label5.Location = new Point(307, 44);
			Label5.Name = "Label5";
			Label5.Size = new Size(54, 18);
			Label5.TabIndex = 3;
			Label5.Text = "Libelle";
			B_rechercher.BackColor = Color.White;
			B_rechercher.Cursor = Cursors.Hand;
			B_rechercher.Image = Resources.Actions_document_find_icon1;
			B_rechercher.ImageAlign = ContentAlignment.MiddleLeft;
			B_rechercher.Location = new Point(661, 35);
			B_rechercher.Name = "B_rechercher";
			B_rechercher.Size = new Size(106, 37);
			B_rechercher.TabIndex = 2;
			B_rechercher.Text = "Chercher";
			B_rechercher.TextAlign = ContentAlignment.MiddleRight;
			B_rechercher.UseVisualStyleBackColor = false;
			Label6.AutoSize = true;
			Label6.BackColor = Color.Transparent;
			Label6.ForeColor = SystemColors.ActiveCaption;
			Label6.Location = new Point(6, 45);
			Label6.Name = "Label6";
			Label6.Size = new Size(47, 18);
			Label6.TabIndex = 0;
			Label6.Text = "Code";
			LIBART.FormattingEnabled = true;
			LIBART.Location = new Point(367, 41);
			LIBART.Name = "LIBART";
			LIBART.Size = new Size(288, 26);
			LIBART.Sorted = true;
			LIBART.TabIndex = 6;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(GroupBox1);
			base.Controls.Add(Label3);
			base.Controls.Add(Label1);
			base.Controls.Add(Button1);
			base.Controls.Add(Button3);
			base.Controls.Add(btnNew);
			base.Controls.Add(btnDelete);
			base.Controls.Add(btnUpdate);
			base.Controls.Add(btnInit);
			base.Controls.Add(dgv1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(3, 5, 3, 5);
			base.Name = "Entree_Stock";
			Text = "Entree Stock";
			base.Controls.SetChildIndex(dgv1, 0);
			base.Controls.SetChildIndex(btnInit, 0);
			base.Controls.SetChildIndex(btnUpdate, 0);
			base.Controls.SetChildIndex(btnDelete, 0);
			base.Controls.SetChildIndex(btnNew, 0);
			base.Controls.SetChildIndex(Button3, 0);
			base.Controls.SetChildIndex(Button1, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(Label3, 0);
			base.Controls.SetChildIndex(GroupBox1, 0);
			((ISupportInitialize)dgv1).EndInit();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Entree_Stock_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					MySqlConnection mySqlConnection = new MySqlConnection(Globals.connStr);
					if (mySqlConnection.State == ConnectionState.Closed)
					{
						mySqlConnection.Open();
					}
					string selectCommandText = "select CODE_ENTREE,REFART,LIBART,quantite,PRIX_UE,fournisseur,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE from entree_stock order by CODE_ENTREE desc limit 100";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, mySqlConnection);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					dgv1.DataSource = dataTable;
					FormatDGV(dgv1);
					MySqlCommand mySqlCommand = new MySqlCommand();
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand);
					DataSet dataSet = new DataSet();
					if (mySqlConnection.State == ConnectionState.Closed)
					{
						mySqlConnection.Open();
					}
					mySqlCommand.Connection = mySqlConnection;
					mySqlCommand.CommandText = "select distinct REFART from ARTICLE_D";
					mySqlDataAdapter2.Fill(dataSet, "list");
					AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						autoCompleteStringCollection.Add(dataSet.Tables[0].Rows[i]["REFART"].ToString());
					}
					REFART.AutoCompleteSource = AutoCompleteSource.CustomSource;
					REFART.AutoCompleteCustomSource = autoCompleteStringCollection;
					REFART.AutoCompleteMode = AutoCompleteMode.Suggest;
					mySqlConnection?.Close();
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

		private void btnNew_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Ajout_entree_Stock.Show();
			MyProject.Forms.Ajout_entree_Stock.Show();
			MyProject.Forms.Ajout_entree_Stock.REFART.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
			MyProject.Forms.Ajout_entree_Stock.REFART_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			MyProject.Forms.Ajout_entree_Stock.quantite.Focus();
		}

		public void btnInit_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlConnection mySqlConnection = new MySqlConnection(Globals.connStr);
				if (mySqlConnection.State == ConnectionState.Closed)
				{
					mySqlConnection.Open();
				}
				string selectCommandText = "select CODE_ENTREE,REFART,LIBART,quantite,PRIX_UE,fournisseur,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE from entree_stock order by CODE_ENTREE desc limit 100";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, mySqlConnection);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				dgv1.DataSource = dataTable;
				mySqlConnection?.Close();
				FormatDGV(dgv1);
				REFART.Text = "";
				LIBART.Text = "";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Modif_entree_stock.Show();
				MyProject.Forms.Modif_entree_stock.Code_entree.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
				MyProject.Forms.Modif_entree_stock.REFART.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
				MyProject.Forms.Modif_entree_stock.LIBART.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
				MyProject.Forms.Modif_entree_stock.quantite.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
				MyProject.Forms.Modif_entree_stock.Fournisseur.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
				MyProject.Forms.Modif_entree_stock.Date_entree.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
				MyProject.Forms.Modif_entree_stock.TYPE_ENTREE.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnUpdate_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM entree_stock WHERE code_entree='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					decimal value = Convert.ToDecimal(dgv1.CurrentRow.Cells[3].Value.ToString());
					string cmdText2 = "UPDATE article_D SET STOK=STOK-('" + Conversions.ToString(value) + "') WHERE REFART='" + dgv1.CurrentRow.Cells[1].Value.ToString() + "'";
					MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, Globals.conn);
					if (Globals.conn.State == ConnectionState.Closed)
					{
						Globals.conn.Open();
					}
					mySqlCommand.ExecuteNonQuery();
					mySqlCommand2.ExecuteNonQuery();
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					dgv1.Rows.Remove(dgv1.CurrentRow);
					FormatDGV(dgv1);
					MessageBox.Show("Ligne supprimé");
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

		public void FormatDGV(DataGridView Dgv)
		{
			Dgv.Columns[0].HeaderCell.Value = "Code";
			Dgv.Columns[1].HeaderCell.Value = "Réf. Article";
			Dgv.Columns[2].HeaderCell.Value = "Lib. Article";
			Dgv.Columns[3].HeaderCell.Value = "Qté";
			Dgv.Columns[4].HeaderCell.Value = "Prix.U";
			Dgv.Columns[5].HeaderCell.Value = "fournisseur";
			Dgv.Columns[6].HeaderCell.Value = "Date entrée";
			Dgv.Columns[7].HeaderCell.Value = "Stock avant";
			Dgv.Columns[8].HeaderCell.Value = "Stock après";
			Dgv.Columns[9].HeaderCell.Value = "Type entrée";
			Dgv.Columns[0].Width = 50;
			Dgv.Columns[3].Width = 60;
			DataGridView dataGridView = null;
			checked
			{
				int num = Dgv.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (unchecked(i % 2) == 1)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					else
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
					}
					if (decimal.Compare(Convert.ToDecimal(Globals.convertNull(RuntimeHelpers.GetObjectValue(Dgv.Rows[i].Cells[7].Value))), decimal.Zero) < 0)
					{
						Dgv.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
					}
				}
				Dgv.Width = 0;
				Dgv.Height = 0;
				IEnumerator enumerator = default(IEnumerator);
				DataGridView dataGridView2;
				try
				{
					enumerator = Dgv.Columns.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataGridViewColumn dataGridViewColumn = unchecked((DataGridViewColumn)enumerator.Current);
						(dataGridView2 = Dgv).Width = dataGridView2.Width + dataGridViewColumn.Width;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				(dataGridView2 = Dgv).Width = dataGridView2.Width + (Dgv.RowHeadersWidth + 20);
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = unchecked((IEnumerable)Dgv.Rows).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataGridViewRow dataGridViewRow = unchecked((DataGridViewRow)enumerator2.Current);
						(dataGridView2 = Dgv).Height = dataGridView2.Height + dataGridViewRow.Height;
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				(dataGridView2 = Dgv).Height = dataGridView2.Height + (Dgv.ColumnHeadersHeight + 2);
				if (Dgv.Height <= 479)
				{
					Dgv.Height = Dgv.Height;
				}
				else
				{
					Dgv.Height = 479;
				}
				if (Dgv.Width <= 1125)
				{
					Dgv.Width = Dgv.Width;
				}
				else
				{
					Dgv.Width = 1125;
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
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
				Globals.ClearTextBox(this);
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select CODE_ENTREE,REFART,LIBART,quantite,PRIX_UE,fournisseur,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE from ENTREE_STOCK where REFART ='" + REFART.Text + "'";
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				mySqlCommand.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					LIBART.Text = mySqlDataReader["LIBART"].ToString();
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
					string selectCommandText = "select CODE_ENTREE,REFART,LIBART,quantite,PRIX_UE,fournisseur,date_entree,STOCK_AVANT,STOCK_APRES,TYPE_ENTREE FROM ENTREE_STOCK where REFART ='" + REFART.Text + "'";
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					dgv1.DataSource = dataTable;
					if (Globals.conn != null)
					{
						Globals.conn.Close();
					}
					FormatDGV(dgv1);
				}
				else
				{
					REFART.Text = "";
					LIBART.Text = "";
					MessageBox.Show("Article non trouvé");
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
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
				Globals.flag_COD = "ES";
				MyProject.Forms.Affich_code.Show();
				string query = "select distinct REFART,LIBART from ENTREE_STOCK";
				MyProject.Forms.Affich_code.dgvA.DataSource = null;
				MyProject.Forms.Affich_code.dgvA.Rows.Clear();
				Globals.LoadData(query, MyProject.Forms.Affich_code.dgvA, "ENTREE_STOCK");
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
				}
				else
				{
					if (Operators.CompareString(REFART.Text, "", false) == 0)
					{
						mySqlDataReader.Close();
						mySqlDataReader.Dispose();
						goto end_IL_0001;
					}
					MessageBox.Show("Article no trouvé!", "Article");
					REFART.Text = "";
					LIBART.Text = "";
					REFART.Focus();
				}
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
