THE ITEM FILTER EVALUATES ITEMS AND RESULTS IN A LOGICAL VALUE MEANING "KEEP" OR "SELL"

FILES
-----
The rules live in %LOCALAPPDATA%\RiftAssistant\settings\item_filter_sc.json (softcore) and item_filter_hc.json (hardcore), next to the other settings.
A file that does not exist is created from the defaults built into the executable, so deleting a file resets it.
Files are checked once per second while the program runs and are reloaded as soon as they change. There is no need to restart.
If a file cannot be parsed, the error is written to logs\exceptions.txt in the same folder and the previous rules stay active.
A single rule with an error is skipped and logged, the other rules still apply.
The JSON may contain // comments and trailing commas. Unknown property names are an error, so typos do not silently disable a rule.

FORMAT
------
{
	"Definitions": { "name": "condition & condition" },
	"Rules": [
		{ "Comment": "optional note", "Group": "helm", "Decision": "Keep", "Enabled": true, "Conditions": ["main_stat+700", "*name*"] }
	]
}

- Rules are evaluated in order, from top to bottom.
- If a rule matches (the item is in its Group and all Conditions are true) and its Decision is "Keep", the item is considered "KEEP" and the evaluation is stopped.
- If a rule matches and its Decision is "Sell", the item is considered "SELL" (force sell) and the evaluation is stopped.
- If no rule matches, the item is considered "SELL".
- Decision is "Keep" or "Sell". It defaults to "Keep".
- Enabled defaults to true. Set it to false to turn a rule off without deleting it.
- Group is an item group name, or "all" to match every item.
- Conditions are all required (logical AND). Each entry is one condition, or a *definition* reference.
- Definitions are reusable condition snippets. Writing *name* inside a condition replaces it with the definition text, which may contain several conditions joined by &.
operators:
+   more or equal
=   strict equal
<   less
at_least[N, a, b, c, d, ...]  evaluates true when at least N conditions are true from the set of a, b, c, d, ...

quality values:
3-5 = magic
6 = rare (4 stat)
7 = rare (5 stat)
8 = rare (6 stat)
9 = legendary, set

combo stats:
DPS (available on weapons and offhands, calculated from (DMG_LO+DMG_HI)/2, or (OFFH_DMG_LO+OFFH_DMG_ADD/2))
MAIN_STAT (highest roll of STR, DEX, INT)
MAIN_STAT_VITA (MAIN_STAT + VITA)
ANYRES (highest roll of any elemental resist)
ALLRES_ARMOR (ALLRES + ARMOR/10)
ALLRES_ANYRES (ALLRES + ARMOR/10 + ANYRES)

processed attributes
--------------------

REG_MANA, REG_AP, REG_FURY, REG_SPIRIT, REG_HATRED, REG_DISC, REG_WRATH
MAX_MANA, MAX_AP, MAX_FURY, MAX_SPIRIT, MAX_HATRED, MAX_DISC, MAX_WRATH

LOH, LOK, LSTEAL - life on hit/kill, life steal
IAS - on armors (see: AS_EXTR on weapons)

STR, DEX, INT, VITA, LIFE, B_ARMOR, E_ARMOR, T_ARMOR, DURA, GF, MF, QUALITY, MOVE
HPGLOBE, HPREG, PICKUP,
LVLREQ, LVLREQRED, EXPBONUS, GEMQUALITY, CCRED, INDEST

ALLRES, ANYRES, PH_RES, F_RES, L_RES, C_RES, P_RES, A_RES

DMG_LO, DMG_HI, CRIT, CRITDMG, APOC, DMG_PBONUS
OFFH_DMG_LO, OFFH_DMG_ADD - this is tricky: "+35-90 Damage" equals to: OFFH_DMG_LO=35 and OFFH_DMG_ADD=55
AS_WEAP - total weapon attack speed (x Attacks per Second)
AS_EXTR - weapons' "Increases Attack Speed by x%" (already calculated into AS_WEAP)
DMG_PBONUS - weapon extra damage (+x% Damage)
SKILLDMG - Increases [skill] Damage by X%
SDMG_ANY, SDMG_PH, SDMG_F, SDMG_L, SDMG_C, SDMG_P, SDMG_A, SDMG_H - ...skills deal X% more damage
RESCOSTRED - Reduces all resource costs by 5%
CDRED - Reduces cooldown of all skills by 5%
ELITEDAM - Increases damage against elites by 5%
ELITEDAMRED - Reduces damage from elites by 5%

B_BLOCK, E_BLOCK, T_BLOCK- base/extra/total block %
THORNS - damage to melee attackers
AREADMG - area damage on hit
SOCK - socket count

CUBED - item is already in the Kanai Cube
CAN_CUBED - item is not in the Kanai Cube but it could be