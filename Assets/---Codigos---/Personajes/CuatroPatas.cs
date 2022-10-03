using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuatroPatas : Enemigos
{
    public float checkRadius;
    public float attackRadius;

    public bool shouldRotate;
    public LayerMask whatIsPlayer;
    public float distance;
    public float parrar;

    private Transform target;
    private Animator anim;
    private Vector2 movement;
    public Vector3 dir;

    public bool isInChaseRange;
    public bool isInAttackRange;

    public GameObject chuleta;
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MovementCharacter(movement);
            Move();
        }
    }
    private void FixedUpdate()
    {//  anim.SetBool("isRunning", isInChaseRange);
        if (vidaActual <= 0)
        {
            // Instantiate(chuleta, Vector2.zero, Quaternion.identity);
            Instantiate(chuleta, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
      //  if ((Vector3.Distance(target.transform.position, transform.position) < distance) && Vector3.Distance(target.transform.position, transform.position) > parrar && vidaActual > 0)
        {
       //     MovementCharacter(movement);
         //   Move();
        }
    }
    private void MovementCharacter(Vector2 dir)
    {
        rb.MovePosition((Vector2)transform.position + (dir * speed * Time.deltaTime));
    }
    public void Move()
    {
        isInChaseRange = Physics2D.OverlapCircle(transform.position, checkRadius, whatIsPlayer);
        isInAttackRange = Physics2D.OverlapCircle(transform.position, attackRadius, whatIsPlayer);

        dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        dir.Normalize();
        movement = dir;
        if (shouldRotate)
        {
            anim.SetFloat("x", dir.x);
            anim.SetFloat("y", dir.y);
        }

        if (isInAttackRange)
        {
            rb.velocity = Vector2.zero;
        }

    }
}
