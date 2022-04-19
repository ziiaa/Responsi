using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemograman4382
{
	class Karyawan
	{
		public int Nik { get; set; }
		public string Nama { get; set; }
		public int Gaji { get; set; }
		public int GajiNaik { get; set; }



		public Karyawan(int NIK, string NAMA, int GajiBiasa)
		{
			Nik = NIK;
			Nama = NAMA;
			Gaji = GajiBiasa;
			GajiNaik = 10;

			if (GajiBiasa < 0)
			{
				Gaji = 0;
			}
		}

		public void getBonus()
		{
			int Bonus = Gaji / GajiNaik;
			Gaji = Gaji + Bonus;
			Console.WriteLine("{0}   {1} {2}", Nik, Nama, Gaji);
		}



		public void PrintAndShow()
		{
			Console.WriteLine("{0}  {1} {2}", Nik, Nama, Gaji);
		}




	}
}
