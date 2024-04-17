using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinRotateParent : MonoBehaviour
{
    // Start is called before the first frame update
   public float RotateSpeed;
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateSpeed * Time.deltaTime,0,0);
    }
}
