using UnityEngine;

// =====================================================================
// 第 3 周练习：2D 角色移动 + 跳跃 + 落地判定（重做摸底第 39 题）
// ---------------------------------------------------------------------
// 目标：不看资料补全 TODO 0–4，做到 —— A/D 水平移动、Space 跳跃、
//       落地后才能再跳（不能二段跳）、角色不穿地。
// 挂载位置：Player 物体（该物体必须有 Rigidbody2D + Collider2D）
//
// 需要用的概念都在《Unity 知识点笔记》第一、二、三章里，
// 自己翻笔记找 API，别直接抄网上的写法。
// =====================================================================
public class PlayerController2D : MonoBehaviour
{
    [Header("移动参数")]
    public float moveSpeed = 5f;      // 水平移动速度
    public float jumpForce = 8f;      // 跳跃力度

    // TODO 0：取消注释并补上两个私有字段
    // private Rigidbody2D _rb;       // 刚体引用（缓存起来，别每帧 GetComponent）
    // private bool _isGrounded;      // 是否站在地面上

    void Start()
    {
        // TODO 0b：在这里获取并缓存刚体组件引用
    }

    void Update()
    {
        // TODO 1：读取水平输入（A / D 或左右方向键），返回一个 -1 ~ 1 的值
        //         参考《输入 Input》章节

        // TODO 2：设置水平速度
        //         注意：y 方向的原有速度要保留（否则会破坏重力 / 跳跃）
        //         注意：移动带 Rigidbody2D 的物体不要用 transform.position

        // TODO 3：检测跳跃按键；只有当 _isGrounded 为 true 时才施加向上速度
        //         （不加这个判断就会变成无限二段跳）
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO 4：接触地面时把 _isGrounded 置为 true
        //         想一想：怎么判断碰到的是「地面」而不是别的物体？
        //         （可以用 collision 里的信息，也可以用物体的 Tag）
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // TODO 4b：离开地面时把 _isGrounded 置为 false
    }
}
