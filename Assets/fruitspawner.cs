using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitspawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruit());
    }

    // Update is called once per frame
    IEnumerator SpawnFruit(){
        while(true){
            GameObject go = Instantiate(fruits[Random.Range(0,fruits.Length)]);
            Rigidbody temp = go.GetComponent<Rigidbody>();
            temp.velocity = new Vector3(0f,8f,.5f);
            temp.useGravity = true;
            Vector3 pos =transform.position;
            pos.x = Random.Range(-0.5f,0.5f);
            go.transform.position = pos;

            yield return new WaitForSeconds(1f);
        }
    }
}
