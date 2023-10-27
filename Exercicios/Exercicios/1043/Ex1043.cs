using System;

class Ex1043
{
    public void Start()
    {
        double a,b,c,resultado;
        string linha = Console.ReadLine();
        string[] numeros = linha.Split(' ');
        
        a = double.Parse(numeros[0]);
        b = double.Parse(numeros[1]);
        c = double.Parse(numeros[2]);

        if (
            Math.Abs(b - c) < a
            && a < b + c
            && Math.Abs(a - c) < b
            && b < a + c
            && Math.Abs(a - b) < c
            && c < a + b
        )
        {
            resultado = a + b + c;
            Console.WriteLine("Perimetro = " + resultado.ToString("N1"));
        }
        else
        {
            resultado = ((a + b) * c) / 2;
            Console.WriteLine("Area = " + resultado.ToString("N1"));
        }
    }
}
