using System;


namespace GerenciadorVeiculos.Modelos
{
    //a classe veiculo é abstrata pois ela serve de molde para carros e motos
    public abstract class Veiculo
    {
        //Propriedades: guardam as informações do veículo
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal ValorDiaria { get; set; }

        //metodo construtor: usado para preencher os dados ao criar o veiculo na memória
        protected Veiculo(string modelo, decimal valorDiaria) 
        {
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        //metodo abstrato: toda classe filha é obrigada a ter este calculo
        public abstract decimal CalcularSeguro();
    }
}
