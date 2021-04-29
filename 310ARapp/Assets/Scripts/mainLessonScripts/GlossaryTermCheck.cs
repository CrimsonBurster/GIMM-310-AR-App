using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlossaryTermCheck : MonoBehaviour
{
    public GameObject lessonPages;
    int number;

    public GameObject term1, term2, term3, term4, term5;
    // Start is called before the first frame update
    void Start()
    {
        number = lessonPages.gameObject.GetComponent<next_backButtonManager>().totalPage;
    }

    // Update is called once per frame
    void Update()
    {
        if(number == 1)
        {
            term1.gameObject.SetActive(true);
        }

        else if(number == 2)
        {
            term1.gameObject.SetActive(true);
            term2.gameObject.SetActive(true);
        }

        else if(number == 3)
        {
            term1.gameObject.SetActive(true);
            term2.gameObject.SetActive(true);
            term3.gameObject.SetActive(true);
        }

        else if(number == 4)
        {
            term1.gameObject.SetActive(true);
            term2.gameObject.SetActive(true);
            term3.gameObject.SetActive(true);
            term4.gameObject.SetActive(true);
            term5.gameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        number = lessonPages.gameObject.GetComponent<next_backButtonManager>().pageCount;

    }
}
