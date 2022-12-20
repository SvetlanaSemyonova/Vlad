using System;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class Burner : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            if (GameObject.FindWithTag("Player"))
            {
                Destroy(GameObject.FindWithTag("Player"));
            }
        }


    }        
    

}