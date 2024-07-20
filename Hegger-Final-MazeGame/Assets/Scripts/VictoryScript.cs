using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    public string VictorySceneName;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Player Entered");
        SceneManager.LoadScene(VictorySceneName);
    }
}
