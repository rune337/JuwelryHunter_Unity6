using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName; //切り替えたいシーン名を指定

    //シーンを切り替える機能を持ったメソッド作成
    public void Load()
    {
        //シーン切り替えのメソッド呼び出し
        SceneManager.LoadScene(sceneName);
    }
}

