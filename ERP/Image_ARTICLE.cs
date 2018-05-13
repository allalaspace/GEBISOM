using ERP.My;
using ERP.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Image_ARTICLE : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("List")]
		private ListBox _List;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

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
				EventHandler value3 = REFART_SelectedIndexChanged;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click -= value2;
					rEFART.SelectedIndexChanged -= value3;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click += value2;
					rEFART.SelectedIndexChanged += value3;
				}
			}
		}

		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ListBox List
		{
			[CompilerGenerated]
			get
			{
				return _List;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = List_SelectedValueChanged;
				ListBox list = _List;
				if (list != null)
				{
					list.SelectedValueChanged -= value2;
				}
				_List = value;
				list = _List;
				if (list != null)
				{
					list.SelectedValueChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return _CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CheckBox1_CheckedChanged;
				CheckBox checkBox = _CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_CheckBox1 = value;
				checkBox = _CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Image_ARTICLE()
		{
			base.KeyDown += Image_ARTICLE_KeyDown;
			base.Load += Image_ARTICLE_Load;
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
			Button5 = new Button();
			REFART = new ComboBox();
			Label1 = new Label();
			List = new ListBox();
			CheckBox1 = new CheckBox();
			PictureBox1 = new PictureBox();
			((ISupportInitialize)PictureBox1).BeginInit();
			base.SuspendLayout();
			Button5.Location = new Point(272, 51);
			Button5.Margin = new Padding(3, 4, 3, 4);
			Button5.Name = "Button5";
			Button5.Size = new Size(38, 29);
			Button5.TabIndex = 49;
			Button5.Text = "...";
			Button5.UseVisualStyleBackColor = true;
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.AutoCompleteSource = AutoCompleteSource.ListItems;
			REFART.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(149, 52);
			REFART.Margin = new Padding(3, 4, 3, 4);
			REFART.Name = "REFART";
			REFART.Size = new Size(140, 26);
			REFART.TabIndex = 48;
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label1.ForeColor = SystemColors.ActiveCaption;
			Label1.Location = new Point(98, 55);
			Label1.Name = "Label1";
			Label1.Size = new Size(47, 18);
			Label1.TabIndex = 47;
			Label1.Text = "Code";
			List.FormattingEnabled = true;
			List.ItemHeight = 16;
			List.Location = new Point(336, 12);
			List.Name = "List";
			List.Size = new Size(120, 84);
			List.TabIndex = 55;
			CheckBox1.AutoSize = true;
			CheckBox1.BackColor = Color.Transparent;
			CheckBox1.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			CheckBox1.Location = new Point(187, 12);
			CheckBox1.Name = "CheckBox1";
			CheckBox1.Size = new Size(75, 27);
			CheckBox1.TabIndex = 56;
			CheckBox1.Text = "Liste";
			CheckBox1.UseVisualStyleBackColor = false;
			PictureBox1.Location = new Point(0, 102);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(898, 366);
			PictureBox1.TabIndex = 57;
			PictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(897, 471);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(CheckBox1);
			base.Controls.Add(List);
			base.Controls.Add(Button5);
			base.Controls.Add(REFART);
			base.Controls.Add(Label1);
			Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Image_ARTICLE";
			Text = "Images ARTICLE";
			((ISupportInitialize)PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
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
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
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

		public void REFART_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
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
					if (!(mySqlDataReader["Photo"] == null | mySqlDataReader["Photo"] == DBNull.Value))
					{
						byte[] buffer = (byte[])mySqlDataReader["Photo"];
						Image image = null;
						MemoryStream stream = new MemoryStream(buffer);
						PictureBox1.Image = Image.FromStream(stream);
					}
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
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
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
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

		private void Image_ARTICLE_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void Image_ARTICLE_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - base.Width) / 2.0));
					workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - base.Height) / 2.0));
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
							List.Items.Add(RuntimeHelpers.GetObjectValue(mySqlDataReader.GetValue(0)));
						}
						mySqlDataReader.Close();
						mySqlDataReader.Dispose();
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
					List.Visible = false;
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

		private void List_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				Globals.cmd.Connection = Globals.conn;
				Globals.cmd.CommandText = Conversions.ToString(Operators.AddObject(Operators.AddObject("select * from ARTICLE_D where REFART ='", List.SelectedItem), "'"));
				MySqlDataReader mySqlDataReader = Globals.cmd.ExecuteReader();
				Globals.cmd.CommandType = CommandType.Text;
				if (mySqlDataReader.Read())
				{
					if (!(mySqlDataReader["Photo"] == null | mySqlDataReader["Photo"] == DBNull.Value))
					{
						byte[] buffer = (byte[])mySqlDataReader["Photo"];
						Image image = null;
						MemoryStream stream = new MemoryStream(buffer);
						PictureBox1.Image = Image.FromStream(stream);
					}
					else
					{
						PictureBox1.Image = null;
					}
					mySqlDataReader.Close();
					mySqlDataReader.Dispose();
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
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBox1.Checked)
			{
				REFART.Visible = false;
				Button5.Visible = false;
				Label1.Visible = false;
				List.Visible = true;
			}
			else
			{
				REFART.Visible = true;
				Button5.Visible = true;
				Label1.Visible = true;
				List.Visible = false;
			}
		}
	}
}
