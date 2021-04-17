using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class inputManager : MonoBehaviour
{
    public GameObject target, pollen, seed, water, sun;

    public Button pollenBtn, seedBtn, waterBtn, sunBtn;

    private Vector3 pollenSpwn, seedSpwn, waterSpwn, sunSpwn, pointSpwn;

    private bool pollenHit, seedHit, waterHit, sunHit;

    public GameObject spawnPoint;

    public void Start()
    {
        pollenSpwn = pollenBtn.transform.position;
        seedSpwn = seedBtn.transform.position;
        waterSpwn = waterBtn.transform.position;
        sunSpwn = sunBtn.transform.position;
        pointSpwn = spawnPoint.transform.position;
    }
    private void Update()
    {
        //if(GameObject.Find("pollenTest"))
        //{
        //    pollen.transform.position = Vector3.Slerp(this.transform.position, target.transform.position, tossSpeed);
        //}
    }

    public void FixedUpdate()
    {
        if (pollenHit)
        {
            Instantiate(pollen, pointSpwn, Quaternion.identity);
            pollenHit = (false);
        }

        if (seedHit)
        {
            Instantiate(seed, pointSpwn, Quaternion.identity);
            seedHit = (false);
        }

        if (waterHit)
        {
            Instantiate(water, pointSpwn, Quaternion.identity);
            waterHit = (false);
        }

        if (sunHit)
        {
            Instantiate(sun, pointSpwn, Quaternion.identity);
            sunHit = (false);
        }

    }

    public void OnPollenButton(InputValue inputValue)
    {
        pollenHit = inputValue.isPressed;
    }

    public void OnSeedButton(InputValue inputValue)
    {
        seedHit = inputValue.isPressed;
    }

    public void OnWaterButton(InputValue inputValue)
    {
        waterHit = inputValue.isPressed;
    }

    public void OnSunButton(InputValue inputValue)
    {
        sunHit = inputValue.isPressed;
    }

    //public void SummonPollen()
    //{
    //    Instantiate(pollen, pointSpwn, Quaternion.identity);
    //}

}
