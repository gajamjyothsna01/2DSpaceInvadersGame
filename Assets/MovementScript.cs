using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed;
    //private float leftPositiveLimit = -8.07f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float xPosition = Mathf.Clamp(transform.position.x, -8.15f, 8.07f);
        float yPosition = Mathf.Clamp(transform.position.y, -1.36f, 3.28f);


        gameObject.transform.Translate(Vector3.right *inputX* speed * Time.deltaTime);
        gameObject.transform.Translate(Vector3.up * inputY * speed * Time.deltaTime);
        


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
        }
    }
}
