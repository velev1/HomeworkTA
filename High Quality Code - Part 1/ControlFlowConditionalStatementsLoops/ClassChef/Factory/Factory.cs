namespace ClassChef.Factory
{
    using Contracts;
    using Models;

    public class Factory
    { 
        public IVegetable GetCarrot()
        {
            return new Carrot();
        }

        public IVegetable GetPotato()
        {
            return new Potato();
        }

    }
}