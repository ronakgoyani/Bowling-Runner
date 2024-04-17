using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualShot : MonoBehaviour
{
    public bool isPlusShot = true;
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
            MainObjectScript.instate.leftBall.SetActive(true);
            PlayerScript.instance.dualBallBool = true;
            gameObject.GetComponentInParent<MeshRenderer>().gameObject.SetActive(false);
            textObj.SetActive(false);
        }
    }
}