using System;

class Ex1009
{
    public void Start()
    {
        string nome;
        double salarioFixo,totalVendas, total;

        nome = Console.ReadLine();
        salarioFixo = Double.Parse(Console.ReadLine());
        totalVendas = Double.Parse(Console.ReadLine());
        total = salarioFixo + (totalVendas * 0.15);
        Console.WriteLine("TOTAL = R$ " + total.ToString("N2"));
    }
}
