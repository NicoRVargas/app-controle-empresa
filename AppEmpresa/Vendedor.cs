using System;


namespace AppEmpresa
{
    public class Vendedor : Funcionario
    {
        private double vendas;
        private double taxa;
        
        public Vendedor(string nome, string cpf, double vendas, double taxa)
        : base(nome, cpf)
        {
            this.vendas = vendas;
            this.taxa = taxa;
        }

        public override double calcSalario()
        {
            return this.vendas * (this.taxa/100);
        }

        public override string ToString() 
        {
            return $"Função: Vendedor\n{base.ToString()}\nVendas: {this.vendas}\nTaxa: {this.taxa}%\n";
        }
    }
}
