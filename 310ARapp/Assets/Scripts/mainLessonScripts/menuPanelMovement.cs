using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPanelMovement : MonoBehaviour
{
    public GameObject MenuOrigPos, MenuActivePos, MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
