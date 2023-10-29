using System;
namespace CalculadoraBasica{
class Calculadora{
static void Main(String[] args){

double num1, num2, resultado;
string tmp; //tmp: temporário

Console.WriteLine("digite um número: ");
tmp = Console.ReadLine();
num1 = int.Parse(tmp);

Console.WriteLine("digite outro número: ");
tmp = Console.ReadLine();
num2 = int.Parse(tmp);

resultado = num1+num2;
Console.WriteLine("soma: "+ resultado);

resultado = num1-num2;
Console.WriteLine("subtração: "+ resultado);

resultado = num1*num2;
Console.WriteLine("multiplicação: "+ resultado);

resultado = num1/num2;
Console.WriteLine("divisão: "+ resultado);
}
}
} 