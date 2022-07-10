using System;

namespace AppEmpresa
{
    public struct Jubilei
    {
        string nome;
    }

    public class Program
    {

        public static void MenuPrinter(string nome)
        {
            Console.Clear();
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"               {nome}");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("1 - Adicionar funcionário");
            Console.WriteLine("2 - Visualizar funcionários");
            Console.WriteLine("3 - Folha de pagamento");
            Console.WriteLine("4 - Exibir Filtros");
            Console.WriteLine("5 - Sair");

        }

        public static int MenuOption()
        {
            int option;
            Console.WriteLine(new string('-', 50));
            Console.Write("Digite sua opção: ");
            option = TestadorNumeroInt();
            Console.WriteLine(new string('-', 50));

            return option;
        }

        public static int TestadorNumeroInt()
        {
            int valor = 0;
            do
            {
                try
                {
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERRO. Digite novamente.");
                }
            }
            while (valor < 0);

            return valor;
        }

        public static bool TestadorBool()
        {
            string opcao = "A";
            do
            {
                opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "N":
                        return false;
                        break;
                    case "S":
                        return true;
                        break;

                }
            }
            while (opcao != "N" || opcao != "S");
            return false;
        }

        public static double TestadorNumeroDouble()
        {
            double valor = 0;
            do
            {
                try
                {
                    valor = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERRO. Digite novamente seu putão.");
                }
            }

            while (valor <= 0);

            return valor;
        }

        public static void Main(string[] args)
        {
            Empresa talesRicardo = new Empresa("Tales Ricardo Company");
            int opcao;
            do
            {
                MenuPrinter(talesRicardo.NomeEmpresa);
                opcao = MenuOption();

                switch (opcao)
                {
                    case 1:
                        string type;

                        type = talesRicardo.typeAdicFuncionario();
                        switch (type)
                        {
                            case "1":
                                talesRicardo.CreateEngenheiro();
                                break;
                            case "2":
                                talesRicardo.CreateVendedor();
                                break;
                            case "3":
                                talesRicardo.CreateHorista();
                                break;
                        }
                        break;

                    case 2:
                        int sair;


                        do
                        {
                            foreach (Funcionario pessoa in talesRicardo.listaFuncionarios)
                            {
                                Console.WriteLine(pessoa);
                            }

                            Console.Write("Digite 0 para voltar: ");
                            sair = TestadorNumeroInt();
                        }

                        while (sair != 0);
                        break;

                    case 3:
                        do
                        {
                            talesRicardo.FolhaDePagamento();
                            Console.Write("Digite 0 para voltar: ");
                            sair = TestadorNumeroInt();
                        }

                        while (sair != 0);
                        break;

                    case 4:
                        do
                        {
                            talesRicardo.Filtro(talesRicardo.typeAdicFuncionario());
                            Console.Write("Digite 0 para voltar: ");
                            sair = TestadorNumeroInt();
                        }
                        while(sair != 0);   

                        break;
    }

            }
            while (opcao != 5);
        }
    }
}

