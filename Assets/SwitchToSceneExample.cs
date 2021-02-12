using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class SwitchToSceneExample : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.transform.parent?.transform.parent?.GetComponent<Player>())
        {
            SceneManager.LoadScene("corridor_33");
        }
    }
}
