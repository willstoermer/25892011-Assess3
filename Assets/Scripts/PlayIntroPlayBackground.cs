using UnityEngine;

public class PlayIntroPlayBackground : MonoBehaviour
{
    [SerializeField] private AudioClip introMusic;
    [SerializeField] private AudioClip backgroundMusic;

    private AudioSource audioSource;

    private string currentAudio = "Intro";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(introMusic);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3 && currentAudio == "Intro") {
            audioSource.Stop();
            audioSource.PlayOneShot(backgroundMusic);
            currentAudio = "Background";
        }
    }
}
