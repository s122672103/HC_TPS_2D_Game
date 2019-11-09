using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    public int count = 0;

    // 開始事件
    private void Start()
    {
        //使用API方法 ：方法名稱（）;
        print("Hello World");
        print(count);
    }

    //更新事件 視裝置的效能而有所不同
    private void Update()
    {
        print("Hi");
    }
}
