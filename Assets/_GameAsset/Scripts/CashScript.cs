using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashScript : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            MainObjectScript.instate.TenNumber(value);
            CanvasScript.instance._score += value;
            CanvasScript.instance.scoreT.text = CanvasScript.instance._score.ToString();
            CanvasScript.instance.cashImg.Play("ScaleUp");
            FX.instance.CollectCashFX(other.transform);
            Destroy(gameObject);
        }
    }
}
