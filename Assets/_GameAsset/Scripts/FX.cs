using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX : MonoBehaviour
{
    public static FX instance;

    public GameObject smoke;
    public GameObject spark;
    public GameObject plsuGateFX;
    public GameObject minusGateFX;
    public GameObject cashCollectFX;

    private void Awake()
    {
        instance = this;
    }

    public void SmokeFX(Transform pos)
    {
        GameObject fx = Instantiate(smoke, pos.position, Quaternion.identity);
        fx.transform.localScale = new Vector3(0.12f, 0.12f, 0.12f);
    }

    public void SparkFX(Transform pos)
    {
        GameObject fx = Instantiate(spark, pos.position, Quaternion.identity);
        fx.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void GateFX(bool isPlus)
    {
        GameObject fx;
        if (isPlus)
            fx = Instantiate(plsuGateFX, PlayerScript.instance.fxTransform);
        else
            fx = Instantiate(minusGateFX, PlayerScript.instance.fxTransform);

        fx.transform.localEulerAngles = new Vector3(0, 0, 0);
    }

    public void CollectCashFX(Transform pos)
    {
        GameObject fx = Instantiate(cashCollectFX, pos.position + new Vector3(0, 0.2f, 0.3f), Quaternion.identity);
        fx.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }
}