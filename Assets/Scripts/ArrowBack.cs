using UnityEngine;

public class ArrowBack : MonoBehaviour
{
    private void Start()
    {
        Vector3 _direction = FindObjectOfType<PlayerController>().transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _direction.normalized);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBack"))
        {
            Destroy(gameObject);
            Destroy(FindObjectOfType<PlayerController>().gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("LeftColl") || collision.CompareTag("RightColl"))
        {
            Destroy(gameObject);
        }
    }
}