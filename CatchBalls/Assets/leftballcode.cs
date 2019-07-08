using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leftballcode : MonoBehaviour
{   
    public float x,y;
    // Start is called before the first frame update
    public Rigidbody ball;
    // Update is called once per frame
    void Start()
    {
        x=Random.Range(3,7);
        y=Random.Range(5,10);
        ball.AddForce(x,y,0,ForceMode.Impulse);
    }
    void OnTriggerEnter (Collider ground){
        if(ground.tag=="ground"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);            
        }
    }
}
