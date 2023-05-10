using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class viewwall : MonoBehaviour
{
    public GameObject[] wall;
    private float timer = 0;
    
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
        if (Input.GetKey("a")) {
            wall[1].gameObject.SetActive(true);
            wall[1].transform.position = new Vector3(0, 5, -20);
            wall[1].transform.Translate( Vector3.forward * Time.deltaTime*2 );
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > 5)
            {
                wall[1].gameObject.SetActive(false);
                timer = 0;
            }
        }
        
    }
    
}
