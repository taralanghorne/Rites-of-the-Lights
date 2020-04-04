using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViviAttack : MonoBehaviour
{
    public static bool AttackY = false;
    public static bool AttackP = false;

    public GameObject AttackRightY;
    //public GameObject AttackLeftY;
    public GameObject AttackRightP;
    //public GameObject AttackLeftP;

    public AudioClip zapping;
    public AudioClip leaves;

    public GameObject player;
    bool isR;
    bool isL;

    bool hitting = false;

    private Animator anim;

    public Transform attackerT;

    public static bool inControlAttack = true;

    GameObject attacker;

    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inControlAttack)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !AttackY)
            {
                if (hitting)
                    return;

                Debug.Log("Attacking Yellow");
                player.GetComponent<Animator>().SetBool("IsAttackingY", true);
                player.GetComponent<Animator>().SetBool("IsRunning", false);
                player.GetComponent<Animator>().SetBool("IsJumping", false);
                AttackY = true;
                AttackYCommand();
            }
            else if (Input.GetKeyDown(KeyCode.E) && !AttackP)
            {
                if (hitting)
                    return;

                Debug.Log("Attacking Pink");
                player.GetComponent<Animator>().SetBool("IsAttackingP", true);
                player.GetComponent<Animator>().SetBool("IsRunning", false);
                player.GetComponent<Animator>().SetBool("IsJumping", false);
                AttackP = true;
                AttackPCommand();
            }
        }
    }

    void AttackYCommand()
    {
        hitting = true;
        AudioSource.PlayClipAtPoint(zapping, transform.position);
        Invoke("AttackAnimStop", 0.1f); //0.02 0.08
        Invoke("Attack_Y_Cancel", 0.6f);
        Invoke("AttackingY", 0.1f);
    }

    void AttackPCommand()
    {
        hitting = true;
        AudioSource.PlayClipAtPoint(zapping, transform.position);
        Invoke("AttackAnimStop", 0.1f); // 0.02 0.08
        Invoke("Attack_P_Cancel", 0.6f);
        Invoke("AttackingP", 0.1f);
    }

    void AttackAnimStop()
    {
        player.GetComponent<Animator>().SetBool("IsAttackingP", false);
        player.GetComponent<Animator>().SetBool("IsAttackingY", false);
    }

    void Attack_Y_Cancel()
    {
        hitting = false;
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        //player.GetComponent<Animator>().SetBool("IsAttacking", false);
        AttackY = false;
        //AttackRight.SetActive(false);
    }

    void Attack_P_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        //player.GetComponent<Animator>().SetBool("IsAttacking", false);
        hitting = false;
        AttackP = false;
        //AttackLeft.SetActive(false);
    }

    void AttackingY()
    {
        attacker = Instantiate(AttackRightY) as GameObject;
        attacker.transform.position = attackerT.transform.position;
    }

    void AttackingP()
    {
        attacker = Instantiate(AttackRightP) as GameObject;
        attacker.transform.position = attackerT.transform.position;
    }

    /*private void Attacking()
    {
        hitting = true;
        Invoke("CanAttackAgain", 1);
        //GetComponent<SpriteRenderer>().color = new Color(1, 0.5f, 0.5f, 0.5f);
        //ouch.Play();
        // For more health, copy the if block for health3, change health3 to whatever yours is,
        // then change the if statement for health3 to else if


    }*/
}
