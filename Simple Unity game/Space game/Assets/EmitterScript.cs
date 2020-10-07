using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{
   public GameObject asteroid1;
   public GameObject asteroid2;
   public GameObject asteroid3;
   public GameObject enemy;
   public GameObject bonus;
   public float minDelay, maxDelay; // задержка между астероидами
   public float minEnemyDelay, maxEnemyDelay;
   public float minBonusDelay, maxBonusDelay;

   float nextlaunchTime;
   float nextEnemyLaunchTime;
   float nextBonusLaunchTime;

    // Update is called once per frame
    // эмиттер, который создает астероиди, врагов и бонусы
    void Update()
    {

        if (!GameControllerScript.instance.getIsStarted()) // остановка игры пока не нажата кнопка "начать"
        {
            return;
        }

        float positionZ = transform.position.z;
        float positionX = Random.Range(-transform.localScale.x/2, transform.localScale.x/2);

        float asteroid = Random.Range(1, 4);

        if(Time.time > nextlaunchTime)
        {
            if(asteroid == 1)
                Instantiate(asteroid1, new Vector3(positionX, 10, positionZ), Quaternion.identity);
            if(asteroid == 2)
                Instantiate(asteroid2, new Vector3(positionX, 10, positionZ), Quaternion.identity);
            if(asteroid == 3)
                Instantiate(asteroid3, new Vector3(positionX, 10, positionZ), Quaternion.identity);
        nextlaunchTime = Time.time + Random.Range(minDelay, maxDelay);
        }
        if(Time.time > nextEnemyLaunchTime)
        {
            Instantiate(enemy, new Vector3(positionX, 10, positionZ), Quaternion.Euler(0, 180, 0));
            nextEnemyLaunchTime = Time.time + Random.Range(minEnemyDelay, maxEnemyDelay);
        }

        if(Time.time > nextBonusLaunchTime)
        {
            Instantiate(bonus, new Vector3(positionX, 10, positionZ), Quaternion.Euler(0, 90, 100));
            nextBonusLaunchTime = Time.time + Random.Range(minBonusDelay, maxBonusDelay);
        }
    }
}
