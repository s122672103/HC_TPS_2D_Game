
using UnityEngine;
using UnityEngine.UI; //引用UI介面
public class GameManager : MonoBehaviour
{

    [Header("目前分數")]
    public int score = 0; // 目前分數
    [Header("最佳分數")]
    public int bestScore = 0; // 最佳分數
    [Header("水管")]
    // GameObject 可存放 場景上的遊戲物件 與 專案內的預製物
    public GameObject pipe;
    [Header("遊戲結算畫面")]
    public GameObject goFinal;
    [Header("遊戲結束")]
    //加上 static 就不會顯示在屬性面板上
    public static bool gameOver;
    [Header("分數介面")]
    public Text textScore;


    /// <summary>
    /// 加分的方法。
    /// </summary>
    public void AddScore()
    {
        score++;
        // 分數介面.文字內容 = 分數.轉為字串();
        textScore.text = score.ToString();
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

    /// <summary>
    /// 遊戲失敗後 方法。
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true); //顯示結算畫面
        gameOver = true;         //遊戲結束 = 是
        CancelInvoke("SpawnPipe");  //停止 InvokeRepeating「重複調用」的方法
    }
    private void Start()
    {
        //重複調用指令("方法名稱", 開始時間 , 間隔時間浮點數)
        InvokeRepeating("SpawnPipe", 0, 3.0f);
    }


}
