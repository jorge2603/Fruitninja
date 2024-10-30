using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class Destroy_on_collision : MonoBehaviour
{
    public Vidadisplayer vidaDisplayer;

    public GameObject activator;
   
    // Este método se llama automáticamente cuando ocurre una colisión con otro objeto
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
            vidaDisplayer.SetVidaPoints(vidaDisplayer.vidapoints - 1);
        }

        if (collision.gameObject.CompareTag("Activator"))
        {   
            collision.gameObject.SetActive(false);
            activator.SetActive(true);
        }
    }
}