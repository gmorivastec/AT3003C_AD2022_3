using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChequeoColisiones : MonoBehaviour
{
    [SerializeField]
    private string _tagItem = "item";

    [SerializeField]
    private string _tagEnemigo = "enemigo";

    [SerializeField]
    private UnityEvent _tocoItem;

    [SerializeField]
    private UnityEvent _tocoEnemigo;
    
    void OnTriggerEnter(Collider c){

        print(c.transform.tag);

        if(c.transform.tag == _tagEnemigo)
            _tocoEnemigo?.Invoke();
        
        if(c.transform.tag == _tagItem)
            _tocoItem?.Invoke();
    }
}
