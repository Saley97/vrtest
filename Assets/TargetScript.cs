using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

    private void OnMouseEnter()
    {
        PlayerManager.currentTarget = gameObject; 
    }

    private void OnMouseExit()
    {
        PlayerManager.currentTarget = null;
    }

}
