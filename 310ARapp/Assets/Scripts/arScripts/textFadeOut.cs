using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFadeOut : MonoBehaviour
{
    float count;
    public float totalCount;
    private Animator animator;

    

    void Start()
    {
        count = 0;
        totalCount = 200;
        animator = GetComponent<Animator>();
        animator.Play("staticGoodJob");
    }

    void Update()
    {

        //Debug.Log(totalCount);
        count += 1;
        if(count >= totalCount)
        {
            

            StartCoroutine(DoAnimation());

            totalCount = 0;
        }
        
    }

    private IEnumerator DoAnimation()
    {
        animator.Play("goodJobFadeOut_anim");
        yield return new WaitForSeconds(1f);
        
        this.gameObject.SetActive(false);

        
    }
}
