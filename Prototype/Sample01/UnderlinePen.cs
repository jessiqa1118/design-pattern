using System;
using System.Text;
using Framework;

public class UnderlinePen : Product
{
    private char ulchar;

    public UnderlinePen(char ulchar)
    {
        this.ulchar = ulchar;
    }

    public void use(string s)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        int length = Encoding.GetEncoding("shift_jis").GetByteCount(s);

        Console.WriteLine("\"" + s + "\"");
        Console.Write(" ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(ulchar);
        }
        Console.WriteLine(" ");
    }

    public Object Clone()
    {
        return this.MemberwiseClone();
    }

    public Product createClone()
    {
        Product p = null;
        p = (Product)this.Clone();

        return p;
    }
}