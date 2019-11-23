using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int jumpHeight = 200; //跳躍高度
    [Header("是否死亡"), Tooltip("用來判斷腳色是否死亡 true為死亡 false為存活")]
    public bool death; //死亡與否

    public Rigidbody2D rb2D;


    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    public void Jump()
    {

        //判斷如果玩家按下左健
        //滑鼠左鍵、手機觸控 Mouse0

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //重置重力加速度，讓剛體設定重新啟動，使重力影響不疊加
            rb2D.Sleep();
            
            // 開始遊戲時恢復重力影響
            rb2D.gravityScale = 1;

            //小雞往上跳
            //對小雞的剛體施加一個y軸(向上)方向的推力
            //小雞剛體.增加推力.(二維向量(上下,左右));
            rb2D.AddForce(new Vector2(0, jumpHeight));

          

        }

    }

    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    public void Dead()
    {
        
    }


    private void Update()
    {
        Jump();
    }

}
