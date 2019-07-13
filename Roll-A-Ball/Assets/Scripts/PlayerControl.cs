using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text scoreText;
    public Text livesText;
    public Text winText;
    public Text loseText;
    private Rigidbody rb;
    private int count;
    private int Count;
    private int score;
    private int lives;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        Count = 0;
        score = 0;
        lives = 3;
        SetCountText ();
        SetScoreText ();
        SetLivesText ();
        winText.text = "";
        loseText.text = "";
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Pick Up")) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            Count = Count + 1;
            SetCountText ();
            SetScoreText ();
        }
        if (other.gameObject.CompareTag("Enemy Pick Up")) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score - 1;
            lives = lives - 1;
            SetCountText ();
            SetScoreText ();
            SetLivesText ();
        }
        if (Count == 12)
        {
            transform.position= new Vector3(53f, 0.003582001f, -0.5274748f);
        }
        if (lives == 0)
        {
            gameObject.SetActive(false);
            loseText.text = "You Lose!";
        }        
    }
    void SetLivesText ()
    {
        livesText.text = "Lives: " + lives.ToString ();
    }
    void SetScoreText ()
    {
       scoreText.text = "Score: " + score.ToString ();
        if (score >= 20)
        {
            winText.text = "You Win!";
        } 
    }
    void SetCountText ()
    {
         countText.text = "Count: " + count.ToString ();
    } 
}
