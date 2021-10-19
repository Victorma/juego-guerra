using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uAdventure.Core;
using uAdventure.Runner;
using uAdventure.Geo;

public class HacksManager : MonoBehaviour {

    public void ActivarModoManual()
    {
        GeoExtension.Instance.SwitchDebugLocation();
    }

    public void DevuelvemeAlMapaDeJuego()
    {
        GUIManager.Instance.ShowConfigMenu();
        if (uAdventure.Runner.Game.Instance.GameState.CheckFlag("IntroduccionTerminada") == FlagCondition.FLAG_ACTIVE)
        {
            Game.Instance.Execute(new EffectHolder(new Effects()
            {
                new TriggerSceneEffect("MapaJugable", 0, 0),

                new DeactivateEffect("UsadoFilosofia")
            }));
        }
        else
        {
            Game.Instance.Execute(new EffectHolder(new Effects()
            {
                new TriggerSceneEffect("MapaIntroduccion", 0, 0)
            }));
        }
    }
}
