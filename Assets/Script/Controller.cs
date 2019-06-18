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

    public float counter;

    bool isBalanced;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        posInicialEsquerdo = pratoEsquerdo.transform.position;
        posInicialDireito = pratoDireito.transform.position;

        ui1Renderes = ui1.GetComponentsInChildren<Renderer>(true);
        ui2Renderes = ui2.GetComponentsInChildren<Renderer>(true);

        SetRendererEnabled(ui1Renderes, true);
        SetRendererEnabled(ui2Renderes, false);

        isBalanced = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float posEsquerdo = pratoEsquerdo.transform.position.y;
        float posDireito = pratoDireito.transform.position.y;

        if (posDireito >= posEsquerdo - 0.1 && posDireito <= posEsquerdo + 0.1)
        {
            counter++;
        }
        else {
            counter = 0;
        }

        if (counter > 120) {
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
