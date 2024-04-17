using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    public static CameraMove instate;

    private void Awake()
    {
        instate = this;
    }
    void LateUpdate()
    {
       
        if (!MainObjectScript.instate.ballBool)
        {   
          
            //transform.position = new Vector3(0, 0, PlayerScript.instance.transform.position.z);
            float MoveXIS = PlayerScript.instance.moveHorizontal.transform.position.x;

            float Smooth = Mathf.Lerp(transform.position.x, MoveXIS,5f * Time.deltaTime);

            transform.position = new Vector3(Smooth, transform.position.y, PlayerScript.instance.moveHorizontal.transform.position.z);
            transform.localEulerAngles = new Vector3(0,PlayerScript.instance.transform.eulerAngles.y,0);
        }
    }
}




