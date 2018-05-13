using ERP.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class FrmAccueil : Accueil
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel_ES")]
		private Panel _Panel_ES;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel_Vente")]
		private Panel _Panel_Vente;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel_SS")]
		private Panel _Panel_SS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel6")]
		private Panel _Panel6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel5")]
		private Panel _Panel5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel15")]
		private Panel _Panel15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel14")]
		private Panel _Panel14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel13")]
		private Panel _Panel13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel12")]
		private Panel _Panel12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel11")]
		private Panel _Panel11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel9")]
		private Panel _Panel9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel8")]
		private Panel _Panel8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel7")]
		private Panel _Panel7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		internal virtual Button Button13
		{
			[CompilerGenerated]
			get
			{
				return _Button13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button13_Click;
				Button button = _Button13;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button13 = value;
				button = _Button13;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button15
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

		internal virtual Label Label11
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return _Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel1_Enter;
				Panel panel = _Panel1;
				if (panel != null)
				{
					panel.Enter -= value2;
				}
				_Panel1 = value;
				panel = _Panel1;
				if (panel != null)
				{
					panel.Enter += value2;
				}
			}
		}

		internal virtual Panel Panel_ES
		{
			[CompilerGenerated]
			get
			{
				return _Panel_ES;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel_ES_Click;
				Panel panel_ES = _Panel_ES;
				if (panel_ES != null)
				{
					panel_ES.Click -= value2;
				}
				_Panel_ES = value;
				panel_ES = _Panel_ES;
				if (panel_ES != null)
				{
					panel_ES.Click += value2;
				}
			}
		}

		internal virtual Panel Panel_Vente
		{
			[CompilerGenerated]
			get
			{
				return _Panel_Vente;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel_Vente_Click;
				Panel panel_Vente = _Panel_Vente;
				if (panel_Vente != null)
				{
					panel_Vente.Click -= value2;
				}
				_Panel_Vente = value;
				panel_Vente = _Panel_Vente;
				if (panel_Vente != null)
				{
					panel_Vente.Click += value2;
				}
			}
		}

		internal virtual Button Button21
		{
			[CompilerGenerated]
			get
			{
				return _Button21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button21_Click;
				Button button = _Button21;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button21 = value;
				button = _Button21;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return _Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button7_Click;
				Button button = _Button7;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button7 = value;
				button = _Button7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button10
		{
			[CompilerGenerated]
			get
			{
				return _Button10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button10_Click;
				Button button = _Button10;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button10 = value;
				button = _Button10;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return _Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button4_Click;
				Button button = _Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button4 = value;
				button = _Button4;
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
				EventHandler value2 = Button3_Click_1;
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

		internal virtual Button Button20
		{
			[CompilerGenerated]
			get
			{
				return _Button20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button20_Click;
				Button button = _Button20;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button20 = value;
				button = _Button20;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Panel Panel_SS
		{
			[CompilerGenerated]
			get
			{
				return _Panel_SS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel_SS_Click;
				Panel panel_SS = _Panel_SS;
				if (panel_SS != null)
				{
					panel_SS.Click -= value2;
				}
				_Panel_SS = value;
				panel_SS = _Panel_SS;
				if (panel_SS != null)
				{
					panel_SS.Click += value2;
				}
			}
		}

		internal virtual Panel Panel6
		{
			[CompilerGenerated]
			get
			{
				return _Panel6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel6_Click;
				Panel panel = _Panel6;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel6 = value;
				panel = _Panel6;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel5
		{
			[CompilerGenerated]
			get
			{
				return _Panel5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel5_Click;
				Panel panel = _Panel5;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel5 = value;
				panel = _Panel5;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel15
		{
			[CompilerGenerated]
			get
			{
				return _Panel15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel15_Click;
				Panel panel = _Panel15;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel15 = value;
				panel = _Panel15;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel14
		{
			[CompilerGenerated]
			get
			{
				return _Panel14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel14_Click;
				Panel panel = _Panel14;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel14 = value;
				panel = _Panel14;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel13
		{
			[CompilerGenerated]
			get
			{
				return _Panel13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel13_Click;
				Panel panel = _Panel13;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel13 = value;
				panel = _Panel13;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel12
		{
			[CompilerGenerated]
			get
			{
				return _Panel12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel12_Click;
				Panel panel = _Panel12;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel12 = value;
				panel = _Panel12;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel11
		{
			[CompilerGenerated]
			get
			{
				return _Panel11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel11_Click;
				Panel panel = _Panel11;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel11 = value;
				panel = _Panel11;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel9
		{
			[CompilerGenerated]
			get
			{
				return _Panel9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel9_Click;
				Panel panel = _Panel9;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel9 = value;
				panel = _Panel9;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel8
		{
			[CompilerGenerated]
			get
			{
				return _Panel8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel8_Enter;
				EventHandler value3 = Panel8_Click;
				Panel panel = _Panel8;
				if (panel != null)
				{
					panel.Enter -= value2;
					panel.Click -= value3;
				}
				_Panel8 = value;
				panel = _Panel8;
				if (panel != null)
				{
					panel.Enter += value2;
					panel.Click += value3;
				}
			}
		}

		internal virtual Panel Panel7
		{
			[CompilerGenerated]
			get
			{
				return _Panel7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel7_Click;
				Panel panel = _Panel7;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel7 = value;
				panel = _Panel7;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return _Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel2_Click_1;
				Panel panel = _Panel2;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel2 = value;
				panel = _Panel2;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return _Panel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Panel3_Click;
				Panel panel = _Panel3;
				if (panel != null)
				{
					panel.Click -= value2;
				}
				_Panel3 = value;
				panel = _Panel3;
				if (panel != null)
				{
					panel.Click += value2;
				}
			}
		}

		internal virtual Button Button1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button Button14
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label Label10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public FrmAccueil()
		{
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

		
		public void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmAccueil));
			Button13 = new Button();
			Button15 = new Button();
			Label9 = new Label();
			Label11 = new Label();
			Panel1 = new Panel();
			Button1 = new Button();
			Panel3 = new Panel();
			Panel2 = new Panel();
			Panel15 = new Panel();
			Panel14 = new Panel();
			Panel13 = new Panel();
			Panel12 = new Panel();
			Panel11 = new Panel();
			Panel9 = new Panel();
			Panel8 = new Panel();
			Panel7 = new Panel();
			Panel6 = new Panel();
			Panel5 = new Panel();
			Panel_ES = new Panel();
			Panel_Vente = new Panel();
			Button21 = new Button();
			Button7 = new Button();
			Button10 = new Button();
			Button4 = new Button();
			Button3 = new Button();
			Button20 = new Button();
			Panel_SS = new Panel();
			Button14 = new Button();
			Label10 = new Label();
			Panel1.SuspendLayout();
			base.SuspendLayout();
			//Button13.BackgroundImage = (Image)componentResourceManager.GetObject("Button13.BackgroundImage");
			Button13.Cursor = Cursors.Hand;
			Button13.Location = new Point(1276, 570);
			Button13.Margin = new Padding(3, 4, 3, 4);
			Button13.Name = "Button13";
			Button13.Size = new Size(70, 75);
			Button13.TabIndex = 15;
			Button13.UseVisualStyleBackColor = true;
			//Button15.BackgroundImage = (Image)componentResourceManager.GetObject("Button15.BackgroundImage");
			Button15.Cursor = Cursors.Hand;
			Button15.Location = new Point(1277, 358);
			Button15.Margin = new Padding(3, 4, 3, 4);
			Button15.Name = "Button15";
			Button15.Size = new Size(69, 72);
			Button15.TabIndex = 17;
			Button15.UseVisualStyleBackColor = true;
			Label9.AutoSize = true;
			Label9.BackColor = Color.Transparent;
			Label9.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label9.ForeColor = SystemColors.ButtonHighlight;
			Label9.Location = new Point(1294, 434);
			Label9.Name = "Label9";
			Label9.Size = new Size(44, 16);
			Label9.TabIndex = 26;
			Label9.Text = "Outils";
			Label11.AutoSize = true;
			Label11.BackColor = Color.Transparent;
			Label11.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label11.ForeColor = SystemColors.ButtonHighlight;
			Label11.Location = new Point(1287, 649);
			Label11.Name = "Label11";
			Label11.Size = new Size(51, 16);
			Label11.TabIndex = 28;
			Label11.Text = "Quitter";
			//Panel1.BackgroundImage = (Image)componentResourceManager.GetObject("Panel1.BackgroundImage");
			Panel1.BackgroundImageLayout = ImageLayout.Stretch;
			Panel1.Controls.Add(Button1);
			Panel1.Controls.Add(Panel3);
			Panel1.Controls.Add(Panel2);
			Panel1.Controls.Add(Panel15);
			Panel1.Controls.Add(Panel14);
			Panel1.Controls.Add(Panel13);
			Panel1.Controls.Add(Panel12);
			Panel1.Controls.Add(Panel11);
			Panel1.Controls.Add(Panel9);
			Panel1.Controls.Add(Panel8);
			Panel1.Controls.Add(Panel7);
			Panel1.Controls.Add(Panel6);
			Panel1.Controls.Add(Panel5);
			Panel1.Controls.Add(Panel_ES);
			Panel1.Controls.Add(Panel_Vente);
			Panel1.Controls.Add(Button21);
			Panel1.Controls.Add(Button7);
			Panel1.Controls.Add(Button10);
			Panel1.Controls.Add(Button4);
			Panel1.Controls.Add(Button3);
			Panel1.Controls.Add(Button20);
			Panel1.Controls.Add(Panel_SS);
			Panel1.Location = new Point(0, 55);
			Panel1.Name = "Panel1";
			Panel1.Size = new Size(1263, 625);
			Panel1.TabIndex = 109;
			Button1.BackColor = Color.Transparent;
			Button1.Cursor = Cursors.Hand;
			Button1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button1.ForeColor = Color.Black;
			Button1.Location = new Point(667, 15);
			Button1.Name = "Button1";
			Button1.Size = new Size(178, 26);
			Button1.TabIndex = 176;
			Button1.Text = "Gestion des fournisseurs";
			Button1.UseVisualStyleBackColor = false;
			Panel3.BackColor = Color.Transparent;
			Panel3.Cursor = Cursors.Hand;
			Panel3.Location = new Point(753, 425);
			Panel3.Name = "Panel3";
			Panel3.Size = new Size(92, 83);
			Panel3.TabIndex = 175;
			Panel2.BackColor = Color.Transparent;
			Panel2.Cursor = Cursors.Hand;
			Panel2.Location = new Point(753, 303);
			Panel2.Name = "Panel2";
			Panel2.Size = new Size(92, 83);
			Panel2.TabIndex = 174;
			Panel15.BackColor = Color.Transparent;
			Panel15.Cursor = Cursors.Hand;
			Panel15.Location = new Point(997, 31);
			Panel15.Name = "Panel15";
			Panel15.Size = new Size(123, 96);
			Panel15.TabIndex = 174;
			Panel14.BackColor = Color.Transparent;
			Panel14.Cursor = Cursors.Hand;
			Panel14.Location = new Point(997, 188);
			Panel14.Name = "Panel14";
			Panel14.Size = new Size(123, 96);
			Panel14.TabIndex = 174;
			Panel13.BackColor = Color.Transparent;
			Panel13.Cursor = Cursors.Hand;
			Panel13.Location = new Point(997, 334);
			Panel13.Name = "Panel13";
			Panel13.Size = new Size(123, 96);
			Panel13.TabIndex = 173;
			Panel12.BackColor = Color.Transparent;
			Panel12.Cursor = Cursors.Hand;
			Panel12.Location = new Point(865, 253);
			Panel12.Name = "Panel12";
			Panel12.Size = new Size(105, 89);
			Panel12.TabIndex = 173;
			Panel11.BackColor = Color.Transparent;
			Panel11.Cursor = Cursors.Hand;
			Panel11.Location = new Point(865, 389);
			Panel11.Name = "Panel11";
			Panel11.Size = new Size(105, 89);
			Panel11.TabIndex = 172;
			Panel9.BackColor = Color.Transparent;
			//Panel9.BackgroundImage = (Image)componentResourceManager.GetObject("Panel9.BackgroundImage");
			Panel9.Cursor = Cursors.Hand;
			Panel9.Location = new Point(657, 350);
			Panel9.Name = "Panel9";
			Panel9.Size = new Size(75, 62);
			Panel9.TabIndex = 171;
			Panel8.BackColor = Color.Transparent;
			//Panel8.BackgroundImage = (Image)componentResourceManager.GetObject("Panel8.BackgroundImage");
			Panel8.Cursor = Cursors.Hand;
			Panel8.Location = new Point(567, 394);
			Panel8.Name = "Panel8";
			Panel8.Size = new Size(68, 61);
			Panel8.TabIndex = 171;
			Panel7.BackColor = Color.Transparent;
			//Panel7.BackgroundImage = (Image)componentResourceManager.GetObject("Panel7.BackgroundImage");
			Panel7.Cursor = Cursors.Hand;
			Panel7.Location = new Point(491, 325);
			Panel7.Name = "Panel7";
			Panel7.Size = new Size(68, 61);
			Panel7.TabIndex = 170;
			Panel6.BackColor = Color.Transparent;
			//Panel6.BackgroundImage = (Image)componentResourceManager.GetObject("Panel6.BackgroundImage");
			Panel6.Cursor = Cursors.Hand;
			Panel6.Location = new Point(567, 282);
			Panel6.Name = "Panel6";
			Panel6.Size = new Size(68, 61);
			Panel6.TabIndex = 169;
			Panel5.BackColor = Color.Transparent;
			//Panel5.BackgroundImage = (Image)componentResourceManager.GetObject("Panel5.BackgroundImage");
			Panel5.Cursor = Cursors.Hand;
			Panel5.Location = new Point(491, 228);
			Panel5.Name = "Panel5";
			Panel5.Size = new Size(58, 56);
			Panel5.TabIndex = 168;
			Panel_ES.BackColor = Color.Transparent;
			//Panel_ES.BackgroundImage = (Image)componentResourceManager.GetObject("Panel_ES.BackgroundImage");
			Panel_ES.Cursor = Cursors.Hand;
			Panel_ES.Location = new Point(491, 124);
			Panel_ES.Name = "Panel_ES";
			Panel_ES.Size = new Size(58, 58);
			Panel_ES.TabIndex = 168;
			Panel_Vente.BackColor = Color.Transparent;
			//Panel_Vente.BackgroundImage = (Image)componentResourceManager.GetObject("Panel_Vente.BackgroundImage");
			Panel_Vente.Cursor = Cursors.Hand;
			Panel_Vente.Location = new Point(420, 163);
			Panel_Vente.Name = "Panel_Vente";
			Panel_Vente.Size = new Size(63, 66);
			Panel_Vente.TabIndex = 166;
			Button21.BackColor = Color.Transparent;
			Button21.Cursor = Cursors.Hand;
			Button21.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button21.ForeColor = Color.Black;
			Button21.Location = new Point(667, 142);
			Button21.Name = "Button21";
			Button21.Size = new Size(178, 26);
			Button21.TabIndex = 165;
			Button21.Text = "Gestion des factures";
			Button21.UseVisualStyleBackColor = false;
			Button7.BackColor = Color.Transparent;
			Button7.Cursor = Cursors.Hand;
			Button7.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button7.ForeColor = Color.Black;
			Button7.Location = new Point(667, 110);
			Button7.Name = "Button7";
			Button7.Size = new Size(178, 26);
			Button7.TabIndex = 163;
			Button7.Text = "Gestion des articles";
			Button7.UseVisualStyleBackColor = false;
			Button10.BackColor = Color.Transparent;
			Button10.Cursor = Cursors.Hand;
			Button10.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button10.ForeColor = Color.Black;
			Button10.Location = new Point(667, 174);
			Button10.Name = "Button10";
			Button10.Size = new Size(178, 26);
			Button10.TabIndex = 164;
			Button10.Text = "Gestion des comptes";
			Button10.UseVisualStyleBackColor = false;
			Button4.BackColor = Color.Transparent;
			Button4.Cursor = Cursors.Hand;
			Button4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button4.ForeColor = Color.Black;
			Button4.Location = new Point(667, 79);
			Button4.Name = "Button4";
			Button4.Size = new Size(178, 26);
			Button4.TabIndex = 162;
			Button4.Text = "Gestion des clients";
			Button4.UseVisualStyleBackColor = false;
			Button3.BackColor = Color.Transparent;
			Button3.Cursor = Cursors.Hand;
			Button3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button3.ForeColor = Color.Black;
			Button3.Location = new Point(667, 47);
			Button3.Name = "Button3";
			Button3.Size = new Size(178, 26);
			Button3.TabIndex = 161;
			Button3.Text = "Mouvement du stock";
			Button3.UseVisualStyleBackColor = false;
			Button20.BackColor = Color.Transparent;
			Button20.Cursor = Cursors.Hand;
			Button20.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button20.ForeColor = Color.Black;
			Button20.Location = new Point(667, 203);
			Button20.Name = "Button20";
			Button20.Size = new Size(178, 26);
			Button20.TabIndex = 160;
			Button20.Text = "Statistiques";
			Button20.UseVisualStyleBackColor = false;
			Panel_SS.BackColor = Color.Transparent;
			//Panel_SS.BackgroundImage = (Image)componentResourceManager.GetObject("Panel_SS.BackgroundImage");
			Panel_SS.Cursor = Cursors.Hand;
			Panel_SS.Location = new Point(577, 179);
			Panel_SS.Name = "Panel_SS";
			Panel_SS.Size = new Size(58, 64);
			Panel_SS.TabIndex = 167;
			//Button14.BackgroundImage = (Image)componentResourceManager.GetObject("Button14.BackgroundImage");
			Button14.Cursor = Cursors.Hand;
			Button14.Location = new Point(1277, 460);
			Button14.Margin = new Padding(3, 4, 3, 4);
			Button14.Name = "Button14";
			Button14.Size = new Size(69, 73);
			Button14.TabIndex = 16;
			Button14.UseVisualStyleBackColor = true;
			Label10.AutoSize = true;
			Label10.BackColor = Color.Transparent;
			Label10.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label10.ForeColor = SystemColors.ButtonHighlight;
			Label10.Location = new Point(1266, 537);
			Label10.Name = "Label10";
			Label10.Size = new Size(92, 16);
			Label10.TabIndex = 27;
			Label10.Text = "Menu second";
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			//BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new Size(1350, 733);
			base.Controls.Add(Panel1);
			base.Controls.Add(Label11);
			base.Controls.Add(Label10);
			base.Controls.Add(Label9);
			base.Controls.Add(Button15);
			base.Controls.Add(Button14);
			base.Controls.Add(Button13);
			base.Location = new Point(0, 0);
			base.Margin = new Padding(5);
			base.Name = "FrmAccueil";
			base.Controls.SetChildIndex(Button13, 0);
			base.Controls.SetChildIndex(Button14, 0);
			base.Controls.SetChildIndex(Button15, 0);
			base.Controls.SetChildIndex(Label9, 0);
			base.Controls.SetChildIndex(Label10, 0);
			base.Controls.SetChildIndex(Label11, 0);
			base.Controls.SetChildIndex(Panel1, 0);
			Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
		}

		private void Button13_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
			MyProject.Forms.Gestion_stock.BringToFront();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
			MyProject.Forms.Sortie_Stock.BringToFront();
		}

		private void Button18_Click(object sender, EventArgs e)
		{
			Gestion_Vente gestion_Vente = new Gestion_Vente();
			gestion_Vente.Show();
			gestion_Vente.GB_MONT.Visible = false;
			gestion_Vente.GB_COM.Visible = true;
			gestion_Vente.LB_Article.SelectedItem = "Article Commercial";
			gestion_Vente.BringToFront();
			gestion_Vente.REFART_C.Focus();
		}

		private void Button12_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Affich_membres.Show();
			MyProject.Forms.Affich_membres.BringToFront();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Article.Show();
			MyProject.Forms.Histo_Article.BringToFront();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Client.Show();
			MyProject.Forms.Histo_Client.BringToFront();
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
			MyProject.Forms.Gestion_Fourn.BringToFront();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
		}

		private void Button23_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Article.Show();
			MyProject.Forms.Histo_Article.BringToFront();
		}

		private void Label16_Click(object sender, EventArgs e)
		{
		}

		private void Button17_Click(object sender, EventArgs e)
		{
		}

		private void Button24_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "TICKET";
			histo_Fact.TABLEDF = "VENTE";
			histo_Fact.REGLEMENT0 = "mode_regl Reglement,(montant_regl-totalttc_fact) Rendu";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Panel2_Click(object sender, EventArgs e)
		{
			Gestion_Vente gestion_Vente = new Gestion_Vente();
			gestion_Vente.Show();
			gestion_Vente.GB_MONT.Visible = false;
			gestion_Vente.GB_COM.Visible = true;
			gestion_Vente.LB_Article.SelectedItem = "Article Commercial";
			gestion_Vente.BringToFront();
			gestion_Vente.REFART_C.Focus();
		}

		private void Panel_SS_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sortie_Stock.Show();
			MyProject.Forms.Sortie_Stock.BringToFront();
		}

		private void Panel9_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Affich_membres.Show();
			MyProject.Forms.Affich_membres.BringToFront();
		}

		private void Panel_ES_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Entree_Stock.Show();
			MyProject.Forms.Entree_Stock.BringToFront();
		}

		private void Panel5_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
			MyProject.Forms.Gestion_Article_Com.LB_Article.SelectedItem = "Article Commercial";
		}

		private void Panel7_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Fourn.Show();
			MyProject.Forms.Gestion_Fourn.BringToFront();
		}

		private void Panel6_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
		}

		private void Panel11_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Client.Show();
			MyProject.Forms.Histo_Client.BringToFront();
		}

		private void Panel2_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Article.Show();
			MyProject.Forms.Histo_Article.BringToFront();
		}

		private void Panel12_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
		}

		private void Panel14_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Stat_Stock.Show();
			MyProject.Forms.Stat_Stock.BringToFront();
		}

		private void Panel13_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "TICKET";
			histo_Fact.TABLEDF = "VENTE";
			histo_Fact.REGLEMENT0 = "mode_regl Reglement,(montant_regl-totalttc_fact) Rendu";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.Show();
			histo_Fact.BringToFront();
			histo_Fact.Reg_Multi.Visible = true;
		}

		private void Panel1_Enter(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.BringToFront();
		}

		private void Panel8_Enter(object sender, EventArgs e)
		{
		}

		private void Panel8_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Mail.Show();
			MyProject.Forms.Mail.BringToFront();
		}

		private void Panel3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Histo_Fourn.Show();
			MyProject.Forms.Histo_Fourn.BringToFront();
		}

		private void Panel15_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
		}

		private void Button3_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_stock.Show();
			MyProject.Forms.Gestion_stock.BringToFront();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Client.Show();
			MyProject.Forms.Gestion_Client.BringToFront();
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Article_Com.Show();
			MyProject.Forms.Gestion_Article_Com.BringToFront();
			MyProject.Forms.Gestion_Article_Com.LB_Article.SelectedItem = "Article Commercial";
		}

		private void Button21_Click(object sender, EventArgs e)
		{
			Histo_Fact histo_Fact = new Histo_Fact();
			histo_Fact.TABLEFACT = "TICKET";
			histo_Fact.TABLEDF = "VENTE";
			histo_Fact.REGLEMENT0 = "mode_regl Reglement,(montant_regl-totalttc_fact) Rendu";
			histo_Fact.Text = "Historique Facture";
			histo_Fact.Show();
			histo_Fact.BringToFront();
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_User.Show();
			MyProject.Forms.Gestion_User.BringToFront();
		}

		private void Button20_Click(object sender, EventArgs e)
		{
			stat_CA stat_CA = new stat_CA();
			stat_CA.Show();
			stat_CA.BringToFront();
		}

		private void Panel_Vente_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Gestion_Vente.Show();
			MyProject.Forms.Gestion_Vente.LB_Article.SelectedItem = "Article Commercial";
			MyProject.Forms.Gestion_Vente.GB_MONT.Visible = false;
			MyProject.Forms.Gestion_Vente.GB_COM.Visible = true;
			MyProject.Forms.Gestion_Vente.BringToFront();
			MyProject.Forms.Gestion_Vente.REFART_C.Focus();
		}
	}
}
