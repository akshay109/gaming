using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameover = false;
    int score = 0;
    public Text scoreText;
    public Text scoreTextPanel;
    public GameObject Gameoverpanel;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;

        }
    }

    public void GameOver()
    {
        gameover = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
        Gameoverpanel.SetActive(true);
        scoreTextPanel.text = "Score= " + score;
    }
    public void IncrementScore()
    {
        if (!gameover)
        {
            score++;
            print(score);
            scoreText.text = score.ToString();
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }





}
