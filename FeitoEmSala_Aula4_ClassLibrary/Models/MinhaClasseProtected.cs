
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula4_ClassLibrary.Models
{
    // modificadores de acesso
    // private NINGUÉM PODE ACESSAR DE FORA
    // protected Só quem herda a classe pode acessar por herança.
    // internal 
    // public
    internal class MinhaClasseProtected
    {
        protected int _codigoCleinte;
        private int CodigoCliente { get; set; }

        public void setCodigo(int codigoCliente)
        {
            _codigoCleinte = codigoCliente;
        }

        //usado para padronização
        protected virtual void MeuMetodoVirtual()
        {
            Console.WriteLine("Meu método");

        }
    }

    internal class TesteProtected() : MinhaClasseProtected
    {
        //mantém o mesmo nome e usa para sobrescrever
        protected override void MeuMetodoVirtual()
        {
            //
            //
            //
            //
            //
            //
            //
            Console.WriteLine("Procuraaaado");
        }
        public void TesteAdtributoProtected()
        {
            var classe = new MinhaClasseProtected();
            _codigoCleinte += 1;
            classe.CodigoCliente
            classe._codigoCliente;



        }
    }
}

