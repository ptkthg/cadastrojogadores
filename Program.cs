using System;

namespace DIO.Jogadores
{
    class Program
    {
        static bdjogadores repositorio = new bdjogadores();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco de Dados da FIFA.");
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListaJogadores();
                        break;
                    case "2":
                        InserirJogadores();
                        break;
                    case "3":
                        AtualizarJogadores();
                        break;
                    case "4":
                        ExcluirJogadores();
                        break;
                    case "5":
                        VisualizarJogadores();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        private static void ListaJogadores ()
        {
            Console.WriteLine("Listar jogadores:");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum jogador cadastrado.");
                return;
            }
            foreach (var jogador in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", jogador.retornaId(), jogador.retornaJogador());
            }
        }
        private static void InserirJogadores()
        {
            Console.WriteLine("Inserir novo jogador:");
            foreach (int i in Enum.GetValues (typeof(Sexo)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Sexo),i));
            }
        Console.WriteLine("Digite o sexo entre as opções acima: ");
        int entradaSexo = int.Parse(Console.ReadLine());

        Console.Write("Digite o time do Jogador:");
        string entradaTime = Console.ReadLine();
        
        Console.Write("Digite a Idade do Jogador:");
        int entradaIdade = int.Parse(Console.ReadLine());

        Console.Write("Digite a Nacionalidade do Jogador:");
        string entradaNacionalidade = Console.ReadLine();

        Jogadores novoJogador = new Jogador (id: repositorio.ProximoId(),
                                            sexo: (Sexo)entradaSexo,
                                            nome: entradaJogador,
                                            time: entradaTime,
                                            idade: entradaIdade,
                                            nacionalidade: entradaNacionalidade);
        repositorio.Insere(novoJogador);
        
    }
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("FIFA.COM");
        Console.WriteLine("Informe a opção desejada:");
        Console.WriteLine("1- Listar Jogadores");
        Console.WriteLine("2-Inserir novo Jogador");
        Console.WriteLine("3-Atualizar Jogadores");
        Console.WriteLine("4- Excluir Jogador");
        Console.WriteLine("5- Visualizar Jogador");
        Console.WriteLine("C- LIMPAR TELA");
        Console.WriteLine("X- SAIR");
        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
            return opcaoUsuario;
    }
  }
}
