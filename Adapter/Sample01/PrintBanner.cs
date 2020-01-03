using System;

public class PrintBanner : Banner, Print {
    public PrintBanner(String str) : base(str) {
    }

    public void printWeak()  {
        showWithParen();
    }

    public void printStrong() {
        showWithAster();
    }
}