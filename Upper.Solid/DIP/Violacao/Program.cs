using System;

namespace DIP.Violacao
{
    public class Motor
    {
        public void Ligar() { }
    }

    public class Carro
    {
        private Motor motor = new Motor();
    }
}
// Esse código viola o DIP (Princípio da Inversão de Dependência)
// porque a classe Carro depende diretamente da classe concreta Motor.
// Assim, o Carro fica acoplado a um tipo específico de motor,
// impedindo substituição por outras implementações.
