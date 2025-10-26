using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Atributo : IAtributo
    {
        public Atributo(NomeAtributo nome, byte valor = 0, int modificador = 0)
        {
            Nome = nome;
            Valor = valor;
            Modificador = modificador;
        }
        public NomeAtributo Nome { get; private set; }
        public byte Valor { get; set; }      
        public int Modificador { get; set; } 
        public float Teste 
        { 
            get
            {
                if (Nome != NomeAtributo.Sorte)
                    return ((Valor + Modificador) * 4) * 0.01f;
                else
                    return (Valor + Modificador);
            } 
        }       
        public string Porcentagem 
        { 
            get
            {
                if (Nome != NomeAtributo.Sorte)
                    return ((Valor + Modificador) * 4) + "%";
                else
                    return (Valor + Modificador) + "%";
            }
        }
    }
}