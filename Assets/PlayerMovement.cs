using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public GameObject laserPrefab;
    float time;
    public float missilePrefab;
    Vector3 enemyPosition;
   int playerHealth = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       if(Input.GetKey(KeyCode.L))
        {
            if(transform.position.x < 8.2f)
                 transform.position = transform.position+ Vector3.right * playerSpeed* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R))
        {
            if(transform.position.x > -8.25f)
            {
                transform.position = transform.position + Vector3.left * playerSpeed * Time.deltaTime;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
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
        if(collision.gameObject.tag == "Missile")
        {
            if(playerHealth >-1)
            {
                Debug.Log(playerHealth);
                playerHealth--;
                
            }
            else
            {
                GameOver();
            }
        }
        
    }
    private void GameOver()
    {

    }
}
