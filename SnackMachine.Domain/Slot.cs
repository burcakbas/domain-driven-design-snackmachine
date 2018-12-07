using SnackMachines.Common;
using System.Collections.Generic;

namespace SnackMachines.Domain
{
    public class Slot : Entity
    {
        public int Index { get; set; }
        public ICollection<Product> Products { get; set; }

        public Slot()
        {
            Products = new List<Product>(5);
        }

        //ToDo: buySnack , product adedini azaltacak
    }
}