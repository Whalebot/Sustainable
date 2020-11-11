using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class ActivateBot : MonoBehaviour
{
    public SimpleAI ai;
    public BotTypes bot;

    public void setbot()
    {
        ai.isAIActive = true;
        ai.bot.AssignBotValues(bot);
    }
}
