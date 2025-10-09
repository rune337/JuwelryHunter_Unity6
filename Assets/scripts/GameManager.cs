using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameManager : MonoBehaviour
{

    public static string gameState;
    public static int totalScore; //ゲーム全体を通してのスコア
    public static int stageScore; //そのステージで獲得したスコア


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Staertより前に処理される
    void Awake()
    {
        //ゲームの初期状態をplaying
        gameState = "playing";
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
