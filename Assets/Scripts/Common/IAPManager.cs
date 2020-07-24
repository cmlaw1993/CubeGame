using System;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;

public class IAPManager : MonoBehaviour, IStoreListener
{
    public static IAPManager instance;

    static IStoreController m_StoreController;
    static IExtensionProvider m_StoreExtensionProvider;

    const string AD_FREE = "perfect_square_ad_free";
    const string HINT_5 = "perfect_square_hint_5";

    private void Awake()
    {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (m_StoreController == null)
            InitializePurchasing();
    }

    /* Initialization */

    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void InitializePurchasing()
    {
        if (IsInitialized())
            return;

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(AD_FREE, ProductType.NonConsumable);
        builder.AddProduct(HINT_5, ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("$$$$$$ IAPManager: OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("$$$$$$ IAPManager: OnInitializeFailed InitializationFailureReason:" + error);
    }

    /* Purchasing */

    void BuyProductID(string productId)
    {
        if (IsInitialized()) {

            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase) {
                Debug.Log(string.Format("$$$$$$ IAPManager: Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else {
                Debug.Log("$$$$$$ IAPManager: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }

        } else {
            Debug.Log("$$$$$$ IAPManager: FAIL. Not initialized.");
        }
    }
    
    public void PurchaseAdFree()
    {
        Debug.Log("$$$$$$ IAPManager: Attempting to purchase Ad Free");
        BuyProductID(AD_FREE);
    }

    public void PurchaseHint5()
    {
        Debug.Log("$$$$$$ IAPManager: Attempting to purchase Hint 5");
        BuyProductID(HINT_5);
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        Debug.Log("$$$$$$ IAPManager: ProcessPurchase called");

        KeyManager keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();

        if (String.Equals(args.purchasedProduct.definition.id, AD_FREE, StringComparison.Ordinal)) {

            Debug.Log("$$$$$$ IAPManager: Ad Free purchase successful");
            
            keyMan.SetAdFree(KeyManager.AdFree.PURCHASED);
            GameObject.Find("AdManager").GetComponent<AdManager>().DestroyBannerAd();

        } else if (String.Equals(args.purchasedProduct.definition.id, HINT_5, StringComparison.Ordinal)) {

            Debug.Log("$$$$$$ IAPManager:  Hint 5 purchase successful");

            keyMan.SetHintCount(keyMan.GetHintCount() + 5);

        } else {
            Debug.Log("$$$$$$ IAPManager: Purchase Failed");
        }

        if (SceneManager.GetActiveScene().name == "MainMenu") {
            MenuMainManager man = GameObject.Find("MenuMainManager").GetComponent<MenuMainManager>();
            man.UpdatePanelBottom();
            man.UpdatePanelStore();
        } else if (SceneManager.GetActiveScene().name == "Level") {
            UIManager man = GameObject.Find("UIManager").GetComponent<UIManager>();
            man.UpdatePanelStore();
            man.SetTextLeftLabelHint(keyMan.GetHintCount());
            man.SetButtonLeftHintActive();
        }

        return PurchaseProcessingResult.Complete;
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("$$$$$$ IAPManager: OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

    /* Restore Purchase */

    public void RestorePurchases()
    {
        if (!IsInitialized()) {
            Debug.Log("$$$$$$ IAPManager: RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
                Application.platform == RuntimePlatform.OSXPlayer) {

            Debug.Log("$$$$$$ IAPManager: RestorePurchases started ...");

            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) => {
                Debug.Log("$$$$$$ IAPManager: RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });

        } else {
            Debug.Log("$$$$$$ IAPManager: RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }
}