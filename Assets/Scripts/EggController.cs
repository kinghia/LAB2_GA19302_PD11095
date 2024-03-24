using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Principal;
using JetBrains.Annotations;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    public GameObject Egg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnCollisionEnter2D(Collision2D col){   
        if(col.gameObject.name.Equals("Ground")){
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0f);
            Destroy(this, 0.1f);
        }
        if(col.gameObject.name.Equals("Egg")){
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0f);
            Destroy(this, 0.1f);
        }
        
        if(col.gameObject.name.Equals("Farmer")){
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0f);
            Destroy(this, 0.1f);
        }
        if(col.gameObject.name.Equals("Box")){
            Destroy(gameObject, 0f);  
            Destroy(this, 0.1f);
        }
    }
}
