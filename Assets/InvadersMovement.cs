using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersMovement : MonoBehaviour
{
    public GameObject invaderPrefab;
    public float numberOfPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(invaderPrefab != null)
        {
            for(int  j= 0; j < 2; j++)
            {
                for (float i = 0.0f; i < numberOfPrefabs; i = i + 1.5f)
                {
                    Instantiate(invaderPrefab, new Vector3(-7.0f + i, -1.06f+j, -1.35f), Quaternion.identity);
                }
            }
            

        }

           
    }
}
