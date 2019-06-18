using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : MonoBehaviour
{
    public GameObject prefab;
    Renderer[] renderes;

    private void OnMouseUp() {
        Instantiate(prefab, transform.position, Quaternion.identity);
        renderes = GetComponentsInChildren<Renderer>(true);
        SetRendererEnabled(renderes, false);

        Destroy(this);
    }

    private void SetRendererEnabled(Renderer[] currentRenderers, bool enableRenderer)
    {

        for (int x = 0; x < currentRenderers.Length; x++)
            currentRenderers[x].enabled = enableRenderer;
    }

}
