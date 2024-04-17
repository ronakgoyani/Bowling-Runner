using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using PathCreation.Examples;

public class MainObjectScript : MonoBehaviour
{
    public static MainObjectScript instate;
    public bool ballBool;
    public GameObject rightBall;
    public GameObject leftBall;
    public int level = 1;

    public GameObject ten;
    public GameObject plusFifty;
    public bool tenOrFiftyBool;
    private void Awake()
    {
        Application.targetFrameRate = 24;
        instate = this;
    }

    void Start()
    {
        level = Random.Range(10, 100);
        //if (PlayerPrefs.HasKey("levelNoIs"))
        //{
        //    level = PlayerPrefs.GetInt("levelNoIs");
        //    CanvasScript.instance.levelT.text = "Level " + level;
        //}
        //else
        //{

        //    CanvasScript.instance.levelT.text = "Level " + level;
        //}
        CanvasScript.instance.levelT.text = "Level " + level;
        ballBool = true;
        rightBall.SetActive(false);
        leftBall.SetActive(false);
    }
    private void Update()
    {

    }
    public void PlayBtnClick()
    {
        ballBool = false;
        PlayerScript.instance.playerAnimator.Play("Bowling_Run");
        PlayerScript.instance.aniName = "Bowling_Run";
        PlayerScript.instance.pathSpeed.speed = PlayerScript.instance.Speed;
        rightBall.SetActive(true);
    }

    public void GameWin()
    {
        SceneManager.LoadScene(0);
    }

    public void TenNumber(int value)
    {
        GameObject tx = Instantiate(ten);
        tx.transform.position = new Vector3(PlayerScript.instance.transform.position.x + 0.709f, 0.258f, PlayerScript.instance.transform.position.z - 0.355f);

        tx.GetComponentInChildren<TextMeshPro>().text = "+" + value;
        tx.transform.GetComponentInChildren<Animator>().Play("+10Animation_anim_anim");

    }

}
