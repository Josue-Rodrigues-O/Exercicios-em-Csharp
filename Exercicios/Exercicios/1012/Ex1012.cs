using System;

class Ex1012
{
    public void Start()
    {
        double A,B,C,triangulo,circulo,trapezio,quadrado,retangulo;
        const double pi = 3.14159;
        string linha;

        linha = Console.ReadLine();
        string[] numeros = linha.Split(' ');
        A = Convert.ToDouble(numeros[0]);
        B = Convert.ToDouble(numeros[1]);
        C = Convert.ToDouble(numeros[2]);
        //Triangulo
        triangulo = (A*C)/2;

        //Circulo
        circulo = (Math.Pow(C,2))*pi;

        //Trapezio
        trapezio = ((A+B)*C)/2;

        //Quadrado
        quadrado = B*B;

        //Retangulo
        retangulo = A*B;

        Console.WriteLine("TRIANGULO = {0}",triangulo.ToString("N3"));
        Console.WriteLine("CIRCULO = {0}",circulo.ToString("N3"));
        Console.WriteLine("TRAPEZIO = {0}",trapezio.ToString("N3"));
        Console.WriteLine("QUADRADO = {0}",quadrado.ToString("N3"));
        Console.WriteLine("RETANGULO = {0}",retangulo.ToString("N3"));

    }
}
