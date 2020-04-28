using UnityEngine;
using UnityEngine.UI;

public class monster : MonoBehaviour
{
    [Header("蝙蝠血量")]
    public int B_HP = 200;
    [Header("蝙蝠攻擊")]
    public int B_ATK = 20;
    [Header("蝙蝠治癒")]
    public int B_HEAL = 10;
    [Header("史萊姆血量")]
    public int S_HP = 300;
    [Header("史萊姆攻擊")]
    public int S_ATK = 10;
    [Header("史萊姆治癒")]
    public int S_HEAL = 20;

    [Header("文字：輸出結果")]
    public Text result;

    public void S_be_ATK()
    {
        if (S_HP > 0)
        {
            S_HP -= B_ATK;
        }
        result.text = ("史萊姆 - 受到傷害：" + B_ATK + "\n" + "史萊姆 - 血量剩下：" + S_HP);
    }

    public void B_be_HEAL()
    {
        if (B_HP < 200)
        {
            B_HP += B_HEAL;
        }
        result.text = ("蝙蝠 - 收到治癒：" + B_HEAL + "\n" + "蝙蝠 - 血量剩下：" + B_HP);
    }

    public void B_be_ATK()
    {
        if (B_HP > 0)
        {
            B_HP -= S_ATK;
        }
        result.text = ("蝙蝠 - 受到傷害：" + S_ATK + "\n" + "蝙蝠 - 血量剩下：" + B_HP);
    }

    public void S_be_HEAL()
    {
        if (S_HP < 300)
        {
            S_HP += S_HEAL;
        }
        result.text = ("史萊姆 - 收到治癒：" + S_HEAL + "\n" + "史萊姆 - 血量剩下：" + S_HP);
    }
}
