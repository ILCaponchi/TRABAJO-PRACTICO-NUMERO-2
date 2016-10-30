using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    private Animator myAnimator;
    [SerializeField]
    private float VelocidadMovimiento;
    private bool mirarDerecha;
	// Use this for initialization
	void Start ()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mirarDerecha = true;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        Movimiento(horizontal);
        Flip(horizontal);
	}
    private void Movimiento(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal*VelocidadMovimiento, myRigidBody.velocity.y);
        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void Flip (float horizontal)
    {
        if(horizontal > 0 && !mirarDerecha || horizontal < 0 && mirarDerecha )
        {

            mirarDerecha = !mirarDerecha;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }

    }
}
