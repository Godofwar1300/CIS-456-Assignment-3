using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour
{
/*
 * (CJ Green)
 * (WallScript.cs)
 * (Assignment 3)
 * (This is the script responsible for restarting the scene if the player hits a wall.)
*/

    public void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
