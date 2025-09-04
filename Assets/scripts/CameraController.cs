using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    float x,y,z; //カメラの変数を決めるための変数

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Playerタグを盛ったゲームオブジェクトを探して、変数playerに代入
        player = GameObject.FindGameObjectWithTag("Player");
        //カメラのz座標は初期値のままを維持したい
        z = transform.position.z;    
    }

    // Update is called once per frame
    void Update()
    {
        //いったんプレイヤーのX座標、Y座標の位置を変数に取得
        x = player.transform.position.x;
        y = player.transform.position.y;

        //取り決めた各変数x,y,zの値をカメラのポジションとする
        transform.position = new Vector3(x,y,z);
    }
}
