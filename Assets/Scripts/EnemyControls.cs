using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public Transform[] DoorPointsLv1;
    public Transform[] DoorPointsLv2;
    public Transform[] DoorPointsLv3;
    public Transform[] DoorPointsLv4;
    public Transform[] DoorPointsLv5;
    public Transform[] DoorPointsLv6;
    public Transform[] DoorPointsLv7;
    public Transform[] EndDoorPoints;
    [SerializeField]
    private float enemySpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    [SerializeField]
    private float rotationSpeed = 4f;
    [SerializeField]
    private float minDistance;


    private CharacterController controller;
    private Vector3 enemyVelocity;
    private bool isGround;
    private Animator anim;
    private int level1DoorNum;
    private int level2DoorNum;
    private int level3DoorNum;
    private int level4DoorNum;
    private int level5DoorNum;
    private int level6DoorNum;
    private int level7DoorNum;
    private int levelEndDoorNum;

    private int currentLevel;
    private bool flag;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

        level1DoorNum = Random.Range(0, DoorPointsLv1.Length);
        level2DoorNum = Random.Range(0, DoorPointsLv2.Length);
        level3DoorNum = Random.Range(0, DoorPointsLv3.Length);
        level4DoorNum = Random.Range(0, DoorPointsLv4.Length);
        level5DoorNum = Random.Range(0, DoorPointsLv5.Length);
        level6DoorNum = Random.Range(0, DoorPointsLv6.Length);
        level7DoorNum = Random.Range(0, DoorPointsLv7.Length);
        levelEndDoorNum = Random.Range(0, EndDoorPoints.Length);
        currentLevel = 1;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 moveDirection = (nextPoint.position - transform.position).normalized;
        //moveDirection.y = 0f;
        //controller.Move(enemySpeed * moveDirection * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            flag = true;
        }

        if(flag)
        {
            isGround = controller.isGrounded; //判断Enemy是否在地面
            if (isGround && enemyVelocity.y < 0)
            {
                enemyVelocity.y = 0f;
                anim.SetBool("Jump", false);
            }

            //处理Enemy下落
            enemyVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(enemyVelocity * Time.deltaTime);

            Vector3 moveDirection = Vector3.zero;
            Vector2 enemyTrans = Vector2.zero;
            Vector2 doorTrans = Vector2.zero;
            float dis = 10000f;

            switch (currentLevel)
            {
                case 1:
                    moveDirection = (DoorPointsLv1[level1DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv1[level1DoorNum].position.x, DoorPointsLv1[level1DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 2;
                        Jump();
                    }
                    break;
                case 2:
                    moveDirection = (DoorPointsLv2[level2DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv2[level2DoorNum].position.x, DoorPointsLv2[level2DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 3;
                        Jump();
                    }
                    break;
                case 3:
                    moveDirection = (DoorPointsLv3[level3DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv3[level3DoorNum].position.x, DoorPointsLv3[level3DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 4;
                        Jump();
                    }
                    break;
                case 4:
                    moveDirection = (DoorPointsLv4[level4DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv4[level4DoorNum].position.x, DoorPointsLv4[level4DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 5;
                        Jump();
                    }
                    break;
                case 5:
                    moveDirection = (DoorPointsLv5[level5DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv5[level5DoorNum].position.x, DoorPointsLv5[level5DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 6;
                        Jump();
                    }
                    break;
                case 6:
                    moveDirection = (DoorPointsLv6[level6DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv6[level6DoorNum].position.x, DoorPointsLv6[level6DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 7;
                        Jump();
                    }
                    break;
                case 7:
                    moveDirection = (DoorPointsLv7[level7DoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(DoorPointsLv7[level7DoorNum].position.x, DoorPointsLv7[level7DoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 8;
                        Jump();
                    }
                    break;
                case 8:
                    moveDirection = (EndDoorPoints[levelEndDoorNum].position - transform.position).normalized;
                    moveDirection.y = 0f;
                    Run(moveDirection);
                    RandomJump();
                    enemyTrans = new Vector2(transform.position.x, transform.position.z);
                    doorTrans = new Vector2(EndDoorPoints[levelEndDoorNum].position.x, EndDoorPoints[levelEndDoorNum].position.z);
                    dis = (enemyTrans - doorTrans).sqrMagnitude;
                    if (dis < minDistance)
                    {
                        currentLevel = 9;
                        anim.SetBool("Run", false);
                    }
                    break;
                default:
                    break;
            }
        }        
    }

    void Run(Vector3 direction)
    {
        controller.Move(enemySpeed * direction * Time.deltaTime);
        anim.SetBool("Run", true);
    }

    void Jump()
    {
        if (isGround)
        {
            enemyVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            anim.SetBool("Jump", true);
        }
    }

    void RandomJump()
    {
        if (isGround)
        {
            if(Random.Range(0,200) == 50)
            {
                enemyVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
                anim.SetBool("Jump", true);
            }
        }
    }
}
