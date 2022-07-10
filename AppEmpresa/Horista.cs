using System;

namespace AppEmpresa
{
    public class Horista : Funcionario
    {
        private int qntHora;
        private double valorHora;

        public Horista(string nome, string cpf, int qntHora, double valorHora)
        : base(nome, cpf)
        {
            this.qntHora = qntHora;
            this.valorHora = valorHora;
        }

        public override double calcSalario()
        {
            return this.qntHora * this.valorHora;
        }

        public override string ToString()
        {
            return $"Função: Horista\n{base.ToString()}\nHoras trabalhadas: {this.qntHora}\nValor da hora: {this.valorHora}\n";
        }
    }
}
