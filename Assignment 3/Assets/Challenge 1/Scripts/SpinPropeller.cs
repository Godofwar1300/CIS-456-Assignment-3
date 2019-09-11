using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

/*
 * (CJ Green)
 * (SpinPropeller.cs)
 * (Assignment 3)
 * (This is the script responsible for spinning the propeller.)
*/

    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
