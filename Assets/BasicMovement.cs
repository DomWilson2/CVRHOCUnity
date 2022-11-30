using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Vector3 movement;
    public float runTime = 10;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < runTime){
            this.GetComponent<Rigidbody>().AddForce(movement);
        }
    }
}
