using System;

class Ex1848
{
    public void Start()
    {
        //Controla se o programa vai continuar executando ou nao
        bool control = true;

        string codigo;
        int traducao;
        int caw = 0;

        int[] resultadoFinal = new int[1000];
        int index = 0;

        int resultado = 0;

        while (control)
        {
            codigo = Console.ReadLine();
            traducao = converter(codigo);
            if (traducao != 8 && traducao != 9)
            {
                resultado += traducao;
            }
            if (traducao == 8)
            {
                resultadoFinal[index] = resultado;
                index++;
                resultado = 0;
                caw += 1;
            }
            //caw caw do corvo
            if (caw >= 3)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(resultadoFinal[i]);
                }
                control = false;
            }
        }
    }

    //Tradutor
    static int converter(string codigo)
    {
        switch (codigo.ToLower())
        {
            case "---":
                return 0;
            case "--*":
                return 1;
            case "-*-":
                return 2;
            case "-**":
                return 3;
            case "*--":
                return 4;
            case "*-*":
                return 5;
            case "**-":
                return 6;
            case "***":
                return 7;
            case "caw caw":
                return 8;
            default:
                return 9;
        }
    }
}
