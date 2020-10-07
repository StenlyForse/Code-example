using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text livesText;
    public UnityEngine.UI.Text superWeaponText;
    public UnityEngine.UI.Button startButton;
    public GameObject menu;
    public static GameControllerScript instance;



    bool isStarted = false; // запущена ли игра
    int score = 0;
    int lives = 1;
    
    public bool getIsStarted()
    {
        return isStarted;
    }

    public void increaseScore(int increment)
    {
        score += increment;
        scoreText.text = "Score: " + score;
    }

    public void increaseLives(int live)
    {
        lives += live;
        livesText.text = "Lives: " + lives;
    }

    public void superWeaponReady(bool ready)
    {
        if (ready)
            superWeaponText.enabled = true;
        else
            superWeaponText.enabled = false;
    }

    private void Start() 
    {
        instance = this;
        AudioSource sound = GetComponent<AudioSource>();
        startButton.onClick.AddListener(delegate
        {
            menu.SetActive(false);
            isStarted = true;
            sound.Play();
        });
    }
}
