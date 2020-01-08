using System;

namespace Framework
{
    public interface Product : ICloneable
    {
        public abstract void use(String s);
        public abstract Product createClone();
    }
}