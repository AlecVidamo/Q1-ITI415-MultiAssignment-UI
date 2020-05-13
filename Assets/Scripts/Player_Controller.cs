using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour {

    public Text scoreText;

    private Rigidbody rb;
    private int score;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText ();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            SetScoreText();
            if (score >= 40)
            {
                SceneManager.LoadScene(5);
            }
        }
    }
    
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}