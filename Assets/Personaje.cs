using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int nivelHambre;

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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        TomarAlimento(alimento.valorAlimentario);
    }
}
