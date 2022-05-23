using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnemyInterationHandler : MonoBehaviour
{
    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Enemy"))
        {
            Debug.Log("Enemy:");
        }

    }
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Enemy"))
        {
            Transform t = args.interactableObject.transform;
            t.localScale *= 0.5f;
        }
    }
}
