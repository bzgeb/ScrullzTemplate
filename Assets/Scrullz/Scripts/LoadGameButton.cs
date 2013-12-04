using UnityEngine;
using System.Collections;

public class LoadGameButton : MonoBehaviour 
{
    void OnMouseUpAsButton() {
        Application.LoadLevel( "Game" );
    }
}
