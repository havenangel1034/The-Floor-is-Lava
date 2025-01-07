using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip bump;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip noot;
    [SerializeField] AudioClip pluh;
    [SerializeField] AudioClip floor;
    [SerializeField] AudioClip BONG;
    [SerializeField] AudioClip mwhehe;
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
           // audio.PlayOneShot(bump)
        }

        if (collision.gameObject.tag == "the launcher")
        {
            audio.clip = pluh;
            audio.Play();
            // audio.PlayOneShot(bump);
        }
        if (collision.gameObject.tag == "floor")
        {
            audio.clip = floor;
            // audio.Play();
            audio.PlayOneShot(floor);
        }

        if (collision.gameObject.tag == "BONG")
        {
            audio.clip = BONG;
            // audio.Play();
            audio.PlayOneShot(BONG);
        }

        if (collision.gameObject.tag == "mwhehe")
        {
            audio.clip = mwhehe;
            // audio.Play();
            audio.PlayOneShot(mwhehe);
        }

    }
}