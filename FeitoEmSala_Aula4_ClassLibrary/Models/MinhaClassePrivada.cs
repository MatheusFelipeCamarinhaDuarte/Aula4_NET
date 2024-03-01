using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula4_ClassLibrary.Models
{
    // modificadores de acesso
    // private
    // protected 
    // internal
    // public
    internal class MinhaClassePrivada
    {
        private int _codigoCleinte;
        public int MyProperty { get; set; }

        public void setCodigo(int codigoCliente)
        {
            _codigoCleinte = codigoCliente;
        }
    }
    internal class TestePrivate
    {
        public void TesteAdtributoProvate()
        {
            var classe = new MinhaClassePrivada();
        }
    }
}
