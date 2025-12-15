using Classe;

Soma s = new Soma();
s.setN1(10);
s.setN2(5);

int numero1 = s.getN1();
int numero2 = s.getN2();
int resultado = s.somar();

Console.WriteLine("Primeiro número: " + numero1 + " Segundo número: " + numero2 + " Soma: " + resultado);
Console.ReadKey();