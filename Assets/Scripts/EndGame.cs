using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManger GameManager;
    void OnTriggerEnter() {
        GameManager.LevelCom();
    }
}
