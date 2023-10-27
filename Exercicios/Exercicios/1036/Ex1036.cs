/*
Regras:
A não pode ser = 0
Delta não pode ser 0
Delta não pode ser negativo
*/
using System;

class Ex1036
{
    public void Start()
    {
        double A,B,C,R1,R2,delta;
        string linha = Console.ReadLine();
        string[] numeros = linha.Split(' ');

        A = double.Parse(numeros[0]);
        B = double.Parse(numeros[1]);
        C = double.Parse(numeros[2]);

        delta = (Math.Pow(B,2))-4*A*C;

        if (delta == 0 || delta < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            R1 = (-B+(Math.Sqrt(delta)))/(2*A);
            R2 = (-B-(Math.Sqrt(delta)))/(2*A);

            Console.WriteLine("R1 = " + R1.ToString("N5"));
            Console.WriteLine("R2 = " + R2.ToString("N5"));
        }
    }
}
