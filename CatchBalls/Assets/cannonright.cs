using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonright : MonoBehaviour
{
    public float timer, mintime, maxtime ;
    public bool shoot=false;
    public Transform fruit, spawnpoint;
    
    // Update is called once per frame
    void Update()
    {
        if(shoot){
            StopCoroutine("Waiting");
            shoot=false;
            timer = Random.Range(mintime,maxtime);
            Instantiate(fruit,spawnpoint.position,transform.rotation);
        }
        else{
            StartCoroutine("Waiting");
        }
    }
    IEnumerator Waiting(){
        yield return new WaitForSeconds(timer);
        shoot=true;
    }
}
