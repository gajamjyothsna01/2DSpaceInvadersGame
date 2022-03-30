using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject missilePrefab;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab,transform.position,Quaternion.identity);
        }

        //gameObject.transform.position = new Vecto3(i,j,0);
        time = time + Time.deltaTime;
        if(time > 3.0f)
        {
            transform.position = new Vector3(UnityEngine.Random.Range(-6f, 2f), UnityEngine.Random.Range(3f, 1f), 0f);
            Instantiate(missilePrefab, transform.position, Quaternion.identity);
            time = 0f;

        }
       


    }
   
       
        
           
          
        
       
    
}
