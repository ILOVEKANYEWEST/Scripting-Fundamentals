using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Public Global/Member Variables
    public int Score = 0; // Variables a wholr number
    public float ItemAmount = 19.95f; // decimal number
    public string PlayerName = "Rizzler"; //declare a text
    public bool IsPlayerActive = true; // declare a true/false

    //private Global/Member Variables
    private int _collectableAmount = 0;
    private float _horizontalInput = 0f;
    private string _username = "rizzler";
    private bool _GameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0; // Assigning Global/Member Variable
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPosition = transform.position;


        float verticalInput = Input.GetAxis("Vertical");
    }

    

}    
