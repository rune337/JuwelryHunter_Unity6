using UnityEngine;

public class PlayerOn : MonoBehaviour
{
    [Header("乗ったら動かす")]
    public bool isMoveWhenOn = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            // プレイヤーを親ブロックの子にする
            collision.transform.SetParent(transform.parent);

            if (isMoveWhenOn)
            {
                MovingBlock parentBlock = transform.parent.GetComponent<MovingBlock>();
                if (parentBlock != null)
                    parentBlock.Move();
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
