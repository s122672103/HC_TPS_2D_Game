
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3, c = 10, d = 10;
    public int score = 50;
    public int num1 = 90, num2 = 10;
    public bool boolA = true, boolB = false;
    public int hp = 100, prop = 10;
   

    private void Start()
    {
        #region 數學運算子區域
        // 數學運算子
        print(a + b); //13 加
        print(a - b); //7  減
        print(a * b); //30 乘
        print(a / b); //3  除
        print(a % b); //1  餘

        // 遞增 ++ 、 遞減 --
        print(c++);  //先輸出再執行遞增
        print(++d);  //先執行遞增再輸出

        //指定運算:等號右邊會先執行運算，再傳輸回等號左邊
        // "="在c#中為指定的意思
        // 適用所有數學運算

        score = score + 10; 
        score += 10; //分數加十 加號可替換為其他運算符號

        print(6 / 2 * (2 + 1));
        #endregion

        #region 比較運算子區域
        //比較運算子(結果為布林值)

        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2); //判斷是否等於
        print(num1 != num2); //判斷是否不等於
        #endregion

        #region 邏輯運算子區域
        // 邏輯運算子(結果為布林值)

        // 並且 &&
        print(boolA && boolB);  //只要有一者為false 結果就為false  f
        print(true && true);  //t
        print(true && false);  //f
        print(false && true);  //f
        print(false && false);  //f

        //或者 ||
        print(boolA || boolB);  //只要有一者為true 結果就為true  t
        print(true || true);  //t
        print(true || false);  //t
        print(false || true);  //t
        print(false || false);  //f

          //可做為過關與否的判定條件  EX 過關條件:HP > 50 並且 道具 > 7
          print(hp > 50 && prop > 7); //t

        //相反! (不是...)
        print(!true);  //f
        print(!false); //t

        #endregion

    }
}
