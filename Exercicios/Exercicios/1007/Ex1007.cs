using System;

class Ex1007
{
    public void Start()
    {
        int A,B,C,D,diferenca;

        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());

        diferenca = A*B-C*D;
        Console.WriteLine("DIFERENCA = " + diferenca);
    }
}