using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform moveSplot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public Animator anim2D;
    public Vector3 dir;
    public Transform target;

    void Start()
    {
     //   anim.SetBool("IsAtacking", true);
        waitTime = startWaitTime;
        moveSplot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        move();
        moveAnim();
    }
    void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSplot.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSplot.position) < 0.2f)
        {
            moveSplot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            waitTime = startWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
    void moveAnim()
    {
        dir = transform.position;
        anim2D.SetFloat("x", dir.x);
        anim2D.SetFloat("y",dir.y );
        dir.Normalize();
    }
}
