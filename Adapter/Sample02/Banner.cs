using System;

public class Banner {
    private String str;

    public Banner(String str) {
        this.str = str;
    }

    public void showWithParen() {
        Console.WriteLine("(" + str + ")");
    }

    public void showWithAster() {
        Console.WriteLine("*" + str + "*");
    }
}