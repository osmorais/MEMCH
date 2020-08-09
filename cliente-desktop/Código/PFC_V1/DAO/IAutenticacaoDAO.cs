using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.DAO
{
    interface IAutenticacaoDAO
    {
        void executar(ref Usuario usuario);
    }
}
