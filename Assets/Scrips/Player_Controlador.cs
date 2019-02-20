using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controlador : MonoBehaviour
{
    private bool hombre;
    
    private Rigidbody2D rgb2;
    private Animator animator;
    private float direccion;
    public static float velocidad = 8;
    private float posX;
    private float posY;
    public static float velocidadMax = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        rgb2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        hombre = animator.GetBool("hombre");
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        mermarVelocidadX();
        verificarGenero();
        RealizarMovimientoCorrer();
    }
    private void RealizarMovimientoCorrer() {
        posX = rgb2.transform.position.x;
        posY = rgb2.transform.position.y;

        if (Input.GetKey(KeyCode.A))
        {
            direccion = -1;
            rgb2.velocity = new Vector3(velocidad * direccion, rgb2.velocity.y, 0);
            animator.SetFloat("velocidad", Mathf.Abs(rgb2.velocity.x));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direccion = 1;
            rgb2.velocity = new Vector3(velocidad * direccion, rgb2.velocity.y, 0);
            animator.SetFloat("velocidad", Mathf.Abs(rgb2.velocity.x));

        }
            rgb2.transform.position = new Vector3(posX, posY, 0);

        if (direccion == -1)
        {
            rgb2.transform.localScale = new Vector3(Mathf.Abs(rgb2.transform.localScale.x), rgb2.transform.localScale.y, rgb2.transform.localScale.z);
        }
        else {
            rgb2.transform.localScale = new Vector3(-Mathf.Abs(rgb2.transform.localScale.x), rgb2.transform.localScale.y, rgb2.transform.localScale.z);
        }
        if (rgb2.velocity.x > velocidadMax)
        {
            Debug.Log("Entro");
            rgb2.velocity = rgb2.velocity = new Vector3(velocidadMax, rgb2.velocity.y, 0);
        }
        else if (rgb2.velocity.x < -velocidadMax)
        {
            rgb2.velocity = rgb2.velocity = new Vector3(-velocidadMax, rgb2.velocity.y, 0);
        }

    }

 
    private void verificarGenero() {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("hombre", !animator.GetBool("hombre"));
            hombre = !hombre;
        }
        if (hombre)
        {
          
            rgb2.transform.localScale = new Vector3(7.2f, 7.2f, 0);
        }
        else {
          
            rgb2.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        }
    }
    private void mermarVelocidadX() {

       rgb2.velocity = new Vector3((rgb2.velocity.x * 0.5f), rgb2.velocity.y, 0);
        Debug.Log("entro");
       animator.SetFloat("velocidad", (rgb2.velocity.x * 0.5f));
    }
}
