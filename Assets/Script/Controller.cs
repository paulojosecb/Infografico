using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject pratoEsquerdo;
    public GameObject pratoDireito;

    public GameObject ui1;
    public GameObject ui2;

    private Vector3 posInicialEsquerdo;
    private Vector3 posInicialDireito;

    Renderer[] ui1Renderes;
    Renderer[] ui2Renderes;

    bool isBalanced;

    // Start is called before the first frame update
    void Start()
    {
        posInicialEsquerdo = pratoEsquerdo.transform.position;
        posInicialDireito = pratoDireito.transform.position;

        ui1Renderes = ui1.GetComponentsInChildren<Renderer>(true);
        ui2Renderes = ui2.GetComponentsInChildren<Renderer>(true);

        SetRendererEnabled(ui1Renderes, true);
        SetRendererEnabled(ui2Renderes, false);

        isBalanced = false;
    }

    // Update is called once per frame
    void Update()
    {
        float posEsquerdo = Mathf.Round(pratoEsquerdo.transform.position.y * 100f) / 100f;
        float posDireito = Mathf.Round(pratoDireito.transform.position.y * 100f) / 100f;
        if ((posEsquerdo <= posDireito)) {

            SetRendererEnabled(ui1Renderes, false);
            SetRendererEnabled(ui2Renderes, true);
        
            isBalanced = true;
            print(isBalanced);

            Time.timeScale = 0;
        }
    }

    private void SetRendererEnabled(Renderer[] currentRenderers, bool enableRenderer)
    {

        for (int x = 0; x < currentRenderers.Length; x++)
            currentRenderers[x].enabled = enableRenderer;
    }
}
