// modos de criar e Ler uma Tupla

// Forma 1

var tupla1 = new Tuple<string, int>("Feliz Natal", 2022);
Console.WriteLine(tupla1);
Console.WriteLine();

// Forma 2
var tupla2 = Tuple.Create<string, int>("Feliz Natal", 2022);
Console.WriteLine(tupla2);
Console.WriteLine();

//Forma 3 => Inferindo tipos
(string, int) tupla3 = ("Feliz Natal", 2022);
Console.WriteLine(tupla3.Item1);
Console.WriteLine(tupla3.Item2);
Console.WriteLine();

//Nomeando itens da tupla
(string mensagem, int ano) tupla4 = ("Feliz Natal", 2022);
Console.WriteLine(tupla4.mensagem);
Console.WriteLine(tupla4.ano);
Console.WriteLine();

//Tuplas em Métodos
Metodos.MonteSeuNome(("Francisco", "Lucas"));
Console.WriteLine();

//Desconstrutor

(int idade, string nome, string email) informacoes = Desconstrutor.ObterInformacoesDoUsuario(10);
Console.WriteLine(informacoes.idade);
Console.WriteLine(informacoes.nome);
Console.WriteLine(informacoes.email);







