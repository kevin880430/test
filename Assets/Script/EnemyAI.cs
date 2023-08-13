using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 3f;                                                                                           //�G�̈ړ��X�s�[�h     
    public float attackRange = 2f;                                                                                         //�G�̍U���͈� 
    public int attackDamage = 1;                                                                                           //�G�̍U����
    public float attackCooldown = 2f;                                                                                      //�U���Ԋu

    private Transform player;                                                                                              //�v���C���[�̈ʒu���
    private bool isPlayerInRange = false;                                                                                  //�v���C���[�T�m�`�F�b�N    
    private bool isAttacking = false;                                                                                      //�U������
    private float attackTimer = 0f;                                                                                        //�U���^�C�}�[

    private void Start()
    {
        player = GameObject.Find("Player").transform;                                                                       //�v���C���[�̈ʒu�����擾
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        isPlayerInRange = distanceToPlayer <= attackRange;                                                                  //�v���C���[�Ƃ̋����͍U���͈͓��Ȃ�isPlayerRange���`�F�b�N

        if (isPlayerInRange && !isAttacking)                                                                                //isPlayerRange�`�F�b�N�ƍU������ł͂Ȃ��ꍇ
        {
            AttackPlayer();                                                                                                 //�v���C���[���U������
        }
        else if (!isPlayerInRange)                                                                                          //�v���C���[���U���͈͊O�Ȃ�
        {
            Move();                                                                                                         //�p�g���[��
        }

        // �^�C�}�[�̍X�V
        if (isAttacking)                                                                                                    //�U������on��
        {
            if (attackTimer >= attackCooldown)                                                                              //�U���^�C�}�[�͍U���Ԋu���ԂɂȂ�����
            {
                isAttacking = false;                                                                                        //�U���̔���off
                attackTimer = 0;                                                                                            //�^�C�}�[���Z�b�g
            }
            else
            {
                attackTimer += Time.deltaTime;                                                                              //�^�C�}�[�X�^�[�g
            }
        }
    }

    private void Move()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);                                                    //�E�Ɉړ�����

        if (transform.position.x >= 3f || transform.position.x <= -3f)                                                      //�ړ�������3�ȏ㒴������
        {
            moveSpeed *= -1;                                                                                                //�ړ��������t�ɂ���
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);//�����̌��������E���]
        }
    }

    private void AttackPlayer()
    { 
        isAttacking = true;                                                                                                 //�U�����s���Ƃ��U�������on    
            
        Debug.Log("Attacking the player!");                                                                                 //�U���A�j���[�V�����܂��ǉ����Ă��Ȃ��̂�DebugLog�ŕ\��

        
        player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);                                                       // �v���C���[�Ƀ_���[�W��^���鏈����ǉ�����
    }
}
