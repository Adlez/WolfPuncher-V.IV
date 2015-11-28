using UnityEngine;
using System.Collections;

public class MayorFunctions : MonoBehaviour 
{
    public GameObject m_Mayor;

    public void Jump(float jumpForce)
    {
        //m_Mayor.GetComponent<Rigidbody2D>().AddForce((0, jumpForce));
    }

    public void Punch(float punchForce, Vector2 targetVector)
    {
        //target vector is the area on the screen pressed by the player
        //the difference in the Y of the location pressed and the Y of the Fist Spawn location
        //changes the direction the fist travels

        //punchforce determines how far the "shockwave" travels
    }

    public void Bash()
    {
        //changes the anim of Mayor
    }
}
