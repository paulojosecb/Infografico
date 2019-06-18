using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaisController : MonoBehaviour
{

    public bool leftBalanced;
    public bool rightBalanced;

    public GameObject ui1;
    public GameObject ui2;

    Renderer[] ui1Renderes;
    Renderer[] ui2Renderes;

    // Start is called before the first frame update
    void Start()
    {
        leftBalanced = false;
        rightBalanced = false;

        ui1Renderes = ui1.GetComponentsInChildren<Renderer>(true);
        ui2Renderes = ui2.GetComponentsInChildren<Renderer>(true);

        SetRendererEnabled(ui1Renderes, true);
        SetRendererEnabled(ui2Renderes, false);

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftBalanced && rightBalanced) {

            SetRendererEnabled(ui1Renderes, false);
            SetRendererEnabled(ui2Renderes, true);
            Time.timeScale = 0;

        }
    }

    public void setLeftBalancedTo(bool b) {
        leftBalanced = b;
    }

    public void setRighitBalancedTo(bool b)
    {
        rightBalanced = b;
    }

    private void SetRendererEnabled(Renderer[] currentRenderers, bool enableRenderer)
    {

        for (int x = 0; x < currentRenderers.Length; x++)
            currentRenderers[x].enabled = enableRenderer;
    }
}

