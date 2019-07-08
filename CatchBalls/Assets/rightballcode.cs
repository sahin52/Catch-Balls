using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightballcode : MonoBehaviour
{   public float x,y;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        x=Random.Range(3,7);
        y=Random.Range(5,10);
        rb.AddForce(-x,y,0,ForceMode.Impulse);
    }
    void OnTriggerEnter (Collider ground){
        if(ground.tag=="ground"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);            
        }
    }
    // Update is called once per frame
}
