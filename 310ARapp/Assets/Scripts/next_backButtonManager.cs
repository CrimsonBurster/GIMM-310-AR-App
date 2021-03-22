using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.Controls;

public class next_backButtonManager : MonoBehaviour
{
    public int pageCount = 0;

    public GameObject intro, plantGrow, waterLight, soil, progressCheck;

    

  

    void Start()
    {
        intro.SetActive(true);


        TouchSimulation.Enable();

    }


    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        if(pageCount == 0)
        {
            intro.SetActive(true);
        }
        else if(pageCount == 1)
        {
            plantGrow.SetActive(true);
        }
        else if(pageCount == 2)
        {
            waterLight.SetActive(true);
        }
        else if(pageCount == 3)
        {
            soil.SetActive(true);
        }
    }

    public void nextPage(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            pageCount += 1;
            Debug.Log(pageCount);
        }
    }

    public void backPage(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            pageCount -= 1;
            Debug.Log(pageCount);
        }
    }

}
