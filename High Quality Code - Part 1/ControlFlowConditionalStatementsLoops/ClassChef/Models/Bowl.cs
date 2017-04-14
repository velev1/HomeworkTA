namespace ClassChef.Models
{
    using System.Collections.Generic;

    using Contracts;

    public class Bowl
    {
        private ICollection<IVegetable> vigitables;

        public Bowl()
        {
            this.vigitables = new List<IVegetable>();
        }

        public ICollection<IVegetable> Vegitables
        {
            get
            {
                return new List<IVegetable>(this.vigitables);
            }

            private set
            {
                this.vigitables = value;
            }
        }

        public void Add(IVegetable vegitable)
        {
            this.vigitables.Add(vegitable);
        }
    }
}
