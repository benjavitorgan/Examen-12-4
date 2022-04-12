//Se debe ingresar la cantidad de entradas vendidas para cada tipo.
////Sabemos que el límite de espectadores totales en el predio del evento es de 20,400 personas en Campo 
//y 16,200 en Plateas y el precio de las entradas es de $1200 para Campo y $2000 para Platea.


////El programa debe cumplir los siguientes requerimientos:
////Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo y de plateas 
//por separado y luego el total sumado. ----


////Se debe mostrar qué cantidad del total de la capacidad del predio quedó vacante.Si las entradas 
//vendidas equivalen al total de la capacidad del predio debe mostrarse además el mensaje “Sold Out!”. ----


////Si la suma de la cantidad de entradas para ambos tipos supera la mitad de la  capacidad del predio 
//debe mostrarse el mensaje “El festival fue un éxito!”. Si no lo supera debe mostrarse “Debemos mejorar la convocatoria. 


////Debe mostrarse un mensaje de error descriptivo y no realizar ningún cálculo si la cantidad de entradas  ----
//vendidas en cualquiera de los tipos es menor a cero o superior a la capacidad del predio para ese tipo.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapallooza : MonoBehaviour
{
    public const int maxima_campo = 20400; //1200
    public const int maxima_platea = 16200; //2000
    public const int cap_maxima_total = 36600; 
    public int cant_campo;
    public int cant_platea;
    int cant_total;
    int cap_vacante;

    // Start is called before the first frame update
    void Start()
    {
        if (cant_campo > 0 && cant_campo <= maxima_campo && cant_platea > 0 && cant_platea <= maxima_platea)
        {
            cant_total = cant_campo + cant_platea;

            Debug.Log("La cantidad de entradas de campo que se vendieron es: " +cant_campo+ " y la cantidad de entradas de platea que se vendieron es: " +cant_platea+ ". En total, se vendieron:" + cant_total + " entradas.");

            cap_vacante = cap_maxima_total - cant_total;

            if (cant_total < cap_maxima_total)
            {
                Debug.Log("Quedaron disponibles " +cap_vacante+ " entradas.");
            } else if (cant_total == cap_maxima_total)
            {
                Debug.Log("¡SOLD OUT!");
            }

            if (cant_total > (cap_maxima_total / 2))
            {
                Debug.Log("El festival fue un exito");
            } else
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }

        } else
        {
            Debug.Log("ERROR! La cantidad ingresada de entradas en alguno de los tipos es menor a cero o excede el limite de ventas posible. Intente ingresar un numero distinto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
