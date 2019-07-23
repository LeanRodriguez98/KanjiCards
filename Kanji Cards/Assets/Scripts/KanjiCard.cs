using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KanjiCard : MonoBehaviour {

    public Text kanjiText;
    public Text furiganaText;
    public Text translateText;
    private ReadTxt kanjis;
    public void Start()
    {
        kanjis = ReadTxt.instance;
        DisplayKanji(kanjis.cards[Random.Range(0, kanjis.cards.ToArray().Length)]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            DisplayKanji(kanjis.cards[Random.Range(0, kanjis.cards.ToArray().Length)]);
        }
    }

    public void DisplayKanji(ReadTxt.KanjiCardData kanjiCard)
    {
        kanjiText.text = kanjiCard.kanji;
        furiganaText.text = kanjiCard.furigana;
        translateText.text = kanjiCard.translate;
    }
}
