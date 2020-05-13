using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
            score = score + 1;
            SetScoreText ();
        }
    }
    
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}