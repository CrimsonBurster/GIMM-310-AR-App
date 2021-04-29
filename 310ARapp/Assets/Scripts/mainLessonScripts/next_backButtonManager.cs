using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class next_backButtonManager : MonoBehaviour
{
    [Range(0, 4)]public int pageCount = 0;

    //count for glossary appearance
    public int totalPage = 0;

    public GameObject intro, plantGrow, waterLight, soil, ConceptMapPage, glossary;

    public GameObject OpenMenuBtn, CloseMenuBtn, MenuPanel,Lesson1Btn, Lesson2Btn, ConceptMapBtn;

    private bool nextPage, backPage, openCloseGlossary, openMenu, closeMenu, lesson1, lesson2, conceptMap;

    void Start()
    {
        intro.SetActive(true);
    }


    void Update()
    {
        //Page Logic
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

        if(pageCount == 4)
        {
            ConceptMapPage.SetActive(true);
        }
        else
        {
            ConceptMapPage.SetActive(false);
        }
    }

    public void FixedUpdate()
    {
        if (nextPage && pageCount < 4)
        {
            pageCount += 1;
            totalPage += 1;
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

        //go to ar
        if(nextPage && pageCount == 4)
        {
            SceneManager.LoadScene("arSequence");
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

        

        if (lesson1 && pageCount != 1)
        {
            pageCount = 1;
            Debug.Log("lesson1 active");
            lesson1 = false;
        }
        //else
        //{
        //    Debug.Log("Less1 is already active");
        //}

        if (lesson2 && pageCount != 2)
        {
            pageCount = 2;
            lesson2 = false;
        }

        if (conceptMap && pageCount != 4)
        {
            pageCount = 4;
            conceptMap = false;
        }

        if (openMenu)
        {
            Animator animator = MenuPanel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
            openMenu = false;
        }

        if (closeMenu)
        {
            Animator animator = MenuPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
            closeMenu = false;
        }
    }

    public void OnNextPage(InputValue inputValue)
    {
        nextPage = inputValue.isPressed;
    }

    public void OnBackPage(InputValue inputValue)
    {
        backPage = inputValue.isPressed;
    }

    public void OnGlossaryOpenClose(InputValue inputValue)
    {
        openCloseGlossary = inputValue.isPressed;
    }

    public void OnPopOutMenu(InputValue inputValue)
    {
        openMenu = inputValue.isPressed;
    }

    public void OnClosePopOut(InputValue inputValue)
    {
        closeMenu = inputValue.isPressed;
    }

    public void OnGoToLessonOne(InputValue inputValue)
    {
        lesson1 = inputValue.isPressed;
    }

    public void OnGoToLessonTwo(InputValue inputValue)
    {
        lesson2 = inputValue.isPressed;
    }

    public void OnGoToConceptMap(InputValue inputValue)
    {
        conceptMap = inputValue.isPressed;
    }

}
