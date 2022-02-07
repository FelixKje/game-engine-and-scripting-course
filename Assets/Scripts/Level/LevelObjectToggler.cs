using UnityEngine;

public class LevelObjectToggler : MonoBehaviour{
    [SerializeField] GameObject[] gameObjectsToToggle;

    public void ToggleObjects(){
        foreach (var gameObjectToToggle in gameObjectsToToggle){
            gameObjectToToggle.SetActive(!gameObjectToToggle.activeSelf);
        }
    }
}
