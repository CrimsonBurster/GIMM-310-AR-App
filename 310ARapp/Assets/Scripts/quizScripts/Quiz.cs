using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System.Linq;

public class Quiz : MonoBehaviour
{
    public Toggle defaultToggle;
    public Toggle OptionOne;
    public Toggle OptionTwo;
    public Toggle OptionThree;
    public Button Submit;
    public Text test;
    public Text finish;

    private int answer;
    private int question;

    bool retry = false;
    bool inRetry = false;
    bool restart = false;

    private List<int> questionsLeft = new List<int> { 1, 2, 3, 4, 5 };
    private List<int> incorrectQuestions = new List<int>();
    private List<int> retryQuestions = new List<int>();

    System.Random random = new System.Random();

    bool submitBtn;

    void Start()
    {
        createQuestion();
    }

    public void onSubmit()
    {
        if (retry == true)
        {
            startRetry();
            return;
        }

        if (restart == true)
        {
            SceneManager.LoadScene(0);
        }

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
        }
    }

    public List<int> Filter(List<int> input)
    {
        return input.Where(x => x != question).ToList();
    }

    public void createQuestion()
    {
        newQuestion(questionsLeft);
        var filtered = Filter(questionsLeft);
        questionsLeft = filtered;
    }

    public void createIncorrectQuestion()
    {
        newQuestion(retryQuestions);
        var filtered = Filter(retryQuestions);
        retryQuestions = filtered;
    }

    public void newQuestion(List<int> input)
    {
        int i = 0;

        if (input.Count != 0)
        {
            while (i == 0)
            {
                question = random.Next(5) + 1;
                if (input.Contains(question))
                {
                    i = 1;
                };
            }
        }
        
        switch (question)
        {
            case 1:
                test.text = "What does pollen do?";
                answer = random.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        OptionOne.GetComponentInChildren<Text>().text = "Allows plants to spread seeds";
                        OptionTwo.GetComponentInChildren<Text>().text = "Makes honey";
                        OptionThree.GetComponentInChildren<Text>().text = "Grows new plants";
                        break;
                    case 2:
                        OptionOne.GetComponentInChildren<Text>().text = "Grows new plants";
                        OptionTwo.GetComponentInChildren<Text>().text = "Allows plants to spread seeds";
                        OptionThree.GetComponentInChildren<Text>().text = "Makes honey";
                        break;
                    case 3:
                        OptionOne.GetComponentInChildren<Text>().text = "Makes honey";
                        OptionTwo.GetComponentInChildren<Text>().text = "Grows new plants";
                        OptionThree.GetComponentInChildren<Text>().text = "Allows plants to spread seeds";
                        break;
                }
                break;
            case 2:
                test.text = "Which animals spread pollen?";
                answer = random.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        OptionOne.GetComponentInChildren<Text>().text = "All animals";
                        OptionTwo.GetComponentInChildren<Text>().text = "Birds";
                        OptionThree.GetComponentInChildren<Text>().text = "Bees";
                        break;
                    case 2:
                        OptionOne.GetComponentInChildren<Text>().text = "Bees";
                        OptionTwo.GetComponentInChildren<Text>().text = "All animals";
                        OptionThree.GetComponentInChildren<Text>().text = "Birds";
                        break;
                    case 3:
                        OptionOne.GetComponentInChildren<Text>().text = "Birds";
                        OptionTwo.GetComponentInChildren<Text>().text = "Bees";
                        OptionThree.GetComponentInChildren<Text>().text = "All animals";
                        break;
                }
                break;
            case 3:
                test.text = "What is a pollinator?";
                answer = random.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        OptionOne.GetComponentInChildren<Text>().text = "An animal that spreads pollen from flower to flower";
                        OptionTwo.GetComponentInChildren<Text>().text = "A person that grows flowers";
                        OptionThree.GetComponentInChildren<Text>().text = "A plant that makes pollen";
                        break;
                    case 2:
                        OptionOne.GetComponentInChildren<Text>().text = "A plant that makes pollen";
                        OptionTwo.GetComponentInChildren<Text>().text = "An animal that spreads pollen from flower to flower";
                        OptionThree.GetComponentInChildren<Text>().text = "A person that grows flowers";
                        break;
                    case 3:
                        OptionOne.GetComponentInChildren<Text>().text = "A person that grows flowers";
                        OptionTwo.GetComponentInChildren<Text>().text = "A plant that makes pollen";
                        OptionThree.GetComponentInChildren<Text>().text = "An animal that spreads pollen from flower to flower";
                        break;
                }
                break;
            case 4:
                test.text = "Which part of the plant absorbs the most sunlight?";
                answer = random.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        OptionOne.GetComponentInChildren<Text>().text = "The leaves";
                        OptionTwo.GetComponentInChildren<Text>().text = "The stems";
                        OptionThree.GetComponentInChildren<Text>().text = "The roots";
                        break;
                    case 2:
                        OptionOne.GetComponentInChildren<Text>().text = "The roots";
                        OptionTwo.GetComponentInChildren<Text>().text = "The leaves";
                        OptionThree.GetComponentInChildren<Text>().text = "The stems";
                        break;
                    case 3:
                        OptionOne.GetComponentInChildren<Text>().text = "The stems";
                        OptionTwo.GetComponentInChildren<Text>().text = "The roots";
                        OptionThree.GetComponentInChildren<Text>().text = "The leaves";
                        break;
                }
                break;
            case 5:
                test.text = "When is the beginning of the plant's life cycle?";
                answer = random.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        OptionOne.GetComponentInChildren<Text>().text = "Germination";
                        OptionTwo.GetComponentInChildren<Text>().text = "Pollenation";
                        OptionThree.GetComponentInChildren<Text>().text = "Birth";
                        break;
                    case 2:
                        OptionOne.GetComponentInChildren<Text>().text = "Birth";
                        OptionTwo.GetComponentInChildren<Text>().text = "Germination";
                        OptionThree.GetComponentInChildren<Text>().text = "Pollenation";
                        break;
                    case 3:
                        OptionOne.GetComponentInChildren<Text>().text = "Pollenation";
                        OptionTwo.GetComponentInChildren<Text>().text = "Birth";
                        OptionThree.GetComponentInChildren<Text>().text = "Germination";
                        break;
                }
                break;
        }
    }

    private void correctAnswer()
    {
        defaultToggle.isOn = true;

        if (inRetry == false)
        {
            if (questionsLeft.Count > 0)
            {
                createQuestion();
            } 
            else if (questionsLeft.Count <= 0)
            {
                OptionOne.gameObject.SetActive(false);
                OptionTwo.gameObject.SetActive(false);
                OptionThree.gameObject.SetActive(false);
                int correctQuestions = 5 - incorrectQuestions.Count;
                test.text = "You got " + correctQuestions + " correct out of 5 questions.";

                if (incorrectQuestions.Count == 0)
                {
                    finish.text = "Good Job! You got all the questions right!";
                    Submit.gameObject.SetActive(false);
                }
                else
                {
                    finish.text = "Looks like you got a few questions wrong, press the button to answer them again.";
                    Submit.GetComponentInChildren<Text>().text = "Retry";
                    retry = true;
                }
            }
        } else
        {
            if (retryQuestions.Count > 0)
            {
                createIncorrectQuestion();
            } 
            else if (retryQuestions.Count <= 0)
            {
                OptionOne.gameObject.SetActive(false);
                OptionTwo.gameObject.SetActive(false);
                OptionThree.gameObject.SetActive(false);
                int CorrectQuestions = 5 - incorrectQuestions.Count;
                test.text = "You got " + CorrectQuestions + " correct out of 5 questions.";
                
                if (incorrectQuestions.Count == 0)
                {
                    finish.text = "Good Job! You got all the questions right this time!";
                    Submit.gameObject.SetActive(false);
                }
                else
                {
                    finish.text = "Looks like you still got some wrong, press the button to go back to the lesson.";
                    Submit.GetComponentInChildren<Text>().text = "Return";
                    restart = true;
                }
            }
        }
    }

    private void incorrectAnswer()
    {
        defaultToggle.isOn = true;

        if (inRetry == false)
        {
            incorrectQuestions.Add(question);
            if (questionsLeft.Count > 0)
            {
                createQuestion();
            }
            else
            {
                OptionOne.gameObject.SetActive(false);
                OptionTwo.gameObject.SetActive(false);
                OptionThree.gameObject.SetActive(false);
                int correctQuestions = 5 - incorrectQuestions.Count;
                test.text = "You got " + correctQuestions + " correct out of 5 questions.";

                if (incorrectQuestions.Count == 0)
                {
                    finish.text = "Good Job! You got all the questions right!";
                    Submit.gameObject.SetActive(false);
                }
                else
                {
                    finish.text = "Looks like you got a few questions wrong, press the button to answer them again.";
                    Submit.GetComponentInChildren<Text>().text = "Retry";
                    retry = true;
                }
            }
        }
        else
        {
            incorrectQuestions.Add(question);
            if (retryQuestions.Count > 0)
            {
                createIncorrectQuestion();
            } else
            {
                OptionOne.gameObject.SetActive(false);
                OptionTwo.gameObject.SetActive(false);
                OptionThree.gameObject.SetActive(false);
                int correctQuestions = 5 - incorrectQuestions.Count;
                test.text = "You got " + correctQuestions + " correct out of 5 questions.";

                if (incorrectQuestions.Count == 0)
                {
                    finish.text = "Good job! You got all the questions right this time!";
                    Submit.gameObject.SetActive(false);
                } else
                {
                    finish.text = "Looks like you still got some questions wrong. Press the button to return to the lesson.";
                    Submit.GetComponentInChildren<Text>().text = "Return";
                    restart = true;
                }
            }
        }
        
    }

    public void startRetry()
    {
        retry = false;
        inRetry = true;
        OptionOne.gameObject.SetActive(true);
        OptionTwo.gameObject.SetActive(true);
        OptionThree.gameObject.SetActive(true);
        finish.text = "";
        Submit.GetComponentInChildren<Text>().text = "Submit";

        retryQuestions.AddRange(incorrectQuestions);
        incorrectQuestions.Clear();

        createIncorrectQuestion();
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