using System;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private ParticleSystem partSystem;

    public static Action OnCrash, OnWin;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        {
            partSystem.transform.position = transform.position;
            partSystem.Play();
            gameObject.SetActive(false);
            OnCrash?.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
            OnWin?.Invoke();
    }
}
