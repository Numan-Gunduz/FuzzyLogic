using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;


namespace Bulanik_Mantik_ÇM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		BulanikMantık? bulanıkMantik;
		double hassaslik;
		double kirlilik;
		double miktar;
		private void buton_hesapla(object sender, EventArgs e)
		{
			hassaslik = (double)numericUpDown1.Value;
			kirlilik = (double)numericUpDown2.Value;
			miktar = (double)numericUpDown3.Value;
			bulanıkMantik = new BulanikMantık(hassaslik, miktar, kirlilik);
			bulanıkMantik.Kume_degerleri(lblkumeH, lblKumeM, lblKumeK);
			kural_tablo_temizle();
			kural_isaretle();
			listBox1.Items.Clear();
			Dictionary<int, double> mamdani_sonuc = new Dictionary<int, double>();
			mamdani_sonuc = bulanıkMantik.BulunanNumaralar();
			var sirala = mamdani_sonuc.OrderBy(i => i.Key);
			foreach (var i in sirala)
			{
				listBox1.Items.Add("Kural " + i.Key + " = " + i.Value);
			}

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			kural_tablosu_yaz();

		}
		void kural_tablosu_yaz()
		{

			string[,] kural_al = Uzman.UzmanKurallari;
			for (int i = 0; i < 27; i++)
			{
				dataGridView1.Rows.Add();
				for (int j = 0; j < 6; j++)
				{
					dataGridView1.Rows[i].Cells[0].Value = i + 1;
					dataGridView1.Rows[i].Cells[j + 1].Value = kural_al[i, j];
				}
			}
		}
		void kural_isaretle()
		{
			string[,] kural = Uzman.UzmanKurallari;

			for (int k = 0; k < bulanıkMantik?.hassaslik_deger.Count; k++)
			{
				for (int m = 0; m < bulanıkMantik?.miktar_deger.Count; m++)
				{
					for (int n = 0; n < bulanıkMantik?.kirlilik_deger.Count; n++)
					{
						for (int i = 0; i < 27; i++)
						{
							if (kural[i, 0] == bulanıkMantik.hassaslik_deger[k] && kural[i, 1] == bulanıkMantik.miktar_deger[m] && kural[i, 2] == bulanıkMantik.kirlilik_deger[n])
							{
								DataGridViewCellStyle renk = new DataGridViewCellStyle();
								renk.BackColor = Color.SteelBlue;
								dataGridView1.Rows[i].DefaultCellStyle = renk;
								i++;
							}
						}
					}
				}
			}
		}
		void kural_tablo_temizle()
		{
			int rowCount = dataGridView1.Rows.Count;
			for (int i = 0; i < 27; i++)
			{
				DataGridViewCellStyle renk = new DataGridViewCellStyle();
				
				dataGridView1.Rows[i].DefaultCellStyle = renk;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BulanikMantık bulanikMantik = new BulanikMantık(hassaslik, miktar, kirlilik);

			bulanikMantik.HesaplaMamdaniAğırlıklıOrtalama();
			lblDeterjan.Text = bulanikMantik.ağırlıklıOrtalamaDeterjan.ToString();
			lblSüre.Text = bulanikMantik.ağırlıklıOrtalamaSüre.ToString();
			lblDönüşHızı.Text = bulanikMantik.ağırlıklıOrtalamaDönüşHızı.ToString();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}
	}

}
