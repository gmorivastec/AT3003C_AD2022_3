using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField]
    private float _velocidad;

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(
            h * Time.deltaTime * _velocidad,
            v * Time.deltaTime * _velocidad,
            0
        );
    }
}
