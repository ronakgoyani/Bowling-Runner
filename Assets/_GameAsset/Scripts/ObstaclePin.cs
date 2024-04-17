using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            FX.instance.SmokeFX(collision.transform);
            Destroy(collision.gameObject);
        }
    }
}
