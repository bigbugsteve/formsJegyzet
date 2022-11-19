using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JegyzetTar
{
	public partial class ucJegyzet : UserControl
	{
		public dsJegyzetTar? dsJegyzetTar { get; set; }
		public ucJegyzet()
		{
			InitializeComponent();
		}

		private void ucJegyzet_VisibleChanged(object sender, EventArgs e)
		{
			if (!Visible || dsJegyzetTar == null) return;
			cbJegyzet.DataSource = dsJegyzetTar.dtJegyzet;
			cbJegyzet.DisplayMember = "Cím";
			cbJegyzet.SelectedIndex = 0;
		}

		private void cbJegyzet_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbCím.Text = ((cbJegyzet.SelectedItem as DataRowView)?.Row as dsJegyzetTar.dtJegyzetRow)?.Cím;
            tbUrl.Text= ((cbJegyzet.SelectedItem as DataRowView)?.Row as dsJegyzetTar.dtJegyzetRow)?.URL;
        }

		private void btMent_Click(object sender, EventArgs e)
		{
			if (tbCím.Text.Length == 0) return;
			var rekord = (cbJegyzet.SelectedItem as DataRowView)?.Row as dsJegyzetTar.dtJegyzetRow;
			if (rekord == null) return;
			rekord.Cím = tbCím.Text;
			rekord.URL = tbUrl.Text;
		}

		private void btÚj_Click(object sender, EventArgs e)
		{
			var sor = (cbJegyzet.Items[cbJegyzet.Items.Count - 1] as DataRowView)?.Row as dsJegyzetTar.dtJegyzetRow;
			short sorszám = (short)(sor.Id + 1);

			dsJegyzetTar.dtJegyzet.AdddtJegyzetRow(sorszám, "Újcím", "ÚjUrl");
			cbJegyzet.SelectedIndex = cbJegyzet.Items.Count - 1;
		}

		private void btMégse_Click(object sender, EventArgs e)
		{
			Visible = false;
		}
	}
}
