using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _uiVida;

    public void CambioVida(float nuevaVida){
        _uiVida.text = nuevaVida + "";
    }
}
