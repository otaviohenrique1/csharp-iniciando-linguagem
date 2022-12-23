namespace HelloWorld;
using System;

class Program
{
  static void Main(string[] args)
  {
    int idade;
    idade = 28;
    Console.WriteLine(idade);

    string nome;
    nome = "Otavio";
    Console.WriteLine(nome);

    float salario1;
    salario1 = 2000;
    Console.WriteLine(salario1);

    double salario2;
    salario2 = 2800.99;
    Console.WriteLine(salario2);

    bool dirigirCarro;
    dirigirCarro = true;
    Console.WriteLine(dirigirCarro);

    long loteria;
    loteria = 2000000000000000;
    Console.WriteLine(loteria);

    short salario3;
    salario3 = 10000;
    Console.WriteLine(salario3);

    decimal salario4;
    salario4 = 10000.2222m;
    Console.WriteLine(salario4);

    char letra1;
    letra1 = 'a';
    Console.WriteLine(letra1);

    char letra2;
    letra2 = (char)65; /* 65 => Codigo do caractere 'A' da tabela ASCII */
    Console.WriteLine(letra2);

    string texto1;
    texto1 = "salario2 => " + salario2;
    Console.WriteLine(texto1);

    string texto2;
    texto2 = @"Lista cursos:
      - Java
      - Javascript
      - C#
      - Dart
      - Typescript
      - PHP";
    Console.WriteLine(texto2);

    Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

    int idade2 = 30;
    int idadeAna = idade2;

    Console.WriteLine(idadeAna);

    idade2 = 25;

    Console.WriteLine("Tecle enter para fechar ...");
    Console.ReadLine();

    /*
      short => 16bits
      float => 32bits
      double => 64bits
      long => 64bits
    */

    /* double x1 = 1.01d;
    double x2 = 1.01;
    float y1 = 1.01f;
    float y2 = 1;
    int k1 = (int)x1;
    int k2 = (int)y1;
    float j1 = (float)x1;
    float j2 = (float)x2;
    Console.WriteLine(x1);
    Console.WriteLine(x2);
    Console.WriteLine(y1);
    Console.WriteLine(y2);
    Console.WriteLine(k1);
    Console.WriteLine(k2);
    Console.WriteLine(j1);
    Console.WriteLine(j2); */
  }
}

// Comentario de uma linha
/*
  Comentario
  de
  varias
  linhas
*/