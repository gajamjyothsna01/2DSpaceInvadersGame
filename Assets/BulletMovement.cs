using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  time = time + Time.deltaTime;
        if (time < 1f)
        {
            //gameObject.transform.Translate(0, bulletSpeed, 0);
            time = time + Time.deltaTime;
            if (time > 2f)
            {
                Destroy(gameObject);
             */
      gameObject.transform.Translate(Vector2.up * bulletSpeed*Time.deltaTime);
        
     }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //Increase the SCores.
        }
    }


}
