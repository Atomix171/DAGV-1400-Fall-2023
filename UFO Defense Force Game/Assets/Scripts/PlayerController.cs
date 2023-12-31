using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 25;
    public float xRange = 20;
    public Transform blaster;
    public GameObject lazerBolt;
    


    // Update is called once per frame
    void Update()
    {
        // Get the input to move the player left and right
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keeps player with in left side wall bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Keeps player with in right side wall bounds
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If space bar is pressed shot lazer bolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate creates an object so in this code its make a lazerbolt at the 
            // blaster transform postion and maintaing the objects rotation. 
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

    

    }

    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
