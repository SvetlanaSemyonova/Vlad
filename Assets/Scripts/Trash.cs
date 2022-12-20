using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Trash : MonoBehaviour
    {
        public void OnDestroy()
        {
            if (GameObject.FindWithTag("Player"))
            {
                
            }
        }
    }
}