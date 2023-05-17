using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class viewwall : MonoBehaviour
{
    public GameObject[] wall;
   // private float timer = 0;
    public float speed = 1.0f;
    private bool hasWall = false;
    private int nowWall;

    void Start()
    {
        for (int i = 0; i < wall.Length; i++)
        {
            wall[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && !hasWall) {
            nowWall = Random.Range(0, 10); // 隨機取牆
            wall[nowWall].gameObject.SetActive(true); // 顯示牆
            wall[nowWall].transform.position = new Vector3(0, 5, -20);  // 牆的初始位置
            hasWall = true;
           /* timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > 5)
            {
                wall[1].gameObject.SetActive(false);
                timer = 0;
            }*/
        }
        if (hasWall)
        {
            wall[nowWall].transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (Input.GetKey("z"))
            {
                wall[nowWall].gameObject.SetActive(false);

                // wall[noWall].
                hasWall = false;
            }
        }
        
    }
    
}
