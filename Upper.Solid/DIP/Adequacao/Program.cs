using System;
using System.Runtime.CompilerServices;

namespace DIP.Adequacao
{
    public interface IMotor
    {
        void Ligar();
    }
    public class Motor: IMotor
    {
        public void Ligar() { }
    }
    public class Carro
    {
        private IMotor motor;
        public Carro(IMotor motor)
        {
            this.motor = motor;
        }
    }
}
// Esse código está em adequação ao DIP (Princípio da Inversão de Dependência)
//Porque Carro recebe o motor de fora, não cria dentro dele injeção de dependência