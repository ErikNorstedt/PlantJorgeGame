using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWater : MonoBehaviour
{
    public GameObject Jorge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
           
            collision.GetComponent<Stat>().Watalvl += 1;
        }
        Destroy(gameObject);
    }
}
