using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camiarGenero : MonoBehaviour
{
 
    public Transform mujer;
    private bool esHombre;
    private Rigidbody2D hijo;
    private float posx;
    private float posy;
    private Transform tf;
   
    private bool esMujer;

    // Start is called before the first frame update
    void Start()
    {

        tf = GetComponent<Transform>();
        esHombre = false;
        esMujer = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&!esHombre) {
            tf.position = new Vector3(mujer.transform.position.x, mujer.transform.position.y+1, 0);
            mujer.position = new Vector3(-14.35f, 6f, 0);
            esHombre = true;
            esMujer = false;
        }
        if (Input.GetKeyDown(KeyCode.E)&&!esMujer) {
            mujer.position = new Vector3(tf.position.x, tf.position.y+1, 0);
            tf.position = new Vector3(-14.35f, 6, 0);
            esHombre = false;
            esMujer = true;
    
        }

      
    }
}
