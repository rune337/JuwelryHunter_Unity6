using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody; //PlayerについているRigidbody2Dを扱うための変数

    float axisH; //入力の方向を記憶するための変数
    public float speed = 3.0f; //プレイヤーのスピードを調整

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //Playerについているコンポーネント情報を取得

    }

    // Update is called once per frame
    void Update()
    {
        //Velocityの元となる値の取得(右なら1.0f、左なら-1.0f、何もなければ0)
        axisH = Input.GetAxisRaw("Horizontal");







    }

    //1秒間に50回繰り返すように制御しながら行う繰り返しメソッド
    private void FixedUpdate()
    {
        //velocytyに値を代入
        rbody.linearVelocity = new Vector2(axisH * speed, rbody.linearVelocity.y);
    }

}
