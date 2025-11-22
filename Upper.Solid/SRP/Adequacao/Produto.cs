

namespace SRP.Adequacao
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        // Retorna o nome e o preco do produto
        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nome) && Preco > 0;
        }
    }
}
        // Essa classe esta em adequacao ao SRP (Single Responsibility Principle) por ter apenas uma responsabilodade  