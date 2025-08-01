using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheHuntIsOn.HkmpAddon;

[JsonConverter(typeof(StringEnumConverter))]
public enum NetEvent
{
    VengefulSpirit = 0,
    DesolateDive,
    HowlingWraiths,
    ShadeSoul,
    DescendingDark,
    AbyssShriek,
    MothwingCloak,
    MantisClaw,
    CrystalHeart,
    MonarchWings,
    IsmasTear,
    ShadeCloak,
    DreamNail,
    CycloneSlash,
    DashSlash,
    GreatSlash,
    Mask,
    SoulVessel,
    Movement1,
    Movement2,
    Movement3,
    Movement4,
    Movement5,
    Movement6,
    Dreamer,
    Tram,
    Stag,
    StagDirtmouth,
    StagCrossroads,
    StagGreenpath,
    StagFungalWastes,
    StagCityStorerooms,
    StagRestingGrounds,
    StagKingsStation,
    StagDeepnest,
    StagRoyalGardens,
    StagHiddenStation,
    StagStagNest,
    Toll,
    Grub,
    DreamWarriorStarted,
    DreamWarriorAbsorbed,
    ShopPurchase,
    NailUpgrade,
    RelicSale,
    LeverHit,
    CharmNotch,
    CharmCollected,
    FinalBossKilled,
    RunnerDeath,
    RunnerDreamDeath,
    PowerUp,
    BossKilled
}