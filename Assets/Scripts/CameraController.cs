using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _smoothSpeed;
    [SerializeField] private float _focusDifference;
    private Vector3 _desiredPosition;
    private float _previousY = -4.5f;

    public void MoveCameraSmoothly(Vector3 newPosition)
    {
        if (newPosition.y > _previousY)
        {
            _desiredPosition = new Vector3(transform.position.x, newPosition.y + _focusDifference, transform.position.z);
            _previousY = newPosition.y;
            StartCoroutine(SmoothMove());
        }
    }

    private IEnumerator SmoothMove()
    {
        while (Vector3.Distance(transform.position, _desiredPosition) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }
}