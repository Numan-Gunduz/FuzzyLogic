
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace Bulanik_Mantik_ÇM
{
	public class BulanikMantık
	{

		public double hassaslik, miktar, kirlilik;

		public string[] uyeliktipi = { "yamuk1", "üçgen", "yamuk2" };

		public List<string> kirlilik_deger = new List<string>();
		public List<string> kirlilik_uyelik = new List<string>();
		public List<string> miktar_deger = new List<string>();
		public List<string> miktar_uyelik = new List<string>();
		public List<string> hassasiyet_uyelik = new List<string>();
		public List<string> hassaslik_deger = new List<string>();
		
		public BulanikMantık(double hassaslik, double miktar, double kirlilik)
		{
			this.hassaslik = hassaslik;
			this.kirlilik = kirlilik;
			this.miktar = miktar;
			Hassasiyet_kontrolu(hassaslik);
			Miktar_kontrolu(miktar);
			Kirlilik_kontrolu(kirlilik);

		}

		public void Kume_degerleri(System.Windows.Forms.Label bir, System.Windows.Forms.Label iki, System.Windows.Forms.Label uc)

		{
			string hassaslikText = string.Join(",", hassaslik_deger);
			string miktarText = string.Join(",", miktar_deger);
			string kirlilikText = string.Join(",", kirlilik_deger);

			bir.Text = hassaslikText;
			iki.Text = miktarText;
			uc.Text = kirlilikText;

			bir.BackColor = iki.BackColor = uc.BackColor = Color.SteelBlue;
		}
		public void Hassasiyet_kontrolu(double h)
		{
			switch (h)
			{
				case var _ when h > 0 && h < 3:
					hassaslik_deger.Add("sağlam");
					break;
				case var _ when h > 4 && h < 5.5:
					hassaslik_deger.Add("orta");
					break;
				case var _ when h > 7 && h <= 10:
					hassaslik_deger.Add("hassas");
					break;
				case var _ when h >= 3 && h <= 4:
					hassaslik_deger.Add("sağlam");
					hassaslik_deger.Add("orta");
					break;
				case var _ when h >= 5.5 && h <= 7:
					hassaslik_deger.Add("orta");
					hassaslik_deger.Add("hassas");
					break;
			}

			switch (hassaslik_deger.Count)
			{
				case 1:
					switch (hassaslik_deger[0])
					{
						case "sağlam":
							hassasiyet_uyelik.Add(uyeliktipi[0]);
							break;
						case "hassas":
							hassasiyet_uyelik.Add(uyeliktipi[2]);
							break;
						case "orta":
							hassasiyet_uyelik.Add(uyeliktipi[1]);
							break;
					}
					break;
				default:
					switch (hassaslik_deger[0])
					{
						case "sağlam" when hassaslik_deger[1] == "orta":
							hassasiyet_uyelik.Add(uyeliktipi[0]);
							hassasiyet_uyelik.Add(uyeliktipi[1]);
							break;
						default:
							hassasiyet_uyelik.Add(uyeliktipi[1]);
							hassasiyet_uyelik.Add(uyeliktipi[2]);
							break;
					}
					break;
			}
		}

		public void Kirlilik_kontrolu(double k)
		{
			switch (k)
			{
				case var _ when k > 0 && k < 3:
					kirlilik_deger.Add("küçük");
					break;
				case var _ when k > 4.5 && k < 5.5:
					kirlilik_deger.Add("orta");
					break;
				case var _ when k > 7 && k <= 10:
					kirlilik_deger.Add("büyük");
					break;
				case var _ when k >= 3 && k <= 4.5:
					kirlilik_deger.Add("küçük");
					kirlilik_deger.Add("orta");
					break;
				case var _ when k >= 5.5 && k <= 7:
					kirlilik_deger.Add("orta");
					kirlilik_deger.Add("büyük");
					break;
			}

			switch (kirlilik_deger.Count)
			{
				case 1:
					switch (kirlilik_deger[0])
					{
						case "küçük":
							kirlilik_uyelik.Add(uyeliktipi[0]);
							break;
						case "büyük":
							kirlilik_uyelik.Add(uyeliktipi[2]);
							break;
						case "orta":
							kirlilik_uyelik.Add(uyeliktipi[1]);
							break;
					}
					break;
				default:
					switch (kirlilik_deger[0])
					{
						case "küçük" when kirlilik_deger[1] == "orta":
							kirlilik_uyelik.Add(uyeliktipi[0]);
							kirlilik_uyelik.Add(uyeliktipi[1]);
							break;
						default:
							kirlilik_uyelik.Add(uyeliktipi[1]);
							kirlilik_uyelik.Add(uyeliktipi[2]);
							break;
					}
					break;
			}
		}

		public void Miktar_kontrolu(double m)
		{
			switch (m)
			{
				case var _ when m > 0 && m < 3:
					miktar_deger.Add("küçük");
					break;
				case var _ when m > 4 && m < 5.5:
					miktar_deger.Add("orta");
					break;
				case var _ when m > 7 && m <= 10:
					miktar_deger.Add("büyük");
					break;
				case var _ when m >= 3 && m <= 4:
					miktar_deger.Add("küçük");
					miktar_deger.Add("orta");
					break;
				case var _ when m >= 5.5 && m <= 7:
					miktar_deger.Add("orta");
					miktar_deger.Add("büyük");
					break;
			}

			switch (miktar_deger.Count)
			{
				case 1:
					switch (miktar_deger[0])
					{
						case "küçük":
							miktar_uyelik.Add(uyeliktipi[0]);
							break;
						case "büyük":
							miktar_uyelik.Add(uyeliktipi[2]);
							break;
						case "orta":
							miktar_uyelik.Add(uyeliktipi[1]);
							break;
					}
					break;
				default:
					switch (miktar_deger[0])
					{
						case "küçük" when miktar_deger[1] == "orta":
							miktar_uyelik.Add(uyeliktipi[0]);
							miktar_uyelik.Add(uyeliktipi[1]);
							break;
						default:
							miktar_uyelik.Add(uyeliktipi[1]);
							miktar_uyelik.Add(uyeliktipi[2]);
							break;
					}
					break;
			}
		}


		double[] h_aralik_yamuk1 = { -4, 1.5, 2, 4 };
		double[] h_aralik_ucgen = { 3, 5, 7 };
		double[] h_aralik_yamuk2 = { 5.5, 8, 12.5, 14 };

		double[] m_aralik_yamuk1 = { -4, 1.5, 2, 4 };
		double[] m_aralik_ucgen = { 3, 5, 7 };
		double[] m_aralik_yamuk2 = { 5.5, 8, 12.5, 14 };

		double[] k_aralik_yamuk1 = { -4.5, -2.5, 2, 4.5 };
		double[] k_aralik_ucgen = { 3, 5, 7 };
		double[] k_aralik_yamuk2 = { 5.5, 8, 12.5, 15 };
		double mamdani;


		public double Mamdani_hesaplama_yap(string uyelik, double[] y1, double[] u, double[] y2, double girilen_deger)
		{
			mamdani = 0;

			switch (uyelik)
			{
				case "yamuk1":
					if (girilen_deger >= y1[0] && girilen_deger <= y1[1])
					{
						mamdani = (girilen_deger - y1[0]) / (y1[1] - y1[0]);
					}
					else if (girilen_deger >= y1[1] && girilen_deger <= y1[2])
					{
						mamdani = 1;
					}
					else if (girilen_deger >= y1[2] && girilen_deger <= y1[3])
					{
						mamdani = (y1[3] - girilen_deger) / (y1[3] - y1[2]);
					}
					else
						mamdani = 0;
					break;

				case "yamuk2":
					if (girilen_deger >= y2[0] && girilen_deger <= y2[1])
					{
						mamdani = (girilen_deger - y2[0]) / (y2[1] - y2[0]);
					}
					else if (girilen_deger >= y2[1] && girilen_deger <= y2[2])
					{
						mamdani = 1;
					}
					else if (girilen_deger >= y2[2] && girilen_deger <= y2[3])
					{
						mamdani = (y2[3] - girilen_deger) / (y2[3] - y2[2]);
					}
					else
						mamdani = 0;
					break;

				default: 
					if (girilen_deger >= u[0] && girilen_deger <= u[1])
					{
						mamdani = (girilen_deger - u[0]) / (u[1] - u[0]);
					}
					else if (girilen_deger >= u[1] && girilen_deger <= u[2])
					{
						mamdani = (u[2] - girilen_deger) / (u[2] - u[1]);
					}
					else
						mamdani = 0;
					break;
			}

			return mamdani;
		}

		double has_mamdani;
		double mik_mamdani;
		double kir_mamdani;
		public List<double> Mamdani_Degeri()
		{
			List<double> mamdani_sonuc = new List<double>();

			for (int h = 0; h < hassasiyet_uyelik.Count; h++)
			{
				for (int m = 0; m < miktar_uyelik.Count; m++)
				{
					for (int k = 0; k < kirlilik_uyelik.Count; k++)
					{
						has_mamdani = Mamdani_hesaplama_yap(hassasiyet_uyelik[h], h_aralik_yamuk1, h_aralik_ucgen, h_aralik_yamuk2, hassaslik);
						mik_mamdani = Mamdani_hesaplama_yap(miktar_uyelik[m], m_aralik_yamuk1, m_aralik_ucgen, m_aralik_yamuk2, miktar);
						kir_mamdani = Mamdani_hesaplama_yap(kirlilik_uyelik[k], k_aralik_yamuk1, k_aralik_ucgen, k_aralik_yamuk2, kirlilik);
						double[] dizi = { has_mamdani, mik_mamdani, kir_mamdani };
						double minDeger = dizi.Min();
						mamdani_sonuc.Add(minDeger);

					}
				}
			}
			return mamdani_sonuc;
		}

		List<int> numaralar = new List<int>();
		string[,] kural = Uzman.UzmanKurallari;
		Dictionary<int, double> KuralCiktilari = new Dictionary<int, double>();


		public Dictionary<int, double> BulunanNumaralar()
		{
			  numaralar.Clear();
			List<double> mamdani_sonuc = new List<double>();
			mamdani_sonuc = Mamdani_Degeri();

			for (int k = 0; k < hassaslik_deger.Count; k++)
			{
				for (int m = 0; m < miktar_deger.Count; m++)
				{
					for (int n = 0; n < kirlilik_deger.Count; n++)
					{
						for (int i = 0; i < 27; i++)
						{
							if (kural[i, 0] == hassaslik_deger[k] && kural[i, 1] == miktar_deger[m] && kural[i, 2] == kirlilik_deger[n])
							{
								numaralar.Add(i + 1);
								i++;
							}
						}
					}
				}
			}

			for (int x = 0; x < numaralar.Count(); x++)
			{
				KuralCiktilari.Add(numaralar[x], mamdani_sonuc[x]);
			}
			return KuralCiktilari;
		}

		double[] dh_hassas_aralik = { -5.8, -2.8, 0.5, 1.5 };
		double[] dh_normal_hassas_aralik = { 0.5, 2.75, 5 };
		double[] dh_orta_aralik = { 2.75, 5, 7.25 };
		double[] dh_normal_guclu_aralik = { 5, 7.25, 9.5 };
		double[] dh_guclu_aralik = { 8.5, 9.5, 12.8, 15.2 };

		double[] s_kisa_aralik = { -46.5, -25.28, 22.3, 39.9 };
		double[] s_normal_kisa_aralik = { 22.3, 39.9, 57.5 };
		double[] s_orta_aralik = { 39.9, 57.5, 75.1 };
		double[] s_normal_uzun_aralik = { 57.5, 75.1, 92.7 };
		double[] s_uzun_aralik = { 75, 92.7, 111.6, 130 };

		double[] dm_cok_az = { 0, 0, 20, 85 };
		double[] dm_az = {  20, 85, 150 };
		double[] dm_orta = { 85, 150,215 };
		double[] dm_fazla = { 150, 215,280 };
		double[] dm_cok_fazla = { 215, 280,300,300 };
		public double ağırlıklıOrtalamaDeterjan { get; set; }
		public double ağırlıklıOrtalamaSüre { get; set; }
		public double ağırlıklıOrtalamaDönüşHızı { get; set; }
		public void HesaplaMamdaniAğırlıklıOrtalama()
		{

			BulanikMantık bulanikMantik = new BulanikMantık(hassaslik, kirlilik, miktar);
			List<double> mamdaniSonuclar = bulanikMantik.Mamdani_Degeri();

			double ağırlıklıOrtalamaDeterjan = 0;
			double ağırlıklıOrtalamaSüre = 0;
			double ağırlıklıOrtalamaDönüşHızı = 0;
			double toplamAğırlık = 0;

			for (int i = 0; i < mamdaniSonuclar.Count; i++)
			{
				int kuralNumarası = i + 1;
				double mamdaniSonuc = mamdaniSonuclar[i];
				double deterjanMiktarı = DeterjanMiktarıHesapla(kuralNumarası);
				double süre = SüreHesapla(kuralNumarası);
				double dönüşHızı = DönüşHızıHesapla(kuralNumarası);

				this.ağırlıklıOrtalamaDeterjan += deterjanMiktarı * mamdaniSonuc;
				this.ağırlıklıOrtalamaSüre += süre * mamdaniSonuc;
				this.ağırlıklıOrtalamaDönüşHızı += dönüşHızı * mamdaniSonuc;


				toplamAğırlık += mamdaniSonuc;
			}

	
			
				ağırlıklıOrtalamaDeterjan /= toplamAğırlık;
				ağırlıklıOrtalamaSüre /= toplamAğırlık;
				ağırlıklıOrtalamaDönüşHızı /= toplamAğırlık;
			
			


		}

		private double DeterjanMiktarıHesapla(int kuralNumarası)
		{
			double miktar = 0.0;


			if (kuralNumarası == 1)
			{
				miktar = (dm_cok_az[2]+ dm_cok_az[1])/2;
			}
			else if (kuralNumarası == 2)
			{
				miktar = dm_az[1];
			}
			else if (kuralNumarası == 3)
			{
				miktar = dm_orta[1];
			}
			else if (kuralNumarası == 4)
			{
				miktar = dm_fazla[1];
			}
			else if (kuralNumarası == 5)
			{
				miktar = (dm_cok_fazla[2]+ dm_cok_fazla[1])/2;
			}

			return miktar;
		}

		private double SüreHesapla(int kuralNumarası)
		{
			double süre = 0.0;

			if (kuralNumarası == 1)
			{
				süre = (s_kisa_aralik[2] + s_kisa_aralik[1]) / 2;
			}
			else if (kuralNumarası == 2)
			{
				süre = s_normal_kisa_aralik[1];
			}
			else if (kuralNumarası == 3)
			{
				süre = s_orta_aralik[1];
			}
			else if (kuralNumarası == 4)
			{
				süre = s_normal_uzun_aralik[1];
			}
			else if (kuralNumarası == 5)
			{
				süre = (s_uzun_aralik[2] + s_uzun_aralik[1]) / 2;
			}

			return süre;
		}

		private double DönüşHızıHesapla(int kuralNumarası)
		{
			double dönüşHızı = 0.0;

			if (kuralNumarası == 1)
			{
				dönüşHızı = (dh_hassas_aralik[2] + dh_hassas_aralik[1]) / 2;
			}
			else if (kuralNumarası == 2)
			{
				dönüşHızı = dh_normal_hassas_aralik[1];
			}
			else if (kuralNumarası == 3)
			{
				dönüşHızı = dh_orta_aralik[1];
			}
			else if (kuralNumarası == 4)
			{
				dönüşHızı = dh_normal_guclu_aralik[1];
			}
			else if (kuralNumarası == 5)
			{
				dönüşHızı = (dh_guclu_aralik[2] + dh_guclu_aralik[1]) / 2;
			}

			return dönüşHızı;
		}

	}
}
