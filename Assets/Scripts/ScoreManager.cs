using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("PsuhCount_Great:" + pushNotes.pushCount_Great + " PsuhCount_Good:" + pushNotes.pushCount_Good + " PsuhCount_Miss:" + pushNotes.pushCount_Miss
            + "PsuhLowerCount_Great:" + pushNotes_Lower.pushLowerCount_Great + " PsuhLowerCount_Good:" + pushNotes_Lower.pushLowerCount_Good + " PsuhLowerCount_Miss:" + pushNotes_Lower.pushLowerCount_Miss
            + " HoldCount_Great:" + holdNotes.holdCount_Great + " holdCount_Miss:" + holdNotes.holdCount_Miss);
    }
}