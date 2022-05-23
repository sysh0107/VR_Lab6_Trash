using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBuddyController : MonoBehaviour
{
    //public AudioSource audio1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //audio1.Play();
        //GameManager.scoreTask2 += 1;
        Destroy(other);

    }
}
