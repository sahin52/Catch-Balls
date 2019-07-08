using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public float timer, mintime, maxtime;
    public Transform fruit,spawnpoint;                                //These are gonna be added afterwards
    public bool reloaded=false;

    // Update is called once per frame
    void Update()
    {
        if(reloaded){
            StopCoroutine("Timer");                                    // Stops Timer function but idk how it works
            Instantiate(fruit,spawnpoint.position,transform.rotation); //Fruit is created in the spawnpoint
            timer=Random.Range(mintime,maxtime);                       //timer is determined
            reloaded = false;                                          //it doesn't reload again
        }
        else{
            StartCoroutine("Timer");                                   //Start coroutine which is down below.
        } 
    }
    IEnumerator Timer(){
        yield return new WaitForSeconds(timer); //here it waits for a time determined by timer.
        reloaded=true;                          //after waiting, it reloads again
    }

}
