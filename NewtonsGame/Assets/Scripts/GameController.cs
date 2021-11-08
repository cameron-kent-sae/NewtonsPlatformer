/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    #region Variables
    public string thisLevel, nextLevel;
    public Player player;
    #endregion

    #region Built In Methods

    #endregion

    #region Custom Methods
    public void LifeRestart()
    {
        player.lives -= 1;

        if (player.lives > 0)
        {
            SaveSystem.SavePlayer(player);
            SceneManager.LoadScene(thisLevel);
        }
        else if (player.lives == 0)
        {
            //Game over
        }
    }
    
    public void FinishLevel()
    {
        //ui prompt
        //load next level
    }
    #endregion
}