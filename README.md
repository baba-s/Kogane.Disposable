# Kogane Disposable

UniRx の Disposable クラスのみを抽出したパッケージ

# 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        using ( Disposable.Create( () => Debug.Log( "Complete" ) ) )
        {
        }

        Disposable.Create( () => Debug.Log( "Complete" ) ).AddTo( gameObject );
    }
}
```

## 備考

* 本パッケージは以下の MIT License のリポジトリの機能を使用しております
    * https://github.com/neuecc/UniRx