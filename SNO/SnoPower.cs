using Plugins;

internal class SnoPower : ISnoPower
{
	internal uint sno;
	private readonly string code;
	private readonly string nameLocalized;
	private readonly string nameEnglish;
	private readonly string descriptionLocalized;
	private readonly string descriptionEnglish;
	private string[] runeNamesLocalized;
	private string[] runeNamesEnglish;
	private int[] iconIndexes;
	private bool hasKnownRunesValues;
	private int[] elementalDamageTypesByRune;
	private int[] weaponDamageMultipliersByRune;
	private float[] dotSecondsByRune;
	private int[] resourceCostsByRune;
	private PowerResourceCostType[] powerResourceCostTypeByRune;
	private double[] baseCoolDownByRune;
	private readonly SnoPowerIcon[] snoPowerIcon = new SnoPowerIcon[32];
	private uint normalIconTextureId;
	private ISnoPower isnoPower;

	public uint Sno
	{
		get {
			return sno;
		}
		set {
			sno = value;
		}
	}

	public string Code
	{
		get {
			return code;
		}
	}

	public string NameLocalized
	{
		get {
			return nameLocalized;
		}
	}

	public string NameEnglish
	{
		get {
			return nameEnglish;
		}
	}

	public string DescriptionLocalized
	{
		get {
			return descriptionLocalized;
		}
	}

	public string DescriptionEnglish
	{
		get {
			return descriptionEnglish;
		}
	}

	public string[] RuneNamesLocalized
	{
		get {
			return runeNamesLocalized;
		}
		set {
			runeNamesLocalized = value;
		}
	}

	public string[] RuneNamesEnglish
	{
		get {
			return runeNamesEnglish;
		}
		set {
			runeNamesEnglish = value;
		}
	}

	public int[] IconIndexes
	{
		get {
			return iconIndexes;
		}
		set {
			iconIndexes = value;
		}
	}

	public bool HasKnownRunesValues
	{
		get {
			return hasKnownRunesValues;
		}
		set {
			hasKnownRunesValues = value;
		}
	}

	public int[] ElementalDamageTypesByRune
	{
		get {
			return elementalDamageTypesByRune;
		}
		set {
			elementalDamageTypesByRune = value;
		}
	}

	public int[] WeaponDamageMultipliersByRune
	{
		get {
			return weaponDamageMultipliersByRune;
		}
		set {
			weaponDamageMultipliersByRune = value;
		}
	}

	public float[] DotSecondsByRune
	{
		get {
			return dotSecondsByRune;
		}
		set {
			dotSecondsByRune = value;
		}
	}

	public int[] ResourceCostsByRune
	{
		get {
			return resourceCostsByRune;
		}
		set {
			resourceCostsByRune = value;
		}
	}

	public PowerResourceCostType[] ResourceCostTypeByRune
	{
		get {
			return powerResourceCostTypeByRune;
		}
		set {
			powerResourceCostTypeByRune = value;
		}
	}

	public double[] BaseCoolDownByRune
	{
		get {
			return baseCoolDownByRune;
		}
		set {
			baseCoolDownByRune = value;
		}
	}

	public SnoPowerIcon[] Icons
	{
		get {
			return snoPowerIcon;
		}
	}

	public uint NormalIconTextureId
	{
		get {
			return normalIconTextureId;
		}
		set {
			normalIconTextureId = value;
		}
	}

	public ISnoPower SynergyPower
	{
		get {
			return isnoPower;
		}
		internal set {
			isnoPower = value;
		}
	}

	internal SnoPower(uint sno, string code, string nameLocalized, string nameEnglish, string descriptionLocalized, string descriptionEnglish)
	{
		this.code = code;
		this.nameLocalized = nameLocalized;
		this.nameEnglish = nameEnglish;
		this.sno = sno;
		this.descriptionLocalized = descriptionLocalized;
		this.descriptionEnglish = descriptionEnglish;
	}
}
