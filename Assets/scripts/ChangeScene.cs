using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName; //切り替えたいシーン名を指定
    public bool toTitle; //タイトルへの切り替えかどうかのフラグ

    //シーンを切り替える機能を持ったメソッド作成
    public void Load()
    {
        //シーンが切り替わる際はいずれにしてもステージスコアはリセット
        GameManager.stageScore = 0;
        Debug.Log("【ChangeScene】スコアは 0 にリセットされました。");

        //toTitleフラグがtrueになっている場合はタイトルに戻ることが予想されるのでトータルスコアもリセット
        if (toTitle) GameManager.totalScore = 0;

        //シーン切り替えのメソッド呼び出し
        SceneManager.LoadScene(sceneName);
    }
}

