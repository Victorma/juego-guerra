using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class End : MonoBehaviour
{
    public Text starsText;

    private void Start()
    {
        uAdventure.Runner.InventoryManager.Instance.Show = false;
        int nNoticias = uAdventure.Runner.Game.Instance.GameState.GetVariable("PuntuacionNoticias");

        int nFotos = 5 - (uAdventure.Runner.Game.Instance.GameState.CheckFlag("UsadoAgronomos") +
            uAdventure.Runner.Game.Instance.GameState.CheckFlag("UsadoArquitectura") +
            uAdventure.Runner.Game.Instance.GameState.CheckFlag("UsadoClinico") +
            uAdventure.Runner.Game.Instance.GameState.CheckFlag("UsadoFilosofia") +
            uAdventure.Runner.Game.Instance.GameState.CheckFlag("UsadoVelazquez"));

        starsText.text = nFotos.ToString() + "/5 fotos y " + nNoticias.ToString() + "/22 recortes de periódico.";
    }

    public void SalirJuego()
    {
        uAdventure.Runner.Game.Instance.Quit();
    }
}
