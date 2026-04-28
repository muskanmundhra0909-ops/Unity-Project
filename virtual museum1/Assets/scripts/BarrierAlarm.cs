using UnityEngine;

public class BarrierAlarm : MonoBehaviour
{
    public AudioSource alarmSound;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            alarmSound.Play();
        }
    }
}
