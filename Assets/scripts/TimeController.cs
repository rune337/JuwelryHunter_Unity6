using UnityEngine;

public class TimeController : MonoBehaviour
{
    //カウントダウンにするかどうかのフラグ
    //failes　ならカウントアップ
    public bool isCountDown = true;


    //ゲームの基準となる時間
    public float gameTime = 0;

    //カウントを止めるかどうかのフラグ
    //falseならカウントし続ける、tureならカウント終了
    public bool isTimeOver = false;

    //ユーザに見せる時間
    public float displayTime = 0;

    //ゲームの経過時間
    float times = 0;

    void Start()
    {
        //もしカウントダウンであれば基準時間をユーザに見えるようにする
        if (isCountDown)
        {
            displayTime = gameTime;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if (isTimeOver == false)
        if (!isTimeOver)
        {
            //終了フラグがたっていないので処理したいがゲームステータスがplayingで無くなったときは止めたい
            if (GameManager.gameState != "playing")
            {
                isTimeOver = true; //停止フラグをON
            }

            //カウントの処理をする

            //経過時間の蓄積
            times += Time.deltaTime;


            //カウントダウン形式だった場合
            if (isCountDown)
            {
                //ユーザに見せたい時間　(残時間)
                //残時間に (基準時間-経過時間) を代入
                displayTime = gameTime - times;

                if (displayTime < 0)
                {
                    displayTime = 0; //0という表記に統一 
                    isTimeOver = true; //停止タイマーをON
                    GameManager.gameState = "gameover";

                }
            }
            else //カウントアップ形式だった場合
            {
                //経過時間をユーザに見せたい時間に代入
                displayTime = times;
                if (displayTime >= gameTime)
                {
                    //ユーザに見せたい時間を基準時間にする
                    displayTime = gameTime;
                    isTimeOver = true; //停止フラグをON
                    GameManager.gameState = "gameover";
                }
            }

            Debug.Log(displayTime);

        }
    }

}
  
