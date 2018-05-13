using ERP.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ERP
{
	[DesignerGenerated]
	public class Affich_Calendar : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MonthCalendar1")]
		private MonthCalendar _MonthCalendar1;

		internal virtual MonthCalendar MonthCalendar1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Affich_Calendar()
		{
			base.KeyDown += Affich_Calendar_KeyDown;
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
			MonthCalendar1 = new MonthCalendar();
			base.SuspendLayout();
			MonthCalendar1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			MonthCalendar1.Location = new Point(8, 1);
			MonthCalendar1.Name = "MonthCalendar1";
			MonthCalendar1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Resources.arrière_plan_blanc_V2;
			base.ClientSize = new Size(274, 220);
			base.Controls.Add(MonthCalendar1);
			base.Name = "Affich_Calendar";
			base.StartPosition = FormStartPosition.CenterParent;
			Text = "Calendrier";
			base.ResumeLayout(false);
		}

		private void Affich_Calendar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}
	}
}
