using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusTenScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyPlusTenCo(gameObject));
    }
    IEnumerator DestroyPlusTenCo(GameObject plusTen)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(plusTen);
    }
} 