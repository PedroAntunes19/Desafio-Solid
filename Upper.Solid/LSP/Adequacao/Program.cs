using System;

namespace LSP.Adequacao
{
    public interface IProduto
    {
        void Preco();
        void ID();
    }
    class Perfume : IProduto
    {
        void Preco() { }
        void ID() { }     
    }
    class Roupa : IProduto
    {
        void Preco() { }
        void ID() { }     
    }
    
}
// Esse código esta em adequação ao LSP(Princípio de Substituição de Liskov)
// A classe filha pode substituir sua classe pai sem alterar o funcionamento do programa.