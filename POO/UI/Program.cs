// Avaliacao avaliacao = new Avaliacao("Carla Silva");
// avaliacao.AtribuirNota(11);   // inválido
// avaliacao.AtribuirNota(8.5);  // válido

// Paciente paciente = new Paciente("Luiz Costa", 42);
// HistoricoMedico historico = new HistoricoMedico("XPT-9987");
// historico.ExibirCodigo();

// Projeto projeto = new Projeto("Sistema de Inventário");
// projeto.AdicionarTarefa("Criar tela de login");
// projeto.AdicionarTarefa("Implementar banco de dados");
// projeto.ExibirTarefas();

// ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso," +
//                             " perfeito para produtividade diária.",
//                             80.00m, "Imagem");

// Console.WriteLine($"Dados do item 1:\nNome: {item1.Nome}\nDescrição: {item1.Descricao}\nPreço: {item1.Preco}\nEstoque: {item1.Estoque}\n");

// Console.WriteLine($"Imagem: {item1.Imagem}");
// item1.Imagem = "Nova Imagem";
// Console.WriteLine($"Imagem: {item1.Imagem}");

// ProdutoDigital item2 = new ProdutoDigital("Curso", "OO EM C#",
//                             100.00m,
//                             "Iamge ilustrativa", "Link");

// Console.WriteLine($"\nDados do item 2:\nNome: {item2.Nome}\nDescrição: {item2.Descricao}\nPreço: {item2.Preco}\nLink: {item2.LinkDownload}\n");

// Passageiro p1 = new Passageiro("Lúcia", 45, 3);
// Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

// p1.ExibirDados();
// p2.ExibirDados();

// Profissao analista = new Analista("Analista de Sistemas");
// Profissao docente = new Docente("Professor de Matemática");

// Certificado c1 = new Certificado(analista);
// Certificado c2 = new Certificado(docente);

// c1.Emitir();
// c2.Emitir();

// int contador = 10;
// while (contador >= 1)
// {
//     Console.WriteLine(contador);
//     contador--;
// }
// Console.WriteLine($"Contagem cabouu");

// int contador = 10;
// do
// {
//     Console.WriteLine(contador);
//     contador--;
// } while (contador >= 1);

// Console.WriteLine($"A contagem chegou ao fim");

// int totalDeVendas = 0;
// int soma;

// do
// {
//     Console.WriteLine($"Digite o valor da venda (ou 0 para encerrar): ");
//     soma = int.Parse(Console.ReadLine());
//     totalDeVendas += soma;
// } while (soma != 0);

// Console.WriteLine($"Total de vendas do dia: R${totalDeVendas}");

// RegistroDeVendas registro = new RegistroDeVendas();
// int valor;

// do
// {
//     Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
//     valor = int.Parse(Console.ReadLine());

//     if (valor != 0)
//     {
//         registro.AdicionarVenda(valor);
//     }

// } while (valor != 0);

// Console.WriteLine($"Total de vendas do dia: R${registro.ObterTotal()}");

// int contador = 10;
// while (contador >= 1)
// {
//     Console.WriteLine(contador);
//     contador--;
// }
// Console.WriteLine($"A contagem chegou ao fim.");

// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine($"A contagem chegou ao fim.");

// List<string> funcionarios = new List<string>
// {
//     "João-Gerente-8500",
//     "Maria-Analista de Sistemas-6200",
//     "Carlos-Desenvolvedor-5500",
//     "Ana-Designer-4800",
//     "Pedro-Suporte Técnico-3980",
//     "Fernanda-Coordenadora de Projetos-7300",
//     "Ricardo-Contador-6000",
//     "Juliana-RH-4500"
// };

// foreach (string funcionario in funcionarios)
// {
//     var nome = funcionario.Split("-")[0];
//     if (nome.Equals("Fernanda"))
//     {
//         Console.WriteLine($"Dados do funcionário buscado: {funcionario}");
//         break;
//     }
// }

// string nomeFormatado = "";

// for (int i = 0; i <= funcionarios.Count; i++)
// {
//     var nome = funcionarios[i].Split("-")[0];
//     if (nome.Equals("Fernanda"))
//     {
//         nomeFormatado = nome;
//         Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
//         Console.WriteLine($"Nome da funcionária encontrada: {nomeFormatado}");
//         break;
//     }
// }

// for (int i = 0; i < funcionarios.Count; i++)
// {
//     var salario = funcionarios[i].Split("-")[2];
//     var salarioInt = int.Parse(salario);
//     if (salarioInt > 5000)
//     {
//         continue;
//     }
//     Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
// }

// EXERCICIOS DE FIXAÇÃO
/* This code snippet is a C# program that defines an integer variable `limite` with a value of 20. It
then executes a `for` loop that iterates from 0 to the value of `limite`. */

// int limite = 20;

// for (int i = 0; i <= limite; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

// EX: Tabela de multiplicação

// int numero = 7;

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(numero + " x " + numero * i);
// }

// List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

// for (int i = 0; i < notas.Count; i++)
// {
//     if (notas[i] <= 5)
//     {
//         Console.WriteLine($"Nota {notas[i]} - Reprovado");
//     }
//     else
//     {
//         Console.WriteLine($"Nota {notas[i]} - Aprovado");
//     }
// }


// Random random = new Random();

// List<int> valores = new List<int>();

// for (int i = 0; i < 10; i++) // Gera 10 valores aleatórios
// {
//     valores.Add(random.Next(1, 101)); // Números entre 1 e 100
// }

// foreach (int numero in valores)
// {
//     Console.WriteLine(numero);
// }

// O laço certo para o problema

List<double> notas = new List<double>
        {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
        };

for (int i = 0; i < notas.Count; i++)
{
    if (notas[i] < 7)
    {
        Console.WriteLine($"O aluno com a nota {notas[i]} está abaixo da média!");
    }
    else
    {
        Console.WriteLine($"O aluno com a nota {notas[i]} está indo muito bem!");

    }
}

