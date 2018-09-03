using UnityEngine;
using System.Collections;

public class RankSettler : MonoBehaviour {
	int rankNum;

	/// <summary>
	/// OUTDATED, USE DIRECTLY SetEquipment
	/// </summary>
	/// <param name="rankNum">Rank number.</param>

	public void rankItem(int rankNum){
		switch (rankNum) {
		case 100021:
			GameControl.attStyle += 10;
			break;
		case 20000:
			GameControl.attStyle-= 20; 
			break;
		case 20001:
			GameControl.attStyle+= 1; 
			break; 
		case 20002:
			GameControl.attStyle+= 2; 
			break;
		case 20003:
			GameControl.attStyle+= 3; 
			break;
		case 20004:
			GameControl.attStyle+= 6; 
			break;
		case 20005:
			GameControl.attStyle+= 6; 
			break;
		case 20006:
			GameControl.attStyle+= 8; 
			break;
		case 20007:
			GameControl.attStyle+= 1; 
			break;
		case 20008:
			GameControl.attStyle+= 3; 
			break;
		case 20009:
			GameControl.attStyle+= 5; 
			break;
		case 20010:
			GameControl.attStyle+= 12; 
			break;
		case 20011:
			GameControl.attStyle+= 16; 
			break;
		case 20012:
			GameControl.attStyle-= 5; 
			break;
		case 20013:
			GameControl.attStyle+= -8; 
			break;
		case 20014:
			GameControl.attStyle+= 20;
			break;
		case 30000:
			GameControl.attStyle+= 0; 
			break;
		case 30001:
			GameControl.attStyle+= 2; 
			break;
		case 30002:
			GameControl.attStyle+= 2; 
			break;
		case 30003:
			GameControl.attStyle+= 0; 
			break;
		case 30004:
			GameControl.attStyle+= 2; 
			break;
		case 40000:
			GameControl.attStyle+= 0; 
			break;
		case 40001:
			GameControl.attStyle-= 2; 
			break;
		case 40002:
			GameControl.attStyle+= 1; 
			break;
		case 40003:
			GameControl.attStyle+= 2; 
			break;
		case 40004:
			GameControl.attStyle+= 4; 
			break;
		case 50000:
			GameControl.attStyle+= 0; 
			break;
		case 50001:
			GameControl.attStyle+= 0; 
			break;
		case 50002:
			GameControl.attStyle+= 2; 
			break;
		case 50003:
			GameControl.attStyle-= 120; 
			break;
		case 50004:
			GameControl.attStyle-= 2; 
			break;
		case 50005:
			GameControl.attStyle+= 2; 
			break;
		case 60000:
			GameControl.attStyle+= 0; 
			break;
		case 60001:
			GameControl.attStyle+= 1; 
			break;
		case 60002:
			GameControl.attStyle+= 1; 
			break;
		case 60003:
			GameControl.attStyle+= 0; 
			break;
		case 60004:
			GameControl.attStyle+= 2; 
			break;
		case 60005:
			GameControl.attStyle+= 3; 
			break;
		case 70000:
			GameControl.attStyle+= 0; 
			break;
		case 70001:
			GameControl.attStyle+= 2; 
			break;
		case 70002:
			GameControl.attStyle-= 1; 
			break;
		case 70003:
			GameControl.attStyle+= 0; 
			break;
		case 70004:
			GameControl.attStyle-= 2; 
			break;
		case 70005:
			GameControl.attStyle+= 0; 
			break;
		case 70006:
			GameControl.attStyle-= 1; 
			break;
		case 80000:
			GameControl.attStyle+= 0; 
			break;
		case 80001:
			GameControl.attStyle+= 0; 
			break;
		case 80002:
			GameControl.attStyle+= 1; 
			break;
		case 80003:
			GameControl.attStyle+= 1; 
			break;
		case 80004:
			GameControl.attStyle-= 1; 
			break;
		case 80005:
			GameControl.attStyle+= 2; 
			break;
		case 90000:
			GameControl.attStyle+= 0; 
			break;
		case 90001:
			GameControl.attStyle+= 1; 
			break;
		case 90002:
			GameControl.attStyle-= 5; 
			break;
		case 90003:
			GameControl.attStyle+= 1; 
			break;
		case 90004:
			GameControl.attStyle+= 3; 
			break;
		case 100004:
			GameControl.attStyle+= 10; 

			break;
		default:
			break;


		}

	}






}
