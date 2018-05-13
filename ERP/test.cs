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
	public class test : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("REFART")]
		private ComboBox _REFART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DateT")]
		private TextBox _DateT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		public string NewArticle;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Items;

		public int FalgNew;

		public int COD_E;

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
				EventHandler value3 = REFART_TextChanged;
				ComboBox rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click -= value2;
					rEFART.TextChanged -= value3;
				}
				_REFART = value;
				rEFART = _REFART;
				if (rEFART != null)
				{
					rEFART.Click += value2;
					rEFART.TextChanged += value3;
				}
			}
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

		internal virtual TextBox DateT
		{
			[CompilerGenerated]
			get
			{
				return _DateT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = DateT_Click;
				EventHandler value3 = DateT_TextChanged;
				TextBox dateT = _DateT;
				if (dateT != null)
				{
					dateT.Click -= value2;
					dateT.TextChanged -= value3;
				}
				_DateT = value;
				dateT = _DateT;
				if (dateT != null)
				{
					dateT.Click += value2;
					dateT.TextChanged += value3;
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

		private object Items
		{
			[CompilerGenerated]
			get
			{
				return _Items;
			}
			[CompilerGenerated]
			set
			{
				_Items = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public test()
		{
			FalgNew = 0;
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
			REFART = new ComboBox();
			MonthCalendar1 = new MonthCalendar();
			DateT = new TextBox();
			Button1 = new Button();
			base.SuspendLayout();
			REFART.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			REFART.FormattingEnabled = true;
			REFART.Location = new Point(84, 124);
			REFART.Name = "REFART";
			REFART.Size = new Size(124, 21);
			REFART.TabIndex = 6;
			MonthCalendar1.Location = new Point(149, 199);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 7;
			MonthCalendar1.Visible = false;
			DateT.Location = new Point(22, 199);
			DateT.Name = "DateT";
			DateT.ReadOnly = true;
			DateT.Size = new Size(100, 20);
			DateT.TabIndex = 8;
			Button1.Location = new Point(123, 197);
			Button1.Name = "Button1";
			Button1.Size = new Size(24, 23);
			Button1.TabIndex = 9;
			Button1.Text = "Button1";
			Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(435, 411);
			base.Controls.Add(MonthCalendar1);
			base.Controls.Add(Button1);
			base.Controls.Add(DateT);
			base.Controls.Add(REFART);
			base.Name = "test";
			Text = "test";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void REFART_Click(object sender, EventArgs e)
		{
		}

		private void REFART_TextChanged(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand mySqlCommand = new MySqlCommand();
				if (Globals.conn.State == ConnectionState.Closed)
				{
					Globals.conn.Open();
				}
				mySqlCommand.Connection = Globals.conn;
				mySqlCommand.CommandText = "select REFART from ARTICLE_D where REFART LIKE '" + REFART.Text + "%'";
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

		private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			DateT.Text = MonthCalendar1.SelectionStart.ToShortDateString();
			MonthCalendar1.Visible = false;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MonthCalendar1.Visible = true;
		}

		private void DateT_Click(object sender, EventArgs e)
		{
			MonthCalendar1.Visible = true;
			DateT.Text = "";
		}

		private void DateT_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
