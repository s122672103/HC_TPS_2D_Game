
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    [Header ("目前分數")]
    public int Score = 0; //目前分數
    [Header ("最佳分數")]
    public int BestScore = 0; //最佳分數

    //修飾詞可限定權限

    /// <summary>
    /// 加分的方法。
    /// </summary>
    public void AddScore()
    {

    }

    /// <summary>
    /// 最高分數的判定方法。
    /// </summary>
    private void HighScore()
    {

    }


    /// <summary>
    /// 生成水管的方法。
    /// </summary>
    private void SpawnPipe()
    {
     
    }


    /// <summary>
    /// 遊戲失敗的判定方法。
    /// </summary>
    public void GameOver()
    {

    }
}
