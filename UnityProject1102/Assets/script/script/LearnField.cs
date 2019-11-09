
using UnityEngine;

public class LearnField : MonoBehaviour
{
    // 定義欄位 Field
    // 語法:欄位類型 欄位名稱 (指定值) 結束

    // 私人 : 隱藏 private (預設)
    // 公開 : 顯示 public 

    // 整數 int       -  0, 1, 999, -100        預設值為零
    // 浮點數 float   -  -1.5, -999.9, 100.5    預設值為零
    // 字串 string    -  紅色藥水、鞋子         預設""
    // 布林值 bool    -  true、false            預設 false

    [Header("角色等級"), Range(1, 999)] //Header為額外的一個title
    public int Lv = 1;  //角色等級
    [Tooltip("角色的移動速度，別調太高，角色會飛走")] //滑鼠hover名稱時出現的提示說明
    [Range(0.1f,99.9f)]  //Range 此限制範圍的拉桿模式只適用於數值型態
    public float speed = 1.5f; //走路速度
    public string prop1 = "紅色藥水";  //道具名稱
    public bool mission = true; //任務成功與否


}
