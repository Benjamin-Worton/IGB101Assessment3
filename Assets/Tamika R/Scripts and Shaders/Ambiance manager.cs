using UnityEngine;

public class AmbianceManager : MonoBehaviour
{
    public AudioSource[] outsideAmbianceSources;
    public AudioSource[] caveAmbianceSources;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.name == "OutsideTrigger")
            {
                StopAllAudioSources(caveAmbianceSources);
                PlayAllAudioSources(outsideAmbianceSources);
            }
            else if (gameObject.name == "CaveTrigger")
            {
                StopAllAudioSources(outsideAmbianceSources);
                PlayAllAudioSources(caveAmbianceSources);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.name == "OutsideTrigger")
            {
                StopAllAudioSources(outsideAmbianceSources);
            }
            else if (gameObject.name == "CaveTrigger")
            {
                StopAllAudioSources(caveAmbianceSources);
            }
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


