using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplashTrigger : MonoBehaviour
{
    public GameObject waterSplash;

    void OnTriggerEnter(Collider other)
    {
        waterSplash.SetActive(true);
        StartCoroutine(finishSplashSFX());
    }

    IEnumerator finishSplashSFX()
    {
        yield return new WaitForSeconds(3);
        waterSplash.SetActive(false);
    }
}
