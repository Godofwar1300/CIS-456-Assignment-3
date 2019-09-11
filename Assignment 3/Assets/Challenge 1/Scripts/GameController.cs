using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

/*
 * (CJ Green)
 * (GameController.cs)
 * (Assignment 3)
 * (This is the script responsible for updating and adding the score.)
*/
    public Text scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    public void AddScore(int scoreValue)
    {
        score += scoreValue;
        Debug.Log(score);
    }
}
