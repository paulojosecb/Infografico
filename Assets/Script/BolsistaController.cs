using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolsistaController : MonoBehaviour
{
    public GameObject bolsistaPrefab;
    public GameObject cincoBolsistasPrefab;
    public GameObject dezBolsistasPrefab;

    public void onBolsistaCreate() {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = new Vector3(mousePos.x, mousePos.y, 0);
        Instantiate(bolsistaPrefab, pos, Quaternion.identity);
    }

    public void onCincoBolsistasCreate()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = new Vector3(mousePos.x, mousePos.y, 0);
        Instantiate(cincoBolsistasPrefab, pos, Quaternion.identity);
    }

    public void onDezBolsistasCreate()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = new Vector3(mousePos.x, mousePos.y, 0);
        Instantiate(dezBolsistasPrefab, pos, Quaternion.identity);
    }
}
