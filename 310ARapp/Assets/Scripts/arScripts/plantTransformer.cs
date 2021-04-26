using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plantTransformer : MonoBehaviour
{
    public GameObject dirtPhase, seedPhase, pollenPhase, waterPhase, sunPhase;

    public float plantCount, numFinishedPlants, totalPlantCount;

    public Text goodMsg, seedMsg, pollenMsg, waterMsg, sunMsg;

    public GameObject wrongMsg, lessonComplete;

    public Button pollenBtn, seedBtn, waterBtn, sunBtn;


    void Start()
    {
        plantCount = 0;
        numFinishedPlants = 0;
    }

    public void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (plantCount == 0)
        {
            dirtPhase.SetActive(true);
            seedPhase.SetActive(false);
            pollenPhase.SetActive(false);
            waterPhase.SetActive(false);
            sunPhase.SetActive(false);

            seedMsg.gameObject.SetActive(true);
            pollenMsg.gameObject.SetActive(false);
            waterMsg.gameObject.SetActive(false);
            sunMsg.gameObject.SetActive(false);
        }
        else if (plantCount == 1)
        {
            dirtPhase.SetActive(false);
            seedPhase.SetActive(true);
            pollenPhase.SetActive(false);
            waterPhase.SetActive(false);
            sunPhase.SetActive(false);

            seedMsg.gameObject.SetActive(false);
            pollenMsg.gameObject.SetActive(true);
            waterMsg.gameObject.SetActive(false);
            sunMsg.gameObject.SetActive(false);
        }
        else if (plantCount == 2)
        {
            dirtPhase.SetActive(false);
            seedPhase.SetActive(false);
            pollenPhase.SetActive(true);
            waterPhase.SetActive(false);
            sunPhase.SetActive(false);

            seedMsg.gameObject.SetActive(false);
            pollenMsg.gameObject.SetActive(false);
            waterMsg.gameObject.SetActive(true);
            sunMsg.gameObject.SetActive(false);
        }
        else if (plantCount == 3)
        {
            dirtPhase.SetActive(false);
            seedPhase.SetActive(false);
            pollenPhase.SetActive(false);
            waterPhase.SetActive(true);
            sunPhase.SetActive(false);

            seedMsg.gameObject.SetActive(false);
            pollenMsg.gameObject.SetActive(false);
            waterMsg.gameObject.SetActive(false);
            sunMsg.gameObject.SetActive(true);
        }
        else if (plantCount == 4)
        {
            dirtPhase.SetActive(false);
            seedPhase.SetActive(false);
            pollenPhase.SetActive(false);
            waterPhase.SetActive(false);
            sunPhase.SetActive(true);

            sunMsg.gameObject.SetActive(false);

            numFinishedPlants += 1;

            if (numFinishedPlants >= totalPlantCount)
            {
                lessonComplete.gameObject.SetActive(true);

                pollenBtn.gameObject.SetActive(false);
                seedBtn.gameObject.SetActive(false);
                waterBtn.gameObject.SetActive(false);
                sunBtn.gameObject.SetActive(false);

                numFinishedPlants = totalPlantCount;
            }

            else
            {
                plantCount = 0;
            }
        }
        
        
    }

    public void PlantCountCollision(float collObjectValue)
    {
        if(collObjectValue == plantCount + 1)
        {
            plantCount = collObjectValue;

            goodMsg.gameObject.SetActive(true);
        }
        else
        {
            plantCount = 0;
            wrongMsg.gameObject.SetActive(true);

            pollenBtn.gameObject.SetActive(false);
            seedBtn.gameObject.SetActive(false);
            waterBtn.gameObject.SetActive(false);
            sunBtn.gameObject.SetActive(false);
            Debug.Log("incorrect step");
        }
        
    }
}
