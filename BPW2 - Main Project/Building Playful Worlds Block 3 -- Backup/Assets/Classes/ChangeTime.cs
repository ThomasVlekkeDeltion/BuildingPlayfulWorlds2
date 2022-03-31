using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTime : MonoBehaviour
{
    public GameObject directionalLight;
    public GameObject tutorialText;
    public GameObject nightLights;
    public Vector3 day;
    public Vector3 night;

    void Start()
    {
        night = new Vector3(-64.0f, 55.0f, -88.0f);
        day = new Vector3(50.0f, -180.0f, -138.0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            tutorialText.SetActive(false); //remove the tutorial text that says "press E to change time"

            directionalLight.transform.eulerAngles = night;

            nightLights.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E) == true)
        {
            directionalLight.transform.eulerAngles = day;

            nightLights.SetActive(false);
        }
    }
}