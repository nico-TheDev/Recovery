using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRaycast : MonoBehaviour
{

    public float rayLength = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), rayLength, LayerMask.GetMask("Player"));

        if (hit)
        {
            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
            BoxCollider2D col = gameObject.AddComponent<BoxCollider2D>();
            col.isTrigger = true;
            rb.gravityScale = 4f;

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
