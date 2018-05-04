using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField] private int enemyCount = 0;
    public string nextLevel;
    [HideInInspector] public static GameManager gameManager;
    // Use this for initialization

    private void Awake()
    {
        gameManager = this;
    }
	
	public void EnemyDie()
    {
        enemyCount -= 1;
        if (enemyCount <= 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
