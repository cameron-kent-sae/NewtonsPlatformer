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

    #endregion

    #region Built In Methods
    private void Start()
    {
        SaveSystem.LoadPlayer();
    }
    #endregion

    #region Custom Methods

    #endregion
}