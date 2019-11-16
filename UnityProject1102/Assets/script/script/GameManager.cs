
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("目前分數")]
    public int Score = 0; //目前分數
    [Header("最佳分數")]
    public int BestScore = 0; //最佳分數
    [Header("水管")]
    //可存放 場景上的遊戲物件 與 專案內的預製物
    public GameObject pipe;



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

        // 單純重複重疊生成(物件);  Object可簡化不寫
        // Object.Instantiate(pipe); 

        // 有條件的生成(物件名稱，生成位置 座標，角度)
        //  區域欄位(不需要修飾詞) 用來定義三維座標位置 pos
        // Quaternion. identity 代表零角度
        // Random.Range(int,int) 隨機數值 

        Vector3 pos = new Vector3(8, Random.Range(0, 3), 0);
        Instantiate(pipe, pos, Quaternion.identity);
        
    }

    private void Start()
    {
        //重複調用指令("方法名稱", 開始時間 , 間隔時間浮點數)
        InvokeRepeating("SpawnPipe", 0, 3.0f);
    }

    /// <summary>
    /// 遊戲失敗的判定方法。
    /// </summary>
    public void GameOver()
    {

    }


}
