using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update

    private float sinal = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -4) {
            sinal = 1;
        }
        if (transform.position.x >= 4) {
            sinal = -1;
        }
        transform.position = transform.position + new Vector3(0.1f*sinal,0,0);
//        Debug.Log(transform.position);
        
    }
}
