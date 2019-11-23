
using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("地板移動速度")]
    [Range(0.1f, 10.1f)]
    public float speed = 10.1f;

    [Header("地板變形元件")]
    public Transform ground;


    private void Update()
    {
        // 呼叫自己的方法  print 則是呼叫官方的方法
        Move();
    }

    // 方法/函式 Method / function 語法;
    // 修飾詞 方法類型 方法名稱 () { 陳述式(敘述、數學運算) }
    // void 無傳回類型

    /// <summary>
    /// 地板的移動方法。
    /// </summary>
        private void Move()
    {
        //如果GM.遊戲結束 為勾選true 就跳過底下方法
        if (GameManager.gameOver) return;
        

        //地板位移的方法(下面一條是官方網站給的方法)
        //地板.位移(x, y, z); 減號用來顛倒預設的運動方向
        //Time.deltaTime 跑每幀的所需時間單位 乘上它,讓性能不同的裝置擁有一致的表現 
        ground.Translate(-speed *Time.deltaTime, 0, 0);

    } 
}
