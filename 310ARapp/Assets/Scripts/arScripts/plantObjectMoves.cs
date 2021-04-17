using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantObjectMoves : MonoBehaviour
{
    public float tossSpeed = 10;
    public GameObject target;
    public float interactionValue;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, tossSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "plant")
        {
            other.gameObject.GetComponent<plantTransformer>().PlantCountCollision(interactionValue);
        }
        Destroy(gameObject);
    }
}
