using UnityEngine;

public class CaveTriggerScript : MonoBehaviour
{
    public AudioSource[] outsideAmbianceSources;
    public AudioSource[] caveAmbianceSources;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllAudioSources(outsideAmbianceSources);
            PlayAllAudioSources(caveAmbianceSources);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllAudioSources(caveAmbianceSources);
        }
    }

    private void PlayAllAudioSources(AudioSource[] audioSources)
    {
        foreach (var audioSource in audioSources)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void StopAllAudioSources(AudioSource[] audioSources)
    {
        foreach (var audioSource in audioSources)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}

