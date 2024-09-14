using System.Collections;
using UnityEngine;

public sealed class Explosion : MonoBehaviour
{
    private ParticleSystem _explosionEffect;

    private void Awake()
    {
        transform.SetParent(null);
        _explosionEffect = GetComponent<ParticleSystem>();
    }

    private IEnumerator Start()
    {
        float animationTime = _explosionEffect.main.duration;
        _explosionEffect.Play();

        yield return new WaitForSeconds(animationTime);

        Destroy(gameObject);
    }
}
