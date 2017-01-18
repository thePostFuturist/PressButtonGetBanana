using System;

public class BananaImageWorker {

    public event Action<bool> onBananaSummon;

    public void SummonBanana()
    {
        if (onBananaSummon != null)
            onBananaSummon(true);
    }

}