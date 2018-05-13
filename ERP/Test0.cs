using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Test0 : Form
	{
		private IContainer components;

		public Test0()
		{
			base.Load += Test0_Load;
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
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(284, 261);
			base.Name = "Test0";
			Text = "Test0";
			base.ResumeLayout(false);
		}

		private void Test0_Load(object sender, EventArgs e)
		{
			Test();
		}

		public void Test()
		{
			string connectionString = "SERVER=localhost;DATABASE=erp_db;UID=root;PASSWORD=";
			MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
			mySqlCommand.CommandText = "select * from reglement";
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			checked
			{
				while (mySqlDataReader.Read())
				{
					string text = null;
					int num = mySqlDataReader.FieldCount - 1;
					for (int i = 0; i <= num; i++)
					{
					}
				}
				mySqlConnection.Close();
			}
		}
	}
}
