using UnityEngine;

public class GameUI : MonoBehaviour
{
    // set variables
    public GameObject gameMenusUI;

    // Update is called once per frame
    void Update()
    {
        // to activate or deactivate the Game Menu using a Keyboard Key
        if (Input.GetKey(KeyCode.L))
        {
            gameMenusUI.SetActive(gameMenusUI.activeSelf);
        }
    }
}
