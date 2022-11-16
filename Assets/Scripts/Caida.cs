using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{

    [SerializeField]
    private float _velocidad = -5;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            0,
            _velocidad * Time.deltaTime,
            0
        );
    }
}
