using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
	//[StandardModule]
	public sealed class Globals
	{
		public static int screenHeight = 1350;

		public static int screenWidth = 750;

		public static string connStr = ConfigurationManager.ConnectionStrings["ERP_ConnectionString"].ConnectionString;

		public static MySqlConnection conn = new MySqlConnection(connStr);

		public static string BDSERVICE = "erp_db";

		public static string BDHOST = "localhost";

		public static string BDUSER = "root";

		public static string BDPW = "";

		//public static Ajout_Fact Ajout_Fact1 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact2 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact3 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact4 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact5 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact6 = new Ajout_Fact();

		//public static Ajout_Fact Ajout_Fact7 = new Ajout_Fact();

		public static MySqlCommand cmd = new MySqlCommand();

		public static MySqlDataAdapter da = new MySqlDataAdapter();

		public static DataSet ds = new DataSet();

		public static string Utilisateur = "0";

		public static string MDP = "0";

		public static string Mail_user = "De";

		public static string NOMSOC;

		public static string ADRESSESOC;

		public static string flag_COD;

		public static string flag_COD_client;

		public static DateTime NowDate = DateTime.Now;

		public static void resolution(Form Form)
		{
			checked
			{
				try
				{
					if (conn.State == ConnectionState.Closed)
					{
						conn.Open();
					}
					cmd.Connection = conn;
					cmd.CommandText = "select IFNULL(longueur_ecran,0) longueur_ecran, IFNULL(largeur_ecran,0) largeur_ecran from UTILISATEUR where matricule_Uti= '" + Utilisateur + "'";
					cmd.CommandType = CommandType.Text;
					MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						screenHeight = Convert.ToInt32(convertDN(mySqlDataReader["longueur_ecran"].ToString()));
						screenWidth = Convert.ToInt32(convertDN(mySqlDataReader["largeur_ecran"].ToString()));
						Form.Size = new Size(screenHeight, screenWidth);
						Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
						Form.Left = (int)Math.Round(unchecked((double)checked(workingArea.Width - Form.Width) / 2.0));
						workingArea = Screen.PrimaryScreen.WorkingArea;
						Form.Top = (int)Math.Round(unchecked((double)checked(workingArea.Height - Form.Height) / 2.0));
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
					if (conn != null)
					{
						conn.Close();
					}
				}
			}
		}

		public static void clorerDGV(DataGridView Dgv)
		{
			int num = checked(Dgv.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (i % 2 == 1)
				{
					Dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else
				{
					Dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
			}
		}

		public static void Control_Nbre(object sender, KeyEventArgs e, string text)
		{
			bool flag = char.IsDigit(Strings.ChrW(e.KeyValue));
			bool flag2 = e.KeyCode >= Keys.NumPad0 & e.KeyCode <= Keys.NumPad9;
			bool flag3 = e.KeyCode == Keys.Decimal | e.KeyCode == Keys.OemQuestion | e.KeyCode == Keys.Back | e.KeyCode == Keys.OemPeriod;
			if (!(flag | flag2 | flag3))
			{
				MessageBox.Show("Caractère non valide!");
				text = "";
			}
		}

		public static void ExecuteUpdateQuery(string query)
		{
			conn = new MySqlConnection(connStr);
			da.UpdateCommand = new MySqlCommand(query, conn);
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			da.UpdateCommand.ExecuteNonQuery();
		}

		public static void ClaculNewCode(string sql, string selectmax, string CODE)
		{
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
				MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				int num = checked(dataTable.Rows.Count - 1);
				if (num == -1)
				{
					CODE = "1";
				}
				else
				{
					mySqlCommand.CommandText = selectmax;
					CODE = Conversions.ToString(mySqlCommand.ExecuteScalar());
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
				conn.Close();
			}
		}

		public static void ExecuteInsertQuery(string query)
		{
			conn = new MySqlConnection(connStr);
			cmd = new MySqlCommand(query, conn);
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			cmd.ExecuteNonQuery();
		}

		public static void LoadData(string query, DataGridView Dgv, string cpmName)
		{
			Dgv.DataSource = null;
			Dgv.Rows.Clear();
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			DataSet dataSet = new DataSet();
			conn = new MySqlConnection(connStr);
			mySqlDataAdapter.SelectCommand = new MySqlCommand(query, conn);
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			dataSet.Clear();
			mySqlDataAdapter.Fill(dataSet, cpmName);
			Dgv.DataSource = dataSet.Tables[cpmName];
		}

		public static void ClearTextBox(Control root)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = root.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					ClearTextBox(control);
					if (control is TextBox)
					{
						((TextBox)control).Text = string.Empty;
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

		public static void ClearComboBox(Control root)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = root.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					ClearComboBox(control);
					if (control is ComboBox)
					{
						((ComboBox)control).Text = string.Empty;
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

		public static decimal convertNull(object number)
		{
			if (number == DBNull.Value)
			{
				return default(decimal);
			}
			return Conversions.ToDecimal(number);
		}

		public static decimal convertDN(object number)
		{
			if (Operators.ConditionalCompareObjectEqual(number, "", false))
			{
				return default(decimal);
			}
			return Convert.ToDecimal(Strings.Replace(Conversions.ToString(number), ".", ",", 1, -1, CompareMethod.Binary));
		}

		public static int controlNum(object Text)
		{
			if (Text != "")
			{
				if (!decimal.TryParse(Strings.Replace(Conversions.ToString(Text), ".", ",", 1, -1, CompareMethod.Binary), out decimal _))
				{
					return 1;
				}
				return 0;
			}
			return 0;
		}

		public static void Societe()
		{
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				cmd.Connection = conn;
				cmd.CommandText = "select * from SOCIETE limit 1";
				cmd.CommandType = CommandType.Text;
				MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					NOMSOC = mySqlDataReader["NOM_SOC"].ToString();
					ADRESSESOC = mySqlDataReader["ADRESSE_SOC"].ToString();
				}
				mySqlDataReader.Close();
				mySqlDataReader.Dispose();
				if (conn != null)
				{
					conn.Close();
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
				if (conn != null)
				{
					conn.Close();
				}
			}
		}
	}
}
