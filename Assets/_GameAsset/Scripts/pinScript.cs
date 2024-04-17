using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pinScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    bool score;
    void Start()
    {
        score = false;
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball"  )
        {
           rb.AddExplosionForce(250, collision.transform.position, 50);
            if (score == false)
            {
                score = true;
                CanvasScript.instance._score = CanvasScript.instance._score+10;
                CanvasScript.instance.scoreT.text = CanvasScript.instance._score.ToString();
                Destroy(this.gameObject, 4f);
                MainObjectScript.instate.TenNumber(10);
            }
        }
        if (collision.gameObject.tag == "Pin")
        {
            if (score==false)
            {
                score = true;
                MainObjectScript.instate.tenOrFiftyBool = false;
                CanvasScript.instance._score = CanvasScript.instance._score+10;
                CanvasScript.instance.scoreT.text = CanvasScript.instance._score.ToString();
                Destroy(this.gameObject, 4f);

                MainObjectScript.instate.TenNumber(10);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddExplosionForce(250,other.transform.position, 50);
            if (score==false)
            {
                score = true;
                MainObjectScript.instate.tenOrFiftyBool = false;
                CanvasScript.instance._score = CanvasScript.instance._score+10;
                CanvasScript.instance.scoreT.text = CanvasScript.instance._score.ToString();
                Destroy(gameObject, 4f);
                MainObjectScript.instate.TenNumber(10);
            }
        }
    }

   
}
