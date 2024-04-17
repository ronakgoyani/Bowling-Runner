using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CanvasScript : MonoBehaviour
{
    public static CanvasScript instance;
    public Text scoreT;
    public Text levelT;
    public GameObject gameOverPanel;
    public GameObject gameWinpanel;
    public int _score = 0;
    public Animator cashImg;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
            _score = PlayerPrefs.GetInt("Score");

        scoreT.text = _score.ToString();
        gameOverPanel.SetActive(false);
        gameWinpanel.SetActive(false);
    }

    public void GameOverPanelFn()
    {
        gameOverPanel.SetActive(true);
        PlayerPrefs.SetInt("Score", _score);
    }
    public void GameWinPanelFN()
    {
        //MainObjectScript.instate.level++;
        //PlayerPrefs.SetInt("levelNoIs", MainObjectScript.instate.level);
        gameWinpanel.SetActive(true);
        PlayerPrefs.SetInt("Score", _score);
    }
    public void RetryBtn()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
   public void NextLevelBtn()
    {
        gameWinpanel.SetActive(false);
        MainObjectScript.instate.GameWin();
    }
}