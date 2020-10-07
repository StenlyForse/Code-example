using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

    public GameObject asteroidExplosion;
    public GameObject shipExplosion;
    public float rotationSpeed;
    public float minSpeed, maxSpeed;
    public float minSize, maxSize;
    // Start is called before the first frame update

    float size;
    void Start()
    {
        Rigidbody asteroid = GetComponent<Rigidbody>();
        asteroid.angularVelocity = Random.insideUnitSphere * rotationSpeed;
        float asteroidSpeed = Random.Range(minSpeed, maxSpeed);
        asteroid.velocity = new Vector3(0, 0, -asteroidSpeed);
        
        size = Random.Range(minSize, maxSize);
        asteroid.transform.localScale *= size;
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Asteroid" || other.tag == "Boundary" || other.tag == "Bonus") // чтобы не сталкивался с другими астероидами, боундарькой и бонусами
        {
            return;
        }

         if(other.tag == "PlayerShot")
            GameControllerScript.instance.increaseScore(1);
        Destroy(gameObject);
        //Destroy(other.gameObject);
        
        

        GameObject explosion =  Instantiate(asteroidExplosion, transform.position, Quaternion.identity); //взрыв
        explosion.transform.localScale *= size;
       /* if (other.tag == "Player")
        {
            Instantiate(shipExplosion, other.transform.position, Quaternion.identity);
        }*/

        
    }
   
}

