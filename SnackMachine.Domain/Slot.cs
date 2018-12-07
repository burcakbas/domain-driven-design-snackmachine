using System.Collections.Generic;

namespace SnackMachines.Domain
{
    public class Slot
    {
        public int Index { get; set; }
        public ICollection<Product> Products { get; set; }

        public Slot()
        {
            Products = new List<Product>(5);
        }

        //buySnack , product adedini azaltacak
    }
}