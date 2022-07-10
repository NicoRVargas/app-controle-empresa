using System;
using System.Collections.Generic;

namespace AppEmpresa
{
    public abstract class Funcionario
    {
        public string Cpf { get; }
        public string Nome { get; set; }

        public Funcionario(string nome, string cpf)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }

        public abstract double calcSalario();
        public override string ToString()
        {
            return $"Funcionário: {this.Nome}\nCpf: {this.Cpf}\nSalário: {this.calcSalario()}\n";
        }
    }
}
