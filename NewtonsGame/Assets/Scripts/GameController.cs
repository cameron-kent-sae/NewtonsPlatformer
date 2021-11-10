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
    #endregion

    #region Built In Methods
    private void Start()
    {
        FinishUI.SetActive(false);
    }
    #endregion

    #region Custom Methods
    public void RestartLevel()
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
            SceneManager.LoadScene(gameOverScene);
        }
    }
    
    public void FinishLevel()
    {
        FinishUI.SetActive(true);
        player.level = levelIndex;
        nextBtn.onClick.AddListener(delegate { SceneManager.LoadScene(nextLevel); });
    }
    #endregion
}