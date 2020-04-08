using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 定義兩個欄位存放怪物一號與怪物二號
    /// </summary>
    [Header("怪物一號")]
    public Enemy enemy1;
    [Header("怪物二號")]
    public Enemy enemy2;

    /// <summary>
    /// 使用開始事件 Start 
    /// </summary>
    private void Start()
    {
        //取得 get
        print("怪物一號的魔力" + enemy1.enemymp);
        print("怪物二號的裝備名稱" + enemy2.equipname);

        //設定 set
        enemy1.enemyhp = 100;
        enemy2.enemyhp = 300;
        enemy1.enemydef = 50;
        enemy1.weaponname = "木棍";
        enemy2.weaponname = "短刀";
        enemy1.keyhold = true;
        enemy2.keyhold = true;
    }

} 
