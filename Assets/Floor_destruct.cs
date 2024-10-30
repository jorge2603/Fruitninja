using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_destruct : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        // Comprueba si el objeto que colisionó tiene la etiqueta "Katana"
        if (collision.gameObject.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject); // Destruye el objeto que tiene este script
          
        }
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject); // Destruye el objeto que tiene este script
        }
    }
}