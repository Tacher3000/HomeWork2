using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mainScript : MonoBehaviour
{

    public GameObject objectCube;
    private bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void buttonClicked()
    {
        if (isActive)
        {
            objectCube.SetActive(!isActive);
            isActive = false;
        }
        else
        {
            objectCube.SetActive(!isActive);
            isActive = true;
        }
    }
}
