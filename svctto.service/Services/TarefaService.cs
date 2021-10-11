using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using svctto.common;

namespace svctto.service
{
    public class TarefaService : Tarefas.TarefasBase
    {
        private readonly ILogger<TarefaService> _logger;
        public TarefaService(ILogger<TarefaService> logger)
        {
            _logger = logger;
        }

        public override 
    }
}
