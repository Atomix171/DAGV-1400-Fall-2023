using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // store refecnce to score manager

    public int scoreToGive;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find scoremanager gameobject and referance scoremanager script component
    }

    void OnTriggerEnter(Collider other) // once the trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // increase the score
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

    
}
