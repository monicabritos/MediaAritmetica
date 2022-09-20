decimal nota1, nota2, nota3, media;

Console.WriteLine("Média Aritmética de 3 números\n");

Console.Write("Digite o primeiro número..: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o segundo número...: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o terceiro número..: ");
nota3 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"\nMédia: {media:N1}");