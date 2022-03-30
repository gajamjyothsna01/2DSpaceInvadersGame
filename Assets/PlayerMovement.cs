using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public GameObject laserPrefab;
    float time;
   // public float missilePrefab;
    Vector3 enemyPosition;
   int playerHealth = 3;
    public Text playerHealthText, displayText;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == false)
        {
            if (Input.GetKey(KeyCode.L))
            {
                if (transform.position.x < 8.2f)
                    transform.position = transform.position + Vector3.right * playerSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.R))
            {
                if (transform.position.x > -8.25f)
                {
                    transform.position = transform.position + Vector3.left * playerSpeed * Time.deltaTime;
                }

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ShootBullet();
            }
        }
       

       
        
        
       // int i = UnityEngine.Random.Range(0, 3);
        //int j = UnityEngine.Random.Range(0, -1);

        //GameObject enemy = GameObject.Find("Enemy" + i + j);

        

        // gameObject.transform.Translate(Vector3.right * inputX * playerSpeed * Time.deltaTime);
    }

    private void ShootBullet()
    {
        Instantiate(laserPrefab, transform.position, Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If missile hits the Player, Player health has to Decrease.
        if(collision.gameObject.tag == "Missile")
        {
            if(playerHealth >-1)
            {
                Destroy(collision.gameObject);  
                //Debug.Log(playerHealth);
                playerHealthText.text = playerHealth.ToString();
                playerHealth--;
                
                
            }
            
            else
            {
                GameOver();
            }
        }
      /*  if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Destroy");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }*/


    }
  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }*/
    private void GameOver()
    {
        Destroy(gameObject);
        isGameOver = true;

    }
}
