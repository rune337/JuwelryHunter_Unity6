using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject mainImage; //アナウンスをする画像
    public GameObject buttonPanel; //ボタンをグループ化しているパネル

    public GameObject retryButton; //リトライボタン
    public GameObject nextButton; //ネクストボタン

    public Sprite gameClearSprite; //ゲームクリアの絵
    public Sprite gameOverSprite;  //ゲームオーバーの絵

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonPanel.SetActive(false); //存在を非表示

        //時間差でメソッドを発動
        Invoke("InactiveImage",1.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.gameState == "gameclear")
        {
            buttonPanel.SetActive(true); //メインパネルの表示
            mainImage.SetActive(true); //メイン画像の復活
            //メイン画像オブジェクトのImageコンポーネントが所持している変数spriteに"ステージクリア"の絵を代入
            mainImage.GetComponent<Image>().sprite = gameClearSprite;
            //リトライボタンオブジェクトのButtonコンポーネントが所持している変数intaeractibleを無効(ボタン機能を無効)
            retryButton.GetComponent<Button>().interactable = false;
        }

        else if(GameManager.gameState == "gameover")
        {
            buttonPanel.SetActive(true); //メインパネルの表示
            mainImage.SetActive(true); //メイン画像の復活
            //メイン画像オブジェクトのImageコンポーネントが所持している変数spriteに"ゲームオーバー"の絵を代入
            mainImage.GetComponent<Image>().sprite = gameOverSprite;
            //リトライボタンオブジェクトのButtonコンポーネントが所持している変数intaeractibleを無効(ボタン機能を無効)
            nextButton.GetComponent<Button>().interactable = false;
        }
    }

    //メイン画像を表示するためのメソッド
    void InactiveImage()
    {
        mainImage.SetActive(false);
    }
}
