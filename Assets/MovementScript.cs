using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
      
        gameObject.transform.Translate(Vector3.right *inputX* speed * Time.deltaTime);
        gameObject.transform.Translate(Vector3.up * inputY * speed * Time.deltaTime);
    }
}
