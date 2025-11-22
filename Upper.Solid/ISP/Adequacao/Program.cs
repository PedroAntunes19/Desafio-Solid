using System;

namespace ISP.Adequacao
{
    public interface ICâmera
    {
        public void TirarFoto();
    }
    public interface IImpressora
    {
        public void Imprimir();
    }
    public interface IDigitalizadora
    {
        public void Digitalizar();
    }
    public interface IEditordeFoto
    {
        public void Editar();
    }

}
// Esse código está em adequacao ao ISP(Principio de Segregação de Interface)
// Pois cada interface te apenas uma Responsabilidade