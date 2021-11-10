/*
	Cameron Kent	2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Finish triggered");
            gameController.FinishLevel();
        }
    }
}