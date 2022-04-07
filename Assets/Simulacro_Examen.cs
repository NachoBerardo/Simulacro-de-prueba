using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro_Examen : MonoBehaviour
{
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la 
    //suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

    public float producto1;
    public float producto2;
    public float producto3;
    public float DineroDisponible;

    void Start()
    {
        if ((producto1+producto2+producto3) < DineroDisponible)
        {
            Debug.Log("La suma de precios no supera el monto de dinero disponible");
            Debug.Log("Sobran $ " + (DineroDisponible - (producto1 + producto2 + producto3)));
        }

        else if ((producto1 + producto2 + producto3) > DineroDisponible)
        {
            Debug.Log("La suma de precios supera el monto de dinero disponible");
            Debug.Log("Faltan $ " + ( (producto1 + producto2 + producto3) - DineroDisponible));
        }

        else if ((producto1 + producto2 + producto3) == DineroDisponible)
        {
            Debug.Log("La suma de precios es igual al monto de dinero disponible");
            Debug.Log("No sobra ni falta");
        }

    }


}
