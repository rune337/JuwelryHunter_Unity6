# JewelryHunter_Unity6

[ゲームのサンプルプレイ](https://rune337.github.io/juwelryhunter_web/)

![ゲーム画面](readmeImg/juwelryhunter.jpg)

## 訓練校で学習する初2D作品
* playerの動作
* アニメーションの作り方
* タグレイヤーの使い方
などを学んでいきます。

## 制作のポイント
### アニメーションをトランジションで作成
Playerのアニメ切り替えには各クリップをトランジションで繋いでフラグで管理しました。トランジションを組み込むことで、アニメ切り替えが滑らかになり、
かつコーディングが効率的なものになりました。
  
![トランザクションの絵](readmeIMg/animator.jpg)
  
## Itemのコーディングの効率化
Itemは列挙型のItemColorを自作して、ItemColor型の変数次第で選ばれた色により見た目が変わるようなコーディングの工夫を行いました。

![トランザクションの絵](readmeIMg/item.jpg)

```
using UnityEngine;

public enum ItemColor
{
    White,
    Blue,
    Green,
    Red
}

public class ItemData : MonoBehaviour
{
    public ItemColor colors = ItemColor.White;
    public Sprite[] itemSprites;

    public int value = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        switch (colors)
        {
            case ItemColor.White:
                spriteRenderer.sprite = itemSprites[0];
                break;
            case ItemColor.Blue:
                spriteRenderer.sprite = itemSprites[1];
                break;
            case ItemColor.Green:
                spriteRenderer.sprite = itemSprites[2];
                break;
            case ItemColor.Red:
                spriteRenderer.sprite = itemSprites[3];
                break;
        }

    }
}
```

## TextMeshProのデザイン切り分け
TextMeshProのデザインを細かく切り分けてデータを用意するなど工夫しました。

![TextMeshProデザインの絵](readmeIMg/result.jpg)(readmeIMg/title.jpg)(readmeIMg/font.jpg)