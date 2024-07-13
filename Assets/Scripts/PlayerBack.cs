using UnityEngine;

public class PlayerBack : MonoBehaviour
{
    private void Update()
    {
        transform.position = FindObjectOfType<PlayerController>().transform.position;
    }
}