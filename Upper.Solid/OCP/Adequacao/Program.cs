namespace OCP.Adequacao
{
        // Interface que define o contrato    
        public interface IDesconto
        {
            double Calcular(double valor);
        }
        // Implementações diferentes do contrato
        public class DescontoClienteComum : IDesconto
        {
            public double Calcular(double valor) => valor * 0.1;
        }
        public class DescontoClienteVip : IDesconto
        {
            public double Calcular(double valor) => valor *0.2;
        }
        // Usando o contrato sem precisar de detalhes
        public class CalculadorDeDescontos
        {
            public double Calcular(IDesconto desconto, double valor)
            {
                return desconto.Calcular(valor);
            }
        }
}
        
        // Essa classe esta em adequacao ao OCP (Open-Closed Principle) por permitir que amplifique o código e estar fechado a implementações