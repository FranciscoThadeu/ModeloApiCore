using MediatR;
using Modelo.ApiCore.Dapper.Domain.Core.Events;
using System;

namespace Modelo.ApiCore.Dapper.Domain.Core.Commands
{
    public class Command : Message, IRequest
    {
        public DateTime Timestamp { get; private set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
