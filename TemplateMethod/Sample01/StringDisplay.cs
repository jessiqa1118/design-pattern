using System;
using System.Text;

public class StringDisplay : AbstractDisplay {
    private String str;
    private int width;

    public StringDisplay(String str) {
        this.str = str;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        this.width = Encoding.GetEncoding("shift_jis").GetByteCount(str);
    }

    public override void open() {
        printLine();
    }

    public override void print() {
        Console.WriteLine("|" + str + "|");
    }

    public override void close() {
        printLine();
    }

    private void printLine() {
        Console.Write("+");

        for (int i = 0; i < width; i++) {
            Console.Write("-");
        }

        Console.WriteLine("+");
    }
}
