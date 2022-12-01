using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    PlayerController control;

    private void Start()
    {
        control = FindObjectOfType<PlayerController>();
    }

    private void OnMouseUp()
    {
        control.DoSomethingToClicked(gameObject);
    }

}
