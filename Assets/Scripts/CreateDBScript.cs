using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
        //Create new database with MySession name
        var ds = new DataService("MySession.db");
        //Xóa table Mysession
        ds._connection.DropTable<MySession>();
        //Tạo mới table Mysession
        ds._connection.CreateTable<MySession>();

        //Thêm thông tin vào bản
        MySession mySession = new MySession();
        mySession.ses_id = 1;
        mySession.use_id = 1;
        mySession.ses_score = 1;
        mySession.ses_time_start = DateTime.Now.ToString("y-M-d H:m:s"); ;
        mySession.ses_status = "enable";
        ds._connection.Insert(mySession);

        //Đọc dữ liệu sau khi insert vào table
        var querySessionData = ds._connection.Query<MySession>("SELECT * FROM MySession");
        Debug.Log(querySessionData.Count +"|"+ querySessionData[0].ses_time_start);
                                                                                    

    }
	
	private void ToConsole(IEnumerable<Person> people){
		foreach (var person in people) {
			ToConsole(person.ToString());
		}
	}
	
	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}
}
