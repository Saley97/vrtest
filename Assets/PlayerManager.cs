using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {
    public static GameObject currentTarget = null;
    public float attackDelay = 1f;
    private float attakTime = 0f;
    public float damage = 35f;
    public float hp = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(attakTime > 0f)
        {
            attakTime -= Time.deltaTime;
        }

        if(currentTarget != null && attakTime <= 0)
        {
            Shoot();
        }
	}

    void Shoot()
    {
        Debug.Log("shoot");
        currentTarget.GetComponent<EnemyScript>().ReciveDamage(damage);
        attakTime = attackDelay;
    }

    public void ReciveDamage(float dmg)
    {
        hp -= dmg;
        if(hp <= 0f)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
