Console.WriteLine("Exercício 1 ");

float m, cm, mm;

Console.WriteLine("Coloque alguma medida em metros");
m = float.Parse(Console.ReadLine());
cm = (m * 100);
Console.WriteLine("O total de centímetros é {0}", cm);
mm = (m * 1000);
Console.WriteLine("já o total em milímetros é {0}", mm);

Console.WriteLine("Exercício 2");

float gr, fah;

Console.WriteLine("Digite qualquer quantia de Grau Fahrenheit");
fah = int.Parse(Console.ReadLine());
gr = ((fah - 32) * (5.0f / 9.0f));
Console.WriteLine("Em fahrenheit {0}", gr);

Console.WriteLine("Exercício 3");

float imc, pe, alt;

Console.WriteLine("Informe seu peso");
pe = float.Parse(Console.ReadLine());
Console.WriteLine("Informe sua altura");
alt = float.Parse(Console.ReadLine());
imc = (pe /(alt * alt));
Console.WriteLine("Seu IMC é de {0}", imc);

Console.WriteLine("Exercício 4");

int n1, n2, n3, med;

Console.WriteLine("Dê o primeiro valor");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dê o segundo valor");
n2= int.Parse(Console.ReadLine());
Console.WriteLine("Dê o terceiro valor");
n3 = int.Parse(Console.ReadLine());
med = ((n1 + n2 + n3) / 4);
Console.WriteLine("A média total é de {0}", med);

Console.WriteLine("Exercício 6 ");

float sal;


Console.WriteLine("Coloque seu salário: ");
sal = float.Parse(Console.ReadLine());
sal = sal + (25.0f / 100.0f) * sal;
Console.WriteLine("O novo salário é de {0}", sal);

Console.WriteLine("Exercício 8 {0}");

int n1, n2;

Console.WriteLine("Digite um número");
n1 = int.Parse(Console.ReadLine());
n2 = (n1 * 3 + 1) + (n1 * 2 - 1);
Console.WriteLine(n2);

Console.WriteLine("Exercício 3");