using UnityEngine;
using UnityEngine.UI;
public class UI_FimDeJogo : MonoBehaviour
{
    public Text message;

    GameManager gm;
    private void OnEnable()
    {
        gm = GameManager.GetInstance();

        if (gm.points >= 10000)
        {
            message.text = "Você Ganhou!!!";
        }
        if(gm.lifes <= 0)
        {
            message.text = "Você Perdeu!!";
        }
    }
    public void Voltar()
    {
        gm.ChangeState(GameManager.GameState.MENU);
    }
}
