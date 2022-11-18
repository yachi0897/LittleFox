
using UnityEngine;

public class EnemyFireSystem2 : MonoBehaviour
/// <summary>
/// 敵人發射
/// </summary>
{




    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}