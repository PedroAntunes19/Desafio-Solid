namespace OCP.Violacao
{
    public class CalculadorDeDescontos
    {
        public double Calcular(string tipoCliente, double valor)
        {
            if (tipoCliente == "Comum")
            {
                return valor * 0.1;
            }
            else if (tipoCliente == "Vip")
            {
                return valor * 0.2;
            }
            else if (tipoCliente == "Premium")
            {
                return valor * 0.3;
            }

            return 0;
        }
    }
}

        // Violação do OCP: toda vez que surge um novo tipo de cliente,
        // precisamos modificar esta classe, adicionando mais if/else.
