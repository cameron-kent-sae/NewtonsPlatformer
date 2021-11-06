/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    #region Variables
    private Player player;
    #endregion

    #region Built In Methods
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.LifeRestart();
        }
    }
    #endregion

    #region Custom Methods

    #endregion
}