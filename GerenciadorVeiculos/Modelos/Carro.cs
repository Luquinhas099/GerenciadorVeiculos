using System;


namespace GerenciadorVeiculos.Modelos
{
    //os ":" indicam que Carro herda de veiculo
    public class Carro : Veiculo
    {
        //informações exclusivas de carro
        public int Portas { get; set; }

        //construtor repassa modelo e valordiaria para classe mãe(Veiculo) atraves do base()
        public Carro(string modelo, decimal valorDiaria, int portas) : base(modelo, valorDiaria)
        {
            Portas = portas;
        }

        //polimorfismo: para carro o seguro é de 10% do valor da diaria
        public override decimal CalcularSeguro()
        {
            return ValorDiaria * 0.10m;
        }
    }
}
