using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsBall : MonoBehaviour
{
    public void BalltimingR()
    {
        BallGen.instate.GenBallR();
    }
    public void BalltimingL()
    {
        if (PlayerScript.instance.dualBallBool == true)
        {
            BallGen.instate.GenBallL();
        }
    }
}