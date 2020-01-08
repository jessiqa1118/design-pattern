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
using System.Text;

string str;
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


### Dictionary
▽ Java
```java
private HashMap showcase = new HashMap();
showcase.put('key', 'value');
String v = showcase.get('key');
```

▽ C#
```cs
private Dictionary<string, string> showcase = new Dictionary<string, string>();
showcase.Add('key', 'value');
string v = showcase['key'];
```


### CloneableインターフェースとCloneメソッド
#### Cloneable
▽ Java
```java
public interface Product extends Cloneable {
    ...
}
```

▽ C#
```cs
public interface Product : ICloneable
{
    ...
}
```

#### Clone
▽ Java
```java
public class MessageBox implements Product {
    ...

    public Product createClone()
    {
        Product p = null;
        try {
            p = (Product)clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        return p;
    }
    ...
}
```

▽ C#
```cs
public class MessageBox : Product
{
    ...

    private Object Clone() {
        return this.MemberwiseClone();
    }

    public Product createClone() {
        Product p = null;
        p = (Product)this.Clone();

         return p;
    }
    ...
}
```

Javaではclone()メソッドが標準で用意されており、この場合はshallow copyとなる。
C#の場合はICloneableインターフェースを継承したクラス内でCloneメソッドを明示的に実装する必要がある。
ただし、実装したCloneメソッドがpublicでない場合、下記のようなコンパイルエラーが出力される。
```
'MessageBox.Clone()' は public ではないため、インターフェイス メンバーを実装できません。
```

一方で、publicにしてしまうとクラス外部から直接Cloneメソッドが実行可能となってしまうので、正直これでいいのかという感じ。
適切な実装がわからないので、ここはもう少し調べておいたほうがよさそう。

ちなみにJavaのclone()メソッドに対応するのはMemberwiseClone()メソッドで、これもshallow copyを提供する(Exceptionは用意されていなさそう)。
Deep copyの場合は、Clone()メソッド内で必要なパラメータを引っ張ってくる項目を実装する必要がある。
