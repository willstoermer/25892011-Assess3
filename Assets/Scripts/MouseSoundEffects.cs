using UnityEngine;

public class MouseSoundEffects : MonoBehaviour
{
    [SerializeField] private AudioClip notEatingSound;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying) 
        {
            audioSource.PlayOneShot(notEatingSound);
        }
    }
}
