using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
