using System;

/*1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.*/

class EX01Class {

  public static void Main (string[] args) {
    int n1, n2;
    char oper;

    Console.Write("Digite o primeiro número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite a operação: ");
    oper = char.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    n2 = int.Parse(Console.ReadLine());

    int Total = CalcSimples(n1,n2,oper);
    Console.Write("Resultado: {0}",Total);
  }

  public static int CalcSimples(int n1,int n2, char oper){
    
    int resultado=0;

    switch (oper){
      case '+' :
        resultado = n1 + n2;
        break;
      case '-' :
        resultado = n1 - n2;
        break;
      case '*' :
        resultado = n1 * n2;
        break;
      case '/' :
        resultado = n1 / n2;
        break;

    }
    return resultado;
  }

}