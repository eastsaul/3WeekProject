using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;


public enum BattleStateTest { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleTest : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public TMP_Text dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    //public HUDTest playerHUD;
    //public HUDTest enemyHUD;

    public BattleStateTest state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleStateTest.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject playerGo = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGo.GetComponent<Unit>();

        GameObject enemyGo = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Unit>();

        dialogueText.text = "살기를 뿜으며 " + enemyUnit.unitName + "가 접근중...";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleStateTest.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        // Damage the enemy
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = "The attack is successful!";

        yield return new WaitForSeconds(2f);

        // check if the enemy is dead
        // change state based on what happened

        if (isDead)
        {
            // End the battle
            state = BattleStateTest.WON;
            EndBattle();
        }
        else
        {
            // Enemy turn
            state = BattleStateTest.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + " 의 공격!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleStateTest.LOST;
            EndBattle();
        }
        else
        {
            state = BattleStateTest.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle()
    {
        if (state == BattleStateTest.WON)
        {
            dialogueText.text = "You won the battle!";
        }
        else if (state == BattleStateTest.LOST)
        {
            dialogueText.text = "You were defeated.";
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action";
    }

    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(5);
        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "You feel renewed strength!";

        yield return new WaitForSeconds(2f);

        state = BattleStateTest.ENEMYTURN;
        StartCoroutine(EnemyTurn());

    }

    public void OnAttackButton()
    {
        if (state != BattleStateTest.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

    public void OnHealButton()
    {
        if (state != BattleStateTest.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }
}
