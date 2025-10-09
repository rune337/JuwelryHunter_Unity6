using UnityEngine;

public class Upblock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveY; //Y移動距離

    public bool isMoveWhenOn = false; //乗ったときに動くフラグ
    bool isCanMove = true; //乗らなくても動くフラグ
    bool isReverse = false;             //反転フラグ
    public float wait = 0.0f;
    public float times  = 0.0f;
    float movep = 0;

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
        startPos = transform.position; //初期位置
        endPos = new Vector2(startPos.x, startPos.y + moveY); //移動位置
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMove)
        {
            float distance = Vector2.Distance(startPos, endPos);
            float ds = distance / times;                                //1秒の移動距離
            float df = ds * Time.deltaTime;                             //１フレームの移動距離
            movep += df / distance;                                     //移動補完値
            if (isReverse)
            {
                transform.position = Vector2.Lerp(endPos, startPos, movep); //逆移動
            }
            else
            {
                transform.position  = Vector2.Lerp(startPos, endPos, movep); //正移動
            }

            if(movep >= 1.0f)
            {
                movep = 0.0f; //移動保管値リセット
                isReverse = !isReverse; //移動を逆転
                isCanMove = false; //移動停止
                if (isCanMove == false)
                {
                    //乗ったときに動くフラグOFF
                    Invoke("Move", wait); //移動フラグを立てる遅延実行
                }
            }
        }
        
    }


    //移動フラグを立てる
    public void Move()
    {
        isCanMove=true;
    }

    //移動フラグを下ろす
    public void Stop()
    {
        isCanMove=false;
    }

    //接触開始
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            collision.transform.SetParent(transform);
            if (isMoveWhenOn)
            {
                //乗ったときに動くフラグ
                isCanMove = true;  //移動フラグを立てる
            }
            }
        }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //接触したのがプレイヤーなら移動床の子から外す
            collision.transform.SetParent(null);
        }
    }
    //移動範囲表示
    void OnDrawGizmosSelected()
    {
        Vector2 fromPos;
        if (startPos == Vector2.zero)
        {
            fromPos = transform.position;
        }
        else
        {
            fromPos = startPos;
        }
        //移動線
        Gizmos.DrawLine(fromPos, new Vector2(fromPos.x, fromPos.y + moveY));
        //スプライトのサイズ
        Vector2 size = GetComponent<SpriteRenderer>().size;
        //初期位置
        Gizmos.DrawWireCube(fromPos, new Vector2(size.x, size.y));
        //移動位置
        Vector2 toPos = new Vector2(fromPos.x, fromPos.y + moveY);
        Gizmos.DrawWireCube(toPos, new Vector2(size.x, size.y));
    }
}

