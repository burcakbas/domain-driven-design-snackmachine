using SnackMachines.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Domain
{
    public interface ISnackMachineRepository : IRepository<SnackMachine>
    {
        IList<SnackMachine> GetSnackMachines();

        IList<Product> GetProducts();

        IList<Slot> GetSlots(int snackMachineId);
    }
}
