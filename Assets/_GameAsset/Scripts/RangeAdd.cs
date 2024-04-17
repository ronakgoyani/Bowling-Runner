using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAdd : MonoBehaviour
{
    public bool isPlusShot = true;
    public float rangeValue;
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
            BallGen.instate.ballRange += rangeValue;
            gameObject.GetComponentInParent<MeshRenderer>().gameObject.SetActive(false);
            textObj.SetActive(false);
        }
    }
}