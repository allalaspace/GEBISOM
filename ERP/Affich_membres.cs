using ERP.My;
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
	public class Affich_membres : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("nom_prenom")]
		private ComboBox _nom_prenom;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

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
		[AccessedThroughProperty("txtSearch")]
		private TextBox _txtSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Affich")]
		private Button _Affich;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgv1")]
		private DataGridView _dgv1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		public int code_perso;

		internal virtual Label Label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox nom_prenom
		{
			[CompilerGenerated]
			get
			{
				return _nom_prenom;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = nom_prenom_Click;
				EventHandler value3 = nom_prenom_SelectedIndexChanged;
				ComboBox nom_prenom = _nom_prenom;
				if (nom_prenom != null)
				{
					nom_prenom.Click -= value2;
					nom_prenom.SelectedIndexChanged -= value3;
				}
				_nom_prenom = value;
				nom_prenom = _nom_prenom;
				if (nom_prenom != null)
				{
					nom_prenom.Click += value2;
					nom_prenom.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

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

		internal virtual TextBox txtSearch
		{
			[CompilerGenerated]
			get
			{
				return _txtSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtSearch_TextChanged;
				TextBox txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.TextChanged -= value2;
				}
				_txtSearch = value;
				txtSearch = _txtSearch;
				if (txtSearch != null)
				{
					txtSearch.TextChanged += value2;
				}
			}
		}

		internal virtual Button Affich
		{
			[CompilerGenerated]
			get
			{
				return _Affich;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Affich_Click;
				Button affich = _Affich;
				if (affich != null)
				{
					affich.Click -= value2;
				}
				_Affich = value;
				affich = _Affich;
				if (affich != null)
				{
					affich.Click += value2;
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

		public Affich_membres()
		{
			base.Load += Affich_membres_Load;
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
			Label2 = new Label();
			nom_prenom = new ComboBox();
			Label1 = new Label();
			btnNew = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			txtSearch = new TextBox();
			Affich = new Button();
			dgv1 = new DataGridView();
			Button1 = new Button();
			((ISupportInitialize)dgv1).BeginInit();
			base.SuspendLayout();
			Label2.AutoSize = true;
			Label2.BackColor = Color.Transparent;
			Label2.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label2.Location = new Point(47, 175);
			Label2.Name = "Label2";
			Label2.Size = new Size(305, 18);
			Label2.TabIndex = 32;
			Label2.Text = "Recherche par saisie (prenom ou nom):";
			nom_prenom.FormattingEnabled = true;
			nom_prenom.Location = new Point(381, 118);
			nom_prenom.Margin = new Padding(3, 4, 3, 4);
			nom_prenom.Name = "nom_prenom";
			nom_prenom.Size = new Size(270, 24);
			nom_prenom.TabIndex = 31;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label1.Location = new Point(107, 124);
			Label1.Name = "Label1";
			Label1.Size = new Size(194, 18);
			Label1.TabIndex = 30;
			Label1.Text = "Recherche par sélection:";
			btnNew.BackColor = Color.White;
			btnNew.Cursor = Cursors.Hand;
			btnNew.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNew.Image = Resources.add_1_icon;
			btnNew.ImageAlign = ContentAlignment.MiddleLeft;
			btnNew.Location = new Point(-1, 330);
			btnNew.Margin = new Padding(3, 4, 3, 4);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(113, 58);
			btnNew.TabIndex = 29;
			btnNew.Text = "Ajouter";
			btnNew.TextAlign = ContentAlignment.MiddleRight;
			btnNew.UseVisualStyleBackColor = false;
			btnDelete.BackColor = Color.White;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.Image = Resources.Button_Delete_icon;
			btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			btnDelete.Location = new Point(0, 498);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(113, 53);
			btnDelete.TabIndex = 28;
			btnDelete.Text = "Supprimer";
			btnDelete.TextAlign = ContentAlignment.MiddleRight;
			btnDelete.UseVisualStyleBackColor = false;
			btnUpdate.BackColor = Color.White;
			btnUpdate.Cursor = Cursors.Hand;
			btnUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.Image = Resources.edit_file_icon;
			btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdate.Location = new Point(-1, 418);
			btnUpdate.Margin = new Padding(3, 4, 3, 4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(113, 53);
			btnUpdate.TabIndex = 26;
			btnUpdate.Text = "Modifier";
			btnUpdate.TextAlign = ContentAlignment.MiddleRight;
			btnUpdate.UseVisualStyleBackColor = false;
			txtSearch.Location = new Point(381, 175);
			txtSearch.Margin = new Padding(3, 4, 3, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(167, 22);
			txtSearch.TabIndex = 27;
			Affich.BackColor = Color.White;
			Affich.Cursor = Cursors.Hand;
			Affich.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Affich.Image = Resources.Button_Refresh_icon;
			Affich.ImageAlign = ContentAlignment.MiddleLeft;
			Affich.Location = new Point(0, 246);
			Affich.Margin = new Padding(3, 4, 3, 4);
			Affich.Name = "Affich";
			Affich.Size = new Size(113, 55);
			Affich.TabIndex = 25;
			Affich.Text = "Initier";
			Affich.TextAlign = ContentAlignment.MiddleRight;
			Affich.UseVisualStyleBackColor = false;
			dgv1.AllowUserToAddRows = false;
			dgv1.AllowUserToDeleteRows = false;
			dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv1.BackgroundColor = Color.White;
			dgv1.BorderStyle = BorderStyle.Fixed3D;
			dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv1.Location = new Point(129, 217);
			dgv1.Margin = new Padding(3, 4, 3, 4);
			dgv1.Name = "dgv1";
			dgv1.ReadOnly = true;
			dgv1.Size = new Size(1094, 457);
			dgv1.TabIndex = 24;
			Button1.BackColor = Color.White;
			Button1.Cursor = Cursors.Hand;
			Button1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.Image = Resources.print_icon;
			Button1.ImageAlign = ContentAlignment.MiddleLeft;
			Button1.Location = new Point(0, 577);
			Button1.Margin = new Padding(3, 4, 3, 4);
			Button1.Name = "Button1";
			Button1.Size = new Size(113, 53);
			Button1.TabIndex = 33;
			Button1.Text = "Imprimer";
			Button1.TextAlign = ContentAlignment.MiddleRight;
			Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(1361, 728);
			base.Controls.Add(Button1);
			base.Controls.Add(Label2);
			base.Controls.Add(nom_prenom);
			base.Controls.Add(Label1);
			base.Controls.Add(btnNew);
			base.Controls.Add(btnDelete);
			base.Controls.Add(btnUpdate);
			base.Controls.Add(txtSearch);
			base.Controls.Add(Affich);
			base.Controls.Add(dgv1);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(5);
			base.Name = "Affich_membres";
			Text = "Gestion Personnel";
			base.Controls.SetChildIndex(dgv1, 0);
			base.Controls.SetChildIndex(Affich, 0);
			base.Controls.SetChildIndex(txtSearch, 0);
			base.Controls.SetChildIndex(btnUpdate, 0);
			base.Controls.SetChildIndex(btnDelete, 0);
			base.Controls.SetChildIndex(btnNew, 0);
			base.Controls.SetChildIndex(Label1, 0);
			base.Controls.SetChildIndex(nom_prenom, 0);
			base.Controls.SetChildIndex(Label2, 0);
			base.Controls.SetChildIndex(Button1, 0);
			((ISupportInitialize)dgv1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Affich_membres_Load(object sender, EventArgs e)
		{
			try
			{
				MySqlConnection mySqlConnection = new MySqlConnection(Globals.connStr);
				mySqlConnection.Open();
				string selectCommandText = "select * from INFO_PERSO";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, mySqlConnection);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				dgv1.DataSource = dataTable;
				string text = "select * from INFO_PERSO";
				MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(text, mySqlConnection);
				MySqlCommand mySqlCommand = new MySqlCommand(text, mySqlConnection);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				mySqlDataReader.Read();
				mySqlConnection.Close();
				Globals.clorerDGV(dgv1);
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				string selectCommandText = "select * from INFO_PERSO WHERE prenom LIKE '" + txtSearch.Text + "%' OR nom LIKE '" + txtSearch.Text + "%'";
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommandText, Globals.conn);
				DataTable dataTable = new DataTable("INFO_PERSO");
				mySqlDataAdapter.Fill(dataTable);
				dgv1.DataSource = dataTable;
				Globals.clorerDGV(dgv1);
				Globals.conn.Close();
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

		private void Affich_Click(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select * from INFO_PERSO ";
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
				DataSet dataSet = new DataSet();
				MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
				DataTable dataTable = new DataTable();
				DataSet dataSet2 = new DataSet();
				mySqlDataAdapter.Fill(dataSet2, "INFO_PERSO");
				dataTable = dataSet2.Tables["INFO_PERSO"];
				dgv1.DataSource = dataTable;
				mySqlCommand.Dispose();
				Globals.conn.Close();
				Globals.clorerDGV(dgv1);
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Etes vous sure de vouloir supprimer cette ligne?", "Suppression de ligne?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.No)
				{
					string cmdText = "DELETE FROM INFO_PERSO WHERE code_perso='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
					MySqlCommand mySqlCommand = new MySqlCommand(cmdText, Globals.conn);
					Globals.conn.Open();
					mySqlCommand.ExecuteNonQuery();
					Globals.conn.Close();
					dgv1.Rows.Remove(dgv1.CurrentRow);
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
			finally
			{
				Globals.conn.Close();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Modif_info_perso.Show();
			MyProject.Forms.Modif_info_perso.nom_prenom.Text = dgv1.CurrentRow.Cells[2].Value.ToString() + " " + dgv1.CurrentRow.Cells[1].Value.ToString();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			MyProject.Forms.info_perso.Show();
		}

		private void nom_prenom_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				Globals.conn.Open();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select distinct concat(prenom,concat(' ',nom)) from INFO_PERSO ";
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				nom_prenom.Items.Clear();
				if (mySqlDataReader.HasRows)
				{
					while (mySqlDataReader.Read())
					{
						nom_prenom.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
					}
				}
				else
				{
					MessageBox.Show("No result for your Data", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
				Globals.conn.Close();
			}
		}

		private void nom_prenom_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Globals.conn.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select * from INFO_PERSO where concat(prenom,concat(' ',nom))='" + nom_prenom.Text + "'";
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandType = CommandType.Text;
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
				DataSet dataSet = new DataSet();
				MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
				DataTable dataTable = new DataTable();
				DataSet dataSet2 = new DataSet();
				mySqlDataAdapter.Fill(dataSet2, "INFO_PERSO");
				dataTable = dataSet2.Tables["INFO_PERSO"];
				dgv1.DataSource = dataTable;
				Globals.clorerDGV(dgv1);
				mySqlCommand.Dispose();
				Globals.conn.Close();
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

		private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MyProject.Forms.Modif_info_perso.Show();
			MyProject.Forms.Modif_info_perso.nom_prenom.Text = dgv1.CurrentRow.Cells[2].Value.ToString() + " " + dgv1.CurrentRow.Cells[1].Value.ToString();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			code_perso = Convert.ToInt32(Convert.ToDecimal(dgv1.CurrentRow.Cells[0].Value.ToString()));
			MyProject.Forms.Imprim_info_perso.CODE_PERSO.Text = Conversions.ToString(Convert.ToDecimal(dgv1.CurrentRow.Cells[0].Value.ToString()));
			MyProject.Forms.Imprim_info_perso.Show();
		}
	}
}
