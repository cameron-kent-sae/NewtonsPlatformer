/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    #region Variables
    public string thisLevel, nextLevel, gameOverScene;
    public int levelIndex;
    public Player player;
    public GameObject FinishUI;
    public Button nextBtn;
    private GameObject heart1, heart2, heart3;
    #endregion

    #region Built In Methods
    private void Start()
    {
        GetUI();
        UpdateUI();

        FinishUI.SetActive(false);
    }
    #endregion

    #region Custom Methods
    public void RestartLevel()
    {
        Debug.Log(player.lives);
        player.lives--;
        Debug.Log(player.lives);
        SaveSystem.SavePlayer(player);

        if (player.lives > 0)
        {
            SceneManager.LoadScene(thisLevel);
        }
        else if (player.lives == 0)
        {
            //Game over
            SceneManager.LoadScene(gameOverScene);
        }
    }

    public void FinishLevel()
    {
        FinishUI.SetActive(true);
        player.level = levelIndex;
        SaveSystem.SavePlayer(player);
        nextBtn.onClick.AddListener(delegate { SceneManager.LoadScene(nextLevel); });
    }

    private void UpdateUI()
    {
        if (player.lives == 2)
        {
            heart3.SetActive(false);
        }

        if (player.lives == 1)
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