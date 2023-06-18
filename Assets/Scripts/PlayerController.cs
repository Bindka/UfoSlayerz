using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    Rigidbody2D rb2d;
    private int count = 0;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

  

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * 15);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.PlaySFX("Bounce");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            count++;
            Destroy(collision.gameObject);
            UpdateScoreText();
            AudioManager.instance.PlaySFX("Coin");
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Wynik: " + count;
        if (count ==3)
        {
           
            winText.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(false);
            StartCoroutine(StopTime());
            AudioManager.instance.PlaySFX("Win");

        }

    }
  
IEnumerator StopTime()
{
    yield return new WaitForSeconds(5);
    SceneManager.LoadScene("Level02"); 
}

    int Suma(int a , int b)
    {
        int suma = a + b;
        return suma;

    }
    void Update()
    {
        
    }
}

