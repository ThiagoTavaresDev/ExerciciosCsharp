//---- Métodos Simples de Manipulação de Strings e Coleções


// 1 - Substring (fácil): Extraia a palavra "mundo" de "Olá, mundo".
string ola = "Olá, mundo";
Console.WriteLine("1- " + ola.Substring(5));

//Replace (fácil): Substitua "gato" por "cão" na frase "O gato está na rua".
string replaced = "O gato está na rua";
Console.WriteLine("2- " +replaced.Replace("gato","cao"));

//ToUpper/ToLower (fácil): Converta "programação" para maiúsculas.
string programacao = "programacao";
Console.WriteLine(programacao.ToUpper());

//Trim (fácil): Remova os espaços extras ao redor da ‘string’" Olá ".
string trimteste = " Olá ";
Console.WriteLine(trimteste.Trim());

//Contains (fácil): Verifique se "abracadabra" contém "cada".

string containsTeste = "abacadabra";
Console.WriteLine(containsTeste.Contains("cada"));

//StartsWith/EndsWith (fácil): Verifique se "foto.jpg" termina com ".jpg".
string foto = "foto.jpg";

Console.WriteLine(foto.EndsWith(".jpg"));

//Split (fácil): Divida a frase "C#, Java, Python" numa lista de linguagens.

string linguagens = "C#, Java, Python";

string[] linguagensArray = linguagens.Split(',');


Console.WriteLine(linguagensArray);

//Join (fácil): Una as palavras ["C#", "é", "legal"] em uma única frase.

string[] palavrasUnidas = ["C#", "é", "legal"];

Console.WriteLine(string.Join(",",palavrasUnidas));

//IndexOf (fácil): Encontre a posição da primeira ocorrência de "a" em "banana".

string banana = "banana";

Console.WriteLine(banana.IndexOf('a'));

//Remove (fácil): Remova os últimos 3 caracteres da palavra "programação".

string palavraProgramacao = "programação";

Console.WriteLine(palavraProgramacao.Remove(8));

//Add (List<T>) (fácil): Adicione 5 números a uma lista de inteiros.

List<int> inteiros = new List<int>();

inteiros.Add(1);
inteiros.Add(2);
inteiros.Add(3);
inteiros.Add(4);
inteiros.Add(5);

Console.WriteLine(inteiros.Count);

//Remove (List<T>) (fácil): Remova o número 3 da lista [1, 2, 3, 4, 5].

List<int> removerItem3 = new List<int>([1, 2, 3, 4, 5]);
removerItem3.Remove(3);
Console.WriteLine(string.Join(",",removerItem3));

//Sort (fácil): Ordene a lista [5, 3, 8, 1] em ordem crescente.

List<int> sortedInteiros = new List<int>([5, 3, 8, 1]);
sortedInteiros.Sort();
Console.WriteLine(string.Join(",",sortedInteiros));

//Reverse (fácil): Inverta a ordem do array [1, 2, 3, 4].

int[] ints = [1, 2, 3, 4];

Console.WriteLine(string.Join(",",ints.Reverse()));

//Contains (List<T>) (fácil): Verifique se a lista de alunos contém "João".

List<string> listaAlunos = new List<string>(["Jessica","Karina","Thiago","João"]);

Console.WriteLine(listaAlunos.Contains("João") ? listaAlunos[listaAlunos.IndexOf("João")] : "Valor não encontrado");

//Clear (fácil): Limpe uma lista de nomes.

List<string> strings = new List<string>(["nome1","nome2","nome3"]);

strings.Clear();

Console.WriteLine(Convert.ToBoolean(strings.Count) ? "lista com itens" : "lista vazia");

//Find (fácil): Encontre o primeiro número maior que 5 na lista [2, 5, 8, 1].

List<int> listaInteiros = [2, 5, 8, 1];

Console.WriteLine(listaInteiros.Find(valor => valor.Equals(5)));

//BinarySearch (fácil): Faça uma busca binária no array [1, 2, 3, 4, 5].

List<int> inteirosArray = [1, 2, 3, 4, 5];

Console.WriteLine(inteirosArray.BinarySearch(3));

//Count (fácil): Conte quantos elementos estão na lista de nomes.

var nomes = new List<string>(["jose","maria"]);

Console.WriteLine(nomes.Count);

//Distinct (fácil): Remova os números duplicados da lista [1, 2, 2, 3, 3, 4].

List<int> inteirosDuplicados = [1, 2, 2, 3, 3, 4];

Console.WriteLine(string.Join("",inteirosDuplicados.Distinct()));

