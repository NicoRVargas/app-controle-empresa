using System;
using System.Collections.Generic;

namespace AppEmpresa
{
    public class Empresa
    {

        public Funcionario funcionario;

        public string NomeEmpresa { get; set; }

        public IList<Funcionario> listaFuncionarios;

        public Empresa(string nomeEmpresa)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.listaFuncionarios = new List<Funcionario>();
        }

        public string typeAdicFuncionario()
        {
            string option;

            Console.WriteLine("Escolha\n" +
                "\n1 - Engenheiro\n" +
                "2 - Vendedor\n" +
                "3 - Horista\n");
            Console.Write("Digite sua opção: ");
            option = Console.ReadLine();

            return option;
        }

        public void CreateEngenheiro()
        {
            string nome;
            string cpf;
            double salario;


            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write($"Digite o cpf de {nome}: ");
            cpf = Console.ReadLine();
            Console.Write($"Qual o salário de {nome}: ");
            salario = Convert.ToInt32(Console.ReadLine());

            Funcionario engenheiro = new Engenheiro(nome, cpf, salario);

            this.listaFuncionarios.Add(engenheiro);
        }
        public void CreateVendedor()
        {
            string nome;
            string cpf;
            double vendas;
            double taxa;


            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write($"Digite o cpf de {nome}: ");
            cpf = Console.ReadLine();
            Console.Write($"Qual o valor total de vendas que {nome} fez: ");
            vendas = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Qual a taxa sobre as vendas de {nome} (1-100): ");
            taxa = Convert.ToInt32(Console.ReadLine());

            Funcionario vendedor = new Vendedor(nome, cpf, vendas, taxa);

            this.listaFuncionarios.Add(vendedor);
        }
        public void CreateHorista()
        {
            string nome;
            string cpf;
            int qntHora;
            double valorHora;


            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write($"Digite o cpf de {nome}: ");
            cpf = Console.ReadLine();
            Console.Write($"Quantas horas {nome} trabalhou: ");
            qntHora = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Quanto vale a hora de {nome}: ");
            valorHora = Convert.ToInt32(Console.ReadLine());

            Funcionario horista = new Horista(nome, cpf, qntHora, valorHora);

            this.listaFuncionarios.Add(horista);
        }

        public void FolhaDePagamento()
        {
            double somaSalario = 0;

            Console.WriteLine($"Salários:");
            foreach (var salario in this.listaFuncionarios)
            {
                Console.WriteLine($"R${salario.calcSalario()}.");
                somaSalario += salario.calcSalario();
            }
            Console.WriteLine($"Total: R${somaSalario}.\n");
        }

        public void Filtro(string option)
        {
            switch (option)
            {
                case "1":

                    foreach(Funcionario funcionario in this.listaFuncionarios)
                    {

                        Type tipoFuncionario = funcionario.GetType();

                        if (tipoFuncionario.Equals(typeof(Engenheiro)))
                        {
                            Console.WriteLine($"\n{funcionario}");
                        }
                    }

                    break;

                case "2":
                    foreach (Funcionario funcionario in this.listaFuncionarios)
                    {

                        Type tipoFuncionario = funcionario.GetType();

                        if (tipoFuncionario.Equals(typeof(Vendedor)))
                        {
                            Console.WriteLine($"\n{funcionario}");
                        }
                    }

                    break;

                case "3":
                    foreach (Funcionario funcionario in this.listaFuncionarios)
                    {

                        Type tipoFuncionario = funcionario.GetType();

                        if (tipoFuncionario.Equals(typeof(Horista)))
                        {
                            Console.WriteLine($"\n{funcionario}");
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Opção Inválida.");
                        break;
                    }

            }
        }
    }
}
