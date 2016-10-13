
namespace DefineClass
{
    class Display
    {
        private float height;
        private float width;
        private int numberOfColors;

        public Display(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public Display(int numberOfColors)
        {
            this.numberOfColors = numberOfColors;
        }

        public Display(float height, float width, int numberOfColors)
         :this(height, width)
        {
            this.numberOfColors = numberOfColors;
        }

    }
}
