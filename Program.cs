// See https://aka.ms/new-console-template for more information

HashSet<int> ints = new HashSet<int>();

for (int letra = 0; letra < 3; letra++) {

	Console.Write($"Quais os Estudantes do Curso {letra+1} ? ");
	int na = int.Parse(Console.ReadLine());
	for (int i = 0; i < na; i++) {
		int matr = int.Parse(Console.ReadLine());
		ints.Add(matr);
	}
}
Console.WriteLine();
Console.Write("Total de Estudantes : " + ints.Count);
