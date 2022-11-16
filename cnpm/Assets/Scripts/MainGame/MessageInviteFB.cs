using UnityEngine;
using System.Runtime.Serialization;
using UnityEngine.UI;
using System.Collections.Generic;

public class MessageInviteFB : MonoBehaviour {

    //xu ly ngon ngu
    public Text textTitle, textNote, textButton;

    public void StartShowMessage()
    {
        //xu ly ngon ngu
        int iLang = Modules.indexLanguage;
        textTitle.font = AllLanguages.listFontLangA[iLang];
        textTitle.text = AllLanguages.menuInvite[iLang];
        textNote.font = AllLanguages.listFontLangB[iLang];
        textNote.text = AllLanguages.menuNoteInvite[iLang];
        textButton.font = AllLanguages.listFontLangA[iLang];
        textButton.text = AllLanguages.menuButtonInvite[iLang];
    }

    public void ButtonCloseClick()
    {
        transform.gameObject.GetComponent<Animator>().SetTrigger("TriClose");
        Modules.PlayAudioClipFree(Modules.audioButton);
    }

    public void ButtonInviteClick()
    {
        /*
        Facebook.Unity.FB.AppRequest(
            AllLanguages.menuMessageInvite[Modules.indexLanguage],
            null, null, null, 100, string.Empty, AllLanguages.menuTitleInvite[Modules.indexLanguage], RewardInviteFB);
        ButtonCloseClick();
        */
    }

    /*
    private void RewardInviteFB(Facebook.Unity.IAppRequestResult result)
    {
        //Modules.textDebug.text += "\n" + result;
        //thuong moi khi moi ban be
        var responseObject = Json.Deserialize(result.RawResult) as Dictionary<string, object>;
        string data = "";
        object tmp;
        responseObject.TryGetValue("to", out tmp);
        if (tmp != null)
        {
            data = tmp.ToString();
            string[] idFriends = data.Split(',');
            if (idFriends.Length > 0)
            {
                int totalCoinBonus = Modules.coinBonusInvite * idFriends.Length;
                if (totalCoinBonus > Modules.coinMaxInvite) totalCoinBonus = Modules.coinMaxInvite;
                Modules.totalCoin += totalCoinBonus;
                Modules.SaveCoin();
                Modules.coinMaxInvite -= totalCoinBonus;
                Modules.SaveCheckInviteFB();
            }
        }
    }
    */
}
