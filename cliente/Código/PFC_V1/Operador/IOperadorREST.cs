﻿using PFC_V1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Operador
{
    interface IOperadorREST
    {
        List<T> listar<T>(Uri uriBase);
    }
}
