using System;
using System.Collections;
using Framework;

namespace Idcard
{
    public class IDCardFactory : Factory
    {
        private ArrayList owners = new ArrayList();

        protected override Product createProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void registerProduct(Product product) {
            owners.Add(((IDCard)product).getOwner());
        }

        public ArrayList getOwners() {
            return owners;
        }
    }
}