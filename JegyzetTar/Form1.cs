using System.Data;

namespace JegyzetTar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Létrehoz();
			//Lement();
			Betölt();
		}

		private void Lement()
		{
			dsJegyzetTar.WriteXml("JegyzetTar.xml",XmlWriteMode.IgnoreSchema);
		}

		private void Létrehoz()
		{
			dsJegyzetTar.dtJegyzet.AdddtJegyzetRow(1,"C# alapok","https://");
			dsJegyzetTar.dtJegyzet.AdddtJegyzetRow(2,"C# haladó","https://");
			dsJegyzetTar.dtSzerzõ.AdddtSzerzõRow(1,"Gipsz Jakab","gipsz@mail.hu");
			dsJegyzetTar.dtSzerzõ.AdddtSzerzõRow(2,"Jegyzetszerzõ Jolán","jj@mail.hu");
			dsJegyzetTar.dtJSz.AdddtJSzRow(1, 1);
			dsJegyzetTar.dtJSz.AdddtJSzRow(1, 2);
			dsJegyzetTar.dtJSz.AdddtJSzRow(2, 2);
		}

		private void Betölt()
		{
			dsJegyzetTar.ReadXml("JegyzetTar.xml",
				XmlReadMode.InferSchema);
		}

		private void tsmiKilépés_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsmiBöngészés_Click(object sender, EventArgs e)
		{
			ucJegyzet.Visible = false;
			dgv.Visible = true;
			dgv.Dock = DockStyle.Fill;
			//dgv.DataSource = dsJegyzetTar.dtJegyzet;
			var eredm = from x in dsJegyzetTar.dtJegyzet
				select new 
				{	Szerzõk=(from y in dsJegyzetTar.dtJSz
							where y.IdJegyzet==x.Id
							join z in dsJegyzetTar.dtSzerzõ 
								on y.IdSzerzõ equals z.Id
									select z.Név).Aggregate("",
									(s,val)=>s+(s.Length==0?"":", ")+val),
					x.Cím,
					x.URL
				};
			dgv.DataSource = eredm.ToList();
		}

		private void tsmiJegyzetek_Click(object sender, EventArgs e)
		{
			dgv.Visible=false;
			ucJegyzet.dsJegyzetTar = dsJegyzetTar;
			ucJegyzet.Visible = true;
			ucJegyzet.Dock = DockStyle.Fill;
		}

		private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lement();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Visible = false;
		}
	}
}