using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour 
{
	const int SPIKES =              0;
	const int FIRE_RING =           1;
	const int BOWLING_PINS =        2;
	const int BLIMP =               3;
	const int TOWER =               4;
	const int SPOTLIGHT =           5;
	const int TOILET =              6;
	const int WALL =                7;
	const int BARBED_WIRE =         8;
	const int PRISON_FLOOR =        9;
	const int TERRAIN =             10;
	const int MEGA_BOWLING_PIN =    11;
	const int ROPE_SOAP =           12;
	const int PRISON_BARS =         13;
	const int WASHING_MACHINE =     14;
	const int BENCH_PRESS_BAR =     15;
	const int PRISON_ALARM =        16;
	const int FRONT_WALL =			17;
	const int EXPLOSIVE_BARREL =    18;
	const int BONUSES_TEXT =		20;
	const int MISSES_TEXT = 		21;
	const int MULTIPLER_TEXT = 		22;
	const int BOLT = 				23;
	const int PRISON_BED = 			24;
	const int CARDBOARD = 			25;
	const int BOAT = 				26;

	public Text spikeText;
	public Text fireRingText;
	public Text bowlingPinText;
	public Text blimpText;
	public Text towerText;
	public Text spotLightText;
	public Text toiletText;
	public Text cardboardText;
    public Text prisonBarsText;
	public Text prisonBedText;
	public Text boltText;
    public Text prisonAlarmText;
	public Text explosiveBarrelText;

	public Text missesText;
	public Text bonusesText;
	public Text multiplerText;
	public Text finalScore;
	public Text megaBowlingPinText;
	void Start () 
	{
		explosiveBarrelText.text = PrisonObstacle.scorehitCount[EXPLOSIVE_BARREL].ToString();
		cardboardText.text = PrisonObstacle.scorehitCount[CARDBOARD].ToString();
		spikeText.text = PrisonObstacle.scorehitCount[SPIKES].ToString();
		fireRingText.text = PrisonObstacle.scorehitCount[FIRE_RING].ToString();
		bowlingPinText.text = PrisonObstacle.scorehitCount[BOWLING_PINS].ToString();
		blimpText.text = PrisonObstacle.scorehitCount[BLIMP].ToString();
		towerText.text = PrisonObstacle.scorehitCount[TOWER].ToString();
		spotLightText.text = PrisonObstacle.scorehitCount[SPOTLIGHT].ToString();
		toiletText.text = PrisonObstacle.scorehitCount[TOILET].ToString();
		boltText.text = PrisonObstacle.scorehitCount[BOLT].ToString ();
		prisonAlarmText.text = PrisonObstacle.scorehitCount[PRISON_ALARM].ToString(); 
        prisonBarsText.text = PrisonObstacle.scorehitCount[PRISON_BARS].ToString();
		prisonBedText.text = PrisonObstacle.scorehitCount[PRISON_BED].ToString();
		megaBowlingPinText.text = PrisonObstacle.scorehitCount[MEGA_BOWLING_PIN].ToString();

        missesText.text = "Misses" + "\n" + PrisonObstacle.scorehitCount[MISSES_TEXT].ToString();
		bonusesText.text = "Bonuses" + "\n" + PrisonObstacle.scorehitCount[BONUSES_TEXT].ToString();
		multiplerText.text = "Mega Multiplier" + "\n x " + PrisonObstacle.scorehitCount[MULTIPLER_TEXT].ToString();
        finalScore.text = "Total Score" + "\n" +UI.totalScoreAcheived.ToString();
	}
}