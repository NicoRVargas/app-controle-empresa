using System;

namespace AppEmpresa
{
    public class Engenheiro : Funcionario
    {
        private double salario;

        public Engenheiro(string nome, string cpf, double salario)
        : base(nome, cpf)
        {
            this.salario = salario;
        }

        public override double calcSalario()
        {
            return this.salario;
        }

        public override string ToString()

        {
            return $"Função: Engenheiro\n{base.ToString()}";
        }
    }
}
