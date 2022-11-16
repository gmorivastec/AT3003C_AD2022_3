using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _originales;

    [SerializeField]
    private float _tiempoMinimo = 0.2f;

    [SerializeField]
    private float _tiempoMaximo = 2f;

    [SerializeField]
    private float _xMinimo;

    [SerializeField]
    private float _xMaximo;

    [SerializeField]
    private float _y;

    [SerializeField]
    private float _z;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());        
    }

    IEnumerator Spawn() {

        if(_originales == null || _originales.Length == 0){
            Debug.LogError("NO HAY OBJETOS ORIGINALES QUE SPAWNEAR");
        } else {

            while(true){
                
                GameObject nuevoObjeto = Instantiate<GameObject>(
                                            _originales[Random.Range(0, _originales.Length)]
                                            );
                
                nuevoObjeto.transform.position = new Vector3(
                    Random.Range(_xMinimo, _xMaximo),
                    _y,
                    _z
                );

                //nuevoObjeto.GetComponent<Collider>().isTrigger = true;

                yield return new WaitForSeconds(Random.Range(_tiempoMinimo, _tiempoMaximo));
            }
        }
    }
}
