using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KanjiCard : MonoBehaviour {

    public Text kanjiText;
    public Text furiganaText;
    public Text translateText;
    private ReadTxt kanjis;
    private ReadTxt.KanjiCardData auxCard;
    private bool answerIsVisible;
    public void Start()
    {
        kanjis = ReadTxt.instance;
        auxCard.kanji = "";
        DisplayKanji();
        answerIsVisible = false;
    }

    public void ShowAnswer()
    {
        kanjiText.gameObject.SetActive(!kanjiText.gameObject.activeSelf);
        furiganaText.gameObject.SetActive(!furiganaText.gameObject.activeSelf);
        translateText.gameObject.SetActive(!translateText.gameObject.activeSelf);
        answerIsVisible = !answerIsVisible;
    }

    public void DisplayKanji()
    {
        ReadTxt.KanjiCardData kanjiCard = kanjis.cards[Random.Range(0, kanjis.cards.ToArray().Length)];
        if (auxCard.kanji == kanjiCard.kanji)
        {
            DisplayKanji();
            return;
        }
        auxCard = kanjiCard;
        kanjiText.text = kanjiCard.kanji;
        furiganaText.text = kanjiCard.furigana;
        translateText.text = kanjiCard.translate;
        if (answerIsVisible)
        {
            ShowAnswer();
        }
    }
}
