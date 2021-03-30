using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class next_backButtonManager : MonoBehaviour
{
    [Range(0, 3)]public int pageCount = 0;

    public GameObject intro, plantGrow, waterLight, soil, progressCheck, glossary;

    private bool nextPage, backPage, openCloseGlossary;

  

    void Start()
    {
        intro.SetActive(true);
    }


    void Update()
    {
        if (pageCount == 0)
        {
            intro.SetActive(true);
        }

        else
        {
            intro.SetActive(false);

        }

        if (pageCount == 1)
        {
            plantGrow.SetActive(true);
        }

        else
        {
            plantGrow.SetActive(false);

        }

        if (pageCount == 2)
        {
            waterLight.SetActive(true);
        }
        else
        {
            waterLight.SetActive(false);

        }

        if (pageCount == 3)
        {
            soil.SetActive(true);
        }
        else
        {
            soil.SetActive(false);
        }
    }

    public void FixedUpdate()
    {
        if (nextPage && pageCount < 3)
        {
            pageCount += 1;
            Debug.Log(pageCount);
            nextPage = (false);
            glossary.SetActive(false);
        }

        if (backPage && pageCount > 0)
        {
            pageCount -= 1;
            Debug.Log(pageCount);
            backPage = (false);
            glossary.SetActive(false);
        }

        if (openCloseGlossary)
        {
            if(glossary.activeSelf)
            {
                glossary.SetActive(false);
            }
            else
            {
                glossary.SetActive(true);
            }
            openCloseGlossary = false;
        }
    }

    public void OnNextPage(InputValue inputValue)
    {

        nextPage = inputValue.isPressed;
        //pageCount += 1;
        //Debug.Log(pageCount);
    }

    public void OnBackPage(InputValue inputValue)
    {
        backPage = inputValue.isPressed;
        //pageCount -= 1;
        //Debug.Log(pageCount);
    }

    public void OnGlossaryOpenClose(InputValue inputValue)
    {
        openCloseGlossary = inputValue.isPressed;
    }
}
