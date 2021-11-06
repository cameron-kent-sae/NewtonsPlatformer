/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void LifeRestart()
    {
        lives -= 1;

        if (lives > 0)
        {
            SaveSystem.SavePlayer(this);
            SceneManager.LoadScene(GetCurrentLevel());
        }
        else
        {
            lives = 3;
            level = 1;
            SaveSystem.SavePlayer(this);
            SceneManager.LoadScene("Menu");
        }
    }

    private string GetCurrentLevel()
    {
        switch (level)
        {
            case 1:
                return "Summer";
            case 2:
                return "Autumn";
            case 3:
                return "Winter";
            case 4:
                return "Spring";
            default:
                return "Summer";
        }
    }
    
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