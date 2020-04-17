using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;
    public float GameDelay = 2f;
    public GameObject LevelComplete;
    public void LevelCom(){
        LevelComplete.SetActive(true);
    }
    public void EndGame(){
      
      if (gameHasEnded == false){
        gameHasEnded = true;
        Debug.Log("Game Over!!!");
        Invoke("Restart", GameDelay);
      }  
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
