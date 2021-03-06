using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersSpawing : MonoBehaviour
{
    public GameObject invaderOnePrefab;
    public GameObject invaderTwoPrefab;
    public GameObject invaderThreePrefab;
    public float numberOfPrefabs;
    [SerializeField]
    public float invaderSpeed = 1.0f; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            if(invaderOnePrefab != null&& Input.GetKeyDown(KeyCode.A))
            { 
                for (int j = 0; j < 2; j++)
                {
                    for (float i = 0.0f; i < numberOfPrefabs; i = i + 1.5f)
                    {
                        
                             Instantiate(invaderOnePrefab, new Vector3(-5.5f + i, -1.06f + j, 0f), Quaternion.identity);
                            // StartCoroutine("checkForInvadersGrid");
                            //  transform.Translate(Vector3.right* invaderSpeed * Time.deltaTime);
                         //   invaderOnePrefab.transform.Translate(Vector3.right * invaderSpeed * Time.deltaTime);
                        
                        
                    }
                }
         

        }
          
            if (invaderTwoPrefab != null && Input.GetKeyDown(KeyCode.B))
            {
                for (int j = 0; j < 2; j++)
                {
                    for (float i = 0.0f; i < numberOfPrefabs; i = i + 1.5f)
                    {
                         Instantiate(invaderTwoPrefab, new Vector3(-5.5f + i, 0.94f + j, 0f), Quaternion.identity);
                          StartCoroutine("checkForInvadersGrid");
                }
                }
            }
        if (invaderThreePrefab != null && Input.GetKeyDown(KeyCode.C))
        {
                for (float i = 0.0f; i < numberOfPrefabs; i = i + 1.5f)
                {
                    Instantiate(invaderThreePrefab, new Vector3(-5.5f + i,2.94f,0f), Quaternion.identity);
                }
            StartCoroutine("checkForInvadersGrid");
        }
      //  gameObject.transform.Translate(Vector3.right * invaderSpeed * Time.deltaTime);



    }
    IEnumerator checkForInvadersGrid()
    {
        yield return new WaitForSeconds(5f);

    }
   
}

