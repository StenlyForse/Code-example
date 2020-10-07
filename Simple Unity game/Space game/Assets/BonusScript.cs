using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScript : MonoBehaviour
{

    Rigidbody bonusCube;
    public float speed;
    // Start is called before the first frame update
    // выкидывает бонусы, дающие 1 жизнь
    void Start()
    {
        bonusCube = GetComponent<Rigidbody>();
        bonusCube.velocity = new Vector3(0, 0, -speed);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
            Destroy(gameObject);
        if (other.tag == "Asteroid" || other.tag =="Enemy" || other.tag == "EnemyLAzerShot" || other.tag == "Boundary") // чтобы не сталкивался с другими объектами
            return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
