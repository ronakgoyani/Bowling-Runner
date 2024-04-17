using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftScript : MonoBehaviour
{
    public int Number;
    public Collider giftCollider;
    public Animator giftAnimator;
    public Text giftT;

    public GameObject TextSprite;

    private void Start()
    {
        TextSprite.SetActive(true);
        giftT.text = Number.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Number--; 
            giftT.text = Number.ToString();
            Destroy(other.gameObject);
            FX.instance.SmokeFX(other.transform);
            if (Number <= 0)
            {
                giftT.text = "";
                giftAnimator.Play("Open");
                TextSprite.gameObject.SetActive(false);
                giftCollider.enabled = false;
            }
        }
    }
}