//DateTime.Now (fácil): Exiba a data e hora atuais.

DateTime data = DateTime.Now;

Console.WriteLine(data);

//AddDays (fácil): Adicione 7 dias à data de hoje.

Console.WriteLine(data.AddDays(7));

//AddMonths (fácil): Calcule a data exata daqui a 3 meses.

Console.WriteLine(data.AddMonths(3));

//AddYears (fácil): Veja que data será daqui a 10 anos.

Console.WriteLine(data.AddYears(10));

//DayOfWeek (fácil): Mostre o dia da semana de uma data específica.

Console.WriteLine(data.DayOfWeek);

//ToString (DateTime) (fácil): Formate uma data no estilo "dd/MM/yyyy".

Console.WriteLine(data.ToString("dd/MM/yyyy"));

//CompareTo (fácil): Compare duas datas para verificar qual é mais recente.

var data2 = DateTime.Now.AddDays(7);

Console.WriteLine(data2.CompareTo(data));

//Subtract (fácil): Calcule quantos dias faltam até o fim do ano.

DateTime ultimoDiaDoAno = new DateTime(data.Year, 12, 31);

Console.WriteLine(ultimoDiaDoAno.Subtract(data));

//IsLeapYear (fácil): Verifique se o ano 2024 é bissexto.


Console.WriteLine(DateTime.IsLeapYear(2024));

//Parse (fácil): Converta a string "12/10/2024" em um objeto DateTime.

string datada = "12/10/2024";

Console.WriteLine(DateTime.Parse(datada));

//Math.Abs (fácil): Calcule o valor absoluto de -42.

int valorABS = -42;

Console.WriteLine(Math.Abs(valorABS));

//Math.Round (fácil): Arredonde 3.14159 para duas casas decimais.

Console.WriteLine(Math.Round(3.14159,2));

//Math.Max (fácil): Encontre o maior número entre 5 e 9.

Console.WriteLine(Math.Max(5,9));

//Math.Min (fácil): Encontre o menor número entre 10 e 7.

Console.WriteLine(Math.Min(10,7));

//Math.Pow (fácil): Calcule 2 elevado a 5.

Console.WriteLine(Math.Pow(2,5));

//Math.Sqrt (fácil): Encontre a raiz quadrada de 49.

Console.WriteLine(Math.Sqrt(49));

//Math.Ceiling (fácil): Arredonde 5.1 para cima.

Console.WriteLine(Math.Ceiling(5.1));

//Math.Floor (fácil): Arredonde 7.9 para baixo.

Console.WriteLine(Math.Floor(7.9));

//Math.Sign (fácil): Verifique se o número -3 é negativo ou positivo.

Console.WriteLine(Math.Sign(-3));

//Math.Truncate (fácil): Remova a parte decimal de 3.999.

Console.WriteLine(Math.Truncate(3.999));

//File.ReadAllText (fácil): Leia o conteúdo de um arquivo .txt.

string caminho = "C:\\Users\\Thzin\\Desktop\\leia-me.txt";

Console.WriteLine(File.ReadAllText(caminho));

//File.WriteAllText (fácil): Salve uma string em um arquivo .txt.

File.WriteAllText("C:\\Users\\Thzin\\Desktop\\texto.txt", "by th");

//File.AppendAllText (fácil): Adicione mais texto ao final de um arquivo.

File.AppendAllText(caminho, "Opa, escrito com append");

//File.Exists (fácil): Verifique se o arquivo "dados.txt" existe.

File.Exists("dados.txt");

//Directory.CreateDirectory (fácil): Crie uma pasta chamada "Backup".

Directory.CreateDirectory("C:\\Users\\Thzin\\Desktop\\Backup");

//Path.Combine (fácil): Combine os caminhos "C:\" e "Backup".

Path.Combine("C:\\","Backup");

//Path.GetExtension (fácil): Obtenha a extensão do arquivo "foto.png".

Path.GetExtension("foto.png");

//Console.ReadLine (fácil): Leia o nome do usuário pelo console.
Console.WriteLine("Digite seu nome");
Console.ReadLine();

//Console.WriteLine (fácil): Exiba "Olá, Mundo!" no console.

Console.WriteLine("Olá mundo!");




//Nível Intermediário/Avançado (51-100):
//Manipulação Avançada de Coleções e Funções Lambda




//LINQ Select (intermediário): Multiplique cada número de uma lista por 2 usando LINQ.

List<int> numerosLinq = new List<int>([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15]);

Console.WriteLine(string.Join(",",numerosLinq.Select(i => i * 2)));
//Dica: Use uma expressão lambda com Select.

