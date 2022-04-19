using System;

namespace ResponsiPemograman4382
{
	public class Program
	{
		static void Main(String[] args)
		{
			Console.WriteLine("NIK \t\t\t Nama \t\t  Gaji");
			Console.WriteLine("-------------------------------------------------------------");

			Karyawan karyawan1 = new Karyawan(20111200,"\t\tNur\t\t", 4000000);
			Karyawan karyawan2 = new Karyawan(20192736, "\t\tAzzizah\t\t", 200000);


			karyawan1.PrintAndShow();
			karyawan2.PrintAndShow();

			Console.WriteLine("\n\n Assyyiiikkkk Kenaikan Gaji 10% !!");
			Console.WriteLine("NIK \t\t\t Nama \t\t  Gaji");
			Console.WriteLine("-------------------------------------------------------------");


			karyawan1.getBonus();
			karyawan2.getBonus();


		}
	}
}
