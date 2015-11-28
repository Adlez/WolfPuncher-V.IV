using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBaseClass : MonoBehaviour 
{
    public float e_VelocityX;

    public List<int> m_KOMoodlet;
    public List<int> m_CrashMoodlet;
    public List<int> m_BashMoodlet;
    public List<int> m_PunchMoodlet;

    public void Die(string methodOfDeath)
    {
        InflictMood(methodOfDeath);
        //change anim depending on the method of death
        //Punch, Crash, Bash - Blood explosion
        //Shockwave, KO - Enemy Flips Upside, travels up a shot distance and then fall off the screen, followed by blood explosion
    }

    public void InflictMood(string methodOfDeath)
    {
        //for purposes of Mood: Shockwave counts as Punch
        //When enemies are killed by KO, nothing will increase Mayor's Sad or Irritation. Only Her boredom can be changed by KO's
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
