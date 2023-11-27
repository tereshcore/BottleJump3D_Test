using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallToAction : MonoBehaviour
{
    [SerializeField] private GameObject CTApanel;
    private void OnTriggerEnter(Collider other)
    {
        Player player= other.GetComponent<Player>();
        if(player)
        {
            CTApanel.SetActive(true);
            Destroy(player);
        }
    }
}
