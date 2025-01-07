using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip bump;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip noot;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "ancher")
        {
            audio.PlayOneShot(noot);
        }
        if (collision.gameObject.tag == "domino")
        {
            audio.PlayOneShot(crash);
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(500f, collision.transform.position, 15f);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.clip = bump;
            audio.Play();
           // audio.PlayOneShot(bump);
        }
    }
}