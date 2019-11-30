
using UnityEngine;
using UnityEngine.UI; //引用UI介面API
using UnityEngine.SceneManagement;   //引用場景管理API
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
    public Text textBest;
    

    

    /// <summary>
    /// 加分的方法。
    /// </summary>
    public void AddScore()
    {
        score++;
        // 分數介面.文字內容 = 分數.轉為字串();
        textScore.text = score.ToString();
        //  呼叫最佳分數判定
        HighScore();

        if (score % 3 == 0 && score > 2)
        {
            if (Ground.speed >= 10f)
            {
                return;
            }
            Ground.speed += 0.5f;
        }
      
    }

    /// <summary>
    /// 最高分數的判定方法。
    /// </summary>
    private void HighScore()
    {
        if (score > PlayerPrefs.GetInt("最高得分"))
        {
            PlayerPrefs.SetInt("最高得分", score);
        }

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
    /// 遊戲失敗。
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true); //顯示結算畫面
        gameOver = true;         //遊戲結束 = 是
        CancelInvoke("SpawnPipe");  //停止 InvokeRepeating「重複調用」的方法
    }

    //要給UI按鈕呼叫的方法必須是public

     /// <summary>
     /// 重新遊戲
     /// </summary>
    public void Replay()
    {
        // Application.LoadLevel("遊戲場景1102"); // 應用程式.載入場景("場景名稱"); 舊版API
        SceneManager.LoadScene("遊戲場景1102");   // 場景管理器.載入場景("場景名稱"); 新版API

    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit(); //使用 應用程式.離開();
    }

    private void Start()
    {
        Ground.speed = 3.0f;
        Screen.SetResolution( 450, 800, false); //螢幕.設定解析度 (寬,高,是否全螢幕);
        //靜態成員在載入場景時不會自動還原(故需在Start中設定還原)
        gameOver = false;
        //重複調用指令("方法名稱", 開始時間 , 間隔時間浮點數)
        InvokeRepeating("SpawnPipe", 0, 2.7f);
        
        textBest.text = PlayerPrefs.GetInt("最高得分").ToString();

    }


}
