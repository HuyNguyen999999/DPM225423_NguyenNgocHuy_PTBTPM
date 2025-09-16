namespace DPM225423_NguyenNgocHuy_Pattern01_Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
