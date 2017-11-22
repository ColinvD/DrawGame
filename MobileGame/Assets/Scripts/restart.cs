using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

    private DrawScript draw;

    public void RestartGame()
    {
        
        Application.LoadLevel(0);
    }
}
