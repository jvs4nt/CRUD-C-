using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    static class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "crud";
        private const string usuario = "root";
        private const string senha = "Mbd828304";

        static public string server = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";


    }
}
