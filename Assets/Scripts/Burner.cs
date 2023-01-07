using System;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class Burner : MonoBehaviour
    {
        [SerializeField] private GameObject Trash;

        private void FixedUpdate()
        {
        }

        /*private void Respawn()
        {
            if (Trash.activeInHierarchy == false)
            {
                Trash.SetActive(true); 
            }
            else
            {
                return;
            }
        }*/
        
        
      
    }        
    

}