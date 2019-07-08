using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float movSpeed;
    public int points;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left*movSpeed*Time.deltaTime,Space.World);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right*movSpeed*Time.deltaTime,Space.World);
        }
    }
    void OnTriggerEnter(Collider collision){
        if(collision.tag=="fruit"){
            points++ ;
            Destroy(collision.gameObject);
        }
    }
}
