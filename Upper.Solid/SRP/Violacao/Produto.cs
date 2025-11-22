namespace SRP.Violacao
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nome) && Preco > 0;
        }

        public void Salvar()
        {
            Console.WriteLine("Produto salvo no banco de dados");
        }

        public void Email()
        {
            Console.WriteLine("Enviando email");
        }
    }
}
