using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inputManager : MonoBehaviour
{
    public GameObject pollen, seed, water, sun, wrongMsg;

    public Button pollenBtn, seedBtn, waterBtn, sunBtn, clearBtn, quizBtn;

    private Vector3 pollenSpwn, seedSpwn, waterSpwn, sunSpwn, pointSpwn;

    private bool pollenHit, seedHit, waterHit, sunHit, clear, toQuiz;

    public GameObject spawnPoint;


    public void Start()
    {
        pointSpwn = spawnPoint.transform.position;
    }
    private void Update()
    {

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

        if (clear)
        {
            pollenBtn.gameObject.SetActive(true);
            seedBtn.gameObject.SetActive(true);
            waterBtn.gameObject.SetActive(true);
            sunBtn.gameObject.SetActive(true);
            wrongMsg.gameObject.SetActive(false);
            clear = (false);
        }

        if (toQuiz)
        {
            SceneManager.LoadScene("Quiz");
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

    public void OnWrongClear(InputValue inputValue)
    {
        clear = inputValue.isPressed;
    }

    public void OnMoveToQuiz(InputValue inputValue)
    {
        toQuiz = inputValue.isPressed;
    }
}
