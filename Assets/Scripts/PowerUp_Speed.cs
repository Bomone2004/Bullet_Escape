using UnityEngine;

public class PowerUp_Speed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.GetComponent<CameraController>()) return;
        Destroy(gameObject);
    }
}
