using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
        Application.LoadLevel("Main");
    }
}
