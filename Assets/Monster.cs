using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1)]
    public float speed = 3.5f;

    [Header("攻擊力"), Range(0, 500)]
    public float attack = 100f;

    [Range(0, 5000)]
    public float health = 350f;

    [Header("掉落道具"), Tooltip("掉落道具")]
    public GameObject item;

    [Header("掉落道具機率"), Range(0, 1)]
    public float itemChance = 1f;

    [Header("掉落道具音效"), Tooltip("掉落道具音效")]

    public AudioClip itemSfx;

    AudioSource aSource;

    Rigidbody2D rig;

    Animator anim;
    
}
