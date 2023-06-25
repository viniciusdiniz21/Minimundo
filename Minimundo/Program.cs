using Minimundo;


class Program
{
    static void Main(string[] args)
    {
        SistemaEmpresa sistema = new SistemaEmpresa();

        bool executar = true;
        while (executar)
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Adicionar Departamento");
            Console.WriteLine("2. Adicionar Empregado");
            Console.WriteLine("3. Adicionar Projeto a um Departamento");
            Console.WriteLine("4. Alocar Empregado a um Projeto");
            Console.WriteLine("5. Sair");
            Console.WriteLine();

            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarDepartamento(sistema);
                    break;
                case "2":
                    AdicionarEmpregado(sistema);
                    break;
                case "3":
                    AdicionarProjetoADepartamento(sistema);
                    break;
                case "4":
                    AlocarEmpregadoAProjeto(sistema);
                    break;
                case "5":
                    executar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, digite uma opção válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AdicionarDepartamento(SistemaEmpresa sistema)
    {
        Console.WriteLine("=== Adicionar Departamento ===");
        Console.Write("Digite o nome do departamento: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o número do departamento: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do gerente do departamento: ");
        string nomeGerente = Console.ReadLine();
        Console.Write("Digite a data de início da gerência do departamento (dd/mm/aaaa): ");
        DateTime dataInicioGerencia = DateTime.Parse(Console.ReadLine());

        Empregado gerente = sistema.Empregados.FirstOrDefault(e => e.Nome == nomeGerente);

        if (gerente == null)
        {
            Console.WriteLine("Erro: O gerente informado não existe.");
            return;
        }

        Departamento departamento = new DepartamentoEspecifico(nome, numero, gerente, dataInicioGerencia);
        sistema.AdicionarDepartamento(departamento);

        Console.WriteLine("Departamento adicionado com sucesso.");
    }

    static void AdicionarEmpregado(SistemaEmpresa sistema)
    {
        Console.WriteLine("=== Adicionar Empregado ===");
        Console.Write("Digite o nome do empregado: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o salário do empregado: ");
        double salario = double.Parse(Console.ReadLine());
        Console.Write("Digite a escolaridade do empregado: ");
        string escolaridade = Console.ReadLine();
        Console.Write("Digite a data de nascimento do empregado: ");
        string dataNascimento = Console.ReadLine();
        Console.Write("Digite o cargo do empregado: ");
        string cargo = Console.ReadLine();

        Empregado empregado = new Empregado(nome, dataNascimento, salario, escolaridade, cargo);
        sistema.AdicionarEmpregado(empregado);

        Console.WriteLine("Empregado adicionado com sucesso.");
    }

    static void AdicionarProjetoADepartamento(SistemaEmpresa sistema)
    {
        Console.WriteLine("=== Adicionar Projeto a um Departamento ===");
        Console.Write("Digite o número do departamento: ");
        int numeroDepartamento = int.Parse(Console.ReadLine());

        Departamento departamento = sistema.Departamentos.FirstOrDefault(d => d.Numero == numeroDepartamento);

        if (departamento == null)
        {
            Console.WriteLine("Erro: O departamento informado não existe.");
            return;
        }

        Console.Write("Digite o nome do projeto: ");
        string nomeProjeto = Console.ReadLine();
        Console.Write("Digite o código do projeto: ");
        int codigoProjeto = int.Parse(Console.ReadLine());
        Console.Write("Digite a rua da localização do projeto: ");
        string ruaProjeto = Console.ReadLine();
        Console.Write("Digite o bairro da localização do projeto: ");
        string bairroProjeto = Console.ReadLine();
        Console.Write("Digite a cidade da localização do projeto: ");
        string cidadeProjeto = Console.ReadLine();

        Localizacao localizacaoProjeto = new Localizacao(ruaProjeto, bairroProjeto, cidadeProjeto);
        Projeto projeto = new Projeto(nomeProjeto, codigoProjeto, localizacaoProjeto);
        departamento.AdicionarProjeto(projeto);

        Console.WriteLine("Projeto adicionado ao departamento com sucesso.");
    }

    static void AlocarEmpregadoAProjeto(SistemaEmpresa sistema)
    {
        Console.WriteLine("=== Alocar Empregado a um Projeto ===");
        Console.Write("Digite o número do departamento: ");
        int numeroDepartamento = int.Parse(Console.ReadLine());

        Departamento departamento = sistema.Departamentos.FirstOrDefault(d => d.Numero == numeroDepartamento);

        if (departamento == null)
        {
            Console.WriteLine("Erro: O departamento informado não existe.");
            return;
        }

        Console.Write("Digite o código do projeto: ");
        int codigoProjeto = int.Parse(Console.ReadLine());

        Projeto projeto = departamento.Projetos.FirstOrDefault(p => p.Codigo == codigoProjeto);

        if (projeto == null)
        {
            Console.WriteLine("Erro: O projeto informado não existe.");
            return;
        }

        Console.Write("Digite o nome do empregado: ");
        string nomeEmpregado = Console.ReadLine();

        Empregado empregado = sistema.Empregados.FirstOrDefault(e => e.Nome == nomeEmpregado);

        if (empregado == null)
        {
            Console.WriteLine("Erro: O empregado informado não existe.");
            return;
        }

        Console.Write("Digite a quantidade de horas que o empregado trabalha no projeto: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        projeto.AdicionarFuncionario(empregado, horasTrabalhadas);

        Console.WriteLine("Empregado alocado ao projeto com sucesso.");
    }
}