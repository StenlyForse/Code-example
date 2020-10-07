using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    Rigidbody enemyShip;
    public GameObject lazerShot;
    public Transform lazerGun;
    public float speed;
    public float shotDelay;
    public GameObject shipExplosion;


    float nextShotTime;


    // Start is called before the first frame update
    void Start()
    {
        enemyShip = GetComponent<Rigidbody>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary" || other.tag == "EnemyLazerShot" || other.tag == "Bonus")
        {
            return;
        }

        if(other.tag == "PlayerShot")
            GameControllerScript.instance.increaseScore(2);
        Destroy(gameObject);
        //Destroy(other.gameObject);
        GameObject explosion =  Instantiate(shipExplosion, transform.position, Quaternion.identity);
    }

    void Update()
    {
        enemyShip.velocity = new Vector3(0, 0, -speed);

        if(Time.time > nextShotTime)
        {
            Instantiate(lazerShot,lazerGun.position, Quaternion.identity);
            nextShotTime = Time.time + shotDelay;
        }

        

    }
}
