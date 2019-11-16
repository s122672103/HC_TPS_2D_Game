
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera cd;
    public AudioSource music;

    private void Start()

    {

        //使用靜態成員 - 屬性
        print("隨機:" + Random.value);

        //使用靜態成員 - 屬性 數學類別. PI (Mathf)
        print("PI:" + Mathf.PI);


        //使用靜態成員 - 方法
        print("隨機範圍:" + Random.Range(1, 100));

        print("絕對值:" + Mathf.Abs(-99));


        //非靜態成員
        //需先給予「欄位」存放實體物件 在unity中拖拉可被辨識的物件進入欄位才不會發生ERROR
        print("物件A的座標:" + transformA.position);

        // transformB.position = new Vector3(-2, 0, 0); 透過程式修改物件B座標的用法
        // transformB.Rotate(0, 0, 10); 透過程式修改物件B旋轉角度的用法

        print("物件B的座標:" + transformB.position);

        print("攝影機的深度:" + cd.depth);

        music.Stop();


    }

    
}
