using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    [SerializeField] private AudioClip crashSound;
    [SerializeField] private AudioClip deliverySound;

    private AudioSource _audioSource;

    private void OnEnable()
    {
        PlayerCollisions.OnCrash += PlayCrashSound;
        Delivery.OnDelivery += PlayDeliverySound;
    } 

    private void OnDisable()
    {
        PlayerCollisions.OnCrash -= PlayCrashSound;
        Delivery.OnDelivery -= PlayDeliverySound;
    }

    private void Start() => _audioSource = GetComponent<AudioSource>();

    private void PlayCrashSound() => _audioSource.PlayOneShot(crashSound);
    private void PlayDeliverySound() => _audioSource.PlayOneShot(deliverySound);
}
