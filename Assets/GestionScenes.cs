using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GestionScenes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            DemarrerJeu();
        }
        
    }

    public void DemarrerJeu()
    {
        SceneManager.LoadScene("Niveau1");
    }
}
