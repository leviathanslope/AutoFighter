using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int isPaused;

    bool _setup = false;

    public float _victoryPoints;
    public float _playerHealth = 20;
    public float _money = 20;

    public AudioSource LossSFX;
    public AudioSource WinSFX;

    string _typePos1;
    string _typePos2;
    string _typePos3;
    string _typePos4;

    [SerializeField] GameObject _objSwordsman;
    [SerializeField] GameObject _objSpearsman;
    [SerializeField] GameObject _objShieldBearer;
    [SerializeField] GameObject _objArcher;
    [SerializeField] GameObject _objMage;
    [SerializeField] GameObject _objHealer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<SaveSystem_Script>().SaveData();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<SaveSystem_Script>().LoadData();
        }

        _shop();
        _autoBattleSetup();
        _autoBattleLose();
        _autoBattleWin();
        _NoHealth();

        Scene _scene = SceneManager.GetActiveScene();
        if (_scene.name == "AutoBattleTest")
        {
            GameObject _objCoin = GameObject.Find("coin_text");
            _objCoin.GetComponent<UnityEngine.UI.Text>().text = _money.ToString();

            GameObject _objHealth = GameObject.Find("HP_text");
            _objHealth.GetComponent<UnityEngine.UI.Text>().text = _playerHealth.ToString();
        }
    }

    void _shop()
    {
        Scene _scene = SceneManager.GetActiveScene();
        if (_scene.name == "GameState")
        {
            _setup = false;
            if (GameObject.Find("pos1") != null)
            {
                GameObject _objPos1 = GameObject.Find("pos1");

                _typePos1 = _objPos1.tag;
            }
            else { _typePos1 = null; }
            if (GameObject.Find("pos2") != null)
            {
                GameObject _objPos2 = GameObject.Find("pos2");

                _typePos2 = _objPos2.tag;
            }
            else { _typePos2 = null; }
            if (GameObject.Find("pos3") != null)
            {
                GameObject _objPos3 = GameObject.Find("pos3");

                _typePos3 = _objPos3.tag;
            }
            else { _typePos3 = null; }
            if (GameObject.Find("pos4") != null)
            {
                GameObject _objPos4 = GameObject.Find("pos4");

                _typePos4 = _objPos4.tag;
            }
            else { _typePos4 = null; }

            GameObject _objCoin = GameObject.Find("coin_text");
            _objCoin.GetComponent<UnityEngine.UI.Text>().text = _money.ToString();

            GameObject _objHealth = GameObject.Find("HP_text");
            _objHealth.GetComponent<UnityEngine.UI.Text>().text = _playerHealth.ToString();

        }
    }

    void _autoBattleSetup()
    {
        Scene _scene = SceneManager.GetActiveScene();
        if (_scene.name == "AutoBattleTest" && _setup == false)
        {
            _setup = true;
            _pos1Setup();
            _pos2Setup();
            _pos3Setup();
            _pos4Setup();
        }
    }

    void _pos1Setup()
    {
        if (_typePos1 == "Swordsman")
        {
            print("check1");
            Instantiate(_objSwordsman, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos1 == "Spearman")
        {
            Instantiate(_objSpearsman, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos1 == "ShieldBearer")
        {
            Instantiate(_objShieldBearer, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos1 == "Archer")
        {
            Instantiate(_objArcher, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos1 == "Mage")
        {
            Instantiate(_objMage, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos1 == "Healer")
        {
            Instantiate(_objHealer, new Vector3(-1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
    }
    void _pos2Setup()
    {
        if (_typePos2 == "Swordsman")
        {
            print("check");
            Instantiate(_objSwordsman, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos2 == "Spearman")
        {
            Instantiate(_objSpearsman, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos2 == "ShieldBearer")
        {
            Instantiate(_objShieldBearer, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos2 == "Archer")
        {
            Instantiate(_objArcher, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos2 == "Mage")
        {
            Instantiate(_objMage, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos2 == "Healer")
        {
            Instantiate(_objHealer, new Vector3(1, -1, 0), Quaternion.Euler(0, 0, 0));
        }
    }
    void _pos3Setup()
    {
        if (_typePos3 == "Swordsman")
        {
            Instantiate(_objSwordsman, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos3 == "Spearman")
        {
            Instantiate(_objSpearsman, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos3 == "ShieldBearer")
        {
            Instantiate(_objShieldBearer, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos3 == "Archer")
        {
            Instantiate(_objArcher, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos3 == "Mage")
        {
            Instantiate(_objMage, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos3 == "Healer")
        {
            Instantiate(_objHealer, new Vector3(-1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
    }
    void _pos4Setup()
    {
        if (_typePos4 == "Swordsman")
        {
            Instantiate(_objSwordsman, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos4 == "Spearman")
        {
            Instantiate(_objSpearsman, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos4 == "ShieldBearer")
        {
            Instantiate(_objShieldBearer, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos4 == "Archer")
        {
            Instantiate(_objArcher, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos4 == "Mage")
        {
            Instantiate(_objMage, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (_typePos4 == "Healer")
        {
            Instantiate(_objHealer, new Vector3(1, -2.5f, 0), Quaternion.Euler(0, 0, 0));
        }
    }

    void _autoBattleWin()
    {
        Scene _scene = SceneManager.GetActiveScene();
        if (_scene.name == "AutoBattleTest" && GameObject.Find("AutoBattlerController_obj").GetComponent<AutoBattlerController_scr>()._actionTick != 0)
        {
            if (GameObject.Find("EPos1") == null
                && GameObject.Find("EPos2") == null
                && GameObject.Find("EPos3") == null
                && GameObject.Find("EPos4") == null)
            {
                print("win");
                _money += 20;
                WinSFX.Play();
                SceneManager.LoadScene("GameState");
            }
        }
    }


    void _autoBattleLose()
    {
        Scene _scene = SceneManager.GetActiveScene();
        if (_scene.name == "AutoBattleTest" && GameObject.Find("AutoBattlerController_obj").GetComponent<AutoBattlerController_scr>()._actionTick != 0)
        {
            if (GameObject.Find("FPos1") == null
                && GameObject.Find("FPos2") == null
                && GameObject.Find("FPos3") == null
                && GameObject.Find("FPos4") == null)
            {
                print("lose");
                _playerHealth -= 3;
                _money += 20;
                LossSFX.Play();
                SceneManager.LoadScene("GameState");
            }
        }
    }

    void _NoHealth()
    {
        if (_playerHealth <= 0)
        {
            _playerHealth = 20;
            _money = 20;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
