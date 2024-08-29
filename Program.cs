Livro l1 = new Livro();

l1 titulo = "HP - E a criança amaldiçoada!";
l1 autor = "JK Rowling";
l1 paginas = 530;

l1.ExibirInformacoes();
bool v1 = l1.VerificarTrezentos();

Console.WriteLine($"Esse livro tem mais de 300 páginas? " + v1);


