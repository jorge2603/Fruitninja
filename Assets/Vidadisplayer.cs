using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidadisplayer : MonoBehaviour
{
    public int vidapoints = 3;
    public GameObject vidaicon;
    public Camera mainCamera;  // Arrastra tu cámara principal aquí en el Inspector.

    public GameObject game;
    public GameObject activator;
    private List<GameObject> icons = new List<GameObject>(); // Lista para rastrear los íconos actuales

    void Start()
    {
        UpdateVidaIcons();
    }

    // Método para cambiar el valor de `vidapoints` y actualizar íconos
    public void SetVidaPoints(int newVidaPoints)
    {
        vidapoints = newVidaPoints;
        UpdateVidaIcons();
        if (vidapoints == 0)
        {
            game.SetActive(false);
            activator.SetActive(true);
        }
    }

    private void UpdateVidaIcons()
    {
        // Elimina todos los íconos actuales
        foreach (GameObject icon in icons)
        {
            Destroy(icon);
        }
        icons.Clear();

        // Crea nuevos íconos según el valor actual de `vidapoints`
        for (int i = 0; i < vidapoints; i++)
        {
            GameObject icon = Instantiate(vidaicon, mainCamera.transform);

            // Ajusta la posición de cada ícono usando el nuevo vector
            icon.transform.localPosition = new Vector3(0f + (i * 0.03f), 0.03f, 0.2f);
            icon.transform.localRotation = Quaternion.identity; // Sin rotación adicional

            icons.Add(icon); // Añade el ícono a la lista
        }
    }
}