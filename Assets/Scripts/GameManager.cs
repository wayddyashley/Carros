using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            SceneManager.LoadScene("Juego");
        }
    }
}
