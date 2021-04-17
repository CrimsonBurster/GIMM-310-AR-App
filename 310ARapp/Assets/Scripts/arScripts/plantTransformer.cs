using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantTransformer : MonoBehaviour
{
    public GameObject phase1, phase2, phase3;

    public float plantCount;

    void Start()
    {
        plantCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(plantCount == 1)
        {
            phase1.SetActive(true);
            phase2.SetActive(false);
            phase3.SetActive(false);
        }
        else if(plantCount == 2)
        {
            phase1.SetActive(false);
            phase2.SetActive(true);
            phase3.SetActive(false);
        }
        else if (plantCount == 3)
        {
            phase1.SetActive(false);
            phase2.SetActive(false);
            phase3.SetActive(true);
        }
    }

    public void PlantCountCollision(float collObjectValue)
    {
        plantCount = collObjectValue;
        Debug.Log(plantCount);
    }
}
