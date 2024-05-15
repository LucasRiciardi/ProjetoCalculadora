

namespace Calc;




public class Calculadora
{






    public static int SomarDoisNumeros(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int SubtrairDoisNumeros(int num1, int num2)
    {
        return num1 - num2;
    }


    public static int MultiplicarDoisNumeros(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int DividirDoisNumeros(int num1, int num2)
    {
        return num1 / num2;
    }

    public static void Main()
    {
        Console.WriteLine("5 + 7 = " + SomarDoisNumeros(5, 7));
        Console.WriteLine("20 - 7 = " + SubtrairDoisNumeros(20, 7));
        Console.WriteLine("5 * 7 = " + MultiplicarDoisNumeros(5, 7));
        Console.WriteLine("5 / 7 = " + DividirDoisNumeros(5, 7));
    }


}
