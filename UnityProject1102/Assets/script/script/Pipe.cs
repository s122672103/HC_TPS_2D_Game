
//繼承:可享有繼承類別的成員
public class Pipe : Ground
{
    private void Start()
    {
        //gameObject此類別本身的物件
        Destroy(gameObject, 5.0f);
    }

}
