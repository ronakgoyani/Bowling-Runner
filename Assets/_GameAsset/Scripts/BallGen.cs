using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGen : MonoBehaviour
{
    // Start is called before the first frame update

    public static BallGen instate;
    public GameObject mainBall;

    public bool dualBool;
   
    public float ballRange;
    public float ballSpeed;
  
    private void Awake()
    {
        instate = this;
    }
    // bool enemyBool;
    void Start()
    {
        dualBool = false;
    }
    public void GenBallR()
    {
        GameObject rightGenBall = Instantiate(mainBall);
        rightGenBall.transform.position = MainObjectScript.instate.rightBall.transform.position;
    }
    public void GenBallL()
    {
        GameObject leftGenBall = Instantiate(mainBall);
        leftGenBall.transform.position = MainObjectScript.instate.leftBall.transform.position;
    }

}
