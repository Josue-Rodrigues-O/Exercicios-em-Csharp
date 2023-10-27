using System;
using System.Globalization;

public class Program
{
	static void Main(string[] args)
	{
		CultureInfo.CurrentCulture = new CultureInfo("en-US");
		bool control = true;
		int decisao;

		Ex1007 ex1007 = new Ex1007();
		Ex1009 ex1009 = new Ex1009();
		Ex1012 ex1012 = new Ex1012();
		Ex1036 ex1036 = new Ex1036();
		Ex1043 ex1043 = new Ex1043();
		Ex1050 ex1050 = new Ex1050();
		Ex1848 ex1848 = new Ex1848();

		while (control)
		{
			Console.WriteLine("========================================================================");
			Console.WriteLine("Escolha qual progama voce quer rodar:\n1007\n1009\n1012\n1036\n1043\n1050\n1848\n0 para fechar\n");
			decisao = Convert.ToInt32(Console.ReadLine());

			switch (decisao)
			{
				case 1007: ex1007.Start(); break;
				case 1009: ex1009.Start(); break;
				case 1012: ex1012.Start(); break;
				case 1036: ex1036.Start(); break;
				case 1043: ex1043.Start(); break;
				case 1050: ex1050.Start(); break;
				case 1848: ex1848.Start(); break;
				case 0: control = false; break;
				default: Console.WriteLine("Digite novamente..."); break;
			}

		}
	}
}
