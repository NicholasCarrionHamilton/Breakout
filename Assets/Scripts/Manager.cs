using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livestxt;
    public Text scoretxt;
    public bool gameOver;
    public GameObject Panel;
    public int Bricks;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        livestxt.text = "Lives: " + lives;
        scoretxt.text = "Score: " + score;
        Bricks = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateNumberOfBricks()
    {
        Bricks--;
        if (Bricks <=0)
        {
            Win();
        }
    }

    public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    



    public void UpdateLives(int changeInLives) {
        lives += changeInLives;
        if (lives <= 0) {
            lives = 0;
            GameOver();
        }
        

        livestxt.text = "Lives: " + lives;
    }
    public void UpdateScore(int points)
    {
        score += points;
        scoretxt.text = "Score: " + score;
    }

    void GameOver()
    {
        gameOver = true;
        Panel.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

 public void Quit()
    {
        Application.Quit();
    }

}