//LINQ Where (intermediário): Filtre os números pares de uma lista.

List<int> numerosWhere = new List<int>([1,2,3,4,4,4,5,6,7,8,9,10,11,12,13,14,15]);

Console.WriteLine(string.Join(",",numerosWhere.Where(i => i % 2 == 0)));
//Dica: Combine Where e % para verificar a paridade.

//GroupBy (intermediário): Agrupe uma lista de pessoas por sua cidade.


List<string> pessoas = new List<string>
{
    "João", "São Paulo",
    "Maria", "Rio de Janeiro",
    "Pedro", "São Paulo",
    "Ana", "Rio de Janeiro",
    "Lucas", "Curitiba"
};

var pares = new List<(string Nome, string Cidade)>();

for (int i = 0; i < pessoas.Count; i += 2)
{
    string nome = pessoas[i];
    string cidade = pessoas[i + 1];
    pares.Add((nome, cidade));
}

// Agrupando as pessoas pela cidade
var pessoasPorCidade = pares.GroupBy(p => p.Cidade);

foreach (var grupo in pessoasPorCidade)
{
    Console.WriteLine($"Cidade: {grupo.Key}");
    foreach (var pessoa in grupo)
    {
        Console.WriteLine($"- {pessoa.Nome}");
    }
}
//OrderBy (intermediário): Ordene uma lista de nomes em ordem alfabética.

List<string> nomezitos = new List<string>(["joao","ana","pedro","jose","thiago","maria","naldo"]);

nomezitos.OrderBy(n => n).ToList();

foreach (var nome in nomezitos)
{
    Console.WriteLine(nome);
}

//Take (intermediário): Pegue os primeiros 5 números de uma lista.

List<int> primeirosNumeros = new List<int>([1,2,3,4,5,6,7,8,9,5,10,12,111]);

Console.WriteLine(string.Join(",",primeirosNumeros.Take(5)));

//Skip (intermediário): Pule os primeiros 3 números de uma lista.

Console.WriteLine(string.Join(",",primeirosNumeros.Skip(3)));

//Any (intermediário): Verifique se há algum número maior que 10 em uma lista.

Console.WriteLine(primeirosNumeros.Any(n => n > 10));

//All (intermediário): Verifique se todos os números de uma lista são positivos.

Console.WriteLine(primeirosNumeros.All(n => n > 0));

//Aggregate (intermediário): Use Aggregate para calcular o produto de uma lista de inteiros.

Console.WriteLine(primeirosNumeros.Aggregate(1,(acumulador,n) => acumulador * n));

//Sum (intermediário): Calcule a soma de uma lista de números usando LINQ.

Console.WriteLine(primeirosNumeros.Sum());

//FirstOrDefault (intermediário): Retorne o primeiro número maior que 5 ou o padrão, se não houver.

Console.WriteLine(primeirosNumeros.FirstOrDefault(i => i > 5));

//LastOrDefault (intermediário): Retorne o último número em uma lista ou o padrão, se a lista estiver vazia.



//LINQ Join (avançado): Faça um join de duas listas baseadas em um campo comum.
//SelectMany (avançado): Use SelectMany para achatar uma lista de listas.
//DistinctBy (avançado): Encontre valores únicos com base em uma propriedade de objeto.
//LINQ Union (avançado): Combine duas listas de forma que os elementos não se repitam.
//LINQ Intersect (avançado): Encontre elementos comuns entre duas listas.
//LINQ Except (avançado): Encontre os elementos de uma lista que não estão presentes em outra.
//Zip (avançado): Combine duas listas em uma única lista de tuplas.
//Reverse com LINQ (avançado): Inverta a ordem de uma lista com LINQ.
//AsParallel (avançado): Execute uma operação paralela em uma lista.
//PLINQ (avançado): Implemente uma consulta paralela para melhorar a performance.
//Task.Run (avançado): Execute uma operação de forma assíncrona com Task.
//async/await (avançado): Faça uma chamada de API simulada usando async/await.
//CancellationToken (avançado): Cancele uma tarefa assíncrona em execução.
//Thread.Sleep (intermediário): Faça um delay na execução de 5 segundos.
//Semaphore (avançado): Controle o acesso concorrente a um recurso.
//Parallel.ForEach (avançado): Implemente um loop paralelo para melhorar a performance.
//MemoryCache (avançado): Implemente cache de dados em memória.
//Lazy<T> (avançado): Use inicialização tardia para otimizar a criação de objetos.
//Dictionary<TKey, TValue> (intermediário): Mapeie nomes de alunos para suas notas.



