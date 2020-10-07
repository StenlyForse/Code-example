using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Rigidbody playerShip;
    public float speed;
    public float xMin, xMax, zMin, zMax;
    public float tilt;
    public GameObject lazerShot; // чем стрелять
    public Transform lazerGun; // откуда стрелять
    public float shotDelay;
    public GameObject shipExplosion;

    public GameObject miniLazerShot;
    public GameObject miniLazerShot2;
    public Transform miniLazerGun1; //объект откуда ведется стрельба
    public Transform miniLazerGun2;
    public float miniShotDelay;
    


    float nextShotTime; //задержки перед следующим выстрелом
    float nextMiniShotTime;
    float bonusSheild = 0;
    float nextSuperWeaponTime;

    // Start is called before the first frame update
    void Start()
    {
        playerShip = GetComponent<Rigidbody>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bonus")
        {
            bonusSheild = bonusSheild + 1;
            GameControllerScript.instance.increaseLives(1);
        }

        if(other.tag == "Enemy" || other.tag == "EnemyLazerShot" || other.tag == "Asteroid")
        {
            if(bonusSheild > 0)
            {
                bonusSheild = bonusSheild - 1;
                GameControllerScript.instance.increaseLives(-1);
                Destroy(other.gameObject);
                return;
                
            }
            else
            {
            GameControllerScript.instance.increaseLives(-1);
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject explosion =  Instantiate(shipExplosion, transform.position, Quaternion.identity);
            //GameControllerScript.instance.increaseScore(1);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSuperWeaponTime) // отображение таблички "супер оружие готово"
            GameControllerScript.instance.superWeaponReady(true);
        else
        GameControllerScript.instance.superWeaponReady(false);

        float moveHorizontal = Input.GetAxis("Horizontal"); //двигается по горизонтали на -1 или +1
        float moveVirtical = Input.GetAxis("Vertical");
        

        playerShip.velocity = new Vector3(moveHorizontal, 0, moveVirtical) * speed; // скорость (движение по горизонтали и вертикали дают от 0 до 1, поэтому умножаем на скорость)
        float restrictedX = Mathf.Clamp(playerShip.position.x, xMin, xMax);  // ограничения по полю
        float restrictedZ = Mathf.Clamp(playerShip.position.z, zMin, zMax);

        playerShip.position = new Vector3(restrictedX, 0, restrictedZ); //задание ограничения, чтобы не выходил за поля

        playerShip.rotation = Quaternion.Euler(tilt * playerShip.velocity.z, 0, -playerShip.velocity.x * tilt); //наклон корабля при поворотах
        
        if(Time.time > nextShotTime && Input.GetButton("Fire1")) // на леквую кнопку мыши огонь
        {
            Instantiate(lazerShot, lazerGun.position, Quaternion.identity); // выстрел
            nextShotTime = Time.time + shotDelay;
        }

        if(Time.time > nextMiniShotTime && Input.GetButton("Fire2")) //активация второго оружия
        {
            Instantiate(miniLazerShot, miniLazerGun1.position, Quaternion.identity);
            Instantiate(miniLazerShot2, miniLazerGun2.position, Quaternion.identity);
            nextMiniShotTime = Time.time + miniShotDelay;

        }

        if(Time.time > nextSuperWeaponTime && Input.GetButtonDown("Jump")) //активация супер-оружия
        {
            
            GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in enemys)
            {
                Destroy(Enemy);
                Instantiate(shipExplosion, Enemy.transform.position, Quaternion.identity);
                nextSuperWeaponTime = Time.time + 12; // задержка следующей активации на 12 секунд
            }
        }
    }
}
