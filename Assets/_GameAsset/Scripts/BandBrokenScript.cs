using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandBrokenScript : MonoBehaviour
{
    public GameObject brokenObj;
    List<Rigidbody> brokenObjRB = new List<Rigidbody>();
 
    private void Start()
    {
        for (int i = 0; i < brokenObj.transform.childCount; i++)
        {
            brokenObjRB.Add(brokenObj.transform.GetChild(i).gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            FX.instance.SparkFX(collision.gameObject.transform);
            gameObject.SetActive(false);
            brokenObj.SetActive(true);
            for (int i = 0; i < brokenObjRB.Count; i++)
            {
                brokenObjRB[i].AddExplosionForce(200, collision.transform.position, 200);
            }
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Debug.Log("GameOver");
    //    }
    //}
}