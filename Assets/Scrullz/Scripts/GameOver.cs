using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public bool IsGameOver;
    // Update is called once per frame
    void Update () {
        if ( IsGameOver ) {
            Application.LoadLevel( "GameOver" );
        }
    }
}
