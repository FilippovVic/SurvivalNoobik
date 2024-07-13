using System.Collections;
using UnityEngine;

public class DestroyerController : MonoBehaviour
{
    [SerializeField] private float _smoothSpeed;
    [SerializeField] private float _focusDifference;
    private Vector3 _desiredPosition;

    public void MoveDestroyerSmoothly(Vector3 newPosition)
    {
        _desiredPosition = new Vector3(transform.position.x, newPosition.y - _focusDifference, transform.position.z);
        StartCoroutine(SmoothMove());
    }

    private IEnumerator SmoothMove()
    {
        while (Vector3.Distance(transform.position, _desiredPosition) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}