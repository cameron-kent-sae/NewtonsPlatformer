/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int lives;
    
    public PlayerData(Player player)
    {
        level = player.level;
        lives = player.lives;
    }
}