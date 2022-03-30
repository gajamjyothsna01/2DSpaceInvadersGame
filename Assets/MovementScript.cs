using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float invaderSpeed;
    public GameObject invaderOnePrefab;
    public GameObject invaderTwoPrefab;
    public GameObject invaderThreePrefab;
    private GameObject prefabToCheck;
    bool isLeft = false;
    //private float leftPositiveLimit = -8.07f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float xPosition = Mathf.Clamp(transform.position.x, -8.15f, 8.07f);
        float yPosition = Mathf.Clamp(transform.position.y, -1.36f, 3.28f); */

        //if(prefabToCheck == invaderOnePrefab ) 
        // {
        /* if(gameObject.transform.position.x < 6.45 )
         {
             Debug.Log("FirstPrefab");*/

        if (isLeft == false)
        {
            gameObject.transform.Translate(Vector2.right * invaderSpeed * Time.deltaTime);
        }
                if(gameObject.transform.position.x > 6.45f)
                 {
            // gameObject.transform.position = gameObject.transform.position + gameObject.transform.forward * invaderSpeed * Time.deltaTime;
            //   gameObject.transform.Translate(transform.position.x,transform.position.y,transform.position.z);
            //  StartCoroutine("InvadersStopForSomeRTime");
                    // gameObject.transform.Translate(transform.position.x * 0.5f, transform.position.y, transform.position.z);
                   
                     isLeft = true;
                     //transform.position.x = gameObject.transform.position.x * 
                 }
                if(isLeft ==true)
                {
                        gameObject.transform.Translate(Vector2.left * invaderSpeed * Time.deltaTime);
                       

                 }
                if(gameObject.transform.position.x < -8.6f)
                 {
                    isLeft=false;

                 }
               


        // }
       /* if (gameObject.transform.position.x == 6.45)
            {
                Debug.Log("Move Left");
                StartCoroutine("InvadersStopForSomeRTime");
                gameObject.transform.Translate(Vector2.left * invaderSpeed * Time.deltaTime);

            }*/
       
           
        }

        /*if (prefabToCheck == invaderTwoPrefab)
        {
            Debug.Log("SecondPrefab");
            gameObject.transform.Translate(Vector3.right * invaderSpeed * Time.deltaTime);
        }*/
        //if(gameObject.transform.position.x > 6.45 )
        // {
        // StartCoroutine("InvadersStopForSomeRTime");
        /*    
            if(transform.position.x == 6.45)
        {
            gameObject.transform.Translate(Vector3.left * invaderSpeed * Time.deltaTime);
        }*/

        //StartCoroutine("InvadersStopForSomeRTime");
        //gameObject.transform.Translate(Vector3.left * invaderSpeed * Time.deltaTime);
        //  }
        /* if (gameObject.transform.position.x == 6.45)
         {

         }*/


        // if (transform.position.x < -6.58)
        // {
        // StartCoroutine("InvadersStopForSomeRTime");
        // gameObject.transform.Translate(Vector3.left * invaderSpeed * Time.deltaTime);
        // }
        // gameObject.transform.Translate(Vector3.up * inputY * speed * Time.deltaTime);


        /*
       if(transform.position.x < -8.15f)
        {
            transform.position = new Vector3(-8.09f, transform.position.y, 0);
        }
        if (transform.position.x > 8.07f)
        {
            transform.position = new Vector3(8.07f,transform.position.y,0);
        }
        if (transform.position.y > 3.45)
        {
            transform.position = new Vector3(transform.position.x, 3.45f, 0);

        }
        if (transform.position.y < -1.21f)
        {
            transform.position = new Vector3(transform.position.x, -1.21f, 0);
        }*/
    
   /* private void OnCollisionEnter(Collision collision)
    {
        if(prefabToCheck !=invaderOnePrefab)
        {
            if(collision.gameObject.tag != "RightWall")
            {
                Debug.Log("FirstPrefab");
                gameObject.transform.Translate(Vector3.left * invaderSpeed * Time.deltaTime);
                this.gameObject.transform.position = collision.transform.position; 
               
            }
        }
    }*/
     private void OnTriggerEnter(Collider other)
      {
          if(other.gameObject.tag == "RightWall")
          {
              transform.Translate(Vector3.left *invaderSpeed * Time.deltaTime);
          }
          if(other.gameObject.tag =="LeftWall")
          {
              transform.Translate(Vector3.right *invaderSpeed * Time.deltaTime);
          }
      }
   
      IEnumerator InvadersStopForSomeRTime()
      {
          yield return new WaitForSeconds(5f);

      }
}
