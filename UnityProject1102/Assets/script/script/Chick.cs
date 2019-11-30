using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"), Range(1, 2000)]
    public int jumpHeight = 200;
    [Header("轉動角度"),Range(0,100)]
    public float angle = 5; 
    [Header("是否死亡"), Tooltip("用來判斷腳色是否死亡 true為死亡 false為存活")]
    public bool death; //預設值為false
    [Header("剛體")]
    public Rigidbody2D rb2D;
    [Header("遊戲管理器")]
    public GameManager gm;

    public GameObject goScore, goGM;

    // AudioSource 存放喇叭元件
    // AudioClip 存放音效檔案
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundAdd;


    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    public void Jump()
    {
        //return 讓運算直接跳出此程式區塊(大括號外)
        //可簡寫為 if(death) return;
        if (death == true) 
        {
            return;
        }

        //判斷如果玩家按下左健
        //滑鼠左鍵、手機觸控 Mouse0

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            aud.PlayOneShot(soundJump, 1.5f);  //喇叭.播放一次音效(音效,音量)

            // 重置重力加速度，讓剛體設定重新啟動，使重力影響不疊加，每次點擊都跳躍一樣的高度
            rb2D.Sleep();
            
            // 開始遊戲時啟動重力環境(初始為無重力狀態 gravityScale = 0)
            // 小雞剛體.重力數值屬性 指定為1
            rb2D.gravityScale = 1;

            //小雞往上跳
            //對小雞的剛體施加一個y軸(向上)方向的推力
            //小雞剛體.增加推力方法.(二維向量(上下,左右));
            rb2D.AddForce(new Vector2(0, jumpHeight));

            // SetActive 顯示物件
            goScore.SetActive(true);  //顯示分數
            goGM.SetActive(true);     //顯示(啟動)遊戲管理器


        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            aud.PlayOneShot(soundJump, 1.5f);  //喇叭.播放一次音效(音效,音量)

            // 重置重力加速度，讓剛體設定重新啟動，使重力影響不疊加，每次點擊都跳躍一樣的高度
            rb2D.Sleep();

            // 開始遊戲時啟動重力環境(初始為無重力狀態 gravityScale = 0)
            // 小雞剛體.重力數值屬性 指定為1
            rb2D.gravityScale = 1;

            //小雞往上跳
            //對小雞的剛體施加一個y軸(向上)方向的推力
            //小雞剛體.增加推力方法.(二維向量(上下,左右));
            rb2D.AddForce(new Vector2(0, -jumpHeight));
        }


        //print(rb2D.velocity);
        //Rigidbody2D. SetRoatation(float) 設定角度[方法](角度)
        //Rigidbody2D.velocity 剛體的加速度[屬性] (二維向量 x,y) 
        //velocity.y y軸方向的加速度 該項目用來抓出一個向上為正，向下為負的值，做為一次同時控制旋轉角度正負的基值
        rb2D.SetRotation(angle * rb2D.velocity.y);

    }

    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    public void Dead()
    {
       
        death = true;
        gm.GameOver();  
    }

    //固定幀數 要控制「物理」請寫在此事件內
    private void Update()
    {
        Jump();
    }

    //事件:碰撞開始 - 碰撞開始時執行一次 (碰撞類別 名稱) 存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D hit)
    {
        // 碰撞物件 遊戲物件 名稱
        print(hit.gameObject.name);

        if (hit.gameObject.name == "地板" )
        {
            Dead();
            aud.PlayOneShot(soundHit, 2.5f);
        }
    }

    // 事件:觸發開始 - 物件必須勾選 IsTrigger (穿透物件)
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.name == "水管 下" || hit.gameObject.name == "水管 上")
        {
            Dead();
            aud.PlayOneShot(soundHit, 2.5f);
        }
    }
    // 事件:觸發離開 - 物件離開觸發區域執行一次  物件必須勾選 IsTrigger(穿透物件)
    private void OnTriggerExit2D(Collider2D hit)
    {
        if(hit.gameObject.name == "加分" && !death ) 
        {
            gm.AddScore();
            aud.PlayOneShot(soundAdd, 1.5f);
        }

    }

}
