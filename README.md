# 클릭 이벤트 처리

    public void OnClickButton()
    {
        audioSource.PlayOneShot(clip);
        GetGold(getGold);
        Score.times ++;
        particle.ClickParticle();
        //Debug.Log("click");
    }

    클릭시 점수가 올라가는 함수를 버튼에 넣어놓고, 화면 가득 채워놓았습니다.

# 자동 클릭 기능

    IEnumerator AutoClick(float amount)
    {
        while (true)
        {
            yield return new WaitForSeconds(amount);
            ClickEvent.OnClickButton();
        }
    }

    코루틴을 사용하여 클릭 이벤트를 시간이 지나면 자동으로 불러오는 함수를 구현하였습니다.

# 점수 시스템

    public void GoldUpdate()
    {
        Gold.text = "Gold : " + gold ;
    }

    public void TimesUpdate()
    {
        Times.text = times + " Times";
    }

    void Update()
    {
        GoldUpdate();
        TimesUpdate();
    }


    클릭 이벤트시, 몇번 클릭했는지와 클릭했을때 얻는 골드를 구현하여 텍스트UI로 화면에 보이게 구성하였습니다.

# 아이템 및 업그레이드 시스템

    public void GetGoldUpgradeButton()
    {
        if (Score.gold >= hasGold_GU && ClickEvent.getGold <= 2048)
        {
            Score.gold -= hasGold_GU;
            ClickEvent.getGold += ClickEvent.getGold;
            hasGold_GU += hasGold_GU;
        }
        else if (ClickEvent.getGold >= 2049) Debug.Log("모든 업그레이드가 완료되었습니다.");
        else Debug.Log("골드가 부족합니다.");
        
    }

    public void GetAutoClickButton()
    {
        if (Score.gold >= hasGold_AC && autoclick == false)
        {
            Score.gold -= hasGold_AC;
            autoclick = true;
            StartCoroutine(AutoClick(0.5f));
        }
        else if (autoclick == true) Debug.Log("이미 구매된 아이템입니다.");
        else Debug.Log("골드가 부족합니다.");
    }


     클릭 시 얻는 골드가 늘어나는 골드업그레이드 아이템과 자동으로 클릭해주는 아이템을 구현하였습니다.


# 게임 내 통화 시스템

    public int gold;

    public void GetGold(int amount)
    {
        Score.gold += amount;
    }


     클릭 시에 골드재화를 얻을수 있게끔 하였습니다. 이 골드를 이용하여 여러 아이템을 구매하고 업그레이드 할 수 있습니다.

# 파티클 시스템

    public void ClickParticle()
    {
            ParticleSystem particleSystem = GameManager.Instance.EffectParticle;
            particleSystem.Play();
    }



     파티클이 나오는 함수를 클릭 이벤트에 넣어 클릭 시 정해진 파티클이 나오게끔 하였습니다.

# 사운드 이펙트

    public AudioClip clip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = this.clip;
        audioSource.Play();
    } public void OnClickButton()
    {
        **audioSource.PlayOneShot(clip);**
        GetGold(getGold);
        Score.times ++;
        particle.ClickParticle();
        //Debug.Log("click");
    }


   배경 음악과 클릭 시 클릭 사운드가 나게끔 하였습니다.
