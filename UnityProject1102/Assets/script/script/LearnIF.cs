
using UnityEngine;

public class LearnIF : MonoBehaviour
{

    public bool test;
    public string prop;

    [Range(0, 100)]
    public int HP = 100;

    //更新事件:一秒執行六十次
    private void Update()
    {
        #region 判斷式
        // 判斷式 if 語法
        // if (布林值){陳述式或演算法}
        // ()中的布林值為true 才會執行 if{}

        if (test)
        {
            print("打開開關!");
        }
        // ()中的布林值為false才會執行 else{}
        else
        {
            print("關閉開關!");
        }


        if (prop == "紅色藥水")
        {
            print("補血");

        }
        else if (prop == "藍色藥水")
        {
            print("補魔力");
        }
        else if (prop == "黃色藥水")
        {
            print("補精神值");
        }
        else
        {
            print("沒發生任何事");

        }
        #endregion

        #region 練習if
        if (HP >= 70)
        {
            print("安全");
        }
        else if ( HP >= 50)
        {
            print("警告");
        }
        else if ( HP >=20)
        {
            print("危險");
        }
        else
        {
            print("快死了");
        }
        #endregion
    }
}
