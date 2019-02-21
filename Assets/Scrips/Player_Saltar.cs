using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Saltar : MonoBehaviour
{
    private float saltos;
    private Animator animator;
    private Rigidbody2D rg2d;
    private float direccion;
    private float tiempoAnimacion;
    public float cantidadSaltos;
    public bool shumpo;
    public float fuerzaSalto;
    public float poderShumpo;
    // Start is called before the first frame update
    void Start()
    {
        direccion = 1;
        animator = GetComponent<Animator>();
        rg2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && saltos > 0)
        {

            rg2d.velocity = new Vector2(rg2d.velocity.x, 0);
            Vector3 jumpPower = new Vector3(0, fuerzaSalto, 0);
            rg2d.AddForce(jumpPower, ForceMode2D.Impulse);
            animator.SetBool("tocaPiso", false);
            saltos -= 1;

        }
        if (Input.GetKeyDown(KeyCode.L) && shumpo)
        {
            if (Input.GetKey(KeyCode.A))
            {

                animator.SetBool("shumpo", true);
                rg2d.transform.position = new Vector3((rg2d.transform.position.x - poderShumpo), rg2d.transform.position.y, rg2d.transform.position.z);

            }
            if (Input.GetKey(KeyCode.D))
            {

                animator.SetBool("shumpo", true);
                rg2d.transform.position = new Vector3((rg2d.transform.position.x + poderShumpo), rg2d.transform.position.y, rg2d.transform.position.z);

            }

        }
        if (Input.GetKeyUp(KeyCode.L) && shumpo)
        {
            animator.SetBool("shumpo", false);

        }
    }
    private void FixedUpdate()
    {
       



    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        saltos = cantidadSaltos;
        animator.SetBool("tocaPiso", true);
    }
}
