using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Shake(0.05f, 0.01f);
    }

    public void Shake(float duration, float magnitude)
    {
        StartCoroutine(ShakeCo(duration, magnitude));
    }

    private IEnumerator ShakeCo(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float timer = 0;
        while (timer < duration)
        {
            timer += Time.deltaTime;

            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = new Vector3(originalPos.x + x, originalPos.y + y, originalPos.z);
     
            yield return null;
        }

        transform.localPosition = originalPos;
    }
}
