using Classe_sub;

subtracao sub = new subtracao();
sub.setN1(70);
sub.setN2(40);
sub.setSub(sub.getN1() - sub.getN2());

Console.WriteLine(sub.getSub());
Console.ReadKey();

subtracao subtrai = new subtracao();
subtrai.setN1(50);
subtrai.setN2(30);
subtrai.setSub(subtrai.getN1() - subtrai.getN2());

Console.WriteLine(subtrai.getSub());
Console.ReadKey();
