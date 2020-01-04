using System;
using Framework;

namespace Idcard
{
    public class IDCard : Product
    {
        private String owner;

        public IDCard(String owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }

        public override void use()
        {
            Console.WriteLine(owner + "のカードを使います。");
        }

        public String getOwner()
        {
            return owner;
        }
    }
}