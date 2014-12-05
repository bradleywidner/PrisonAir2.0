using UnityEngine;
using System.Collections;

public class PrisonObstacle : MonoBehaviour
{
	public static int[] scorehitCount = new int[24];

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

	public string ObstacleTag;
	public int ObstacleType;

    private GameObject Cop;
    private Transform ObstaclePosition;
    private Transform WallPosition;

    private float HighestHeightAchievedInArc; 
    private float ObstacleDistancePastWall;
    private float HitWallAt;
    private float HitBarbedWireAt;
    private float PrisonerDistancePastWall;
    
	private int TotalArcScore;
	private int ObstacleHitScore = 0;
    private Cop CopSetup;

    void Start()
    {
		Cop = GameObject.Find("Cop");
		WallPosition = 	GameObject.Find("FrontTrackerWall").transform;
		ObstaclePosition = transform;
        CopSetup = (Cop)Cop.GetComponent(typeof(Cop));
        
		CalculateObstacleDistancePastWall();
    }
    public void CalculateArcScore()
    {
        ObstacleHitScore = 0;
        switch (ObstacleType)
        {
			// Hit per limb per criminal
            case MEGA_BOWLING_PIN:
                ObstacleHitScore = 50;
                TotalArcScore = (int) (HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[MEGA_BOWLING_PIN] += 1;
                break;
            case ROPE_SOAP:
                ObstacleHitScore = 15;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[ROPE_SOAP] += 1;
                break;
            case PRISON_BARS:
                ObstacleHitScore = 5;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[PRISON_BARS] += 1;
                break;
            case WASHING_MACHINE:
                ObstacleHitScore = 10;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[WASHING_MACHINE] += 1;
                break;
            case BENCH_PRESS_BAR:
                ObstacleHitScore = 12;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[BENCH_PRESS_BAR] += 1;
                break;
            case PRISON_ALARM:
                ObstacleHitScore = 15;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
                scorehitCount[PRISON_ALARM] += 1;
                break;
            case SPIKES:
                ObstacleHitScore = 5;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[SPIKES] += 1;
                break;
            case FIRE_RING:
                ObstacleHitScore = 30;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[FIRE_RING] += 1;
                break;
            case BOWLING_PINS:
                ObstacleHitScore = 5;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[BOWLING_PINS] += 1;
			    break;
            case TOWER:
                ObstacleHitScore = 5;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[TOWER] += 1;
                break;
            case SPOTLIGHT:
                ObstacleHitScore = 10;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[SPOTLIGHT] += 1;
                break;
            case BLIMP:
                ObstacleHitScore = 65;
				CalculateObstacleDistancePastWall();
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[BLIMP] += 1;
                break;
            case TOILET:
                ObstacleHitScore = 15;
                TotalArcScore = (int)(ObstacleDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[TOILET] += 1;
                break;
            case BARBED_WIRE:
                ObstacleHitScore = -15;
                TotalArcScore = (int)(HitBarbedWireAt + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[BARBED_WIRE] += 1;
                break;
			case EXPLOSIVE_BARREL:
				ObstacleHitScore = 10;
				TotalArcScore = (int)(HighestHeightAchievedInArc + ObstacleHitScore + ObstacleDistancePastWall);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[EXPLOSIVE_BARREL] += 1;
				break;
			case BOLT:
				ObstacleHitScore = 10;
				TotalArcScore = (int)(HighestHeightAchievedInArc + ObstacleHitScore + ObstacleDistancePastWall);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[BOLT] += 1;
				break;

			// Hit per criminal
            case WALL:
                ObstacleHitScore = 2;
				TotalArcScore = (int)(HitWallAt + ObstacleHitScore + ObstacleDistancePastWall + HighestHeightAchievedInArc);
				scorehitCount[BONUSES_TEXT] += (int)(HighestHeightAchievedInArc + ObstacleDistancePastWall);
				scorehitCount[WALL] += 1;
                break;
            case PRISON_FLOOR: // BONUS
                ObstacleHitScore = 1;
                TotalArcScore = (int)(PrisonerDistancePastWall + HighestHeightAchievedInArc + ObstacleHitScore);
				scorehitCount[BONUSES_TEXT] += TotalArcScore;
                break;
			case FRONT_WALL: // MISS
				ObstacleHitScore = -45;
				TotalArcScore = (int)(ObstacleHitScore);
				scorehitCount[MISSES_TEXT] += TotalArcScore;
				break;
			case TERRAIN: // MISS
				ObstacleHitScore = -60;
				TotalArcScore = ObstacleHitScore;
				scorehitCount[MISSES_TEXT] += TotalArcScore;
				break;
        }
        CopSetup.ApplyScoreToCop(TotalArcScore);
    }
	public int GetObstacleType()
	{
		return ObstacleType;
	}
	public string GetObstacleTag()
	{
		return ObstacleTag;
	}
    public void CalculateObstacleDistancePastWall()
    {
        ObstacleDistancePastWall = Mathf.Abs(ObstaclePosition.position.z - WallPosition.position.z);
    }
    public void SetHighestHeightAchievedInArc(float HighestHeight)
    {
        HighestHeightAchievedInArc = HighestHeight;
    }
    public void SetHitWallAtHeight(float Height)
    {
        HitWallAt = Height;
    }
    public void SetHitBarbedWireAtHeight(float Height)
    {
        HitBarbedWireAt = Height;
    }
    public void SetPrisonerDistancePastWall(float DistancePastWall)
    {
		PrisonerDistancePastWall = DistancePastWall;
    }
}
