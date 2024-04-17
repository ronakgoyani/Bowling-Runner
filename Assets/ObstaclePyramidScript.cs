using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObstaclePyramidScript : MonoBehaviour
{
    public int num;
    Rigidbody rb;
    TextMeshPro numTextIs;
    GameObject imageIs;
    
    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        numTextIs = gameObject.transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
        imageIs = gameObject.transform.GetChild(0).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            num--;
            numTextIs.text = num.ToString();
            FX.instance.SmokeFX(collision.transform );
            if (num <= 0)
            {
                rb.isKinematic = false;
                rb.AddExplosionForce(300, collision.transform.position, 100);
                imageIs.SetActive(false);
                Destroy(gameObject,3);
            }
            Destroy(collision.gameObject);
        }
    }
}
