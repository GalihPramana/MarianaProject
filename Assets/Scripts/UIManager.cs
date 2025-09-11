using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject infoPanel;
    public Text nameText;
    public Text descriptionText;
    public Image creatureImage;

    void Start()
    {
        infoPanel.SetActive(false); // hidden saat awal
    }

    public void ShowCreatureInfo(HewanLaut creature)
    {
        infoPanel.SetActive(true);
        nameText.text = creature.creatureName;
        descriptionText.text = creature.description;
        creatureImage.sprite = creature.image;
    }

    public void HideCreatureInfo()
    {
        infoPanel.SetActive(false);
    }
}
