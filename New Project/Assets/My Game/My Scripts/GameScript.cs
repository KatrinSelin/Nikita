using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

    public Transform level2enemies;
    public bool level2complete = false;
    public GameObject level2rewards;


	// Use this for initialization
	protected void Start () {
		
	}

	// Update is called once per frame
	protected void Update () {
		
        if (level2enemies.childCount == 0 && level2complete == false)
        {
            HUD.Message("You hajkdhsakfj");
            level2complete = true;
            level2rewards.SetActive(true);
        }

	}
}