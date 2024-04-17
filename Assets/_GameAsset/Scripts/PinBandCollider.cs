using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinBandCollider : MonoBehaviour
{
    public TextMeshProUGUI pinBandText;
    public Text pinHitCountT;
    private Animator band;
    public int pinBandNo;
    public List<Rigidbody> pinRb = new List<Rigidbody>();

    private void Start()
    {
        band = GetComponent<Animator>();
      
        if (pinBandNo == 0)
            pinHitCountT.text = "";
        else
            pinHitCountT.text = pinBandNo.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            FX.instance.SmokeFX(collision.gameObject.transform);
            Destroy(collision.gameObject);
            pinBandNo--;
           
            pinHitCountT.text = pinBandNo.ToString();
            pinHitCountT.GetComponent<Animator>().Play("MoveTextUp");
            if (pinBandNo <= 0)
            {
                for (int i = 0; i < pinRb.Count; i++)
                {
                    pinRb[i].isKinematic = false;
                }

                band.Play("PinBand");
                gameObject.GetComponent<MeshCollider>().enabled = false;
             
                pinHitCountT.text = "";
                Destroy(collision.gameObject);
            }
        }
    }
}
