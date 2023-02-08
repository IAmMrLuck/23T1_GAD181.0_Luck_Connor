using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SimpleSceneLoader
{

    public class SceneLoader : MonoBehaviour
    {
        //need a feature which loads X scene when it is collided with

        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            // if it is the player who interacts with the tag
            if (other.tag == "Player")
            {
                //load the scene
                SceneManager.LoadScene(sceneToLoad);
                
            }
        }
    }
}
