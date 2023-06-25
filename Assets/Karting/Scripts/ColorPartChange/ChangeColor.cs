using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update

    public Renderer rend;
    public GameObject SideLine;

    public Color myColor;
    public float rFloat;
    public float gFloat;
    public float bFloat;

    // [SerializeField] public Color newColor;
    // [SerializeField] public Color[] colors;

    //private int colorValue;

    void Start()
    {
        rend = SideLine.GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (rFloat < 1)
            {
                rFloat += 0.01f;
            }
            else { rFloat = 0; }
        }

        if (Input.GetKey(KeyCode.G))
        {
            if (gFloat < 1)
            {
                gFloat += 0.01f;
            }
            else { gFloat = 0; }
        }

        if (Input.GetKey(KeyCode.B))
        {
            if (bFloat < 1)
            {
                bFloat += 0.01f;
            }
            else { bFloat = 0; }
        }

        myColor = new Color(rFloat, gFloat, bFloat);
        rend.material.color = myColor;
    }



    /*
    public void ChangeMaterial()
    {

        rend.material.color = newColor;
    }
    */
}
