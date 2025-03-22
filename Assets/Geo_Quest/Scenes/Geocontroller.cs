using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geocontroller : MonoBehaviour
{
     Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_1";
    string String = "Hello";
    int burger = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update() 
    {
        Debug.Log(burger);
        burger++;
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.position += new Vector3(1, 0, 0);
            //rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        if (Input.GetKeyDown (KeyCode.S))
        {
            //transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.position += new Vector3(-1, 0, 0);
            //rb.velocity = new Vector2(5, rb.velocity.y);
        }
       
        {
            
        }
        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);
    }
    private int coinCounter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Runkiller");


        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel); 
                    break;
                }

            case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }  


        }




    }
}
