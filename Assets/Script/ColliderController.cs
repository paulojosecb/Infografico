using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public double weight;
    // Start is called before the first frame update
    void Start()
    {
        weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (weight == 1) {
            print("Balanceado");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       //Debug.Log("PORRRA");

    }
}
