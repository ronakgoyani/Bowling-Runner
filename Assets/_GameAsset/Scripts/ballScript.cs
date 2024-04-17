using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public static ballScript instate; 
  
    
    private void Awake()
    {
        instate = this; 
    }
    private void Start()
    {
       // rb= GetComponent<>
    }
    void Update()
    {
        if (!MainObjectScript.instate.ballBool)
        {
            transform.Translate(Vector3.forward * BallGen.instate.ballSpeed * Time.deltaTime, CameraMove.instate.transform);
            //transform.position += new Vector3(0, 0, BallGen.instate.ballSpeed * Time.deltaTime);
            Destroy(gameObject,BallGen.instate.ballRange);
        }
    }
}
