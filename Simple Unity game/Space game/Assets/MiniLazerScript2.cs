using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniLazerScript2 : MonoBehaviour
{
   public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-30, 0, speed); // скорость выстрела лазерного
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
