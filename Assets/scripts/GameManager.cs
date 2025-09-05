using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameManager : MonoBehaviour
{

    public static string gameState;
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
