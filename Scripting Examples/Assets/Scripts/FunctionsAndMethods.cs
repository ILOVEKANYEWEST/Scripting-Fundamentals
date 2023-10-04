using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FunctionsAndMethods : MonoBehaviour
{
   public int Score = 0;
    private int _playerHealthAmount = 100;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // M3ethod Example n
    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount = amount;
    }

    private void IncreaseScore()
    {
        Score = 0; // Score =  Score = 0
    }

    private void MovePlayer() 
    {
        transform.Translate(Vector3.forward);
    
    }
}
