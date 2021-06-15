using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRaycast : MonoBehaviour
{

    public float rayLength = 10f;
    public float gravityPull = 4f;
    Rigidbody2D rb;
    BoxCollider2D col;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        col = gameObject.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), rayLength, LayerMask.GetMask("Player"));

        if (hit)
        {
            rb.gravityScale = gravityPull;
            StartCoroutine(DestroySelf());
            // Debug.Log(hit.collider.name);
            // Debug.DrawLine(transform.position, hit.transform.position, Color.red);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - rayLength, 0));

    }
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
