using System;

namespace LSP.Violacao
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
        void TAMANHO() { }  
    }
    
}
// Esse código quebra o LSP(Princípio de Substituição de Liskov)
// Pois Se o código cliente depender de TAMANHO(), ele não poderá usar Roupa como IProduto
// sem quebrar o funcionamento do programa. Portanto, Roupa NÃO pode substituir IProduto.