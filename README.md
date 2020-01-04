# デザインパターン
## ◆概要
学習用リポジトリ。
Javaで書かれたデザインパターンのサンプルコードをC#で実装。


## ◆プロジェクトの初期化
```
> dir [ディレクトリ名]
> cd [ディレクトリ名]
> dotnet new console
```


## ◆実行コマンド
```powershell
> dotnet run
```


## ◆言語の変換
### 標準出力
▽ Java
```java
System.out.print("Jessica");
System.out.println("Jessica");
```

▽ C#
```cs
Console.Write("Jessica");
Console.WriteLine("Jessica");
```


### 文字列のバイト数取得
▽ Java
```java
String str;
int width = str.getBytes().length;
```

▽ C#
```cs
String str;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
int width = Encoding.GetEncoding("shift_jis").GetByteCount(str);
```

C#では文字コードを自動的に判別する方法を見つけられていないので、明示的にShift-JISを指定。
ただし、.NET CoreではデフォルトでShift-JISをサポートしていないようなので、カスタムエンコーディングを登録する必要がある。
NuGetからパッケージ "System.Text.Encoding.CodePages" をダウンロードして配置すればよい。

▽参考リンク  
[.NET CoreでShift-JISを取り扱う方法](https://blog.hitsujin.jp/entry/2019/01/27/200055)

### パッケージと名前空間
▽ Java
```java
import custom
```

▽ C#
```cs
using Custom;
```

Javaでいうパッケージは、C#における名前空間と対応づけられる。
ネーミングルールを考慮し、名前空間の場合は頭文字を大文字にする。
