using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float JumpPower;

    private Rigidbody2D RB;

    private float _startJumpPower;
    private float _startSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
        RB = GetComponent<Rigidbody2D>();
        _startJumpPower = JumpPower;
        _startSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 movement = new Vector2(0, RB.velocity.y);

        if(Input.GetKey(KeyCode.A))
        {
            movement.x = -Speed*Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            movement.x = Speed*Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(new Vector2(0, JumpPower));
        }

        RB.velocity = movement;

    }

    public void JumpPowerup(float seconds, float Power)
    {
        StartCoroutine(RunJumpPowerup(seconds, Power));
    }

    IEnumerator RunJumpPowerup(float seconds, float Power)
    {
        JumpPower = Power;
        yield return new WaitForSeconds(seconds);
        JumpPower = _startJumpPower;
    }

    public void SpeedPowerup(float sec, float sPower)
    {
        StartCoroutine(RunSpeedBoost(sec, sPower));
    }

    IEnumerator RunSpeedBoost(float seconds, float SpeedPower)
    {
        Speed = SpeedPower;
        yield return new WaitForSeconds(seconds);
        Speed = _startSpeed;
    }
}
