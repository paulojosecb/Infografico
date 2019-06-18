using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public bool hasRightObject;
    public bool isOnBalance;

    public int counter;

    public GameObject objectToCollide;
    public GameObject rightPlate;

    public string side;

    // Start is called before the first frame update
    void Start()
    {
        hasRightObject = false;
        counter = 0;
        isOnBalance = false;
    }

    private void Update()
    {
        if (hasRightObject)
        {
            float posEsquerdo = transform.position.y;
            float posDireito = rightPlate.transform.position.y;

            if (posDireito >= posEsquerdo - 0.1 && posDireito <= posEsquerdo + 0.1)
            {
                counter++;
            }
            else {
                counter = 0;
            }

            if (counter > 120) {
                switch (side)
                {
                    case "left":
                        GameObject.Find("AnimaisController").GetComponent<AnimaisController>().setLeftBalancedTo(true);
                        break;
                    case "right":
                        GameObject.Find("AnimaisController").GetComponent<AnimaisController>().setRighitBalancedTo(true);
                        break;
                    default:
                        break;
                }
            }

        }
        else {
            counter = 0;
        }
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(objectToCollide.gameObject.name)) {
            print("PAAAAAAAA");
            hasRightObject = true;
        }
        
    }
}
