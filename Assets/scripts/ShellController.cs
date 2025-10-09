using UnityEngine;

public class ShellController : MonoBehaviour
{
    [Header("生存時間")]
    public float deleteTime = 3.0f; //削除する時間設定

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, deleteTime); //削除設定
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); //何かに接触したら消す
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
