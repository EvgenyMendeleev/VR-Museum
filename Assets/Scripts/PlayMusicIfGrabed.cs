using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PlayMusicIfGrabed : MonoBehaviour
{
    [SerializeField] private AudioClip voiceOfGuider;
    private Interactable interactable;
    private AudioSource soundSource;

    void Start()
    {
        interactable = GetComponent<Interactable>();
        soundSource = gameObject.AddComponent<AudioSource>();
        soundSource.clip = voiceOfGuider;
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes grabTypes = hand.GetGrabStarting();
        if (interactable.attachedToHand == null && grabTypes != GrabTypes.None)
        {
            if (!soundSource.isPlaying)
            {
                soundSource.Play();
            }
        }
    }
}