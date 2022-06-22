namespace design_patterns.Proxy
{
    public class ProxyImage : IImage
    {
        private string file;
        private RealImage real;

        public ProxyImage(string file)
        {
            this.file = file;
        }


        public void display()
        {

            real = new RealImage(file);

            real.display();
        }
    }
}