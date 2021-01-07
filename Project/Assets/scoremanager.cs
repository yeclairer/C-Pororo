using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    static int score = 0;
    
    public static void setscore(int value){
    score += value;
    }
    public static int getscore(){
    return score;
    }
}
