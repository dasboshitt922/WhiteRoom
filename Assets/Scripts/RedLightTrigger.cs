using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightTrigger : MonoBehaviour
{
    [SerializeField] private GameObject CeilingParent;
    [SerializeField] private GameObject RedLights;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CeilingParent.SetActive(false);
            RedLights.SetActive(true);
        }
    }
}
