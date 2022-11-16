using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComprobadorVida : MonoBehaviour
{
    public void DetectarTreinta(float vida){

        if(vida <= 30){
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void VidaTermino(){
        SceneManager.LoadScene(1);
    }
}
