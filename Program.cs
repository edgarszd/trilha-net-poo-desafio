using DesafioPOO.Models;

Nokia n1 = new Nokia("999999", "Tijolão", "1111111", 2);

n1.Ligar();
n1.InstalarAplicativo("Instagram");

Console.WriteLine();

Iphone i1 = new Iphone("888888", "Iphone 1", "2222222", 1);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");