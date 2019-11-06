using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
    public GameObject text;
    public EnemyBox box;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void GameOver() {
        text.SetActive(true);
        box.Stop();
        Enemy[] enemies=GameObject.FindObjectsOfType<Enemy>();
        foreach(var ene in enemies) {
            ene.enabled=false;
        }
    }
}
