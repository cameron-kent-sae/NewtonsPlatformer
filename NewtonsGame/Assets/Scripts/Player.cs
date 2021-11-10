/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    public int level;
    public int lives;

    private GameObject heart1, heart2, heart3;
    #endregion

    #region Built In Methods
    private void Start()
    {
        SaveSystem.LoadPlayer();
        GetUI();
        UpdateUI();
    }
    #endregion

    #region Custom Methods
   
    private void UpdateUI()
    {
        if (lives == 2)
        {
            heart3.SetActive(false);
        }

        if (lives == 1)
        {
            heart2.SetActive(false);
        }
    }

    private void GetUI()
    {
        heart1 = GameObject.Find("Heart 1");
        heart2 = GameObject.Find("Heart 2");
        heart3 = GameObject.Find("Heart 3");
    }
    #endregion
}