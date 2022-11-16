using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class VidaCambio : UnityEvent<float> {} 
public class Vida : MonoBehaviour
{

    [SerializeField]
    private float _vida = 100;

    [SerializeField]
    private VidaCambio _vidaCambio;

    [SerializeField]
    private UnityEvent _vidaTermino;

    private void InvocarEventos(){
        
        if(_vida > 0)
            _vidaCambio?.Invoke(_vida);
        else   
            _vidaTermino?.Invoke();
    }
    public void EnemigoTocado() {
    
        _vida -= 20;
        // ?. - safe call
        // llamada segura (obviamente...)
        // si el objeto es nulo no invoca lo que siga
        InvocarEventos();
    }
    
    public void ItemTocado() {

        _vida += 10;

        InvocarEventos();
    }   
}
