using System;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class Trash : MonoBehaviour
    {
        [SerializeField] private GameObject myGameObject;
        [SerializeField] private GameObject Ground;

        void Update()
        {
            if (myGameObject.activeInHierarchy == false)
            {
                //Respawn();
                // .SetPositionAndRotation(new Vector3(-1.5f, 5, -1.2f), Quaternion.identity);
            }
        }

        private void Respawn()
        {
            if (myGameObject.activeInHierarchy == false)
            {
                myGameObject.SetActive(true);
                myGameObject.transform.position = new Vector3(-1.5f, 5, -1.2f);
            }
        }
        
        public void OnTriggerEnter(Collider other)
        {
            if(Ground)
            {
                myGameObject.SetActive(false);
                Respawn();
                // myGameObject.transform.position = new Vector3(-1.5f, 5, -1.2f);
            }
        }
    }
}