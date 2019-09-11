using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{   
/*
 * (CJ Green)
 * (ScoreTrigger.cs)
 * (Assignment 3)
 * (This is the script responsible for detecting when the player hits the Score Trigger and gets points.)
*/
    public int scoreValue;
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {
            gameController.AddScore(scoreValue);
        }
    }
}
