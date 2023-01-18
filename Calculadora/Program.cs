namespace Calculadora
{
  class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que você deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtracao");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Selecione uma opcao:");
      short res = short.Parse(Console.ReadLine());
      switch (res)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 5:
          System.Environment.Exit(exitCode: 0);
          break;
        default:
          Menu();
          break;
      }
    }
    static void Soma()
    {
      Console.Clear();
      float v1;
      float v2;
      Console.WriteLine(value: "Primeiro valor");
      string valor1 = Console.ReadLine();

      if (valor1 != "" && valor1 != null)
      {
        v1 = float.Parse(s: valor1);
      }
      else { v1 = 0; }

      Console.WriteLine(value: "Segundo valor");
      string valor2 = Console.ReadLine();

      if (valor2 != "" && valor2 != null)
      {
        v2 = float.Parse(s: valor2);
      }
      else { v2 = 0; }


      float resultado = v1 + v2;
      Console.WriteLine("");
      Console.WriteLine($"O resultado da soma é {resultado}");
      Console.ReadKey();
      Menu();
    }
    static void Subtracao()
    {
      Console.Clear();
      float v1;
      float v2;
      Console.WriteLine(value: "Primeiro valor");
      string valor1 = Console.ReadLine();

      if (valor1 != "" && valor1 != null)
      {
        v1 = float.Parse(s: valor1);
      }
      else { v1 = 0; }

      Console.WriteLine(value: "Segundo valor");
      string valor2 = Console.ReadLine();

      if (valor2 != "" && valor2 != null)
      {
        v2 = float.Parse(s: valor2);
      }
      else { v2 = 0; }


      float resultado = v1 - v2;
      Console.WriteLine("");
      Console.WriteLine($"O resultado da subtracao é {resultado}");
      Console.ReadKey();
      Menu();
    }
    static void Divisao()
    {
      Console.Clear();
      float v1;
      float v2;
      Console.WriteLine(value: "Primeiro valor");
      string valor1 = Console.ReadLine();

      if (valor1 != "" && valor1 != null)
      {
        v1 = float.Parse(s: valor1);
      }
      else { v1 = 0; }

      Console.WriteLine(value: "Segundo valor");
      string valor2 = Console.ReadLine();

      if (valor2 != "" && valor2 != null)
      {
        v2 = float.Parse(s: valor2);
      }
      else { v2 = 0; }


      float resultado = v1 / v2;
      Console.WriteLine("");
      Console.WriteLine($"O resultado da divisao é {resultado}");
      Console.ReadKey();
      Menu();
    }
    static void Multiplicacao()
    {
      Console.Clear();
      float v1;
      float v2;
      Console.WriteLine(value: "Primeiro valor");
      string valor1 = Console.ReadLine();

      if (valor1 != "" && valor1 != null)
      {
        v1 = float.Parse(s: valor1);
      }
      else { v1 = 0; }

      Console.WriteLine(value: "Segundo valor");
      string valor2 = Console.ReadLine();

      if (valor2 != "" && valor2 != null)
      {
        v2 = float.Parse(s: valor2);
      }
      else { v2 = 0; }


      float resultado = v1 * v2;
      Console.WriteLine("");
      Console.WriteLine($"O resultado da multiplicacao é {resultado}");
      Console.ReadKey();
      Menu();
    }
  }
}

