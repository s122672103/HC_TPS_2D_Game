using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int jumpHeight = 100; //跳躍高度
    [Header("是否死亡"), Tooltip("用來判斷腳色是否死亡 true為死亡 false為存活")]
    public bool death; //死亡與否

    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    public void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    public void Dead()
    {

    }
}
