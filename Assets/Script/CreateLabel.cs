using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLabel : MonoBehaviour  
{
    public GameObject labelPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() {
        print("Mouse dwon");
        Instantiate(labelPrefab, transform.position, Quaternion.identity);
    }
}
