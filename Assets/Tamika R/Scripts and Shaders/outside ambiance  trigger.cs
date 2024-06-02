using UnityEngine;

public class OutsideTriggerScript : MonoBehaviour
{
    public AudioSource[] outsideAmbianceSources;
    public AudioSource[] caveAmbianceSources;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllAudioSources(caveAmbianceSources);
            PlayAllAudioSources(outsideAmbianceSources);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllAudioSources(outsideAmbianceSources);
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

