using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSceneLogicScript : MonoBehaviour
{

    public ToggleGroup difficultyToggleGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartGameButton()
    {
        // Grab the difficulty value
        Toggle selectedToggle = null;

        foreach(Toggle t in difficultyToggleGroup.ActiveToggles())
        {
            selectedToggle = t;
        }

        GameManagerScript.StartGame(selectedToggle.gameObject.name);
    }
}
