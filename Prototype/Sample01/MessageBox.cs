using System;
using System.Text;
using Framework;

public class MessageBox : Product
{
    private char decochar;

    public MessageBox(char decochar)
    {
        this.decochar = decochar;
    }

    public void use(String s)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        int length = Encoding.GetEncoding("shift_jis").GetByteCount(s);

        for (int i = 0; i < length + 4; i++)
        {
            Console.Write(decochar);
        }
        Console.WriteLine("");
        Console.WriteLine(decochar + " " + s + " " + decochar);
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write(decochar);
        }
        Console.WriteLine("");
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