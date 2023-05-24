using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class viewwall : MonoBehaviour
{
    public GameObject[] wall;
    private int nowWall;
    private float nextWallTime = 0f;
    private float preTime;
    void Start()
    {
        preTime = Time.time;
    }
    void Update()
    {
        if(Time.time - preTime > nextWallTime)
        {
            nowWall = Random.Range(0, 10);//ÀH¾÷Àð
            nextWallTime = Random.Range(6, 9);//5~10¬í¤@­ÓÀð
            Instantiate(wall[nowWall], new Vector3(0, 5, -40), wall[nowWall].transform.rotation);
            preTime = Time.time;
        }
    }
    
}
