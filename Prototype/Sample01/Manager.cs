using System;
using System.Collections.Generic;

namespace Framework
{
    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();

        public void register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }

        public Product create(string protoname)
        {
            Product p = showcase[protoname];
            return p.createClone();
        }
    }

}