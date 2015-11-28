using UnityEngine;
using System.Collections;

public class MayorController : MonoBehaviour 
{
    public GameObject m_Mayor;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	void FixedUpdate () 
    {
        //Jump
        if (Input.GetAxis("Jump") > 0)
        {
            m_Mayor.GetComponent<MayorStats>().m_CurJumpForce++;
        }
        else
        {
            if (m_Mayor.GetComponent<MayorStats>().m_CurJumpForce != 0)
            {
                var jumpForce = m_Mayor.GetComponent<MayorStats>().m_CurJumpForce;
                m_Mayor.GetComponent<MayorFunctions>().Jump(jumpForce);
                m_Mayor.GetComponent<MayorStats>().m_CurJumpForce = 0;
            }
        }

        //Punch
        if (Input.GetAxis("Fire1") > 0)
        {
            m_Mayor.GetComponent<MayorStats>().m_PunchForce++;
        }
        else
        {
            if (m_Mayor.GetComponent<MayorStats>().m_PunchForce != 0)
            {
                var punchForce = m_Mayor.GetComponent<MayorStats>().m_PunchForce;
                m_Mayor.GetComponent<MayorFunctions>().Punch(punchForce, new Vector2(0,0));
                m_Mayor.GetComponent<MayorStats>().m_PunchForce = 0;
            }
        }
	}
}
