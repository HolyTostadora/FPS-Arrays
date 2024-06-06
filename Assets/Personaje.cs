using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int nivelHambre;
    public AlimentoScript alimento;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TomarAlimento (int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
        if(nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }
}
