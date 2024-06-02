using UnityEngine;

public class SingleNonLoopingSoundTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    private static AudioSource currentlyPlayingSource;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        audioSource.loop = false;  // Ensure the audio source is not set to loop
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (currentlyPlayingSource != null && currentlyPlayingSource.isPlaying)
            {
                currentlyPlayingSource.Stop();
            }
            currentlyPlayingSource = audioSource;
            PlaySound();
        }
    }

    private void PlaySound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}

