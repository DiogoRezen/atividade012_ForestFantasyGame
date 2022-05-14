using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControler : MonoBehaviour
{
    public GameObject gameOver;
    public int totalScore;
    public static GameControler instance;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}   

    // Update is called once per frame
