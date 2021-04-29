using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Quiz : MonoBehaviour
{
    public Toggle defaultToggle;
    public Toggle OptionOne;
    public Toggle OptionTwo;
    public Toggle OptionThree;
    public Toggle OptionFour;
    public Toggle OptionFive;
    public Button Submit;
    public Text test;

    private int answer;

    System.Random random = new System.Random();

    bool submitBtn;

    void Start()
    {
        answer = random.Next(5) + 1;
        Debug.Log(answer);
        test.text = "Select Option " + answer + " and then hit Submit.";
    }

    public void onSubmit()
    {
        if (defaultToggle.isOn == true)
        {
            return;
        }

        switch (answer)
        {
            case 1:
                if (OptionOne.isOn == true)
                {
                    correctAnswer();
                } else if (OptionOne.isOn == false)
                {
                    incorrectAnswer();
                }
                break;
            case 2:
                if (OptionTwo.isOn == true)
                {
                    correctAnswer();
                }
                else if (OptionTwo.isOn == false)
                {
                    incorrectAnswer();
                }
                break;
            case 3:
                if (OptionThree.isOn == true)
                {
                    correctAnswer();
                }
                else if (OptionThree.isOn == false)
                {
                    incorrectAnswer();
                }
                break;
            case 4:
                if (OptionFour.isOn == true)
                {
                    correctAnswer();
                }
                else if (OptionFour.isOn == false)
                {
                    incorrectAnswer();
                }
                break;
            case 5:
                if (OptionFive.isOn == true)
                {
                    correctAnswer();
                }
                else if (OptionFive.isOn == false)
                {
                    incorrectAnswer();
                }
                break;
        }

        /*if (OptionOne.isOn == true && answer == 1)
        {
            correctAnswer();
        } else if (OptionTwo.isOn == true && answer == 2)
        {
            correctAnswer();
        } else if (OptionThree.isOn == true && answer == 3)
        {
            correctAnswer();
        } else if (OptionFour.isOn == true && answer == 4)
        {
            correctAnswer();
        } else if (OptionFive.isOn == true && answer == 5)
        {
            correctAnswer();
        } else if (defaultToggle.isOn == true)
        {
            return;
        } else
        {
            Debug.Log("Wrong");
            incorrectAnswer();
        }*/
    }

    private void correctAnswer()
    {
        defaultToggle.isOn = true;
        answer = random.Next(5) + 1;
        Debug.Log(answer);
        test.text = "Good job! Now select Option " + answer + " and then hit Submit.";
    }

    private void incorrectAnswer()
    {
        defaultToggle.isOn = true;
        answer = random.Next(5) + 1;
        Debug.Log(answer);
        test.text = "Mmm, that wasn't correct. Try to select Option " + answer + " and then hit Submit.";
    }

    public void FixedUpdate()
    {
        if (submitBtn == true)
        {
            onSubmit();
            
            submitBtn = (false);
        }
    }

    public void OnSubmitButton(InputValue value)
    {
        submitBtn = value.isPressed;
    }
}
