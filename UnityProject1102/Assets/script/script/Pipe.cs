
//繼承:可享有繼承類別的成員
public class Pipe : Ground
{
    private void Start()
    {

        //gameObject此類別本身的物件
        //刪除(物件,延遲時間)
       // Destroy(gameObject, 5.0f);
    }

    //掛此類別的物件需要有元件:Mesh Render
    //在所有攝影機畫面外的時候執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1f);
    }

    //在所有攝影機畫面內的時候執行一次
    private void OnBecameVisible()
    {
        
    }

}
