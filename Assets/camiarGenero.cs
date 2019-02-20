using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camiarGenero : MonoBehaviour
{
    private bool hombre;
    private Rigidbody2D hijo;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            hombre = !hombre;
        }


        if (hombre) {
            hijo = GetComponentInChildren<Rigidbody2D>();
            
        }
    }
}
