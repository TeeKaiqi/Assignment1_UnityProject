using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField]
    private AudioClip dirtFootstep;
    [SerializeField]
    private AudioClip concreteFootstep;
    [SerializeField]
    private AudioClip woodFootstep;

    private AudioSource audioSource;
    public LayerMask groundLayer;

    public GameObject character;

    public float raycastHeightOffset = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    private void Step()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f, groundLayer))
        {
            string groundTag = hit.collider.gameObject.tag;

            Debug.Log("Raycast Hit: " + hit.collider.gameObject.name);
            Debug.Log("Ground Tag: " + groundTag);
            Debug.Log("Collider Position: " + hit.collider.gameObject.transform.position);
            Debug.Log("Collider Size: " + hit.collider.bounds.size);

            if (groundTag == "Dirt")
            {
                PlayFootstepSound(dirtFootstep);
            }
            if (groundTag == "Concrete")
            {
                PlayFootstepSound(concreteFootstep);
            }
            if (groundTag == "Wood")
            {
                PlayFootstepSound(woodFootstep);
            }
        }
        else
        {
            Debug.Log("Raycast did not hit anything.");
        }
    }

    private void PlayFootstepSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    
}
