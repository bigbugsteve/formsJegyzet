using System.Data;

namespace JegyzetTar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//L�trehoz();
			//Lement();
			Bet�lt();
		}

		private void Lement()
		{
			dsJegyzetTar.WriteXml("JegyzetTar.xml",XmlWriteMode.IgnoreSchema);
		}

		private void L�trehoz()
		{
			dsJegyzetTar.dtJegyzet.AdddtJegyzetRow(1,"C# alapok","https://");
			dsJegyzetTar.dtJegyzet.AdddtJegyzetRow(2,"C# halad�","https://");
			dsJegyzetTar.dtSzerz�.AdddtSzerz�Row(1,"Gipsz Jakab","gipsz@mail.hu");
			dsJegyzetTar.dtSzerz�.AdddtSzerz�Row(2,"Jegyzetszerz� Jol�n","jj@mail.hu");
			dsJegyzetTar.dtJSz.AdddtJSzRow(1, 1);
			dsJegyzetTar.dtJSz.AdddtJSzRow(1, 2);
			dsJegyzetTar.dtJSz.AdddtJSzRow(2, 2);
		}

		private void Bet�lt()
		{
			dsJegyzetTar.ReadXml("JegyzetTar.xml",
				XmlReadMode.InferSchema);
		}

		private void tsmiKil�p�s_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsmiB�ng�sz�s_Click(object sender, EventArgs e)
		{
			ucJegyzet.Visible = false;
			dgv.Visible = true;
			dgv.Dock = DockStyle.Fill;
			//dgv.DataSource = dsJegyzetTar.dtJegyzet;
			var eredm = from x in dsJegyzetTar.dtJegyzet
				select new 
				{	Szerz�k=(from y in dsJegyzetTar.dtJSz
							where y.IdJegyzet==x.Id
							join z in dsJegyzetTar.dtSzerz� 
								on y.IdSzerz� equals z.Id
									select z.N�v).Aggregate("",
									(s,val)=>s+(s.Length==0?"":", ")+val),
					x.C�m,
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

		private void ment�sToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lement();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Visible = false;
		}
	}
}