using System;
using UnityEngine;

public class GameOverOnCollision : MonoBehaviour
{
    GameManager _turretsManager;
    public int Hp = 5;

    private void Start()
    {
        _turretsManager = GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MoveBullet>())
        {
            Hp--;
            if (Hp <= 0)
            {
                _turretsManager.GameOver();
                Destroy(GetComponent<Collider>()); //Destroy collider to stop being hit
            }
        }
        if (other.gameObject.GetComponent<PowerUP_Hp>()) Hp+=1;

        Debug.Log(Hp);
    }
}
