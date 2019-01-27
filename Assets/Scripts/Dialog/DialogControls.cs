using UnityEngine;
using UnityEngine.UI;

public class DialogControls : MonoBehaviour {  
  public GameObject root;
  public Button prefab;
  public Transform parent;

  public void Close() {
    root.SetActive(false);
  }

  public void Open() {
    root.SetActive(true);
  }

    public void AddOptions(Dialog.Option[] options, ButtonListListener listener) {

        parent.DetachChildren();

        for (int i = 0; i < options.Length; i++)
        {
            int newIndex = options[i].newPhraseIndex;
            Button b = GameObject.Instantiate(prefab);
            b.transform.SetParent(parent);
            b.onClick.AddListener(() => listener(newIndex));
            b.GetComponentInChildren<Text>().text = options[i].choice;
        }
    }

    public Text phraseText;
    public void UpdatePhrase(string newPhrase) {
        phraseText.text = newPhrase;
    }

    public delegate void ButtonListListener(int i);

}