using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombdestroy : MonoBehaviour
{
    public Vidadisplayer vidadisplayer; // Referencia al script Vidadisplayer
    // Este método se llama automáticamente cuando ocurre una colisión con otro objeto
    void OnCollisionEnter(Collision collision)
    {
        // Comprueba si el objeto que colisionó tiene la etiqueta "Katana"
        if (collision.gameObject.CompareTag("Katana"))
        {
            Destroy(gameObject); // Destruye el objeto que tiene este script
            vidadisplayer.SetVidaPoints(vidadisplayer.vidapoints - 1); // Reduce la vida en 1
        }
    }
}