using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {

       
        theScore += 10;
        scoreText.GetComponent<Text>().text = "ESTRELLAS: " + theScore;
        Destroy(gameObject);


    }

}
