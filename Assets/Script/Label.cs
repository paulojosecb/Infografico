using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : MonoBehaviour
{
    public GameObject prefab;

    private void OnMouseUp() {
        Instantiate(prefab, transform.position, Quaternion.identity);
        Destroy(this);
    }


}
