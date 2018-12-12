using SnackMachines.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Domain
{
    public class SnackMachineRepository : NHibernateRepository<SnackMachine>, ISnackMachineRepository
    {
        public IList<Product> GetProducts()
        {
            //ToDo: extra domain spesifik repo çağrıları buradan
            throw new NotImplementedException();
        }

        public IList<Slot> GetSlots(int snackMachineId)
        {
            throw new NotImplementedException();
        }

        public IList<SnackMachine> GetSnackMachines()
        {
            throw new NotImplementedException();
        }
    }
}
