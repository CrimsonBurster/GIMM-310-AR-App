using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class next_backButtonManager : MonoBehaviour
{
    [Range(0, 32)] public int pageCount = 0;

    //count for glossary appearance
    public int totalPage = 0;

    public GameObject ConceptMapPage, glossary, nextPageBtn, backPageBtn, startARBtn;

    public GameObject intro, readMat, vocab, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26;

    public GameObject OpenMenuBtn, CloseMenuBtn, MenuPanel, Lesson1Btn, Lesson2Btn, ConceptMapBtn;

    private bool nextPage, backPage, openCloseGlossary, openMenu, closeMenu, lesson1, lesson2, conceptMap, startAR;

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
            readMat.SetActive(true);
        }

        else
        {
            readMat.SetActive(false);
        }

        if (pageCount == 2)
        {
            vocab.SetActive(true);
        }
        else
        {
            vocab.SetActive(false);
        }

        if (pageCount == 3)
        {
            p1.SetActive(true);
        }
        else
        {
            p1.SetActive(false);
        }

        if (pageCount == 4)
        {
            p2.SetActive(true);
        }
        else
        {
            p2.SetActive(false);
        }

        if (pageCount == 5)
        {
            p3.SetActive(true);
        }
        else
        {
            p3.SetActive(false);
        }

        if (pageCount == 6)
        {
            p4.SetActive(true);
        }
        else
        {
            p4.SetActive(false);
        }

        if (pageCount == 7)
        {
            p5.SetActive(true);
        }
        else
        {
            p5.SetActive(false);
        }

        if (pageCount == 8)
        {
            p6.SetActive(true);
        }
        else
        {
            p6.SetActive(false);
        }

        if (pageCount == 10)
        {
            p7.SetActive(true);
        }
        else
        {
            p7.SetActive(false);
        }

        if (pageCount == 11)
        {
            p8.SetActive(true);
        }
        else
        {
            p8.SetActive(false);
        }

        if (pageCount == 12)
        {
            p9.SetActive(true);
        }
        else
        {
            p9.SetActive(false);
        }

        if (pageCount == 13)
        {
            p10.SetActive(true);
        }
        else
        {
            p10.SetActive(false);
        }

        if (pageCount == 14)
        {
            p11.SetActive(true);
        }
        else
        {
            p11.SetActive(false);
        }

        if (pageCount == 15)
        {
            p12.SetActive(true);
        }
        else
        {
            p12.SetActive(false);
        }

        if (pageCount == 17)
        {
            p13.SetActive(true);
        }
        else
        {
            p13.SetActive(false);
        }

        if (pageCount == 18)
        {
            p14.SetActive(true);
        }
        else
        {
            p14.SetActive(false);
        }

        if (pageCount == 19)
        {
            p15.SetActive(true);
        }
        else
        {
            p15.SetActive(false);
        }

        if (pageCount == 20)
        {
            p16.SetActive(true);
        }
        else
        {
            p16.SetActive(false);
        }

        if (pageCount == 21)
        {
            p17.SetActive(true);
        }
        else
        {
            p17.SetActive(false);
        }

        if (pageCount == 22)
        {
            p18.SetActive(true);
        }
        else
        {
            p18.SetActive(false);
        }

        if (pageCount == 24)
        {
            p19.SetActive(true);
        }
        else
        {
            p19.SetActive(false);
        }

        if (pageCount == 25)
        {
            p20.SetActive(true);
        }
        else
        {
            p20.SetActive(false);
        }

        if (pageCount == 26)
        {
            p21.SetActive(true);
        }
        else
        {
            p21.SetActive(false);
        }

        if (pageCount == 27)
        {
            p22.SetActive(true);
        }
        else
        {
            p22.SetActive(false);
        }

        if (pageCount == 28)
        {
            p23.SetActive(true);
        }
        else
        {
            p23.SetActive(false);
        }

        if (pageCount == 29)
        {
            p24.SetActive(true);
        }
        else
        {
            p24.SetActive(false);
        }

        if (pageCount == 30)
        {
            p25.SetActive(true);
        }
        else
        {
            p25.SetActive(false);
        }

        if (pageCount == 31)
        {
            p26.SetActive(true);
        }
        else
        {
            p26.SetActive(false);
        }
        //end of pages

        //concept map placement
        if (pageCount == 9)
        {
            ConceptMapPage.SetActive(true);
        }
        else if (pageCount == 16)
        {
            ConceptMapPage.SetActive(true);
        }
        else if (pageCount == 23)
        {
            ConceptMapPage.SetActive(true);
        }
        else if (pageCount == 32)
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

        if (nextPage && pageCount < 32)
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
        if (pageCount == 32)
        {
            startARBtn.gameObject.SetActive(true);
        }
        else
        {
            startARBtn.gameObject.SetActive(false);
        }

        if (openCloseGlossary)
        {
            if (glossary.activeSelf)
            {
                glossary.SetActive(false);
            }
            else
            {
                glossary.SetActive(true);
            }
            openCloseGlossary = false;
        }

        if (lesson1 && pageCount != 3)
        {
            pageCount = 3;
            Debug.Log("lesson1 active");
            lesson1 = false;
        }

        if (lesson2 && pageCount != 10)
        {
            pageCount = 10;
            lesson2 = false;
        }

        if (conceptMap && pageCount >= 23)
        {
            pageCount = 23;
            conceptMap = false;
        }
        else if(conceptMap && pageCount >= 16)
        {
            pageCount = 16;
            conceptMap = false;
        }
        else if (conceptMap && pageCount >= 9)
        {
            pageCount = 9;
            conceptMap = false;
        }

        if (openMenu)
        {
            Animator animator = MenuPanel.GetComponent<Animator>();
            if (animator != null)
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

        if (startAR)
        {
            SceneManager.LoadScene("arSequence");
            startAR = false;
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

    public void OnStartArLesson(InputValue inputValue)
    {
        startAR = inputValue.isPressed;
    }
}
