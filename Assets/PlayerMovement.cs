using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    
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
        if (Input.GetKey(KeyCode.K))
        {
            if(transform.position.x > -8.25f)
            {
                transform.position = transform.position + Vector3.left * playerSpeed * Time.deltaTime;
            }
            
        }

        // gameObject.transform.Translate(Vector3.right * inputX * playerSpeed * Time.deltaTime);
    }
}
