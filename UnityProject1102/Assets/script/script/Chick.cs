using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int JumpHeight = 100; //跳躍高度
    [Header("是否死亡")]
    public bool death; //死亡與否

}
