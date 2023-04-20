using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float velocidadMovimineto;
    [SerializeField] private float distancia;
    [SerializeField] private LayerMask queEsPared;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2d.velocity = new Vector2(velocidadMovimineto * transform.right.x, rb2d.velocity.y);
        RaycastHit2D informacionPared = Physics2D.Raycast(transform.position, transform.right, distancia, queEsPared);
        if (informacionPared)
        {
            Girar();
        }
    }

    private void Girar()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * distancia);
        
    }
}
