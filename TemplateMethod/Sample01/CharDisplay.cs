using System;

public class CharDisplay : AbstractDisplay {
    private char ch;

    public CharDisplay(char ch) {
        this.ch = ch;
    }

    public override void open() {
        Console.Write("<<");
    }

    public override void print() {
        Console.Write(ch);
    }

    public override void close() {
        Console.WriteLine(">>");
    }
}
