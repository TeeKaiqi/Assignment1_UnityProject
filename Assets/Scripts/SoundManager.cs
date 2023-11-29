using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class SoundManager : MonoBehaviour
//{
//    public AudioClip dirtFS;
//    public AudioClip concreteFS;
//    public AudioClip woodFS;

//    public AudioSource source;
//    enum FSMaterial
//    {
//        Grass, Concrete, Wood, Empty
//    }


//    // Start is called before the first frame update
//    void Start()
//    {
//        source = GetComponent<AudioSource>();
//    }
    
//    public void PlayGrassFootsteps (AudioSource grassSound)
//    {
//        grassSound.Play();
//    }


    //// Play the given footstep sound
    //void PlayFootstepSound(AudioClip footstepSound)
    //{
    //    if (footstepSound != null)
    //    {
    //        source.clip = footstepSound;
    //        source.Play();
    //    }
    //}
    //private FSMaterial SurfaceSelect()
    //{
    //    RaycastHit hit;
    //    Ray ray = new Ray(transform.position + Vector3.up * 0.5f, -Vector3.up);
    //    Material surfaceMaterial;
        
    //    if (Physics.Raycast(ray,out hit, 1.0f, Physics.AllLayers, QueryTriggerInteraction.Ignore))
    //    {
    //        Renderer surfaceRenderer = hit.collider.GetComponentInChildren<Renderer>();
    //        if (surfaceRenderer)
    //        {
    //            surfaceMaterial = surfaceRenderer ? surfaceRenderer.sharedMaterial : null;
    //            if (surfaceMaterial.name.Contains("Dirt"))
    //        }
    //    }

    //}

//    void PlayFootstep()
//    {
//        AudioClip clip;
//        FSMaterial surface = SurfaceSelect();
//        switch (surface)
//        {
//            case FSMaterial.Grass:
//                clip = dirtFS;
//                    break;
//            case FSMaterial.Concrete:
//                clip = concreteFS;
//                break;
//            case FSMaterial.Wood:
//                clip = woodFS;
//                break;

//        }
//        Debug.Log(surface);

//        if (surface != FSMaterial.Empty)
//        {
//            source.clip = clip;
//            source.volume = Random.Range(0.02f, 0.05f);
//            source.pitch = Random.Range(0.08f, 1.2f);

//        }
//    }
//}
