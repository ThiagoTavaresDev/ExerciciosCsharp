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

//Trim (fácil): Remova os espaços extras ao redor da string " Olá ".
string trimteste = " Olá ";
Console.WriteLine(trimteste.Trim());

//Contains (fácil): Verifique se "abracadabra" contém "cada".

string containsTeste = "abacadabra";
Console.WriteLine(containsTeste.Contains("cada"));

//StartsWith/EndsWith (fácil): Verifique se "foto.jpg" termina com ".jpg".
string foto = "foto.jpg";

Console.WriteLine(foto.EndsWith(".jpg"));

//Split (fácil): Divida a frase "C#, Java, Python" em uma lista de linguagens.

string linguagens = "C#, Java, Python";

Console.WriteLine(linguagens.Split(','));

//Join (fácil): Una as palavras ["C#", "é", "legal"] em uma única frase.
//IndexOf (fácil): Encontre a posição da primeira ocorrência de "a" em "banana".
//Remove (fácil): Remova os últimos 3 caracteres da palavra "programação".
//Add (List<T>) (fácil): Adicione 5 números a uma lista de inteiros.
//Remove (List<T>) (fácil): Remova o número 3 da lista [1, 2, 3, 4, 5].
//Sort (fácil): Ordene a lista [5, 3, 8, 1] em ordem crescente.
//Reverse (fácil): Inverta a ordem do array [1, 2, 3, 4].
//Contains (List<T>) (fácil): Verifique se a lista de alunos contém "João".
//Clear (fácil): Limpe uma lista de nomes.
//Find (fácil): Encontre o primeiro número maior que 5 na lista [2, 5, 8, 1].
//BinarySearch (fácil): Faça uma busca binária no array [1, 2, 3, 4, 5].
//Count (fácil): Conte quantos elementos estão na lista de nomes.
//Distinct (fácil): Remova os números duplicados da lista [1, 2, 2, 3, 3, 4].
//DateTime.Now (fácil): Exiba a data e hora atuais.
//AddDays (fácil): Adicione 7 dias à data de hoje.
//AddMonths (fácil): Calcule a data exata daqui a 3 meses.
//AddYears (fácil): Veja que data será daqui a 10 anos.
//DayOfWeek (fácil): Mostre o dia da semana de uma data específica.
//ToString (DateTime) (fácil): Formate uma data no estilo "dd/MM/yyyy".
//CompareTo (fácil): Compare duas datas para verificar qual é mais recente.
//Subtract (fácil): Calcule quantos dias faltam até o fim do ano.
//IsLeapYear (fácil): Verifique se o ano 2024 é bissexto.
//Parse (fácil): Converta a string "12/10/2024" em um objeto DateTime.
//Math.Abs (fácil): Calcule o valor absoluto de -42.
//Math.Round (fácil): Arredonde 3.14159 para duas casas decimais.
//Math.Max (fácil): Encontre o maior número entre 5 e 9.
//Math.Min (fácil): Encontre o menor número entre 10 e 7.
//Math.Pow (fácil): Calcule 2 elevado a 5.
//Math.Sqrt (fácil): Encontre a raiz quadrada de 49.
//Math.Ceiling (fácil): Arredonde 5.1 para cima.
//Math.Floor (fácil): Arredonde 7.9 para baixo.
//Math.Sign (fácil): Verifique se o número -3 é negativo ou positivo.
//Math.Truncate (fácil): Remova a parte decimal de 3.999.
//File.ReadAllText (fácil): Leia o conteúdo de um arquivo .txt.
//File.WriteAllText (fácil): Salve uma string em um arquivo .txt.
//File.AppendAllText (fácil): Adicione mais texto ao final de um arquivo.
//File.Exists (fácil): Verifique se o arquivo "dados.txt" existe.
//Directory.CreateDirectory (fácil): Crie uma pasta chamada "Backup".
//Path.Combine (fácil): Combine os caminhos "C:\" e "Backup".
//Path.GetExtension (fácil): Obtenha a extensão do arquivo "foto.png".
//Console.ReadLine (fácil): Leia o nome do usuário pelo console.
//Console.WriteLine (fácil): Exiba "Olá, Mundo!" no console.
//Enum.Parse (fácil): Converta a string "Vermelho" para um valor de enumeração.
//Nível Intermediário/Avançado (51-100):
//Manipulação Avançada de Coleções e Funções Lambda
//LINQ Select (intermediário): Multiplique cada número de uma lista por 2 usando LINQ.
//Dica: Use uma expressão lambda com Select.
//LINQ Where (intermediário): Filtre os números pares de uma lista.
//Dica: Combine Where e % para verificar a paridade.
//GroupBy (intermediário): Agrupe uma lista de pessoas por sua cidade.
//OrderBy (intermediário): Ordene uma lista de nomes em ordem alfabética.
//Take (intermediário): Pegue os primeiros 5 números de uma lista.
//Skip (intermediário): Pule os primeiros 3 números de uma lista.
//Any (intermediário): Verifique se há algum número maior que 10 em uma lista.
//All (intermediário): Verifique se todos os números de uma lista são positivos.
//Aggregate (intermediário): Use Aggregate para calcular o produto de uma lista de inteiros.
//Sum (intermediário): Calcule a soma de uma lista de números usando LINQ.
//FirstOrDefault (intermediário): Retorne o primeiro número maior que 5 ou o padrão, se não houver.
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
//SortedList (intermediário): Use uma listaMétodos Simples de Manipulação de Strings e Coleções
//Substring (fácil): Extraia a palavra "mundo" de "Olá, mundo".
//Replace (fácil): Substitua "gato" por "cão" na frase "O gato está na rua".
//ToUpper/ToLower (fácil): Converta "programação" para maiúsculas.
//Trim (fácil): Remova os espaços extras ao redor da string " Olá ".
//Contains (fácil): Verifique se "abracadabra" contém "cada".
//StartsWith/EndsWith (fácil): Verifique se "foto.jpg" termina com ".jpg".
//Split (fácil): Divida a frase "C#, Java, Python" em uma lista de linguagens.
//Join (fácil): Una as palavras ["C#", "é", "legal"] em uma única frase.
//IndexOf (fácil): Encontre a posição da primeira ocorrência de "a" em "banana".
//Remove (fácil): Remova os últimos 3 caracteres da palavra "programação".
//Add (List<T>) (fácil): Adicione 5 números a uma lista de inteiros.
//Remove (List<T>) (fácil): Remova o número 3 da lista [1, 2, 3, 4, 5].
//Sort (fácil): Ordene a lista [5, 3, 8, 1] em ordem crescente.
//Reverse (fácil): Inverta a ordem do array [1, 2, 3, 4].
//Contains (List<T>) (fácil): Verifique se a lista de alunos contém "João".
//Clear (fácil): Limpe uma lista de nomes.
//Find (fácil): Encontre o primeiro número maior que 5 na lista [2, 5, 8, 1].
//BinarySearch (fácil): Faça uma busca binária no array [1, 2, 3, 4, 5].
//Count (fácil): Conte quantos elementos estão na lista de nomes.
//Distinct (fácil): Remova os números duplicados da lista [1, 2, 2, 3, 3, 4].
//DateTime.Now (fácil): Exiba a data e hora atuais.
//AddDays (fácil): Adicione 7 dias à data de hoje.
//AddMonths (fácil): Calcule a data exata daqui a 3 meses.
//AddYears (fácil): Veja que data será daqui a 10 anos.
//DayOfWeek (fácil): Mostre o dia da semana de uma data específica.
//ToString (DateTime) (fácil): Formate uma data no estilo "dd/MM/yyyy".
//CompareTo (fácil): Compare duas datas para verificar qual é mais recente.
//Subtract (fácil): Calcule quantos dias faltam até o fim do ano.
//IsLeapYear (fácil): Verifique se o ano 2024 é bissexto.
//Parse (fácil): Converta a string "12/10/2024" em um objeto DateTime.
//Math.Abs (fácil): Calcule o valor absoluto de -42.
//Math.Round (fácil): Arredonde 3.14159 para duas casas decimais.
//Math.Max (fácil): Encontre o maior número entre 5 e 9.
//Math.Min (fácil): Encontre o menor número entre 10 e 7.
//Math.Pow (fácil): Calcule 2 elevado a 5.
//Math.Sqrt (fácil): Encontre a raiz quadrada de 49.
//Math.Ceiling (fácil): Arredonde 5.1 para cima.
//Math.Floor (fácil): Arredonde 7.9 para baixo.
//Math.Sign (fácil): Verifique se o número -3 é negativo ou positivo.
//Math.Truncate (fácil): Remova a parte decimal de 3.999.
//File.ReadAllText (fácil): Leia o conteúdo de um arquivo .txt.
//File.WriteAllText (fácil): Salve uma string em um arquivo .txt.
//File.AppendAllText (fácil): Adicione mais texto ao final de um arquivo.
//File.Exists (fácil): Verifique se o arquivo "dados.txt" existe.
//Directory.CreateDirectory (fácil): Crie uma pasta chamada "Backup".
//Path.Combine (fácil): Combine os caminhos "C:\" e "Backup".
//Path.GetExtension (fácil): Obtenha a extensão do arquivo "foto.png".
//Console.ReadLine (fácil): Leia o nome do usuário pelo console.
//Console.WriteLine (fácil): Exiba "Olá, Mundo!" no console.
//Enum.Parse (fácil): Converta a string "Vermelho" para um valor de enumeração.
//Nível Intermediário/Avançado (51-100):
//Manipulação Avançada de Coleções e Funções Lambda
//LINQ Select (intermediário): Multiplique cada número de uma lista por 2 usando LINQ.
//Dica: Use uma expressão lambda com Select.
//LINQ Where (intermediário): Filtre os números pares de uma lista.
//Dica: Combine Where e % para verificar a paridade.
//GroupBy (intermediário): Agrupe uma lista de pessoas por sua cidade.
//OrderBy (intermediário): Ordene uma lista de nomes em ordem alfabética.
//Take (intermediário): Pegue os primeiros 5 números de uma lista.
//Skip (intermediário): Pule os primeiros 3 números de uma lista.
//Any (intermediário): Verifique se há algum número maior que 10 em uma lista.
//All (intermediário): Verifique se todos os números de uma lista são positivos.
//Aggregate (intermediário): Use Aggregate para calcular o produto de uma lista de inteiros.
//Sum (intermediário): Calcule a soma de uma lista de números usando LINQ.
//FirstOrDefault (intermediário): Retorne o primeiro número maior que 5 ou o padrão, se não houver.
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
//SortedList (intermediário): Use uma lista