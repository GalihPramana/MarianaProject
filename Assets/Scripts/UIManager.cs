using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject infoPanel;
    public Text nameText;
    public Text descriptionText;
    public Image creatureImage;

    private bool isPanelOpen = false;

    void Start()
    {
        infoPanel.SetActive(false); // hidden saat awal
    }

    void Update()
    {
        // Tekan ESC untuk nutup pop-up
        if (isPanelOpen && Input.GetKeyDown(KeyCode.Q))
        {
            HideCreatureInfo();
        }
    }

    public void ShowCreatureInfo(HewanLaut creature)
    {
        infoPanel.SetActive(true);
        nameText.text = creature.creatureName;
        descriptionText.text = creature.description;
        creatureImage.sprite = creature.image;
        isPanelOpen = true;
    }

    public void HideCreatureInfo()
    {
        infoPanel.SetActive(false);
        isPanelOpen = false;
    }
}
