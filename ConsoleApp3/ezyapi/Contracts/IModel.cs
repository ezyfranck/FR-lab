using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ezyapi.Contracts
{
    public interface IUpdatableModel : IModel
    {
    }

    public interface IModel
    {
        string Id { get; }
    }
}
