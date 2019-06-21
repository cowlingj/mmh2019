using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class DemoRunner : MonoBehaviour
{
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        bool firePressed = CrossPlatformInputManager.GetButton("Cancel");
        menu.SetActive(firePressed);
    }

    public void LoadLevel(string name) {
        Debug.Log(name);
        if (name.Equals("")) {
            Application.Quit();
            return;
        }
        SceneManager.LoadScene(name);
    }
}
