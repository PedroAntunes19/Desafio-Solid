using System;

namespace ISP.Violacao
{
    public interface Câmera
    {
        public void TirarFoto();
        public void Imprimir();
        public void Digitalizar();
        public void Editar();
    }
}
// Esse código viola o ISP(Principio de Segregação de Interface)
// Pois a interface tem muitas resposabilidades