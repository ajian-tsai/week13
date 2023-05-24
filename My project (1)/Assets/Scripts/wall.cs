using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private float speed = 8.0f;
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(gameObject.transform.position.z > 10)
        {
            Destroy(gameObject);
        }
    }
}
