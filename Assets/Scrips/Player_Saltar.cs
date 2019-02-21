using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Saltar : MonoBehaviour
{
    public float cantidadSaltos;
    private float saltos;
    public bool shumpo;
    private Animator animator;
    private Rigidbody2D rg2d;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W)&&saltos>0) {

            rg2d.velocity = new Vector2(rg2d.velocity.x, 0);
            Vector3 jumpPower = new Vector3(0, 7.5f, 0);
            rg2d.AddForce(jumpPower, ForceMode2D.Impulse);
            animator.SetBool("tocaPiso", false);
            saltos -= 1;

        }
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        saltos = cantidadSaltos;
        animator.SetBool("tocaPiso", true);
    }
}
