using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button playButton, continueButton;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(NewGame);
        continueButton.onClick.AddListener(ContinueGame);
    }

    private void NewGame()
    {
        player.lives = 3;
        player.level = 1;
     //   player.SavePlayer();
        SceneManager.LoadScene("L1_Summer");
    }
    private void ContinueGame()
    {
        string scenetoLoad = "";
        SaveSystem.LoadPlayer();
        switch (player.level)
        {
            case 1: scenetoLoad = "L1_Summer";
                break;
            case 2: scenetoLoad = "L2_Autumn";
                break;
            case 3: scenetoLoad = "L3_Winter";
                break;
            case 4: scenetoLoad = "L4_Spring";
                break;
        }
        SceneManager.LoadScene(scenetoLoad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
