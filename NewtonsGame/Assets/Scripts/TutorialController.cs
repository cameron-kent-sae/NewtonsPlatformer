/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    #region Variables
    public CanvasGroup tutText;
    #endregion

    #region Built In Methods
    private void Start()
    {
        tutText.alpha = 0;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutText.alpha = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tutText.alpha = 0;
        }
    }
    #endregion

    #region Custom Methods

    #endregion
}