using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundsController : MonoBehaviour
{
    [SerializeField] private AudioClip _tapSound;
    [SerializeField] private AudioClip _looseBall;
    [SerializeField] private AudioClip[] _playlist;

    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        
    }

    public void TapSound()
    {
        _source.clip = _tapSound;
        _source.Play();
    }

    public void LooseBall()
    {
        _source.clip = _looseBall;
        _source.Play();
    }
}
