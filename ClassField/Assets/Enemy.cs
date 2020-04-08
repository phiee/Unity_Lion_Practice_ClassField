using UnityEngine;

/// <summary>
/// 定義怪物參數
/// </summary>

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 血量
    /// </summary>    
    [Header("血量"), Tooltip("怪物的血量"), Range(50, 500)]
    public int enemyhp;

    /// <summary>
    /// 魔力
    /// </summary>    
    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int enemymp = 100;

    /// <summary>
    /// 移動速度
    /// </summary>    
    [Header("移動速度"), Range(1,50.5f)]
    public float movespeed = 10.5f;

    /// <summary>
    /// 攻擊力
    /// </summary>    
    [Header("攻擊力"), Range(20, 200)]
    public int enemyatk = 50;

    /// <summary>
    /// 防禦力
    /// </summary>    
    [Header("防禦力"), Range(0, 100)]
    public int enemydef;

    /// <summary>
    /// 武器名稱
    /// </summary>  
    [Header("裝備")]
    public string weaponname;

    /// <summary>
    /// 裝備名稱
    /// </summary>  
    public string equipname = "皮衣";

    /// <summary>
    /// 是否帶有鑰匙
    /// </summary>  
    [Header("其他資料"),Tooltip("怪物是否帶有鑰匙")]
    public bool keyhold = false;
    
    /// <summary>
    /// 是否掉落寶物
    /// </summary>  
    [Tooltip("怪物是否帶有寶物")]
    public bool treasuredrop= false;
      
}
