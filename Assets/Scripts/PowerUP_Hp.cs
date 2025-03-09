using UnityEngine;

public class PowerUP_Hp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.GetComponent<CameraController>()) return;
        Destroy(gameObject);
    }
}
