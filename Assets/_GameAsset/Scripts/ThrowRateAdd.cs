using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRateAdd : MonoBehaviour
{
    public bool isPlusShot = true;
    public float throwRateIs;
    public GameObject textObj;
    private void Start()
    {
        textObj.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FX.instance.GateFX(isPlusShot);
          //  PlayerScript.instance.playerAni[PlayerScript.instance.aniName].speed+=throwRateIs;
            PlayerScript.instance.playerAnimator.speed += throwRateIs;
            gameObject.GetComponentInParent<MeshRenderer>().gameObject.SetActive(false);
            textObj.SetActive(false);
           // BallGen.instate.rightThrowRate = throwRateIs;
        }
    }
}