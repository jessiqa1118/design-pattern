using System;

public class PrintBanner : Print {
    private Banner banner;

    public PrintBanner(String str) {
        this.banner = new Banner(str);
    }

    public override void printWeak() {
        banner.showWithParen();
    }

    public override void printStrong() {
        banner.showWithAster();
    }
}