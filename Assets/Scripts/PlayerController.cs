using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject clickedGameObject;

    public bool isSelected = false;
    public bool isClicked = false;

    private void OnMouseDown()
    {
        isSelected = true;
        
    }

    public void DoSomethingToClicked(GameObject clickedOn)
    {
        isClicked = true;
        clickedGameObject = clickedOn;

        Debug.Log(clickedGameObject.gameObject.tag);
    }

    private void Update()
    {
        if (isClicked && isSelected)
        {
            float distanceX = (transform.position.x - clickedGameObject.gameObject.transform.position.x) ;
            float distanceZ = (transform.position.z - clickedGameObject.gameObject.transform.position.z) ;

            if(distanceX <= 6 && distanceZ <= 6)
            {
                if (clickedGameObject.gameObject.tag == "Ground" || clickedGameObject.gameObject.tag == "Village")
                {
                    transform.position = new Vector3(clickedGameObject.gameObject.transform.position.x, 1.47f, clickedGameObject.gameObject.transform.position.z);
                }
                isClicked = false;
                isSelected = false;
            }

        }

        if(isSelected && !isSelected)
        {
            isClicked = false;
            clickedGameObject = null;
        }

    }

}
