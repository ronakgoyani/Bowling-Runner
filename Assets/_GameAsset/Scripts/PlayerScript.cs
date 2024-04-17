using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation.Examples;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript instance;

    public Transform moveHorizontal;
    public float Speed;
    public Animator playerAnimator;
    public Transform fxTransform;
    public string aniName;
    public PathFollower pathSpeed;
    Vector3 FPos;
    public float clampPos;

    public bool dualBallBool;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        dualBallBool = false;
        
        playerAnimator.Play("IdleThrowBall");
        aniName = "IdleThrowBall";
        pathSpeed.speed = 0;
    }
    
    void FixedUpdate()
    {
        if (!MainObjectScript.instate.ballBool)
        {
            //gameObject.transform.position += new Vector3(0, 0, Speed * Time.deltaTime);

            if (Input.GetMouseButtonDown(0))
            {
                FPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 SPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
                Vector3 diff = SPos - FPos;
                // float X = Mathf.Lerp(transform.position.x, diff.x, 2f * Time.deltaTime); (player smooth Extra....;)

                moveHorizontal.transform.localPosition += new Vector3(diff.x *80* Time.deltaTime, 0, 0);
                moveHorizontal.transform.localPosition = new Vector3(Mathf.Clamp(moveHorizontal.transform.localPosition.x, -clampPos, clampPos), 0, 0);
                FPos = SPos;
            }
            //if (Input.GetMouseButtonUp(0))
            //{
            //    FPos = new Vector3(0, 0, 0);
            //}
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameOver")
        {

            MainObjectScript.instate.ballBool = true;
            pathSpeed.speed = 0;
            playerAnimator.Play("Flying Fall Death");
            aniName = "Flying Fall Death";
            CanvasScript.instance.GameOverPanelFn();
            MainObjectScript.instate.rightBall.SetActive(false);
            MainObjectScript.instate.leftBall.SetActive(false);
        }
        if (other.gameObject.tag == "ForwordThrow")
        {
            MainObjectScript.instate.ballBool = true;
            pathSpeed.speed = 0;
            playerAnimator.Play("Flying Fall Death");
            aniName = "Flying Fall Death";
            CanvasScript.instance.GameOverPanelFn();
            MainObjectScript.instate.rightBall.SetActive(false);
            MainObjectScript.instate.leftBall.SetActive(false);
        }
        if (other.gameObject.tag == "GameWinAni")
        {
            playerAnimator.speed = 1;
            pathSpeed.speed = 0;
            transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z - 0.3f); // player Win Pos
            MainObjectScript.instate.ballBool = true;
            int RandomNum;
            RandomNum = Random.Range(0,2);
            if (RandomNum == 0)
            {
                playerAnimator.Play("Victory");
                aniName = "Victory";
            }
            else
            {
                playerAnimator.Play("SwingDancingAni");
                aniName = "SwingDancingAni";
            }
            MainObjectScript.instate.rightBall.SetActive(false);
            MainObjectScript.instate.leftBall.SetActive(false);
            CanvasScript.instance.GameWinPanelFN();
        }
    }

   
}
